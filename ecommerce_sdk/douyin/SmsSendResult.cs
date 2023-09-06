namespace ecommerce.sdk.douyin;

[Description("查询短信发送结果")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","超时，请重试","isp.service-error:500","超时，请重试")]
[DouyinRetCode(50002,"业务处理失败","响应结果不符合预期","isv.business-failed:628005100","请根据错误信息描述检查")]
[DouyinRetCode(20000,"系统错误","628004205:Redis Get错误","isp.service-error:628004205","系统内部错误，请重试")]
[DouyinRetCode(50002,"业务处理失败","628002001:您输入参数不正确，请检查后重试","isv.business-failed:628002001","业务错误，请检查")]
[DouyinRetCode(50002,"业务处理失败","628004002:请求超时","isv.business-failed:628004002","请求超时，请重试")]
public class SmsSendResultReq : IDouyinReq<SmsSendResultRsp>
{

	public string GetMethod() { return "sms.sendResult"; }

	public string GetUrl() { return "/sms/sendResult"; }

	[JsonPropertyName("from_time")]
	[Description("开始时间-时间戳，单位秒")]
	[NotNull]
	public long? FromTime { get; set; }

	[JsonPropertyName("to_time")]
	[Description("结束时间-时间戳，单位秒")]
	[NotNull]
	public long? ToTime { get; set; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("template_id")]
	[Description("模版id")]
	public string TemplateId { get; set; }

	[JsonPropertyName("status")]
	[Description("发送状态： 未回执：1 发送失败：2 发送成功：3")]
	public long? Status { get; set; }

	[JsonPropertyName("size")]
	[Description("查询结果大小，默认是10")]
	public long? Size { get; set; }

	[JsonPropertyName("page")]
	[Description("查询结果页数，从0开始，默认是0")]
	public long? Page { get; set; }

	[JsonPropertyName("sign")]
	[Description("签名内容")]
	public string Sign { get; set; }

	[JsonPropertyName("post_tel")]
	[Description("既支持明文，又支持密文")]
	public string PostTel { get; set; }

	[JsonPropertyName("message_id")]
	[Description("消息的唯一标识，可以用于查询短信到达等")]
	public string MessageId { get; set; }

	[JsonPropertyName("tpl_type")]
	[Description("查询短信类型，默认是查普通文本短信：,0是查询所有类型短信，1是查询普通文本短信，2是查询视频短信")]
	public long? TplType { get; set; }
}

[Description("查询短信发送结果")]
public class SmsSendResultRsp
{
	[JsonPropertyName("total")]
	[Description("数量")]
	public long Total { get; set; }

	[JsonPropertyName("sms_send_result_list")]
	[Description("短信结果列表")]
	public List<SmsSendResultListItem> SmsSendResultList { get; set; }

	public class SmsSendResultListItem
	{
		[JsonPropertyName("send_time")]
		[Description("发送时间-时间戳，单位秒")]
		public long SendTime { get; set; }

		[JsonPropertyName("sms_content")]
		[Description("短信内容")]
		public string SmsContent { get; set; }

		[JsonPropertyName("status")]
		[Description("未回执：1 发送失败：2 发送成功：3")]
		public long Status { get; set; }

		[JsonPropertyName("count")]
		[Description("计费条数，如果短信过长，会分多次计费")]
		public long Count { get; set; }

		[JsonPropertyName("code")]
		[Description("错误码")]
		public long Code { get; set; }

		[JsonPropertyName("message")]
		[Description("错误说明")]
		public string Message { get; set; }

		[JsonPropertyName("message_id")]
		[Description("消息ID")]
		public string MessageId { get; set; }

		[JsonPropertyName("tag")]
		[Description("透传字段，回执的时候原样返回给调用方。")]
		public string Tag { get; set; }
	}
}
