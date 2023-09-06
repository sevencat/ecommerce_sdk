namespace ecommerce.sdk.douyin;

[Description("查询商家自定义区模板（新版）,使用面单模板设计器编辑发布的模板用此接口获取商家模板数据；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","操作数据库异常","isv.business-failed:4010","请稍后重试")]
public class LogisticsGetCustomTemplateListReq : IDouyinReq<LogisticsGetCustomTemplateListRsp>
{

	public string GetMethod() { return "logistics.getCustomTemplateList"; }

	public string GetUrl() { return "/logistics/getCustomTemplateList"; }

	[JsonPropertyName("logistics_code")]
	[Description("物流服务商编码（若为空代表查询全部）")]
	public string LogisticsCode { get; set; }
}

[Description("查询商家自定义区模板（新版）,使用面单模板设计器编辑发布的模板用此接口获取商家模板数据；")]
public class LogisticsGetCustomTemplateListRsp
{
	[JsonPropertyName("custom_template_data")]
	[Description("商家所有快递自定义模板的数据列表")]
	public List<CustomTemplateDataItem> CustomTemplateData { get; set; }

	public class CustomTemplateDataItem
	{
		[JsonPropertyName("logistics_code")]
		[Description("物流服务商编码")]
		public string LogisticsCode { get; set; }

		[JsonPropertyName("custom_template_infos")]
		[Description("用户使用的模板数据")]
		public List<CustomTemplateInfosItem> CustomTemplateInfos { get; set; }

		public class CustomTemplateInfosItem
		{
			[JsonPropertyName("custom_template_code")]
			[Description("自定义区模板code")]
			public string CustomTemplateCode { get; set; }

			[JsonPropertyName("custom_template_name")]
			[Description("自定义区模板名称")]
			public string CustomTemplateName { get; set; }

			[JsonPropertyName("parent_template_code")]
			[Description("父模板code(查询标准模板API中返回的template_code)")]
			public string ParentTemplateCode { get; set; }

			[JsonPropertyName("custom_template_url")]
			[Description("自定义区模板url(URL资源的内容为xml格式的报文)")]
			public string CustomTemplateUrl { get; set; }

			[JsonPropertyName("custom_template_key_list")]
			[Description("customTemplateKeyList（打印项中字段列表）")]
			public List<string> CustomTemplateKeyList { get; set; }

			[JsonPropertyName("custom_template_id")]
			[Description("自定义区模板id")]
			public long CustomTemplateId { get; set; }

			[JsonPropertyName("parent_template_id")]
			[Description("父模板id")]
			public long ParentTemplateId { get; set; }
		}
	}
}
