namespace ecommerce.sdk.douyin;

[Description("批量创建区域仓")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","仓库编码Z0010160524ZE02重复","isv.business-failed:2","请检查仓库信息")]
[DouyinRetCode(50002,"业务处理失败","单次请求过于频繁，请稍后重试","isv.business-failed:1005","请稍后重试")]
public class WarehouseCreateBatchReq : IDouyinReq<WarehouseCreateBatchRsp>
{

	public string GetMethod() { return "warehouse.createBatch"; }

	public string GetUrl() { return "/warehouse/createBatch"; }

	[JsonPropertyName("out_warehouse_list")]
	[Description("外部仓信息列表")]
	[NotNull]
	public List<OutWarehouseListItem> OutWarehouseList { get; set; }

	public class OutWarehouseListItem
	{
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

		[JsonPropertyName("address_detail")]
		[Description("仓地址详细地址，苹果门店店铺、超市小时达店铺建仓必传")]
		public string AddressDetail { get; set; }

		[JsonPropertyName("warehouse_location")]
		[Description("仓地址编码  苹果门店店铺、超市小时达店铺建仓必传")]
		public WarehouseLocationItem WarehouseLocation { get; set; }

		public class WarehouseLocationItem
		{
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
		}
	}
}

[Description("批量创建区域仓")]
public class WarehouseCreateBatchRsp
{
	[JsonPropertyName("data")]
	[Description("key是outWarehouseId,value代表成功/失败")]
	public Dictionary<string,bool> Data { get; set; }
}
