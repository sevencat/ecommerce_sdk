namespace ecommerce.sdk.douyin;

[Description("创建翻仓入库单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:1001","联系系统负责人处理")]
[DouyinRetCode(50002,"业务处理失败","货主、店铺信息不合法","isv.business-failed:13001","确定店铺和货主的有效性")]
public class YuncReflowInboundCreateReq : IDouyinReq<YuncReflowInboundCreateRsp>
{

	public string GetMethod() { return "yunc.reflow.inboundCreate"; }

	public string GetUrl() { return "/yunc/reflow/inboundCreate"; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码（仅允许仓库类型为翻仓）")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("inbound_order_no")]
	[Description("入库单号")]
	[NotNull]
	public string InboundOrderNo { get; set; }

	[JsonPropertyName("biz_order_no")]
	[Description("上游业务单号")]
	[NotNull]
	public string BizOrderNo { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }

	[JsonPropertyName("owner_name")]
	[Description("货主名称")]
	public string OwnerName { get; set; }

	[JsonPropertyName("order_type")]
	[Description("单据类型（CGRK-采购入库，XTRK-销退入库，DBRK-调拨入库，SCRK-生产入库，QTRK-其他入库）")]
	[NotNull]
	public string OrderType { get; set; }

	[JsonPropertyName("status")]
	[Description("单据状态")]
	[NotNull]
	public int? Status { get; set; }

	[JsonPropertyName("supplier_code")]
	[Description("供应商编码")]
	public string SupplierCode { get; set; }

	[JsonPropertyName("supplier_name")]
	[Description("供应商名称")]
	public string SupplierName { get; set; }

	[JsonPropertyName("shopid")]
	[Description("店铺ID")]
	public long? Shopid { get; set; }

	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	public string ShopName { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("sale_outbound_order_no")]
	[Description("销售出库单号")]
	public string SaleOutboundOrderNo { get; set; }

	[JsonPropertyName("sale_way_bill_no")]
	[Description("销售运单号")]
	public string SaleWayBillNo { get; set; }

	[JsonPropertyName("sale_express")]
	[Description("销售快递商编码")]
	public string SaleExpress { get; set; }

	[JsonPropertyName("sale_express_name")]
	[Description("销售快递商名称")]
	public string SaleExpressName { get; set; }

	[JsonPropertyName("sale_return_way_bill_no")]
	[Description("销退运单号")]
	public string SaleReturnWayBillNo { get; set; }

	[JsonPropertyName("sale_return_express")]
	[Description("销退快递商编码")]
	public string SaleReturnExpress { get; set; }

	[JsonPropertyName("sale_return_express_name")]
	[Description("销退快递商名称")]
	public string SaleReturnExpressName { get; set; }

	[JsonPropertyName("order_details")]
	[Description("入库单明细")]
	[NotNull]
	public List<OrderDetailsItem> OrderDetails { get; set; }

	public class OrderDetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("行号（同一入库单下行号唯一）")]
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

		[JsonPropertyName("barcode")]
		[Description("货品条码")]
		public string Barcode { get; set; }

		[JsonPropertyName("erp_sku_id")]
		[Description("ERP商品ID")]
		public string ErpSkuId { get; set; }

		[JsonPropertyName("expect_qty")]
		[Description("预计入库数量")]
		[NotNull]
		public int? ExpectQty { get; set; }

		[JsonPropertyName("actual_qty")]
		[Description("实际入库数量")]
		public int? ActualQty { get; set; }
	}

	[JsonPropertyName("order_create_time")]
	[Description("wms系统单据创建时间")]
	public long? OrderCreateTime { get; set; }
}

[Description("创建翻仓入库单")]
public class YuncReflowInboundCreateRsp
{
	[JsonPropertyName("code")]
	[Description("错误码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("错误信息")]
	public string Msg { get; set; }
}
