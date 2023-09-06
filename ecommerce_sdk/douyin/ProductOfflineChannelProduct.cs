namespace ecommerce.sdk.douyin;

[Description("下架渠道商品")]
public class ProductOfflineChannelProductReq : IDouyinReq<ProductOfflineChannelProductRsp>
{

	public string GetMethod() { return "product.offlineChannelProduct"; }

	public string GetUrl() { return "/product/offlineChannelProduct"; }

	[JsonPropertyName("main_product_id")]
	[Description("主商品ID")]
	[NotNull]
	public long? MainProductId { get; set; }

	[JsonPropertyName("channel_id")]
	[Description("渠道ID")]
	[NotNull]
	public long? ChannelId { get; set; }

	[JsonPropertyName("channel_type")]
	[Description("渠道类型,3：商家自卖,4：达人带货")]
	[NotNull]
	public long? ChannelType { get; set; }
}

[Description("下架渠道商品")]
public class ProductOfflineChannelProductRsp
{
}
