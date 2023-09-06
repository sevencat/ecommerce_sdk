using System.Data.SQLite;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using AutoMapper;

namespace douyinsdkgen;

//https://op.jinritemai.com/doc/external/open/QueryDocDirTreeNew?dirId=3&withArticleList=true&articleOrderType=3
internal class Program
{
	public static void Main(string[] args)
	{
		var p = new Program();
		p.Init();
		p.SnapIndex();
		p.SnapDetail();
		p.GenAllApi("douyin");
	}

	private IFreeSql db;
	private HttpClient hc;
	private IMapper mapper;

	private DouyinGenApi genApi;
	public const string ns = "ecommerce.sdk.douyin";

	public void GenAllApi(string subdir)
	{
		var exedir = AppDomain.CurrentDomain.BaseDirectory;
		var clsdir = Path.Combine(exedir, subdir);
		Directory.CreateDirectory(clsdir);
		var items = db.Select<TDouyinSdkItem>().ToList();
		foreach (var item in items)
		{
			var sb = new StringBuilder();
			var fname = DouyinGenApi.ToCamelCase(item.title);
			try
			{
				genApi.Gen(item, ns, sb);
				var clsfn = Path.Combine(clsdir, fname + ".cs");
				File.Delete(clsfn);
				File.WriteAllText(clsfn, sb.ToString());
			}
			catch (JsonException e)
			{
				Console.WriteLine("生成失败,json解析失败:{0},{1},{2}", item.id, item.title, e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine("生成失败:{0},{1},{2},{3}", item.id, item.title, e.Message, e.StackTrace);
			}
		}
	}

	public void Gen(int id, StringBuilder sb, int tabnum)
	{
		var item = db.Select<TDouyinSdkItem>().Where(x => x.id == id).First();
		genApi.Gen(item, ns, sb);
	}

	public void Init()
	{
		genApi = new DouyinGenApi();
		var config = new MapperConfiguration(cfg => { cfg.CreateMap<DouyinSdkIdxRsp.ApiItem, TDouyinSdkItem>(); });
		mapper = config.CreateMapper();
		db = CreateDb();
		hc = new HttpClient();
		db.CodeFirst.SyncStructure<TDouyinSdkItem>();
	}

	public void SnapDetail()
	{
		while (true)
		{
			try
			{
				if (!SnapOnce())
				{
					Console.WriteLine("接口全部抓取");
					return;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("出错了:{0},{1}", e.Message, e.StackTrace);
			}

			Task.Delay(5000).Wait();
		}
	}

	public bool SnapOnce()
	{
		var items = db.Select<TDouyinSdkItem>().Where(x => x.snap < 100).Limit(5).ToList();
		if (!items.Any())
			return false;
		foreach (var item in items)
		{
			SnapDetail(item);
			Task.Delay(100).Wait();
		}

		return true;
	}

	public void SnapDetail(TDouyinSdkItem item)
	{
		Console.WriteLine("开始抓取:{0}.{1},{2},{3}", item.dirId, item.id, item.title, item.subtitle);
		// https://op.jinritemai.com/doc/external/open/queryDocArticleDetail?articleId=4257
		var url = "https://op.jinritemai.com/doc/external/open/queryDocArticleDetail?articleId=" + item.id;
		var s = hc.GetStringAsync(url).Result;
		var jobj = JsonNode.Parse(s) as JsonObject;
		var ctx = (jobj["data"]["article"]["content"]).GetValue<string>();
		db.Update<TDouyinSdkItem>()
			.Set(x => x.ctx, ctx)
			.Set(x => x.snap, 100)
			.Where(x => x.id == item.id)
			.ExecuteAffrows();
		return;
	}

	public void SnapIndex()
	{
		if (db.Select<TDouyinSdkItem>().Count() > 0)
		{
			Console.WriteLine("接口列表已抓取");
			return;
		}

		Console.WriteLine("开始抓取接口列表");
		var idxurl =
			"https://op.jinritemai.com/doc/external/open/QueryDocDirTreeNew?dirId=3&withArticleList=true&articleOrderType=3";
		var s = hc.GetStringAsync(idxurl).Result;
		var apis = JsonSerializer.Deserialize<DouyinSdkIdxRsp>(s);
		foreach (var dir in apis.data.dirs)
		{
			if (dir.articles == null)
				continue;
			foreach (var api in dir.articles)
			{
				var dbitem = mapper.Map<TDouyinSdkItem>(api);
				dbitem.dirName = dir.name;
				if (db.Select<TDouyinSdkItem>().Where(x => x.id == dbitem.id).Count() == 0)
					db.Insert(dbitem).ExecuteAffrows();
			}
		}
	}

	public IFreeSql CreateDb()
	{
		var exedir = AppDomain.CurrentDomain.BaseDirectory;
		var dbfn = Path.Combine(exedir, "sdk_douyin.db");
		if (!File.Exists(dbfn))
		{
			SQLiteConnection.CreateFile(dbfn);
		}

		var dbblder = new SQLiteConnectionStringBuilder
		{
			Pooling = true,
			JournalMode = SQLiteJournalModeEnum.Wal,
			PageSize = 32 * 1024,
			DataSource = dbfn
		};
		var fsql = new FreeSql.FreeSqlBuilder()
			.UseConnectionString(FreeSql.DataType.Sqlite, dbblder.ToString())
			.UseAutoSyncStructure(false) //自动创建、迁移实体表结构
			.Build();
		return fsql;
	}
}