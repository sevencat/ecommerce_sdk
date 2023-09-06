namespace ecommerce.sdk.douyin;

[Description("1、一次请求最大支持50个sku更新")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败（check not pass）","isv.parameter-invalid:-30001","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","内部请求错误","isv.business-failed:-5000","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","商户状态不合法: 初始状态","isv.business-failed:-40010","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","当前商户状态，不可编辑","isv.business-failed:-40011","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","商品审核中，不可更新","isv.business-failed:-40001","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","商品封禁，不可更新","isv.business-failed:-40002","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","商品已删除，不可更新","isv.business-failed:-40003","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","账号权限错误","isv.business-failed:-40012","请检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:-10002","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","设置库存逻辑错误","isv.business-failed:-10007","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","Token已被使用","isv.business-failed:-20002","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","库存不足","isv.business-failed:-20001","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","有关联的货品，无法修改库存","isv.business-failed:-20011","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","当前商品的部分SKU库存不得低于活动/达人专属价设置的库存数","isv.business-failed:-20008","请检查参数后重试")]
public class SkuSyncStockBatchMultiProductsReq : IDouyinReq<SkuSyncStockBatchMultiProductsRsp>
{

	public string GetMethod() { return "sku.syncStockBatchMultiProducts"; }

	public string GetUrl() { return "/sku/syncStockBatchMultiProducts"; }

	[JsonPropertyName("items")]
	[Description("请求列表")]
	[NotNull]
	public List<ItemsItem> Items { get; set; }

	public class ItemsItem
	{
		[JsonPropertyName("store_id")]
		[Description("小时达店铺场景才可以传，小时达场景可以通过传入主品id+门店id对该门店下的子品进行操作")]
		public long? StoreId { get; set; }

		[JsonPropertyName("out_sku_id")]
		[Description("外部skuid，开发者在创建或更新商品时设置。")]
		public long? OutSkuId { get; set; }

		[JsonPropertyName("out_product_id")]
		[Description("外部商品id；开发者在创建或更新商品时设置的。")]
		public long? OutProductId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		[NotNull]
		public long? ProductId { get; set; }

		[JsonPropertyName("sku_id")]
		[Description("商品规格ID；一次请求最大支持50个sku更新")]
		[NotNull]
		public long? SkuId { get; set; }

		[JsonPropertyName("out_warehouse_id")]
		[Description("外部仓库id编码，开发者自定义；如传入传值表示更新区域库存，不传默认更新普通库存。可以使用【/warehouse/list】接口响应参数【out_warehouse_id】字段获取。超市小时达店铺类型，需传入store_id字段，store_id可以使用【/shop/batchCreateStore】创建成功后获取")]
		public string OutWarehouseId { get; set; }

		[JsonPropertyName("stock_num")]
		[Description("现货库存数")]
		public long? StockNum { get; set; }

		[JsonPropertyName("step_stock_num")]
		[Description("阶梯库存数")]
		public long? StepStockNum { get; set; }
	}

	[JsonPropertyName("idempotent_id")]
	[Description("幂等ID")]
	[NotNull]
	public string IdempotentId { get; set; }

	[JsonPropertyName("incremental")]
	[Description("库存更新方式，必填字段；true-增量更新，同时stock_num和step_stock_num字段可以为正数或负数；false-全量更新，同时stock_num和step_stock_num字段只能为正数数")]
	[NotNull]
	public bool? Incremental { get; set; }

	[JsonPropertyName("source")]
	[Description("请求来源，开发者自定义；")]
	public string Source { get; set; }
}

[Description("1、一次请求最大支持50个sku更新")]
public class SkuSyncStockBatchMultiProductsRsp
{
	[JsonPropertyName("results")]
	[Description("结果列表")]
	public List<ResultsItem> Results { get; set; }

	public class ResultsItem
	{
		[JsonPropertyName("sku_id")]
		[Description("商品规格ID")]
		public long SkuId { get; set; }

		[JsonPropertyName("warehouse_id")]
		[Description("仓ID")]
		public long WarehouseId { get; set; }

		[JsonPropertyName("stock_num")]
		[Description("现货库存数")]
		public long StockNum { get; set; }

		[JsonPropertyName("step_stock_num")]
		[Description("阶梯库存数")]
		public long StepStockNum { get; set; }

		[JsonPropertyName("change_num")]
		[Description("更改的现货库存数")]
		public long ChangeNum { get; set; }

		[JsonPropertyName("step_change_num")]
		[Description("更改的阶梯库存数")]
		public long StepChangeNum { get; set; }

		[JsonPropertyName("status_code")]
		[Description("状态码")]
		public long StatusCode { get; set; }

		[JsonPropertyName("status_message")]
		[Description("状态信息")]
		public string StatusMessage { get; set; }
	}
}
