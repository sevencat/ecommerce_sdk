namespace ecommerce.sdk.douyin;

[Description("用于商家主动恢复门店营业，仅当门店被商家主动暂停营业后，可以主动恢复。如果门店因为平台处罚被暂停营业，则不能通过此接口恢复营业")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","8:门店不存在","isv.business-failed:8","门店不存在")]
[DouyinRetCode(50002,"业务处理失败","14:非正常营业或停业的门店不可恢复营业","isv.business-failed:14","非正常营业或停业的门店不可恢复营业")]
public class ShopUnsuspendStoreReq : IDouyinReq<ShopUnsuspendStoreRsp>
{

	public string GetMethod() { return "shop.unsuspendStore"; }

	public string GetUrl() { return "/shop/unsuspendStore"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("reason")]
	[Description("恢复营业原因")]
	public string Reason { get; set; }
}

[Description("用于商家主动恢复门店营业，仅当门店被商家主动暂停营业后，可以主动恢复。如果门店因为平台处罚被暂停营业，则不能通过此接口恢复营业")]
public class ShopUnsuspendStoreRsp
{
	[JsonPropertyName("ret_code")]
	[Description("返回错误码")]
	public long RetCode { get; set; }

	[JsonPropertyName("ret_msg")]
	[Description("-")]
	public string RetMsg { get; set; }
}
