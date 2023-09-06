namespace ecommerce.sdk.douyin;

[Description("逆向支付信息查询")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","10000:不存在对应的取件信息","isv.business-failed:10000","输入的订单不存在，不可重试")]
public class PowerQueryPaymentStatusReq : IDouyinReq<PowerQueryPaymentStatusRsp>
{

	public string GetMethod() { return "power.queryPaymentStatus"; }

	public string GetUrl() { return "/power/queryPaymentStatus"; }

	[JsonPropertyName("order_id")]
	[Description("订单号")]
	public string OrderId { get; set; }

	[JsonPropertyName("biz_type")]
	[Description("业务类型")]
	public string BizType { get; set; }
}

[Description("逆向支付信息查询")]
public class PowerQueryPaymentStatusRsp
{
	[JsonPropertyName("payment_status")]
	[Description("1--已支付 0--核重未支付 2--未核重")]
	public string PaymentStatus { get; set; }

	[JsonPropertyName("payment_fee")]
	[Description("用户支付金额（分）")]
	public long PaymentFee { get; set; }

	[JsonPropertyName("insurance_claim_fee")]
	[Description("应理赔金额（分）= 激励金额 + 保险理赔金额")]
	public long InsuranceClaimFee { get; set; }

	[JsonPropertyName("encourage_fee")]
	[Description("激励金额（分）")]
	public long EncourageFee { get; set; }

	[JsonPropertyName("platform_allowance")]
	[Description("平台补贴金额(分)")]
	public long PlatformAllowance { get; set; }

	[JsonPropertyName("insure_claim_fee")]
	[Description("保险理赔金额(分)")]
	public long InsureClaimFee { get; set; }

	[JsonPropertyName("operation_time")]
	[Description("状态对应的操作时间")]
	public string OperationTime { get; set; }
}
