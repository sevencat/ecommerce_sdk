namespace ecommerce.sdk.douyin;

[Description("商家送检实物质检订单（仅实物质检可用，图片质检订单不可用）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","状态检查失败，订单不为商家备货，不可送检","isv.business-failed:10000","无法送检")]
[DouyinRetCode(50002,"业务处理失败","订单不存在","isv.business-failed:4000","请检查订单信息")]
[DouyinRetCode(50002,"业务处理失败","线上质检订单请通过小程序进行操作","isv.business-failed:2001","线上质检订单请通过小程序进行操作")]
[DouyinRetCode(50002,"业务处理失败","2030:参数错误","isv.business-failed:2030","-")]
[DouyinRetCode(50002,"业务处理失败","拦截发货时候请先处理退款请求","isv.business-failed:2036","拦截发货时候请先处理退款请求")]
[DouyinRetCode(50002,"业务处理失败","1201:获取锁失败","isv.business-failed:1201","-")]
public class BtasSaveInspectionInfoReq : IDouyinReq<BtasSaveInspectionInfoRsp>
{

	public string GetMethod() { return "btas.saveInspectionInfo"; }

	public string GetUrl() { return "/btas/saveInspectionInfo"; }

	[JsonPropertyName("order_id")]
	[Description("父订单（店铺单）编号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("product_order_id")]
	[Description("首次录入时必输 商品单ID")]
	public string ProductOrderId { get; set; }

	[JsonPropertyName("order_code")]
	[Description("首次录入时必输 一件商品一个订单码，订单码由字节系统生成。 订单码")]
	public string OrderCode { get; set; }

	[JsonPropertyName("service_status")]
	[Description("枚举值 1: 新增   2: 修改")]
	[NotNull]
	public int? ServiceStatus { get; set; }

	[JsonPropertyName("base_send_logistics_code")]
	[Description("service_status 是2 的时候使用，当且仅当 送检方式为邮寄时，且需要修改送检的运单号时：必输，输入时必须与send_logistics_code不同 若仅需要质检机构发货的信息、拦截发货时 则product_order_id、order_code 必输 优先检查base_send_logistics_code 修改送检面单时，基于该店铺单下的运单号进行修改")]
	public string BaseSendLogisticsCode { get; set; }

	[JsonPropertyName("send_type")]
	[Description("送检方式 1：快递送检：通过物流快递将商品送到质检机构； 2：线下送检：非物流快递将商品送到质检机构； 当选择自发货时，必须使用线下送检 首次录入时用，不支持修改")]
	[NotNull]
	public int? SendType { get; set; }

	[JsonPropertyName("send_logistics_id")]
	[Description("可以为空（线下送检时）；否则必输 物流公司ID，由接口/order/logisticsCompanyList返回的物流公司列表中对应的ID")]
	public string SendLogisticsId { get; set; }

	[JsonPropertyName("send_logistics_company_code")]
	[Description("预留：物流公司编码")]
	public string SendLogisticsCompanyCode { get; set; }

	[JsonPropertyName("send_logistics_code")]
	[Description("可以为空（线下送检时）；否则必输 快递送检运单号")]
	public string SendLogisticsCode { get; set; }

	[JsonPropertyName("is_shipping_self")]
	[Description("0：否  即：质检完成后，质检机构将商品发货给顾客 ,1：是  即：质检完成后，商家拿回商品，自行发货给顾客；或者是大商派人到商家侧完成质检，然后商家自行发货。 该字段与订单取消后流程有关，注意正确传参,,首次录入时用，不支持修改")]
	[NotNull]
	public int? IsShippingSelf { get; set; }

	[JsonPropertyName("shipping_logistics_type")]
	[Description("质检机构发货时的物流类型，可以为空（自发货时）；否则必输入。,1：顺丰标快； 2：顺丰特惠；")]
	public string ShippingLogisticsType { get; set; }

	[JsonPropertyName("insurance_cost")]
	[Description("可以为空（自发货时）；否则必输 质检机构代发货时，若发顾客物流需要保价，则录入保价金额，不能高于订单金额。若无需保价则为0 单位为分")]
	public int? InsuranceCost { get; set; }

	[JsonPropertyName("return_intercept_type")]
	[Description("0：发货优先：线下送检，客户在质检方收货前申请退款，系统将在质检收货环节驳回退款，继续履约。 1：售后优先：线下送检，客户在质检方收货前申请退款，质检方将无法收货鉴定送检商品，并退回给商家（或等待商家处理完成退款申请再做质检）。 自发货时，建议选择正常发货，否则可能出现卡单")]
	[NotNull]
	public int? ReturnInterceptType { get; set; }

	[JsonPropertyName("return_type")]
	[Description("可以为空（自发货时）；否则必输 1：邮寄：若质检过程中订单取消，质检机构将商品邮寄回商家； 2：商家自提：若质检过程中订单取消，商家需要到质检机构处自己取回商品。")]
	public int? ReturnType { get; set; }
}

[Description("商家送检实物质检订单（仅实物质检可用，图片质检订单不可用）")]
public class BtasSaveInspectionInfoRsp
{
}
