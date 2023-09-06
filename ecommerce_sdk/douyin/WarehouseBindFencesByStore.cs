namespace ecommerce.sdk.douyin;

[Description("可以直接通过门店绑定电子围栏，不需要先绑定门店和仓，再绑定仓和电子围栏")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:2","检查参数")]
[DouyinRetCode(20000,"系统错误","系统错误，请重试","isp.service-error:9999","重试")]
public class WarehouseBindFencesByStoreReq : IDouyinReq<WarehouseBindFencesByStoreRsp>
{

	public string GetMethod() { return "warehouse.bindFencesByStore"; }

	public string GetUrl() { return "/warehouse/bindFencesByStore"; }

	[JsonPropertyName("store_id")]
	[Description("门店id")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("add_out_fence_ids")]
	[Description("要添加的外部围栏id列表")]
	[NotNull]
	public List<string> AddOutFenceIds { get; set; }
}

[Description("可以直接通过门店绑定电子围栏，不需要先绑定门店和仓，再绑定仓和电子围栏")]
public class WarehouseBindFencesByStoreRsp
{
}
