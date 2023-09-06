namespace ecommerce.sdk.douyin;

[Description("根据sku_id获取sku详情信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","code: 1715469761741840, 找不到对应的sku","isv.parameter-invalid:20050","请检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","参数不合法: 请输入正确sku_id或sku_code","isv.parameter-invalid:20011","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","商品信息获取异常: 获取sku仓时效失败","isv.business-failed:20100","请稍后重试")]
public class SkuDetailReq : IDouyinReq<SkuDetailRsp>
{

	public string GetMethod() { return "sku.detail"; }

	public string GetUrl() { return "/sku/detail"; }

	[JsonPropertyName("sku_id")]
	[Description("sku id，推荐使用")]
	public long? SkuId { get; set; }

	[JsonPropertyName("code")]
	[Description("sku code，不推荐")]
	public string Code { get; set; }
}

[Description("根据sku_id获取sku详情信息")]
public class SkuDetailRsp
{
	[JsonPropertyName("id")]
	[Description("sku id")]
	public long Id { get; set; }

	[JsonPropertyName("open_user_id")]
	[Description("app_key")]
	public long OpenUserId { get; set; }

	[JsonPropertyName("out_sku_id")]
	[Description("外部的skuId")]
	public long OutSkuId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	public long ProductId { get; set; }

	[JsonPropertyName("spec_detail_id1")]
	[Description("第一级子规格")]
	public long SpecDetailId1 { get; set; }

	[JsonPropertyName("spec_detail_id2")]
	[Description("第二级子规格")]
	public long SpecDetailId2 { get; set; }

	[JsonPropertyName("spec_detail_id3")]
	[Description("第三级子规格")]
	public long SpecDetailId3 { get; set; }

	[JsonPropertyName("spec_detail_name1")]
	[Description("第一级子规格名")]
	public string SpecDetailName1 { get; set; }

	[JsonPropertyName("spec_detail_name2")]
	[Description("第二级子规格名")]
	public string SpecDetailName2 { get; set; }

	[JsonPropertyName("spec_detail_name3")]
	[Description("第三级子规格名")]
	public string SpecDetailName3 { get; set; }

	[JsonPropertyName("customs_report_info")]
	[Description("海关申报要素")]
	public CustomsReportInfoItem CustomsReportInfo { get; set; }

	public class CustomsReportInfoItem
	{
		[JsonPropertyName("hs_code")]
		[Description("海关代码")]
		public string HsCode { get; set; }

		[JsonPropertyName("first_measure_qty")]
		[Description("法定第一计量数量")]
		public decimal FirstMeasureQty { get; set; }

		[JsonPropertyName("second_measure_qty")]
		[Description("法定第二计量数量")]
		public decimal SecondMeasureQty { get; set; }

		[JsonPropertyName("first_measure_unit")]
		[Description("法定第一计量单位")]
		public string FirstMeasureUnit { get; set; }

		[JsonPropertyName("second_measure_unit")]
		[Description("法定第二计量单位")]
		public string SecondMeasureUnit { get; set; }

		[JsonPropertyName("unit")]
		[Description("售卖单位")]
		public string Unit { get; set; }

		[JsonPropertyName("report_name")]
		[Description("品名")]
		public string ReportName { get; set; }

		[JsonPropertyName("report_brand_name")]
		[Description("品牌")]
		public string ReportBrandName { get; set; }

		[JsonPropertyName("usage")]
		[Description("用途")]
		public string Usage { get; set; }

		[JsonPropertyName("g_model")]
		[Description("规格型号")]
		public string GModel { get; set; }

		[JsonPropertyName("bar_code")]
		[Description("条形码")]
		public string BarCode { get; set; }
	}

	[JsonPropertyName("price")]
	[Description("价格")]
	public long Price { get; set; }

	[JsonPropertyName("settlement_price")]
	[Description("结算价格，【已废弃】价格字段是price")]
	public long SettlementPrice { get; set; }

	[JsonPropertyName("spec_id")]
	[Description("规格ID")]
	public long SpecId { get; set; }

	[JsonPropertyName("create_time")]
	[Description("创建时间")]
	public long CreateTime { get; set; }

	[JsonPropertyName("code")]
	[Description("sku外部编码")]
	public string Code { get; set; }

	[JsonPropertyName("sku_type")]
	[Description("0-普通 1-区域库存")]
	public long SkuType { get; set; }

	[JsonPropertyName("supplier_id")]
	[Description("供应商ID")]
	public string SupplierId { get; set; }

	[JsonPropertyName("stock_num")]
	[Description("sku_type=0时，表示库存数量 sku_type=1时，使用stock_map")]
	public long StockNum { get; set; }

	[JsonPropertyName("prehold_stock_num")]
	[Description("sku_type=0时，表示预占库存数量 sku_type=1时，使用prehold_stock_map")]
	public long PreholdStockNum { get; set; }

	[JsonPropertyName("prom_stock_num")]
	[Description("活动库存")]
	public long PromStockNum { get; set; }

	[JsonPropertyName("step_stock_num")]
	[Description("阶梯库存")]
	public long StepStockNum { get; set; }

	[JsonPropertyName("prehold_step_stock_num")]
	[Description("预占阶梯库存")]
	public long PreholdStepStockNum { get; set; }

	[JsonPropertyName("prom_step_stock_num")]
	[Description("活动阶梯库存")]
	public long PromStepStockNum { get; set; }

	[JsonPropertyName("stock_map")]
	[Description("如果sku_type=0，为空 如果sku_type=1，则为区域仓库存映射表，key为out_warehouse_id，value为库存")]
	public Dictionary<object,object> StockMap { get; set; }

	[JsonPropertyName("prehold_stock_map")]
	[Description("如果sku_type=0，为空 如果sku_type=1，则为区域仓库存映射表，key为out_warehouse_id，value为占用库存")]
	public Dictionary<object,object> PreholdStockMap { get; set; }

	[JsonPropertyName("product_id_str")]
	[Description("商品 ID 字符串")]
	public string ProductIdStr { get; set; }

	[JsonPropertyName("ship_rule_map")]
	[Description("如果sku_type=0，为空 如果sku_type=1，则为区域仓库存映射表，key为out_warehouse_id，value为sku 在对应仓中的发货时效")]
	public Dictionary<object,object> ShipRuleMap { get; set; }
}
