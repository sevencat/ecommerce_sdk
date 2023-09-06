namespace ecommerce.sdk.douyin;

[Description("门店绑定运费模版，运费模版必须属于门店关联的抖店，且门店与运费模版是一对一关系")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数异常","isv.parameter-invalid:1","检查下参数")]
public class ShopBindStoreFreightReq : IDouyinReq<ShopBindStoreFreightRsp>
{

	public string GetMethod() { return "shop.bindStoreFreight"; }

	public string GetUrl() { return "/shop/bindStoreFreight"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("freight_id")]
	[Description("运费模版ID")]
	[NotNull]
	public long? FreightId { get; set; }
}

[Description("门店绑定运费模版，运费模版必须属于门店关联的抖店，且门店与运费模版是一对一关系")]
public class ShopBindStoreFreightRsp
{
}
