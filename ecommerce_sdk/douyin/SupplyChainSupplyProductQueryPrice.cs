namespace ecommerce.sdk.douyin;

[Description("查询价格")]
public class SupplyChainSupplyProductQueryPriceReq : IDouyinReq<SupplyChainSupplyProductQueryPriceRsp>
{

	public string GetMethod() { return "supplyChain.supplyProduct.queryPrice"; }

	public string GetUrl() { return "/supplyChain/supplyProduct/queryPrice"; }

	[JsonPropertyName("sku_id")]
	[Description("skuid")]
	public long? SkuId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("productid")]
	public long? ProductId { get; set; }
}

[Description("查询价格")]
public class SupplyChainSupplyProductQueryPriceRsp
{
	[JsonPropertyName("data")]
	[Description("返回值")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("sku_id")]
		[Description("skuid")]
		public long SkuId { get; set; }

		[JsonPropertyName("supply_price")]
		[Description("基准供货价")]
		public long SupplyPrice { get; set; }

		[JsonPropertyName("spec_price_list")]
		[Description("特定供货价")]
		public List<SpecPriceListItem> SpecPriceList { get; set; }

		public class SpecPriceListItem
		{
			[JsonPropertyName("distributor_id_list")]
			[Description("分销商id列表")]
			public List<long> DistributorIdList { get; set; }

			[JsonPropertyName("supply_price")]
			[Description("特定供货价")]
			public long SupplyPrice { get; set; }
		}
	}
}
