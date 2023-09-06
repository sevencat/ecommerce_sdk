namespace ecommerce.sdk.douyin;

[Description("下载qic订单码,下载qic订单码，下载后订单进入预绑码状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","订单处理中","isv.business-failed:1001","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","存在未维护sku的订单","isv.business-failed:-1","需要维护sku")]
public class OrderCodeDownloadOrderCodeByShopReq : IDouyinReq<OrderCodeDownloadOrderCodeByShopRsp>
{

	public string GetMethod() { return "orderCode.downloadOrderCodeByShop"; }

	public string GetUrl() { return "/orderCode/downloadOrderCodeByShop"; }

	[JsonPropertyName("order_id")]
	[Description("订单id")]
	[NotNull]
	public long? OrderId { get; set; }
}

[Description("下载qic订单码,下载qic订单码，下载后订单进入预绑码状态")]
public class OrderCodeDownloadOrderCodeByShopRsp
{
	[JsonPropertyName("is_success")]
	[Description("是否成功")]
	public string IsSuccess { get; set; }

	[JsonPropertyName("error_desc")]
	[Description("错误信息")]
	public string ErrorDesc { get; set; }

	[JsonPropertyName("delivery_type")]
	[Description("送检方式")]
	public long DeliveryType { get; set; }

	[JsonPropertyName("ship_type")]
	[Description("出仓方式")]
	public long ShipType { get; set; }

	[JsonPropertyName("order_code")]
	[Description("订单码")]
	public string OrderCode { get; set; }
}
