namespace ecommerce.sdk.douyin;

[Description("库存对账")]
public class YuncReflowInventoryCheckReq : IDouyinReq<YuncReflowInventoryCheckRsp>
{

	public string GetMethod() { return "yunc.reflow.inventoryCheck"; }

	public string GetUrl() { return "/yunc/reflow/inventoryCheck"; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("audit_date")]
	[Description("对账日期（yyyyMMDD）")]
	[NotNull]
	public string AuditDate { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("audit_details")]
	[Description("单据对账明细")]
	public List<AuditDetailsItem> AuditDetails { get; set; }

	public class AuditDetailsItem
	{
		[JsonPropertyName("reflow_order_type")]
		[Description("翻仓单据类型（1-入库单，2-出库单，3-库调单）")]
		[NotNull]
		public int? ReflowOrderType { get; set; }

		[JsonPropertyName("shopid")]
		[Description("店铺ID")]
		[NotNull]
		public long? Shopid { get; set; }

		[JsonPropertyName("order_qty")]
		[Description("单据数量")]
		[NotNull]
		public long? OrderQty { get; set; }
	}
}

[Description("库存对账")]
public class YuncReflowInventoryCheckRsp
{
	[JsonPropertyName("code")]
	[Description("错误码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("错误信息")]
	public string Msg { get; set; }
}
