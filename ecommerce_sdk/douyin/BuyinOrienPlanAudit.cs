namespace ecommerce.sdk.douyin;

[Description("商家审核定向计划达人的申请")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效申请ID","isv.parameter-invalid:4117","无效申请ID")]
public class BuyinOrienPlanAuditReq : IDouyinReq<BuyinOrienPlanAuditRsp>
{

	public string GetMethod() { return "buyin.orienPlanAudit"; }

	public string GetUrl() { return "/buyin/orienPlanAudit"; }

	[JsonPropertyName("audit_action")]
	[Description("审核选项。1：通过（默认值）；2：拒绝； 3：删除达人")]
	[NotNull]
	public int? AuditAction { get; set; }

	[JsonPropertyName("apply_id")]
	[Description("作者申请ID，/buyin/orienPlanAuthors 返回参数")]
	[NotNull]
	public long? ApplyId { get; set; }
}

[Description("商家审核定向计划达人的申请")]
public class BuyinOrienPlanAuditRsp
{
}
