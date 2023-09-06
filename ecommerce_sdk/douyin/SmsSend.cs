namespace ecommerce.sdk.douyin;

[Description("短信发送（注：游戏营销类短信目前暂不不支持发送）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数不合法","isv.parameter-invalid:5","参数不合法")]
[DouyinRetCode(20000,"系统错误","服务内部错误，请重试","isp.service-error:7","服务内部错误，请重试")]
[DouyinRetCode(20000,"系统错误","服务内部错误，请重试","isp.service-error:4","服务内部错误，请重试")]
[DouyinRetCode(20000,"系统错误","超时，请重试","isp.service-error:500","超时，请重试")]
[DouyinRetCode(20000,"系统错误","服务内部错误","isp.service-error:628004205","服务内部错误，请重试")]
[DouyinRetCode(20000,"系统错误","超时","isp.service-error:628004002","服务内部错误，请重试")]
[DouyinRetCode(50002,"业务处理失败","响应结果不符合预期","isv.business-failed:628005100","请根据错误信息描述检查")]
[DouyinRetCode(20000,"系统错误","服务内部错误","isp.service-error:628004001","服务内部错误，请重试")]
[DouyinRetCode(20000,"系统错误","服务内部错误","isp.service-error:628004702","服务内部错误，请重试")]
[DouyinRetCode(50002,"业务处理失败","密文解密错误","isv.business-failed:628002001","请检查密文信息")]
public class SmsSendReq : IDouyinReq<SmsSendRsp>
{

	public string GetMethod() { return "sms.send"; }

	public string GetUrl() { return "/sms/send"; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("sign")]
	[Description("签名")]
	[NotNull]
	public string Sign { get; set; }

	[JsonPropertyName("template_id")]
	[Description("短信模版id")]
	[NotNull]
	public string TemplateId { get; set; }

	[JsonPropertyName("template_param")]
	[Description("短信模板占位符要替换的值")]
	[NotNull]
	public string TemplateParam { get; set; }

	[JsonPropertyName("tag")]
	[Description("透传字段，回执的时候原样返回给调用方，最大长度512字符")]
	public string Tag { get; set; }

	[JsonPropertyName("post_tel")]
	[Description("既支持手机号明文，又支持手机号密文")]
	[NotNull]
	public string PostTel { get; set; }

	[JsonPropertyName("user_ext_code")]
	[Description("用户自定义扩展码，仅当允许自定义扩展码的时候生效")]
	public string UserExtCode { get; set; }
}

[Description("短信发送（注：游戏营销类短信目前暂不不支持发送）")]
public class SmsSendRsp
{
	[JsonPropertyName("code")]
	[Description("错误码，0表示成功")]
	public long Code { get; set; }

	[JsonPropertyName("message")]
	[Description("说明")]
	public string Message { get; set; }

	[JsonPropertyName("message_id")]
	[Description("消息的唯一标识，可以用于查询短信到达等")]
	public string MessageId { get; set; }
}
