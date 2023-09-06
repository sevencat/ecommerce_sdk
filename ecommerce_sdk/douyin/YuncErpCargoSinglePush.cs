namespace ecommerce.sdk.douyin;

[Description("erp推送货品数据至字节云仓")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务异常","isp.service-error:1000","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","参数错误","isv.business-failed:3000","请根据报错修复参数")]
[DouyinRetCode(50002,"业务处理失败","并发更新失败","isv.business-failed:3202","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","并发更新失败","isv.business-failed:3201","请稍后重试")]
public class YuncErpCargoSinglePushReq : IDouyinReq<YuncErpCargoSinglePushRsp>
{

	public string GetMethod() { return "yunc.erpCargoSinglePush"; }

	public string GetUrl() { return "/yunc/erpCargoSinglePush"; }

	[JsonPropertyName("shop_id")]
	[Description("抖店店铺id")]
	[NotNull]
	public long? ShopId { get; set; }

	[JsonPropertyName("cargo_name")]
	[Description("货品名称")]
	[NotNull]
	public string CargoName { get; set; }

	[JsonPropertyName("cargo_desc")]
	[Description("货品描述")]
	public string CargoDesc { get; set; }

	[JsonPropertyName("english_name")]
	[Description("货品英文名")]
	public string EnglishName { get; set; }

	[JsonPropertyName("stock_unit")]
	[Description("计量单位, 枚举值: 台, 双, 本, 支, 片, 个, 套, 件, 副, 束, 盒")]
	public string StockUnit { get; set; }

	[JsonPropertyName("length_unit")]
	[Description("长度单位, 枚举值: mm, cm, m, km. 最小精度为整数位mm")]
	public string LengthUnit { get; set; }

	[JsonPropertyName("length")]
	[Description("长")]
	public decimal? Length { get; set; }

	[JsonPropertyName("width")]
	[Description("宽")]
	public decimal? Width { get; set; }

	[JsonPropertyName("height")]
	[Description("高")]
	public decimal? Height { get; set; }

	[JsonPropertyName("weight_unit")]
	[Description("重量单位, 枚举值: g, kg. 默认为g. 最小精度为整数位g")]
	public string WeightUnit { get; set; }

	[JsonPropertyName("gross_weight")]
	[Description("毛重")]
	public decimal? GrossWeight { get; set; }

	[JsonPropertyName("net_weight")]
	[Description("净重")]
	public decimal? NetWeight { get; set; }

	[JsonPropertyName("currency_unit")]
	[Description("货币单位, 枚举值: USD, CNY, EUR, GBP")]
	public string CurrencyUnit { get; set; }

	[JsonPropertyName("market_price")]
	[Description("市场价(吊牌价)")]
	public decimal? MarketPrice { get; set; }

	[JsonPropertyName("supply_price")]
	[Description("采购价")]
	public decimal? SupplyPrice { get; set; }

	[JsonPropertyName("retail_price")]
	[Description("零售价")]
	public decimal? RetailPrice { get; set; }

	[JsonPropertyName("is_embargo")]
	[Description("是否航空禁运品；0否1是")]
	public short? IsEmbargo { get; set; }

	[JsonPropertyName("is_fragile")]
	[Description("是否易碎品；0否1是")]
	public short? IsFragile { get; set; }

	[JsonPropertyName("is_large")]
	[Description("是否大件；0否1是")]
	public short? IsLarge { get; set; }

	[JsonPropertyName("is_precious")]
	[Description("是否贵重品；0否1是")]
	public short? IsPrecious { get; set; }

	[JsonPropertyName("is_need_valid")]
	[Description("是否效期管理；0否1是")]
	public short? IsNeedValid { get; set; }

	[JsonPropertyName("is_liquid")]
	[Description("是否液体")]
	public short? IsLiquid { get; set; }

	[JsonPropertyName("is_hazardous")]
	[Description("是否危险品")]
	public short? IsHazardous { get; set; }

	[JsonPropertyName("period_of_validity")]
	[Description("有效期；以天为单位")]
	public int? PeriodOfValidity { get; set; }

	[JsonPropertyName("period_of_forbid_sale")]
	[Description("禁售期；以天为单位. 按有效期计算, 计算规则以平台为准")]
	public int? PeriodOfForbidSale { get; set; }

	[JsonPropertyName("period_of_forbid_take")]
	[Description("禁收期；以天为单位. 按有效期计算, 计算规则以平台为准")]
	public int? PeriodOfForbidTake { get; set; }

	[JsonPropertyName("period_of_warning")]
	[Description("临期预警天数；以天为单位")]
	public int? PeriodOfWarning { get; set; }

	[JsonPropertyName("is_need_batch")]
	[Description("是否批次管理；0否1是")]
	public short? IsNeedBatch { get; set; }

	[JsonPropertyName("batch_type")]
	[Description("批次类型（1：生产批次/2：采购批次/3：收货批次）")]
	public int? BatchType { get; set; }

	[JsonPropertyName("is_must_batch")]
	[Description("是否强批次管理；0否1是")]
	public short? IsMustBatch { get; set; }

	[JsonPropertyName("accessory_info")]
	[Description("配件信息，字符串展示, 如电源 * 1, 数据线 * 2")]
	public string AccessoryInfo { get; set; }

	[JsonPropertyName("origin_address")]
	[Description("产地，一般给国家-省两级信息即可")]
	public string OriginAddress { get; set; }

	[JsonPropertyName("tax_rate")]
	[Description("增值税率")]
	public string TaxRate { get; set; }

	[JsonPropertyName("delivery_temp")]
	[Description("运输温度")]
	public string DeliveryTemp { get; set; }

	[JsonPropertyName("storage_temp")]
	[Description("存储温度")]
	public string StorageTemp { get; set; }

	[JsonPropertyName("brand_code")]
	[Description("品牌编码")]
	public string BrandCode { get; set; }

	[JsonPropertyName("brand_name")]
	[Description("品牌名称")]
	public string BrandName { get; set; }

	[JsonPropertyName("picture")]
	[Description("货品图片")]
	public string Picture { get; set; }

	[JsonPropertyName("erp_sku_id")]
	[Description("商家ERP的sku_id")]
	[NotNull]
	public string ErpSkuId { get; set; }

	[JsonPropertyName("category_id")]
	[Description("叶子类目id")]
	public long? CategoryId { get; set; }

	[JsonPropertyName("category_name")]
	[Description("叶子类目名称")]
	public string CategoryName { get; set; }

	[JsonPropertyName("barcode")]
	[Description("条形码")]
	[NotNull]
	public List<string> Barcode { get; set; }

	[JsonPropertyName("props_extends")]
	[Description("货品扩展描述属性")]
	public List<PropsExtendsItem> PropsExtends { get; set; }

	public class PropsExtendsItem
	{
		[JsonPropertyName("prop_key_id")]
		[Description("属性keyId")]
		public long? PropKeyId { get; set; }

		[JsonPropertyName("prop_key")]
		[Description("属性key")]
		public string PropKey { get; set; }

		[JsonPropertyName("prop_val_id")]
		[Description("属性值id")]
		public long? PropValId { get; set; }

		[JsonPropertyName("prop_val")]
		[Description("属性值")]
		public string PropVal { get; set; }
	}

	[JsonPropertyName("sku_props")]
	[Description("货品销售规格")]
	public List<SkuPropsItem> SkuProps { get; set; }

	public class SkuPropsItem
	{
		[JsonPropertyName("prop_key_id")]
		[Description("销售规格keyId")]
		public long? PropKeyId { get; set; }

		[JsonPropertyName("prop_key")]
		[Description("销售规格名称")]
		public string PropKey { get; set; }

		[JsonPropertyName("prop_val_id")]
		[Description("销售规格值id")]
		public long? PropValId { get; set; }

		[JsonPropertyName("prop_val")]
		[Description("销售规格值")]
		public string PropVal { get; set; }
	}

	[JsonPropertyName("category_detail")]
	[Description("类目详情")]
	public CategoryDetailItem CategoryDetail { get; set; }

	public class CategoryDetailItem
	{
		[JsonPropertyName("first_cid")]
		[Description("一级类目id")]
		public long? FirstCid { get; set; }

		[JsonPropertyName("first_cname")]
		[Description("一级类目名称")]
		public string FirstCname { get; set; }

		[JsonPropertyName("second_cid")]
		[Description("二级类目id")]
		public long? SecondCid { get; set; }

		[JsonPropertyName("second_cname")]
		[Description("二级类目名称")]
		public string SecondCname { get; set; }

		[JsonPropertyName("third_cid")]
		[Description("三级类目id")]
		public long? ThirdCid { get; set; }

		[JsonPropertyName("third_cname")]
		[Description("三级类目名称")]
		public string ThirdCname { get; set; }

		[JsonPropertyName("fourth_cid")]
		[Description("四级类目id")]
		public long? FourthCid { get; set; }

		[JsonPropertyName("fourth_cname")]
		[Description("四级类目名称")]
		public string FourthCname { get; set; }
	}

	[JsonPropertyName("status")]
	[Description("货品状态：1正常 -1停用")]
	[NotNull]
	public int? Status { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码，2023.6.26日后，请默认传空串，平台会全自动推品到订购的所有仓，无需制定具体某一个仓了")]
	[NotNull]
	public string WarehouseCode { get; set; }
}

[Description("erp推送货品数据至字节云仓")]
public class YuncErpCargoSinglePushRsp
{
	[JsonPropertyName("erp_sku_id")]
	[Description("erp的sku_id")]
	public string ErpSkuId { get; set; }

	[JsonPropertyName("cargo_code")]
	[Description("字节平台货品编码")]
	public string CargoCode { get; set; }
}
