namespace ecommerce.sdk.douyin;

[Description("删除短信模板")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数不合法","isv.parameter-invalid:5","参数不合法")]
[DouyinRetCode(40004,"非法的参数","参数template_id对应模板不存在","isv.parameter-invalid:7","参数template_id对应模板不存在")]
[DouyinRetCode(50002,"业务处理失败","响应结果不符合预期","isv.business-failed:628005100","请根据错误信息描述检查")]
public class SmsTemplateDeleteReq : IDouyinReq<SmsTemplateDeleteRsp>
{

	public string GetMethod() { return "sms.template.delete"; }

	public string GetUrl() { return "/sms/template/delete"; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("template_id")]
	[Description("短信模板id")]
	[NotNull]
	public string TemplateId { get; set; }
}

[Description("删除短信模板")]
public class SmsTemplateDeleteRsp
{
	[JsonPropertyName("code")]
	[Description("是否成功 0表示成功")]
	public long Code { get; set; }

	[JsonPropertyName("message")]
	[Description("说明")]
	public string Message { get; set; }
}
