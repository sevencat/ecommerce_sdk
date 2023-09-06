namespace ecommerce.sdk.douyin;

[Description("退货场景下，根据商家的自提码查询订单列表")]
public class BtasScListOrderCodeByPickupCodeReq : IDouyinReq<BtasScListOrderCodeByPickupCodeRsp>
{

	public string GetMethod() { return "btas.sc.listOrderCodeByPickupCode"; }

	public string GetUrl() { return "/btas/sc/listOrderCodeByPickupCode"; }

	[JsonPropertyName("pickup_code")]
	[Description("商家自提码，由商家在抖店后台自行取的")]
	[NotNull]
	public string PickupCode { get; set; }

	[JsonPropertyName("sc_id")]
	[Description("质检机构ID")]
	[NotNull]
	public long? ScId { get; set; }
}

[Description("退货场景下，根据商家的自提码查询订单列表")]
public class BtasScListOrderCodeByPickupCodeRsp
{
	[JsonPropertyName("pickup_code")]
	[Description("自提码")]
	public string PickupCode { get; set; }

	[JsonPropertyName("order_list")]
	[Description("订单列表")]
	public List<OrderListItem> OrderList { get; set; }

	public class OrderListItem
	{
		[JsonPropertyName("order_code")]
		[Description("订单码")]
		public string OrderCode { get; set; }

		[JsonPropertyName("inspection_type")]
		[Description("质检类型")]
		public int InspectionType { get; set; }

		[JsonPropertyName("product_name")]
		[Description("商品名称")]
		public string ProductName { get; set; }

		[JsonPropertyName("product_img")]
		[Description("商品图片")]
		public string ProductImg { get; set; }

		[JsonPropertyName("product_price")]
		[Description("商品价格（分）")]
		public long ProductPrice { get; set; }

		[JsonPropertyName("extra_properties")]
		[Description("商品附加属性")]
		public string ExtraProperties { get; set; }
	}
}
