namespace ecommerce.sdk.douyin;

[Description("下架产品")]
[DouyinRetCode(10000,"success","","","")]
public class SupplyChainSupplyProductOfflineReq : IDouyinReq<SupplyChainSupplyProductOfflineRsp>
{

	public string GetMethod() { return "supplyChain.supplyProduct.offline"; }

	public string GetUrl() { return "/supplyChain/supplyProduct/offline"; }

	[JsonPropertyName("product_id")]
	[Description("产品id")]
	[NotNull]
	public long? ProductId { get; set; }
}

[Description("下架产品")]
public class SupplyChainSupplyProductOfflineRsp
{
}
