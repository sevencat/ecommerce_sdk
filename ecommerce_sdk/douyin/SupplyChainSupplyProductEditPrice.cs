namespace ecommerce.sdk.douyin;

[Description("编辑价格，包含基准供货价和特定供货价")]
[DouyinRetCode(10000,"success","","","")]
public class SupplyChainSupplyProductEditPriceReq : IDouyinReq<SupplyChainSupplyProductEditPriceRsp>
{

	public string GetMethod() { return "supplyChain.supplyProduct.editPrice"; }

	public string GetUrl() { return "/supplyChain/supplyProduct/editPrice"; }

	[JsonPropertyName("product_id")]
	[Description("产品id")]
	public long? ProductId { get; set; }

	[JsonPropertyName("sku_id")]
	[Description("skuId")]
	[NotNull]
	public long? SkuId { get; set; }

	[JsonPropertyName("supply_price")]
	[Description("供货价（单位分）")]
	public long? SupplyPrice { get; set; }

	[JsonPropertyName("spec_price_list")]
	[Description("特定供货价")]
	public List<SpecPriceListItem> SpecPriceList { get; set; }

	public class SpecPriceListItem
	{
		[JsonPropertyName("distributor_id_list")]
		[Description("分销商列表")]
		[NotNull]
		public List<long> DistributorIdList { get; set; }

		[JsonPropertyName("supply_price")]
		[Description("供货价（单位分）")]
		[NotNull]
		public long? SupplyPrice { get; set; }
	}
}

[Description("编辑价格，包含基准供货价和特定供货价")]
public class SupplyChainSupplyProductEditPriceRsp
{
}
