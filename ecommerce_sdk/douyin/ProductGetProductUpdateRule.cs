namespace ecommerce.sdk.douyin;

[Description("根据店铺ID、类目等查询商品发布规则，如查询支持发货模式、发货时效、尺码模板配置规则、商品主图3:4配置规则等")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","2010013:获取账号信息失败","isv.business-failed:2010013","重试")]
[DouyinRetCode(50002,"业务处理失败","2010001:获取类目标失败","isv.business-failed:2010001","重试")]
[DouyinRetCode(50002,"业务处理失败","2010004:类目ID不合法","isv.business-failed:2010004","检查类目id")]
[DouyinRetCode(50002,"业务处理失败","2010346:未绑定商家仓","isv.business-failed:2010346","检查商家仓")]
[DouyinRetCode(50002,"业务处理失败","2010109:当前类目未开通主图3:4上传功能，请删除主图3:4","isv.business-failed:2010109","删除主图3:4后重新发布")]
public class ProductGetProductUpdateRuleReq : IDouyinReq<ProductGetProductUpdateRuleRsp>
{

	public string GetMethod() { return "product.getProductUpdateRule"; }

	public string GetUrl() { return "/product/getProductUpdateRule"; }

	[JsonPropertyName("category_id")]
	[Description("类目id")]
	[NotNull]
	public long? CategoryId { get; set; }

	[JsonPropertyName("senses")]
	[Description("闪购定制参数，普通发品忽略")]
	public List<int> Senses { get; set; }

	[JsonPropertyName("standard_brand_id")]
	[Description("品牌id")]
	public long? StandardBrandId { get; set; }

	[JsonPropertyName("spu_id")]
	[Description("spu_id")]
	public long? SpuId { get; set; }
}

[Description("根据店铺ID、类目等查询商品发布规则，如查询支持发货模式、发货时效、尺码模板配置规则、商品主图3:4配置规则等")]
public class ProductGetProductUpdateRuleRsp
{
	[JsonPropertyName("fulfillment_rule")]
	[Description("履约规则")]
	public FulfillmentRuleItem FulfillmentRule { get; set; }

	public class FulfillmentRuleItem
	{
		[JsonPropertyName("normal_rule")]
		[Description("现货发货模式规则")]
		public NormalRuleItem NormalRule { get; set; }

		public class NormalRuleItem
		{
			[JsonPropertyName("delay_rule")]
			[Description("特殊时间延迟发货规则")]
			public DelayRuleItem DelayRule { get; set; }

			public class DelayRuleItem
			{
				[JsonPropertyName("end_time")]
				[Description("规则结束时间")]
				public long EndTime { get; set; }

				[JsonPropertyName("start_time")]
				[Description("规则开始时间")]
				public long StartTime { get; set; }

				[JsonPropertyName("config_value")]
				[Description("与规则配置类型对应的配置值")]
				public long ConfigValue { get; set; }

				[JsonPropertyName("config_type")]
				[Description("支持的配置类型,1：代表时间点，此时对应的config_value的值为支持的最晚发货的秒级时间戳,2：代表相对时间，此时对应的config_value的值表示支付后几天发货；比如config_value=3表示支付后三天发货")]
				public int ConfigType { get; set; }
			}

			[JsonPropertyName("support")]
			[Description("是否支持")]
			public bool Support { get; set; }

			[JsonPropertyName("delay_options")]
			[Description("发货时效选项，如当日发、次日发、48小时")]
			public List<long> DelayOptions { get; set; }

			[JsonPropertyName("is_special_delay_option")]
			[Description("是否是特殊的时间发货，可忽略")]
			public bool IsSpecialDelayOption { get; set; }
		}

		[JsonPropertyName("step_rule")]
		[Description("阶梯发货模式规则")]
		public StepRuleItem StepRule { get; set; }

		public class StepRuleItem
		{
			[JsonPropertyName("support")]
			[Description("是否支持")]
			public bool Support { get; set; }

			[JsonPropertyName("delay_options")]
			[Description("阶梯现货部分延迟返货时间范围")]
			public List<long> DelayOptions { get; set; }

			[JsonPropertyName("is_special_delay_option")]
			[Description("是特殊时间延迟发货，可忽略")]
			public bool IsSpecialDelayOption { get; set; }

			[JsonPropertyName("step_min_delay")]
			[Description("阶梯发货阶梯部分发货时间最小值")]
			public long StepMinDelay { get; set; }

			[JsonPropertyName("step_max_delay")]
			[Description("阶梯发货阶梯部分发货时间最大值")]
			public long StepMaxDelay { get; set; }

			[JsonPropertyName("delay_rule")]
			[Description("延迟发货规则")]
			public DelayRuleItem DelayRule { get; set; }

			public class DelayRuleItem
			{
				[JsonPropertyName("config_type")]
				[Description("配置类型")]
				public int ConfigType { get; set; }

				[JsonPropertyName("config_value")]
				[Description("配置值")]
				public long ConfigValue { get; set; }

				[JsonPropertyName("start_time")]
				[Description("商家配置的开始时间")]
				public long StartTime { get; set; }

				[JsonPropertyName("end_time")]
				[Description("商家配置的结束时间")]
				public long EndTime { get; set; }
			}
		}

		[JsonPropertyName("product_presell_rule")]
		[Description("全款预售发货模式规则")]
		public ProductPresellRuleItem ProductPresellRule { get; set; }

		public class ProductPresellRuleItem
		{
			[JsonPropertyName("support")]
			[Description("是否支持全款预售")]
			public bool Support { get; set; }

			[JsonPropertyName("min_presell_price")]
			[Description("预售门槛价")]
			public long MinPresellPrice { get; set; }

			[JsonPropertyName("support_delivery_after_pay")]
			[Description("是否支持支付成功后发货")]
			public bool SupportDeliveryAfterPay { get; set; }

			[JsonPropertyName("support_delivery_after_presell")]
			[Description("是否支持预售结束后发货")]
			public bool SupportDeliveryAfterPresell { get; set; }

			[JsonPropertyName("delivery_after_pay_config")]
			[Description("支付结束后规则")]
			public DeliveryAfterPayConfigItem DeliveryAfterPayConfig { get; set; }

			public class DeliveryAfterPayConfigItem
			{
				[JsonPropertyName("min_delivery_days")]
				[Description("延迟发货时间最小值")]
				public long MinDeliveryDays { get; set; }

				[JsonPropertyName("max_delivery_days")]
				[Description("延迟发货时间最大值")]
				public long MaxDeliveryDays { get; set; }

				[JsonPropertyName("max_presell_end_days")]
				[Description("最长预售结束时间")]
				public long MaxPresellEndDays { get; set; }

				[JsonPropertyName("need_audit")]
				[Description("是否需要人审，可忽略")]
				public bool NeedAudit { get; set; }
			}

			[JsonPropertyName("delivery_after_presell_config")]
			[Description("预售结束后规则")]
			public DeliveryAfterPresellConfigItem DeliveryAfterPresellConfig { get; set; }

			public class DeliveryAfterPresellConfigItem
			{
				[JsonPropertyName("min_delivery_days")]
				[Description("延迟发货时间最小值")]
				public long MinDeliveryDays { get; set; }

				[JsonPropertyName("max_delivery_days")]
				[Description("延迟发货时间最大值")]
				public long MaxDeliveryDays { get; set; }

				[JsonPropertyName("max_presell_end_days")]
				[Description("最长预售结束时间")]
				public long MaxPresellEndDays { get; set; }

				[JsonPropertyName("need_audit")]
				[Description("是否需要人审，可忽略")]
				public bool NeedAudit { get; set; }
			}
		}

		[JsonPropertyName("sku_presell_rule")]
		[Description("SKU预售发货模式规则")]
		public SkuPresellRuleItem SkuPresellRule { get; set; }

		public class SkuPresellRuleItem
		{
			[JsonPropertyName("support")]
			[Description("是否支持")]
			public bool Support { get; set; }

			[JsonPropertyName("min_presell_price")]
			[Description("预售门槛价")]
			public long MinPresellPrice { get; set; }

			[JsonPropertyName("support_delivery_after_pay")]
			[Description("是否支持支付结束后发货")]
			public bool SupportDeliveryAfterPay { get; set; }

			[JsonPropertyName("support_delivery_after_presell")]
			[Description("是否支持预售结束后发货")]
			public bool SupportDeliveryAfterPresell { get; set; }

			[JsonPropertyName("delivery_after_pay_config")]
			[Description("支付结束后规则")]
			public DeliveryAfterPayConfigItem DeliveryAfterPayConfig { get; set; }

			public class DeliveryAfterPayConfigItem
			{
				[JsonPropertyName("min_delivery_days")]
				[Description("延迟发货时间最小值")]
				public long MinDeliveryDays { get; set; }

				[JsonPropertyName("max_delivery_days")]
				[Description("延迟发货时间最大值")]
				public long MaxDeliveryDays { get; set; }

				[JsonPropertyName("max_presell_end_days")]
				[Description("最长预售结束时间")]
				public long MaxPresellEndDays { get; set; }

				[JsonPropertyName("need_audit")]
				[Description("是否需要人审，可忽略")]
				public bool NeedAudit { get; set; }
			}

			[JsonPropertyName("delivery_after_presell_config")]
			[Description("预售结束后规则")]
			public DeliveryAfterPresellConfigItem DeliveryAfterPresellConfig { get; set; }

			public class DeliveryAfterPresellConfigItem
			{
				[JsonPropertyName("min_delivery_days")]
				[Description("延迟发货时间最小值")]
				public long MinDeliveryDays { get; set; }

				[JsonPropertyName("max_delivery_days")]
				[Description("延迟发货时间最大值")]
				public long MaxDeliveryDays { get; set; }

				[JsonPropertyName("max_presell_end_days")]
				[Description("最长预售结束时间")]
				public long MaxPresellEndDays { get; set; }

				[JsonPropertyName("need_audit")]
				[Description("是否需要人审，可忽略")]
				public bool NeedAudit { get; set; }
			}
		}

		[JsonPropertyName("time_sku_presell_with_normal_rule")]
		[Description("现货+预售发货规则")]
		public TimeSkuPresellWithNormalRuleItem TimeSkuPresellWithNormalRule { get; set; }

		public class TimeSkuPresellWithNormalRuleItem
		{
			[JsonPropertyName("support")]
			[Description("是否支持")]
			public bool Support { get; set; }

			[JsonPropertyName("time_sku_spec_name")]
			[Description("发货时效规格名称")]
			public string TimeSkuSpecName { get; set; }

			[JsonPropertyName("time_sku_spec_detial")]
			[Description("发货时效规格选项")]
			public List<TimeSkuSpecDetialItem> TimeSkuSpecDetial { get; set; }

			public class TimeSkuSpecDetialItem
			{
				[JsonPropertyName("spec_value")]
				[Description("规格值")]
				public string SpecValue { get; set; }

				[JsonPropertyName("is_presell_spec")]
				[Description("是否预售时效")]
				public bool IsPresellSpec { get; set; }

				[JsonPropertyName("spec_code")]
				[Description("product_time_spec_same_day 当日发/次日发 product_time_spec_next_day 次日发 product_time_spec_48h  48小时内发货 product_time_spec_5d  5天内发货 product_time_spec_15d  15天内发货 product_time_spec_45d  45天内发货")]
				public string SpecCode { get; set; }
			}

			[JsonPropertyName("min_presell_price")]
			[Description("预售门槛价，单位分")]
			public long MinPresellPrice { get; set; }
		}

		[JsonPropertyName("time_sku_pure_presell_rule")]
		[Description("新预售发货模式规则")]
		public TimeSkuPurePresellRuleItem TimeSkuPurePresellRule { get; set; }

		public class TimeSkuPurePresellRuleItem
		{
			[JsonPropertyName("support")]
			[Description("是否支持")]
			public bool Support { get; set; }

			[JsonPropertyName("time_sku_spec_name")]
			[Description("发货时效规格名称")]
			public string TimeSkuSpecName { get; set; }

			[JsonPropertyName("time_sku_spec_detial")]
			[Description("发货时效规格选项")]
			public List<TimeSkuSpecDetialItem> TimeSkuSpecDetial { get; set; }

			public class TimeSkuSpecDetialItem
			{
				[JsonPropertyName("spec_code")]
				[Description("规格值code")]
				public string SpecCode { get; set; }

				[JsonPropertyName("spec_value")]
				[Description("规格值")]
				public string SpecValue { get; set; }

				[JsonPropertyName("is_presell_spec")]
				[Description("是否预售时效")]
				public bool IsPresellSpec { get; set; }
			}

			[JsonPropertyName("min_presell_price")]
			[Description("预售门槛价，单位分")]
			public long MinPresellPrice { get; set; }
		}
	}

	[JsonPropertyName("recommend_name_rule")]
	[Description("商品标题推荐规则")]
	public RecommendNameRuleItem RecommendNameRule { get; set; }

	public class RecommendNameRuleItem
	{
		[JsonPropertyName("title_limit_rule")]
		[Description("标题长度规则")]
		public TitleLimitRuleItem TitleLimitRule { get; set; }

		public class TitleLimitRuleItem
		{
			[JsonPropertyName("max_length")]
			[Description("标题最长长度")]
			public string MaxLength { get; set; }

			[JsonPropertyName("min_length")]
			[Description("标题最短长度")]
			public string MinLength { get; set; }
		}

		[JsonPropertyName("satisfy_prefix")]
		[Description("当前类目id是否命中前缀推荐规则")]
		public bool SatisfyPrefix { get; set; }

		[JsonPropertyName("property_ids")]
		[Description("命中规则的属性id详情")]
		public List<long> PropertyIds { get; set; }
	}

	[JsonPropertyName("after_sale_rule")]
	[Description("售后服务规则")]
	public AfterSaleRuleItem AfterSaleRule { get; set; }

	public class AfterSaleRuleItem
	{
		[JsonPropertyName("allergy_return_v2_rule")]
		[Description("过敏包退规则")]
		public AllergyReturnV2RuleItem AllergyReturnV2Rule { get; set; }

		public class AllergyReturnV2RuleItem
		{
			[JsonPropertyName("enable")]
			[Description("是否可选过敏包退")]
			public string Enable { get; set; }

			[JsonPropertyName("must_select")]
			[Description("是否必选过敏包退")]
			public string MustSelect { get; set; }

			[JsonPropertyName("options")]
			[Description("可选项")]
			public List<OptionsItem> Options { get; set; }

			public class OptionsItem
			{
				[JsonPropertyName("value")]
				[Description("可选项对应value")]
				public string Value { get; set; }

				[JsonPropertyName("name")]
				[Description("可选项名称")]
				public string Name { get; set; }
			}
		}

		[JsonPropertyName("large_product_rule")]
		[Description("大件商品规则")]
		public LargeProductRuleItem LargeProductRule { get; set; }

		public class LargeProductRuleItem
		{
			[JsonPropertyName("enable")]
			[Description("是否可选大件商品")]
			public bool Enable { get; set; }

			[JsonPropertyName("must_select")]
			[Description("是否必须大件商品")]
			public bool MustSelect { get; set; }

			[JsonPropertyName("options")]
			[Description("可选项")]
			public List<OptionsItem> Options { get; set; }

			public class OptionsItem
			{
				[JsonPropertyName("name")]
				[Description("可选项名称")]
				public string Name { get; set; }

				[JsonPropertyName("value")]
				[Description("可选项对应value")]
				public string Value { get; set; }
			}
		}

		[JsonPropertyName("supply_day_return_rule")]
		[Description("无理由退货规则")]
		public SupplyDayReturnRuleItem SupplyDayReturnRule { get; set; }

		public class SupplyDayReturnRuleItem
		{
			[JsonPropertyName("enable")]
			[Description("true 支持七天无理由，false 不支持七天无理由")]
			public bool Enable { get; set; }

			[JsonPropertyName("options")]
			[Description("可选的无理由退货选项列表")]
			public List<OptionsItem> Options { get; set; }

			public class OptionsItem
			{
				[JsonPropertyName("name")]
				[Description("天无理由退货文案描述")]
				public string Name { get; set; }

				[JsonPropertyName("value")]
				[Description("无理由退货的类型")]
				public string Value { get; set; }
			}
		}
	}

	[JsonPropertyName("reference_price_rule")]
	[Description("参考价相关规则")]
	public ReferencePriceRuleItem ReferencePriceRule { get; set; }

	public class ReferencePriceRuleItem
	{
		[JsonPropertyName("is_support")]
		[Description("true表示可填写参考价，false表示不可填写参考价")]
		public bool IsSupport { get; set; }

		[JsonPropertyName("is_required")]
		[Description("true表示必填参考价，false表示不必填参考价")]
		public bool IsRequired { get; set; }

		[JsonPropertyName("certificate_types")]
		[Description("参考价凭证类型枚举值与对应的显示名称，比如{     1 : 厂商建议零售价,     2 : 吊牌价,     3 : 定价,     4 : 官网零售价 }")]
		public Dictionary<long,string> CertificateTypes { get; set; }

		[JsonPropertyName("lower_sku_price_times")]
		[Description("参考价最高高于最低SKU价格的倍数，比如最低SKU价格为1，此值为10，则参考价不可高于10")]
		public long LowerSkuPriceTimes { get; set; }
	}

	[JsonPropertyName("spu_control_rule")]
	[Description("spu管控规则")]
	public SpuControlRuleItem SpuControlRule { get; set; }

	public class SpuControlRuleItem
	{
		[JsonPropertyName("support_spu_product")]
		[Description("是否支持spu发品")]
		public bool SupportSpuProduct { get; set; }

		[JsonPropertyName("control_type")]
		[Description("0不管控 1弱管控 2强管控")]
		public long ControlType { get; set; }

		[JsonPropertyName("support_create_spu")]
		[Description("是否支持新建spu")]
		public bool SupportCreateSpu { get; set; }

		[JsonPropertyName("support_rectify_spu")]
		[Description("是否支持spu纠错")]
		public bool SupportRectifySpu { get; set; }

		[JsonPropertyName("support_report_spu")]
		[Description("是否支持spu举报")]
		public bool SupportReportSpu { get; set; }

		[JsonPropertyName("no_need_audit_spu")]
		[Description("是否spu免审")]
		public bool NoNeedAuditSpu { get; set; }
	}

	[JsonPropertyName("product_spec_rule")]
	[Description("商品规格约束")]
	public ProductSpecRuleItem ProductSpecRule { get; set; }

	public class ProductSpecRuleItem
	{
		[JsonPropertyName("spec_rule_code")]
		[Description("totally_use_given_spec：完全使用系统下发规格；partly_use_given_spec部分使用系统下发规格；not_use_given_spec：不管控规格;:为空时表示不管控规格")]
		public string SpecRuleCode { get; set; }

		[JsonPropertyName("required_spec_details")]
		[Description("商品规格列表")]
		public List<RequiredSpecDetailsItem> RequiredSpecDetails { get; set; }

		public class RequiredSpecDetailsItem
		{
			[JsonPropertyName("sell_property_name")]
			[Description("规格项名称")]
			public string SellPropertyName { get; set; }

			[JsonPropertyName("sell_property_id")]
			[Description("规格项id")]
			public long SellPropertyId { get; set; }

			[JsonPropertyName("property_values")]
			[Description("规格值选项")]
			public List<PropertyValuesItem> PropertyValues { get; set; }

			public class PropertyValuesItem
			{
				[JsonPropertyName("sell_property_value_id")]
				[Description("规格值id")]
				public long SellPropertyValueId { get; set; }

				[JsonPropertyName("sell_property_value_name")]
				[Description("规格值名称")]
				public string SellPropertyValueName { get; set; }

				[JsonPropertyName("value_pic")]
				[Description("规格值图片")]
				public ValuePicItem ValuePic { get; set; }

				public class ValuePicItem
				{
					[JsonPropertyName("pic_value")]
					[Description("规格值图片内容")]
					public string PicValue { get; set; }

					[JsonPropertyName("pic_type")]
					[Description("规格值图片类型rgb和url")]
					public string PicType { get; set; }
				}
			}

			[JsonPropertyName("support_remark")]
			[Description("是否支持备注")]
			public bool SupportRemark { get; set; }

			[JsonPropertyName("support_diy")]
			[Description("是否可以自定义规格值")]
			public bool SupportDiy { get; set; }

			[JsonPropertyName("is_required")]
			[Description("是否必填")]
			public bool IsRequired { get; set; }

			[JsonPropertyName("value_display_style")]
			[Description("规格样式，cascader是为导航样式")]
			public string ValueDisplayStyle { get; set; }

			[JsonPropertyName("measure_templates")]
			[Description("度量衡模版，可能有多个")]
			public List<MeasureTemplatesItem> MeasureTemplates { get; set; }

			public class MeasureTemplatesItem
			{
				[JsonPropertyName("template_id")]
				[Description("度量衡模版id")]
				public long TemplateId { get; set; }

				[JsonPropertyName("value_modules")]
				[Description("度量衡模版模块内容，一个模版多个模块")]
				public List<ValueModulesItem> ValueModules { get; set; }

				public class ValueModulesItem
				{
					[JsonPropertyName("module_id")]
					[Description("模块id")]
					public long ModuleId { get; set; }

					[JsonPropertyName("prefix")]
					[Description("前缀")]
					public string Prefix { get; set; }

					[JsonPropertyName("suffix")]
					[Description("后缀")]
					public string Suffix { get; set; }

					[JsonPropertyName("input_type")]
					[Description("输入类型：枚举 enum, 输入 input， enum_diy 枚举可输入")]
					public string InputType { get; set; }

					[JsonPropertyName("values")]
					[Description("度量衡值选项")]
					public List<ValuesItem> Values { get; set; }

					public class ValuesItem
					{
						[JsonPropertyName("value_name")]
						[Description("度量衡值")]
						public string ValueName { get; set; }
					}

					[JsonPropertyName("units")]
					[Description("度量衡单位")]
					public List<UnitsItem> Units { get; set; }

					public class UnitsItem
					{
						[JsonPropertyName("unit_id")]
						[Description("度量衡单位id")]
						public long UnitId { get; set; }

						[JsonPropertyName("unit_name")]
						[Description("度量衡单位名称")]
						public string UnitName { get; set; }
					}

					[JsonPropertyName("validate_rule")]
					[Description("度量衡规则")]
					public ValidateRuleItem ValidateRule { get; set; }

					public class ValidateRuleItem
					{
						[JsonPropertyName("data_type")]
						[Description("数据类型，integer、float")]
						public string DataType { get; set; }

						[JsonPropertyName("precision")]
						[Description("小数位数，data_type为float时有值")]
						public long Precision { get; set; }

						[JsonPropertyName("min")]
						[Description("最小值")]
						public decimal Min { get; set; }

						[JsonPropertyName("max")]
						[Description("最大值")]
						public decimal Max { get; set; }

						[JsonPropertyName("unit_rules")]
						[Description("单位规则明细")]
						public List<UnitRulesItem> UnitRules { get; set; }

						public class UnitRulesItem
						{
							[JsonPropertyName("unit_id")]
							[Description("度量衡单位id")]
							public long UnitId { get; set; }

							[JsonPropertyName("min")]
							[Description("最小值")]
							public decimal Min { get; set; }

							[JsonPropertyName("max")]
							[Description("最大值")]
							public decimal Max { get; set; }
						}
					}
				}
			}

			[JsonPropertyName("need_paging_query_value")]
			[Description("是否需要二次查询规格值")]
			public bool NeedPagingQueryValue { get; set; }

			[JsonPropertyName("navigation_properties")]
			[Description("导航属性")]
			public List<NavigationPropertiesItem> NavigationProperties { get; set; }

			public class NavigationPropertiesItem
			{
				[JsonPropertyName("property_id")]
				[Description("导航属性id")]
				public long PropertyId { get; set; }

				[JsonPropertyName("property_name")]
				[Description("导航属性名称")]
				public string PropertyName { get; set; }
			}

			[JsonPropertyName("property_default_display")]
			[Description("1")]
			public bool PropertyDefaultDisplay { get; set; }
		}

		[JsonPropertyName("max_spec_num_limit")]
		[Description("最大可支持的规格层级数量")]
		public long MaxSpecNumLimit { get; set; }

		[JsonPropertyName("spec_combination_limit")]
		[Description("sku组合数量上限")]
		public long SpecCombinationLimit { get; set; }

		[JsonPropertyName("spec_single_limit")]
		[Description("单个规格的规格值数量上限")]
		public long SpecSingleLimit { get; set; }

		[JsonPropertyName("support_property_diy")]
		[Description("是否支持规格项自定义")]
		public bool SupportPropertyDiy { get; set; }
	}

	[JsonPropertyName("component_template_rule")]
	[Description("商品尺码模板配置规则")]
	public ComponentTemplateRuleItem ComponentTemplateRule { get; set; }

	public class ComponentTemplateRuleItem
	{
		[JsonPropertyName("is_show")]
		[Description("是否展示尺码信息")]
		public bool IsShow { get; set; }

		[JsonPropertyName("must_input")]
		[Description("尺码信息是否必填")]
		public bool MustInput { get; set; }
	}

	[JsonPropertyName("main_image_three_to_four_rule")]
	[Description("商品主图3:4配置规则")]
	public MainImageThreeToFourRuleItem MainImageThreeToFourRule { get; set; }

	public class MainImageThreeToFourRuleItem
	{
		[JsonPropertyName("is_show")]
		[Description("是否展示主图3:4信息")]
		public bool IsShow { get; set; }

		[JsonPropertyName("must_input")]
		[Description("主图3:4信息是否必填")]
		public bool MustInput { get; set; }
	}

	[JsonPropertyName("gold_price_rule")]
	[Description("金价信息，计价金类目下sku价格可以按照公式进行计算（价格=克重*每克价格+加工费），本字段提供相关信息")]
	public GoldPriceRuleItem GoldPriceRule { get; set; }

	public class GoldPriceRuleItem
	{
		[JsonPropertyName("price_rules")]
		[Description("价格规则信息，内有黄金的不同的单位价格以及枚举")]
		public List<PriceRulesItem> PriceRules { get; set; }

		public class PriceRulesItem
		{
			[JsonPropertyName("can_select")]
			[Description("是否可选，true表示可选，false表示不可选，如果不可选则表示商家没有设置过基础金价，需要前往抖店后台设置")]
			public bool CanSelect { get; set; }

			[JsonPropertyName("desc")]
			[Description("金价描述")]
			public string Desc { get; set; }

			[JsonPropertyName("value")]
			[Description("每克重黄金对应的价格，单位：分")]
			public long Value { get; set; }

			[JsonPropertyName("type")]
			[Description("价格规则枚举：,1是投资金,2是首饰金")]
			public long Type { get; set; }
		}

		[JsonPropertyName("sell_property_id")]
		[Description("销售属性（规格）id，价格基于这个规格填写的数值按照公式进行计算")]
		public string SellPropertyId { get; set; }

		[JsonPropertyName("is_required")]
		[Description("是否必填，true表示必填，false表示非必填")]
		public bool IsRequired { get; set; }

		[JsonPropertyName("is_show")]
		[Description("是否需要展示（可填），true表示需要展示（可填），false表示无需展示（不可填）")]
		public bool IsShow { get; set; }
	}

	[JsonPropertyName("extra_rule")]
	[Description("其他规则")]
	public ExtraRuleItem ExtraRule { get; set; }

	public class ExtraRuleItem
	{
		[JsonPropertyName("c2b_customize_rule")]
		[Description("c2b定制相关规则")]
		public C2bCustomizeRuleItem C2bCustomizeRule { get; set; }

		public class C2bCustomizeRuleItem
		{
			[JsonPropertyName("selected_fulfillment_rule")]
			[Description("支持c2b定制时可用的履约规则")]
			public SelectedFulfillmentRuleItem SelectedFulfillmentRule { get; set; }

			public class SelectedFulfillmentRuleItem
			{
				[JsonPropertyName("normal_rule")]
				[Description("支持c2b定制时可用的发货规则")]
				public NormalRuleItem NormalRule { get; set; }

				public class NormalRuleItem
				{
					[JsonPropertyName("description")]
					[Description("描述信息")]
					public string Description { get; set; }

					[JsonPropertyName("delay_options")]
					[Description("可用的延迟发货天数")]
					public List<long> DelayOptions { get; set; }

					[JsonPropertyName("deny_description")]
					[Description("不可用信息")]
					public string DenyDescription { get; set; }

					[JsonPropertyName("display")]
					[Description("是否可见")]
					public string Display { get; set; }

					[JsonPropertyName("support")]
					[Description("是否支持")]
					public string Support { get; set; }
				}
			}

			[JsonPropertyName("app_list")]
			[Description("可选小程序")]
			public List<AppListItem> AppList { get; set; }

			public class AppListItem
			{
				[JsonPropertyName("name")]
				[Description("小程序名称")]
				public string Name { get; set; }

				[JsonPropertyName("value")]
				[Description("小程序id")]
				public string Value { get; set; }
			}

			[JsonPropertyName("supply_day_return_selector")]
			[Description("支持c2b定制时可用的7天无理由")]
			public List<SupplyDayReturnSelectorItem> SupplyDayReturnSelector { get; set; }

			public class SupplyDayReturnSelectorItem
			{
				[JsonPropertyName("name")]
				[Description("7天无理由选项名称")]
				public string Name { get; set; }

				[JsonPropertyName("value")]
				[Description("7天无理由选项值")]
				public string Value { get; set; }
			}

			[JsonPropertyName("enable")]
			[Description("是否支持c2b定制")]
			public bool Enable { get; set; }
		}
	}

	[JsonPropertyName("trade_rule")]
	[Description("交易相关的规则")]
	public TradeRuleItem TradeRule { get; set; }

	public class TradeRuleItem
	{
		[JsonPropertyName("support_auto_charge_rule")]
		[Description("自动充值相关的规则")]
		public SupportAutoChargeRuleItem SupportAutoChargeRule { get; set; }

		public class SupportAutoChargeRuleItem
		{
			[JsonPropertyName("value")]
			[Description("是否支持自动充值")]
			public bool Value { get; set; }

			[JsonPropertyName("disabled")]
			[Description("1")]
			public bool Disabled { get; set; }
		}
	}

	[JsonPropertyName("sku_rule")]
	[Description("sku规则")]
	public SkuRuleItem SkuRule { get; set; }

	public class SkuRuleItem
	{
		[JsonPropertyName("sku_classification_rule")]
		[Description("sku分类信息填写规则")]
		public SkuClassificationRuleItem SkuClassificationRule { get; set; }

		public class SkuClassificationRuleItem
		{
			[JsonPropertyName("options")]
			[Description("sku分类信息扩展项")]
			public List<OptionsItem> Options { get; set; }

			public class OptionsItem
			{
				[JsonPropertyName("example")]
				[Description("sku分类对应举例")]
				public string Example { get; set; }

				[JsonPropertyName("description")]
				[Description("sku分类对应介绍")]
				public string Description { get; set; }

				[JsonPropertyName("value")]
				[Description("sku分类枚举信息")]
				public string Value { get; set; }

				[JsonPropertyName("name")]
				[Description("sku分类信息中文名称")]
				public string Name { get; set; }
			}

			[JsonPropertyName("must_select")]
			[Description("sku分类信息是否必填")]
			public bool MustSelect { get; set; }

			[JsonPropertyName("enable")]
			[Description("是否允许填写sku分类信息")]
			public bool Enable { get; set; }
		}
	}
}
