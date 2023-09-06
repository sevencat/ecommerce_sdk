namespace ecommerce.sdk.douyin;

[Description("查询物流商的标准模板。,注意：物流商模板平台会定期更新或新增，请开发者定期扫描该接口，保持和平台数据一致")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","100201:获取模版信息失败","isv.business-failed:100201","请重试")]
public class LogisticsTemplateListReq : IDouyinReq<LogisticsTemplateListRsp>
{

	public string GetMethod() { return "logistics.templateList"; }

	public string GetUrl() { return "/logistics/templateList"; }

}

[Description("查询物流商的标准模板。,注意：物流商模板平台会定期更新或新增，请开发者定期扫描该接口，保持和平台数据一致")]
public class LogisticsTemplateListRsp
{
	[JsonPropertyName("template_data")]
	[Description("模版数据")]
	public List<TemplateDataItem> TemplateData { get; set; }

	public class TemplateDataItem
	{
		[JsonPropertyName("template_infos")]
		[Description("模版信息")]
		public List<TemplateInfosItem> TemplateInfos { get; set; }

		public class TemplateInfosItem
		{
			[JsonPropertyName("template_id")]
			[Description("模版id")]
			public long TemplateId { get; set; }

			[JsonPropertyName("template_code")]
			[Description("模版编码")]
			public string TemplateCode { get; set; }

			[JsonPropertyName("template_name")]
			[Description("模版名称")]
			public string TemplateName { get; set; }

			[JsonPropertyName("template_url")]
			[Description("模版URL")]
			public string TemplateUrl { get; set; }

			[JsonPropertyName("version")]
			[Description("版本")]
			public short Version { get; set; }

			[JsonPropertyName("template_type")]
			[Description("模版类型； 1-一联单 2-二联单")]
			public short TemplateType { get; set; }

			[JsonPropertyName("perview_url")]
			[Description("预览URL")]
			public string PerviewUrl { get; set; }
		}

		[JsonPropertyName("logistics_code")]
		[Description("物流公司")]
		public string LogisticsCode { get; set; }
	}
}
