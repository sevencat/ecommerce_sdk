namespace ecommerce.sdk.douyin;

[Description("服务商预约事件")]
public class LogisticsOperatorAppointmentEventRequestReq : IDouyinReq<LogisticsOperatorAppointmentEventRequestRsp>
{

	public string GetMethod() { return "logistics.operatorAppointmentEventRequest"; }

	public string GetUrl() { return "/logistics/operatorAppointmentEventRequest"; }

	[JsonPropertyName("service_code")]
	[Description("SVC-WBTRADEIN")]
	[NotNull]
	public string ServiceCode { get; set; }

	[JsonPropertyName("operation_no")]
	[Description("操作单ID")]
	[NotNull]
	public string OperationNo { get; set; }

	[JsonPropertyName("appointment_time")]
	[Description("预约时间")]
	public string AppointmentTime { get; set; }

	[JsonPropertyName("operation_time")]
	[Description("操作时间")]
	public string OperationTime { get; set; }

	[JsonPropertyName("service_entity_code")]
	[Description("服务实体编码，需和研发确认")]
	public string ServiceEntityCode { get; set; }
}

[Description("服务商预约事件")]
public class LogisticsOperatorAppointmentEventRequestRsp
{
}
