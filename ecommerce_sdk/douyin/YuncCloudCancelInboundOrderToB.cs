namespace ecommerce.sdk.douyin;

[Description("此接口已废弃！此接口已废弃！此接口已废弃！此接口已废弃！此接口已废弃！此接口已废弃！,tob入库单取消 请调用 /yunc/erpInboundCancel")]
public class YuncCloudCancelInboundOrderToBReq : IDouyinReq<YuncCloudCancelInboundOrderToBRsp>
{

	public string GetMethod() { return "yunc.CloudCancelInboundOrderToB"; }

	public string GetUrl() { return "/yunc/CloudCancelInboundOrderToB"; }

	[JsonPropertyName("biz_order_no")]
	[Description("入库单号")]
	[NotNull]
	public string BizOrderNo { get; set; }

	[JsonPropertyName("action_type")]
	[Description("操作类型")]
	[NotNull]
	public int? ActionType { get; set; }

	[JsonPropertyName("cancel_reason")]
	[Description("取消原因")]
	[NotNull]
	public string CancelReason { get; set; }

	[JsonPropertyName("order_type")]
	[Description("订单类型")]
	[NotNull]
	public int? OrderType { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺编号")]
	[NotNull]
	public long? ShopId { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }
}

[Description("此接口已废弃！此接口已废弃！此接口已废弃！此接口已废弃！此接口已废弃！此接口已废弃！,tob入库单取消 请调用 /yunc/erpInboundCancel")]
public class YuncCloudCancelInboundOrderToBRsp
{
	[JsonPropertyName("data")]
	[Description("响应数据")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("logistics_no")]
		[Description("lo单号")]
		public string LogisticsNo { get; set; }
	}
}
