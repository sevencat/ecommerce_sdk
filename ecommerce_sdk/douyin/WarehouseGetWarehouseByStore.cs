namespace ecommerce.sdk.douyin;

[Description("可以查询仓信息，以及仓绑定的外部围栏id")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","2:参数错误,门店ID个数不得超过200","isv.business-failed:2","无")]
public class WarehouseGetWarehouseByStoreReq : IDouyinReq<WarehouseGetWarehouseByStoreRsp>
{

	public string GetMethod() { return "warehouse.getWarehouseByStore"; }

	public string GetUrl() { return "/warehouse/getWarehouseByStore"; }

	[JsonPropertyName("store_ids")]
	[Description("门店id列表")]
	[NotNull]
	public List<long> StoreIds { get; set; }
}

[Description("可以查询仓信息，以及仓绑定的外部围栏id")]
public class WarehouseGetWarehouseByStoreRsp
{
	[JsonPropertyName("warehouse_info_map")]
	[Description("仓信息map")]
	public Dictionary<long,WarehouseInfoMapItem> WarehouseInfoMap { get; set; }

	public class WarehouseInfoMapItem
	{
		[JsonPropertyName("warehouseId")]
		[Description("仓id")]
		public long WarehouseId { get; set; }

		[JsonPropertyName("outWarehouseId")]
		[Description("外部仓id")]
		public string OutWarehouseId { get; set; }

		[JsonPropertyName("name")]
		[Description("仓名称")]
		public string Name { get; set; }

		[JsonPropertyName("introduction")]
		[Description("仓介绍")]
		public string Introduction { get; set; }

		[JsonPropertyName("warehouseLocation")]
		[Description("仓地址信息")]
		public WarehouseLocationItem WarehouseLocation { get; set; }

		public class WarehouseLocationItem
		{
			[JsonPropertyName("addressId1")]
			[Description("一级地址ID")]
			public long AddressId1 { get; set; }

			[JsonPropertyName("addressId2")]
			[Description("二级地址ID")]
			public long AddressId2 { get; set; }

			[JsonPropertyName("addressId3")]
			[Description("三级地址ID")]
			public long AddressId3 { get; set; }

			[JsonPropertyName("addressId4")]
			[Description("四级地址ID")]
			public long AddressId4 { get; set; }

			[JsonPropertyName("addressName1")]
			[Description("一级地址名称")]
			public string AddressName1 { get; set; }

			[JsonPropertyName("addressName2")]
			[Description("二级地址名称")]
			public string AddressName2 { get; set; }

			[JsonPropertyName("addressName3")]
			[Description("三级地址名称")]
			public string AddressName3 { get; set; }

			[JsonPropertyName("addressName4")]
			[Description("四级地址名称")]
			public string AddressName4 { get; set; }
		}

		[JsonPropertyName("addressDetail")]
		[Description("详细地址")]
		public string AddressDetail { get; set; }

		[JsonPropertyName("updateTime")]
		[Description("更新时间")]
		public long UpdateTime { get; set; }

		[JsonPropertyName("createTime")]
		[Description("创建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("shopId")]
		[Description("店铺id")]
		public long ShopId { get; set; }

		[JsonPropertyName("warehouseType")]
		[Description("仓类型")]
		public long WarehouseType { get; set; }

		[Description("绑定的外部围栏ID列表")]
		public List<string> OutFenceIds { get; set; }
	}
}
