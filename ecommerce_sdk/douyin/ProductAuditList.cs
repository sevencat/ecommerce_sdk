namespace ecommerce.sdk.douyin;

[Description("1、查询审核记录列表，以及审核被驳回的原因；,2、只支持查询近15天提交审核的记录 ；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","2010001:系统异常,请重试","isv.business-failed:2010001","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","2010004:page or size is invalid","isv.business-failed:2010004","page or size is invalid")]
public class ProductAuditListReq : IDouyinReq<ProductAuditListRsp>
{

	public string GetMethod() { return "product.auditList"; }

	public string GetUrl() { return "/product/auditList"; }

	[JsonPropertyName("publish_status")]
	[Description("指定审核状态返回商品列表：0-审核中 1-审核通过 2-审核拒绝")]
	[NotNull]
	public long? PublishStatus { get; set; }

	[JsonPropertyName("page")]
	[Description("第几页（第一页为0，最大为99）")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页返回条数，最多支持100条")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品id")]
	public long? ProductId { get; set; }
}

[Description("1、查询审核记录列表，以及审核被驳回的原因；,2、只支持查询近15天提交审核的记录 ；")]
public class ProductAuditListRsp
{
	[JsonPropertyName("records")]
	[Description("审核记录列表")]
	public List<RecordsItem> Records { get; set; }

	public class RecordsItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品id")]
		public long ProductId { get; set; }

		[JsonPropertyName("title")]
		[Description("商品名称")]
		public string Title { get; set; }

		[JsonPropertyName("img_url")]
		[Description("商品主图")]
		public string ImgUrl { get; set; }

		[JsonPropertyName("publish_status")]
		[Description("0-审核中 1-审核通过 2-审核拒绝")]
		public long PublishStatus { get; set; }

		[JsonPropertyName("publish_time")]
		[Description("提审时间，单位为秒")]
		public long PublishTime { get; set; }

		[JsonPropertyName("audit_time")]
		[Description("审核通过/拒绝时间，单位为秒")]
		public long AuditTime { get; set; }

		[JsonPropertyName("audit_reason")]
		[Description("审核未通过理由")]
		public Dictionary<string,object> AuditReason { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数量")]
	public long Total { get; set; }
}
