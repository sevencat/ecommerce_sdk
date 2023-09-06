namespace ecommerce.sdk.douyin;

[Description("1、支持修改普通库存,区域库存,阶梯库存,2、支持增量更新，当incremental=true时idempotent_id字段参数必传，同时stock_num支持加/减库存。加库存例：原商品库存是10个，接口传入5个，执行成功商品库存是15个。减库存例：原商品库存是10个，接口stock_num传入-5，执行成功商品库存是5个。注意：减库存时【商品现库存-即将减少库存数不能<0】，否则会报错系统错误:更新库存数失败: 库存不足；,3、支持全量更新。例：原商品库存是10个，接口传入5个，执行成功商品库存是5个。,4、可以设置库存为0,5、超市小时达店铺类型，更新库存out_warehouse_id= store_id（门店id）表示更新门店商品库存。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","当前sku已被删除,禁止修改库存","isv.parameter-invalid:4","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010401:系统繁忙，请稍后再试","isv.business-failed:2010401","2010401:系统繁忙，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","sku_id: 21062210000363, 找不到对应的sku","isv.parameter-invalid:5","请检查请求参数的skuid是否存在或商品已经被删除")]
[DouyinRetCode(40004,"非法的参数","[idempotent_id]重复，操作已执行","isv.parameter-invalid:40010","idempotent_id需要保持唯一性，请检查替换idempotent_id值")]
[DouyinRetCode(40004,"非法的参数","系统错误:获取区域仓失败","isv.parameter-invalid:40004","此报错是超时导致，重试即可")]
public class SkuSyncStockReq : IDouyinReq<SkuSyncStockRsp>
{

	public string GetMethod() { return "sku.syncStock"; }

	public string GetUrl() { return "/sku/syncStock"; }

	[JsonPropertyName("code")]
	[Description("sku编码")]
	public string Code { get; set; }

	[JsonPropertyName("sku_id")]
	[Description("规格id；抖店系统生成，商品id下唯一。")]
	public long? SkuId { get; set; }

	[JsonPropertyName("out_sku_id")]
	[Description("外部skuid，开发者在创建或更新商品时设置。")]
	public long? OutSkuId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品ID，抖店系统生成，店铺下唯一；长度19位。")]
	public long? ProductId { get; set; }

	[JsonPropertyName("out_product_id")]
	[Description("外部商品id；开发者在创建或更新商品时设置的。")]
	public long? OutProductId { get; set; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("外部仓库id编码，开发者自定义；如传入传值表示更新区域库存，不传默认更新普通库存。可以使用【/warehouse/list】接口响应参数【out_warehouse_id】字段获取。超市小时达店铺类型，需传入store_id字段，store_id可以使用【/shop/batchCreateStore】创建成功后获取")]
	public string OutWarehouseId { get; set; }

	[JsonPropertyName("supplier_id")]
	[Description("供应商ID")]
	public string SupplierId { get; set; }

	[JsonPropertyName("incremental")]
	[Description("库存更新方式；true-增量更新，同时idempotent_id字段必填；false-全量更新；默认为false")]
	public bool? Incremental { get; set; }

	[JsonPropertyName("idempotent_id")]
	[Description("幂等ID，当incremental=true时该参数必传")]
	public string IdempotentId { get; set; }

	[JsonPropertyName("stock_num")]
	[Description("库存值；可以设置为0，不能小于0，当incremental=true时stock_num支持加/减库存。支持传入“-”，例如：-5表示减5个库存；加库存例：原商品库存是10个，接口传入5个，执行成功商品库存是15个。减库存例：原商品库存是10个，接口stock_num传入-5，执行成功商品库存是5个。注意：减库存时【商品现库存-即将减少库存数不能<0】，否则会报错系统错误:更新库存数失败: 库存不足；")]
	[NotNull]
	public long? StockNum { get; set; }

	[JsonPropertyName("step_stock_num")]
	[Description("阶梯库存")]
	public long? StepStockNum { get; set; }

	[JsonPropertyName("store_id")]
	[Description("小时达店铺场景才可以传，小时达场景可以通过传入主品id+门店id对该门店下的子品进行操作")]
	public long? StoreId { get; set; }
}

[Description("1、支持修改普通库存,区域库存,阶梯库存,2、支持增量更新，当incremental=true时idempotent_id字段参数必传，同时stock_num支持加/减库存。加库存例：原商品库存是10个，接口传入5个，执行成功商品库存是15个。减库存例：原商品库存是10个，接口stock_num传入-5，执行成功商品库存是5个。注意：减库存时【商品现库存-即将减少库存数不能<0】，否则会报错系统错误:更新库存数失败: 库存不足；,3、支持全量更新。例：原商品库存是10个，接口传入5个，执行成功商品库存是5个。,4、可以设置库存为0,5、超市小时达店铺类型，更新库存out_warehouse_id= store_id（门店id）表示更新门店商品库存。")]
public class SkuSyncStockRsp
{
}
