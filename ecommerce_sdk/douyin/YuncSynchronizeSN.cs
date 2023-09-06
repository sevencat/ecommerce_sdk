namespace ecommerce.sdk.douyin;

[Description("WMS回传SN信息")]
public class YuncSynchronizeSNReq : IDouyinReq<YuncSynchronizeSNRsp>
{

	public string GetMethod() { return "yunc.synchronizeSN"; }

	public string GetUrl() { return "/yunc/synchronizeSN"; }

	[JsonPropertyName("warehouse_code")]
	[Description("字段长度(16):仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("order_no")]
	[Description("字段长度(64):单据号")]
	[NotNull]
	public string OrderNo { get; set; }

	[JsonPropertyName("order_type")]
	[Description("字段长度(32):单据类型（CGRK=采购入库，XTRK=销退入库，DBRK=调拨入库，SCRK=生产入库，QTRK=其他入库，TCCK=退仓出库，XSCK=销售出库，DBCK=调拨出库，SCCK=生产出库，QTCK=其他出库，INVENTORY_TAKING_PROFIT=库存盘点-盘盈，INVENTORY_TAKING_LOSS=库存盘点-盘亏）")]
	[NotNull]
	public string OrderType { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("字段长度(32):货主编码")]
	[NotNull]
	public string OwnerCode { get; set; }

	[JsonPropertyName("track_no")]
	[Description("字段长度(64):运单号")]
	public string TrackNo { get; set; }

	[JsonPropertyName("express_code")]
	[Description("字段长度(32):快递公司编码（字节平台编码）")]
	public string ExpressCode { get; set; }

	[JsonPropertyName("occur_time")]
	[Description("业务发生时间")]
	[NotNull]
	public long? OccurTime { get; set; }

	[JsonPropertyName("idempotent_no")]
	[Description("字段长度(128):幂等号")]
	[NotNull]
	public string IdempotentNo { get; set; }

	[JsonPropertyName("extend")]
	[Description("扩展信息")]
	public Dictionary<string,string> Extend { get; set; }

	[JsonPropertyName("sn_list")]
	[Description("SN码信息列表")]
	[NotNull]
	public List<SnListItem> SnList { get; set; }

	public class SnListItem
	{
		[JsonPropertyName("sn_code")]
		[Description("字段长度(128):SN码")]
		[NotNull]
		public string SnCode { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("字段长度(64):货品编码")]
		[NotNull]
		public string CargoCode { get; set; }
	}
}

[Description("WMS回传SN信息")]
public class YuncSynchronizeSNRsp
{
	[JsonPropertyName("code")]
	[Description("错误码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("错误信息")]
	public string Msg { get; set; }
}
