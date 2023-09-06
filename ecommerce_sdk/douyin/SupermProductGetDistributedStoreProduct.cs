namespace ecommerce.sdk.douyin;

[Description("根据店铺主商品ID查询已经铺品的门店及子商品")]
public class SupermProductGetDistributedStoreProductReq : IDouyinReq<SupermProductGetDistributedStoreProductRsp>
{

	public string GetMethod() { return "superm.product.getDistributedStoreProduct"; }

	public string GetUrl() { return "/superm/product/getDistributedStoreProduct"; }

	[JsonPropertyName("main_product_id")]
	[Description("店铺主商品ID")]
	[NotNull]
	public long? MainProductId { get; set; }

	[JsonPropertyName("store_ids")]
	[Description("门店列表")]
	public List<long> StoreIds { get; set; }

	[JsonPropertyName("page")]
	[Description("起始页 (从0开始)")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页尺寸 (最大值50)")]
	[NotNull]
	public long? Size { get; set; }
}

[Description("根据店铺主商品ID查询已经铺品的门店及子商品")]
public class SupermProductGetDistributedStoreProductRsp
{
	[JsonPropertyName("store_products")]
	[Description("门店列表信息")]
	public List<StoreProductsItem> StoreProducts { get; set; }

	public class StoreProductsItem
	{
		[JsonPropertyName("main_product_id")]
		[Description("店铺主商品ID")]
		public long MainProductId { get; set; }

		[JsonPropertyName("sku_mapping")]
		[Description("店铺主商品与门店子商品SKU映射")]
		public List<SkuMappingItem> SkuMapping { get; set; }

		public class SkuMappingItem
		{
			[JsonPropertyName("main_sku_id")]
			[Description("店铺主商品SKU ID")]
			public long MainSkuId { get; set; }

			[JsonPropertyName("store_sku_id")]
			[Description("门店子商品SKU ID")]
			public long StoreSkuId { get; set; }
		}

		[JsonPropertyName("store_product_id")]
		[Description("门店子商品ID")]
		public long StoreProductId { get; set; }

		[JsonPropertyName("store_info")]
		[Description("门店信息")]
		public StoreInfoItem StoreInfo { get; set; }

		public class StoreInfoItem
		{
			[JsonPropertyName("store_id")]
			[Description("门店ID")]
			public long StoreId { get; set; }
		}
	}

	[JsonPropertyName("page")]
	[Description("起始页 (从0开始)")]
	public long Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页尺寸 (最大值50)")]
	public long Size { get; set; }

	[JsonPropertyName("total")]
	[Description("商品总数")]
	public long Total { get; set; }
}
