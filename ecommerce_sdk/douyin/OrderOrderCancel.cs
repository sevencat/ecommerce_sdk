namespace ecommerce.sdk.douyin;

[Description("1、订单为买家待支付状态时，支持商家主动取消待支付订单。该接口规则同抖店【订单管理-批量取消-取消订单】功能，主要解决：避免多渠道商家超卖和提升商家取消恶意预占库存订单效率 2、仅主订单维度取消订单 3、注意：确认取消订单后，取消原因将以短信的形式发送至买家，请确保已和买家协商达成一致，否则您将面临投诉或赔偿 4、cancel_reason请填写枚举值中的中文描述必须一模一样，请勿自定义信息，否则无法通过接口校验；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","订单已取消","isv.business-failed:50005","订单已取消，无需重试")]
[DouyinRetCode(50002,"业务处理失败","距用户下单时间未超过1分钟，请稍后再试","isv.business-failed:50007","距用户下单时间未超过1分钟，请稍后再试")]
[DouyinRetCode(40002,"缺少必选参数","订单id不能为空","isv.missing-parameter:50001","订单id不能为空")]
[DouyinRetCode(40002,"缺少必选参数","缺少必选参数","isv.missing-parameter:50002","请检查参数")]
[DouyinRetCode(40002,"缺少必选参数","缺少必选参数","isv.missing-parameter:50003","请检查参数")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:50004","业务处理失败，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:70007","业务处理失败，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:50021","业务处理失败，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:50060","业务处理失败，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","定金预售订单不支持取消","isv.business-failed:50047","定金预售订单不支持取消")]
[DouyinRetCode(50002,"业务处理失败","当前订单为竞拍订单，不允许取消","isv.business-failed:50061","当前订单为竞拍订单，不允许取消")]
[DouyinRetCode(50002,"业务处理失败","当前订单使用了跨店优惠，仅允许买家主动取消","isv.business-failed:50048","当前订单使用了跨店优惠，仅允许买家主动取消")]
[DouyinRetCode(50002,"业务处理失败","保险类订单不支持取消","isv.business-failed:50046","保险类订单不支持取消")]
[DouyinRetCode(50002,"业务处理失败","拍卖类订单不支持取消","isv.business-failed:50057","拍卖类订单不支持取消")]
[DouyinRetCode(50002,"业务处理失败","拍卖保证金订单不支持取消","isv.business-failed:50058","拍卖保证金订单不支持取消")]
[DouyinRetCode(50002,"业务处理失败","货到付款订单已完成后不允许取消","isv.business-failed:50059","货到付款订单已完成后不允许取消")]
[DouyinRetCode(50002,"业务处理失败","货到付款订单已发货后不允许取","isv.business-failed:50008","货到付款订单已发货后不允许取")]
[DouyinRetCode(80000,"风控拦截","业务处理失败","isv.risk-control-failed:50999","业务处理失败，请检查取消原因")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:20003","系统异常，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:50009","系统异常，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","已付款订单不允许取消","isv.business-failed:50006","已付款订单不允许取消")]
public class OrderOrderCancelReq : IDouyinReq<OrderOrderCancelRsp>
{

	public string GetMethod() { return "order.orderCancel"; }

	public string GetUrl() { return "/order/orderCancel"; }

	[JsonPropertyName("shop_order_id")]
	[Description("店铺主订单号")]
	[NotNull]
	public string ShopOrderId { get; set; }

	[JsonPropertyName("cancel_reason")]
	[Description("取消原因必须是如下枚举之一：①：用户重复下单②：用户不想买了③：用户买错了/信息填错了④重新下单、联系不上用户⑥：快递无法配送至用户地址⑦：其他；注意请使用枚举值信息，如“用户重复下单”必须要一致，开发者请勿自定义或带有空格等信息，否则无法通过接口校验；")]
	[NotNull]
	public string CancelReason { get; set; }
}

[Description("1、订单为买家待支付状态时，支持商家主动取消待支付订单。该接口规则同抖店【订单管理-批量取消-取消订单】功能，主要解决：避免多渠道商家超卖和提升商家取消恶意预占库存订单效率 2、仅主订单维度取消订单 3、注意：确认取消订单后，取消原因将以短信的形式发送至买家，请确保已和买家协商达成一致，否则您将面临投诉或赔偿 4、cancel_reason请填写枚举值中的中文描述必须一模一样，请勿自定义信息，否则无法通过接口校验；")]
public class OrderOrderCancelRsp
{
}
