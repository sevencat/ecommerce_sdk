namespace ecommerce.sdk.douyin;

[Description("获取App对于商家订单修改地址的审核权限,获取App对于商家订单修改地址的审核权限")]
public class OrderAddresSwitchConfigReq : IDouyinReq<OrderAddresSwitchConfigRsp>
{

	public string GetMethod() { return "order.addresSwitchConfig"; }

	public string GetUrl() { return "/order/addresSwitchConfig"; }

}

[Description("获取App对于商家订单修改地址的审核权限,获取App对于商家订单修改地址的审核权限")]
public class OrderAddresSwitchConfigRsp
{
	[JsonPropertyName("authorized_status")]
	[Description("0: 商家当前未开启审核 1:商家当前已开启审核，但本应用不可进行审核 2:商家当前已开启审核，且本应用可审核")]
	public long AuthorizedStatus { get; set; }
}
