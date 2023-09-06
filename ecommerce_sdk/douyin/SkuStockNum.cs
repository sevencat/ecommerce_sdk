namespace ecommerce.sdk.douyin;

[Description("查询商品规格库存")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","code: 195250981220, 找不到对应的sku","isv.parameter-invalid:20050","请检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","参数不合法: 请输入正确sku_id或sku_code","isv.parameter-invalid:20011","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","商品信息获取异常: 获取库存数失败","isv.business-failed:20100","请稍后重试")]
public class SkuStockNumReq : IDouyinReq<SkuStockNumRsp>
{

	public string GetMethod() { return "sku.stockNum"; }

	public string GetUrl() { return "/sku/stockNum"; }

	[JsonPropertyName("sku_id")]
	[Description("商品规格id，店铺商品id下唯一，抖店平台生成")]
	public long? SkuId { get; set; }

	[JsonPropertyName("code")]
	[Description("sku商家编码，对应抖店后台商品sku商家编码。外部开发者自定义商品规格id，会校验在店铺下唯一性")]
	public string Code { get; set; }

	[JsonPropertyName("out_warehouse_id")]
	[Description("仓库编码（供应商编码）")]
	public string OutWarehouseId { get; set; }
}

[Description("查询商品规格库存")]
public class SkuStockNumRsp
{
	[JsonPropertyName("sku_id")]
	[Description("商品规格id，店铺商品id下唯一，抖店平台生成")]
	public long SkuId { get; set; }

	[JsonPropertyName("out_sku_id")]
	[Description("外部开发者自定义商品规格id，会校验再店铺下唯一性")]
	public long OutSkuId { get; set; }

	[JsonPropertyName("code")]
	[Description("sku商家编码，对应抖店后台商品sku商家编码")]
	public string Code { get; set; }

	[JsonPropertyName("sku_type")]
	[Description("sku库存类型，0-普通库存；1-区域库存；10-阶梯库存；")]
	public long SkuType { get; set; }

	[JsonPropertyName("stock_num")]
	[Description("商品规格库存；如果sku_type=0，表示全国库存； 如果sku_type=1，且入参有out_warehouse_id，则表示该仓库的库存； 如果sku_type=1，且入参无out_warehouse_id，则为空；")]
	public long StockNum { get; set; }

	[JsonPropertyName("prehold_stock_num")]
	[Description("占用库存")]
	public long PreholdStockNum { get; set; }

	[JsonPropertyName("prom_stock_num")]
	[Description("活动库存")]
	public long PromStockNum { get; set; }

	[JsonPropertyName("step_stock_num")]
	[Description("阶梯库存")]
	public long StepStockNum { get; set; }

	[JsonPropertyName("prehold_step_stock_num")]
	[Description("阶梯占用库存")]
	public long PreholdStepStockNum { get; set; }

	[JsonPropertyName("prom_step_stock_num")]
	[Description("活动阶梯库存")]
	public long PromStepStockNum { get; set; }

	[JsonPropertyName("stock_num_map")]
	[Description("如果sku_type=0，为空 如果sku_type=1，则为区域仓库存映射表，key为out_warehouse_id，value为库存")]
	public Dictionary<string,long> StockNumMap { get; set; }

	[JsonPropertyName("prehold_stock_map")]
	[Description("如果sku_type=0，为空 如果sku_type=1，则为区域仓库存映射表，key为out_warehouse_id，value为占用库存")]
	public Dictionary<string,long> PreholdStockMap { get; set; }

	[JsonPropertyName("ship_rule_map")]
	[Description("如果sku_type=0，为空 如果sku_type=1，则为区域仓库存映射表，key为out_warehouse_id，value为sku在仓中的发货时效")]
	public Dictionary<string,ShipRuleMapItem> ShipRuleMap { get; set; }

	public class ShipRuleMapItem
	{
	}

	[JsonPropertyName("normal_stock_num")]
	[Description("普通库存，非活动可售")]
	public long NormalStockNum { get; set; }

	[JsonPropertyName("channel_stock_num")]
	[Description("渠道库存")]
	public long ChannelStockNum { get; set; }
}
