namespace ecommerce.sdk.douyin;

[Description("发布话费、流量、生活娱乐充值商品时，account_template_id必填")]
public class TopupAccountTemplateListReq : IDouyinReq<TopupAccountTemplateListRsp>
{

	public string GetMethod() { return "topup.accountTemplateList"; }

	public string GetUrl() { return "/topup/accountTemplateList"; }

	[JsonPropertyName("category_id")]
	[Description("叶子类目id")]
	[NotNull]
	public long? CategoryId { get; set; }
}

[Description("发布话费、流量、生活娱乐充值商品时，account_template_id必填")]
public class TopupAccountTemplateListRsp
{
	[JsonPropertyName("template_list")]
	[Description("模板列表")]
	public List<TemplateListItem> TemplateList { get; set; }

	public class TemplateListItem
	{
		[JsonPropertyName("template_id")]
		[Description("模板id")]
		public long TemplateId { get; set; }

		[JsonPropertyName("name")]
		[Description("模板名称")]
		public string Name { get; set; }
	}
}
