namespace ecommerce.sdk.douyin;

[Description("直接操作门店解绑电子围栏")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:2","请检查参数")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:9999","请稍后重试")]
public class WarehouseUnbindFencesByStoreReq : IDouyinReq<WarehouseUnbindFencesByStoreRsp>
{

	public string GetMethod() { return "warehouse.unbindFencesByStore"; }

	public string GetUrl() { return "/warehouse/unbindFencesByStore"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("remove_out_fence_ids")]
	[Description("外部围栏id")]
	[NotNull]
	public List<string> RemoveOutFenceIds { get; set; }
}

[Description("直接操作门店解绑电子围栏")]
public class WarehouseUnbindFencesByStoreRsp
{
}
