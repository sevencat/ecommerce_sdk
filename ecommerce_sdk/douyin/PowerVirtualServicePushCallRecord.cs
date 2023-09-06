namespace ecommerce.sdk.douyin;

[Description("略")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:-1","重试")]
public class PowerVirtualServicePushCallRecordReq : IDouyinReq<PowerVirtualServicePushCallRecordRsp>
{

	public string GetMethod() { return "power.virtualServicePushCallRecord"; }

	public string GetUrl() { return "/power/virtualServicePushCallRecord"; }

	[JsonPropertyName("request_id")]
	[Description("-")]
	[NotNull]
	public string RequestId { get; set; }

	[JsonPropertyName("service_code")]
	[Description("-")]
	[NotNull]
	public string ServiceCode { get; set; }

	[JsonPropertyName("tel_a")]
	[Description("-")]
	[NotNull]
	public string TelA { get; set; }

	[JsonPropertyName("tel_x")]
	[Description("-")]
	[NotNull]
	public string TelX { get; set; }

	[JsonPropertyName("tel_b")]
	[Description("-")]
	[NotNull]
	public string TelB { get; set; }

	[JsonPropertyName("tel_y")]
	[Description("-")]
	public string TelY { get; set; }

	[JsonPropertyName("subid")]
	[Description("-")]
	public string Subid { get; set; }

	[JsonPropertyName("calltype")]
	[Description("-")]
	[NotNull]
	public string Calltype { get; set; }

	[JsonPropertyName("calltime")]
	[Description("-")]
	[NotNull]
	public string Calltime { get; set; }

	[JsonPropertyName("ringingtime")]
	[Description("-")]
	[NotNull]
	public string Ringingtime { get; set; }

	[JsonPropertyName("starttime")]
	[Description("-")]
	[NotNull]
	public string Starttime { get; set; }

	[JsonPropertyName("releasetime")]
	[Description("-")]
	[NotNull]
	public string Releasetime { get; set; }

	[JsonPropertyName("call_duration")]
	[Description("-")]
	public int? CallDuration { get; set; }

	[JsonPropertyName("ringing_duration")]
	[Description("-")]
	public int? RingingDuration { get; set; }

	[JsonPropertyName("callid")]
	[Description("-")]
	[NotNull]
	public string Callid { get; set; }

	[JsonPropertyName("releasedir")]
	[Description("-")]
	public string Releasedir { get; set; }

	[JsonPropertyName("releasecause")]
	[Description("-")]
	public string Releasecause { get; set; }

	[JsonPropertyName("calldisplay")]
	[Description("-")]
	public string Calldisplay { get; set; }

	[JsonPropertyName("callrecording")]
	[Description("-")]
	public string Callrecording { get; set; }

	[JsonPropertyName("recordurl")]
	[Description("-")]
	public string Recordurl { get; set; }

	[JsonPropertyName("ringingrecordurl")]
	[Description("-")]
	public string Ringingrecordurl { get; set; }

	[JsonPropertyName("areacode")]
	[Description("-")]
	public string Areacode { get; set; }

	[JsonPropertyName("remark")]
	[Description("-")]
	public string Remark { get; set; }

	[JsonPropertyName("tel_xext")]
	[Description("-")]
	public string TelXext { get; set; }

	[JsonPropertyName("collect_num_time")]
	[Description("-")]
	public string CollectNumTime { get; set; }

	[JsonPropertyName("callstate")]
	[Description("-")]
	public string Callstate { get; set; }

	[JsonPropertyName("ext")]
	[Description("-")]
	public string Ext { get; set; }
}

[Description("略")]
public class PowerVirtualServicePushCallRecordRsp
{
	[JsonPropertyName("success")]
	[Description("-")]
	public bool Success { get; set; }
}
