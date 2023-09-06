namespace ecommerce.sdk.douyin;

[Description("获取交易订单状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","订单号不存在","isv.business-failed:1005","订单号不存在")]
[DouyinRetCode(50002,"业务处理失败","orderId值不能为空！","isv.business-failed:1002","校验参数")]
public class CrossBorderGetTradeOrderStatusReq : IDouyinReq<CrossBorderGetTradeOrderStatusRsp>
{

	public string GetMethod() { return "crossBorder.getTradeOrderStatus"; }

	public string GetUrl() { return "/crossBorder/getTradeOrderStatus"; }

	[JsonPropertyName("vendor")]
	[Description("服务商编码")]
	public string Vendor { get; set; }

	[JsonPropertyName("order_id")]
	[Description("订单id")]
	public string OrderId { get; set; }
}

[Description("获取交易订单状态")]
public class CrossBorderGetTradeOrderStatusRsp
{
	[JsonPropertyName("order_status")]
	[Description("订单状态")]
	public long OrderStatus { get; set; }

	[JsonPropertyName("final_status")]
	[Description("最终状态")]
	public long FinalStatus { get; set; }
}
