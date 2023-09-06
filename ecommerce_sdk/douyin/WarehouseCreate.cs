namespace ecommerce.sdk.douyin;

[Description("创建单个区域仓")]
public class WarehouseCreateReq : IDouyinReq<WarehouseCreateRsp>
{

	public string GetMethod() { return "warehouse.create"; }

	public string GetUrl() { return "/warehouse/create"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓库ID，一个店铺下，同一个外部ID只能创建一个仓库")]
	[NotNull]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("name")]
	[Description("仓库名称")]
	[NotNull]
	public string Name { get; set; }

	[JsonPropertyName("intro")]
	[Description("仓库介绍")]
	[NotNull]
	public string Intro { get; set; }
}

[Description("创建单个区域仓")]
public class WarehouseCreateRsp
{
	[JsonPropertyName("data")]
	[Description("仓库id")]
	public long Data { get; set; }
}
