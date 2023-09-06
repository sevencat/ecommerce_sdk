namespace ecommerce.sdk.douyin;

[Description("虚拟号服务商回传虚拟号接通事件")]
public class PowerHandleVirtualTelConnectReq : IDouyinReq<PowerHandleVirtualTelConnectRsp>
{

	public string GetMethod() { return "power.HandleVirtualTelConnect"; }

	public string GetUrl() { return "/power/HandleVirtualTelConnect"; }

	[JsonPropertyName("request_id")]
	[Description("请求id")]
	[NotNull]
	public string RequestId { get; set; }

	[JsonPropertyName("service_code")]
	[Description("服务商code")]
	[NotNull]
	public string ServiceCode { get; set; }

	[JsonPropertyName("callid")]
	[Description("通话id")]
	public string Callid { get; set; }

	[JsonPropertyName("tel_a")]
	[Description("A号码")]
	public string TelA { get; set; }

	[JsonPropertyName("tel_x")]
	[Description("X号码")]
	public string TelX { get; set; }

	[JsonPropertyName("tel_b")]
	[Description("B号码")]
	public string TelB { get; set; }

	[JsonPropertyName("tel_y")]
	[Description("Y号码")]
	public string TelY { get; set; }

	[JsonPropertyName("subid")]
	[Description("绑定id")]
	public string Subid { get; set; }

	[JsonPropertyName("calltype")]
	[Description("呼叫类型")]
	public string Calltype { get; set; }

	[JsonPropertyName("calltime")]
	[Description("呼叫时间（已废弃，请传下方的eventTime字段）")]
	public string Calltime { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("tel_xext")]
	[Description("分机号")]
	public string TelXext { get; set; }

	[JsonPropertyName("collect_num_time")]
	[Description("时间(可不传，废弃字段)")]
	public string CollectNumTime { get; set; }

	[JsonPropertyName("ext")]
	[Description("拓展字段")]
	public string Ext { get; set; }

	[JsonPropertyName("event_type")]
	[Description("事件类型（1开始呼叫、2被叫方振铃、3呼叫建立、4呼叫结束）")]
	public int? EventType { get; set; }

	[JsonPropertyName("all_event_type")]
	[Description("本次通话全部的通话事件（正常接通挂断的情况下）")]
	public List<int> AllEventType { get; set; }

	[JsonPropertyName("event_time")]
	[Description("事件发生时间的时间戳（单位：秒）")]
	public long? EventTime { get; set; }
}

[Description("虚拟号服务商回传虚拟号接通事件")]
public class PowerHandleVirtualTelConnectRsp
{
	[JsonPropertyName("success")]
	[Description("成功")]
	public bool Success { get; set; }
}
