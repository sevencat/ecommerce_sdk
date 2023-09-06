namespace ecommerce.sdk.douyin;

[Description("支持同一店铺同一收货人的多个订单发同一个物流包裹")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","无默认售后地址，请先设置然后操作发货","isv.business-failed:70016","请到【抖店左侧导航栏-物流-地址库管理】设置默认售后地址后再操作发货")]
[DouyinRetCode(20000,"系统错误","发货失败，请稍后重试","isp.service-error:70014","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","当前订单存在处理中流程，请稍后重试","isv.business-failed:70011","稍后重试")]
[DouyinRetCode(20000,"系统错误","发货失败，请稍后重试","isp.service-error:70002","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","该订单已售前退款成功，不能发货","isv.business-failed:60068","请更新订单信息")]
[DouyinRetCode(40004,"非法的参数","手机序列号仅支持填写15～17位数字","isv.parameter-invalid:60062","请输入正确的序列号")]
[DouyinRetCode(40002,"缺少必选参数","补贴商品发货时需要上传商品序列号","isv.missing-parameter:60056","补贴商品必须传入序列号，请输入序列号")]
[DouyinRetCode(50002,"业务处理失败","发货订单中有退款申请需要处理，请先处理","isv.business-failed:60040","请先处理该订单的售后单，然后再进行发货")]
[DouyinRetCode(40004,"非法的参数","未查询到此订单","isv.parameter-invalid:60033","订单号不存在，请检查")]
[DouyinRetCode(50002,"业务处理失败","该店铺无默认售后地址，请到【抖店左侧导航栏-物流-地址库管理】设置后再操作发货","isv.business-failed:60027","请到【抖店左侧导航栏-物流-地址库管理】设置默认售后地址后再操作发货")]
[DouyinRetCode(50002,"业务处理失败","订单已取消，不支持发货","isv.business-failed:60021","请更新订单信息")]
[DouyinRetCode(40004,"非法的参数","暂不支持该物流公司或物流商已失效","isv.parameter-invalid:60018","company_code参数错误。请通过/order/logisticsCompanyList接口获取company_code")]
[DouyinRetCode(40004,"非法的参数","物流单号不符合规则","isv.parameter-invalid:60017","company_code和logistics_code不匹配，请检查物流公司和单号是否正确")]
[DouyinRetCode(40002,"缺少必选参数","物流公司Code不能为空","isv.missing-parameter:60011","company_code参数错误。请通过/order/logisticsCompanyList接口获取company_code")]
[DouyinRetCode(40002,"缺少必选参数","订单号不能为空","isv.missing-parameter:50049","请输入正确的订单号")]
[DouyinRetCode(40004,"非法的参数","订单号为空或格式错误","isv.parameter-invalid:50001","请输入正确的订单号")]
[DouyinRetCode(40002,"缺少必选参数","物流公司编码(company_code)字段不能为空。注：物流公司ID(logisitcs_id)字段已废弃","isv.missing-parameter:60083","请通过/order/logisticsCompanyList接口获取company_code")]
[DouyinRetCode(50002,"业务处理失败","60072:该店铺无默认发货地址，请到【抖店左侧导航栏-物流-地址库管理】设置后再操作发货","isv.business-failed:60072","该店铺无默认发货地址，请到【抖店左侧导航栏-物流-地址库管理】设置后再操作发货")]
[DouyinRetCode(50002,"业务处理失败","60046:序列号长度不能超过30位字符","isv.business-failed:60046","若传入了序列号，则序列号长度需要在1-30位字符之间，请检查后重新发货")]
[DouyinRetCode(50002,"业务处理失败","60069:该订单为质检订单，请在商家后台送检页面进行送检发货操作","isv.business-failed:60069","该订单为质检订单，请在商家后台送检页面进行送检发货操作")]
[DouyinRetCode(50002,"业务处理失败","当前发货地址存在异常，请前往抖店PC端「物流-地址库管理」修改后重试","isv.business-failed:60070","当前发货地址存在异常，请前往抖店PC端「物流-地址库管理」修改后重试")]
[DouyinRetCode(50002,"业务处理失败","该订单补贴商品的序列号已经上传，请重新填写","isv.business-failed:60047","该订单补贴商品的序列号已经上传，请重新填写")]
[DouyinRetCode(50002,"业务处理失败","发货失败，请稍后重试","isv.business-failed:70009","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","该订单不支持使用其它物流进行发货","isv.business-failed:60026","请检查订单和物流信息")]
[DouyinRetCode(50002,"业务处理失败","70023:没有能发货的订单，请修改后重试","isv.business-failed:70023","没有能发货的订单，请修改后重试")]
[DouyinRetCode(50002,"业务处理失败","70020:运单号收件人电话及地址与该订单收件人电话及地址均不一致，请核实后更新快递单号","isv.business-failed:70020","运单号收件人电话及地址与该订单收件人电话及地址均不一致，请核实后更新快递单号")]
[DouyinRetCode(50002,"业务处理失败","60016:商品单单号为空或者格式错误","isv.business-failed:60016","商品单单号为空或者格式错误")]
[DouyinRetCode(50002,"业务处理失败","60127:发货信息填写有误，请检查物流单号、物流公司是否填写/选择正确","isv.business-failed:60127","发货信息填写有误，请检查物流单号、物流公司是否填写/选择正确")]
[DouyinRetCode(50002,"业务处理失败","60110:订单已发货，不允许再次执行发货","isv.business-failed:60110","订单已发货，不允许再次执行发货")]
[DouyinRetCode(50002,"业务处理失败","60113:订单已完结，禁止发货","isv.business-failed:60113","订单已完结，禁止发货")]
[DouyinRetCode(50002,"业务处理失败","60124:系统连接错误，请稍后再试","isv.business-failed:60124","系统连接错误，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","8888:系统繁忙，请稍后重试","isv.business-failed:8888","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","60109:订单正在风控审核中，风控审核时效1~2小时，请等待订单变为“备货中”状态后重试","isv.business-failed:60109","订单正在风控审核中，风控审核时效1~2小时，请等待订单变为“备货中”状态后重试")]
[DouyinRetCode(50002,"业务处理失败","60123:当前订单为供应链订单，需: 海口珍珠恋服饰设计有限公司 帮助发货","isv.business-failed:60123","当前订单为供应链订单，需: 海口珍珠恋服饰设计有限公司 帮助发货")]
[DouyinRetCode(50002,"业务处理失败","60138:订单需送货上门，请使用支持送货上门的物流公司发货","isv.business-failed:60138","订单需送货上门，请使用支持送货上门的物流公司发货")]
[DouyinRetCode(50002,"业务处理失败","70021:多个订单的收货人手机号/收货地址不一致，请核对发货数据","isv.business-failed:70021","多个订单的收货人手机号/收货地址不一致，请核对发货数据")]
[DouyinRetCode(50002,"业务处理失败","60101:非本店铺订单，操作失败","isv.business-failed:60101","非本店铺订单，操作失败")]
[DouyinRetCode(50002,"业务处理失败","请传入退货地址，提高退换货的履约准确率","isv.business-failed:700029","请传入退货地址，提高退换货的履约准确率")]
[DouyinRetCode(50002,"业务处理失败","70019:物流单号首条轨迹产生时间早于订单支付时间，请核实后更新单号","isv.business-failed:70019","请检查单号时间")]
[DouyinRetCode(50002,"业务处理失败","70018:物流单号已被快递回收或取消，无法继续使用，请核实后更新单号","isv.business-failed:70018","请检查单号状态")]
[DouyinRetCode(50002,"业务处理失败","60116:订单中商品由平台仓发货，无需手动发货","isv.business-failed:60116","该订单无需手动发货")]
[DouyinRetCode(50002,"业务处理失败","60118:订单售后信息异常，请稍后重试","isv.business-failed:60118","请重试")]
[DouyinRetCode(50002,"业务处理失败","70022:物流单号已被其他订单使用，且收货人手机号/收货地址不一致，请核实后更新单号","isv.business-failed:70022","请跟换物流单号")]
[DouyinRetCode(50002,"业务处理失败","700006:小时达订单不支持拆单发货","isv.business-failed:700006","不支持拆单发货")]
public class OrderLogisticsAddSinglePackReq : IDouyinReq<OrderLogisticsAddSinglePackRsp>
{

	public string GetMethod() { return "order.logisticsAddSinglePack"; }

	public string GetUrl() { return "/order/logisticsAddSinglePack"; }

	[JsonPropertyName("order_id_list")]
	[Description("父订单ID列表")]
	[NotNull]
	public List<string> OrderIdList { get; set; }

	[JsonPropertyName("shipped_order_info")]
	[Description("需要发货的子订单信息")]
	[NotNull]
	public List<ShippedOrderInfoItem> ShippedOrderInfo { get; set; }

	public class ShippedOrderInfoItem
	{
		[JsonPropertyName("shipped_order_id")]
		[Description("需要发货的子订单号")]
		[NotNull]
		public string ShippedOrderId { get; set; }

		[JsonPropertyName("shipped_num")]
		[Description("上述子订单的待发货数")]
		[NotNull]
		public long? ShippedNum { get; set; }

		[JsonPropertyName("shipped_item_ids")]
		[Description("已废弃")]
		public List<string> ShippedItemIds { get; set; }
	}

	[JsonPropertyName("logistics_code")]
	[Description("运单号")]
	[NotNull]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("company")]
	[Description("物流公司名字")]
	public string Company { get; set; }

	[JsonPropertyName("request_id")]
	[Description("请求唯一标识，相同request_id多次请求，第一次请求成功后，后续的请求会触发幂等，会直接返回第一次请求成功的结果，不会实际触发发货。")]
	[NotNull]
	public string RequestId { get; set; }

	[JsonPropertyName("is_reject_refund")]
	[Description("是否拒绝退款申请（true表示拒绝退款，并继续发货；不传或为false表示有退款需要处理，拒绝发货），is_refund_reject和is_reject_refund随机使用一个即可")]
	public bool? IsRejectRefund { get; set; }

	[JsonPropertyName("logistics_id")]
	[Description("已废弃。物流公司ID。请使用company_code字段。")]
	public string LogisticsId { get; set; }

	[JsonPropertyName("company_code")]
	[Description("物流公司Code，由接口/order/logisticsCompanyLis查询物流公司列表获得，必填")]
	public string CompanyCode { get; set; }

	[JsonPropertyName("address_id")]
	[Description("发货地址id")]
	public string AddressId { get; set; }

	[JsonPropertyName("is_refund_reject")]
	[Description("是否拒绝退款申请（true表示拒绝退款，并继续发货；不传或为false表示有退款需要处理，拒绝发货），is_refund_reject和is_reject_refund随机使用一个即可")]
	public bool? IsRefundReject { get; set; }

	[JsonPropertyName("order_serial_number")]
	[Description("订单序列号")]
	public List<OrderSerialNumberItem> OrderSerialNumber { get; set; }

	public class OrderSerialNumberItem
	{
		[JsonPropertyName("order_id")]
		[Description("父订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("serial_number_list")]
		[Description("商品序列号，单个序列号长度不能超过30位字符，其中手机序列号仅支持填写15～17位数字")]
		public List<string> SerialNumberList { get; set; }
	}

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	public long? StoreId { get; set; }

	[JsonPropertyName("after_sale_address_id")]
	[Description("退货地址ID,通过地址库列表【/address/list】接口查询。当传入该字段时，可实现自动审核场景买家退货至商家指定退货地址：例如商家配置的售后小助手以及平台闪电退货规则，会获取发货时传入的after_sale_address_id地址id对应的地址给买家展示进行商品退回；")]
	public long? AfterSaleAddressId { get; set; }
}

[Description("支持同一店铺同一收货人的多个订单发同一个物流包裹")]
public class OrderLogisticsAddSinglePackRsp
{
	[JsonPropertyName("pack_id")]
	[Description("包裹id")]
	public string PackId { get; set; }
}
