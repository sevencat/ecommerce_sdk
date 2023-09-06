namespace ecommerce.sdk.douyin;

[Description("获取商家发货时效推荐列表")]
public class PromiseDeliveryListReq : IDouyinReq<PromiseDeliveryListRsp>
{

	public string GetMethod() { return "promise.deliveryList"; }

	public string GetUrl() { return "/promise/deliveryList"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，从1开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页数量")]
	[NotNull]
	public long? Size { get; set; }
}

[Description("获取商家发货时效推荐列表")]
public class PromiseDeliveryListRsp
{
	[JsonPropertyName("products")]
	[Description("商品返回结构")]
	public List<ProductsItem> Products { get; set; }

	public class ProductsItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("ship_mode")]
		[Description("1：当日发；2：次日发")]
		public int ShipMode { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
