namespace ecommerce.sdk.douyin;

[Description("支持查询商家评分，包括商家体验分、商品体验分、物流体验分和商家服务分。需店铺授权")]
public class ShopReputationReq : IDouyinReq<ShopReputationRsp>
{

	public string GetMethod() { return "shop.reputation"; }

	public string GetUrl() { return "/shop/reputation"; }

}

[Description("支持查询商家评分，包括商家体验分、商品体验分、物流体验分和商家服务分。需店铺授权")]
public class ShopReputationRsp
{
	[JsonPropertyName("shop_id")]
	[Description("店铺 id")]
	public long ShopId { get; set; }

	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	public string ShopName { get; set; }

	[JsonPropertyName("shop_score")]
	[Description("商家体验分")]
	public string ShopScore { get; set; }

	[JsonPropertyName("product_score")]
	[Description("商品体验分")]
	public string ProductScore { get; set; }

	[JsonPropertyName("logistics_score")]
	[Description("物流体验分")]
	public string LogisticsScore { get; set; }

	[JsonPropertyName("service_score")]
	[Description("商家服务分")]
	public string ServiceScore { get; set; }
}
