namespace ecommerce.sdk.douyin;

[Description("逆向场景下通过售后单查询运力时间段日历，查询得到的时间片作为入参用于逆向运力费用的询价/superm/getPlatformPickUpEstimatedCharge和逆向运力的呼叫/superm/applyPlatformPickUp")]
public class SupermGetPlatformPickUpCalendarReq : IDouyinReq<SupermGetPlatformPickUpCalendarRsp>
{

	public string GetMethod() { return "superm.getPlatformPickUpCalendar"; }

	public string GetUrl() { return "/superm/getPlatformPickUpCalendar"; }

	[JsonPropertyName("aftersale_id")]
	[Description("售后单号")]
	[NotNull]
	public long? AftersaleId { get; set; }
}

[Description("逆向场景下通过售后单查询运力时间段日历，查询得到的时间片作为入参用于逆向运力费用的询价/superm/getPlatformPickUpEstimatedCharge和逆向运力的呼叫/superm/applyPlatformPickUp")]
public class SupermGetPlatformPickUpCalendarRsp
{
	[JsonPropertyName("is_support")]
	[Description("是否支持查询")]
	public bool IsSupport { get; set; }

	[JsonPropertyName("un_support_reason")]
	[Description("不支持的原因")]
	public string UnSupportReason { get; set; }

	[JsonPropertyName("period_list")]
	[Description("时间段")]
	public List<PeriodListItem> PeriodList { get; set; }

	public class PeriodListItem
	{
		[JsonPropertyName("time_begin_ts")]
		[Description("时间段开始时间；Unix时间戳，单位：秒")]
		public long TimeBeginTs { get; set; }

		[JsonPropertyName("time_end_ts")]
		[Description("时间段结束时间；Unix时间戳，单位：秒")]
		public long TimeEndTs { get; set; }
	}
}
