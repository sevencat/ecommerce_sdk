namespace ecommerce.sdk.douyin;

[Description("仓库绑定门店接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:2","修改后重试")]
[DouyinRetCode(20000,"系统错误","系统内部错误","isp.service-error:9999","重试或反馈问题")]
[DouyinRetCode(50002,"业务处理失败","该门店已经绑定了其他仓库","isv.business-failed:500","重试或反馈问题")]
public class WarehouseBindStoreReq : IDouyinReq<WarehouseBindStoreRsp>
{

	public string GetMethod() { return "warehouse.bindStore"; }

	public string GetUrl() { return "/warehouse/bindStore"; }

	[JsonPropertyName("store_ids")]
	[Description("要添加的门店id列表")]
	[NotNull]
	public List<long> StoreIds { get; set; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓id列表")]
	[NotNull]
	public string OutWarehouseId { get; set; }
}

[Description("仓库绑定门店接口")]
public class WarehouseBindStoreRsp
{
}
