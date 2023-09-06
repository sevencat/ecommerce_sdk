namespace ecommerce.sdk.douyin;

[Description("上报上门取件履约过程中的异常")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","必传参数没传","isv.missing-parameter:10000","检查参数正确性")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:10001","寻找对接研发同学排查相关问题")]
[DouyinRetCode(40004,"非法的参数","订单信息不存在","isv.parameter-invalid:10002","检查参数正确性")]
[DouyinRetCode(40004,"非法的参数","物流商错误","isv.parameter-invalid:10003","检查参数正确性")]
[DouyinRetCode(40004,"非法的参数","运单号错误","isv.parameter-invalid:10004","检查参数正确性")]
[DouyinRetCode(50002,"业务处理失败","当前状态不支持上报“无法联系上消费者”","isv.business-failed:10005","检查当前订单状态和电联记录")]
[DouyinRetCode(50002,"业务处理失败","当前状态不支持上报“费用无法达成一致”","isv.business-failed:10006","检查当前订单状态和电联记录")]
[DouyinRetCode(50002,"业务处理失败","当前状态不支持上报“消费者超时未支付运费”","isv.business-failed:10007","检查当前订单状态和电联记录")]
[DouyinRetCode(50002,"业务处理失败","当前状态不支持上报“物品不符合寄递标准”","isv.business-failed:10008","检查当前订单状态和电联记录")]
[DouyinRetCode(50002,"业务处理失败","当前状态不支持上报“不接受实名认证”","isv.business-failed:10009","检查当前订单状态和电联记录")]
[DouyinRetCode(50002,"业务处理失败","不满足电联要求","isv.business-failed:10010","检查是否符合电联要求")]
[DouyinRetCode(50002,"业务处理失败","当前状态不支持二次发起滞留或者取消","isv.business-failed:10011","检查是否二次发起滞留或取消")]
[DouyinRetCode(50002,"业务处理失败","当前状态不支持上报“超时未寄件”","isv.business-failed:10012","检查当前订单状态和电联记录")]
[DouyinRetCode(50002,"业务处理失败","当前状态不支持取消","isv.business-failed:10013","检查当前订单状态")]
public class LogisticsReverseReportExceptionReq : IDouyinReq<LogisticsReverseReportExceptionRsp>
{

	public string GetMethod() { return "logistics.reverse.reportException"; }

	public string GetUrl() { return "/logistics/reverse/reportException"; }

	[JsonPropertyName("waybill_code")]
	[Description("运单号")]
	[NotNull]
	public string WaybillCode { get; set; }

	[JsonPropertyName("express")]
	[Description("物流商编码")]
	[NotNull]
	public string Express { get; set; }

	[JsonPropertyName("order_id")]
	[Description("订单号（下单给到的orderId）")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("reason")]
	[Description("报备原因；详情请参考https://bytedance.feishu.cn/docx/doxcnFoMDormTOfXuG05n4NFpNf的接口18的「报备原因」,UNABLE_TO_CONTACT_CONSUMER——无法联系上消费者。,AGREEMENT_WITH_CONSUMER——与消费者达成一致后取消。,TIMEOUT_NO_PAID——消费者超时未支付运费。,DISAGREEMENT_WITH_FEE——费用无法达成一致。,NO_MEET_CRITERIA——物品不符合寄递标准。,USER_NO_AUTH——用户不接受实名认证。,TIMEOUT_NO_SEND——上门取件订单超时。")]
	[NotNull]
	public string Reason { get; set; }

	[JsonPropertyName("report_status")]
	[Description("报备状态；CANCELED——取消，INTERCEPTED——拦截")]
	[NotNull]
	public string ReportStatus { get; set; }

	[JsonPropertyName("call_info")]
	[Description("电联信息明细（核销前需要电联明细，核销后不需要）")]
	public List<CallInfoItem> CallInfo { get; set; }

	public class CallInfoItem
	{
		[JsonPropertyName("call_number")]
		[Description("电联号码（快递员）")]
		public string CallNumber { get; set; }

		[JsonPropertyName("caller_name")]
		[Description("电联人姓名（快递员）")]
		public string CallerName { get; set; }

		[JsonPropertyName("receive_number")]
		[Description("用户号码")]
		public string ReceiveNumber { get; set; }

		[JsonPropertyName("is_connected")]
		[Description("是否接通")]
		public bool? IsConnected { get; set; }

		[JsonPropertyName("call_time")]
		[Description("电联时间")]
		public string CallTime { get; set; }

		[JsonPropertyName("call_duration")]
		[Description("电联时长（单位秒）")]
		public string CallDuration { get; set; }
	}

	[JsonPropertyName("need_connect")]
	[Description("是否需要电联")]
	public bool? NeedConnect { get; set; }
}

[Description("上报上门取件履约过程中的异常")]
public class LogisticsReverseReportExceptionRsp
{
	[JsonPropertyName("result")]
	[Description("请求是否成功")]
	public bool Result { get; set; }

	[JsonPropertyName("return_code")]
	[Description("请求成功/失败错误码")]
	public string ReturnCode { get; set; }

	[JsonPropertyName("message")]
	[Description("请求失败必填，业务逻辑失败原因描述")]
	public string Message { get; set; }

	[JsonPropertyName("data")]
	[Description("请求成功必填，返回定义的字段信息")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("cur_order_status")]
		[Description("当前订单状态；CANCELED--取消，INTERCEPTED--拦截，STRANDED--滞留")]
		public string CurOrderStatus { get; set; }

		[JsonPropertyName("tip_info")]
		[Description("提示信息（只有滞留才会返回）")]
		public TipInfoItem TipInfo { get; set; }

		public class TipInfoItem
		{
			[JsonPropertyName("tip_code")]
			[Description("提示编码；10000——待用户支付；10001——待消费者操作反馈")]
			public string TipCode { get; set; }

			[JsonPropertyName("tip_message")]
			[Description("提示信息")]
			public string TipMessage { get; set; }
		}
	}
}
