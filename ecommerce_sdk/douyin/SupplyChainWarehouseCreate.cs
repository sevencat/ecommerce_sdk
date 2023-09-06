namespace ecommerce.sdk.douyin;

[Description("创建区域仓")]
public class SupplyChainWarehouseCreateReq : IDouyinReq<SupplyChainWarehouseCreateRsp>
{

	public string GetMethod() { return "supplyChain.warehouse.create"; }

	public string GetUrl() { return "/supplyChain/warehouse/create"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓id")]
	[NotNull]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("name")]
	[Description("区域仓名称")]
	[NotNull]
	public string Name { get; set; }

	[JsonPropertyName("intro")]
	[Description("区域仓信息描述")]
	[NotNull]
	public string Intro { get; set; }
}

[Description("创建区域仓")]
public class SupplyChainWarehouseCreateRsp
{
	[JsonPropertyName("warehouse_id")]
	[Description("平台侧返回的仓编码与out_warehouse_id一一对应")]
	public string WarehouseId { get; set; }
}
