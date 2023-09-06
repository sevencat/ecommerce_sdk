namespace ecommerce.sdk.douyin;

[Description("质检确认收到商家送检的实物质检订单")]
public class BtasScConfirmReceiveOfflineOrdersReq : IDouyinReq<BtasScConfirmReceiveOfflineOrdersRsp>
{

	public string GetMethod() { return "btas.sc.confirmReceiveOfflineOrders"; }

	public string GetUrl() { return "/btas/sc/confirmReceiveOfflineOrders"; }

	[JsonPropertyName("orders")]
	[Description("订单列表")]
	[NotNull]
	public List<OrdersItem> Orders { get; set; }

	public class OrdersItem
	{
		[JsonPropertyName("order_code")]
		[Description("订单码")]
		[NotNull]
		public string OrderCode { get; set; }

		[JsonPropertyName("product_quantity")]
		[Description("商品数量")]
		[NotNull]
		public int? ProductQuantity { get; set; }
	}

	[JsonPropertyName("sc_id")]
	[Description("质检机构ID。请填入当前订单对应的")]
	[NotNull]
	public long? ScId { get; set; }
}

[Description("质检确认收到商家送检的实物质检订单")]
public class BtasScConfirmReceiveOfflineOrdersRsp
{
	[JsonPropertyName("orders")]
	[Description("订单列表")]
	public List<OrdersItem> Orders { get; set; }

	public class OrdersItem
	{
		[JsonPropertyName("order_code")]
		[Description("订单码")]
		public string OrderCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("错误消息")]
		public string ErrMsg { get; set; }
	}
}
