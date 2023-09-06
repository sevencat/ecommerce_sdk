namespace ecommerce.sdk.douyin;

[Description("查看短信签名")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","628004205:Redis Get错误","isp.service-error:628004205","系统内部错误，请重试")]
public class SmsSignSearchReq : IDouyinReq<SmsSignSearchRsp>
{

	public string GetMethod() { return "sms.sign.search"; }

	public string GetUrl() { return "/sms/sign/search"; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("like")]
	[Description("模糊搜索串")]
	public string Like { get; set; }

	[JsonPropertyName("size")]
	[Description("每页大小，默认10")]
	public long? Size { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，默认0")]
	public long? Page { get; set; }
}

[Description("查看短信签名")]
public class SmsSignSearchRsp
{
	[JsonPropertyName("sign_search_list")]
	[Description("签名列表")]
	public List<SignSearchListItem> SignSearchList { get; set; }

	public class SignSearchListItem
	{
		[JsonPropertyName("sms_account")]
		[Description("短信发送渠道，主要做资源隔离")]
		public string SmsAccount { get; set; }

		[JsonPropertyName("sign")]
		[Description("签名")]
		public string Sign { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
