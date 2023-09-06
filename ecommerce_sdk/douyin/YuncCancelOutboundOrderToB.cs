namespace ecommerce.sdk.douyin;

[Description("toB场景取消出库单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","订单状态不允许取消","isv.business-failed:62302623","订单不允许取消")]
[DouyinRetCode(50002,"业务处理失败","100102:取消指令实操取消失败","isv.business-failed:100102","取消指令实操取消失败")]
[DouyinRetCode(50002,"业务处理失败","4004:warehouse outbound operation error","isv.business-failed:4004","出库操作失败")]
[DouyinRetCode(20001,"内部服务超时","1103:服务超时，请重试","isp.service-timeout-error:1103","请重试")]
[DouyinRetCode(50002,"业务处理失败","500:500","isv.business-failed:500","500")]
[DouyinRetCode(50002,"业务处理失败","9023:取消指令实操取消失败","isv.business-failed:9023","取消指令实操取消失败")]
public class YuncCancelOutboundOrderToBReq : IDouyinReq<YuncCancelOutboundOrderToBRsp>
{

	public string GetMethod() { return "yunc.cancelOutboundOrderToB"; }

	public string GetUrl() { return "/yunc/cancelOutboundOrderToB"; }

	[JsonPropertyName("erp_order_no")]
	[Description("erp出库单号")]
	[NotNull]
	public string ErpOrderNo { get; set; }

	[JsonPropertyName("op_type")]
	[Description("操作类型 枚举值：0【取消】、1【拦截】")]
	[NotNull]
	public long? OpType { get; set; }

	[JsonPropertyName("cancel_tag")]
	[Description("取消标记，枚举值：0【整单取消】")]
	[NotNull]
	public long? CancelTag { get; set; }

	[JsonPropertyName("cancel_reason")]
	[Description("取消原因")]
	[NotNull]
	public string CancelReason { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }
}

[Description("toB场景取消出库单")]
public class YuncCancelOutboundOrderToBRsp
{
	[JsonPropertyName("data")]
	[Description("响应")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("logistics_no")]
		[Description("物流订单号")]
		public string LogisticsNo { get; set; }
	}
}
