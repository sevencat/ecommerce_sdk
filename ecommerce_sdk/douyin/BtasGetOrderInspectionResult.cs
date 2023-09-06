namespace ecommerce.sdk.douyin;

[Description("获取订单的质检结果.0:未鉴定 1:鉴定通过 2:鉴定失败")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","质检任务不存在，请确认","isv.business-failed:4002","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","订单还未送检","isv.business-failed:-1","先送检，完成质检在查看质检结果")]
public class BtasGetOrderInspectionResultReq : IDouyinReq<BtasGetOrderInspectionResultRsp>
{

	public string GetMethod() { return "btas.getOrderInspectionResult"; }

	public string GetUrl() { return "/btas/getOrderInspectionResult"; }

	[JsonPropertyName("order_code")]
	[Description("订单码")]
	[NotNull]
	public string OrderCode { get; set; }
}

[Description("获取订单的质检结果.0:未鉴定 1:鉴定通过 2:鉴定失败")]
public class BtasGetOrderInspectionResultRsp
{
	[JsonPropertyName("order_id")]
	[Description("父订单（店铺单）编号")]
	public string OrderId { get; set; }

	[JsonPropertyName("product_order_id")]
	[Description("商品单编号")]
	public string ProductOrderId { get; set; }

	[JsonPropertyName("order_code")]
	[Description("订单码")]
	public string OrderCode { get; set; }

	[JsonPropertyName("inspection_result")]
	[Description("鉴定结果")]
	public int InspectionResult { get; set; }

	[JsonPropertyName("certification_code")]
	[Description("证书编号")]
	public string CertificationCode { get; set; }

	[JsonPropertyName("detail")]
	[Description("鉴定明细")]
	public string Detail { get; set; }

	[JsonPropertyName("inspection_comment")]
	[Description("鉴定备注")]
	public string InspectionComment { get; set; }

	[JsonPropertyName("inspection_cost")]
	[Description("鉴定费用")]
	public long InspectionCost { get; set; }

	[JsonPropertyName("logistics_cost")]
	[Description("物流费用")]
	public long LogisticsCost { get; set; }

	[JsonPropertyName("inspection_time")]
	[Description("鉴定结果时间戳（秒）")]
	public string InspectionTime { get; set; }

	[JsonPropertyName("inspection_order_id")]
	[Description("鉴定单ID")]
	public string InspectionOrderId { get; set; }
}
