namespace ecommerce.sdk.douyin;

[Description("编辑商品")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","业务处理失败","isv.parameter-invalid:7","请检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:4","请检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","库存错误","isv.parameter-invalid:-20008","可到营销中心修改对应的营销活动库存，或直接修改当前商品现货库存数")]
[DouyinRetCode(40004,"非法的参数","商品编辑失败：图片上传错误","isv.parameter-invalid:99","建议接入素材中心")]
[DouyinRetCode(20000,"系统错误","加载信息失败","isp.service-error:20011","请检查参数后重试")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2010001","请检查参数后重试")]
[DouyinRetCode(20000,"系统错误","请求超时","isp.service-error:2010002","重试")]
[DouyinRetCode(40002,"缺少必选参数","缺少参数","isv.missing-parameter:2010003","重新进入页面进行补充")]
[DouyinRetCode(40004,"非法的参数","非法参数","isv.parameter-invalid:2010004","请检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","无访问权限","isv.parameter-invalid:2010005","核对后重试")]
[DouyinRetCode(40004,"非法的参数","编辑商品失败","isv.parameter-invalid:2010011","请检查参数后重试")]
[DouyinRetCode(20000,"系统错误","保存商品失败","isp.service-error:2010012","重试")]
[DouyinRetCode(20000,"系统错误","读取失败","isp.service-error:2010013","重试")]
[DouyinRetCode(40004,"非法的参数","资质类属性必填拒绝","isv.parameter-invalid:2010020","重新输入正确编号")]
[DouyinRetCode(50002,"业务处理失败","商品操作重复","isv.business-failed:2010021","请勿重复操作")]
[DouyinRetCode(50002,"业务处理失败","商品状态错误","isv.business-failed:2010022","检查状态后重试")]
[DouyinRetCode(50002,"业务处理失败","该商品在审核中","isv.business-failed:2010041","不允许编辑")]
[DouyinRetCode(50002,"业务处理失败","该商品已删除","isv.business-failed:2010042","不允许编辑")]
[DouyinRetCode(50002,"业务处理失败","该商品已封禁","isv.business-failed:2010043","不允许编辑")]
[DouyinRetCode(40004,"非法的参数","类目校验","isv.parameter-invalid:2010044","请重新选择类目进行商品发布")]
[DouyinRetCode(40004,"非法的参数","商品正在参加活动","isv.parameter-invalid:2010045","暂不支持修改规格")]
[DouyinRetCode(40004,"非法的参数","店铺需要绑定","isv.parameter-invalid:2010050","完成账号绑定")]
[DouyinRetCode(40002,"缺少必选参数","资质不合法","isv.missing-parameter:2010101","请上传包装标签图")]
[DouyinRetCode(40004,"非法的参数","内容未做修改","isv.parameter-invalid:2010102","请修改后提交审核")]
[DouyinRetCode(40004,"非法的参数","品牌不合法","isv.parameter-invalid:2010104","检查参数后重试")]
[DouyinRetCode(20000,"系统错误","获取类目信息失败","isp.service-error:2010201","重试")]
[DouyinRetCode(20000,"系统错误","获取类目配置失败","isp.service-error:2010202","重试")]
[DouyinRetCode(20000,"系统错误","查询品牌库失败","isp.service-error:2010206","重试")]
[DouyinRetCode(20000,"系统错误","查询商家资质失败","isp.service-error:2010207","查询商家资质失败，请重试")]
[DouyinRetCode(40004,"非法的参数","必须支持7天无理由退货","isv.parameter-invalid:2010316","检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","品牌受限","isv.parameter-invalid:2010317","检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","使用的品牌没有授权","isv.parameter-invalid:2010319","检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","品牌必填","isv.parameter-invalid:2010320","请重新选择品牌")]
[DouyinRetCode(40002,"缺少必选参数","缺少属性","isv.missing-parameter:2010321","检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","发布诊断失败","isv.parameter-invalid:2010501","检查参数后重试")]
[DouyinRetCode(60000,"触发限流，请稍后重试","编辑商品失败：接口限流","isp.traffic-limited:2010401","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","2010329:当前店铺类型下，不支持在该类目发布此品牌商品。您可查看对应“行业管理规范”的入驻方式。请跳转https://zjsms.com/NE7whg4/","isv.business-failed:2010329","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010060:商家不支持 假一赔十 权益","isv.business-failed:2010060","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010203:获取商品信息失败","isv.business-failed:2010203","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010326:因为店铺受到处罚，限制发品，更多请到商家后台奖惩中心查看","isv.business-failed:2010326","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010061:请求权益信息失败","isv.business-failed:2010061","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","2147483647:存在审批中素材，请等待审批","isv.business-failed:2147483647","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","2010310:不存在该规格信息","isv.business-failed:2010310","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010053:所选类目经营资质已失效，您可以选择保存草稿，待资质审核通过后再提交","isv.business-failed:2010053","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010063:当前店铺在架商品量已达上限，暂无法创建商品，详细规则可查看商品数限额实施细则","isv.business-failed:2010063","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010055:因服务器升级，商品价格展示可能异常，请修改价格后重试","isv.business-failed:2010055","检查参数后重试")]
[DouyinRetCode(60000,"触发限流，请稍后重试","2010067:更新商品太频繁，操作失败请重试","isp.traffic-limited:2010067","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","2010058:商品不存在","isv.business-failed:2010058","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010340:当前商品使用的品牌未关联当前类目，请切换品牌或者前往商家资质中心补全品牌资质信息，之后再上架商品。","isv.business-failed:2010340","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010015:该商品为竞拍商品，不支持变更","isv.business-failed:2010015","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010348:门店未绑定绑定限售模板","isv.business-failed:2010348","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010347:门店未绑定运费模板","isv.business-failed:2010347","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010107:当前价格或商品起购件数不符合平台要求","isv.business-failed:2010107","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010341:阶梯库存模式不合法","isv.business-failed:2010341","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010352:商品存在预定的下架时间, 暂不支持在预定下架时间到达前编辑, 预定下架时间: 2023-01-04 23:59:59","isv.business-failed:2010352","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010999:系统错误，请重试","isv.business-failed:2010999","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010109:当前类目未开通主图3：4上传功能，请删除主图3：4","isv.business-failed:2010109","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010339:[存在审批中素材，请等待审批]","isv.business-failed:2010339","请等待审批")]
[DouyinRetCode(50002,"业务处理失败","110111009:[商品存在预定的下架时间, 暂不支持在预定下架时间到达前编辑, 预定下架时间: 2023-03-01 19:59:59]","isv.business-failed:110111009","请等待下架时间")]
[DouyinRetCode(50002,"业务处理失败","110107003:当前价格或商品起购件数不符合平台要求","isv.business-failed:110107003","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110101049:前缀不匹配","isv.business-failed:110101049","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110330002:该类目不支持该类型售后7无标签","isv.business-failed:110330002","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110310010:当前商品正在参与活动 抖音618好物节商品报名，商品sku价格不得低于活动到手价格￥120.00元，请修改后重新提交。","isv.business-failed:110310010","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110260002:您为榴莲定向分销商，必须通过分销平台采购榴莲货源，请绑定分销货品","isv.business-failed:110260002","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110250008:尺码模板不支持当前类目","isv.business-failed:110250008","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110126002:当前商品设置达人库存，暂不支持修改规格","isv.business-failed:110126002","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110260016:该商品未绑定备案","isv.business-failed:110260016","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110014001:系统繁忙，请稍后再试","isv.business-failed:110014001","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110280003:当前价格或商品起购件数不符合平台要求","isv.business-failed:110280003","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110102009:商品存在预定的下架时间, 暂不支持在预定下架时间到达前编辑, 预定下架时间: 2023-05-29 12:00:00","isv.business-failed:110102009","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110215002:类目属性[?️]中含有emoji等特殊字符，请检查后重试","isv.business-failed:110215002","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110230002:当前商品大于三级规格，请使用sell_properties参数","isv.business-failed:110230002","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110220012：至少包含一个主售款sku","isv.business-failed:110220012","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110220013：SKU分类值填写错误，请使用正确分类","isv.business-failed:110220013","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","110220014:当前类目/店铺不支持SKU分类信息填写","isv.business-failed:110220014","检查参数后重试")]
public class ProductEditV2Req : IDouyinReq<ProductEditV2Rsp>
{

	public string GetMethod() { return "product.editV2"; }

	public string GetUrl() { return "/product/editV2"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("product_type")]
	[Description("0-普通，3-虚拟，6玉石闪购，7云闪购")]
	public long? ProductType { get; set; }

	[JsonPropertyName("category_leaf_id")]
	[Description("叶子类目ID通过/shop/getShopCategory接口获取")]
	public long? CategoryLeafId { get; set; }

	[JsonPropertyName("product_format")]
	[Description("属性名称|属性值 之间用|分隔, 多组之间用^分开")]
	public string ProductFormat { get; set; }

	[JsonPropertyName("name")]
	[Description("商品名称，最多60个字符(30个汉字)，不能含emoj表情")]
	public string Name { get; set; }

	[JsonPropertyName("recommend_remark")]
	[Description("商家推荐语，不能含emoj表情")]
	public string RecommendRemark { get; set; }

	[JsonPropertyName("pic")]
	[Description("商品轮播图，多张图片用 ,|, 分开，第一张图为主图，最多5张，至少600x600，大小不超过1M")]
	public string Pic { get; set; }

	[JsonPropertyName("description")]
	[Description("商详图片，多张图片用 | 分开。图片数量总和，不得超过50张。")]
	public string Description { get; set; }

	[JsonPropertyName("pay_type")]
	[Description("已废弃，支付方式，0货到付款 1在线支付，2，货到付款+在线支付")]
	public long? PayType { get; set; }

	[JsonPropertyName("delivery_method")]
	[Description("海南免税生效。 0:离岛免税、1:邮寄、2:离岛自提+邮寄")]
	public int? DeliveryMethod { get; set; }

	[JsonPropertyName("cdf_category")]
	[Description("海南免税：海关限购分类编码")]
	public string CdfCategory { get; set; }

	[JsonPropertyName("reduce_type")]
	[Description("1 减库存类型：1-拍下减库存 2-付款减库存")]
	public long? ReduceType { get; set; }

	[JsonPropertyName("assoc_ids")]
	[Description("同店商品推荐：为空表示使用系统推荐；多个product_id使用“|”分开")]
	public string AssocIds { get; set; }

	[JsonPropertyName("freight_id")]
	[Description("运费模板id，传0表示包邮，通过/freightTemplate/list接口获取")]
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
	public long? Supply7dayReturn { get; set; }

	[JsonPropertyName("mobile")]
	[Description("客服电话号码")]
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
	[Description("外部product_id。超市小时达场景不推荐使用")]
	public long? OutProductId { get; set; }

	[JsonPropertyName("quality_list")]
	[Description("资质信息，可通过/product/qualificationConfig获取")]
	public List<QualityListItem> QualityList { get; set; }

	public class QualityListItem
	{
		[JsonPropertyName("quality_key")]
		[Description("资质key")]
		[NotNull]
		public string QualityKey { get; set; }

		[JsonPropertyName("quality_name")]
		[Description("资质名称")]
		[NotNull]
		public string QualityName { get; set; }

		[JsonPropertyName("quality_attachments")]
		[Description("资质")]
		[NotNull]
		public List<QualityAttachmentsItem> QualityAttachments { get; set; }

		public class QualityAttachmentsItem
		{
			[JsonPropertyName("media_type")]
			[Description("1-图片")]
			[NotNull]
			public long? MediaType { get; set; }

			[JsonPropertyName("url")]
			[Description("凭证url")]
			[NotNull]
			public string Url { get; set; }
		}
	}

	[JsonPropertyName("spec_name")]
	[Description("【废弃不再使用，请使用spec_info参数】如果不填，则规格名为各级规格名用 ,-, 自动生成")]
	public string SpecName { get; set; }

	[JsonPropertyName("specs")]
	[Description("【废弃不再使用，请使用spec_info参数】店铺通用规格，能被同类商品通用。多规格用^分隔，规格与规格值用|分隔，多个规格值用,分隔。如果创建或编辑现货+预售商品或新预售商品时，须包含发货时效，如：颜色|黑色,白色,黄色^尺码|S,M,L^发货时效|5天内发货,15天内发货")]
	public string Specs { get; set; }

	[JsonPropertyName("spec_prices")]
	[Description("sku详情，数量应该等于规格1规格2规格3，sku数量和规格组合数必须一致 sku不可售时，库存可设置为0。price单位为分。 delivery_infos为SKU物流信息，info_value为字符串类型（示例：12），info_type填weight，info_unit支持mg,g,kg，超市小时达场景主品用普通库存，子品用区域库存（sku_type: 1 // 区域库存，stock_num_map: {123: 99999 // 门店ID:库存数量}）。gold_process_charge表示商品加工费，只有计价金类目可填并必填。,sell_properties为sku规格信息，代替spec_detail_name1、spec_detail_name2、spec_detail_name3，支持填写超过三级规格，样式:[{property_id:123,property_name:颜色,value_id:456,value_name:红色,remark:偏深},{property_id:789,property_name:净含量,value_id:891,value_name:30ml,remark:null,measurement:{measure_unit:ml,measure_unit_id:4,value:30}}] 其中property_id规格项属性id,自定义时传0,property_name为规格项名称,value_id为规格值属性id自定义时传0,value_name为规格值名称,remark为规格值备注(选填),measurement为度量衡信息，当规格值为度量衡属性自定义值时传递。")]
	public string SpecPrices { get; set; }

	[JsonPropertyName("spec_pic")]
	[Description("如颜色-尺寸, 颜色就是主规格, 颜色如黑,白,黄,它们图片url以逗号分隔 注：,pic,、,description,、,spec_pic,这三个字段里的传入的图片数量总和，不得超过50张。")]
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
	[Description("通过/product/getCatePropertyV2获取 格式：{property_id:[{value:value,name:property_name,diy_type:0}]}, name的类型是string，value和diy_type的类型是number")]
	public string ProductFormatNew { get; set; }

	[JsonPropertyName("spu_id")]
	[Description("spu id")]
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

	[JsonPropertyName("outer_product_id")]
	[Description("外部product id。超市小时达场景不推荐使用")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("standard_brand_id")]
	[Description("standard_brand_id，通过/brand/list获取，无品牌id则传596120136")]
	public long? StandardBrandId { get; set; }

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

		[JsonPropertyName("coupon_return_methods")]
		[Description("数组当前只支持一个元素且只可为 1或2，其中 1 表示随时退+过期自动退，2 表示不支持退")]
		public List<long> CouponReturnMethods { get; set; }
	}

	[JsonPropertyName("force_use_quality_list")]
	[Description("使用qualityList覆盖当前商品资质，qualityList传空代表清空")]
	public bool? ForceUseQualityList { get; set; }

	[JsonPropertyName("car_vin_code")]
	[Description("汽车Vin码")]
	public string CarVinCode { get; set; }

	[JsonPropertyName("presell_config_level")]
	[Description("0：全款预售，1：sku预售，2：现货+预售 ，3：新预售")]
	public long? PresellConfigLevel { get; set; }

	[JsonPropertyName("need_recharge_mode")]
	[Description("充值模式")]
	public bool? NeedRechargeMode { get; set; }

	[JsonPropertyName("account_template_id")]
	[Description("多账号模板")]
	public string AccountTemplateId { get; set; }

	[JsonPropertyName("presell_delivery_type")]
	[Description("全款预售和sku预售时传递，其他不传： 0 预售结束后发货  1支付完成后发货")]
	public long? PresellDeliveryType { get; set; }

	[JsonPropertyName("white_back_ground_pic_url")]
	[Description("白底图url(仅素材中心url有效)")]
	public string WhiteBackGroundPicUrl { get; set; }

	[JsonPropertyName("long_pic_url")]
	[Description("3:4长图url(仅素材中心url有效)")]
	public string LongPicUrl { get; set; }

	[JsonPropertyName("after_sale_service")]
	[Description("售后服务参数,key:value格式  supply_day_return_selector(7天无理由选项)：N天-政策代号，N只支持7和15 supply_red_ass_return（红屁屁无忧）：0不支持，1支持 supply_allergy_return（过敏无忧,仅跨境可选）：0不支持，1支持 damaged_order_return（坏损包退）：0不支持，1支持 support_allergy_returnV2（过敏包退，境内可选）：0不支持，1支持")]
	public Dictionary<string,string> AfterSaleService { get; set; }

	[JsonPropertyName("sell_channel")]
	[Description("售卖方式;0:全渠道手售卖,1:仅指定直播间售卖")]
	public List<long> SellChannel { get; set; }

	[JsonPropertyName("start_sale_type")]
	[Description("审核通过后上架售卖时间配置:0-立即上架售卖 1-放入仓库")]
	public long? StartSaleType { get; set; }

	[JsonPropertyName("delay_rule")]
	[Description("特殊日期延迟发货规则")]
	public DelayRuleItem DelayRule { get; set; }

	public class DelayRuleItem
	{
		[JsonPropertyName("enable")]
		[Description("是否开启特殊日期延迟发货")]
		public bool? Enable { get; set; }

		[JsonPropertyName("config_type")]
		[Description("1 时间点；2 时间范围")]
		public int? ConfigType { get; set; }

		[JsonPropertyName("config_value")]
		[Description("特殊日期延迟发货时间最晚发货时间，时间戳，单位秒：当config_type=1时，传时间戳，代表最晚x发货；当config_type=2时，传天数，代表延迟x天发货")]
		public long? ConfigValue { get; set; }

		[JsonPropertyName("start_time")]
		[Description("特殊日期延迟发货时间下单开始时间，时间戳，单位秒")]
		public long? StartTime { get; set; }

		[JsonPropertyName("end_time")]
		[Description("特殊日期延迟发货时间下单结束时间，时间戳，单位秒")]
		public long? EndTime { get; set; }
	}

	[JsonPropertyName("material_video_id")]
	[Description("主图视频ID，可以先通过https://op.jinritemai.com/docs/api-docs/69/1617接口上传视频，获取审核通过的视频素材ID进行传入")]
	public string MaterialVideoId { get; set; }

	[JsonPropertyName("pickup_method")]
	[Description("提取方式新字段，推荐使用。0: 普通商品-使用物流发货, 1: 虚拟商品-无需物流与电子交易凭证, 2: 虚拟商品-使用电子交易凭证, 3: 虚拟商品-充值直连")]
	public string PickupMethod { get; set; }

	[JsonPropertyName("size_info_template_id")]
	[Description("尺码模板ID")]
	public long? SizeInfoTemplateId { get; set; }

	[JsonPropertyName("substitute_goods_url")]
	[Description("外部商品url")]
	public string SubstituteGoodsUrl { get; set; }

	[JsonPropertyName("sale_channel_type")]
	[Description("销售渠道类型，可选onlineOnly（纯电商，仅在线上售卖）或sameAsOffline（专柜同款，线上线下都有售卖），云零售商家（https://fxg.jinritemai.com/ffa/merchant-growth/cloud-retail）可以设置")]
	public string SaleChannelType { get; set; }

	[JsonPropertyName("name_prefix")]
	[Description("通过/product/getRecommendName接口推荐的商品标题前缀（注意系统根据类目属性生成前缀字符串时，末尾有一个空格）")]
	public string NamePrefix { get; set; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	public long? StoreId { get; set; }

	[JsonPropertyName("main_product_id")]
	[Description("主商品ID")]
	public long? MainProductId { get; set; }

	[JsonPropertyName("sale_limit_id")]
	[Description("限售模板ID")]
	public long? SaleLimitId { get; set; }

	[JsonPropertyName("reference_price")]
	[Description("商品参考价")]
	public long? ReferencePrice { get; set; }

	[JsonPropertyName("reference_price_certificate")]
	[Description("参考价凭证相关信息")]
	public ReferencePriceCertificateItem ReferencePriceCertificate { get; set; }

	public class ReferencePriceCertificateItem
	{
		[JsonPropertyName("certificate_type")]
		[Description("参考价凭证类型，通过/product/getProductUpdateRule获取可选类型")]
		public long? CertificateType { get; set; }

		[JsonPropertyName("certificate_urls")]
		[Description("凭证图片，必须是商品素材中心URL，最多允许一张图片")]
		public List<string> CertificateUrls { get; set; }
	}

	[JsonPropertyName("main_image_three_to_four")]
	[Description("商品主图3:4，多张图片用 ,|, 分开，最多5张，大小不超过1M。")]
	public string MainImageThreeToFour { get; set; }

	[JsonPropertyName("unit_price_info")]
	[Description("价格规则信息")]
	public UnitPriceInfoItem UnitPriceInfo { get; set; }

	public class UnitPriceInfoItem
	{
		[JsonPropertyName("process_charge")]
		[Description("废弃字段，请写死传0")]
		public long? ProcessCharge { get; set; }

		[JsonPropertyName("price_rule_type")]
		[Description("价格规则类型：,1表示投资金,2表示首饰金")]
		public int? PriceRuleType { get; set; }
	}

	[JsonPropertyName("quality_inspection_info")]
	[Description("前置质检相关（特定二手商家、特定二手类目使用）")]
	public QualityInspectionInfoItem QualityInspectionInfo { get; set; }

	public class QualityInspectionInfoItem
	{
		[JsonPropertyName("supported")]
		[Description("是否支持前置质检")]
		public bool? Supported { get; set; }

		[JsonPropertyName("agency")]
		[Description("机构编码，请通过/inspection/QueryBtasAgencyList接口获取")]
		public string Agency { get; set; }

		[JsonPropertyName("certificate_code")]
		[Description("质检证书编码")]
		public string CertificateCode { get; set; }

		[JsonPropertyName("mode")]
		[Description("1: 单库存模式，只允许售卖一个sku；2: 多库存模式，不限售卖次数")]
		public int? Mode { get; set; }
	}

	[JsonPropertyName("is_c2b_switch_on")]
	[Description("是否支持c2b小程序（特定c2b定制商家使用，请使用/product/getProductUpdateRule接口获取是否支持）")]
	public bool? IsC2bSwitchOn { get; set; }

	[JsonPropertyName("micro_app_id")]
	[Description("支持c2b定制时的小程序id（特定c2b定制商家使用，请使用/product/getProductUpdateRule接口获取是否支持）")]
	public string MicroAppId { get; set; }

	[JsonPropertyName("is_auto_charge")]
	[Description("是否修改为自动充值商品")]
	public bool? IsAutoCharge { get; set; }

	[JsonPropertyName("short_product_name")]
	[Description("导购短标题，短标题可用于物流打单及商品搜索场景，若未填写，则系统将智能生成最优短标题在商详购买页面展示，说明详见：https://school.jinritemai.com/doudian/web/article/aHUW2MCvHqF3?from=shop_article")]
	public string ShortProductName { get; set; }

	[JsonPropertyName("after_sale_service_v2")]
	[Description("售后服务新结构（老的after_sale_service中的字段后续会慢慢迁移到这里）")]
	public AfterSaleServiceV2Item AfterSaleServiceV2 { get; set; }

	public class AfterSaleServiceV2Item
	{
		[JsonPropertyName("is_large_product")]
		[Description("当前商品是否是大件商品")]
		public long? IsLargeProduct { get; set; }
	}

	[JsonPropertyName("spec_prices_v2")]
	[Description("sku新参数，建议切到新参数，后续老参数spec_prices废弃")]
	public List<SpecPricesV2Item> SpecPricesV2 { get; set; }

	public class SpecPricesV2Item
	{
		[JsonPropertyName("sku_classification_type")]
		[Description("sku分类信息，对应枚举值,main_sale_single_product - 主售款（单品）,main_sale_multi_product - 主售款（多件装）,main_sale_combination - 主售款（组合品）,non_main_sale - 非主售款,information_description - 信息说明/防拍")]
		public string SkuClassificationType { get; set; }

		[JsonPropertyName("package_sku")]
		[Description("组套包信息")]
		public List<PackageSkuItem> PackageSku { get; set; }

		public class PackageSkuItem
		{
			[JsonPropertyName("short_name")]
			[Description("组套名称")]
			public string ShortName { get; set; }

			[JsonPropertyName("combo_num")]
			[Description("组套包子品数量")]
			public long? ComboNum { get; set; }

			[JsonPropertyName("sub_sku_id")]
			[Description("组套包子品skuId")]
			public long? SubSkuId { get; set; }

			[JsonPropertyName("sub_product_id")]
			[Description("组套包子品商品id")]
			public long? SubProductId { get; set; }
		}

		[JsonPropertyName("sku_id")]
		[Description("skuId,支持基于skuId修改sku信息")]
		public long? SkuId { get; set; }

		[JsonPropertyName("gold_process_charge")]
		[Description("黄金加工费，单位：分，nil代表不修改")]
		public long? GoldProcessCharge { get; set; }

		[JsonPropertyName("sell_properties")]
		[Description("sku规格信息：规格项规格值")]
		public List<SellPropertiesItem> SellProperties { get; set; }

		public class SellPropertiesItem
		{
			[JsonPropertyName("property_name")]
			[Description("规格名称")]
			public string PropertyName { get; set; }

			[JsonPropertyName("value_name")]
			[Description("规格值名称")]
			public string ValueName { get; set; }
		}

		[JsonPropertyName("supply_price")]
		[Description("供货价,单位：分，nil代表不修改，0代表清空")]
		public long? SupplyPrice { get; set; }

		[JsonPropertyName("delivery_infos")]
		[Description("SKU运输信息")]
		public List<DeliveryInfosItem> DeliveryInfos { get; set; }

		public class DeliveryInfosItem
		{
			[JsonPropertyName("info_unit")]
			[Description("信息计量单位")]
			public string InfoUnit { get; set; }

			[JsonPropertyName("info_value")]
			[Description("信息值")]
			public string InfoValue { get; set; }

			[JsonPropertyName("info_type")]
			[Description("信息类型")]
			public string InfoType { get; set; }
		}

		[JsonPropertyName("cargo")]
		[Description("货品信息，如果传0 0 表示解绑）")]
		public List<CargoItem> Cargo { get; set; }

		public class CargoItem
		{
			[JsonPropertyName("cargo_id")]
			[Description("货品id")]
			public long? CargoId { get; set; }

			[JsonPropertyName("source_type")]
			[Description("货品类型")]
			public long? SourceType { get; set; }
		}

		[JsonPropertyName("barcodes")]
		[Description("条码信息")]
		public List<string> Barcodes { get; set; }

		[JsonPropertyName("presell_delay")]
		[Description("SKU维度预售发货延迟时间")]
		public long? PresellDelay { get; set; }

		[JsonPropertyName("spec_value_lib_id")]
		[Description("商品规格值id：懂车帝场景传递")]
		public long? SpecValueLibId { get; set; }

		[JsonPropertyName("tax_exemption_sku_info")]
		[Description("海南免税：Sku 额外信息")]
		public List<TaxExemptionSkuInfoItem> TaxExemptionSkuInfo { get; set; }

		public class TaxExemptionSkuInfoItem
		{
			[JsonPropertyName("volume")]
			[Description("净含量")]
			public long? Volume { get; set; }

			[JsonPropertyName("suit_num")]
			[Description("套装数量")]
			public long? SuitNum { get; set; }

			[JsonPropertyName("is_suit")]
			[Description("是否套装（0 否 1 是）")]
			public long? IsSuit { get; set; }
		}

		[JsonPropertyName("stock_num_map")]
		[Description("仓ID -> 库存数量")]
		public Dictionary<string,long> StockNumMap { get; set; }

		[JsonPropertyName("sku_type")]
		[Description("库存类型")]
		public long? SkuType { get; set; }

		[JsonPropertyName("customs_report_info")]
		[Description("海关申报要素")]
		public List<CustomsReportInfoItem> CustomsReportInfo { get; set; }

		public class CustomsReportInfoItem
		{
			[JsonPropertyName("bar_code")]
			[Description("条形码")]
			public string BarCode { get; set; }

			[JsonPropertyName("g_model")]
			[Description("规格型号")]
			public string GModel { get; set; }

			[JsonPropertyName("usage")]
			[Description("用途")]
			public string Usage { get; set; }

			[JsonPropertyName("report_brand_name")]
			[Description("品牌")]
			public string ReportBrandName { get; set; }

			[JsonPropertyName("report_name")]
			[Description("品名")]
			public string ReportName { get; set; }

			[JsonPropertyName("unit")]
			[Description("售卖单位")]
			public string Unit { get; set; }

			[JsonPropertyName("second_measure_unit")]
			[Description("法定第二计量单位")]
			public string SecondMeasureUnit { get; set; }

			[JsonPropertyName("first_measure_unit")]
			[Description("法定第一计量单位")]
			public string FirstMeasureUnit { get; set; }

			[JsonPropertyName("second_measure_qty")]
			[Description("法定第二计量数量")]
			public decimal? SecondMeasureQty { get; set; }

			[JsonPropertyName("first_measure_qty")]
			[Description("法定第一计量数量")]
			public decimal? FirstMeasureQty { get; set; }

			[JsonPropertyName("hs_code")]
			[Description("海关代码")]
			public string HsCode { get; set; }
		}

		[JsonPropertyName("outer_sku_id")]
		[Description("外部sku_id-string")]
		public string OuterSkuId { get; set; }

		[JsonPropertyName("supplier_id")]
		[Description("供应商编码")]
		public string SupplierId { get; set; }

		[JsonPropertyName("step_stock_num")]
		[Description("阶梯库存数")]
		public long? StepStockNum { get; set; }

		[JsonPropertyName("code")]
		[Description("商家编码")]
		public string Code { get; set; }

		[JsonPropertyName("price")]
		[Description("价格")]
		public long? Price { get; set; }

		[JsonPropertyName("stock_num")]
		[Description("库存数量")]
		public long? StockNum { get; set; }
	}

	[JsonPropertyName("spec_info")]
	[Description("规格模版详细信息")]
	public SpecInfoItem SpecInfo { get; set; }

	public class SpecInfoItem
	{
		[JsonPropertyName("spec_values")]
		[Description("规格项，如颜色、尺码")]
		public List<SpecValuesItem> SpecValues { get; set; }

		public class SpecValuesItem
		{
			[JsonPropertyName("values")]
			[Description("规格值")]
			public List<ValuesItem> Values { get; set; }

			public class ValuesItem
			{
				[JsonPropertyName("value_name")]
				[Description("规格值名称")]
				[NotNull]
				public string ValueName { get; set; }

				[JsonPropertyName("remark")]
				[Description("规格值备注信息，如偏大")]
				public string Remark { get; set; }

				[JsonPropertyName("cpv_path")]
				[Description("规格值的导航样式路径信息，如色系->色值")]
				public List<CpvPathItem> CpvPath { get; set; }

				public class CpvPathItem
				{
					[JsonPropertyName("cpvid")]
					[Description("如具体白色系的销售属性值id")]
					public long? Cpvid { get; set; }

					[JsonPropertyName("cpid")]
					[Description("如色系的销售属性id")]
					public long? Cpid { get; set; }
				}

				[JsonPropertyName("measure_info")]
				[Description("度量衡结构化信息，如单果规格的规格值10-13g，包含两个模块：,{,        measure_info: {,          template_id: 50,,          values: [,            {,              module_id: 44,,              prefix: ,,              suffix: -,,              value: 10,            },,            {,              module_id: 45,,              prefix: ,,              suffix: ,,              value: 13,,              unit_id: 2,,              unit_name: g,            },          ],        }")]
				public MeasureInfoItem MeasureInfo { get; set; }

				public class MeasureInfoItem
				{
					[JsonPropertyName("values")]
					[Description("度量衡模块信息，如示例中13克为一个模块")]
					public List<ValuesItem> Values { get; set; }

					public class ValuesItem
					{
						[JsonPropertyName("suffix")]
						[Description("后缀，如-")]
						public string Suffix { get; set; }

						[JsonPropertyName("prefix")]
						[Description("前缀，示例中为空")]
						public string Prefix { get; set; }

						[JsonPropertyName("unit_name")]
						[Description("单位名称，如g")]
						public string UnitName { get; set; }

						[JsonPropertyName("unit_id")]
						[Description("单位id")]
						public long? UnitId { get; set; }

						[JsonPropertyName("value")]
						[Description("值内容，如13")]
						public string Value { get; set; }

						[JsonPropertyName("module_id")]
						[Description("模块id")]
						public long? ModuleId { get; set; }
					}

					[JsonPropertyName("template_id")]
					[Description("度量衡模版id，根据/getProductUpdateRule中回填")]
					public long? TemplateId { get; set; }
				}

				[JsonPropertyName("value_id")]
				[Description("标准销售属性值id")]
				public long? ValueId { get; set; }
			}

			[JsonPropertyName("property_name")]
			[Description("规格项名称，如颜色")]
			[NotNull]
			public string PropertyName { get; set; }

			[JsonPropertyName("property_id")]
			[Description("标准销售属性id")]
			public long? PropertyId { get; set; }
		}
	}

	[JsonPropertyName("with_sku_type")]
	[Description("主动设置库存类型")]
	public bool? WithSkuType { get; set; }
}

[Description("编辑商品")]
public class ProductEditV2Rsp
{
}
