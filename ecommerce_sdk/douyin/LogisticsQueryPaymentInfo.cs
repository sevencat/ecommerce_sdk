namespace ecommerce.sdk.douyin;

[Description("末端服务商查询订单支付结果")]
public class LogisticsQueryPaymentInfoReq : IDouyinReq<LogisticsQueryPaymentInfoRsp>
{

	public string GetMethod() { return "logistics.queryPaymentInfo"; }

	public string GetUrl() { return "/logistics/queryPaymentInfo"; }

	[JsonPropertyName("bizType")]
	[Description("业务类型；,枚举：COURIER_STATION —— 驿站寄件")]
	[NotNull]
	public string BizType { get; set; }

	[JsonPropertyName("orderId")]
	[Description("订单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("partnerCode")]
	[Description("末端服务商编码")]
	[NotNull]
	public string PartnerCode { get; set; }

	[JsonPropertyName("postCode")]
	[Description("驿站编码")]
	[NotNull]
	public string PostCode { get; set; }

	[JsonPropertyName("postName")]
	[Description("驿站名称")]
	[NotNull]
	public string PostName { get; set; }
}

[Description("末端服务商查询订单支付结果")]
public class LogisticsQueryPaymentInfoRsp
{
	[JsonPropertyName("errCode")]
	[Description("失败原因编码（处理成功默认回传“0”）")]
	public string ErrCode { get; set; }

	[JsonPropertyName("errReason")]
	[Description("失败原因描述")]
	public string ErrReason { get; set; }

	[JsonPropertyName("message")]
	[Description("支付信息")]
	public MessageItem Message { get; set; }

	public class MessageItem
	{
		[JsonPropertyName("paymentStatus")]
		[Description("支付结果,枚举：0--核重未支付，1--已支付，2--未核重核，3--已退款")]
		public string PaymentStatus { get; set; }

		[JsonPropertyName("paymentFee")]
		[Description("用户支付金额（单位：分）")]
		public long PaymentFee { get; set; }

		[JsonPropertyName("insuranceClaimFee")]
		[Description("应理赔金额（单位：分）")]
		public long InsuranceClaimFee { get; set; }

		[JsonPropertyName("encourageFee")]
		[Description("激励金（单位：分）")]
		public long EncourageFee { get; set; }

		[JsonPropertyName("operationTime")]
		[Description("操作时间（格式：yyyy-MM-dd HH:mm:ss，24小时制）")]
		public string OperationTime { get; set; }
	}
}
