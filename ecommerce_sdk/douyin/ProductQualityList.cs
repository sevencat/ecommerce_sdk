namespace ecommerce.sdk.douyin;

[Description("查询店铺商品质量情况，对标后台商品成长中心")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","缺少必要参数","isv.missing-parameter:2030003","补充必要参数")]
[DouyinRetCode(40004,"非法的参数","参数值非法","isv.parameter-invalid:2030004","按要求填写参数值")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:2030001","等待后重试")]
[DouyinRetCode(20000,"系统错误","读取数据失败","isp.service-error:2030201","系统异常，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","2030013:读取商品失败","isv.business-failed:2030013","系统异常，请稍后重试")]
public class ProductQualityListReq : IDouyinReq<ProductQualityListRsp>
{

	public string GetMethod() { return "product.qualityList"; }

	public string GetUrl() { return "/product/qualityList"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	public long? ProductId { get; set; }

	[JsonPropertyName("product_name")]
	[Description("商品名字")]
	public string ProductName { get; set; }

	[JsonPropertyName("order_by")]
	[Description("排序方式，降序“desc”，升序“asc”， 不传默认降序")]
	public string OrderBy { get; set; }

	[JsonPropertyName("page")]
	[Description("分页参数，页数从1开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("分页参数，每页大小，填写范围1~100；")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("task_id")]
	[Description("【已废弃】开发者可以传入：9999999999")]
	[NotNull]
	public long? TaskId { get; set; }

	[JsonPropertyName("diagnose_status")]
	[Description("商品诊断状态，0-待诊断；1-待优化；2-已修改审核中；3-已优化；以前的status 字段因为配置错误已经删除，请使用此新字段")]
	public List<long> DiagnoseStatus { get; set; }
}

[Description("查询店铺商品质量情况，对标后台商品成长中心")]
public class ProductQualityListRsp
{
	[JsonPropertyName("quality_list")]
	[Description("商品质量列表")]
	public List<QualityListItem> QualityList { get; set; }

	public class QualityListItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("product_name")]
		[Description("商品名字")]
		public string ProductName { get; set; }

		[JsonPropertyName("problem_num_to_improve")]
		[Description("待优化问题数量")]
		public long ProblemNumToImprove { get; set; }

		[JsonPropertyName("problem_type_distribution")]
		[Description("待优化问题分布列表")]
		public List<ProblemTypeDistributionItem> ProblemTypeDistribution { get; set; }

		public class ProblemTypeDistributionItem
		{
			[JsonPropertyName("type_name")]
			[Description("待优化问题类型")]
			public string TypeName { get; set; }

			[JsonPropertyName("num")]
			[Description("问题数量")]
			public long Num { get; set; }
		}

		[JsonPropertyName("meet_standard")]
		[Description("商品是否达标，1达标，2不达标")]
		public long MeetStandard { get; set; }

		[JsonPropertyName("base_score")]
		[Description("商品基础分")]
		public long BaseScore { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("店铺待优化商品总量")]
	public long Total { get; set; }
}
