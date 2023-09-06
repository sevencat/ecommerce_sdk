namespace ecommerce.sdk.douyin;

[Description("支持达人PID删除，需要达人百应授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","参数校验失败","isv.business-failed:257","参数校验失败")]
public class BuyinKolPidDelReq : IDouyinReq<BuyinKolPidDelRsp>
{

	public string GetMethod() { return "buyin.kolPidDel"; }

	public string GetUrl() { return "/buyin/kolPidDel"; }

	[JsonPropertyName("pids")]
	[Description("PID列表，多个用,分隔，最多200个")]
	[NotNull]
	public string Pids { get; set; }
}

[Description("支持达人PID删除，需要达人百应授权")]
public class BuyinKolPidDelRsp
{
}
