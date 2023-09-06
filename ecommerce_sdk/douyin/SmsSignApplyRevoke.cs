namespace ecommerce.sdk.douyin;

[Description("撤销短信签名申请单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","628005100:status is not reviewing","isv.business-failed:628005100","请根据错误信息描述检查")]
public class SmsSignApplyRevokeReq : IDouyinReq<SmsSignApplyRevokeRsp>
{

	public string GetMethod() { return "sms.sign.apply.revoke"; }

	public string GetUrl() { return "/sms/sign/apply/revoke"; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("sms_sign_apply_id")]
	[Description("申请单id")]
	[NotNull]
	public string SmsSignApplyId { get; set; }
}

[Description("撤销短信签名申请单")]
public class SmsSignApplyRevokeRsp
{
	[JsonPropertyName("code")]
	[Description("是否成功 0表示成功")]
	public long Code { get; set; }

	[JsonPropertyName("message")]
	[Description("说明")]
	public string Message { get; set; }
}
