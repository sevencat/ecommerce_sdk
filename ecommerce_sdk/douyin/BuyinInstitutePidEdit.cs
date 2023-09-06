namespace ecommerce.sdk.douyin;

[Description("支持PID自定义字段的编辑能力，需要抖客百应授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","推广位名称重复，请更换","isv.parameter-invalid:1054","推广位名称重复，请更换")]
[DouyinRetCode(40004,"非法的参数","无效 PID","isv.parameter-invalid:1039","无效 PID")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","需【抖客】角色授权后访问","isv.business-failed:4198","需【抖客】角色授权后访问")]
public class BuyinInstitutePidEditReq : IDouyinReq<BuyinInstitutePidEditRsp>
{

	public string GetMethod() { return "buyin.institutePidEdit"; }

	public string GetUrl() { return "/buyin/institutePidEdit"; }

	[JsonPropertyName("pid")]
	[Description("PID")]
	[NotNull]
	public string Pid { get; set; }

	[JsonPropertyName("site_name")]
	[Description("推广位名称，不能和已有的重复(最长10个字符)")]
	[NotNull]
	public string SiteName { get; set; }
}

[Description("支持PID自定义字段的编辑能力，需要抖客百应授权")]
public class BuyinInstitutePidEditRsp
{
}
