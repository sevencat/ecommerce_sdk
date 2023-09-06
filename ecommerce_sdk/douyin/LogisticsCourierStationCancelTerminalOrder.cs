namespace ecommerce.sdk.douyin;

[Description("驿站寄件场景，驿站主动取消订单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","-","isp.service-error:10001","修改请求参数")]
[DouyinRetCode(20000,"系统错误","-","isp.service-error:10002","接口重试")]
[DouyinRetCode(20000,"系统错误","-","isp.service-error:10003","联系开发人员")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10101","订单不存在")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10104","订单当前状态不允许取消")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10105","订单当前状态不允许拦截")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10110","不支持重复取消")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10111","不支持重复拦截")]
public class LogisticsCourierStationCancelTerminalOrderReq : IDouyinReq<LogisticsCourierStationCancelTerminalOrderRsp>
{

	public string GetMethod() { return "logistics.courierStation.cancelTerminalOrder"; }

	public string GetUrl() { return "/logistics/courierStation/cancelTerminalOrder"; }

	[JsonPropertyName("orderId")]
	[Description("订单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("cancelCode")]
	[Description("取消/拦截原因编码（枚举值参考OPENAPI，联系对接研发）")]
	[NotNull]
	public string CancelCode { get; set; }

	[JsonPropertyName("cancelReason")]
	[Description("取消/拦截原因描述")]
	public string CancelReason { get; set; }

	[JsonPropertyName("operationTime")]
	[Description("操作时间（格式：yyyy-MM-dd HH:mm:ss，24小时制）")]
	[NotNull]
	public string OperationTime { get; set; }

	[JsonPropertyName("bizType")]
	[Description("业务类型；,枚举：COURIER_STATION--驿站寄件")]
	[NotNull]
	public string BizType { get; set; }

	[JsonPropertyName("partnerCode")]
	[Description("服务商编码")]
	[NotNull]
	public string PartnerCode { get; set; }

	[JsonPropertyName("postCode")]
	[Description("驿站编码")]
	public string PostCode { get; set; }

	[JsonPropertyName("postName")]
	[Description("驿站名称")]
	public string PostName { get; set; }

	[JsonPropertyName("status")]
	[Description("状态；,枚举：Canceled--取消，Intercepted--拦截")]
	[NotNull]
	public string Status { get; set; }

	[JsonPropertyName("brandCode")]
	[Description("品牌编码")]
	[NotNull]
	public string BrandCode { get; set; }
}

[Description("驿站寄件场景，驿站主动取消订单")]
public class LogisticsCourierStationCancelTerminalOrderRsp
{
	[JsonPropertyName("errCode")]
	[Description("失败原因编码（处理成功默认回传“0”）")]
	public string ErrCode { get; set; }

	[JsonPropertyName("errReason")]
	[Description("失败原因描述")]
	public string ErrReason { get; set; }
}
