namespace ecommerce.sdk.douyin;

[Description("团长活动特殊申请（修改费率、终止合作等）审核")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","已经处理过该申请，无需重复处理","isv.business-failed:100010","已经处理过该申请，无需重复处理")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
[DouyinRetCode(50002,"业务处理失败","服务器错误，请稍后再试","isv.business-failed:500","服务器错误，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","已经处理过该申请，无需重复处理","isv.business-failed:8192","已经处理过该申请，无需重复处理")]
public class BuyinColonelSpecialApplyDealReq : IDouyinReq<BuyinColonelSpecialApplyDealRsp>
{

	public string GetMethod() { return "buyin.colonel.specialApplyDeal"; }

	public string GetUrl() { return "/buyin/colonel/specialApplyDeal"; }

	[JsonPropertyName("activity_id")]
	[Description("活动ID")]
	[NotNull]
	public long? ActivityId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("special_apply_id")]
	[Description("特殊申请ID")]
	[NotNull]
	public long? SpecialApplyId { get; set; }

	[JsonPropertyName("status")]
	[Description("处理结果。1：同意；  2：拒绝")]
	[NotNull]
	public int? Status { get; set; }
}

[Description("团长活动特殊申请（修改费率、终止合作等）审核")]
public class BuyinColonelSpecialApplyDealRsp
{
	[JsonPropertyName("success")]
	[Description("审批是否成功，true 为成功，false 为失败（即使团长同意，但是不满足条件也会自动拒绝）")]
	public bool Success { get; set; }

	[JsonPropertyName("low_service_fee_activity_id")]
	[Description("活动 ID 列表（当商品提报了二级团长时,商家申请降低服务费率，若调整的服务费率*90%后的值，低于任意一个一级团长报名的二级团长服务费率，当一级团长点击同意时，系统自动拒绝，并且告知不合条件的活动ID）")]
	public List<long> LowServiceFeeActivityId { get; set; }

	[JsonPropertyName("second_activity_id")]
	[Description("活动 ID 列表（当商品提报了二级团长时，不允许降低佣金率，当一级团长点击同意时，系统自动拒绝，并且告知所有合作中的二级活动 ID）")]
	public List<long> SecondActivityId { get; set; }
}
