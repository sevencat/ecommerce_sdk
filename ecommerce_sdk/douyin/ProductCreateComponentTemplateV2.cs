namespace ecommerce.sdk.douyin;

[Description("创建尺码模板")]
public class ProductCreateComponentTemplateV2Req : IDouyinReq<ProductCreateComponentTemplateV2Rsp>
{

	public string GetMethod() { return "product.createComponentTemplateV2"; }

	public string GetUrl() { return "/product/createComponentTemplateV2"; }

	[JsonPropertyName("template_type")]
	[Description("模板类型：尺码模板")]
	[NotNull]
	public string TemplateType { get; set; }

	[JsonPropertyName("template_sub_type")]
	[Description("模板子类型: clothing(服装)、undies(内衣)、shoes(鞋靴类)、children_clothing(童装)")]
	[NotNull]
	public string TemplateSubType { get; set; }

	[JsonPropertyName("template_name")]
	[Description("模板名称")]
	[NotNull]
	public string TemplateName { get; set; }

	[JsonPropertyName("component_front_data")]
	[Description("商品组件数据 json，表格行列顺序以selectedSize和selectedSpecs的顺序为准")]
	[NotNull]
	public string ComponentFrontData { get; set; }

	[JsonPropertyName("shareable")]
	[Description("是否设置为公有模板(多个商品可共用)。true-是，false-不是；不传默认fasle")]
	public bool? Shareable { get; set; }

	[JsonPropertyName("category_id")]
	[Description("类目id，用来确定模板类型")]
	public long? CategoryId { get; set; }
}

[Description("创建尺码模板")]
public class ProductCreateComponentTemplateV2Rsp
{
	[JsonPropertyName("template_id")]
	[Description("模板ID")]
	public long TemplateId { get; set; }
}
