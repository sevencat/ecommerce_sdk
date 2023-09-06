namespace ecommerce.sdk.douyin;

[Description("isv获取虚拟号通话状态申请")]
public class PowerSubscribeVirtualTelCallStatusReq : IDouyinReq<PowerSubscribeVirtualTelCallStatusRsp>
{

	public string GetMethod() { return "power.SubscribeVirtualTelCallStatus"; }

	public string GetUrl() { return "/power/SubscribeVirtualTelCallStatus"; }

	[JsonPropertyName("virtual_main_tel")]
	[Description("虚拟号主号")]
	[NotNull]
	public string VirtualMainTel { get; set; }

	[JsonPropertyName("virtual_sub_tel")]
	[Description("虚拟号分机号")]
	[NotNull]
	public string VirtualSubTel { get; set; }

	[JsonPropertyName("order_id")]
	[Description("父订单号")]
	[NotNull]
	public string OrderId { get; set; }
}

[Description("isv获取虚拟号通话状态申请")]
public class PowerSubscribeVirtualTelCallStatusRsp
{
	[JsonPropertyName("success")]
	[Description("订阅成功")]
	public bool Success { get; set; }
}
