namespace ecommerce.sdk.douyin;

[Description("批量下载qic订单码,批量下载qic订单码，下载后订单进入预绑码状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","存在未维护sku的订单","isv.business-failed:-1","需要维护sku")]
public class OrderCodeBatchGetOrderCodeByShopReq : IDouyinReq<OrderCodeBatchGetOrderCodeByShopRsp>
{

	public string GetMethod() { return "orderCode.batchGetOrderCodeByShop"; }

	public string GetUrl() { return "/orderCode/batchGetOrderCodeByShop"; }

	[JsonPropertyName("order_ids")]
	[Description("订单号列表")]
	[NotNull]
	public List<long> OrderIds { get; set; }
}

[Description("批量下载qic订单码,批量下载qic订单码，下载后订单进入预绑码状态")]
public class OrderCodeBatchGetOrderCodeByShopRsp
{
	[JsonPropertyName("batch_data")]
	[Description("订单码数据")]
	public List<BatchDataItem> BatchData { get; set; }

	public class BatchDataItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public long OrderId { get; set; }

		[JsonPropertyName("order_code")]
		[Description("订单码")]
		public string OrderCode { get; set; }
	}

	[JsonPropertyName("delivery_type")]
	[Description("送检方式")]
	public long DeliveryType { get; set; }

	[JsonPropertyName("ship_type")]
	[Description("出仓方式")]
	public long ShipType { get; set; }
}
