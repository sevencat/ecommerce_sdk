namespace ecommerce.sdk.douyin;

[Description("短信服务，开发者申请创建视频短信模板")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:628005100","业务处理失败，请检查请求参数")]
[DouyinRetCode(40004,"非法的参数","请求入参非法","isv.parameter-invalid:628002001","请检查请求入参")]
[DouyinRetCode(50002,"业务处理失败","628004001:RPC通用错误","isv.business-failed:628004001","检查参数并稍后重试")]
public class SmsApplyVmsTemplateReq : IDouyinReq<SmsApplyVmsTemplateRsp>
{

	public string GetMethod() { return "sms.applyVmsTemplate"; }

	public string GetUrl() { return "/sms/applyVmsTemplate"; }

	[JsonPropertyName("sms_account")]
	[Description("短信account")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("template_name")]
	[Description("模板名称")]
	[NotNull]
	public string TemplateName { get; set; }

	[JsonPropertyName("template_theme")]
	[Description("模板主题")]
	[NotNull]
	public string TemplateTheme { get; set; }

	[JsonPropertyName("contents")]
	[Description("短信模板内容")]
	[NotNull]
	public List<ContentsItem> Contents { get; set; }

	public class ContentsItem
	{
		[JsonPropertyName("source_type")]
		[Description("文本：text/string,jpg图片：image/jpg,png图片：image/png ,gif图片：image/gif,mp4视频：video/mp4 ,mp3音频：audio/mp3")]
		[NotNull]
		public string SourceType { get; set; }

		[JsonPropertyName("content")]
		[Description("文本类型：传string utf-8，文本内容结尾需要带上固定文案：TD退订、T退订或者N退订,其他类型：转base64编码,总大小不超过1.9M")]
		[NotNull]
		public string Content { get; set; }
	}

	[JsonPropertyName("signature")]
	[Description("短信签名")]
	[NotNull]
	public string Signature { get; set; }

	[JsonPropertyName("extra")]
	[Description("模板描述")]
	public string Extra { get; set; }
}

[Description("短信服务，开发者申请创建视频短信模板")]
public class SmsApplyVmsTemplateRsp
{
	[JsonPropertyName("template_id")]
	[Description("模板id")]
	public string TemplateId { get; set; }
}
