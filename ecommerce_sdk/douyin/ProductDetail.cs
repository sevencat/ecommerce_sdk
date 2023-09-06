namespace ecommerce.sdk.douyin;

[Description("使用场景：查询抖店商品详情信息,1、支持使用抖店商品id,2、商品外部开发者自定义编码查询")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","out_product_id未找到或商品已删除","isv.parameter-invalid:4","请检查参数后重试")]
[DouyinRetCode(20000,"系统错误","7:请求失败，请稍后再试","isp.service-error:7","请检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","商品不存在或已彻底删除","isv.parameter-invalid:2010058","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010401:触发商品操作限流,请稍后再试","isv.business-failed:2010401","请稍后再试")]
[DouyinRetCode(20000,"系统错误","2010001:系统异常,请重试","isp.service-error:2010001","请稍后再试")]
[DouyinRetCode(20000,"系统错误","2010327:销售属性查询失败","isp.service-error:2010327","请稍后再试")]
[DouyinRetCode(20000,"系统错误","2010013:数据查询异常","isp.service-error:2010013","请稍后再试")]
[DouyinRetCode(20000,"系统错误","2010321:类目属性查询异常","isp.service-error:2010321","请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","2010004:商品参数错误","isv.business-failed:2010004","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010203:获取商品信息失败","isv.business-failed:2010203","请检查参数后重试")]
public class ProductDetailReq : IDouyinReq<ProductDetailRsp>
{

	public string GetMethod() { return "product.detail"; }

	public string GetUrl() { return "/product/detail"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID，抖店系统生成，店铺下唯一；长度19位")]
	public string ProductId { get; set; }

	[JsonPropertyName("out_product_id")]
	[Description("外部商家编码，商家自定义字段")]
	public string OutProductId { get; set; }

	[JsonPropertyName("show_draft")]
	[Description("true：读取草稿数据；false：读取线上数据；不传默认为false")]
	public string ShowDraft { get; set; }
}

[Description("使用场景：查询抖店商品详情信息,1、支持使用抖店商品id,2、商品外部开发者自定义编码查询")]
public class ProductDetailRsp
{
	[JsonPropertyName("product_id")]
	[Description("商品ID，抖店系统生成，店铺下唯一；长度19位。")]
	public long ProductId { get; set; }

	[JsonPropertyName("product_id_str")]
	[Description("商品ID（字符串类型），抖店系统生成，店铺下唯一；长度19位。")]
	public string ProductIdStr { get; set; }

	[JsonPropertyName("out_product_id")]
	[Description("【即将废弃】外部商家编码，商家自定义字段。推荐使用，outer_product_id字段")]
	public long OutProductId { get; set; }

	[JsonPropertyName("outer_product_id")]
	[Description("外部商家编码，商家自定义字段，支持最多 255个字符")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("open_user_id")]
	[Description("【已废弃】open应用id")]
	public long OpenUserId { get; set; }

	[JsonPropertyName("name")]
	[Description("商品标题，规则：至少输入8个字（16个字符）以上~输入30个字（60个字符）以内。；标题不规范会引起商品下架，影响您的正常销售，详见商品发布规范：https://school.jinritemai.com/doudian/web/article/101800?from=shop_article")]
	public string Name { get; set; }

	[JsonPropertyName("description")]
	[Description("商品详情，最大支持50张图片，单张详情图宽高比不超2000*2000px，大小5M内，仅支持jpg/jpeg/png格式，返回HTML格式；注意：商品详情不规范，会引起商品下架，影响您的正常销售：https://school.jinritemai.com/doudian/web/article/101800?from=shop_article")]
	public string Description { get; set; }

	[JsonPropertyName("delivery_method")]
	[Description("承诺发货时间，单位是天; 不传则默认为2天，当presell_type为0或2均只支持传入2；当presell_type为1时支持可选值为: 2、3、5、7、10、15；")]
	public int DeliveryMethod { get; set; }

	[JsonPropertyName("cdf_category")]
	[Description("海南免税，海关限购分类编码，仅海淘商品有值返回。")]
	public string CdfCategory { get; set; }

	[JsonPropertyName("status")]
	[Description("商品在店铺中状态: 0-在线；1-下线；2-删除；详见商品状态机：https://op.jinritemai.com/docs/question-docs/92/2070")]
	public long Status { get; set; }

	[JsonPropertyName("spec_id")]
	[Description("商品规格，新增商品是全局唯一，注意：有部分历史存量商品可能存在规格复用")]
	public long SpecId { get; set; }

	[JsonPropertyName("check_status")]
	[Description("商品审核状态: 1-未提交；2-待审核；3-审核通过；4-审核未通过；5-封禁；7-审核通过待上架；详见商品状态机：https://op.jinritemai.com/docs/question-docs/92/2070")]
	public long CheckStatus { get; set; }

	[JsonPropertyName("mobile")]
	[Description("【已废弃】手机号")]
	public string Mobile { get; set; }

	[JsonPropertyName("brand_id")]
	[Description("【已废弃】品牌id，推荐使用standard_brand_id字段，通过【/brand/list】获取，无品牌id商品返回默认值：596120136；")]
	public long BrandId { get; set; }

	[JsonPropertyName("is_sub_product")]
	[Description("是否是组合商品的子商品；true-是，false-不是；")]
	public bool IsSubProduct { get; set; }

	[JsonPropertyName("draft_status")]
	[Description("草稿状态；0-无草稿,1-未提审,2-待审核,3-审核通过,4-审核未通过。详见：https://op.jinritemai.com/docs/question-docs/92/2070")]
	public long DraftStatus { get; set; }

	[JsonPropertyName("category_detail")]
	[Description("类目详情；商品类目id可使用【/shop/getShopCategory】查询")]
	public CategoryDetailItem CategoryDetail { get; set; }

	public class CategoryDetailItem
	{
		[JsonPropertyName("first_cid")]
		[Description("一级类目id")]
		public long FirstCid { get; set; }

		[JsonPropertyName("second_cid")]
		[Description("二级类目id")]
		public long SecondCid { get; set; }

		[JsonPropertyName("third_cid")]
		[Description("三级类目id")]
		public long ThirdCid { get; set; }

		[JsonPropertyName("fourth_cid")]
		[Description("四级类目id")]
		public long FourthCid { get; set; }

		[JsonPropertyName("first_cname")]
		[Description("一级类目名")]
		public string FirstCname { get; set; }

		[JsonPropertyName("second_cname")]
		[Description("二级类目名")]
		public string SecondCname { get; set; }

		[JsonPropertyName("third_cname")]
		[Description("三级类目名")]
		public string ThirdCname { get; set; }

		[JsonPropertyName("fourth_cname")]
		[Description("四级类目名")]
		public string FourthCname { get; set; }
	}

	[JsonPropertyName("pay_type")]
	[Description("【已废弃】支持的支付方式：0货到付款 1在线支付 2两者都支持")]
	public long PayType { get; set; }

	[JsonPropertyName("recommend_remark")]
	[Description("【已废弃】商家推荐语")]
	public string RecommendRemark { get; set; }

	[JsonPropertyName("extra")]
	[Description("额外信息，如资质")]
	public string Extra { get; set; }

	[JsonPropertyName("is_create")]
	[Description("【已废弃】无业务意义")]
	public long IsCreate { get; set; }

	[JsonPropertyName("create_time")]
	[Description("商品创建时间，时间格式：yyyy-mm-dd hh:mm:ss")]
	public string CreateTime { get; set; }

	[JsonPropertyName("update_time")]
	[Description("商品更新时间，时间格式：yyyy-mm-dd hh:mm:ss")]
	public string UpdateTime { get; set; }

	[JsonPropertyName("pic")]
	[Description("商品主图；最多支持5张图片；仅支持png，jpg，jpeg格式，宽高比例为1:1（至少600*600px），大小5M内")]
	public List<string> Pic { get; set; }

	[JsonPropertyName("product_format")]
	[Description("【即将废弃】推荐使用product_format_new；属性名称|属性值 之间用|分隔, 多组之间用^分开")]
	public string ProductFormat { get; set; }

	[JsonPropertyName("spec_pics")]
	[Description("规格图片")]
	public List<SpecPicsItem> SpecPics { get; set; }

	public class SpecPicsItem
	{
		[JsonPropertyName("spec_detail_id")]
		[Description("id")]
		public long SpecDetailId { get; set; }

		[JsonPropertyName("pic")]
		[Description("规格图片uri")]
		public string Pic { get; set; }
	}

	[JsonPropertyName("spec_prices")]
	[Description("商品sku详情")]
	public List<SpecPricesItem> SpecPrices { get; set; }

	public class SpecPricesItem
	{
		[JsonPropertyName("sku_classification_type")]
		[Description("sku分类信息")]
		public string SkuClassificationType { get; set; }

		[JsonPropertyName("sell_properties")]
		[Description("sku对应的销售属性信息")]
		public List<SellPropertiesItem> SellProperties { get; set; }

		public class SellPropertiesItem
		{
			[JsonPropertyName("value_spec_detail_id")]
			[Description("规格值id")]
			public long ValueSpecDetailId { get; set; }

			[JsonPropertyName("remark")]
			[Description("备注")]
			public string Remark { get; set; }

			[JsonPropertyName("value_name")]
			[Description("规格值名称")]
			public string ValueName { get; set; }

			[JsonPropertyName("value_id")]
			[Description("销售属性值id，只有在规格由属性库下发时，这个才有值。 默认为0")]
			public long ValueId { get; set; }

			[JsonPropertyName("property_name")]
			[Description("规格项名称")]
			public string PropertyName { get; set; }

			[JsonPropertyName("perperty_id")]
			[Description("销售属性id，只有在规格由属性库下发时，这个字段才有值。 默认为0")]
			public long PerpertyId { get; set; }
		}

		[JsonPropertyName("cargo_info")]
		[Description("货品信息（国内）")]
		public CargoInfoItem CargoInfo { get; set; }

		public class CargoInfoItem
		{
			[JsonPropertyName("source_type")]
			[Description("货品类型，1-分销货品，2-云仓自流转货品，6-云仓非自流转货品")]
			public long SourceType { get; set; }

			[JsonPropertyName("cargo_id")]
			[Description("货品id")]
			public string CargoId { get; set; }
		}

		[JsonPropertyName("gold_process_charge")]
		[Description("Sku的黄金加工费，单位：分")]
		public long GoldProcessCharge { get; set; }

		[JsonPropertyName("sku_id")]
		[Description("规格id；抖店系统生成，商品id下唯一。")]
		public long SkuId { get; set; }

		[JsonPropertyName("out_sku_id")]
		[Description("外部商家skui_id编码，商家自定义字段；推荐使用outer_sku_id字段")]
		public long OutSkuId { get; set; }

		[JsonPropertyName("outer_sku_id")]
		[Description("外部商家skui_id编码，商家自定义字段")]
		public string OuterSkuId { get; set; }

		[JsonPropertyName("spec_detail_ids")]
		[Description("规格id列表,多规格以”,“分隔；")]
		public List<long> SpecDetailIds { get; set; }

		[JsonPropertyName("stock_num")]
		[Description("可售库存；当前现货可售库存；")]
		public long StockNum { get; set; }

		[JsonPropertyName("price")]
		[Description("商品价格；单位：分")]
		public long Price { get; set; }

		[JsonPropertyName("code")]
		[Description("编码")]
		public string Code { get; set; }

		[JsonPropertyName("step_stock_num")]
		[Description("阶梯库存，规则详见名称解释：https://op.jinritemai.com/docs/guide-docs/202/170")]
		public long StepStockNum { get; set; }

		[JsonPropertyName("prom_stock_num")]
		[Description("活动库存，，规则详见名称解释：https://op.jinritemai.com/docs/guide-docs/202/170")]
		public long PromStockNum { get; set; }

		[JsonPropertyName("prom_step_stock_num")]
		[Description("活动阶梯库存，，规则详见名称解释：https://op.jinritemai.com/docs/guide-docs/202/170")]
		public long PromStepStockNum { get; set; }

		[JsonPropertyName("spec_detail_id1")]
		[Description("【已废弃，无需使用】规格ID")]
		public long SpecDetailId1 { get; set; }

		[JsonPropertyName("spec_detail_id2")]
		[Description("【已废弃，无需使用】规格ID")]
		public long SpecDetailId2 { get; set; }

		[JsonPropertyName("spec_detail_id3")]
		[Description("【已废弃，无需使用】规格ID")]
		public long SpecDetailId3 { get; set; }

		[JsonPropertyName("sku_type")]
		[Description("sku类型；0-普通库存  1-区域库存  10-阶梯库存")]
		public long SkuType { get; set; }

		[JsonPropertyName("supplier_id")]
		[Description("供应商编码")]
		public string SupplierId { get; set; }

		[JsonPropertyName("promotion_stock_num")]
		[Description("活动现货库存")]
		public long PromotionStockNum { get; set; }

		[JsonPropertyName("promotion_step_stock_num")]
		[Description("活动阶梯库存")]
		public long PromotionStepStockNum { get; set; }

		[JsonPropertyName("customs_report_info")]
		[Description("海关申报要素（仅海淘商品返回信息）")]
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

		[JsonPropertyName("lock_stock_num")]
		[Description("现货订单锁定库存")]
		public long LockStockNum { get; set; }

		[JsonPropertyName("lock_step_stock_num")]
		[Description("阶梯订单锁定库存")]
		public long LockStepStockNum { get; set; }

		[JsonPropertyName("stock_num_map")]
		[Description("仓ID->库存映射")]
		public Dictionary<string,long> StockNumMap { get; set; }

		[JsonPropertyName("tax_exemption_sku_info")]
		[Description("海南免税sku信息（仅海淘商品返回信息）")]
		public TaxExemptionSkuInfoItem TaxExemptionSkuInfo { get; set; }

		public class TaxExemptionSkuInfoItem
		{
			[JsonPropertyName("is_suit")]
			[Description("是否套装（0 否 1 是）")]
			public int IsSuit { get; set; }

			[JsonPropertyName("suit_num")]
			[Description("套装数量")]
			public long SuitNum { get; set; }

			[JsonPropertyName("volume")]
			[Description("净含量")]
			public long Volume { get; set; }
		}

		[JsonPropertyName("presell_delay")]
		[Description("发货时间（全款预售模式时的发货时间/阶梯模式下阶梯发货时间），9999是当日发、1次日发、2 是48小时发、5、15、45天等。发货时间规则可使用【product/getProductUpdateRule】获取")]
		public long PresellDelay { get; set; }

		[JsonPropertyName("delivery_infos")]
		[Description("SKU物流信息")]
		public List<DeliveryInfosItem> DeliveryInfos { get; set; }

		public class DeliveryInfosItem
		{
			[JsonPropertyName("info_type")]
			[Description("信息类型")]
			public string InfoType { get; set; }

			[JsonPropertyName("info_value")]
			[Description("信息值")]
			public string InfoValue { get; set; }

			[JsonPropertyName("info_unit")]
			[Description("信息计量单位")]
			public string InfoUnit { get; set; }
		}
	}

	[JsonPropertyName("specs")]
	[Description("规格信息，规格项和规格值")]
	public List<SpecsItem> Specs { get; set; }

	public class SpecsItem
	{
		[JsonPropertyName("property_id")]
		[Description("标准销售属性id")]
		public long PropertyId { get; set; }

		[JsonPropertyName("id")]
		[Description("【无需使用】规格模版id")]
		public long Id { get; set; }

		[JsonPropertyName("spec_id")]
		[Description("【无需使用】规格id")]
		public long SpecId { get; set; }

		[JsonPropertyName("name")]
		[Description("销售属性")]
		public string Name { get; set; }

		[JsonPropertyName("pid")]
		[Description("【无需使用】规格父id")]
		public long Pid { get; set; }

		[JsonPropertyName("is_leaf")]
		[Description("是否是销售属性值")]
		public short IsLeaf { get; set; }

		[JsonPropertyName("values")]
		[Description("销售属性值")]
		public List<ValuesItem> Values { get; set; }

		public class ValuesItem
		{
			[JsonPropertyName("value_id")]
			[Description("标准销售属性值id")]
			public string ValueId { get; set; }

			[JsonPropertyName("extra")]
			[Description("其他扩展信息：,包括度量衡信息等")]
			public ExtraItem Extra { get; set; }

			public class ExtraItem
			{
				[JsonPropertyName("measure_info")]
				[Description("度量衡结构化信息")]
				public MeasureInfoItem MeasureInfo { get; set; }

				public class MeasureInfoItem
				{
					[JsonPropertyName("values")]
					[Description("度量衡模块")]
					public List<ValuesItem> Values { get; set; }

					public class ValuesItem
					{
						[JsonPropertyName("value")]
						[Description("度量衡值")]
						public string Value { get; set; }

						[JsonPropertyName("unit_name")]
						[Description("度量衡单位名称")]
						public string UnitName { get; set; }

						[JsonPropertyName("unit_id")]
						[Description("度量衡单位id")]
						public long UnitId { get; set; }

						[JsonPropertyName("suffix")]
						[Description("度量衡后缀")]
						public string Suffix { get; set; }

						[JsonPropertyName("prefix")]
						[Description("度量衡前缀")]
						public string Prefix { get; set; }

						[JsonPropertyName("module_id")]
						[Description("度量衡模块id")]
						public long ModuleId { get; set; }
					}

					[JsonPropertyName("template_id")]
					[Description("度量衡模版id")]
					public long TemplateId { get; set; }
				}

				[JsonPropertyName("cpv_path")]
				[Description("导航路径信息")]
				public List<CpvPathItem> CpvPath { get; set; }

				public class CpvPathItem
				{
					[JsonPropertyName("cpvid")]
					[Description("导航属性值id")]
					public long Cpvid { get; set; }

					[JsonPropertyName("cpid")]
					[Description("导航属性id")]
					public long Cpid { get; set; }
				}
			}

			[JsonPropertyName("id")]
			[Description("规格值id")]
			public long Id { get; set; }

			[JsonPropertyName("spec_id")]
			[Description("规格ID")]
			public long SpecId { get; set; }

			[JsonPropertyName("name")]
			[Description("销售属性值")]
			public string Name { get; set; }

			[JsonPropertyName("pid")]
			[Description("规格值父id")]
			public long Pid { get; set; }

			[JsonPropertyName("is_leaf")]
			[Description("是否是销售属性值")]
			public short IsLeaf { get; set; }

			[JsonPropertyName("status")]
			[Description("在线状态，-2彻底删除、0在线、1下线、2删除")]
			public short Status { get; set; }
		}
	}

	[JsonPropertyName("img")]
	[Description("头图，主图第一张")]
	public string Img { get; set; }

	[JsonPropertyName("presell_type")]
	[Description("预售类型，1-全款预售，0-非预售，2-阶梯库存")]
	public long PresellType { get; set; }

	[JsonPropertyName("maximum_per_order")]
	[Description("单用户下单限购件数")]
	public long MaximumPerOrder { get; set; }

	[JsonPropertyName("limit_per_buyer")]
	[Description("单用户累计限购件数")]
	public long LimitPerBuyer { get; set; }

	[JsonPropertyName("minimum_per_order")]
	[Description("用户每次下单至少购买的件数")]
	public long MinimumPerOrder { get; set; }

	[JsonPropertyName("quality_list")]
	[Description("资质信息")]
	public List<QualityListItem> QualityList { get; set; }

	public class QualityListItem
	{
		[JsonPropertyName("quality_key")]
		[Description("资质key")]
		public string QualityKey { get; set; }

		[JsonPropertyName("quality_name")]
		[Description("资质名称")]
		public string QualityName { get; set; }

		[JsonPropertyName("quality_attachments")]
		[Description("资质链接")]
		public List<QualityAttachmentsItem> QualityAttachments { get; set; }

		public class QualityAttachmentsItem
		{
			[JsonPropertyName("media_type")]
			[Description("1-图片，2-pdf")]
			public long MediaType { get; set; }

			[JsonPropertyName("url")]
			[Description("资质url")]
			public string Url { get; set; }
		}
	}

	[JsonPropertyName("logistics_info")]
	[Description("跨境物流信息（仅海淘商品返回）")]
	public LogisticsInfoItem LogisticsInfo { get; set; }

	public class LogisticsInfoItem
	{
		[JsonPropertyName("customs_clear_type")]
		[Description("通关模式，1BBC 2BC 3邮关")]
		public long CustomsClearType { get; set; }

		[JsonPropertyName("origin_country_id")]
		[Description("原产国id")]
		public long OriginCountryId { get; set; }

		[JsonPropertyName("source_country_id")]
		[Description("货源国id")]
		public long SourceCountryId { get; set; }

		[JsonPropertyName("brand_country_id")]
		[Description("品牌所在地id")]
		public long BrandCountryId { get; set; }

		[JsonPropertyName("tax_payer")]
		[Description("税金承担方，0商家承担，1用户承担")]
		public long TaxPayer { get; set; }

		[JsonPropertyName("net_weight_qty")]
		[Description("商品净重")]
		public decimal NetWeightQty { get; set; }
	}

	[JsonPropertyName("after_sale_service")]
	[Description("售后服务")]
	public string AfterSaleService { get; set; }

	[JsonPropertyName("price_has_tax")]
	[Description("商品价格是否含税")]
	public long PriceHasTax { get; set; }

	[JsonPropertyName("appoint_delivery_day")]
	[Description("可预约发货天数")]
	public long AppointDeliveryDay { get; set; }

	[JsonPropertyName("product_format_new")]
	[Description("类目属性")]
	public string ProductFormatNew { get; set; }

	[JsonPropertyName("standard_brand_id")]
	[Description("品牌库brand id，原brand_id代表商标关系id")]
	public long StandardBrandId { get; set; }

	[JsonPropertyName("market_price")]
	[Description("划线价 单位分")]
	public long MarketPrice { get; set; }

	[JsonPropertyName("discount_price")]
	[Description("售卖价 单位分")]
	public long DiscountPrice { get; set; }

	[JsonPropertyName("car_vin_code")]
	[Description("汽车vin码")]
	public string CarVinCode { get; set; }

	[JsonPropertyName("need_recharge_mode")]
	[Description("生活娱乐充值模式")]
	public bool NeedRechargeMode { get; set; }

	[JsonPropertyName("account_template_id")]
	[Description("多账号充值账号模板")]
	public string AccountTemplateId { get; set; }

	[JsonPropertyName("presell_config_level")]
	[Description("发货模式：presell_type = 0 现货；presell_type = 2 阶梯；presell_type = 1 && presell_config_level = 0 全款预售；presell_type = 1 && presell_config_level = 1 sku预售；presell_type = 1 && presell_config_level = 2 现货+预售；presell_type = 1 && presell_config_level = 3 新预售")]
	public long PresellConfigLevel { get; set; }

	[JsonPropertyName("delivery_delay_day")]
	[Description("现货模式的发货天数；阶梯模式现货部分的发货天数，9999=当日发、1=次日发")]
	public long DeliveryDelayDay { get; set; }

	[JsonPropertyName("presell_delay")]
	[Description("阶梯模式阶梯部分的发货天数；商品全款预售模式，预售天数")]
	public long PresellDelay { get; set; }

	[JsonPropertyName("poi_resource")]
	[Description("卡券信息")]
	public PoiResourceItem PoiResource { get; set; }

	public class PoiResourceItem
	{
		[JsonPropertyName("coupon_return_methods")]
		[Description("1 随时退+过期自动退，2 不支持退")]
		public List<long> CouponReturnMethods { get; set; }
	}

	[JsonPropertyName("delay_rule")]
	[Description("特殊日期延迟发货规则")]
	public DelayRuleItem DelayRule { get; set; }

	public class DelayRuleItem
	{
		[JsonPropertyName("enable")]
		[Description("是否开启特殊日期延迟发货")]
		public bool Enable { get; set; }

		[JsonPropertyName("config_type")]
		[Description("1 时间点；2 时间范围")]
		public int ConfigType { get; set; }

		[JsonPropertyName("config_value")]
		[Description("特殊日期延迟发货时间最晚发货时间，时间戳，单位秒")]
		public long ConfigValue { get; set; }

		[JsonPropertyName("start_time")]
		[Description("特殊日期延迟发货时间下单开始时间，时间戳，单位秒")]
		public long StartTime { get; set; }

		[JsonPropertyName("end_time")]
		[Description("特殊日期延迟发货时间下单结束时间，时间戳，单位秒")]
		public long EndTime { get; set; }
	}

	[JsonPropertyName("long_pic_url")]
	[Description("3:4长图url(仅素材中心url有效)")]
	public string LongPicUrl { get; set; }

	[JsonPropertyName("sell_channel")]
	[Description("售卖方式;0:全渠道手售卖,1:仅指定直播间售卖")]
	public List<long> SellChannel { get; set; }

	[JsonPropertyName("freight_id")]
	[Description("运费模版ID")]
	public long FreightId { get; set; }

	[JsonPropertyName("material_video_id")]
	[Description("主图视频ID")]
	public string MaterialVideoId { get; set; }

	[JsonPropertyName("pickup_method")]
	[Description("提取方式新字段，推荐使用。0: 普通商品-使用物流发货, 1: 虚拟商品-无需物流与电子交易凭证, 2: 虚拟商品-使用电子交易凭证,  3: 虚拟商品-充值直连")]
	public string PickupMethod { get; set; }

	[JsonPropertyName("size_info_template_id")]
	[Description("尺码模板ID")]
	public long SizeInfoTemplateId { get; set; }

	[JsonPropertyName("white_back_ground_pic_url")]
	[Description("白底图url(仅素材中心url有效)")]
	public string WhiteBackGroundPicUrl { get; set; }

	[JsonPropertyName("sale_channel_type")]
	[Description("销售渠道类型，包括纯电商（onlineOnly）、专柜同款（sameAsOffline），云零售商家（https://fxg.jinritemai.com/ffa/merchant-growth/cloud-retail）可以设置")]
	public string SaleChannelType { get; set; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	public long StoreId { get; set; }

	[JsonPropertyName("main_product_id")]
	[Description("主商品ID")]
	public long MainProductId { get; set; }

	[JsonPropertyName("sale_limit_id")]
	[Description("限售模板ID")]
	public long SaleLimitId { get; set; }

	[JsonPropertyName("name_prefix")]
	[Description("系统推荐的标题前缀")]
	public string NamePrefix { get; set; }

	[JsonPropertyName("product_type")]
	[Description("商品类型，0-普通，3-虚拟，6玉石闪购，7云闪购")]
	public long ProductType { get; set; }

	[JsonPropertyName("presell_delivery_type")]
	[Description("预售发货方式配置 0-预售结束后xx天发货; 1-支付完成后xx天发货")]
	public long PresellDeliveryType { get; set; }

	[JsonPropertyName("start_sale_type")]
	[Description("审核通过后上架售卖时间配置：0-立即上架售卖 1-放入仓库")]
	public long StartSaleType { get; set; }

	[JsonPropertyName("reduce_type")]
	[Description("库存扣减方式，1-拍下减库存 2-付款减库存")]
	public long ReduceType { get; set; }

	[JsonPropertyName("presell_end_time")]
	[Description("预售结束时间，格式2020-02-21 18:54:27，最多支持设置距离当前30天")]
	public string PresellEndTime { get; set; }

	[JsonPropertyName("weight_value")]
	[Description("重量数值")]
	public decimal WeightValue { get; set; }

	[JsonPropertyName("weight_unit")]
	[Description("重量单位，0-kg, 1-g")]
	public long WeightUnit { get; set; }

	[JsonPropertyName("reference_price_certificate")]
	[Description("参考价凭证")]
	public ReferencePriceCertificateItem ReferencePriceCertificate { get; set; }

	public class ReferencePriceCertificateItem
	{
		[JsonPropertyName("certificate_type")]
		[Description("凭证类型;1:厂商建议零售价,2:吊牌价,3:定价,4:官网零售售价")]
		public string CertificateType { get; set; }

		[JsonPropertyName("certificate_urls")]
		[Description("凭证图片url")]
		public string CertificateUrls { get; set; }
	}

	[JsonPropertyName("reference_price")]
	[Description("参考价，单位分")]
	public long ReferencePrice { get; set; }

	[JsonPropertyName("quality_inspection_info")]
	[Description("前置质检相关（特定二手商家、特定二手类目使用）")]
	public QualityInspectionInfoItem QualityInspectionInfo { get; set; }

	public class QualityInspectionInfoItem
	{
		[JsonPropertyName("mode")]
		[Description("1: 单库存模式，只允许售卖一个sku；2: 多库存模式，不限售卖次数")]
		public int Mode { get; set; }

		[JsonPropertyName("certificate_code")]
		[Description("质检证书编码")]
		public string CertificateCode { get; set; }

		[JsonPropertyName("agency")]
		[Description("机构编码")]
		public string Agency { get; set; }

		[JsonPropertyName("supported")]
		[Description("是否勾选支持前置质检")]
		public bool Supported { get; set; }
	}

	[JsonPropertyName("unit_price_info")]
	[Description("单位价格信息")]
	public UnitPriceInfoItem UnitPriceInfo { get; set; }

	public class UnitPriceInfoItem
	{
		[JsonPropertyName("price_rule_type")]
		[Description("1：投资金单位价格,2：首饰金单位价格")]
		public int PriceRuleType { get; set; }
	}

	[JsonPropertyName("main_image_three_to_four")]
	[Description("历史字段，废弃，请使用新字段main_pic_3_4")]
	public string MainImageThreeToFour { get; set; }

	[JsonPropertyName("is_c2b_switch_on")]
	[Description("是否支持c2b小程序（特定c2b定制商家使用）")]
	public bool IsC2bSwitchOn { get; set; }

	[JsonPropertyName("micro_app_id")]
	[Description("支持c2b定制时的小程序id（特定c2b定制商家使用）")]
	public string MicroAppId { get; set; }

	[JsonPropertyName("is_auto_charge")]
	[Description("是否是自动充值商品")]
	public bool IsAutoCharge { get; set; }

	[JsonPropertyName("spu_id")]
	[Description("spu_id 大于0代表有挂载spu")]
	public long SpuId { get; set; }

	[JsonPropertyName("short_product_name")]
	[Description("导购短标题，短标题可用于物流打单及商品搜索场景，若未填写，则系统将智能生成最优短标题在商详购买页面展示，说明详见：https://school.jinritemai.com/doudian/web/article/aHUW2MCvHqF3?from=shop_article")]
	public string ShortProductName { get; set; }

	[JsonPropertyName("after_sale_service_v2")]
	[Description("售后服务新结构")]
	public AfterSaleServiceV2Item AfterSaleServiceV2 { get; set; }

	public class AfterSaleServiceV2Item
	{
		[JsonPropertyName("is_large_product")]
		[Description("当前商品是否是大件商品 1-是")]
		public long IsLargeProduct { get; set; }
	}

	[JsonPropertyName("format_update_time")]
	[Description("更新时间，和update_time一样，只是格式不同")]
	public string FormatUpdateTime { get; set; }

	[JsonPropertyName("sell_num")]
	[Description("商品销量")]
	public long SellNum { get; set; }

	[JsonPropertyName("product_audit_info")]
	[Description("商品审核结果")]
	public ProductAuditInfoItem ProductAuditInfo { get; set; }

	public class ProductAuditInfoItem
	{
		[JsonPropertyName("material_audit_reason")]
		[Description("素材相关审核结果")]
		public List<MaterialAuditReasonItem> MaterialAuditReason { get; set; }

		public class MaterialAuditReasonItem
		{
			[JsonPropertyName("material_type")]
			[Description("0-主图视频、1-白底图、4-长图、17-测评视频")]
			public string MaterialType { get; set; }

			[JsonPropertyName("reasons")]
			[Description("素材类型对应的驳回原因")]
			public List<string> Reasons { get; set; }
		}
	}

	[JsonPropertyName("main_pic_3_4")]
	[Description("商品主图3:4；最多支持5张图片；宽高比例为3:4")]
	public List<string> MainPic34 { get; set; }

	[JsonPropertyName("shop_category")]
	[Description("店铺装修分类")]
	public ShopCategoryItem ShopCategory { get; set; }

	public class ShopCategoryItem
	{
		[JsonPropertyName("leaf_category_ids")]
		[Description("店铺装修分类叶子类目id")]
		public string LeafCategoryIds { get; set; }
	}
}
