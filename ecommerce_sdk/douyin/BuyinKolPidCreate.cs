namespace ecommerce.sdk.douyin;

[Description("支持达人PID创建，需要达人授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","推广位名称重复，请更换","isv.parameter-invalid:1054","推广位名称重复，请更换")]
[DouyinRetCode(40004,"非法的参数","无效渠道类型","isv.parameter-invalid:1051","无效渠道类型")]
[DouyinRetCode(40004,"非法的参数","无效渠道名称","isv.parameter-invalid:1050","无效渠道名称")]
[DouyinRetCode(40004,"非法的参数","无效推广位名称","isv.parameter-invalid:1049","无效推广位名称")]
[DouyinRetCode(40004,"非法的参数","没有此渠道","isv.parameter-invalid:1048","没有此渠道")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","渠道名称已存在，渠道类型不一致","isv.business-failed:1076","渠道名称已存在，渠道类型不一致")]
[DouyinRetCode(50002,"业务处理失败","最多可创建2000个推广位","isv.business-failed:1052","请检查推广位数量")]
public class BuyinKolPidCreateReq : IDouyinReq<BuyinKolPidCreateRsp>
{

	public string GetMethod() { return "buyin.kolPidCreate"; }

	public string GetUrl() { return "/buyin/kolPidCreate"; }

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

[Description("支持达人PID创建，需要达人授权")]
public class BuyinKolPidCreateRsp
{
	[JsonPropertyName("pid")]
	[Description("达人PID")]
	public string Pid { get; set; }
}
