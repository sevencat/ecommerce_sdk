namespace ecommerce.sdk.douyin;

[Description("运力呼叫询价（逆向）/运力取消询价（逆向）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统服务异常,请重试","isp.service-error:20100","读操作数据库异常")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40100","参数错误")]
[DouyinRetCode(20000,"系统错误","请求内部服务异常,请重试","isp.service-error:20200","请求内部服务异常,请重试")]
[DouyinRetCode(50002,"业务处理失败","op not found","isv.business-failed:20201","op not found")]
[DouyinRetCode(50002,"业务处理失败","业务错误，此状态下不可重试","isv.business-failed:50300","业务错误，此状态下不可重试")]
public class SupermGetPlatformPickUpEstimatedChargeReq : IDouyinReq<SupermGetPlatformPickUpEstimatedChargeRsp>
{

	public string GetMethod() { return "superm.getPlatformPickUpEstimatedCharge"; }

	public string GetUrl() { return "/superm/getPlatformPickUpEstimatedCharge"; }

	[JsonPropertyName("aftersale_id")]
	[Description("售后单ID")]
	[NotNull]
	public long? AftersaleId { get; set; }

	[JsonPropertyName("selected_calendar_period")]
	[Description("查询的时间段")]
	public SelectedCalendarPeriodItem SelectedCalendarPeriod { get; set; }

	public class SelectedCalendarPeriodItem
	{
		[JsonPropertyName("time_begin_ts")]
		[Description("时间段开始时间；Unix时间戳，单位：秒")]
		[NotNull]
		public long? TimeBeginTs { get; set; }

		[JsonPropertyName("time_end_ts")]
		[Description("时间段结束时间；Unix时间戳，单位：秒")]
		[NotNull]
		public long? TimeEndTs { get; set; }
	}

	[JsonPropertyName("dispatcher_fee_type")]
	[Description("查询的费用类型；1 -呼叫运力费用；2-取消运力费用")]
	[NotNull]
	public int? DispatcherFeeType { get; set; }
}

[Description("运力呼叫询价（逆向）/运力取消询价（逆向）")]
public class SupermGetPlatformPickUpEstimatedChargeRsp
{
	[JsonPropertyName("dispatcher_fee")]
	[Description("运力费用预估，单位：分")]
	public long DispatcherFee { get; set; }
}
