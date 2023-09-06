namespace ecommerce.sdk.douyin;

[Description("提交短信模板申请单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","7:模板中不允许包含【】等","isv.parameter-invalid:7","请根据错误码描述检查请求参数")]
[DouyinRetCode(50002,"业务处理失败","响应结果不符合预期","isv.business-failed:628005100","请根据错误信息描述检查")]
public class SmsTemplateApplyReq : IDouyinReq<SmsTemplateApplyRsp>
{

	public string GetMethod() { return "sms.template.apply"; }

	public string GetUrl() { return "/sms/template/apply"; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("template_type")]
	[Description("CN_NTC 国内通知短信 CN_MKT 国内营销短信（营销短信将自带退订功能） CN_OTP 国内验证码")]
	[NotNull]
	public string TemplateType { get; set; }

	[JsonPropertyName("template_name")]
	[Description("短信模板名称")]
	[NotNull]
	public string TemplateName { get; set; }

	[JsonPropertyName("template_content")]
	[Description("短信模板内容： 英文短信：整条短信（包括签名+模板+变量中的内容）最多支持140个英文字符，超出将按140个字符截取为多条短信进行发送，费用按截取的条数收费； 非英文短信：整条短信（包括签名+模板+变量中的内容）最多支持70字符，超出将按70个字符截取为多条短信进行发送，费用按截取的条数收费；")]
	[NotNull]
	public string TemplateContent { get; set; }
}

[Description("提交短信模板申请单")]
public class SmsTemplateApplyRsp
{
	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	public string SmsAccount { get; set; }

	[JsonPropertyName("template_content")]
	[Description("短信模板内容： 英文短信：最多支持140个英文字符，超出将按140个字符截取为多条短信进行发送，费用按截取的条数收费； 非英文短信：最多支持140个英文字符，超出将按140个字符截取为多条短信进行发送，费用按截取的条数收费；")]
	public string TemplateContent { get; set; }

	[JsonPropertyName("template_name")]
	[Description("短信模版名称")]
	public string TemplateName { get; set; }

	[JsonPropertyName("sms_template_id")]
	[Description("模版id")]
	public string SmsTemplateId { get; set; }

	[JsonPropertyName("sms_template_apply_id")]
	[Description("短信模板申请单id")]
	public string SmsTemplateApplyId { get; set; }

	[JsonPropertyName("code")]
	[Description("是否成功 0表示成功")]
	public long Code { get; set; }

	[JsonPropertyName("message")]
	[Description("说明")]
	public string Message { get; set; }
}
