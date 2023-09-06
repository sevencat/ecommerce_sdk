namespace ecommerce.sdk.douyin;

[Description("暂停营业")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","8:门店不存在","isv.business-failed:8","检查id")]
[DouyinRetCode(50002,"业务处理失败","13:非正常营业或停业的门店不可暂停营业","isv.business-failed:13","非正常营业或停业的门店不可暂停营业")]
public class ShopStoreSuspendReq : IDouyinReq<ShopStoreSuspendRsp>
{

	public string GetMethod() { return "shop.storeSuspend"; }

	public string GetUrl() { return "/shop/storeSuspend"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("reason")]
	[Description("停业原因")]
	public string Reason { get; set; }
}

[Description("暂停营业")]
public class ShopStoreSuspendRsp
{
	[JsonPropertyName("ret_code")]
	[Description("返回错误码")]
	public long RetCode { get; set; }

	[JsonPropertyName("ret_msg")]
	[Description("-")]
	public string RetMsg { get; set; }
}
