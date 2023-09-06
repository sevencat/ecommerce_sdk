namespace ecommerce.sdk.douyin;

[Description("支持独立抖客PID创建，需要独立抖客授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效渠道类型","isv.parameter-invalid:4201","无效渠道类型")]
[DouyinRetCode(40004,"非法的参数","无效渠道名称","isv.parameter-invalid:4200","无效渠道名称")]
[DouyinRetCode(40004,"非法的参数","最多可创建2000个推广位","isv.parameter-invalid:4202","最多可创建2000个推广位")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","没有此渠道","isv.business-failed:4198","没有此渠道")]
[DouyinRetCode(40004,"非法的参数","需【独立抖客】角色授权后访问","isv.parameter-invalid:8198","需【独立抖客】角色授权后访问")]
[DouyinRetCode(50002,"业务处理失败","无效推广位名称","isv.business-failed:4199","无效推广位名称")]
public class BuyinDoukePidCreateReq : IDouyinReq<BuyinDoukePidCreateRsp>
{

	public string GetMethod() { return "buyin.doukePidCreate"; }

	public string GetUrl() { return "/buyin/doukePidCreate"; }

	[JsonPropertyName("media_type")]
	[Description("推广媒体类型，0:其他, 1:微信, 2:QQ, 3:微博, 4:抖音, 5:头条")]
	[NotNull]
	public int? MediaType { get; set; }

	[JsonPropertyName("media_name")]
	[Description("渠道名称，没有media_id时自动创建渠道；存在media_id时无效")]
	public string MediaName { get; set; }

	[JsonPropertyName("media_id")]
	[Description("渠道ID，和media_name二选一")]
	public long? MediaId { get; set; }

	[JsonPropertyName("site_name")]
	[Description("推广位名称(最长10个字符)")]
	[NotNull]
	public string SiteName { get; set; }
}

[Description("支持独立抖客PID创建，需要独立抖客授权")]
public class BuyinDoukePidCreateRsp
{
	[JsonPropertyName("pid")]
	[Description("抖客PID")]
	public string Pid { get; set; }
}
