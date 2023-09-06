namespace ecommerce.sdk.douyin;

[Description("外部仓列表")]
[DouyinRetCode(10000,"success","","","")]
public class SupplyChainWarehouseListReq : IDouyinReq<SupplyChainWarehouseListRsp>
{

	public string GetMethod() { return "supplyChain.warehouse.list"; }

	public string GetUrl() { return "/supplyChain/warehouse/list"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓id")]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("warehouse_name")]
	[Description("仓名称")]
	public string WarehouseName { get; set; }

	[JsonPropertyName("out_warehouse_ids")]
	[Description("外部仓列表")]
	public List<string> OutWarehouseIds { get; set; }

	[JsonPropertyName("page")]
	[Description("1")]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("50")]
	public long? Size { get; set; }
}

[Description("外部仓列表")]
public class SupplyChainWarehouseListRsp
{
	[JsonPropertyName("warehouse_list")]
	[Description("外部仓列表")]
	public List<WarehouseListItem> WarehouseList { get; set; }

	public class WarehouseListItem
	{
		[JsonPropertyName("warehouse_id")]
		[Description("仓id")]
		public string WarehouseId { get; set; }

		[JsonPropertyName("name")]
		[Description("仓名称")]
		public string Name { get; set; }

		[JsonPropertyName("intro")]
		[Description("介绍")]
		public string Intro { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public long UpdateTime { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("out_warehouse_id")]
		[Description("外部仓id")]
		public string OutWarehouseId { get; set; }

		[JsonPropertyName("addr")]
		[Description("地址")]
		public List<AddrItem> Addr { get; set; }

		public class AddrItem
		{
			[JsonPropertyName("addr_id1")]
			[Description("一级地址")]
			public long AddrId1 { get; set; }

			[JsonPropertyName("addr_id2")]
			[Description("二级地址")]
			public long AddrId2 { get; set; }

			[JsonPropertyName("addr_id3")]
			[Description("三级地址")]
			public long AddrId3 { get; set; }

			[JsonPropertyName("addr_id4")]
			[Description("四级地址")]
			public long AddrId4 { get; set; }

			[JsonPropertyName("update_time")]
			[Description("更新时间")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("create_time")]
			[Description("创建时间")]
			public long CreateTime { get; set; }
		}
	}

	[JsonPropertyName("total")]
	[Description("总页数")]
	public long Total { get; set; }
}
