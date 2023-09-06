namespace ecommerce.sdk.douyin;

[Description("支持PID自定义字段的编辑能力，需要达人百应授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","推广位名称重复，请更换","isv.parameter-invalid:1054","推广位名称重复，请更换")]
[DouyinRetCode(40004,"非法的参数","无效推广位名称","isv.parameter-invalid:1049","无效推广位名称")]
[DouyinRetCode(40004,"非法的参数","无效 PID","isv.parameter-invalid:1039","无效 PID")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","推广位没有找到","isv.business-failed:1055","推广位没有找到")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
public class BuyinKolPidEditReq : IDouyinReq<BuyinKolPidEditRsp>
{

	public string GetMethod() { return "buyin.kolPidEdit"; }

	public string GetUrl() { return "/buyin/kolPidEdit"; }

	[JsonPropertyName("pid")]
	[Description("PID")]
	[NotNull]
	public string Pid { get; set; }

	[JsonPropertyName("site_name")]
	[Description("推广位名称，不能和已有的重复(最长10个字符)")]
	[NotNull]
	public string SiteName { get; set; }
}

[Description("支持PID自定义字段的编辑能力，需要达人百应授权")]
public class BuyinKolPidEditRsp
{
}
