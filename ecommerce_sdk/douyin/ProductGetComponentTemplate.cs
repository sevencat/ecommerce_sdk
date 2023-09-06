namespace ecommerce.sdk.douyin;

[Description("分页查询模板列表")]
public class ProductGetComponentTemplateReq : IDouyinReq<ProductGetComponentTemplateRsp>
{

	public string GetMethod() { return "product.getComponentTemplate"; }

	public string GetUrl() { return "/product/getComponentTemplate"; }

	[JsonPropertyName("template_type")]
	[Description("模板类型: size_info(尺码表)")]
	public string TemplateType { get; set; }

	[JsonPropertyName("template_sub_type")]
	[Description("组件模板子类型；clothing -饰；undies-内衣；shoes 鞋靴；children_clothing-童装")]
	public string TemplateSubType { get; set; }

	[JsonPropertyName("template_id")]
	[Description("模板ID")]
	public long? TemplateId { get; set; }

	[JsonPropertyName("shareable")]
	[Description("是否设置为公有模板(多个商品可共用)。true-是，false-不是；不传默认true")]
	public bool? Shareable { get; set; }

	[JsonPropertyName("page_num")]
	[Description("页码，从0开始，最大支持100")]
	public long? PageNum { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页条数，最大支持20；page_size和template_id二选一入参")]
	public long? PageSize { get; set; }
}

[Description("分页查询模板列表")]
public class ProductGetComponentTemplateRsp
{
	[JsonPropertyName("component_template_info_list")]
	[Description("尺码模板列表")]
	public List<ComponentTemplateInfoListItem> ComponentTemplateInfoList { get; set; }

	public class ComponentTemplateInfoListItem
	{
		[JsonPropertyName("template_id")]
		[Description("模板ID")]
		public long TemplateId { get; set; }

		[JsonPropertyName("template_type")]
		[Description("模板类型: size_info(尺码表)")]
		public string TemplateType { get; set; }

		[JsonPropertyName("template_sub_type")]
		[Description("组件模板子类型:clothing、undies、shoes、children_clothing")]
		public string TemplateSubType { get; set; }

		[JsonPropertyName("template_name")]
		[Description("模板名称")]
		public string TemplateName { get; set; }

		[JsonPropertyName("component_data")]
		[Description("模板数据")]
		public string ComponentData { get; set; }

		[JsonPropertyName("image")]
		[Description("尺码模板图片")]
		public ImageItem Image { get; set; }

		public class ImageItem
		{
			[JsonPropertyName("url")]
			[Description("图片url")]
			public string Url { get; set; }

			[JsonPropertyName("width")]
			[Description("图片宽度")]
			public short Width { get; set; }

			[JsonPropertyName("height")]
			[Description("图片长度")]
			public short Height { get; set; }
		}

		[JsonPropertyName("shareable")]
		[Description("是否可共享 是-false 否-true")]
		public bool Shareable { get; set; }

		[JsonPropertyName("category_id")]
		[Description("类目ID")]
		public long CategoryId { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public long UpdateTime { get; set; }

		[JsonPropertyName("component_front_data")]
		[Description("模板配置数据")]
		public string ComponentFrontData { get; set; }
	}

	[JsonPropertyName("total_num")]
	[Description("总页数")]
	public long TotalNum { get; set; }
}
