namespace ecommerce.sdk.douyin;

[Description("呼叫运力并发货/重新发货，取消运力呼叫")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","店铺ID不能为空","isv.missing-parameter:40001","店铺ID不能为空")]
[DouyinRetCode(40002,"缺少必选参数","门店ID不能为空","isv.missing-parameter:40002","门店ID不能为空")]
[DouyinRetCode(40002,"缺少必选参数","订单不能为空","isv.missing-parameter:40003","订单不能为空")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20101","订单查询失败")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20102","门店信息获取失败")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20103","执行单不存在,原错误码80002")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20104","流水号为空")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20200","履约内部rpc调用失败,原错误码503")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20201","调用履约呼叫运力失败")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20202","deliverId生成失败,原错误码505")]
[DouyinRetCode(50002,"业务处理失败","非小时达订单不允许使用呼叫运力","isv.business-failed:50100","非小时达订单不允许使用呼叫运力")]
[DouyinRetCode(50002,"业务处理失败","未开通平台运力服务，无法使用。","isv.business-failed:50101","未开通平台运力服务，无法使用。")]
[DouyinRetCode(50002,"业务处理失败","非本店铺订单，呼叫运力失败","isv.business-failed:50102","非本店铺订单，呼叫运力失败")]
[DouyinRetCode(50002,"业务处理失败","发货订单包含非本门店订单，请重试","isv.business-failed:50103","发货订单包含非本门店订单，请重试")]
[DouyinRetCode(50002,"业务处理失败","store_id不存在/错误，超市小时达订单发货需传入订单对应的门店ID","isv.business-failed:50104","store_id不存在/错误，超市小时达订单发货需传入订单对应的门店ID")]
[DouyinRetCode(50002,"业务处理失败","运费获取失败，请重新获取。","isv.business-failed:50201","订单信息异常，sku信息为空")]
[DouyinRetCode(50002,"业务处理失败","运费获取失败，请重新获取。","isv.business-failed:50202","订单信息异常，地址信息解析失败")]
[DouyinRetCode(50002,"业务处理失败","运费获取失败，请重新获取。","isv.business-failed:50203","订单信息异常，地址信息解析失败")]
[DouyinRetCode(50002,"业务处理失败","运费获取失败，请重新获取。","isv.business-failed:50204","订单信息异常，重量为空")]
[DouyinRetCode(50002,"业务处理失败","运费获取失败，请重新获取。","isv.business-failed:50205","订单信息异常，门店作业时间为空")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:50206","收件人信息解析失败")]
[DouyinRetCode(50002,"业务处理失败","订单当前状态无法取消运力","isv.business-failed:50301","订单当前状态无法取消运力")]
[DouyinRetCode(50002,"业务处理失败","未开通平台运力服务，无法使用","isv.business-failed:50111","未开通平台运力服务，无法使用")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:20113","系统异常，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","订单当前状态无法取消运力","isv.business-failed:50311","订单当前状态无法取消运力")]
[DouyinRetCode(50002,"业务处理失败","呼叫运力失败，请稍后重试","isv.business-failed:120047","呼叫运力失败，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","订单未成功呼叫运力，取消失败","isv.business-failed:20211","订单未成功呼叫运力，取消失败")]
[DouyinRetCode(50002,"业务处理失败","订单不存在","isv.business-failed:20111","订单不存在")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20214","保价服务失败")]
[DouyinRetCode(20001,"内部服务超时","订单已有骑手接单配送，无需重复呼叫运力","isp.service-timeout-error:20301","订单已有骑手接单配送，无需重复呼叫运力")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:50211","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","门店未订购平台运力服务，无法呼叫运力","isv.business-failed:60000","门店未订购平台运力服务，无法呼叫运力")]
public class SupermShopOrderDispatcherReq : IDouyinReq<SupermShopOrderDispatcherRsp>
{

	public string GetMethod() { return "superm.shopOrderDispatcher"; }

	public string GetUrl() { return "/superm/shopOrderDispatcher"; }

	[JsonPropertyName("store_id")]
	[Description("店铺ID")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("shop_order_id")]
	[Description("订单号")]
	[NotNull]
	public string ShopOrderId { get; set; }

	[JsonPropertyName("dispatcher_type")]
	[Description("enum DispatcherType {     Call   = 1 // 呼叫运力     Cancel = 2 // 取消运力 }")]
	[NotNull]
	public int? DispatcherType { get; set; }

	[JsonPropertyName("serial_number_list")]
	[Description("序列码列表，如果包含有多个序列码，请用_英文下划线分割（属于数码手机类目的商品订单才需要传序列码。）")]
	public string SerialNumberList { get; set; }

	[JsonPropertyName("verify_code_type")]
	[Description("是否需要取件码(针对呼叫运力),0否1是")]
	public int? VerifyCodeType { get; set; }

	[JsonPropertyName("insurance_amount")]
	[Description("保价金额，单位：分")]
	public long? InsuranceAmount { get; set; }
}

[Description("呼叫运力并发货/重新发货，取消运力呼叫")]
public class SupermShopOrderDispatcherRsp
{
	[JsonPropertyName("pickup_code")]
	[Description("取件码")]
	public string PickupCode { get; set; }
}
