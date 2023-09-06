namespace ecommerce.sdk.douyin;

[Description("质检机构更新订单的物流信息，注意需要单独配置权限")]
public class BtasScUpdateOrderCourierReq : IDouyinReq<BtasScUpdateOrderCourierRsp>
{

	public string GetMethod() { return "btas.sc.updateOrderCourier"; }

	public string GetUrl() { return "/btas/sc/updateOrderCourier"; }

	[JsonPropertyName("order_code")]
	[Description("订单码")]
	[NotNull]
	public string OrderCode { get; set; }

	[JsonPropertyName("courier_code")]
	[Description("物流单号")]
	[NotNull]
	public string CourierCode { get; set; }

	[JsonPropertyName("logistics_name_en")]
	[Description("快递公司名称")]
	[NotNull]
	public string LogisticsNameEn { get; set; }

	[JsonPropertyName("sc_id")]
	[Description("质检机构ID")]
	[NotNull]
	public long? ScId { get; set; }
}

[Description("质检机构更新订单的物流信息，注意需要单独配置权限")]
public class BtasScUpdateOrderCourierRsp
{
}
