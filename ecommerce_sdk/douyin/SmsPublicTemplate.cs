namespace ecommerce.sdk.douyin;

[Description("公共模版查询接口")]
public class SmsPublicTemplateReq : IDouyinReq<SmsPublicTemplateRsp>
{

	public string GetMethod() { return "sms.public.template"; }

	public string GetUrl() { return "/sms/public/template"; }

	[JsonPropertyName("size")]
	[Description("每页数据大小")]
	public long? Size { get; set; }

	[JsonPropertyName("page")]
	[Description("第几页，从0开始")]
	public long? Page { get; set; }

	[JsonPropertyName("template_id")]
	[Description("模版id")]
	public string TemplateId { get; set; }
}

[Description("公共模版查询接口")]
public class SmsPublicTemplateRsp
{
	[JsonPropertyName("total")]
	[Description("数据总量")]
	public long Total { get; set; }

	[JsonPropertyName("public_template_list")]
	[Description("列表页数据")]
	public List<PublicTemplateListItem> PublicTemplateList { get; set; }

	public class PublicTemplateListItem
	{
		[JsonPropertyName("template_id")]
		[Description("模版id")]
		public string TemplateId { get; set; }

		[JsonPropertyName("template_name")]
		[Description("模版名称")]
		public string TemplateName { get; set; }

		[JsonPropertyName("template_content")]
		[Description("模版内容")]
		public string TemplateContent { get; set; }

		[JsonPropertyName("channel_type")]
		[Description("模版类型")]
		public string ChannelType { get; set; }
	}
}
