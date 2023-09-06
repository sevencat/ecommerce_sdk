namespace ecommerce.sdk.douyin;

[Description("小时达拒绝原因列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20201","系统繁忙，请稍后重试")]
public class SupermRejectReasonListReq : IDouyinReq<SupermRejectReasonListRsp>
{

	public string GetMethod() { return "superm.rejectReasonList"; }

	public string GetUrl() { return "/superm/rejectReasonList"; }

}

[Description("小时达拒绝原因列表")]
public class SupermRejectReasonListRsp
{
	[JsonPropertyName("reject_infos")]
	[Description("拒绝原因列表")]
	public List<RejectInfosItem> RejectInfos { get; set; }

	public class RejectInfosItem
	{
		[JsonPropertyName("reject_code")]
		[Description("拒绝code")]
		public long RejectCode { get; set; }

		[JsonPropertyName("reject_reason")]
		[Description("拒绝原因")]
		public string RejectReason { get; set; }
	}
}
