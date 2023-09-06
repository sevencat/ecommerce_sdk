namespace ecommerce.sdk.douyin;

[Description("设置全国覆盖和区域覆盖库存")]
[DouyinRetCode(10000,"success","","","")]
public class SupplyChainSkuSyncSupplyStockReq : IDouyinReq<SupplyChainSkuSyncSupplyStockRsp>
{

	public string GetMethod() { return "supplyChain.sku.syncSupplyStock"; }

	public string GetUrl() { return "/supplyChain/sku/syncSupplyStock"; }

	[JsonPropertyName("sku_id")]
	[Description("skuid")]
	[NotNull]
	public long? SkuId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("productid")]
	public long? ProductId { get; set; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓库编码")]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("incremental")]
	[Description("是否增量同步，当前供销平台只支持增量同步")]
	public bool? Incremental { get; set; }

	[JsonPropertyName("idempotent_id")]
	[Description("请求幂等键")]
	public string IdempotentId { get; set; }

	[JsonPropertyName("stock_num")]
	[Description("库存变更量，负值代表减")]
	[NotNull]
	public long? StockNum { get; set; }
}

[Description("设置全国覆盖和区域覆盖库存")]
public class SupplyChainSkuSyncSupplyStockRsp
{
}
