namespace ecommerce.sdk.douyin;

[Description("使用场景： 1、使用【/spu/createSpu】创建spuid创建成功后，可以使用spu_id查询审核状态；建议场景成功后间隔1小时后再查询审核结果； 2、当前支持支持图书spuid查询")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","2012004:spu_id必须大于0","isv.business-failed:2012004","请检查spu_id是否正确")]
public class SpuGetAuditInfoReq : IDouyinReq<SpuGetAuditInfoRsp>
{

	public string GetMethod() { return "spu.getAuditInfo"; }

	public string GetUrl() { return "/spu/getAuditInfo"; }

	[JsonPropertyName("spu_id")]
	[Description("SPU编号；使用【/spu/createSpu】创建spuid创建成功后，可以使用spu_id查询审核状态；建议场景成功后间隔1小时后再查询审核结果；")]
	[NotNull]
	public long? SpuId { get; set; }
}

[Description("使用场景： 1、使用【/spu/createSpu】创建spuid创建成功后，可以使用spu_id查询审核状态；建议场景成功后间隔1小时后再查询审核结果； 2、当前支持支持图书spuid查询")]
public class SpuGetAuditInfoRsp
{
	[JsonPropertyName("spu_id")]
	[Description("SPU编号")]
	public long SpuId { get; set; }

	[JsonPropertyName("spu_status")]
	[Description("SPU状态，1:已上线，2:已下线，3:审核中，4:审核不通过")]
	public long SpuStatus { get; set; }

	[JsonPropertyName("reject_reason")]
	[Description("审核驳回原因")]
	public string RejectReason { get; set; }

	[JsonPropertyName("create_time")]
	[Description("审核记录创建时间")]
	public string CreateTime { get; set; }

	[JsonPropertyName("update_time")]
	[Description("审核记录更新时间")]
	public string UpdateTime { get; set; }
}
