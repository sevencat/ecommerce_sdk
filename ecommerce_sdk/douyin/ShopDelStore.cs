namespace ecommerce.sdk.douyin;

[Description("删除门店")]
[DouyinRetCode(10000,"success","","","")]
public class ShopDelStoreReq : IDouyinReq<ShopDelStoreRsp>
{

	public string GetMethod() { return "shop.delStore"; }

	public string GetUrl() { return "/shop/delStore"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }
}

[Description("删除门店")]
public class ShopDelStoreRsp
{
}
