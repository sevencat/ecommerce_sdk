namespace ecommerce.sdk.douyin;

[Description("上架渠道品")]
public class ProductOnlineChannelProductReq : IDouyinReq<ProductOnlineChannelProductRsp>
{

	public string GetMethod() { return "product.onlineChannelProduct"; }

	public string GetUrl() { return "/product/onlineChannelProduct"; }

	[JsonPropertyName("main_product_id")]
	[Description("主商品ID")]
	[NotNull]
	public long? MainProductId { get; set; }

	[JsonPropertyName("channel_id")]
	[Description("渠道ID")]
	[NotNull]
	public long? ChannelId { get; set; }

	[JsonPropertyName("channel_type")]
	[Description("渠道类型。不支持修改。,3：商家自卖,4：达人带货")]
	[NotNull]
	public long? ChannelType { get; set; }
}

[Description("上架渠道品")]
public class ProductOnlineChannelProductRsp
{
}
