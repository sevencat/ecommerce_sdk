namespace ecommerce.sdk.douyin;

[Description("支持抖客PID创建，需要抖客授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效渠道类型","isv.parameter-invalid:1051","请检查渠道类型")]
[DouyinRetCode(40004,"非法的参数","无效渠道名称","isv.parameter-invalid:1050","请检查渠道名称")]
[DouyinRetCode(40004,"非法的参数","无效推广位名称","isv.parameter-invalid:1049","请检查推广位名称")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","推广位名称重复，请更换","isv.business-failed:1054","请检查推广位名称")]
[DouyinRetCode(50002,"业务处理失败","没有此渠道","isv.business-failed:1048","请检查渠道信息")]
[DouyinRetCode(50002,"业务处理失败","最多可创建2000个推广位","isv.business-failed:1052","最多可创建2000个推广位")]
[DouyinRetCode(50002,"业务处理失败","需【抖客】角色授权后访问","isv.business-failed:4198","需【抖客】角色授权后访问")]
public class BuyinInstitutePidCreateReq : IDouyinReq<BuyinInstitutePidCreateRsp>
{

	public string GetMethod() { return "buyin.institutePidCreate"; }

	public string GetUrl() { return "/buyin/institutePidCreate"; }

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

[Description("支持抖客PID创建，需要抖客授权")]
public class BuyinInstitutePidCreateRsp
{
	[JsonPropertyName("pid")]
	[Description("机构PID")]
	public string Pid { get; set; }
}
