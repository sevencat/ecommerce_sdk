namespace ecommerce.sdk.douyin;

[Description("单个仓创建v2版本")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:2","修改后重试")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:9999","重试")]
public class WarehouseCreateV2Req : IDouyinReq<WarehouseCreateV2Rsp>
{

	public string GetMethod() { return "warehouse.createV2"; }

	public string GetUrl() { return "/warehouse/createV2"; }

	[JsonPropertyName("warehouse")]
	[Description("仓相关信息")]
	[NotNull]
	public WarehouseItem Warehouse { get; set; }

	public class WarehouseItem
	{
		[JsonPropertyName("warehouse_location")]
		[Description("仓的地址编码")]
		[NotNull]
		public WarehouseLocationItem WarehouseLocation { get; set; }

		public class WarehouseLocationItem
		{
			[JsonPropertyName("address_id1")]
			[Description("地址1级编码")]
			[NotNull]
			public long? AddressId1 { get; set; }

			[JsonPropertyName("address_id2")]
			[Description("地址2级编码")]
			[NotNull]
			public long? AddressId2 { get; set; }

			[JsonPropertyName("address_id3")]
			[Description("地址3级编码")]
			[NotNull]
			public long? AddressId3 { get; set; }

			[JsonPropertyName("address_id4")]
			[Description("地址4级编码")]
			public long? AddressId4 { get; set; }
		}

		[JsonPropertyName("address_detail")]
		[Description("仓的地址详情")]
		[NotNull]
		public string AddressDetail { get; set; }
	}

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓ID")]
	[NotNull]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("name")]
	[Description("仓名称")]
	[NotNull]
	public string Name { get; set; }

	[JsonPropertyName("intro")]
	[Description("仓介绍")]
	[NotNull]
	public string Intro { get; set; }
}

[Description("单个仓创建v2版本")]
public class WarehouseCreateV2Rsp
{
	[JsonPropertyName("warehouse_id")]
	[Description("内部仓id")]
	public string WarehouseId { get; set; }
}
