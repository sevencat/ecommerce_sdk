namespace ecommerce.sdk.douyin;

[Description("删除视频短信模板")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:628005100","业务处理失败，请检查请求参数")]
[DouyinRetCode(40004,"非法的参数","请求入参非法","isv.parameter-invalid:628002001","请检查请求入参")]
public class SmsDeleteVmsTemplateReq : IDouyinReq<SmsDeleteVmsTemplateRsp>
{

	public string GetMethod() { return "sms.deleteVmsTemplate"; }

	public string GetUrl() { return "/sms/deleteVmsTemplate"; }

	[JsonPropertyName("sms_account")]
	[Description("短信account")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("template_id")]
	[Description("视频短信模板id")]
	[NotNull]
	public string TemplateId { get; set; }
}

[Description("删除视频短信模板")]
public class SmsDeleteVmsTemplateRsp
{
}
