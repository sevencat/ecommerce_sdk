namespace ecommerce.sdk.douyin;

[Description("新增跨境/海南商品")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","商品创建失败：图片上传错误","isv.parameter-invalid:99","建议接入素材中心")]
[DouyinRetCode(20000,"系统错误","商品创建失败: 系统错误","isp.service-error:2010001","重试")]
[DouyinRetCode(20000,"系统错误","商品创建失败: 请求超时","isp.service-error:2010002","重试")]
[DouyinRetCode(40002,"缺少必选参数","商品创建失败: 缺少参数","isv.missing-parameter:2010003","请重新进入页面进行补充")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 非法参数","isv.parameter-invalid:2010004","输入正确参数")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 无访问权限","isv.parameter-invalid:2010005","输入正确参数")]
[DouyinRetCode(50002,"业务处理失败","商品创建失败: 新建商品失败","isv.business-failed:2010011","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","商品创建失败: 读取失败","isv.business-failed:2010013","检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 资质类属性必填拒绝","isv.parameter-invalid:2010020","输入正确参数")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 商品状态错误","isv.parameter-invalid:2010022","输入正确参数")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 类目校验","isv.parameter-invalid:2010044","请重新选择类目进行商品发布")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 店铺需要绑定","isv.parameter-invalid:2010050","完成账号绑定")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 类目相关信息过期","isv.parameter-invalid:2010053","待资质审核通过后再提交")]
[DouyinRetCode(40002,"缺少必选参数","商品创建失败: 资质不合法","isv.missing-parameter:2010101","请上传版权页图")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 品牌不合法","isv.parameter-invalid:2010104","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","商品创建失败: 获取类目信息失败","isv.business-failed:2010201","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","商品创建失败: 调用成功，但填充返回数据时失败,无影响","isv.business-failed:2010204","无影响，可忽略")]
[DouyinRetCode(20000,"系统错误","商品创建失败: 查询品牌库失败","isp.service-error:2010206","重试")]
[DouyinRetCode(20000,"系统错误","商品创建失败: 查询商家资质失败","isp.service-error:2010207","重试")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 必须支持7天无理由退货","isv.parameter-invalid:2010316","检查参数后重试")]
[DouyinRetCode(40002,"缺少必选参数","商品创建失败: 品牌受限","isv.missing-parameter:2010317","补充参数")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 使用的品牌没有授权","isv.parameter-invalid:2010319","检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 品牌必填","isv.parameter-invalid:2010320","检查参数后重试")]
[DouyinRetCode(40002,"缺少必选参数","商品创建失败: 缺少属性","isv.missing-parameter:2010321","重新进入页面补充")]
[DouyinRetCode(40004,"非法的参数","商品创建失败: 发布诊断失败","isv.parameter-invalid:2010501","补充参数")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:4","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:7","检查参数后重试")]
[DouyinRetCode(20000,"系统错误","商品创建失败：接口限流","isp.service-error:2010055","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","商品创建失败: 因为店铺受到处罚，限制发品，更多请到商家后台奖惩中心查看","isv.business-failed:2010326","检查店铺状态后重试")]
[DouyinRetCode(20000,"系统错误","商品创建失败: 获取类目配置失败","isp.service-error:2010202","稍后重试")]
[DouyinRetCode(20000,"系统错误","商品创建失败: 保存素材失败","isp.service-error:2010024","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","2010329:商品创建失败: 当前店铺类型下，不支持在该类目发布此品牌商品。您可查看对应“行业管理规范”的入驻方式。请跳转https://zjsms.com/NE7whg4/","isv.business-failed:2010329","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010061:商品创建失败: 请求权益信息失败","isv.business-failed:2010061","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010063:商品创建失败: 当前店铺在架商品量已达上限，暂无法创建商品，详细规则可查看商品数限额实施细则","isv.business-failed:2010063","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010021:商品创建失败: 更新库存数失败: 幂等ID重复","isv.business-failed:2010021","检查参数后重试")]
public class ProductAddCbProductReq : IDouyinReq<ProductAddCbProductRsp>
{

	public string GetMethod() { return "product.addCbProduct"; }

	public string GetUrl() { return "/product/addCbProduct"; }

	[JsonPropertyName("outer_product_id")]
	[Description("推荐使用，外部商家编码，支持字符串")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("product_type")]
	[Description("0-普通，3-虚拟，6玉石闪购，7云闪购")]
	[NotNull]
	public long? ProductType { get; set; }

	[JsonPropertyName("category_leaf_id")]
	[Description("叶子类目ID通过/shop/getShopCategory接口获取")]
	[NotNull]
	public long? CategoryLeafId { get; set; }

	[JsonPropertyName("product_format")]
	[Description("属性名称|属性值 之间用|分隔, 多组之间用^分开")]
	public string ProductFormat { get; set; }

	[JsonPropertyName("name")]
	[Description("商品名称，最多60个字符(30个汉字)，不能含emoj表情")]
	[NotNull]
	public string Name { get; set; }

	[JsonPropertyName("recommend_remark")]
	[Description("商家推荐语，不能含emoj表情")]
	public string RecommendRemark { get; set; }

	[JsonPropertyName("pic")]
	[Description("商品轮播图，多张图片用 ,|, 分开，第一张图为主图，最多5张，至少600x600，大小不超过1M 注：,pic,、,description,、,spec_pic,这三个字段里的传入的图片数量总和，不得超过50张。")]
	[NotNull]
	public string Pic { get; set; }

	[JsonPropertyName("description")]
	[Description("商品描述，目前只支持图片。多张图片用 ,|, 分开。不能用其他网站的文本粘贴，这样会出现css样式不兼容 注：,pic,、,description,、,spec_pic,这三个字段里的传入的图片数量总和，不得超过50张。")]
	[NotNull]
	public string Description { get; set; }

	[JsonPropertyName("pay_type")]
	[Description("支付方式，0货到付款 1在线支付，2，货到付款+在线支付")]
	[NotNull]
	public long? PayType { get; set; }

	[JsonPropertyName("delivery_method")]
	[Description("海南免税生效。 0:离岛免税、1:邮寄、2:离岛自提+邮寄")]
	public int? DeliveryMethod { get; set; }

	[JsonPropertyName("cdf_category")]
	[Description("海南免税：海关限购分类编码")]
	public string CdfCategory { get; set; }

	[JsonPropertyName("reduce_type")]
	[Description("1 减库存类型：1-拍下减库存 2-付款减库存")]
	[NotNull]
	public long? ReduceType { get; set; }

	[JsonPropertyName("assoc_ids")]
	[Description("同店商品推荐：为空表示使用系统推荐；多个product_id使用“|”分开")]
	public string AssocIds { get; set; }

	[JsonPropertyName("freight_id")]
	[Description("运费模板id，传0表示包邮，通过/freightTemplate/list接口获取")]
	[NotNull]
	public long? FreightId { get; set; }

	[JsonPropertyName("weight")]
	[Description("重量")]
	public decimal? Weight { get; set; }

	[JsonPropertyName("weight_unit")]
	[Description("重量单位，0-kg, 1-g")]
	public long? WeightUnit { get; set; }

	[JsonPropertyName("delivery_delay_day")]
	[Description("delivery_delay_day： 承诺发货时间，单位是天,不传则默认为2天。现货发货(presell_type=0)和阶梯发货模式(presell_type=2)时必填，支持传入9999 、1、 2 （分别表示当日发、次日发、48小时发），具体支持传入的参数范围/product/getProductUpdateRule")]
	public long? DeliveryDelayDay { get; set; }

	[JsonPropertyName("presell_type")]
	[Description("发货模式，0-现货发货，1-预售发货，2-阶梯发货，默认0")]
	public long? PresellType { get; set; }

	[JsonPropertyName("presell_delay")]
	[Description("全款预售模式时的发货时间/阶梯模式下阶梯发货时间，具体支持传入的参数范围/product/getProductUpdateRule")]
	public long? PresellDelay { get; set; }

	[JsonPropertyName("presell_end_time")]
	[Description("预售结束时间，格式2020-02-21 18:54:27，最多支持设置距离当前30天")]
	public string PresellEndTime { get; set; }

	[JsonPropertyName("supply_7day_return")]
	[Description("【该字段将在2023年4月30日下线，请开发使用最新的after_sale_service字段传值；】是否支持7天无理由，0不支持，1支持，2支持（拆封后不支持）")]
	[NotNull]
	public long? Supply7dayReturn { get; set; }

	[JsonPropertyName("mobile")]
	[Description("客服电话号码")]
	[NotNull]
	public string Mobile { get; set; }

	[JsonPropertyName("commit")]
	[Description("false仅保存，true保存+提审")]
	[NotNull]
	public bool? Commit { get; set; }

	[JsonPropertyName("brand_id")]
	[Description("品牌id (请求店铺授权品牌接口获取) (效果即为商品详情页面中的品牌字段)")]
	public long? BrandId { get; set; }

	[JsonPropertyName("remark")]
	[Description("商家可见备注")]
	public string Remark { get; set; }

	[JsonPropertyName("out_product_id")]
	[Description("外部product_id")]
	public long? OutProductId { get; set; }

	[JsonPropertyName("quality_list")]
	[Description("资质，可通过/product/qualificationConfig获取")]
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
		[Description("资质")]
		public List<QualityAttachmentsItem> QualityAttachments { get; set; }

		public class QualityAttachmentsItem
		{
			[JsonPropertyName("media_type")]
			[Description("1-图片，2-pdf")]
			public long? MediaType { get; set; }

			[JsonPropertyName("url")]
			[Description("凭证url")]
			public string Url { get; set; }
		}
	}

	[JsonPropertyName("spec_name")]
	[Description("如果不填，则规格名为各级规格名用 ,-, 自动生成")]
	public string SpecName { get; set; }

	[JsonPropertyName("specs")]
	[Description("店铺通用规格，能被同类商品通用。多规格用^分隔，规格与规格值用|分隔，多个规格值用,分隔。如果创建或编辑现货+预售商品或新预售商品时，须包含发货时效，如：颜色|黑色,白色,黄色^尺码|S,M,L^发货时效|5天内发货,15天内发货")]
	[NotNull]
	public string Specs { get; set; }

	[JsonPropertyName("spec_prices")]
	[Description("sku详情，数量应该等于规格1规格2规格3，sku数量和规格组合数必须一致 sku不可售时，库存可设置为0")]
	[NotNull]
	public string SpecPrices { get; set; }

	[JsonPropertyName("spec_pic")]
	[Description("如颜色-尺寸, 颜色就是主规格, 颜色如黑,白,黄,它们图片url以逗号分隔 注：,pic,、,description,、,spec_pic,这三个字段里的传入的图片数量总和，不得超过50张")]
	public string SpecPic { get; set; }

	[JsonPropertyName("maximum_per_order")]
	[Description("每个用户每次下单限购件数")]
	public long? MaximumPerOrder { get; set; }

	[JsonPropertyName("limit_per_buyer")]
	[Description("每个用户累计限购件数")]
	public long? LimitPerBuyer { get; set; }

	[JsonPropertyName("minimum_per_order")]
	[Description("每个用户每次下单至少购买的件数")]
	public long? MinimumPerOrder { get; set; }

	[JsonPropertyName("product_format_new")]
	[Description("通过/product/getCatePropertyV2获取 格式：{property_id:[{value:value,name:property_name,diy_type:0}]} name的类型是string，value和diy_type的类型是number")]
	public string ProductFormatNew { get; set; }

	[JsonPropertyName("spu_id")]
	[Description("spu_id")]
	public long? SpuId { get; set; }

	[JsonPropertyName("appoint_delivery_day")]
	[Description("可预约发货天数")]
	public long? AppointDeliveryDay { get; set; }

	[JsonPropertyName("third_url")]
	[Description("third_url")]
	public string ThirdUrl { get; set; }

	[JsonPropertyName("extra")]
	[Description("extra")]
	public string Extra { get; set; }

	[JsonPropertyName("src")]
	[Description("src")]
	public string Src { get; set; }

	[JsonPropertyName("need_check_out")]
	[Description("卡券类型需要传true")]
	public bool? NeedCheckOut { get; set; }

	[JsonPropertyName("poi_resource")]
	[Description("卡券信息")]
	public PoiResourceItem PoiResource { get; set; }

	public class PoiResourceItem
	{
		[JsonPropertyName("valid_days")]
		[Description("有效时间段，从领取日开始计算，优先级高于ValidStart-ValidEnd")]
		public long? ValidDays { get; set; }

		[JsonPropertyName("valid_start")]
		[Description("卡券有效开始时间，秒单位时间戳")]
		public long? ValidStart { get; set; }

		[JsonPropertyName("valid_end")]
		[Description("卡券有效截止时间，秒单位时间戳")]
		public long? ValidEnd { get; set; }

		[JsonPropertyName("service_num")]
		[Description("客服电话")]
		public string ServiceNum { get; set; }

		[JsonPropertyName("notification")]
		[Description("领取须知")]
		public string Notification { get; set; }

		[JsonPropertyName("code_type")]
		[Description("平台产生券码: 1 ; 合作方api实时传入的券码: 4")]
		public long? CodeType { get; set; }

		[JsonPropertyName("count")]
		[Description("券码总量，0/-1表示不限制，平台券时须,u003e0")]
		public long? Count { get; set; }

		[JsonPropertyName("couponSecondExchange")]
		[Description("0-不支持二次兑换，1-支持二次兑换")]
		public long? CouponSecondExchange { get; set; }

		[JsonPropertyName("total_can_use_count")]
		[Description("可核销总次数")]
		public int? TotalCanUseCount { get; set; }

		[JsonPropertyName("link")]
		[Description("兑换链接")]
		public string Link { get; set; }

		[JsonPropertyName("condition")]
		[Description("券码使用条件")]
		public string Condition { get; set; }
	}

	[JsonPropertyName("car_vin_code")]
	[Description("汽车vin码")]
	public string CarVinCode { get; set; }

	[JsonPropertyName("need_recharge_mode")]
	[Description("充值模式")]
	public bool? NeedRechargeMode { get; set; }

	[JsonPropertyName("presell_config_level")]
	[Description("0：全款预售，1：sku预售，2：现货+预售 ，3：新预售")]
	public long? PresellConfigLevel { get; set; }

	[JsonPropertyName("account_template_id")]
	[Description("账号模板id")]
	public string AccountTemplateId { get; set; }

	[JsonPropertyName("presell_delivery_type")]
	[Description("全款预售和sku预售时传递，其他不传： 0 预售结束后发货 1支付完成后发货")]
	public long? PresellDeliveryType { get; set; }

	[JsonPropertyName("white_back_ground_pic_url")]
	[Description("白底图url(仅素材中心url有效)")]
	public string WhiteBackGroundPicUrl { get; set; }

	[JsonPropertyName("long_pic_url")]
	[Description("3:4长图url(仅素材中心url有效)")]
	public string LongPicUrl { get; set; }

	[JsonPropertyName("after_sale_service")]
	[Description("售后服务参数,key:value格式 ,supply_7day_return(7天无理由)： 0不支持，1支持，2支持（拆封后不支持） supply_day_return_selector(7天无理由标签)：N天-政策代号，N只支持7和15 supply_red_ass_return（红屁屁无忧）：0不支持，1支持 supply_allergy_return（过敏无忧,仅跨境可选）：0不支持，1支持 damaged_order_return（坏损包退）：0不支持，1支持 support_allergy_returnV2（过敏包退，境内可选）：0不支持，1支持")]
	public Dictionary<string,string> AfterSaleService { get; set; }

	[JsonPropertyName("sell_channel")]
	[Description("售卖方式;0:全渠道售卖,1:仅指定直播间售卖")]
	public List<long> SellChannel { get; set; }

	[JsonPropertyName("start_sale_type")]
	[Description("审核通过后上架售卖时间配置:0-立即上架售卖 1-放入仓库")]
	public long? StartSaleType { get; set; }

	[JsonPropertyName("logistics_info")]
	[Description("{customs_clear_type:4,origin_region_id: 3573511,source_region_id: 3573511,brand_region_id: 174982,net_weight_qty:13.4,tax_payer:0}")]
	public string LogisticsInfo { get; set; }

	[JsonPropertyName("price_has_tax")]
	[Description("商品价格是否含税")]
	public string PriceHasTax { get; set; }

	[JsonPropertyName("biz_kind")]
	[Description("商品是否跨境、教育等（跨境/海南商品填写2））")]
	public long? BizKind { get; set; }

	[JsonPropertyName("standard_brand_id")]
	[Description("standard_brand_id，通过/brand/list获取，无品牌id则传596120136")]
	public long? StandardBrandId { get; set; }

	[JsonPropertyName("discount_price")]
	[Description("售价，单位分，含税价")]
	public long? DiscountPrice { get; set; }

	[JsonPropertyName("market_price")]
	[Description("划线价，单位分，含税价(在spec_prices设置)")]
	public long? MarketPrice { get; set; }

	[JsonPropertyName("size_info_template_id")]
	[Description("尺码表")]
	public long? SizeInfoTemplateId { get; set; }
}

[Description("新增跨境/海南商品")]
public class ProductAddCbProductRsp
{
	[JsonPropertyName("product_id")]
	[Description("product_id")]
	public long ProductId { get; set; }

	[JsonPropertyName("out_product_id")]
	[Description("out_product_id")]
	public long OutProductId { get; set; }

	[JsonPropertyName("outer_product_id")]
	[Description("outer_product_id")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("create_time")]
	[Description("create_time")]
	public string CreateTime { get; set; }

	[JsonPropertyName("sku")]
	[Description("1")]
	public List<SkuItem> Sku { get; set; }

	public class SkuItem
	{
		[JsonPropertyName("sku_id")]
		[Description("1")]
		public long SkuId { get; set; }

		[JsonPropertyName("out_sku_id")]
		[Description("1")]
		public long OutSkuId { get; set; }

		[JsonPropertyName("outer_sku_id")]
		[Description("1")]
		public string OuterSkuId { get; set; }

		[JsonPropertyName("code")]
		[Description("1")]
		public string Code { get; set; }

		[JsonPropertyName("spec_detail_id1")]
		[Description("1")]
		public long SpecDetailId1 { get; set; }

		[JsonPropertyName("spec_detail_id2")]
		[Description("1")]
		public long SpecDetailId2 { get; set; }

		[JsonPropertyName("spec_detail_id3")]
		[Description("1")]
		public long SpecDetailId3 { get; set; }
	}
}
