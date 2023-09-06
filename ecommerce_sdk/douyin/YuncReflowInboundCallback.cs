namespace ecommerce.sdk.douyin;

[Description("回告翻仓入库单信息")]
public class YuncReflowInboundCallbackReq : IDouyinReq<YuncReflowInboundCallbackRsp>
{

	public string GetMethod() { return "yunc.reflow.inboundCallback"; }

	public string GetUrl() { return "/yunc/reflow/inboundCallback"; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("inbound_order_no")]
	[Description("入库单号")]
	[NotNull]
	public string InboundOrderNo { get; set; }

	[JsonPropertyName("order_type")]
	[Description("单据类型（CGRK-采购入库，XTRK-销退入库，DBRK-调拨入库，SCRK-生产入库，QTRK-其他入库）")]
	[NotNull]
	public string OrderType { get; set; }

	[JsonPropertyName("event_type")]
	[Description("事件类型（1-已创建，2-分批收货，3-收货完成，4-已取消，6-上架完成，22-已登记）")]
	[NotNull]
	public int? EventType { get; set; }

	[JsonPropertyName("extend")]
	[Description("扩展字段")]
	public Dictionary<string,string> Extend { get; set; }

	[JsonPropertyName("slip_no")]
	[Description("幂等号（唯一流水号）")]
	[NotNull]
	public string SlipNo { get; set; }

	[JsonPropertyName("occur_time")]
	[Description("事件发生时间")]
	public long? OccurTime { get; set; }

	[JsonPropertyName("details")]
	[Description("入库单明细")]
	[NotNull]
	public List<DetailsItem> Details { get; set; }

	public class DetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("行号")]
		[NotNull]
		public string LineNo { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("货品编码")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("total_qty")]
		[Description("累计实收")]
		[NotNull]
		public long? TotalQty { get; set; }

		[JsonPropertyName("received_qty")]
		[Description("本次实收")]
		[NotNull]
		public long? ReceivedQty { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("库存类型（1-正品，2-残品）")]
		[NotNull]
		public int? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态（1-正常，2-质检，3-冻结）")]
		[NotNull]
		public int? InventoryStatus { get; set; }

		[JsonPropertyName("batch_info")]
		[Description("批次信息")]
		public BatchInfoItem BatchInfo { get; set; }

		public class BatchInfoItem
		{
			[JsonPropertyName("batch_number")]
			[Description("批次号")]
			public string BatchNumber { get; set; }

			[JsonPropertyName("product_date")]
			[Description("生产日期")]
			public long? ProductDate { get; set; }

			[JsonPropertyName("expire_date")]
			[Description("失效日期")]
			public long? ExpireDate { get; set; }

			[JsonPropertyName("receipt_date")]
			[Description("入库日期")]
			public long? ReceiptDate { get; set; }

			[JsonPropertyName("supplier_id")]
			[Description("供应商ID")]
			public string SupplierId { get; set; }

			[JsonPropertyName("scm_inbound_order")]
			[Description("SCM入库单号")]
			public string ScmInboundOrder { get; set; }
		}
	}
}

[Description("回告翻仓入库单信息")]
public class YuncReflowInboundCallbackRsp
{
	[JsonPropertyName("code")]
	[Description("错误码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("错误信息")]
	public string Msg { get; set; }
}
