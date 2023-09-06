namespace ecommerce.sdk.douyin;

[Description("查询短信模板")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","628004205:Redis Get错误","isp.service-error:628004205","系统内部错误，请重试")]
public class SmsTemplateSearchReq : IDouyinReq<SmsTemplateSearchRsp>
{

	public string GetMethod() { return "sms.template.search"; }

	public string GetUrl() { return "/sms/template/search"; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("template_id")]
	[Description("短信模板id")]
	public string TemplateId { get; set; }

	[JsonPropertyName("template_content")]
	[Description("短信模版内容")]
	public string TemplateContent { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，默认0")]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页大小，默认10")]
	public long? Size { get; set; }

	[JsonPropertyName("template_name")]
	[Description("短信模版名称")]
	public string TemplateName { get; set; }
}

[Description("查询短信模板")]
public class SmsTemplateSearchRsp
{
	[JsonPropertyName("template_search_list")]
	[Description("模板列表")]
	public List<TemplateSearchListItem> TemplateSearchList { get; set; }

	public class TemplateSearchListItem
	{
		[JsonPropertyName("sms_account")]
		[Description("短信发送渠道，主要做资源隔离")]
		public string SmsAccount { get; set; }

		[JsonPropertyName("template_content")]
		[Description("短信模版内容")]
		public string TemplateContent { get; set; }

		[JsonPropertyName("template_id")]
		[Description("短信模板id")]
		public string TemplateId { get; set; }

		[JsonPropertyName("channel_type")]
		[Description("CN_NTC 国内通知短信 CN_MKT 国内营销短信（免审模版营销短信将自带退订功能，非免审模版需自行添加退订描述） CN_OTP 国内验证码")]
		public string ChannelType { get; set; }

		[JsonPropertyName("template_name")]
		[Description("短信模版名称")]
		public string TemplateName { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总条数")]
	public long Total { get; set; }
}
