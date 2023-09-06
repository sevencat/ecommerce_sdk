namespace ecommerce.sdk.douyin;

[Description("提交短信签名申请单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","签名已经存在","isv.parameter-invalid:7","签名已经存在")]
[DouyinRetCode(40004,"非法的参数","参数不合法","isv.parameter-invalid:5","参数不合法")]
[DouyinRetCode(20000,"系统错误","内部错误","isp.service-error:4","内部错误")]
[DouyinRetCode(20000,"系统错误","内部错误","isp.service-error:500","超时")]
[DouyinRetCode(50002,"业务处理失败","响应结果不符合预期","isv.business-failed:628005100","请根据错误信息描述检查")]
[DouyinRetCode(20000,"系统错误","超时","isp.service-error:628004002","服务处理超时，请重试")]
[DouyinRetCode(40004,"非法的参数","商家不存在","isv.parameter-invalid:628005202","商家不存在")]
[DouyinRetCode(40002,"缺少必选参数","输入参数不正确，请检查后重试","isv.missing-parameter:628002001","请根据错误信息检查入参是否正确")]
[DouyinRetCode(20000,"系统错误","服务内部错误，请重试","isp.service-error:628004001","服务内部错误，请重试")]
[DouyinRetCode(50002,"业务处理失败","HttpPost请求失败","isv.business-failed:628004702","服务内部错误，请重试")]
public class SmsSignApplyReq : IDouyinReq<SmsSignApplyRsp>
{

	public string GetMethod() { return "sms.sign.apply"; }

	public string GetUrl() { return "/sms/sign/apply"; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("sign")]
	[Description("签名")]
	[NotNull]
	public string Sign { get; set; }
}

[Description("提交短信签名申请单")]
public class SmsSignApplyRsp
{
	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	public string SmsAccount { get; set; }

	[JsonPropertyName("sms_sign_apply_id")]
	[Description("短信签名申请单id")]
	public string SmsSignApplyId { get; set; }

	[JsonPropertyName("code")]
	[Description("是否成功 0表示成功")]
	public long Code { get; set; }

	[JsonPropertyName("message")]
	[Description("说明")]
	public string Message { get; set; }

	[JsonPropertyName("sign")]
	[Description("签名")]
	public string Sign { get; set; }

	[JsonPropertyName("status")]
	[Description("审核状态： 1:审核中 2:未通过 3:已开通 4:已关闭 5:免审核（店铺名和签名完全一致时返回）")]
	public long Status { get; set; }
}
