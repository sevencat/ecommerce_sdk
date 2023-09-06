namespace ecommerce.sdk.douyin;

[Description("专属团长活动商品审核接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","活动不是处在报名中，不能审核","isv.business-failed:4140","活动不是处在报名中，不能审核")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","请稍候再试")]
[DouyinRetCode(50002,"业务处理失败","当前用户不是创建活动的用户","isv.business-failed:4139","当前用户不是创建活动的用户")]
[DouyinRetCode(50002,"业务处理失败","参数校验失败","isv.business-failed:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","活动ID不存在","isv.business-failed:4138","活动ID不存在")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
public class AllianceColonelActivityProductAuditReq : IDouyinReq<AllianceColonelActivityProductAuditRsp>
{

	public string GetMethod() { return "alliance.colonelActivityProductAudit"; }

	public string GetUrl() { return "/alliance/colonelActivityProductAudit"; }

	[JsonPropertyName("activity_id")]
	[Description("团长活动id")]
	[NotNull]
	public long? ActivityId { get; set; }

	[JsonPropertyName("apply_ids")]
	[Description("团长商品申请ID。（可在活动商品查询接口中获取）")]
	[NotNull]
	public List<long> ApplyIds { get; set; }

	[JsonPropertyName("operation")]
	[Description("审核信息（0：通过； 1：拒绝）")]
	[NotNull]
	public long? Operation { get; set; }

	[JsonPropertyName("repeat_apply")]
	[Description("是否允许二次报名（true:允许，false:不允许）")]
	public bool? RepeatApply { get; set; }

	[JsonPropertyName("suggest_info")]
	[Description("审核建议")]
	public string SuggestInfo { get; set; }
}

[Description("专属团长活动商品审核接口")]
public class AllianceColonelActivityProductAuditRsp
{
	[JsonPropertyName("product_audit_info")]
	[Description("审核结果")]
	public List<ProductAuditInfoItem> ProductAuditInfo { get; set; }

	public class ProductAuditInfoItem
	{
		[JsonPropertyName("apply_id")]
		[Description("团长商品申请ID")]
		public long ApplyId { get; set; }

		[JsonPropertyName("reject_reason")]
		[Description("商品不在该活动中, 商品已经审核过, 商品不存在")]
		public string RejectReason { get; set; }
	}
}
