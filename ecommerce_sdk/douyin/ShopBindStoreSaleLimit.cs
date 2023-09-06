namespace ecommerce.sdk.douyin;

[Description("门店绑定限售模版")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","参数异常","isv.business-failed:1","检查参数是否正确")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:100","重试即可")]
public class ShopBindStoreSaleLimitReq : IDouyinReq<ShopBindStoreSaleLimitRsp>
{

	public string GetMethod() { return "shop.bindStoreSaleLimit"; }

	public string GetUrl() { return "/shop/bindStoreSaleLimit"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("sale_limit_id")]
	[Description("限售模版ID")]
	[NotNull]
	public long? SaleLimitId { get; set; }
}

[Description("门店绑定限售模版")]
public class ShopBindStoreSaleLimitRsp
{
}
