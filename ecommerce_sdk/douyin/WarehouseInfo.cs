namespace ecommerce.sdk.douyin;

[Description("查询区域仓")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","仓库不存在","isv.business-failed:20002","仓库不存在,请检查信息")]
public class WarehouseInfoReq : IDouyinReq<WarehouseInfoRsp>
{

	public string GetMethod() { return "warehouse.info"; }

	public string GetUrl() { return "/warehouse/info"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("仓库编码")]
	[NotNull]
	public string OutWarehouseId { get; set; }
}

[Description("查询区域仓")]
public class WarehouseInfoRsp
{
	[JsonPropertyName("data")]
	[Description("仓库信息")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("warehouse_id")]
		[Description("仓库id")]
		public long WarehouseId { get; set; }

		[JsonPropertyName("out_warehouse_id")]
		[Description("仓库外部id")]
		public string OutWarehouseId { get; set; }

		[JsonPropertyName("name")]
		[Description("仓库名称")]
		public string Name { get; set; }

		[JsonPropertyName("intro")]
		[Description("仓库介绍")]
		public string Intro { get; set; }

		[JsonPropertyName("addr")]
		[Description("覆盖区域列表")]
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
			[Description("地址更新时间")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("create_time")]
			[Description("地址创建时间")]
			public long CreateTime { get; set; }
		}

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public long UpdateTime { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺id")]
		public long ShopId { get; set; }

		[JsonPropertyName("warehouse_location")]
		[Description("仓库地址")]
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

			[JsonPropertyName("address_name1")]
			[Description("省地址中文")]
			public string AddressName1 { get; set; }

			[JsonPropertyName("address_name2")]
			[Description("市地址中文")]
			public string AddressName2 { get; set; }

			[JsonPropertyName("address_name3")]
			[Description("街道地址中文")]
			public string AddressName3 { get; set; }

			[JsonPropertyName("address_name4")]
			[Description("街道地址中文")]
			public string AddressName4 { get; set; }
		}

		[JsonPropertyName("address_detail")]
		[Description("详细地址")]
		public string AddressDetail { get; set; }

		[JsonPropertyName("out_fence_ids")]
		[Description("外部围栏ID列表")]
		public List<string> OutFenceIds { get; set; }
	}
}
