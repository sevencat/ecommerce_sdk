namespace ecommerce.sdk.douyin;

[Description("查询短信模板申请单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","响应结果不符合预期","isv.business-failed:628005100","请根据错误码描述检查请求参数")]
[DouyinRetCode(20000,"系统错误","628004205:Redis Get错误","isp.service-error:628004205","系统内部错误，请重试")]
[DouyinRetCode(50002,"业务处理失败","628004002:接口超时","isv.business-failed:628004002","请重试")]
public class SmsTemplateApplyListReq : IDouyinReq<SmsTemplateApplyListRsp>
{

	public string GetMethod() { return "sms.template.apply.list"; }

	public string GetUrl() { return "/sms/template/apply/list"; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("template_content")]
	[Description("短信模板内容： 英文短信：整条短信（包括签名+模板+变量中的内容）最多支持140个英文字符，超出将按140个字符截取为多条短信进行发送，费用按截取的条数收费； 非英文短信：整条短信（包括签名+模板+变量中的内容）最多支持70字符，超出将按70个字符截取为多条短信进行发送，费用按截取的条数收费；")]
	public string TemplateContent { get; set; }

	[JsonPropertyName("sms_template_apply_id")]
	[Description("短信模板申请单id")]
	public string SmsTemplateApplyId { get; set; }

	[JsonPropertyName("size")]
	[Description("每页数量，默认10")]
	public long? Size { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，默认0")]
	public long? Page { get; set; }

	[JsonPropertyName("status")]
	[Description("审核状态： 1:审核中 2:未通过 3:已开通 4:已关闭")]
	public long? Status { get; set; }
}

[Description("查询短信模板申请单")]
public class SmsTemplateApplyListRsp
{
	[JsonPropertyName("template_apply_list")]
	[Description("短信模板申请单列表")]
	public List<TemplateApplyListItem> TemplateApplyList { get; set; }

	public class TemplateApplyListItem
	{
		[JsonPropertyName("template_id")]
		[Description("模板id")]
		public string TemplateId { get; set; }

		[JsonPropertyName("sms_account")]
		[Description("短信发送渠道，主要做资源隔离")]
		public string SmsAccount { get; set; }

		[JsonPropertyName("sms_template_apply_id")]
		[Description("短信模板申请单id")]
		public string SmsTemplateApplyId { get; set; }

		[JsonPropertyName("template_name")]
		[Description("短信模版名称")]
		public string TemplateName { get; set; }

		[JsonPropertyName("template_content")]
		[Description("短信模版内容")]
		public string TemplateContent { get; set; }

		[JsonPropertyName("channel_type")]
		[Description("CN_NTC 国内通知短信 CN_MKT 国内营销短信（营销短信将自带退订功能） CN_OTP 国内验证码")]
		public string ChannelType { get; set; }

		[JsonPropertyName("status")]
		[Description("审核状态： 1:审核中 2:未通过 3:已开通 4:已关闭")]
		public long Status { get; set; }

		[JsonPropertyName("status_remark")]
		[Description("状态说明")]
		public string StatusRemark { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
