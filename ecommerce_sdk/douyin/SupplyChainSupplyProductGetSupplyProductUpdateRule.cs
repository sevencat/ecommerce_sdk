namespace ecommerce.sdk.douyin;

[Description("包含产品发布品牌列表、类目属性要求、资质填写要求列表")]
[DouyinRetCode(10000,"success","","","")]
public class SupplyChainSupplyProductGetSupplyProductUpdateRuleReq : IDouyinReq<SupplyChainSupplyProductGetSupplyProductUpdateRuleRsp>
{

	public string GetMethod() { return "supplyChain.supplyProduct.getSupplyProductUpdateRule"; }

	public string GetUrl() { return "/supplyChain/supplyProduct/getSupplyProductUpdateRule"; }

	[JsonPropertyName("category_id")]
	[Description("类目id")]
	[NotNull]
	public long? CategoryId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("品id，编辑的时候需要传被编辑的商品id，发布商品时如果已有产品id也需要传")]
	public long? ProductId { get; set; }
}

[Description("包含产品发布品牌列表、类目属性要求、资质填写要求列表")]
public class SupplyChainSupplyProductGetSupplyProductUpdateRuleRsp
{
	[JsonPropertyName("brand_list")]
	[Description("品牌列表")]
	public List<BrandListItem> BrandList { get; set; }

	public class BrandListItem
	{
		[JsonPropertyName("brand_id")]
		[Description("品牌id")]
		public long BrandId { get; set; }

		[JsonPropertyName("name_cn")]
		[Description("品牌中文名")]
		public string NameCn { get; set; }

		[JsonPropertyName("name_en")]
		[Description("品牌英文名")]
		public string NameEn { get; set; }
	}

	[JsonPropertyName("cate_property_list")]
	[Description("属性值列表")]
	public List<CatePropertyListItem> CatePropertyList { get; set; }

	public class CatePropertyListItem
	{
		[JsonPropertyName("property_name")]
		[Description("属性名称")]
		public string PropertyName { get; set; }

		[JsonPropertyName("options")]
		[Description("属性可选值列表")]
		public List<OptionsItem> Options { get; set; }

		public class OptionsItem
		{
			[JsonPropertyName("value_id")]
			[Description("属性值对应的id")]
			public long ValueId { get; set; }

			[JsonPropertyName("name")]
			[Description("属性值的展示名称")]
			public string Name { get; set; }
		}

		[JsonPropertyName("is_required")]
		[Description("true")]
		public bool IsRequired { get; set; }

		[JsonPropertyName("property_id")]
		[Description("属性id")]
		public long PropertyId { get; set; }

		[JsonPropertyName("sequence")]
		[Description("属性排列顺序")]
		public long Sequence { get; set; }

		[JsonPropertyName("diy_type")]
		[Description("是否支持枚举可输入,0表示不支持，1表示支持，支持枚举可输入的属性，在发布/编辑接口的类目属性参数中可以传入自定义的属性值，自定义属性值value为0，diy_type为1")]
		public long DiyType { get; set; }
	}

	[JsonPropertyName("quality_list")]
	[Description("资质列表")]
	public List<QualityListItem> QualityList { get; set; }

	public class QualityListItem
	{
		[JsonPropertyName("quality_key")]
		[Description("资质的key")]
		public string QualityKey { get; set; }

		[JsonPropertyName("quality_name")]
		[Description("资质名称")]
		public string QualityName { get; set; }

		[JsonPropertyName("text_list")]
		[Description("填写提示")]
		public List<string> TextList { get; set; }

		[JsonPropertyName("is_required")]
		[Description("是否必须")]
		public bool IsRequired { get; set; }
	}
}
