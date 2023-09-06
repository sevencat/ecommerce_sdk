namespace ecommerce.sdk.douyin;

[Description("快递服务商将运单申报的回执回告至字节平台")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","非法参数，如参数格式错误、参数数据错误","isv.parameter-invalid:1002","请检查参数是否正确，若认为正确请联系工作人员")]
[DouyinRetCode(50002,"业务处理失败","接口调用异常，请重试；多次仍失败，请联系工作人员","isv.business-failed:1005","重试，多次失败请人工反馈")]
public class CrossBorderReceiveReceiptOfCustomsWayBillReq : IDouyinReq<CrossBorderReceiveReceiptOfCustomsWayBillRsp>
{

	public string GetMethod() { return "crossBorder.receiveReceiptOfCustomsWayBill"; }

	public string GetUrl() { return "/crossBorder/receiveReceiptOfCustomsWayBill"; }

	[JsonPropertyName("order_no")]
	[Description("字节平台的订单号")]
	[NotNull]
	public string OrderNo { get; set; }

	[JsonPropertyName("logistics_code")]
	[Description("物流企业代码")]
	[NotNull]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("logistics_no")]
	[Description("物流运单编号")]
	[NotNull]
	public string LogisticsNo { get; set; }

	[JsonPropertyName("return_status")]
	[Description("海关的回执状态")]
	[NotNull]
	public string ReturnStatus { get; set; }

	[JsonPropertyName("return_time")]
	[Description("回执时间，精确到秒")]
	[NotNull]
	public long? ReturnTime { get; set; }

	[JsonPropertyName("return_info")]
	[Description("具体海关回执错误信息。如无，请填空字符串")]
	[NotNull]
	public string ReturnInfo { get; set; }
}

[Description("快递服务商将运单申报的回执回告至字节平台")]
public class CrossBorderReceiveReceiptOfCustomsWayBillRsp
{
}
