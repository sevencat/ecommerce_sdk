namespace ecommerce.sdk.douyin;

[Description("批量绑定地址与区域仓")]
public class WarehouseSetAddrBatchReq : IDouyinReq<WarehouseSetAddrBatchRsp>
{

	public string GetMethod() { return "warehouse.setAddrBatch"; }

	public string GetUrl() { return "/warehouse/setAddrBatch"; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓库ID")]
	[NotNull]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("addr_list")]
	[Description("仓库配送地址列表")]
	[NotNull]
	public List<AddrListItem> AddrList { get; set; }

	public class AddrListItem
	{
		[JsonPropertyName("addr_id1")]
		[Description("一级地址id")]
		[NotNull]
		public long? AddrId1 { get; set; }

		[JsonPropertyName("addr_id2")]
		[Description("二级地址id")]
		public long? AddrId2 { get; set; }

		[JsonPropertyName("addr_id3")]
		[Description("三级地址id")]
		public long? AddrId3 { get; set; }

		[JsonPropertyName("addr_id4")]
		[Description("四级地址id")]
		public long? AddrId4 { get; set; }
	}
}

[Description("批量绑定地址与区域仓")]
public class WarehouseSetAddrBatchRsp
{
}
