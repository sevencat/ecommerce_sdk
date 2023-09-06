namespace ecommerce.sdk.douyin;

[Description("1、只支持批量同步归属于同一个商品的sku库存；,2、接口规则全部成功或全部失败，例：批量更新10个skuid库存，其中一个skuid信息不正确，这样整个请求都会失败，10个skuid都未更新成功。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","商品封禁，不可更新","isv.business-failed:2010043","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","商户状态不合法: 停业整顿状态","isv.business-failed:2010005","请检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","更新库存数失败: 幂等ID重复","isv.parameter-invalid:2010021","请勿重复请求")]
[DouyinRetCode(40004,"非法的参数","查询商品信息失败，请检查参数后重试","isv.parameter-invalid:2010013","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","商品已删除，不可更新","isv.business-failed:2010042","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","商品审核中，不可更新","isv.business-failed:2010041","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","更新库存数失败: 库存不足","isv.business-failed:2010012","请检查参数后重试")]
[DouyinRetCode(40002,"缺少必选参数","参数缺失","isv.missing-parameter:2010004","请检查参数后重试")]
[DouyinRetCode(20000,"系统错误","操作超时，请重试","isp.service-error:2010002","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","商品不存在或已彻底删除","isv.business-failed:2010058","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后再试","isv.business-failed:2010401","请稍后重试")]
[DouyinRetCode(20000,"系统错误","内部请求错误","isp.service-error:2010001","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","商品正在参加平台活动，无法修改库存类型","isv.business-failed:2010045","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","由于该商品基础分25（不达标），不支持快捷编辑价格/总库存，请点击右侧“编辑”进入商品详情页进行操作提醒：建议PC后台-商品优化-筛选“基础分不达标”，查看店铺所有不达标商品进行集中优化","isv.business-failed:2010330","由于该商品基础分25（不达标），不支持快捷编辑价格/总库存，请点击右侧“编辑”进入商品详情页进行操作提醒：建议PC后台-商品优化-筛选“基础分不达标”，查看店铺所有不达标商品进行集中优化")]
[DouyinRetCode(50002,"业务处理失败","商品正在参加平台活动（电视预售），不允许切换库存类型","isv.business-failed:2010307","商品正在参加平台活动（电视预售），不允许切换库存类型")]
public class SkuSyncStockBatchReq : IDouyinReq<SkuSyncStockBatchRsp>
{

	public string GetMethod() { return "sku.syncStockBatch"; }

	public string GetUrl() { return "/sku/syncStockBatch"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID，整型格式")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("idempotent_id")]
	[Description("幂等ID，仅incremental=true时有用")]
	public string IdempotentId { get; set; }

	[JsonPropertyName("incremental")]
	[Description("true表示增量库存，false表示全量库存，默认为false")]
	[NotNull]
	public bool? Incremental { get; set; }

	[JsonPropertyName("sku_sync_list")]
	[Description("需要批量提交的skuid及对应的库存和仓；接口规则全部成功或全部失败，例：批量更新10个skuid库存，其中一个skuid信息不正确，这样整个请求都会失败，10个skuid都未更新成功。")]
	[NotNull]
	public List<SkuSyncListItem> SkuSyncList { get; set; }

	public class SkuSyncListItem
	{
		[JsonPropertyName("outer_sku_id")]
		[Description("外部sku编码，需要结合outer_product_id进行使用")]
		public string OuterSkuId { get; set; }

		[JsonPropertyName("sku_id")]
		[Description("skuid")]
		[NotNull]
		public long? SkuId { get; set; }

		[JsonPropertyName("sku_type")]
		[Description("库存类型：0普通库存，1区域库存,10阶梯库存。 超市小时达子品传区域库存")]
		[NotNull]
		public long? SkuType { get; set; }

		[JsonPropertyName("stock_num")]
		[Description("普通库存数量")]
		public long? StockNum { get; set; }

		[JsonPropertyName("step_stock_num")]
		[Description("阶梯库存数量")]
		public long? StepStockNum { get; set; }

		[JsonPropertyName("stock_map")]
		[Description("区域库存配置")]
		public List<StockMapItem> StockMap { get; set; }

		public class StockMapItem
		{
			[JsonPropertyName("out_warehouse_id")]
			[Description("仓id，超市小时达子品传storeId")]
			[NotNull]
			public string OutWarehouseId { get; set; }

			[JsonPropertyName("stock_num")]
			[Description("库存数量")]
			[NotNull]
			public long? StockNum { get; set; }
		}

		[JsonPropertyName("supplier_id")]
		[Description("供应商ID")]
		public string SupplierId { get; set; }
	}

	[JsonPropertyName("outer_product_id")]
	[Description("推荐使用，外部商家编码，支持字符串。")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("store_id")]
	[Description("小时达二期店铺场景才可以传，小时达二期场景可以通过传入主品id+门店id对该门店下的子品进行操作")]
	public long? StoreId { get; set; }
}

[Description("1、只支持批量同步归属于同一个商品的sku库存；,2、接口规则全部成功或全部失败，例：批量更新10个skuid库存，其中一个skuid信息不正确，这样整个请求都会失败，10个skuid都未更新成功。")]
public class SkuSyncStockBatchRsp
{
}
