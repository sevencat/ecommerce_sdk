namespace ecommerce.sdk.douyin;

[Description("创建限售规则模板")]
[DouyinRetCode(10000,"success","","","")]
public class TradeCreateTradeLimitTemplateReq : IDouyinReq<TradeCreateTradeLimitTemplateRsp>
{

	public string GetMethod() { return "trade.createTradeLimitTemplate"; }

	public string GetUrl() { return "/trade/createTradeLimitTemplate"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	public long? StoreId { get; set; }

	[JsonPropertyName("trade_limit_rule_request_list")]
	[Description("限购参数")]
	[NotNull]
	public List<TradeLimitRuleRequestListItem> TradeLimitRuleRequestList { get; set; }

	public class TradeLimitRuleRequestListItem
	{
		[JsonPropertyName("trade_limit_model")]
		[Description("限购模型 1-重量，2-数量，3-地区，4-金额")]
		[NotNull]
		public int? TradeLimitModel { get; set; }

		[JsonPropertyName("trade_limit_resource")]
		[Description("限购资源类别1-抖店，2-门店，3-商品ID，4-sku,5-类目，6-活动，7-商品标")]
		[NotNull]
		public int? TradeLimitResource { get; set; }

		[JsonPropertyName("trade_limit_resource_object")]
		[Description("限购资源值")]
		public TradeLimitResourceObjectItem TradeLimitResourceObject { get; set; }

		public class TradeLimitResourceObjectItem
		{
			[JsonPropertyName("trade_limit_resource_id_list")]
			[Description("限购资源值列表")]
			public List<string> TradeLimitResourceIdList { get; set; }
		}

		[JsonPropertyName("trade_limit_pattern")]
		[Description("限购值，模型为重量则单位为毫克，模型为金额则单位为分")]
		[NotNull]
		public TradeLimitPatternItem TradeLimitPattern { get; set; }

		public class TradeLimitPatternItem
		{
			[JsonPropertyName("minimum")]
			[Description("单次下限")]
			[NotNull]
			public long? Minimum { get; set; }

			[JsonPropertyName("maximum")]
			[Description("单次上限")]
			[NotNull]
			public long? Maximum { get; set; }

			[JsonPropertyName("cumulative_max")]
			[Description("累计限购值")]
			[NotNull]
			public long? CumulativeMax { get; set; }
		}

		[JsonPropertyName("time_period")]
		[Description("限购时间")]
		public TimePeriodItem TimePeriod { get; set; }

		public class TimePeriodItem
		{
			[JsonPropertyName("start_time")]
			[Description("限购开始时间")]
			public long? StartTime { get; set; }

			[JsonPropertyName("end_time")]
			[Description("限购结束时间")]
			public long? EndTime { get; set; }

			[JsonPropertyName("limit_period")]
			[Description("限购滑动窗口时长")]
			public long? LimitPeriod { get; set; }

			[JsonPropertyName("limit_period_end_time")]
			[Description("限购滑动窗口结束时间")]
			public long? LimitPeriodEndTime { get; set; }
		}

		[JsonPropertyName("trade_limit_subject_list")]
		[Description("限购维度1 // 端用户（比如uid=122，aid=1128）        2 // 用户组用户（比如uid=122，group=aweme） 3 // 设备 4 // 下单电话 5 // 收件电话 6 // 身份证号 7 // 支付账号")]
		[NotNull]
		public List<int> TradeLimitSubjectList { get; set; }
	}
}

[Description("创建限售规则模板")]
public class TradeCreateTradeLimitTemplateRsp
{
	[JsonPropertyName("trade_limit_id")]
	[Description("限购模板ID")]
	public long TradeLimitId { get; set; }
}
