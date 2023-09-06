namespace ecommerce.sdk.douyin;

[Description("调用场景：,1、仅支持整单发货【/order/logisticsAdd】接口，发货成功的订单更新；,2、支持已发货订单（final_status=3）的发货物流信息更新；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","此订单状态不允许重新发货","isv.business-failed:10007","请重新获取订单信息")]
[DouyinRetCode(40004,"非法的参数","运单号不符合规则，请核对单号大小写、单号位数、快递公司是否正确","isv.parameter-invalid:10002","请检查物流公司与物流单号是否匹配")]
[DouyinRetCode(20000,"系统错误","重新发货失败，请稍后重试","isp.service-error:10001","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","60024:该订单不可自行操作重新发货，请联系跨境服务商进行操作","isv.business-failed:60024","联系跨境服务商进行处理")]
[DouyinRetCode(50002,"业务处理失败","物流单号错误。原因：发货信息填写有误，请检查物流单号、物流公司是否填写/选择正确","isv.business-failed:60017","请检查物流公司与物流单号是否匹配")]
[DouyinRetCode(50002,"业务处理失败","物流公司错误。原因：暂不支持该物流商，请检查物流商编码后重新发货","isv.business-failed:60018","请检查物流公司与物流单号是否匹配")]
[DouyinRetCode(50002,"业务处理失败","该订单的订单状态不允许重新发货","isv.business-failed:60021","请检查订单状态是否允许发货")]
[DouyinRetCode(40004,"非法的参数","物流公司编码(company_code)字段不能为空。注：物流公司ID(logisitcs_id)字段已废弃","isv.parameter-invalid:60083","请检查物流公司与物流单号是否匹配")]
[DouyinRetCode(50002,"业务处理失败","物流单号校验失败，请稍后重试","isv.business-failed:70013","请检查物流公司与物流单号是否匹配")]
[DouyinRetCode(40004,"非法的参数","物流单号不能为空","isv.parameter-invalid:60014","请检查物流公司与物流单号是否匹配")]
[DouyinRetCode(50002,"业务处理失败","该订单为质检订单，请在商家后台送检页面进行送检发货操作","isv.business-failed:60023","请在商家后台送检页面进行送检发货")]
[DouyinRetCode(20000,"系统错误","重新发货失败，请稍后重试","isp.service-error:70008","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","该订单不支持使用其它物流进行发货","isv.business-failed:60026","不支持使用其他物流发货")]
[DouyinRetCode(50002,"业务处理失败","退货地址在地址库不存在，请刷新重试","isv.business-failed:60134","该发货地址在商家地址库不存在，商家重新选择可用的发货地址或者前往抖店PC端「订单-发货管理-物流工具-地址库管理」设置后重试")]
[DouyinRetCode(50002,"业务处理失败","70011:包裹单号缺失，请修改后重试","isv.business-failed:70011","仅支持整单接口发货的物流修改，如订单是一单多包或合单发货的订单，请使用【/order/logisticsEditByPack】接口更新；")]
public class OrderLogisticsEditReq : IDouyinReq<OrderLogisticsEditRsp>
{

	public string GetMethod() { return "order.logisticsEdit"; }

	public string GetUrl() { return "/order/logisticsEdit"; }

	[JsonPropertyName("order_id")]
	[Description("订单ID")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("logistics_id")]
	[Description("已废弃。物流公司ID。请使用company_code字段。")]
	public long? LogisticsId { get; set; }

	[JsonPropertyName("company_code")]
	[Description("物流公司code,由接口/order/logisticsCompanyList返回的物流公司列表获得，必填")]
	public string CompanyCode { get; set; }

	[JsonPropertyName("logistics_code")]
	[Description("快递单号")]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("company")]
	[Description("已废弃。物流公司名称")]
	public string Company { get; set; }

	[JsonPropertyName("store_id")]
	[Description("门店ID，抖超业务使用")]
	public long? StoreId { get; set; }

	[JsonPropertyName("after_sale_address_id")]
	[Description("退货地址ID,通过地址库列表【/address/list】接口查询。当传入该字段时，可实现自动审核场景买家退货至商家指定退货地址：例如商家配置的售后小助手以及平台闪电退货规则，会获取发货时传入的after_sale_address_id地址id对应的地址给买家展示进行商品退回；")]
	public long? AfterSaleAddressId { get; set; }
}

[Description("调用场景：,1、仅支持整单发货【/order/logisticsAdd】接口，发货成功的订单更新；,2、支持已发货订单（final_status=3）的发货物流信息更新；")]
public class OrderLogisticsEditRsp
{
}
