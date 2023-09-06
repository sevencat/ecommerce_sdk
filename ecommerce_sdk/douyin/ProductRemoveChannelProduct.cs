namespace ecommerce.sdk.douyin;

[Description("删除渠道品")]
public class ProductRemoveChannelProductReq : IDouyinReq<ProductRemoveChannelProductRsp>
{

	public string GetMethod() { return "product.removeChannelProduct"; }

	public string GetUrl() { return "/product/removeChannelProduct"; }

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

[Description("删除渠道品")]
public class ProductRemoveChannelProductRsp
{
}
