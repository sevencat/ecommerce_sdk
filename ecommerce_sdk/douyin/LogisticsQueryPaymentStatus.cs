namespace ecommerce.sdk.douyin;

[Description("支付结果查询")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:10000","换个参数")]
public class LogisticsQueryPaymentStatusReq : IDouyinReq<LogisticsQueryPaymentStatusRsp>
{

	public string GetMethod() { return "logistics.queryPaymentStatus"; }

	public string GetUrl() { return "/logistics/queryPaymentStatus"; }

	[JsonPropertyName("orderId")]
	[Description("订单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("bizType")]
	[Description("ReversePickUp -- 上门取件（默认值，不传为上门取件业务） CabinetPickUp -- 快递柜")]
	public string BizType { get; set; }
}

[Description("支付结果查询")]
public class LogisticsQueryPaymentStatusRsp
{
	[JsonPropertyName("paymentStatus")]
	[Description("1--已支付 0--核重未支付 2--未核重")]
	public string PaymentStatus { get; set; }

	[JsonPropertyName("paymentFee")]
	[Description("用户支付金额")]
	public long PaymentFee { get; set; }

	[JsonPropertyName("insuranceClaimFee")]
	[Description("应理赔金额=激励金 + 保险理赔金额")]
	public long InsuranceClaimFee { get; set; }

	[JsonPropertyName("encourageFee")]
	[Description("激励金")]
	public long EncourageFee { get; set; }

	[JsonPropertyName("platformAllowance")]
	[Description("平台补贴金额")]
	public long PlatformAllowance { get; set; }

	[JsonPropertyName("insureClaimFee")]
	[Description("保险理赔金额")]
	public long InsureClaimFee { get; set; }

	[JsonPropertyName("operationTime")]
	[Description("操作时间")]
	public string OperationTime { get; set; }
}
