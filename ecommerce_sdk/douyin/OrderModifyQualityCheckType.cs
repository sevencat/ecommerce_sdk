namespace ecommerce.sdk.douyin;

[Description("修改可质检订单质检类型")]
public class OrderModifyQualityCheckTypeReq : IDouyinReq<OrderModifyQualityCheckTypeRsp>
{

	public string GetMethod() { return "order.modifyQualityCheckType"; }

	public string GetUrl() { return "/order/modifyQualityCheckType"; }

	[JsonPropertyName("shop_order_id")]
	[Description("订单号")]
	[NotNull]
	public string ShopOrderId { get; set; }
}

[Description("修改可质检订单质检类型")]
public class OrderModifyQualityCheckTypeRsp
{
}
