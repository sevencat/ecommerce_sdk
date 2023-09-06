namespace ecommerce.sdk.douyin;

[Description("使用面单模板设计器编辑发布的「自定义模板」，用此接口获取商家的自定义模板数据，注意和「自定义区模板」概念不同；")]
public class LogisticsGetDesignTemplateListReq : IDouyinReq<LogisticsGetDesignTemplateListRsp>
{

	public string GetMethod() { return "logistics.getDesignTemplateList"; }

	public string GetUrl() { return "/logistics/getDesignTemplateList"; }

}

[Description("使用面单模板设计器编辑发布的「自定义模板」，用此接口获取商家的自定义模板数据，注意和「自定义区模板」概念不同；")]
public class LogisticsGetDesignTemplateListRsp
{
	[JsonPropertyName("design_template_data")]
	[Description("已发布的自定义模板列表")]
	public List<DesignTemplateDataItem> DesignTemplateData { get; set; }

	public class DesignTemplateDataItem
	{
		[JsonPropertyName("design_template_code")]
		[Description("自定义模板code")]
		public string DesignTemplateCode { get; set; }

		[JsonPropertyName("design_template_name")]
		[Description("自定义模板名称")]
		public string DesignTemplateName { get; set; }

		[JsonPropertyName("design_template_url")]
		[Description("自定义模板url")]
		public string DesignTemplateUrl { get; set; }

		[JsonPropertyName("design_template_key_list")]
		[Description("打印项中字段列表")]
		public List<string> DesignTemplateKeyList { get; set; }
	}
}
