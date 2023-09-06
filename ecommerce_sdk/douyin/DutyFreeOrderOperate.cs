namespace ecommerce.sdk.douyin;

[Description("海南项目服务商回传实操节点")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","接口调用异常，请重试，多次失败请人工反馈","isv.business-failed:99999","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","回告节点时序有误，当前节点为【出库完成】","isv.business-failed:10002","请检查当前节点")]
[DouyinRetCode(50002,"业务处理失败","订单不存在，请联系履约确认是否已推单成功","isv.business-failed:10001","请核实订单信息")]
[DouyinRetCode(50002,"业务处理失败","交易单已关闭，请核实交易单状态","isv.business-failed:10003","请核实交易单状态")]
public class DutyFreeOrderOperateReq : IDouyinReq<DutyFreeOrderOperateRsp>
{

	public string GetMethod() { return "dutyFree.orderOperate"; }

	public string GetUrl() { return "/dutyFree/orderOperate"; }

	[JsonPropertyName("order_id")]
	[Description("订单id")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("occurrence_time")]
	[Description("物流状态的真实发生时间，yyyy-MM-dd hh:mm:ss")]
	[NotNull]
	public string OccurrenceTime { get; set; }

	[JsonPropertyName("status")]
	[Description("节点状态：1 出库异常，2 已出库 ， 3  提货公司揽收异常，4 提货公司已揽收，5 已送达自提点， 6 消费者已提货，7 提货异常，8已核销，9 核销异常")]
	[NotNull]
	public long? Status { get; set; }

	[JsonPropertyName("verification_info")]
	[Description("核销信息，status传入8时必填")]
	public VerificationInfoItem VerificationInfo { get; set; }

	public class VerificationInfoItem
	{
		[JsonPropertyName("leave_type")]
		[Description("离岛工具：1 飞机，2 火车， 3 轮船")]
		[NotNull]
		public long? LeaveType { get; set; }

		[JsonPropertyName("leave_ticket_no")]
		[Description("离岛工具票号")]
		[NotNull]
		public string LeaveTicketNo { get; set; }

		[JsonPropertyName("leave_time")]
		[Description("用户所填交通工具离岛时间 yyyy-MM-dd hh:mm:ss")]
		[NotNull]
		public string LeaveTime { get; set; }
	}

	[JsonPropertyName("transportation")]
	[Description("发货信息，邮寄模式或会员购模式下，status传入2时必填")]
	public TransportationItem Transportation { get; set; }

	public class TransportationItem
	{
		[JsonPropertyName("domestic_carrier")]
		[Description("国内快递公司编码 按字节定义的编码推送")]
		[NotNull]
		public string DomesticCarrier { get; set; }

		[JsonPropertyName("domestic_trans_no")]
		[Description("运单号")]
		[NotNull]
		public string DomesticTransNo { get; set; }
	}

	[JsonPropertyName("error_info")]
	[Description("节点异常，status传入1、3、7、9时必填")]
	public ErrorInfoItem ErrorInfo { get; set; }

	public class ErrorInfoItem
	{
		[JsonPropertyName("error_code")]
		[Description("返回失败编码，商家只回传不可逆转的失败")]
		[NotNull]
		public string ErrorCode { get; set; }

		[JsonPropertyName("error_msg")]
		[Description("返回详细失败原因")]
		[NotNull]
		public string ErrorMsg { get; set; }
	}
}

[Description("海南项目服务商回传实操节点")]
public class DutyFreeOrderOperateRsp
{
}
