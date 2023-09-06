namespace ecommerce.sdk.douyin;

[Description("查询线索提报审核结果")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","提报记录不存在","isv.business-failed:501","检查参数")]
public class ProductIsvQueryClueAuditStatusReq : IDouyinReq<ProductIsvQueryClueAuditStatusRsp>
{

	public string GetMethod() { return "product.isv.queryClueAuditStatus"; }

	public string GetUrl() { return "/product/isv/queryClueAuditStatus"; }

	[JsonPropertyName("clue_id")]
	[Description("线索ID")]
	[NotNull]
	public long? ClueId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }
}

[Description("查询线索提报审核结果")]
public class ProductIsvQueryClueAuditStatusRsp
{
	[JsonPropertyName("audit_status")]
	[Description("审核状态（0:待审核，1:人审已通过，2:人审已驳回，3:机审通过，4:机审驳回，5:申诉中）")]
	public long AuditStatus { get; set; }

	[JsonPropertyName("refused_reason")]
	[Description("审核不通过原因")]
	public string RefusedReason { get; set; }

	[JsonPropertyName("submit_id")]
	[Description("提报id")]
	public long SubmitId { get; set; }
}
