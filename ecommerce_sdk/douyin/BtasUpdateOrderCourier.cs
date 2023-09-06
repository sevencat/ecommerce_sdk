namespace ecommerce.sdk.douyin;

[Description("更新订单的物流信息，需要单独配置权限。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","-1:当前账号不能访问该接口，请联系开发人员配置","isv.business-failed:-1","联系开发者")]
public class BtasUpdateOrderCourierReq : IDouyinReq<BtasUpdateOrderCourierRsp>
{

	public string GetMethod() { return "btas.updateOrderCourier"; }

	public string GetUrl() { return "/btas/updateOrderCourier"; }

	[JsonPropertyName("order_code")]
	[Description("订单码")]
	[NotNull]
	public string OrderCode { get; set; }

	[JsonPropertyName("courier_code")]
	[Description("快递单号(可以通过电子面单获取）")]
	[NotNull]
	public string CourierCode { get; set; }

	[JsonPropertyName("logistics_name_en")]
	[Description("快递公司名称")]
	[NotNull]
	public string LogisticsNameEn { get; set; }
}

[Description("更新订单的物流信息，需要单独配置权限。")]
public class BtasUpdateOrderCourierRsp
{
}
