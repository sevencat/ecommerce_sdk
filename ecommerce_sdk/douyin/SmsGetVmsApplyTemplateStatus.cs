namespace ecommerce.sdk.douyin;

[Description("查询视频短信模板申请状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:628005100","业务处理失败，请检查请求参数")]
[DouyinRetCode(40004,"非法的参数","请求入参非法","isv.parameter-invalid:628002001","请检查请求入参")]
public class SmsGetVmsApplyTemplateStatusReq : IDouyinReq<SmsGetVmsApplyTemplateStatusRsp>
{

	public string GetMethod() { return "sms.getVmsApplyTemplateStatus"; }

	public string GetUrl() { return "/sms/getVmsApplyTemplateStatus"; }

	[JsonPropertyName("sms_account")]
	[Description("短信account")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("template_id")]
	[Description("申请的模板id")]
	[NotNull]
	public string TemplateId { get; set; }
}

[Description("查询视频短信模板申请状态")]
public class SmsGetVmsApplyTemplateStatusRsp
{
	[JsonPropertyName("result")]
	[Description("响应结果")]
	public List<ResultItem> Result { get; set; }

	public class ResultItem
	{
		[JsonPropertyName("carrier")]
		[Description("运营商名称枚举,China Mobile、,China Telecom、,China Unicom")]
		public string Carrier { get; set; }

		[JsonPropertyName("status")]
		[Description("模版审核状态；1: 审核中，2: 未通过，3: 已开通，4: 已关闭，5: 免审")]
		public long Status { get; set; }

		[JsonPropertyName("reason")]
		[Description("失败原因(部分失败情况会有)")]
		public string Reason { get; set; }
	}
}
