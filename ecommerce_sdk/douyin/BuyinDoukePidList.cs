namespace ecommerce.sdk.douyin;

[Description("独立抖客查看自己的PID列表，需要抖客授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","推广位没有找到","isv.business-failed:4205","推广位没有找到")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","需【独立抖客】角色授权后访问","isv.business-failed:8198","需【独立抖客】角色授权后访问")]
public class BuyinDoukePidListReq : IDouyinReq<BuyinDoukePidListRsp>
{

	public string GetMethod() { return "buyin.doukePidList"; }

	public string GetUrl() { return "/buyin/doukePidList"; }

	[JsonPropertyName("page")]
	[Description("页数，默认从1开始")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页大小。默认100，最大2000")]
	public long? PageSize { get; set; }

	[JsonPropertyName("media_type")]
	[Description("推广媒体类型，0:其他, 1:微信, 2:QQ, 3:微博, 4:抖音, 5:头条")]
	public int? MediaType { get; set; }

	[JsonPropertyName("pid")]
	[Description("PID")]
	public string Pid { get; set; }

	[JsonPropertyName("site_name")]
	[Description("推广位名称，匹配查询")]
	public string SiteName { get; set; }
}

[Description("独立抖客查看自己的PID列表，需要抖客授权")]
public class BuyinDoukePidListRsp
{
	[JsonPropertyName("data")]
	[Description("结果")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("total")]
		[Description("总数")]
		public int Total { get; set; }

		[JsonPropertyName("pids")]
		[Description("PID列表")]
		public List<PidsItem> Pids { get; set; }

		public class PidsItem
		{
			[JsonPropertyName("pid")]
			[Description("PID")]
			public string Pid { get; set; }

			[JsonPropertyName("media_type")]
			[Description("推广媒体类型")]
			public int MediaType { get; set; }

			[JsonPropertyName("media_id")]
			[Description("渠道ID")]
			public long MediaId { get; set; }

			[JsonPropertyName("media_name")]
			[Description("渠道名称")]
			public string MediaName { get; set; }

			[JsonPropertyName("site_name")]
			[Description("推广位名称")]
			public string SiteName { get; set; }

			[JsonPropertyName("create_time")]
			[Description("创建时间")]
			public long CreateTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("更新时间")]
			public long UpdateTime { get; set; }
		}
	}
}
