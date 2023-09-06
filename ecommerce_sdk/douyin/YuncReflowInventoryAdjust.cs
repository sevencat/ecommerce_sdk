namespace ecommerce.sdk.douyin;

[Description("库存调整，包括库存盘点和库存转移")]
public class YuncReflowInventoryAdjustReq : IDouyinReq<YuncReflowInventoryAdjustRsp>
{

	public string GetMethod() { return "yunc.reflow.inventoryAdjust"; }

	public string GetUrl() { return "/yunc/reflow/inventoryAdjust"; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("adjust_no")]
	[Description("外部调整单号")]
	[NotNull]
	public string AdjustNo { get; set; }

	[JsonPropertyName("adjust_type")]
	[Description("调整类型（1=库存盘点，2=库存转移）")]
	[NotNull]
	public short? AdjustType { get; set; }

	[JsonPropertyName("adjust_time")]
	[Description("调整时间（业务发生时间）")]
	[NotNull]
	public long? AdjustTime { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	[NotNull]
	public string Remark { get; set; }

	[JsonPropertyName("details")]
	[Description("调整明细")]
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

		[JsonPropertyName("cargo_name")]
		[Description("货品名称")]
		[NotNull]
		public string CargoName { get; set; }

		[JsonPropertyName("erp_sku_id")]
		[Description("ERP商品ID")]
		public string ErpSkuId { get; set; }

		[JsonPropertyName("owner_code")]
		[Description("货主编码")]
		public string OwnerCode { get; set; }

		[JsonPropertyName("owner_name")]
		[Description("货主名称")]
		public string OwnerName { get; set; }

		[JsonPropertyName("shopid")]
		[Description("店铺ID")]
		public long? Shopid { get; set; }

		[JsonPropertyName("shop_name")]
		[Description("店铺名称")]
		public string ShopName { get; set; }

		[JsonPropertyName("adjust_list")]
		[Description("调整列表")]
		[NotNull]
		public List<AdjustListItem> AdjustList { get; set; }

		public class AdjustListItem
		{
			[JsonPropertyName("adjust_direction")]
			[Description("调整方向（1-调增，2-调减）")]
			[NotNull]
			public short? AdjustDirection { get; set; }

			[JsonPropertyName("adjust_qty")]
			[Description("调整数量（正数）")]
			[NotNull]
			public long? AdjustQty { get; set; }

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
}

[Description("库存调整，包括库存盘点和库存转移")]
public class YuncReflowInventoryAdjustRsp
{
	[JsonPropertyName("code")]
	[Description("错误码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("错误信息")]
	public string Msg { get; set; }
}
