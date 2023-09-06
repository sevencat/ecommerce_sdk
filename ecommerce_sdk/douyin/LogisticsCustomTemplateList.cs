namespace ecommerce.sdk.douyin;

[Description("查询商家自定义区域数据；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","不支持的服务商","isv.business-failed:4006","请检查logistics_code字段")]
public class LogisticsCustomTemplateListReq : IDouyinReq<LogisticsCustomTemplateListRsp>
{

	public string GetMethod() { return "logistics.customTemplateList"; }

	public string GetUrl() { return "/logistics/customTemplateList"; }

	[JsonPropertyName("logistics_code")]
	[Description("物流商编码")]
	public string LogisticsCode { get; set; }
}

[Description("查询商家自定义区域数据；")]
public class LogisticsCustomTemplateListRsp
{
	[JsonPropertyName("custom_template_data")]
	[Description("自定义模板的数据列表")]
	public List<CustomTemplateDataItem> CustomTemplateData { get; set; }

	public class CustomTemplateDataItem
	{
		[JsonPropertyName("logistics_code")]
		[Description("物流商编码")]
		public string LogisticsCode { get; set; }

		[JsonPropertyName("custom_template_infos")]
		[Description("用户使用的模板数据")]
		public List<CustomTemplateInfosItem> CustomTemplateInfos { get; set; }

		public class CustomTemplateInfosItem
		{
			[JsonPropertyName("custom_template_code")]
			[Description("自定义模板code")]
			public string CustomTemplateCode { get; set; }

			[JsonPropertyName("custom_template_url")]
			[Description("自定义区模板url(URL资源的内容为xml格式的报文)")]
			public string CustomTemplateUrl { get; set; }

			[JsonPropertyName("custom_template_name")]
			[Description("自定义区模板名称")]
			public string CustomTemplateName { get; set; }

			[JsonPropertyName("parent_template_code")]
			[Description("父模板code(查询标准模板API中返回的template_code)")]
			public string ParentTemplateCode { get; set; }
		}
	}
}
