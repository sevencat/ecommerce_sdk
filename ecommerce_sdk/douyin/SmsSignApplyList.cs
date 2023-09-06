namespace ecommerce.sdk.douyin;

[Description("查看短信签名申请单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","响应结果不符合预期","isv.business-failed:628005100","请根据错误信息描述检查")]
[DouyinRetCode(20000,"系统错误","628004205:Redis Get错误","isp.service-error:628004205","系统错误，请重试")]
public class SmsSignApplyListReq : IDouyinReq<SmsSignApplyListRsp>
{

	public string GetMethod() { return "sms.sign.apply.list"; }

	public string GetUrl() { return "/sms/sign/apply/list"; }

	[JsonPropertyName("sms_account")]
	[Description("短信发送渠道，主要做资源隔离")]
	[NotNull]
	public string SmsAccount { get; set; }

	[JsonPropertyName("like")]
	[Description("搜索")]
	public string Like { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，默认0")]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页大小，默认10")]
	public long? Size { get; set; }

	[JsonPropertyName("sms_sign_apply_id")]
	[Description("申请单id")]
	public string SmsSignApplyId { get; set; }
}

[Description("查看短信签名申请单")]
public class SmsSignApplyListRsp
{
	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }

	[JsonPropertyName("apply_list")]
	[Description("短信签名申请单列表")]
	public List<ApplyListItem> ApplyList { get; set; }

	public class ApplyListItem
	{
		[JsonPropertyName("sms_sign_apply_id")]
		[Description("申请单id")]
		public string SmsSignApplyId { get; set; }

		[JsonPropertyName("sign")]
		[Description("签名")]
		public string Sign { get; set; }

		[JsonPropertyName("sms_account")]
		[Description("短信发送渠道，主要做资源隔离")]
		public string SmsAccount { get; set; }

		[JsonPropertyName("status")]
		[Description("审核状态： 1:审核中 2:未通过 3:已开通 4:已关闭 5:免审核（店铺名和签名完全一致时返回）")]
		public long Status { get; set; }

		[JsonPropertyName("status_remark")]
		[Description("说明")]
		public string StatusRemark { get; set; }
	}
}
