namespace ecommerce.sdk.douyin;

[Description("获取门店绑定的运费模版")]
[DouyinRetCode(10000,"success","","","")]
public class ShopGetStoreFreightReq : IDouyinReq<ShopGetStoreFreightRsp>
{

	public string GetMethod() { return "shop.getStoreFreight"; }

	public string GetUrl() { return "/shop/getStoreFreight"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }
}

[Description("获取门店绑定的运费模版")]
public class ShopGetStoreFreightRsp
{
	[JsonPropertyName("store_freights")]
	[Description("运费模版关联关系")]
	public List<StoreFreightsItem> StoreFreights { get; set; }

	public class StoreFreightsItem
	{
		[JsonPropertyName("store_id")]
		[Description("门店id")]
		public long StoreId { get; set; }

		[JsonPropertyName("freight_id")]
		[Description("运费模版id")]
		public long FreightId { get; set; }
	}
}
