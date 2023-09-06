namespace ecommerce.sdk.douyin;

[Description("取消正在审核中的商品")]
public class ProductCancelAuditReq : IDouyinReq<ProductCancelAuditRsp>
{

	public string GetMethod() { return "product.cancelAudit"; }

	public string GetUrl() { return "/product/cancelAudit"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }
}

[Description("取消正在审核中的商品")]
public class ProductCancelAuditRsp
{
}
