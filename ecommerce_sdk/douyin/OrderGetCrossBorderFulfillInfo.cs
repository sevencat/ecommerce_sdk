namespace ecommerce.sdk.douyin;

[Description("获取跨境承运单信息")]
public class OrderGetCrossBorderFulfillInfoReq : IDouyinReq<OrderGetCrossBorderFulfillInfoRsp>
{

	public string GetMethod() { return "order.getCrossBorderFulfillInfo"; }

	public string GetUrl() { return "/order/getCrossBorderFulfillInfo"; }

	[JsonPropertyName("shop_order_id")]
	[Description("主订单号(不带A)")]
	[NotNull]
	public string ShopOrderId { get; set; }
}

[Description("获取跨境承运单信息")]
public class OrderGetCrossBorderFulfillInfoRsp
{
	[JsonPropertyName("shop_order_id")]
	[Description("主订单号")]
	public string ShopOrderId { get; set; }

	[JsonPropertyName("company")]
	[Description("物流公司名称")]
	public string Company { get; set; }

	[JsonPropertyName("company_code")]
	[Description("物流公司Code")]
	public string CompanyCode { get; set; }

	[JsonPropertyName("sku_order_ids")]
	[Description("商品单id列表")]
	public List<string> SkuOrderIds { get; set; }

	[JsonPropertyName("logistics_code")]
	[Description("物流单号")]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("way_bill_url")]
	[Description("电子面单链接")]
	public string WayBillUrl { get; set; }

	[JsonPropertyName("mark")]
	[Description("大头笔")]
	public string Mark { get; set; }

	[JsonPropertyName("product_num")]
	[Description("商品件数")]
	public long ProductNum { get; set; }
}
