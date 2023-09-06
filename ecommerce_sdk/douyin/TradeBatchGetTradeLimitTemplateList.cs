namespace ecommerce.sdk.douyin;

[Description("批量查询限购模板")]
[DouyinRetCode(10000,"success","","","")]
public class TradeBatchGetTradeLimitTemplateListReq : IDouyinReq<TradeBatchGetTradeLimitTemplateListRsp>
{

	public string GetMethod() { return "trade.batchGetTradeLimitTemplateList"; }

	public string GetUrl() { return "/trade/batchGetTradeLimitTemplateList"; }

	[JsonPropertyName("trade_limit_template_id_list")]
	[Description("限购模板ID列表")]
	[NotNull]
	public List<long> TradeLimitTemplateIdList { get; set; }
}

[Description("批量查询限购模板")]
public class TradeBatchGetTradeLimitTemplateListRsp
{
	[JsonPropertyName("trade_limit_template_list")]
	[Description("限购模板信息列表")]
	public List<TradeLimitTemplateListItem> TradeLimitTemplateList { get; set; }

	public class TradeLimitTemplateListItem
	{
		[JsonPropertyName("trade_limit_template_id")]
		[Description("限购模板ID")]
		public long TradeLimitTemplateId { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺ID")]
		public long ShopId { get; set; }

		[JsonPropertyName("trade_limit_rule_list")]
		[Description("规则列表")]
		public List<TradeLimitRuleListItem> TradeLimitRuleList { get; set; }

		public class TradeLimitRuleListItem
		{
			[JsonPropertyName("trade_limit_model")]
			[Description("限购模型 1-重量，2-数量，3-地区，4-金额")]
			public int TradeLimitModel { get; set; }

			[JsonPropertyName("trade_limit_subject")]
			[Description("限购维度1 // 端用户（比如uid=122，aid=1128）        2 // 用户组用户（比如uid=122，group=aweme） 3 // 设备 4 // 下单电话 5 // 收件电话 6 // 身份证号 7 // 支付账号")]
			public int TradeLimitSubject { get; set; }

			[JsonPropertyName("trade_limit_resource")]
			[Description("限购资源类别1-抖店，2-门店，3-商品ID，4-sku,5-类目，6-活动，7-商品标")]
			public int TradeLimitResource { get; set; }

			[JsonPropertyName("trade_limit_resource_object")]
			[Description("限购资源值")]
			public TradeLimitResourceObjectItem TradeLimitResourceObject { get; set; }

			public class TradeLimitResourceObjectItem
			{
				[JsonPropertyName("trade_limit_resource_id_list")]
				[Description("限购资源具体值")]
				public List<string> TradeLimitResourceIdList { get; set; }

				[JsonPropertyName("product_category_list")]
				[Description("限购类目信息")]
				public List<ProductCategoryListItem> ProductCategoryList { get; set; }

				public class ProductCategoryListItem
				{
					[JsonPropertyName("first_cid")]
					[Description("一级类目")]
					public long FirstCid { get; set; }

					[JsonPropertyName("second_cid")]
					[Description("二级类目")]
					public long SecondCid { get; set; }

					[JsonPropertyName("thrid_cid")]
					[Description("三级类目")]
					public long ThridCid { get; set; }

					[JsonPropertyName("fourth_cid")]
					[Description("四级类目")]
					public long FourthCid { get; set; }
				}
			}

			[JsonPropertyName("trade_limit_pattern")]
			[Description("限购范围")]
			public TradeLimitPatternItem TradeLimitPattern { get; set; }

			public class TradeLimitPatternItem
			{
				[JsonPropertyName("minimum")]
				[Description("限购下限")]
				public long Minimum { get; set; }

				[JsonPropertyName("maximum")]
				[Description("限购上限")]
				public long Maximum { get; set; }

				[JsonPropertyName("cumulative_max")]
				[Description("累计限购")]
				public long CumulativeMax { get; set; }
			}

			[JsonPropertyName("time_period")]
			[Description("限购时间")]
			public TimePeriodItem TimePeriod { get; set; }

			public class TimePeriodItem
			{
				[JsonPropertyName("time_period_pattern")]
				[Description("限购时间类型 1固定起止时间 2滑动窗口")]
				public int TimePeriodPattern { get; set; }

				[JsonPropertyName("time_period_fixed")]
				[Description("限购时间段")]
				public TimePeriodFixedItem TimePeriodFixed { get; set; }

				public class TimePeriodFixedItem
				{
					[JsonPropertyName("start_time")]
					[Description("开始时间戳")]
					public long StartTime { get; set; }

					[JsonPropertyName("end_time")]
					[Description("结束时间戳")]
					public long EndTime { get; set; }

					[JsonPropertyName("cyclic")]
					[Description("是否循环")]
					public bool Cyclic { get; set; }

					[JsonPropertyName("cyclic_option")]
					[Description("循环参数")]
					public CyclicOptionItem CyclicOption { get; set; }

					public class CyclicOptionItem
					{
						[JsonPropertyName("cyclic_interval")]
						[Description("循环类别")]
						public int CyclicInterval { get; set; }

						[JsonPropertyName("expire_time")]
						[Description("过期时间")]
						public long ExpireTime { get; set; }

						[JsonPropertyName("frequency")]
						[Description("每Frequency个CyclicUnit循环一次")]
						public long Frequency { get; set; }

						[JsonPropertyName("cyclic_unit")]
						[Description("循环单位 1日 2周 3月 4年")]
						public int CyclicUnit { get; set; }
					}
				}

				[JsonPropertyName("time_period_sliding_window")]
				[Description("时间滑动窗口")]
				public TimePeriodSlidingWindowItem TimePeriodSlidingWindow { get; set; }

				public class TimePeriodSlidingWindowItem
				{
					[JsonPropertyName("window_size")]
					[Description("窗口大小，单位为S")]
					public long WindowSize { get; set; }

					[JsonPropertyName("time_shift")]
					[Description("滑动窗口结束时间距离Now的偏移量")]
					public long TimeShift { get; set; }
				}
			}
		}
	}
}
