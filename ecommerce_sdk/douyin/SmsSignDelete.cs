namespace ecommerce.sdk.douyin;

[Description("删除短信签名")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","响应结果不符合预期","isv.business-failed:628005100","请根据错误信息描述检查")]
public class SmsSignDeleteReq : IDouyinReq<SmsSignDeleteRsp>
{

	public string GetMethod() { return "sms.sign.delete"; }

	public string GetUrl() { return "/sms/sign/delete"; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("sign")]
	[Description("签名")]
	[NotNull]
	public string Sign { get; set; }
}

[Description("删除短信签名")]
public class SmsSignDeleteRsp
{
	[JsonPropertyName("code")]
	[Description("是否成功 0表示成功")]
	public long Code { get; set; }

	[JsonPropertyName("message")]
	[Description("说明")]
	public string Message { get; set; }
}
