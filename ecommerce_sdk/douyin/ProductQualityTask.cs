namespace ecommerce.sdk.douyin;

[Description("商品每日诊断任务查询API,根据店铺ID查询最新每日诊断任务详情")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:2030001","等待后重试")]
[DouyinRetCode(50002,"业务处理失败","处理超时","isv.business-failed:2030002","等待后重试")]
[DouyinRetCode(40002,"缺少必选参数","缺少必要参数","isv.missing-parameter:2030003","补充必要参数")]
[DouyinRetCode(40004,"非法的参数","参数值非法","isv.parameter-invalid:2030004","按要求填写参数值")]
[DouyinRetCode(20000,"系统错误","读取数据失败","isp.service-error:2030201","等待后重试")]
[DouyinRetCode(50002,"业务处理失败","2030013:读取任务失败","isv.business-failed:2030013","请稍后重试")]
public class ProductQualityTaskReq : IDouyinReq<ProductQualityTaskRsp>
{

	public string GetMethod() { return "product.qualityTask"; }

	public string GetUrl() { return "/product/qualityTask"; }

	[JsonPropertyName("brief_only")]
	[Description("是否只返回简要信息，不写默认false")]
	public bool? BriefOnly { get; set; }
}

[Description("商品每日诊断任务查询API,根据店铺ID查询最新每日诊断任务详情")]
public class ProductQualityTaskRsp
{
	[JsonPropertyName("product_num_total")]
	[Description("总共需要诊断的商品数")]
	public long ProductNumTotal { get; set; }

	[JsonPropertyName("product_num_finished")]
	[Description("已经诊断过的商品数")]
	public long ProductNumFinished { get; set; }

	[JsonPropertyName("task_status")]
	[Description("任务状态，0-初始化，1-进行中，2-已完成")]
	public long TaskStatus { get; set; }

	[JsonPropertyName("product_num_to_improve_total")]
	[Description("待优化商品数，仅brief_only为false返回")]
	public long ProductNumToImproveTotal { get; set; }

	[JsonPropertyName("problem_num_total")]
	[Description("可优化项总数，仅brief_only为false返回")]
	public long ProblemNumTotal { get; set; }

	[JsonPropertyName("problem_num_to_improve")]
	[Description("待优化项数量，仅brief_only为false返回")]
	public long ProblemNumToImprove { get; set; }

	[JsonPropertyName("task_finish_time")]
	[Description("任务完成时间，仅brief_only为false返回")]
	public string TaskFinishTime { get; set; }

	[JsonPropertyName("problem_type_distribution")]
	[Description("问题类型分布，仅brief_only为false返回")]
	public List<ProblemTypeDistributionItem> ProblemTypeDistribution { get; set; }

	public class ProblemTypeDistributionItem
	{
		[JsonPropertyName("type_key")]
		[Description("优化项代号，1-商品信息不规范，2-关键信息待优化，3-商品素材缺失")]
		public long TypeKey { get; set; }

		[JsonPropertyName("type_name")]
		[Description("优化项具体名字")]
		public string TypeName { get; set; }

		[JsonPropertyName("num")]
		[Description("具体问题数量")]
		public long Num { get; set; }
	}

	[JsonPropertyName("task_id")]
	[Description("任务ID")]
	public long TaskId { get; set; }

	[JsonPropertyName("standard_rate")]
	[Description("达标率，百分比")]
	public decimal StandardRate { get; set; }

	[JsonPropertyName("is_standard")]
	[Description("是否达标")]
	public bool IsStandard { get; set; }

	[JsonPropertyName("meet_standard_num")]
	[Description("达标商品数")]
	public long MeetStandardNum { get; set; }
}
