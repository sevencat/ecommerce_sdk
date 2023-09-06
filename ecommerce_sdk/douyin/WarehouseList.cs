namespace ecommerce.sdk.douyin;

[Description("批量查询区域仓")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","2:参数错误,OrderBy格式不正确","isv.business-failed:2","调整请求")]
public class WarehouseListReq : IDouyinReq<WarehouseListRsp>
{

	public string GetMethod() { return "warehouse.list"; }

	public string GetUrl() { return "/warehouse/list"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓库ID")]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("warehouse_name")]
	[Description("仓库名称")]
	public string WarehouseName { get; set; }

	[JsonPropertyName("addr")]
	[Description("仓库覆盖地址")]
	public AddrItem Addr { get; set; }

	public class AddrItem
	{
		[JsonPropertyName("addr_id1")]
		[Description("一级地址")]
		[NotNull]
		public long? AddrId1 { get; set; }

		[JsonPropertyName("addr_id2")]
		[Description("二级地址")]
		public long? AddrId2 { get; set; }

		[JsonPropertyName("addr_id3")]
		[Description("三级地址")]
		public long? AddrId3 { get; set; }

		[JsonPropertyName("addr_id4")]
		[Description("四级地址")]
		public long? AddrId4 { get; set; }
	}

	[JsonPropertyName("out_warehouse_ids")]
	[Description("外部仓库ID列表")]
	public List<string> OutWarehouseIds { get; set; }

	[JsonPropertyName("order_by")]
	[Description("排序方式，可选create_time、update_time")]
	public string OrderBy { get; set; }

	[JsonPropertyName("rank")]
	[Description("顺序，可选desc、asc，与order_by同时生效")]
	public string Rank { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，从0开始，最大到100")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页数量，最大100，超过100会限制到100")]
	[NotNull]
	public long? Size { get; set; }
}

[Description("批量查询区域仓")]
public class WarehouseListRsp
{
	[JsonPropertyName("warehouses")]
	[Description("仓库信息")]
	public List<WarehousesItem> Warehouses { get; set; }

	public class WarehousesItem
	{
		[JsonPropertyName("warehouse_id")]
		[Description("仓库id")]
		public long WarehouseId { get; set; }

		[JsonPropertyName("name")]
		[Description("仓库名字")]
		public string Name { get; set; }

		[JsonPropertyName("intro")]
		[Description("仓库介绍")]
		public string Intro { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public long UpdateTime { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("out_warehouse_id")]
		[Description("仓库外部id")]
		public string OutWarehouseId { get; set; }

		[JsonPropertyName("addr")]
		[Description("仓库覆盖范围列表")]
		public List<AddrItem> Addr { get; set; }

		public class AddrItem
		{
			[JsonPropertyName("addr_id1")]
			[Description("一级地址id")]
			public long AddrId1 { get; set; }

			[JsonPropertyName("addr_id2")]
			[Description("二级地址id")]
			public long AddrId2 { get; set; }

			[JsonPropertyName("addr_id3")]
			[Description("三级地址id")]
			public long AddrId3 { get; set; }

			[JsonPropertyName("addr_id4")]
			[Description("四级地址id")]
			public long AddrId4 { get; set; }

			[JsonPropertyName("update_time")]
			[Description("更新时间")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("create_time")]
			[Description("创建时间")]
			public long CreateTime { get; set; }
		}

		[JsonPropertyName("shop_id")]
		[Description("店铺id")]
		public long ShopId { get; set; }

		[JsonPropertyName("out_fence_ids")]
		[Description("外部电子围栏id列表")]
		public List<string> OutFenceIds { get; set; }

		[JsonPropertyName("address_detail")]
		[Description("仓的详细地址")]
		public string AddressDetail { get; set; }

		[JsonPropertyName("warehouse_location")]
		[Description("仓的地址编码")]
		public WarehouseLocationItem WarehouseLocation { get; set; }

		public class WarehouseLocationItem
		{
			[JsonPropertyName("address_id1")]
			[Description("省地址编码")]
			public long AddressId1 { get; set; }

			[JsonPropertyName("address_id2")]
			[Description("市地址编码")]
			public long AddressId2 { get; set; }

			[JsonPropertyName("address_id3")]
			[Description("区地址编码")]
			public long AddressId3 { get; set; }

			[JsonPropertyName("address_id4")]
			[Description("街道地址编码")]
			public long AddressId4 { get; set; }
		}
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
