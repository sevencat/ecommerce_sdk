namespace ecommerce.sdk.douyin;

[Description("买家地址变更确认,卖家同意地址变更")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","该任务已经被取消:发起售后自动取消审核任务","isv.business-failed:50042","请检查订单状态")]
[DouyinRetCode(50002,"业务处理失败","该任务已经被驳回:订单已进入发货环节","isv.business-failed:50041","请检查订单状态")]
[DouyinRetCode(50002,"业务处理失败","该任务已经被通过","isv.business-failed:50040","该任务已经被通过")]
[DouyinRetCode(40004,"非法的参数","该订单不存在修改地址审核记录","isv.parameter-invalid:50039","不存在审核记录，请检查")]
[DouyinRetCode(40004,"非法的参数","审核开关未打开","isv.parameter-invalid:50038","审核开关未打开，请检查")]
[DouyinRetCode(50002,"业务处理失败","审核失败，当前app id无权审核用户的修改地址请求","isv.business-failed:50036","审核失败，当前app id无权审核用户的修改地址请求")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请重试","isv.business-failed:20003","系统异常，请重试")]
public class OrderAddressConfirmReq : IDouyinReq<OrderAddressConfirmRsp>
{

	public string GetMethod() { return "order.addressConfirm"; }

	public string GetUrl() { return "/order/addressConfirm"; }

	[JsonPropertyName("order_id")]
	[Description("主订单id，注意请求时order/list或 order/detail中返回的主订单id带的‘A’需要截断掉")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("is_approved")]
	[Description("0:同意; 拒绝需要传入以下参数： 1001:订单已进入拣货环节 1002:订单已进入配货环节 1003:订单已进入仓库环节 1004:订单已进入出库环节 1005:订单已进入发货环节")]
	[NotNull]
	public long? IsApproved { get; set; }
}

[Description("买家地址变更确认,卖家同意地址变更")]
public class OrderAddressConfirmRsp
{
}
