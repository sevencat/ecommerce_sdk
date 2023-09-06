namespace ecommerce.sdk.douyin;

[Description("根据商品id获取商品的sku列表，支持返回预占库存信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","该商品不属于你","isv.parameter-invalid:4","请检查参数后重试")]
[DouyinRetCode(40002,"缺少必选参数","[product_id]与[out_product_id]参数至少传一个","isv.missing-parameter:3","请填写product_id或out_product_id")]
[DouyinRetCode(50002,"业务处理失败","获取库存数失败","isv.business-failed:7","请稍后重试")]
public class SkuListReq : IDouyinReq<SkuListRsp>
{

	public string GetMethod() { return "sku.list"; }

	public string GetUrl() { return "/sku/list"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID；抖店系统生成。")]
	public long? ProductId { get; set; }

	[JsonPropertyName("out_product_id")]
	[Description("外部商品ID；商家创建商品时自定义。")]
	public long? OutProductId { get; set; }
}

[Description("根据商品id获取商品的sku列表，支持返回预占库存信息")]
public class SkuListRsp
{
	[JsonPropertyName("data")]
	[Description("sku列表")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("id")]
		[Description("商品sku_id;抖店系统生成。")]
		public long Id { get; set; }

		[JsonPropertyName("open_user_id")]
		[Description("app_key")]
		public long OpenUserId { get; set; }

		[JsonPropertyName("out_sku_id")]
		[Description("外部的skuId；商家自定义；未设置返回为0。")]
		public long OutSkuId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID；抖店系统生成。")]
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
		[Description("商品价格，单位：分")]
		public long Price { get; set; }

		[JsonPropertyName("settlement_price")]
		[Description("结算价格，【已废弃】价格字段是price")]
		public long SettlementPrice { get; set; }

		[JsonPropertyName("spec_id")]
		[Description("规格ID")]
		public long SpecId { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间，时间戳：单位秒；")]
		public long CreateTime { get; set; }

		[JsonPropertyName("code")]
		[Description("sku外部编码")]
		public string Code { get; set; }

		[JsonPropertyName("sku_type")]
		[Description("库存类型；0-普通；1-区域库存；10-阶梯库存；")]
		public long SkuType { get; set; }

		[JsonPropertyName("supplier_id")]
		[Description("供应商ID")]
		public string SupplierId { get; set; }

		[JsonPropertyName("stock_num")]
		[Description("sku_type=0时，表示普通库存数量 ;sku_type=1时，使用stock_map，表示区域库存数量")]
		public long StockNum { get; set; }

		[JsonPropertyName("prehold_stock_num")]
		[Description("sku_type=0时，表示预占库存数量； sku_type=1时，表示区域库存数量，使用prehold_stock_map")]
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
		[Description("如果sku_type=0，为空 如果sku_type=1，则为区域仓库存映射表，key为out_warehouse_id（区域仓库id使用【/warehouse/list】查询），value为库存")]
		public Dictionary<string,long> StockMap { get; set; }

		[JsonPropertyName("prehold_stock_map")]
		[Description("如果sku_type=0，为空 如果sku_type=1，则为区域仓库存映射表，key为out_warehouse_id（区域仓库id使用【/warehouse/list】查询），value为占用库存")]
		public Dictionary<string,long> PreholdStockMap { get; set; }

		[JsonPropertyName("product_id_str")]
		[Description("商品 ID字符串类型")]
		public string ProductIdStr { get; set; }

		[JsonPropertyName("ship_rule_map")]
		[Description("如果sku_type=0，为空 如果sku_type=1，则为区域仓库存映射表，key为out_warehouse_id（区域仓库id使用【/warehouse/list】查询），value为sku 在对应仓中的发货时效")]
		public Dictionary<string,ShipRuleMapItem> ShipRuleMap { get; set; }

		public class ShipRuleMapItem
		{
			[JsonPropertyName("presell_type")]
			[Description("0 现货模式  1 全款预售模式")]
			public long PresellType { get; set; }

			[JsonPropertyName("delay_day")]
			[Description("发货延迟时间；0表示当天发货；")]
			public long DelayDay { get; set; }

			[JsonPropertyName("presell_end_time")]
			[Description("全款预售截止时间  presell_type = 1时有用")]
			public long PresellEndTime { get; set; }
		}

		[JsonPropertyName("is_suit")]
		[Description("海南免税：是否套装，0 否，1 是")]
		public int IsSuit { get; set; }

		[JsonPropertyName("suit_num")]
		[Description("海南免税：套装数量")]
		public long SuitNum { get; set; }

		[JsonPropertyName("volume")]
		[Description("海南免税：净含量")]
		public long Volume { get; set; }

		[JsonPropertyName("normal_stock_num")]
		[Description("库存模型V2新增 普通库存 非活动可售")]
		public long NormalStockNum { get; set; }

		[JsonPropertyName("channel_stock_num")]
		[Description("库存模型V2新增 渠道库存")]
		public long ChannelStockNum { get; set; }

		[JsonPropertyName("sell_properties")]
		[Description("销售属性，代替spec_detail_id123、spec_detail_name123")]
		public List<SellPropertiesItem> SellProperties { get; set; }

		public class SellPropertiesItem
		{
			[JsonPropertyName("value_spec_detail_id")]
			[Description("规格值id")]
			public long ValueSpecDetailId { get; set; }

			[JsonPropertyName("value_name")]
			[Description("规格值名称")]
			public string ValueName { get; set; }
		}
	}
}
