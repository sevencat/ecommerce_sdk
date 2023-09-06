namespace ecommerce.sdk.douyin;

[Description("查询sku库存")]
public class SupplyChainSkuStockNumReq : IDouyinReq<SupplyChainSkuStockNumRsp>
{

	public string GetMethod() { return "supplyChain.sku.stockNum"; }

	public string GetUrl() { return "/supplyChain/sku/stockNum"; }

	[JsonPropertyName("sku_id")]
	[Description("skuid")]
	public long? SkuId { get; set; }

	[JsonPropertyName("outer_sku_id")]
	[Description("外部skuid")]
	public string OuterSkuId { get; set; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓编码")]
	public string OutWarehouseId { get; set; }
}

[Description("查询sku库存")]
public class SupplyChainSkuStockNumRsp
{
	[JsonPropertyName("data")]
	[Description("返回数据")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("out_warehouse_id")]
		[Description("外部仓编码")]
		public string OutWarehouseId { get; set; }

		[JsonPropertyName("total_qty")]
		[Description("总库存")]
		public long TotalQty { get; set; }

		[JsonPropertyName("alloc_qty")]
		[Description("已发货库存")]
		public long AllocQty { get; set; }

		[JsonPropertyName("remain_qty")]
		[Description("剩余可用库存")]
		public long RemainQty { get; set; }
	}
}
