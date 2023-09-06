namespace ecommerce.sdk.douyin;

[Description("支持调用后打开（或关闭）卖家针对买家收货地址变更的审核流程")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请重试","isv.business-failed:20003","-")]
[DouyinRetCode(50002,"业务处理失败","开通失败，当前应用未接入spi接口","isv.business-failed:30002","-")]
[DouyinRetCode(50002,"业务处理失败","关闭失败，无权关闭该权限","isv.business-failed:50044","-")]
[DouyinRetCode(50002,"业务处理失败","开启失败，已存在有权限审核改地址的应用","isv.business-failed:50045","-")]
[DouyinRetCode(50002,"业务处理失败","服务器开小差了，请稍后重试","isv.business-failed:20001","请稍后重试")]
public class OrderAddressAppliedSwitchReq : IDouyinReq<OrderAddressAppliedSwitchRsp>
{

	public string GetMethod() { return "order.AddressAppliedSwitch"; }

	public string GetUrl() { return "/order/AddressAppliedSwitch"; }

	[JsonPropertyName("is_allowed")]
	[Description("0代表关闭，不需要审核 1代表开启审核，买家变更需要审核")]
	[NotNull]
	public long? IsAllowed { get; set; }

	[JsonPropertyName("review_type")]
	[Description("0代表异步审核，1表示实时审核")]
	public long? ReviewType { get; set; }
}

[Description("支持调用后打开（或关闭）卖家针对买家收货地址变更的审核流程")]
public class OrderAddressAppliedSwitchRsp
{
}
