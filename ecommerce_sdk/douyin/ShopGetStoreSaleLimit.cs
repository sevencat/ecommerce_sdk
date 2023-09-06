namespace ecommerce.sdk.douyin;

[Description("获取门店绑定的限售模版")]
[DouyinRetCode(10000,"success","","","")]
public class ShopGetStoreSaleLimitReq : IDouyinReq<ShopGetStoreSaleLimitRsp>
{

	public string GetMethod() { return "shop.getStoreSaleLimit"; }

	public string GetUrl() { return "/shop/getStoreSaleLimit"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }
}

[Description("获取门店绑定的限售模版")]
public class ShopGetStoreSaleLimitRsp
{
	[JsonPropertyName("store_sale_limits")]
	[Description("门店关联的限售模版")]
	public List<StoreSaleLimitsItem> StoreSaleLimits { get; set; }

	public class StoreSaleLimitsItem
	{
		[JsonPropertyName("store_id")]
		[Description("门店id")]
		public long StoreId { get; set; }

		[JsonPropertyName("sale_limit_id")]
		[Description("模版id")]
		public long SaleLimitId { get; set; }
	}
}
