namespace ecommerce.sdk.douyin;

[Description("电子面单追加子单号场景；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","订单状态不为接货中,不允许拆单","isv.parameter-invalid:10000","订单状态不为接货中,不允许拆单")]
[DouyinRetCode(50002,"业务处理失败","电子面单号不存在","isv.business-failed:10014","输入正确的面单号")]
[DouyinRetCode(50002,"业务处理失败","订单已生成路由不能申请子单","isv.business-failed:8168","订单已生成路由不能申请子单")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:400","参数错误")]
[DouyinRetCode(50002,"业务处理失败","目标服务异常或不可达","isv.business-failed:4007","目标服务异常或不可达")]
[DouyinRetCode(50002,"业务处理失败","订单已取消，不允许变更","isv.business-failed:10901","订单已取消，不允许变更，请检查订单状态")]
[DouyinRetCode(50002,"业务处理失败","4009:请求物流服务商超时         !","isv.business-failed:4009","请重试")]
public class LogisticsAppendSubOrderReq : IDouyinReq<LogisticsAppendSubOrderRsp>
{

	public string GetMethod() { return "logistics.appendSubOrder"; }

	public string GetUrl() { return "/logistics/appendSubOrder"; }

	[JsonPropertyName("track_no")]
	[Description("运单号")]
	[NotNull]
	public string TrackNo { get; set; }

	[JsonPropertyName("logistics_code")]
	[Description("物流商编码")]
	[NotNull]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("pack_add_quantity")]
	[Description("追加个数")]
	[NotNull]
	public int? PackAddQuantity { get; set; }

	[JsonPropertyName("is_return_full_sub_codes")]
	[Description("是否返回全量的子单号")]
	public bool? IsReturnFullSubCodes { get; set; }
}

[Description("电子面单追加子单号场景；")]
public class LogisticsAppendSubOrderRsp
{
	[JsonPropertyName("track_no")]
	[Description("运单号")]
	public string TrackNo { get; set; }

	[JsonPropertyName("pack_quantity")]
	[Description("子母单数量")]
	public long PackQuantity { get; set; }

	[JsonPropertyName("sub_waybill_codes")]
	[Description("新追加的子单号")]
	public string SubWaybillCodes { get; set; }
}
