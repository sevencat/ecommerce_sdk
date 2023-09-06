namespace ecommerce.sdk.douyin;

[Description("供应商回传虚拟号短信结果")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:-1","重试")]
public class LogisticsVirtualServicePushSmsReq : IDouyinReq<LogisticsVirtualServicePushSmsRsp>
{

	public string GetMethod() { return "logistics.virtualServicePushSms"; }

	public string GetUrl() { return "/logistics/virtualServicePushSms"; }

	[JsonPropertyName("request_id")]
	[Description("请求id")]
	[NotNull]
	public string RequestId { get; set; }

	[JsonPropertyName("record_id")]
	[Description("服务商短信记录id")]
	[NotNull]
	public string RecordId { get; set; }

	[JsonPropertyName("service_code")]
	[Description("服务商身份标识")]
	[NotNull]
	public string ServiceCode { get; set; }

	[JsonPropertyName("tel_a")]
	[Description("A真实号码")]
	[NotNull]
	public string TelA { get; set; }

	[JsonPropertyName("tel_x")]
	[Description("虚拟主号")]
	[NotNull]
	public string TelX { get; set; }

	[JsonPropertyName("tel_b")]
	[Description("B真实号码")]
	[NotNull]
	public string TelB { get; set; }

	[JsonPropertyName("sub_id")]
	[Description("绑定关系id")]
	public string SubId { get; set; }

	[JsonPropertyName("send_type")]
	[Description("13：话单中A号码接收短信 14：话单中A号码发送短信 30：无绑定关系的短信")]
	[NotNull]
	public string SendType { get; set; }

	[JsonPropertyName("area_code")]
	[Description("区域")]
	public string AreaCode { get; set; }

	[JsonPropertyName("receive_time")]
	[Description("短信接收时间")]
	[NotNull]
	public string ReceiveTime { get; set; }

	[JsonPropertyName("sms_content")]
	[Description("短信内容")]
	[NotNull]
	public string SmsContent { get; set; }

	[JsonPropertyName("sms_result")]
	[Description("发送状态")]
	[NotNull]
	public string SmsResult { get; set; }

	[JsonPropertyName("sms_num")]
	[Description("短信条数")]
	[NotNull]
	public int? SmsNum { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("ext")]
	[Description("扩展字段")]
	public string Ext { get; set; }

	[JsonPropertyName("tel_xext")]
	[Description("分机号")]
	public string TelXext { get; set; }
}

[Description("供应商回传虚拟号短信结果")]
public class LogisticsVirtualServicePushSmsRsp
{
	[JsonPropertyName("success")]
	[Description("是否成功")]
	public bool Success { get; set; }
}
