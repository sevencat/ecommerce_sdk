namespace ecommerce.sdk.douyin;

[Description("商家调用这个接口用于设置尾款信息.")]
public class ShopSetFinalPaymentReq : IDouyinReq<ShopSetFinalPaymentRsp>
{

	public string GetMethod() { return "shop.setFinalPayment"; }

	public string GetUrl() { return "/shop/setFinalPayment"; }

	[JsonPropertyName("final_price")]
	[Description("尾款价格")]
	[NotNull]
	public long? FinalPrice { get; set; }

	[JsonPropertyName("product_imgs")]
	[Description("商品图片信息")]
	[NotNull]
	public List<string> ProductImgs { get; set; }

	[JsonPropertyName("product_dscription")]
	[Description("描述一下这个商品")]
	[NotNull]
	public string ProductDscription { get; set; }

	[JsonPropertyName("shop_order_no")]
	[Description("店铺单号")]
	[NotNull]
	public string ShopOrderNo { get; set; }

	[JsonPropertyName("operate_user_name")]
	[Description("操作人信息")]
	[NotNull]
	public string OperateUserName { get; set; }

	[JsonPropertyName("source")]
	[Description("0默认/1Open调用-创建/2Open调用-更新")]
	public long? Source { get; set; }
}

[Description("商家调用这个接口用于设置尾款信息.")]
public class ShopSetFinalPaymentRsp
{
}
