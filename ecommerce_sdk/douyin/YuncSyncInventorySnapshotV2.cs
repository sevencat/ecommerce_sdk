namespace ecommerce.sdk.douyin;

[Description("库存快照回传V2")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:1001","根据提示处理")]
[DouyinRetCode(50002,"业务处理失败","鉴权失败","isv.business-failed:1003","根据提示处理")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:1004","根据提示处理")]
public class YuncSyncInventorySnapshotV2Req : IDouyinReq<YuncSyncInventorySnapshotV2Rsp>
{

	public string GetMethod() { return "yunc.syncInventorySnapshotV2"; }

	public string GetUrl() { return "/yunc/syncInventorySnapshotV2"; }

	[JsonPropertyName("idempotent_no")]
	[Description("字段长度(20):幂等键")]
	[NotNull]
	public string IdempotentNo { get; set; }

	[JsonPropertyName("total_lines")]
	[Description("字段长度(10):总行数")]
	[NotNull]
	public long? TotalLines { get; set; }

	[JsonPropertyName("current_page")]
	[Description("字段长度(10):当前页，一次性回传的话，传1")]
	[NotNull]
	public long? CurrentPage { get; set; }

	[JsonPropertyName("page_size")]
	[Description("字段长度(10):当前页数量，一次性回传的话，值等于总行数")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("occur_time")]
	[Description("字段长度(10):发生时间，秒级时间戳；比如1.31凌晨2点回传前一天的快照，时间应该是1.30 23点59分59秒")]
	[NotNull]
	public long? OccurTime { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("字段长度(16):仓code")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("字段长度(16):仓code")]
	[NotNull]
	public string OwnerCode { get; set; }

	[JsonPropertyName("api_time")]
	[Description("字段长度(10):接口请求时间，秒级时间戳")]
	[NotNull]
	public long? ApiTime { get; set; }

	[JsonPropertyName("details")]
	[Description("明细")]
	[NotNull]
	public List<DetailsItem> Details { get; set; }

	public class DetailsItem
	{
		[JsonPropertyName("cargo_code")]
		[Description("字段长度(64):货品code")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("cargo_type")]
		[Description("字段长度(2):货品类型，默认1")]
		[NotNull]
		public short? CargoType { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("字段长度(2):库存类型，1正品；2次品")]
		[NotNull]
		public short? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("字段长度(2):库存状态，1正常；2质检；3冻结")]
		[NotNull]
		public short? InventoryStatus { get; set; }

		[JsonPropertyName("scm_inbound_order")]
		[Description("字段长度(20):scm入库单号")]
		[NotNull]
		public string ScmInboundOrder { get; set; }

		[JsonPropertyName("supplier_id")]
		[Description("字段长度(20):供应商id")]
		[NotNull]
		public string SupplierId { get; set; }

		[JsonPropertyName("product_date")]
		[Description("字段长度(10):生产日期，秒级时间戳")]
		[NotNull]
		public long? ProductDate { get; set; }

		[JsonPropertyName("expire_date")]
		[Description("字段长度(10):失效日期，秒级时间戳")]
		[NotNull]
		public long? ExpireDate { get; set; }

		[JsonPropertyName("receipt_date")]
		[Description("字段长度(10):接收时间，秒级时间戳")]
		[NotNull]
		public long? ReceiptDate { get; set; }

		[JsonPropertyName("batch_number")]
		[Description("字段长度(26):批次号")]
		[NotNull]
		public string BatchNumber { get; set; }

		[JsonPropertyName("opening_inventory")]
		[Description("字段长度(10):期初库存")]
		[NotNull]
		public decimal? OpeningInventory { get; set; }

		[JsonPropertyName("ending_inventory")]
		[Description("字段长度(10):期末库存")]
		[NotNull]
		public decimal? EndingInventory { get; set; }

		[JsonPropertyName("occupied_inventory")]
		[Description("占用库存数量")]
		public long? OccupiedInventory { get; set; }

		[JsonPropertyName("lot_id")]
		[Description("字段长度(128):批次ID 唯一标识一组批次属性 batch_number + product_date + expire_date + receipt_date + supplier_id + scm_inbound_order + batch_extend")]
		public string LotId { get; set; }

		[JsonPropertyName("batch_extend")]
		[Description("批属性扩展字段，json形式(仅接收规定key)")]
		public string BatchExtend { get; set; }
	}

	[JsonPropertyName("vendor_no")]
	[Description("服务商编码")]
	[NotNull]
	public string VendorNo { get; set; }

	[JsonPropertyName("shop_id_out")]
	[Description("店铺ID")]
	[NotNull]
	public long? ShopIdOut { get; set; }
}

[Description("库存快照回传V2")]
public class YuncSyncInventorySnapshotV2Rsp
{
}
