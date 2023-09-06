namespace ecommerce.sdk.douyin;

[Description("支持PID自定义字段的编辑能力，需要独立抖客百应授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效 PID","isv.parameter-invalid:4102","参数校验失败：无效 PID")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","推广位名称重复，请更换","isv.parameter-invalid:4204","推广位名称重复，请更换")]
public class BuyinDoukePidEditReq : IDouyinReq<BuyinDoukePidEditRsp>
{

	public string GetMethod() { return "buyin.doukePidEdit"; }

	public string GetUrl() { return "/buyin/doukePidEdit"; }

	[JsonPropertyName("pid")]
	[Description("PID")]
	[NotNull]
	public string Pid { get; set; }

	[JsonPropertyName("site_name")]
	[Description("推广位名称，不能和已有的重复(最长10个字符)")]
	[NotNull]
	public string SiteName { get; set; }
}

[Description("支持PID自定义字段的编辑能力，需要独立抖客百应授权")]
public class BuyinDoukePidEditRsp
{
}
