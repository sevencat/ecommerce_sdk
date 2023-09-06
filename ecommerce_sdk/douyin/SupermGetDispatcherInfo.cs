namespace ecommerce.sdk.douyin;

[Description("运力呼叫询价/取消呼叫询价（正向）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数非法","isv.parameter-invalid:1000001","参数非法")]
[DouyinRetCode(40002,"缺少必选参数","店铺ID不能为空","isv.missing-parameter:40011","店铺ID不能为空")]
[DouyinRetCode(40002,"缺少必选参数","门店ID不能为空","isv.missing-parameter:40012","门店ID不能为空")]
[DouyinRetCode(40002,"缺少必选参数","订单不能为空","isv.missing-parameter:40013","订单不能为空")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20111","订单查询失败")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20112","门店信息获取失败")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20113","执行单不存在")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20114","流水号为空")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20200","履约内部rpc调用失败")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20211","调用履约呼叫运力失败")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20212","deliverId生成失败,原错误码505")]
[DouyinRetCode(50002,"业务处理失败","非小时达订单不允许使用呼叫运力","isv.business-failed:50110","非小时达订单不允许使用呼叫运力")]
[DouyinRetCode(50002,"业务处理失败","未开通平台运力服务，无法使用。","isv.business-failed:50111","未开通平台运力服务，无法使用。")]
[DouyinRetCode(50002,"业务处理失败","非本店铺订单，呼叫运力失败","isv.business-failed:50112","非本店铺订单，呼叫运力失败")]
[DouyinRetCode(50002,"业务处理失败","发货订单包含非本门店订单，请重试","isv.business-failed:50113","发货订单包含非本门店订单，请重试")]
[DouyinRetCode(50002,"业务处理失败","store_id不存在/错误，超市小时达订单发货需传入订单对应的门店ID","isv.business-failed:50114","store_id不存在/错误，超市小时达订单发货需传入订单对应的门店ID")]
[DouyinRetCode(50002,"业务处理失败","运费获取失败，请重新获取。","isv.business-failed:50211","订单信息异常")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:50216","收件人信息解析失败")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20214","保价服务失败")]
public class SupermGetDispatcherInfoReq : IDouyinReq<SupermGetDispatcherInfoRsp>
{

	public string GetMethod() { return "superm.getDispatcherInfo"; }

	public string GetUrl() { return "/superm/getDispatcherInfo"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("shop_order_id")]
	[Description("订单ID")]
	[NotNull]
	public string ShopOrderId { get; set; }

	[JsonPropertyName("dispatcher_fee_type")]
	[Description("运力费用类型 1: 呼叫运力费用，2:取消运力费用")]
	[NotNull]
	public int? DispatcherFeeType { get; set; }

	[JsonPropertyName("insurance_amount")]
	[Description("保价金额，单位：分")]
	public long? InsuranceAmount { get; set; }
}

[Description("运力呼叫询价/取消呼叫询价（正向）")]
public class SupermGetDispatcherInfoRsp
{
	[JsonPropertyName("dispatcher_fee")]
	[Description("运力费用，单位：分")]
	public long DispatcherFee { get; set; }

	[JsonPropertyName("insurance_fee")]
	[Description("保价费用，单位：分")]
	public long InsuranceFee { get; set; }
}
