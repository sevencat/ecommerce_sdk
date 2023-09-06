namespace ecommerce.sdk.douyin;

[Description("跨境类自营店铺二级承接页商品加购功能")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","网络错误，请稍后重试","isp.service-error:300","网络错误，请稍后重试")]
public class SupplyChainAddCartSchemaReq : IDouyinReq<SupplyChainAddCartSchemaRsp>
{

	public string GetMethod() { return "supplyChain.addCartSchema"; }

	public string GetUrl() { return "/supplyChain/addCartSchema"; }

	[JsonPropertyName("promotion_id")]
	[Description("推广id")]
	[NotNull]
	public string PromotionId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品id")]
	[NotNull]
	public string ProductId { get; set; }

	[JsonPropertyName("ecom_scene_id")]
	[Description("场景id")]
	[NotNull]
	public string EcomSceneId { get; set; }

	[JsonPropertyName("entrance_info")]
	[Description("入口信息")]
	[NotNull]
	public string EntranceInfo { get; set; }

	[JsonPropertyName("promotion_source")]
	[Description("商品来源")]
	[NotNull]
	public long? PromotionSource { get; set; }

	[JsonPropertyName("sku_session_id")]
	[Description("SKU唯一标识")]
	[NotNull]
	public string SkuSessionId { get; set; }
}

[Description("跨境类自营店铺二级承接页商品加购功能")]
public class SupplyChainAddCartSchemaRsp
{
	[JsonPropertyName("url")]
	[Description("加购的URL")]
	public string Url { get; set; }

	[JsonPropertyName("type")]
	[Description("类型")]
	public int Type { get; set; }
}
