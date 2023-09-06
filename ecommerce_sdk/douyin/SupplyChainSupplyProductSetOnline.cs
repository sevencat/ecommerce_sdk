namespace ecommerce.sdk.douyin;

[Description("上架产品")]
[DouyinRetCode(10000,"success","","","")]
public class SupplyChainSupplyProductSetOnlineReq : IDouyinReq<SupplyChainSupplyProductSetOnlineRsp>
{

	public string GetMethod() { return "supplyChain.supplyProduct.setOnline"; }

	public string GetUrl() { return "/supplyChain/supplyProduct/setOnline"; }

	[JsonPropertyName("product_id")]
	[Description("产品id")]
	[NotNull]
	public long? ProductId { get; set; }
}

[Description("上架产品")]
public class SupplyChainSupplyProductSetOnlineRsp
{
}
