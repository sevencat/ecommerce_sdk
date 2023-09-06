namespace ecommerce.sdk.douyin;

[Description("使用场景：,当调用【/order/batchDecrypt】接口，返回参数is_virtual_tel=true并且订单需在可解密状态下；当虚拟号无法满足当前业务使用时；调用该接口进行报备，报备成功后再次调用【/order/batchDecrypt】接口进行解密成明文；,注意：订单不满足解密要求的时候，先调用报备接口即使报备成功依然无法解密")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:88888","重试")]
[DouyinRetCode(40004,"非法的参数","申请数量不能超过100","isv.parameter-invalid:10005","减少请求量")]
[DouyinRetCode(40002,"缺少必选参数","申请信息不能为空","isv.missing-parameter:10004","输入请求参数")]
public class OrderOrdeReportListReq : IDouyinReq<OrderOrdeReportListRsp>
{

	public string GetMethod() { return "order.ordeReportList"; }

	public string GetUrl() { return "/order/ordeReportList"; }

	[JsonPropertyName("add_real_mobile_whites")]
	[Description("报备请求")]
	[NotNull]
	public List<AddRealMobileWhitesItem> AddRealMobileWhites { get; set; }

	public class AddRealMobileWhitesItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单号，订单号和售后单号只需选择一个传入即可")]
		public string OrderId { get; set; }

		[JsonPropertyName("after_sale_id")]
		[Description("售后单号，订单号和售后单号只需选择一个传入即可")]
		public string AfterSaleId { get; set; }

		[JsonPropertyName("reason_no")]
		[Description("报备原因编码：1-无法发货，2-无法处理售后，3-无法处理客诉，4-无法处理物流包裹，5-其他原因")]
		[NotNull]
		public long? ReasonNo { get; set; }

		[JsonPropertyName("remark")]
		[Description("报备备注")]
		public string Remark { get; set; }
	}
}

[Description("使用场景：,当调用【/order/batchDecrypt】接口，返回参数is_virtual_tel=true并且订单需在可解密状态下；当虚拟号无法满足当前业务使用时；调用该接口进行报备，报备成功后再次调用【/order/batchDecrypt】接口进行解密成明文；,注意：订单不满足解密要求的时候，先调用报备接口即使报备成功依然无法解密")]
public class OrderOrdeReportListRsp
{
	[JsonPropertyName("add_real_mobile_whites")]
	[Description("报备响应")]
	public List<AddRealMobileWhitesItem> AddRealMobileWhites { get; set; }

	public class AddRealMobileWhitesItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("after_sale_id")]
		[Description("售后单号")]
		public string AfterSaleId { get; set; }

		[JsonPropertyName("msg")]
		[Description("报备失败原因")]
		public string Msg { get; set; }
	}
}
