namespace ecommerce.sdk.douyin;

[Description("质检机构在收到实物质检商品质检完成，并且同步到平台后，进行发货。 此时，如果订单已经已经取消就是发往商家（如果商家是自提则接口会报错）；如果订单未取消，则发往消费者。")]
public class BtasScShippingOfflineOrderReq : IDouyinReq<BtasScShippingOfflineOrderRsp>
{

	public string GetMethod() { return "btas.sc.shippingOfflineOrder"; }

	public string GetUrl() { return "/btas/sc/shippingOfflineOrder"; }

	[JsonPropertyName("order_code")]
	[Description("订单码")]
	[NotNull]
	public string OrderCode { get; set; }

	[JsonPropertyName("sc_id")]
	[Description("质检机构ID")]
	[NotNull]
	public long? ScId { get; set; }
}

[Description("质检机构在收到实物质检商品质检完成，并且同步到平台后，进行发货。 此时，如果订单已经已经取消就是发往商家（如果商家是自提则接口会报错）；如果订单未取消，则发往消费者。")]
public class BtasScShippingOfflineOrderRsp
{
	[JsonPropertyName("seller_send_type")]
	[Description("商家送检方式。1，邮寄。2：面交")]
	public int SellerSendType { get; set; }

	[JsonPropertyName("logistics_num")]
	[Description("快递单号。面交没有这个字段")]
	public string LogisticsNum { get; set; }

	[JsonPropertyName("logistics_name_cn")]
	[Description("快递公司名称")]
	public string LogisticsNameCn { get; set; }

	[JsonPropertyName("logistics_name_en")]
	[Description("快递公司英文名称")]
	public string LogisticsNameEn { get; set; }

	[JsonPropertyName("receiver_type")]
	[Description("收货人类型，-1-未知;0-买家收货;1-卖家收货。-1的情况是质检站点在btas系统中，修改了发货信息，但是实际上发给谁，系统并不清楚")]
	public int ReceiverType { get; set; }

	[JsonPropertyName("order_code")]
	[Description("发货的orderCode")]
	public string OrderCode { get; set; }

	[JsonPropertyName("logistics_pdf_file")]
	[Description("发货物流PDF文件")]
	public string LogisticsPdfFile { get; set; }

	[JsonPropertyName("cancel_status")]
	[Description("订单取消状态。0-未取消；1-申请取消；2-订单已经取消；4-仅退款&订单已取消；6-退货退款&订单已取消")]
	public int CancelStatus { get; set; }
}
