namespace ecommerce.sdk.douyin;

[Description("更新代发订单的发货物流信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"服务不可用","发货失败，请稍后重试","isp.service-error:88888","发货失败，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","发货失败","isv.business-failed:41005","请确认代发单状态")]
[DouyinRetCode(50002,"业务处理失败","代发单状态不允许发货","isv.business-failed:41000","请确认代发单状态")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:10000","请确认参数后重试")]
[DouyinRetCode(50002,"业务处理失败","代发单不存在","isv.business-failed:41002","请确认代发单号单是否正确")]
public class IopWaybillUpdateReq : IDouyinReq<IopWaybillUpdateRsp>
{

	public string GetMethod() { return "iop.waybillUpdate"; }

	public string GetUrl() { return "/iop/waybillUpdate"; }

	[JsonPropertyName("user_id")]
	[Description("代打店铺id")]
	[NotNull]
	public long? UserId { get; set; }

	[JsonPropertyName("distr_order_id")]
	[Description("代打订单号")]
	[NotNull]
	public string DistrOrderId { get; set; }

	[JsonPropertyName("track_no")]
	[Description("运单号")]
	[NotNull]
	public string TrackNo { get; set; }

	[JsonPropertyName("company_code")]
	[Description("快递公司")]
	[NotNull]
	public string CompanyCode { get; set; }

	[JsonPropertyName("delivery_id")]
	[Description("运单id")]
	[NotNull]
	public string DeliveryId { get; set; }
}

[Description("更新代发订单的发货物流信息")]
public class IopWaybillUpdateRsp
{
	[JsonPropertyName("return_result")]
	[Description("操作结果")]
	public bool ReturnResult { get; set; }

	[JsonPropertyName("delivery_id")]
	[Description("运单id")]
	public string DeliveryId { get; set; }
}
