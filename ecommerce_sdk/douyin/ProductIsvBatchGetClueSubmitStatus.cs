namespace ecommerce.sdk.douyin;

[Description("批量查询线索的提报状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","批量查询的数据不得超过100","isv.parameter-invalid:501","批量查询的数据不得超过100")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:502","联系管理员")]
public class ProductIsvBatchGetClueSubmitStatusReq : IDouyinReq<ProductIsvBatchGetClueSubmitStatusRsp>
{

	public string GetMethod() { return "product.isv.batchGetClueSubmitStatus"; }

	public string GetUrl() { return "/product/isv/batchGetClueSubmitStatus"; }

	[JsonPropertyName("productid_clueid_pair")]
	[Description("线索ID和商品ID")]
	[NotNull]
	public List<ProductidClueidPairItem> ProductidClueidPair { get; set; }

	public class ProductidClueidPairItem
	{
		[JsonPropertyName("clue_id")]
		[Description("线索ID")]
		[NotNull]
		public long? ClueId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		[NotNull]
		public long? ProductId { get; set; }
	}
}

[Description("批量查询线索的提报状态")]
public class ProductIsvBatchGetClueSubmitStatusRsp
{
	[JsonPropertyName("data")]
	[Description("返回数据")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("clue_id")]
		[Description("线索ID")]
		public long ClueId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("audit_status")]
		[Description("状态，-1-提报失败；0-待审核；1-人审通过；2-人审已驳回；3-机审通过；4-机审驳回；5-申诉中")]
		public long AuditStatus { get; set; }

		[JsonPropertyName("refused_reason")]
		[Description("审核驳回的理由")]
		public string RefusedReason { get; set; }

		[JsonPropertyName("submit_id")]
		[Description("提报ID")]
		public long SubmitId { get; set; }
	}
}
