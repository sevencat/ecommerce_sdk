namespace ecommerce.sdk.douyin;

[Description("服务商回告清关状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","1000: 非法的参数","isv.parameter-invalid:1000","检查参数是否正确，若确认参数正确请联系工作人员")]
[DouyinRetCode(50002,"业务处理失败","1005:接口调用异常，请重试，多次失败请人工反馈","isv.business-failed:1005","重试，多次失败联系工作人员")]
[DouyinRetCode(50002,"业务处理失败","1004:回告节点时序有误，当前节点为【交易订单已关闭】","isv.business-failed:1004","检查当前单据状态，回告正确的状态")]
[DouyinRetCode(50002,"业务处理失败","1002:参数错误","isv.business-failed:1002","检查参数是否正确，若确认参数正确请联系工作人员")]
[DouyinRetCode(50002,"业务处理失败","3002:参数错误：暂时不支持","isv.business-failed:3002","检查参数是否正确，若确认参数正确请联系工作人员")]
public class CrossborderOrderCustomClearanceReq : IDouyinReq<CrossborderOrderCustomClearanceRsp>
{

	public string GetMethod() { return "crossborder.orderCustomClearance"; }

	public string GetUrl() { return "/crossborder/orderCustomClearance"; }

	[JsonPropertyName("vendor")]
	[Description("字节给供应链服务商定义的编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("order_id")]
	[Description("字节电商平台的交易订单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("status")]
	[Description("清关状态：1开始清关 2清关成功 3清关失败（需要平台接入的异常）")]
	[NotNull]
	public long? Status { get; set; }

	[JsonPropertyName("occurrence_time")]
	[Description("物流状态的真实发生时间，yyyy-MM-dd hh:mi:ss")]
	[NotNull]
	public string OccurrenceTime { get; set; }

	[JsonPropertyName("customs_code")]
	[Description("申报口岸【口岸代码】")]
	[NotNull]
	public string CustomsCode { get; set; }

	[JsonPropertyName("customs_name")]
	[Description("申报口岸【口岸名称】")]
	[NotNull]
	public string CustomsName { get; set; }

	[JsonPropertyName("error_info")]
	[Description("异常信息（【清关失败/异常】状态时，必须提供）")]
	public ErrorInfoItem ErrorInfo { get; set; }

	public class ErrorInfoItem
	{
		[JsonPropertyName("error_code")]
		[Description("发货失败异常码")]
		[NotNull]
		public string ErrorCode { get; set; }

		[JsonPropertyName("error_msg")]
		[Description("详细失败原因")]
		[NotNull]
		public string ErrorMsg { get; set; }
	}
}

[Description("服务商回告清关状态")]
public class CrossborderOrderCustomClearanceRsp
{
}
