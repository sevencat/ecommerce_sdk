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
		var sb = new StringBuilder();
		p.Gen(56, sb, 0);
		var x = sb.ToString();
		Console.WriteLine(x);
	}

	private SnapContext db;
	private HttpClient hc;
	private IMapper mapper;

	private DouyinGenApi genApi;

	public void Gen(int id, StringBuilder sb, int tabnum)
	{
		var item = db.DouyinSdkItems.First(x => x.id == id);
		genApi.Gen(item, sb, tabnum);
	}

	public void Init()
	{
		genApi = new DouyinGenApi();
		var config = new MapperConfiguration(cfg => { cfg.CreateMap<DouyinSdkIdxRsp.ApiItem, DouyinSdkItem>(); });
		mapper = config.CreateMapper();
		db = new SnapContext();
		hc = new HttpClient();
	}

	public void SnapDetail()
	{
		while (true)
		{
			try
			{
				SnapOnce();
			}
			catch (Exception e)
			{
				Console.WriteLine("出错了:{0},{1}", e.Message, e.StackTrace);
			}

			Task.Delay(5000).Wait();
		}
	}

	public void SnapOnce()
	{
		var items = db.DouyinSdkItems.Where(x => x.snap < 100).Take(10).ToList();
		if (!items.Any())
			return;
		foreach (var item in items)
		{
			SnapDetail(item);
			Task.Delay(100).Wait();
		}
	}

	public void SnapDetail(DouyinSdkItem item)
	{
		Console.WriteLine("开始抓取:{0}.{1},{2},{3}", item.dirId, item.id, item.title, item.subtitle);
		// https://op.jinritemai.com/doc/external/open/queryDocArticleDetail?articleId=4257
		var url = "https://op.jinritemai.com/doc/external/open/queryDocArticleDetail?articleId=" + item.id;
		var s = hc.GetStringAsync(url).Result;
		var jobj = JsonNode.Parse(s) as JsonObject;
		var ctx = (jobj["data"]["article"]["content"]).GetValue<string>();

		item.ctx = ctx;
		item.snap = 100;
		db.SaveChanges();
		return;
	}

	public void SnapIndex()
	{
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
				var dbitem = mapper.Map<DouyinSdkItem>(api);
				if (db.DouyinSdkItems.First(x => x.id == dbitem.id) != null)
					db.DouyinSdkItems.Add(dbitem);
			}
		}
	}
}