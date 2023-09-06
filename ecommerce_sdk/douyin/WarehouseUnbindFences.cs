namespace ecommerce.sdk.douyin;

[Description("用于外部仓和电子围栏解绑")]
public class WarehouseUnbindFencesReq : IDouyinReq<WarehouseUnbindFencesRsp>
{

	public string GetMethod() { return "warehouse.unbindFences"; }

	public string GetUrl() { return "/warehouse/unbindFences"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓id")]
	[NotNull]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("out_fence_ids")]
	[Description("外部围栏id列表")]
	[NotNull]
	public List<string> OutFenceIds { get; set; }
}

[Description("用于外部仓和电子围栏解绑")]
public class WarehouseUnbindFencesRsp
{
}
