namespace ecommerce.sdk.douyin;

[Description("撤销短信模板申请单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","响应结果不符合预期","isv.business-failed:628005100","请根据错误信息描述检查")]
public class SmsTemplateRevokeReq : IDouyinReq<SmsTemplateRevokeRsp>
{

	public string GetMethod() { return "sms.template.revoke"; }

	public string GetUrl() { return "/sms/template/revoke"; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("sms_template_apply_id")]
	[Description("短信模板申请单id")]
	[NotNull]
	public string SmsTemplateApplyId { get; set; }
}

[Description("撤销短信模板申请单")]
public class SmsTemplateRevokeRsp
{
	[JsonPropertyName("code")]
	[Description("是否成功 0表示成功")]
	public long Code { get; set; }

	[JsonPropertyName("message")]
	[Description("说明")]
	public string Message { get; set; }
}
