namespace ecommerce.sdk.douyin;

[Description("虚拟号服务商通话记录回传")]
public class LogisticsVirtualServicePushCallRecordReq : IDouyinReq<LogisticsVirtualServicePushCallRecordRsp>
{

	public string GetMethod() { return "logistics.virtualServicePushCallRecord"; }

	public string GetUrl() { return "/logistics/virtualServicePushCallRecord"; }

	[JsonPropertyName("request_id")]
	[Description("业务id")]
	[NotNull]
	public string RequestId { get; set; }

	[JsonPropertyName("service_code")]
	[Description("服务商标识")]
	[NotNull]
	public string ServiceCode { get; set; }

	[JsonPropertyName("tel_a")]
	[Description("被叫号码")]
	[NotNull]
	public string TelA { get; set; }

	[JsonPropertyName("tel_x")]
	[Description("虚拟主号")]
	[NotNull]
	public string TelX { get; set; }

	[JsonPropertyName("tel_b")]
	[Description("主叫号码")]
	[NotNull]
	public string TelB { get; set; }

	[JsonPropertyName("tel_y")]
	[Description("来显号码")]
	public string TelY { get; set; }

	[JsonPropertyName("sub_id")]
	[Description("绑定id")]
	public string SubId { get; set; }

	[JsonPropertyName("call_type")]
	[Description("10：A号主叫，即A回呼 11：A号被叫，即A呼入 12：未输入分机号放弃呼叫 20：无绑定关系，即Xx无绑定号码")]
	[NotNull]
	public string CallType { get; set; }

	[JsonPropertyName("call_time")]
	[Description("发起呼叫时间 格式: yyyy-MM-dd HH:mm:ss")]
	[NotNull]
	public string CallTime { get; set; }

	[JsonPropertyName("ringing_time")]
	[Description("振铃开始时间格式: yyyy-MM-dd HH:mm:ss")]
	[NotNull]
	public string RingingTime { get; set; }

	[JsonPropertyName("start_time")]
	[Description("通话开始时间格式: yyyy-MM-dd HH:mm:ss")]
	[NotNull]
	public string StartTime { get; set; }

	[JsonPropertyName("release_time")]
	[Description("通话结束时间格式: yyyy-MM-dd HH:mm:ss")]
	[NotNull]
	public string ReleaseTime { get; set; }

	[JsonPropertyName("call_duration")]
	[Description("通话时长")]
	[NotNull]
	public int? CallDuration { get; set; }

	[JsonPropertyName("ringing_duration")]
	[Description("振铃时长")]
	[NotNull]
	public int? RingingDuration { get; set; }

	[JsonPropertyName("call_id")]
	[Description("通话标识")]
	[NotNull]
	public string CallId { get; set; }

	[JsonPropertyName("release_dir")]
	[Description("释放方向1表示主叫, 2表示被叫，0表示平台释放")]
	[NotNull]
	public string ReleaseDir { get; set; }

	[JsonPropertyName("release_cause")]
	[Description("释放原因")]
	public string ReleaseCause { get; set; }

	[JsonPropertyName("call_display")]
	[Description("来显控制当其他号码为主叫时，是否在被叫上显示其他号码的真实号码。 0：不显示真实号码；1：显示真实号码。默认是0不显示真实号码")]
	[NotNull]
	public string CallDisplay { get; set; }

	[JsonPropertyName("call_recording")]
	[Description("录音控制")]
	[NotNull]
	public string CallRecording { get; set; }

	[JsonPropertyName("record_url")]
	[Description("通话录音地址")]
	public string RecordUrl { get; set; }

	[JsonPropertyName("ringing_record_url")]
	[Description("振铃录音地址")]
	public string RingingRecordUrl { get; set; }

	[JsonPropertyName("area_code")]
	[Description("对应绑定请求中areacode")]
	public string AreaCode { get; set; }

	[JsonPropertyName("remark")]
	[Description("接入商自有字段")]
	public string Remark { get; set; }

	[JsonPropertyName("tel_xext")]
	[Description("四位分机号")]
	public string TelXext { get; set; }

	[JsonPropertyName("collect_num_time")]
	[Description("发起收号时获取的时间。格式YYYY-MM-DD HH:mm:SS")]
	public string CollectNumTime { get; set; }

	[JsonPropertyName("call_state")]
	[Description("呼叫状态 ANSWERED通话成功，被叫接通，双方成功建立通话 BUSY被叫正忙 NO_ANSWER被叫无应答 REJECT被叫拒接 HANGUP主叫放弃 INVALID_NUMBER空号，话务平台返回的号码是空号，非返回字段为空 POWER_OFF被叫关机 UNAVAILABLE被叫暂时无法接听，不在服务区、暂时无法接通（不关机拔电池）等SUSPEND被叫停机 NO_BINDING无绑定关系 BANNED无权呼叫 OTHER其他失败情形")]
	[NotNull]
	public string CallState { get; set; }

	[JsonPropertyName("ext")]
	[Description("额外字段")]
	public string Ext { get; set; }
}

[Description("虚拟号服务商通话记录回传")]
public class LogisticsVirtualServicePushCallRecordRsp
{
	[JsonPropertyName("success")]
	[Description("是否成功")]
	public bool Success { get; set; }
}
