namespace ecommerce.sdk.douyin;

[Description("编辑区域仓")]
public class WarehouseEditReq : IDouyinReq<WarehouseEditRsp>
{

	public string GetMethod() { return "warehouse.edit"; }

	public string GetUrl() { return "/warehouse/edit"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓库id")]
	[NotNull]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("name")]
	[Description("仓库名称")]
	public string Name { get; set; }

	[JsonPropertyName("intro")]
	[Description("仓库介绍")]
	public string Intro { get; set; }

	[JsonPropertyName("address_id1")]
	[Description("省地址编码")]
	public long? AddressId1 { get; set; }

	[JsonPropertyName("address_id2")]
	[Description("市地址编码")]
	public long? AddressId2 { get; set; }

	[JsonPropertyName("address_id3")]
	[Description("区地址编码")]
	public long? AddressId3 { get; set; }

	[JsonPropertyName("address_id4")]
	[Description("街道地址编码")]
	public long? AddressId4 { get; set; }

	[JsonPropertyName("address_detail")]
	[Description("详细地址")]
	public string AddressDetail { get; set; }
}

[Description("编辑区域仓")]
public class WarehouseEditRsp
{
	[JsonPropertyName("data")]
	[Description("修改结果")]
	public bool Data { get; set; }
}
