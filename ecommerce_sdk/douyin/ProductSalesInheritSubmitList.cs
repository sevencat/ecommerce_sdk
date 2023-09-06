namespace ecommerce.sdk.douyin;

[Description("批量查询店铺商品全网销量信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:500","请检查参数要求")]
public class ProductSalesInheritSubmitListReq : IDouyinReq<ProductSalesInheritSubmitListRsp>
{

	public string GetMethod() { return "product.salesInherit.submitList"; }

	public string GetUrl() { return "/product/salesInherit/submitList"; }

	[JsonPropertyName("product_ids")]
	[Description("抖店店铺商品id列表,最大支持50条；")]
	public List<long> ProductIds { get; set; }

	[JsonPropertyName("outside_product_ids")]
	[Description("站外商品id列表（与站内商品id条件取）；最大支持50条；")]
	public List<long> OutsideProductIds { get; set; }

	[JsonPropertyName("page")]
	[Description("分页参数")]
	[NotNull]
	public PageItem Page { get; set; }

	public class PageItem
	{
		[JsonPropertyName("page_no")]
		[Description("当前页，从1起")]
		[NotNull]
		public int? PageNo { get; set; }

		[JsonPropertyName("page_size")]
		[Description("每页数量；最大50；")]
		[NotNull]
		public int? PageSize { get; set; }
	}
}

[Description("批量查询店铺商品全网销量信息")]
public class ProductSalesInheritSubmitListRsp
{
	[JsonPropertyName("sales_extend_record_list")]
	[Description("全网销量记录列表")]
	public List<SalesExtendRecordListItem> SalesExtendRecordList { get; set; }

	public class SalesExtendRecordListItem
	{
		[JsonPropertyName("platform_id")]
		[Description("站外平台id（1:淘宝）")]
		public long PlatformId { get; set; }

		[JsonPropertyName("submit_time")]
		[Description("提报时间，单位：秒；")]
		public long SubmitTime { get; set; }

		[JsonPropertyName("submit_sales_num")]
		[Description("提报销量")]
		public long SubmitSalesNum { get; set; }

		[JsonPropertyName("product_id")]
		[Description("抖店商品id")]
		public long ProductId { get; set; }

		[JsonPropertyName("outside_product_id")]
		[Description("站外商品id")]
		public long OutsideProductId { get; set; }

		[JsonPropertyName("audit_status")]
		[Description("审核状态（0:待审核；1:已通过；2:已驳回）")]
		public int AuditStatus { get; set; }

		[JsonPropertyName("audit_msg")]
		[Description("驳回原因")]
		public string AuditMsg { get; set; }

		[JsonPropertyName("audit_time")]
		[Description("审核结果时间包含审核失败和成功；单位：秒；")]
		public long AuditTime { get; set; }

		[JsonPropertyName("extend_sales_num")]
		[Description("实际审核通过后的全网销量，审核通过后可在抖店c端买家商详页面查看的销量；")]
		public long ExtendSalesNum { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总条数")]
	public long Total { get; set; }
}
