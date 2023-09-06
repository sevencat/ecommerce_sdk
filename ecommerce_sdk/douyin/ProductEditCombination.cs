namespace ecommerce.sdk.douyin;

[Description("编辑商品搭配的信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","非法的参数","isv.parameter-invalid:2010004","参考具体信息")]
public class ProductEditCombinationReq : IDouyinReq<ProductEditCombinationRsp>
{

	public string GetMethod() { return "product.editCombination"; }

	public string GetUrl() { return "/product/editCombination"; }

	[JsonPropertyName("combination_id")]
	[Description("搭配ID")]
	[NotNull]
	public long? CombinationId { get; set; }

	[JsonPropertyName("title")]
	[Description("搭配标题")]
	public string Title { get; set; }

	[JsonPropertyName("description")]
	[Description("搭配描述")]
	public string Description { get; set; }

	[JsonPropertyName("anchor_image_info")]
	[Description("搭配主图信息，只有店铺主图搭配需要使用，请注意，这里只允许修改锚点和商品展示的名称。")]
	public string AnchorImageInfo { get; set; }

	[JsonPropertyName("creator_id")]
	[Description("创建者ID，用于校验权限")]
	public long? CreatorId { get; set; }

	[JsonPropertyName("creator_type")]
	[Description("创建者类型，1表示店铺，3表示客服")]
	public long? CreatorType { get; set; }

	[JsonPropertyName("combination_type")]
	[Description("搭配类型，1表示店铺，3表示客服")]
	public int? CombinationType { get; set; }

	[JsonPropertyName("combination_subtype")]
	[Description("搭配子类型：0表示默认搭配，1表示固定有主图搭配，2表示无主图搭配。店铺搭配可以使用枚举值1，2；客服搭配只可以使用枚举值0")]
	public int? CombinationSubtype { get; set; }

	[JsonPropertyName("sku_info")]
	[Description("Sku信息")]
	public List<SkuInfoItem> SkuInfo { get; set; }

	public class SkuInfoItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long? ProductId { get; set; }

		[JsonPropertyName("sku_num_info")]
		[Description("SKU数量信息")]
		public List<SkuNumInfoItem> SkuNumInfo { get; set; }

		public class SkuNumInfoItem
		{
			[JsonPropertyName("sku_id")]
			[Description("SKU的ID")]
			public long? SkuId { get; set; }

			[JsonPropertyName("num")]
			[Description("SKU的数量")]
			public long? Num { get; set; }
		}
	}

	[JsonPropertyName("product_ids")]
	[Description("商品ID的数组")]
	public List<long> ProductIds { get; set; }
}

[Description("编辑商品搭配的信息")]
public class ProductEditCombinationRsp
{
}
