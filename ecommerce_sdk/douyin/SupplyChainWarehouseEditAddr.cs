namespace ecommerce.sdk.douyin;

[Description("编辑区域仓地址")]
public class SupplyChainWarehouseEditAddrReq : IDouyinReq<SupplyChainWarehouseEditAddrRsp>
{

	public string GetMethod() { return "supplyChain.warehouse.editAddr"; }

	public string GetUrl() { return "/supplyChain/warehouse/editAddr"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓编码")]
	[NotNull]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("warehouse_addr_list")]
	[Description("仓地址列表")]
	[NotNull]
	public List<WarehouseAddrListItem> WarehouseAddrList { get; set; }

	public class WarehouseAddrListItem
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

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		[NotNull]
		public long? UpdateTime { get; set; }
	}
}

[Description("编辑区域仓地址")]
public class SupplyChainWarehouseEditAddrRsp
{
}
