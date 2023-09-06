namespace ecommerce.sdk.douyin;

[Description("呼叫运力售后取件")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40100","参数错误")]
[DouyinRetCode(20000,"系统错误","请求内部服务异常,请重试","isp.service-error:20200","请求内部服务异常,请重试")]
[DouyinRetCode(20000,"系统错误","虚拟号生成异常","isp.service-error:20213","虚拟号生成异常")]
[DouyinRetCode(20000,"系统错误","请求内部服务异常,请重试","isp.service-error:20201","请求内部服务异常,请重试")]
[DouyinRetCode(50002,"业务处理失败","拓展字段校验不通过","isv.business-failed:50400","拓展字段校验不通过")]
[DouyinRetCode(50002,"业务处理失败","业务错误，此状态下不可重试","isv.business-failed:50300","业务错误，此状态下不可重试")]
public class SupermApplyPlatformPickUpReq : IDouyinReq<SupermApplyPlatformPickUpRsp>
{

	public string GetMethod() { return "superm.applyPlatformPickUp"; }

	public string GetUrl() { return "/superm/applyPlatformPickUp"; }

	[JsonPropertyName("aftersale_id")]
	[Description("售后单ID")]
	[NotNull]
	public long? AftersaleId { get; set; }

	[JsonPropertyName("selected_calendar_period")]
	[Description("运力呼叫时间段")]
	public SelectedCalendarPeriodItem SelectedCalendarPeriod { get; set; }

	public class SelectedCalendarPeriodItem
	{
		[JsonPropertyName("time_begin_ts")]
		[Description("时间段开始时间")]
		[NotNull]
		public long? TimeBeginTs { get; set; }

		[JsonPropertyName("time_end_ts")]
		[Description("时间段结束时间")]
		[NotNull]
		public long? TimeEndTs { get; set; }
	}
}

[Description("呼叫运力售后取件")]
public class SupermApplyPlatformPickUpRsp
{
	[JsonPropertyName("logistics_id")]
	[Description("物流单ID")]
	public string LogisticsId { get; set; }
}
