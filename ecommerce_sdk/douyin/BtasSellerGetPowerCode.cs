namespace ecommerce.sdk.douyin;

[Description("商家_电子面单取号，可以取到发往质检机构或者发往消费者的电子面单号。系统自动处理收货地址关系")]
public class BtasSellerGetPowerCodeReq : IDouyinReq<BtasSellerGetPowerCodeRsp>
{

	public string GetMethod() { return "btas.sellerGetPowerCode"; }

	public string GetUrl() { return "/btas/sellerGetPowerCode"; }

	[JsonPropertyName("order_code")]
	[Description("订单码")]
	[NotNull]
	public string OrderCode { get; set; }

	[JsonPropertyName("sc_receipt_courier_type")]
	[Description("质检机构物流编号。1-顺丰")]
	[NotNull]
	public long? ScReceiptCourierType { get; set; }

	[JsonPropertyName("sc_receipt_order_insurance_cost")]
	[Description("报价金额（分）")]
	[NotNull]
	public long? ScReceiptOrderInsuranceCost { get; set; }
}

[Description("商家_电子面单取号，可以取到发往质检机构或者发往消费者的电子面单号。系统自动处理收货地址关系")]
public class BtasSellerGetPowerCodeRsp
{
	[JsonPropertyName("power_order_track_no")]
	[Description("物流单号")]
	public string PowerOrderTrackNo { get; set; }

	[JsonPropertyName("s_c_receipt_courier_code_count")]
	[Description("取号次数，当前限制为4")]
	public long SCReceiptCourierCodeCount { get; set; }
}
