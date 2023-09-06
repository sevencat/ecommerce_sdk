namespace ecommerce.sdk.douyin;

[Description("在设置到门店的运费模板的前提下，可以调用这个接口设置打包费。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:1","参考文档，重新配置")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:100","可重试，若仍然失败可oncall反馈")]
[DouyinRetCode(50002,"业务处理失败","操作数据库失败","isv.business-failed:3","可重试，若仍然失败可oncall反馈")]
[DouyinRetCode(50002,"业务处理失败","门店不存在","isv.business-failed:8","查看storeId是否正确")]
[DouyinRetCode(50002,"业务处理失败","门店当前状态不可设置打包费","isv.business-failed:8005","门店必须正常营业了才可以设置，即state=5或6")]
[DouyinRetCode(50002,"业务处理失败","需要先绑定运费模板才可设置打包费","isv.business-failed:8006","先去设置门店的运费模板")]
public class ShopSetStorePackageFeeReq : IDouyinReq<ShopSetStorePackageFeeRsp>
{

	public string GetMethod() { return "shop.setStorePackageFee"; }

	public string GetUrl() { return "/shop/setStorePackageFee"; }

	[JsonPropertyName("store_id")]
	[Description("门店id")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("package_fee")]
	[Description("打包费，单位分 0~200")]
	[NotNull]
	public long? PackageFee { get; set; }
}

[Description("在设置到门店的运费模板的前提下，可以调用这个接口设置打包费。")]
public class ShopSetStorePackageFeeRsp
{
}
