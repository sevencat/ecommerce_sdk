namespace ecommerce.sdk.douyin;

[Description("支持抖客删除PID，需要抖客百应授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","需【抖客】角色授权后访问","isv.business-failed:4198","需【抖客】角色授权后访问")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
public class BuyinInstitutePidDelReq : IDouyinReq<BuyinInstitutePidDelRsp>
{

	public string GetMethod() { return "buyin.institutePidDel"; }

	public string GetUrl() { return "/buyin/institutePidDel"; }

	[JsonPropertyName("pids")]
	[Description("PID列表，多个用,分隔，最多200个")]
	[NotNull]
	public string Pids { get; set; }
}

[Description("支持抖客删除PID，需要抖客百应授权")]
public class BuyinInstitutePidDelRsp
{
}
