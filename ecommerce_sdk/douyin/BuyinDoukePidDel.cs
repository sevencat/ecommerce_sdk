namespace ecommerce.sdk.douyin;

[Description("支持独立抖客删除PID，需要独立抖客百应授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","需【独立抖客】角色授权后访问","isv.parameter-invalid:8198","需【独立抖客】角色授权后访问")]
public class BuyinDoukePidDelReq : IDouyinReq<BuyinDoukePidDelRsp>
{

	public string GetMethod() { return "buyin.doukePidDel"; }

	public string GetUrl() { return "/buyin/doukePidDel"; }

	[JsonPropertyName("pids")]
	[Description("PID列表，多个用,分隔，最多200个")]
	[NotNull]
	public string Pids { get; set; }
}

[Description("支持独立抖客删除PID，需要独立抖客百应授权")]
public class BuyinDoukePidDelRsp
{
}
