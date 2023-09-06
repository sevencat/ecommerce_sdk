namespace ecommerce.sdk.douyin;

[Description("基于店铺主品创建门店子品 (同步创建)")]
public class SupermProductCreateSubProductReq : IDouyinReq<SupermProductCreateSubProductRsp>
{

	public string GetMethod() { return "superm.product.createSubProduct"; }

	public string GetUrl() { return "/superm/product/createSubProduct"; }

	[JsonPropertyName("main_product_id")]
	[Description("店铺主商品ID")]
	[NotNull]
	public long? MainProductId { get; set; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("sku_info")]
	[Description("子商品SKU的库存、价格信息")]
	public List<SkuInfoItem> SkuInfo { get; set; }

	public class SkuInfoItem
	{
		[JsonPropertyName("sell_property_names")]
		[Description("子商品规格值列表")]
		[NotNull]
		public List<string> SellPropertyNames { get; set; }

		[JsonPropertyName("price")]
		[Description("子商品SKU价格 (单位：分)")]
		public long? Price { get; set; }

		[JsonPropertyName("stock")]
		[Description("子商品SKU库存")]
		public long? Stock { get; set; }
	}
}

[Description("基于店铺主品创建门店子品 (同步创建)")]
public class SupermProductCreateSubProductRsp
{
	[JsonPropertyName("sub_product_id")]
	[Description("门店子商品ID")]
	public long SubProductId { get; set; }
}
