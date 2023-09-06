namespace ecommerce.sdk.douyin;

[Description("商家使用自提码，自提某些订单列表。该功能仅在商家的退货方式选择自提，且订单在发货给消费者之前被取消有效。")]
public class BtasScConfirmOrderByPickupCodeReq : IDouyinReq<BtasScConfirmOrderByPickupCodeRsp>
{

	public string GetMethod() { return "btas.sc.confirmOrderByPickupCode"; }

	public string GetUrl() { return "/btas/sc/confirmOrderByPickupCode"; }

	[JsonPropertyName("order_code_list")]
	[Description("订单码码列表")]
	[NotNull]
	public List<string> OrderCodeList { get; set; }

	[JsonPropertyName("pickup_code")]
	[Description("自提码")]
	[NotNull]
	public string PickupCode { get; set; }

	[JsonPropertyName("sc_id")]
	[Description("质检机构ID")]
	[NotNull]
	public long? ScId { get; set; }
}

[Description("商家使用自提码，自提某些订单列表。该功能仅在商家的退货方式选择自提，且订单在发货给消费者之前被取消有效。")]
public class BtasScConfirmOrderByPickupCodeRsp
{
}
