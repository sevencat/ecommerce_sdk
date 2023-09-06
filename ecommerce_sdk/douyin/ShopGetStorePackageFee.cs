namespace ecommerce.sdk.douyin;

[Description("在设置到门店的打包费的前提下，可以调用这个接口设置打包费。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:1","参考文档，重新配置")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:100","可重试，若仍然失败可oncall反馈")]
[DouyinRetCode(50002,"业务处理失败","操作数据库失败","isv.business-failed:3","可重试，若仍然失败可oncall反馈")]
[DouyinRetCode(50002,"业务处理失败","门店不存在","isv.business-failed:8","查看storeId是否正确")]
public class ShopGetStorePackageFeeReq : IDouyinReq<ShopGetStorePackageFeeRsp>
{

	public string GetMethod() { return "shop.getStorePackageFee"; }

	public string GetUrl() { return "/shop/getStorePackageFee"; }

	[JsonPropertyName("store_id")]
	[Description("门店id")]
	[NotNull]
	public long? StoreId { get; set; }
}

[Description("在设置到门店的打包费的前提下，可以调用这个接口设置打包费。")]
public class ShopGetStorePackageFeeRsp
{
	[JsonPropertyName("package_fee")]
	[Description("打包费")]
	public PackageFeeItem PackageFee { get; set; }

	public class PackageFeeItem
	{
		[JsonPropertyName("amount")]
		[Description("打包费，单位分 0~200")]
		public long Amount { get; set; }
	}
}
