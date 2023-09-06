namespace ecommerce.sdk.douyin;

[Description("调用场景：,1、支持修改一单多包（拆单发货）【/order/logisticsAddMultiPack】和合单发货【/order/logisticsAddSinglePack】接口，发货成功的订单；,2、注意：整单发货修改物流请使用【/order/logisticsEdit】接口；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","请求校验物流公司及物流单号失败，请稍后重试","isp.service-error:70013","稍后重试")]
[DouyinRetCode(20000,"系统错误","发货失败，请稍后重试","isp.service-error:70011","请参考接口错误信息，修复后重试")]
[DouyinRetCode(20000,"系统错误","发货失败，请稍后重试","isp.service-error:70008","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","该订单的订单状态不允许发货","isv.business-failed:60021","请重新获取订单信息")]
[DouyinRetCode(40004,"非法的参数","物流单号不符合规则","isv.parameter-invalid:60017","物流单号不符合规则或不匹配")]
[DouyinRetCode(40002,"缺少必选参数","物流公司编码(company_code)字段不能为空。注：物流公司ID(logisitcs_id)字段已废弃","isv.missing-parameter:60083","请通过/order/logisticsCompanyList接口获取company_code")]
[DouyinRetCode(50002,"业务处理失败","60011:物流公司Code不能全为空","isv.business-failed:60011","请通过/order/logisticsCompanyList接口获取company_code")]
[DouyinRetCode(50002,"业务处理失败","暂不支持该物流商，请检查物流商编码后重新发货","isv.business-failed:60018","请通过/order/logisticsCompanyList接口获取company_code")]
[DouyinRetCode(50002,"业务处理失败","发货失败，请稍后重试","isv.business-failed:8888","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","订单不支持使用其它物流进行发货","isv.business-failed:60026","订单不支持使用其它物流进行发货")]
[DouyinRetCode(50002,"业务处理失败","退货地址在地址库不存在，请刷新重试","isv.business-failed:60134","该发货地址在商家地址库不存在，商家重新选择可用的发货地址或者前往抖店PC端「订单-发货管理-物流工具-地址库管理」设置后重试")]
public class OrderLogisticsEditByPackReq : IDouyinReq<OrderLogisticsEditByPackRsp>
{

	public string GetMethod() { return "order.logisticsEditByPack"; }

	public string GetUrl() { return "/order/logisticsEditByPack"; }

	[JsonPropertyName("order_id")]
	[Description("父订单ID，可使用【/order/searchList】接口获取；")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("pack_id")]
	[Description("包裹ID；可使用【/order/orderDetail,】和【/order/searchList】在响应参数中获取delivery_id字段；")]
	[NotNull]
	public string PackId { get; set; }

	[JsonPropertyName("logistics_code")]
	[Description("运单号")]
	[NotNull]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("company_code")]
	[Description("物流公司ID，由接口【/order/logisticsCompanyList】返回的物流公司列表获得，必填")]
	public string CompanyCode { get; set; }

	[JsonPropertyName("logistics_id")]
	[Description("已废弃。物流公司ID。请使用company_code字段。")]
	public string LogisticsId { get; set; }

	[JsonPropertyName("store_id")]
	[Description("门店ID，抖超业务使用")]
	public long? StoreId { get; set; }

	[JsonPropertyName("after_sale_address_id")]
	[Description("退货地址ID,通过地址库列表【/address/list】接口查询。当传入该字段时，可实现自动审核场景买家退货至商家指定退货地址：例如商家配置的售后小助手以及平台闪电退货规则，会获取发货时传入的after_sale_address_id地址id对应的地址给买家展示进行商品退回；")]
	public long? AfterSaleAddressId { get; set; }
}

[Description("调用场景：,1、支持修改一单多包（拆单发货）【/order/logisticsAddMultiPack】和合单发货【/order/logisticsAddSinglePack】接口，发货成功的订单；,2、注意：整单发货修改物流请使用【/order/logisticsEdit】接口；")]
public class OrderLogisticsEditByPackRsp
{
}
