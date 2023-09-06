namespace ecommerce.sdk.douyin;

[Description("仓绑定电子围栏")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:2","修改后重试")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:9999","重试")]
public class WarehouseBindFencesReq : IDouyinReq<WarehouseBindFencesRsp>
{

	public string GetMethod() { return "warehouse.bindFences"; }

	public string GetUrl() { return "/warehouse/bindFences"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓id")]
	[NotNull]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("out_fence_ids")]
	[Description("外部电子围栏id列表")]
	[NotNull]
	public List<string> OutFenceIds { get; set; }
}

[Description("仓绑定电子围栏")]
public class WarehouseBindFencesRsp
{
}
