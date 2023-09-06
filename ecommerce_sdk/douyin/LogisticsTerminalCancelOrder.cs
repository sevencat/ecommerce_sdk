namespace ecommerce.sdk.douyin;

[Description("物流商取消")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:11000","修改参数")]
[DouyinRetCode(20000,"系统错误","订单不存在","isp.service-error:11005","联系技术")]
[DouyinRetCode(20000,"系统错误","状态机初始化失败","isp.service-error:12001","联系技术")]
[DouyinRetCode(20000,"系统错误","当前状态不允许取消","isp.service-error:12002","联系技术")]
[DouyinRetCode(20000,"系统错误","mq异常","isp.service-error:11002","可重试")]
[DouyinRetCode(20000,"系统错误","数据库异常","isp.service-error:11001","可重试")]
[DouyinRetCode(20000,"系统错误","并发异常","isp.service-error:11017","可重试")]
[DouyinRetCode(50002,"业务处理失败","支付成功29天后不允许取消","isv.business-failed:14001","联系技术")]
[DouyinRetCode(50002,"业务处理失败","不满足电联条件","isv.business-failed:14002","请电联")]
public class LogisticsTerminalCancelOrderReq : IDouyinReq<LogisticsTerminalCancelOrderRsp>
{

	public string GetMethod() { return "logistics.terminalCancelOrder"; }

	public string GetUrl() { return "/logistics/terminalCancelOrder"; }

	[JsonPropertyName("waybillCode")]
	[Description("运单号")]
	public string WaybillCode { get; set; }

	[JsonPropertyName("orderId")]
	[Description("订单号")]
	public string OrderId { get; set; }

	[JsonPropertyName("operationType")]
	[Description("取消类型")]
	public string OperationType { get; set; }

	[JsonPropertyName("backCode")]
	[Description("取回码")]
	public string BackCode { get; set; }

	[JsonPropertyName("operatorName")]
	[Description("操作人姓名")]
	public string OperatorName { get; set; }

	[JsonPropertyName("operatorTel")]
	[Description("操作人号码")]
	public string OperatorTel { get; set; }

	[JsonPropertyName("cancelCode")]
	[Description("取消编码")]
	public string CancelCode { get; set; }

	[JsonPropertyName("cancelReason")]
	[Description("取消原因")]
	public string CancelReason { get; set; }

	[JsonPropertyName("isConnected")]
	[Description("是否接通")]
	public bool? IsConnected { get; set; }

	[JsonPropertyName("call")]
	[Description("是否电联")]
	public bool? Call { get; set; }

	[JsonPropertyName("callNums")]
	[Description("电联次数")]
	public string CallNums { get; set; }

	[JsonPropertyName("callInfo")]
	[Description("电联明细")]
	public List<CallInfoItem> CallInfo { get; set; }

	public class CallInfoItem
	{
		[JsonPropertyName("callNumber")]
		[Description("电联号码（快递员）")]
		public string CallNumber { get; set; }

		[JsonPropertyName("callerName")]
		[Description("电联人姓名（快递员）")]
		public string CallerName { get; set; }

		[JsonPropertyName("receiveNumber")]
		[Description("用户号码")]
		public string ReceiveNumber { get; set; }

		[JsonPropertyName("isConnected")]
		[Description("是否接通")]
		public bool? IsConnected { get; set; }

		[JsonPropertyName("callTime")]
		[Description("电联时间")]
		public string CallTime { get; set; }

		[JsonPropertyName("callDuration")]
		[Description("通话时长")]
		public string CallDuration { get; set; }
	}

	[JsonPropertyName("needConnect")]
	[Description("是否需要电联")]
	public bool? NeedConnect { get; set; }
}

[Description("物流商取消")]
public class LogisticsTerminalCancelOrderRsp
{
}
