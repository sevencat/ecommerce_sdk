namespace ecommerce.sdk.douyin;

[Description("用户编辑已经存在的限售模版时更新")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","数组越界异常","isv.business-failed:20001","模版更新时需要选择限购纬度")]
public class TradeUpdateTradeLimitTemplateReq : IDouyinReq<TradeUpdateTradeLimitTemplateRsp>
{

	public string GetMethod() { return "trade.UpdateTradeLimitTemplate"; }

	public string GetUrl() { return "/trade/UpdateTradeLimitTemplate"; }

	[JsonPropertyName("trade_limit_template_id")]
	[Description("限购模板ID")]
	[NotNull]
	public long? TradeLimitTemplateId { get; set; }

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
			[JsonPropertyName("time_period_pattern")]
			[Description("限购时间类型")]
			[NotNull]
			public int? TimePeriodPattern { get; set; }

			[JsonPropertyName("time_period_fixed")]
			[Description("限购时间滑动窗口")]
			public TimePeriodFixedItem TimePeriodFixed { get; set; }

			public class TimePeriodFixedItem
			{
				[JsonPropertyName("start_time")]
				[Description("开始时间")]
				[NotNull]
				public long? StartTime { get; set; }

				[JsonPropertyName("end_time")]
				[Description("结束时间")]
				[NotNull]
				public long? EndTime { get; set; }
			}
		}

		[JsonPropertyName("trade_limit_subject_lisit")]
		[Description("限购维度1 // 端用户（比如uid=122，aid=1128） 2 // 用户组用户（比如uid=122，group=aweme） 3 // 设备 4 // 下单电话 5 // 收件电话 6 // 身份证号 7 // 支付账号")]
		[NotNull]
		public List<int> TradeLimitSubjectLisit { get; set; }
	}
}

[Description("用户编辑已经存在的限售模版时更新")]
public class TradeUpdateTradeLimitTemplateRsp
{
	[JsonPropertyName("trade_limit_template_id")]
	[Description("限购模板ID")]
	public long TradeLimitTemplateId { get; set; }
}
