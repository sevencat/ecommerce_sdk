namespace ecommerce.sdk.douyin;

[Description("支持根据条件筛选团长下赏金任务列表，需团长授权")]
public class BuyinColonelAwardTaskListReq : IDouyinReq<BuyinColonelAwardTaskListRsp>
{

	public string GetMethod() { return "buyin.colonelAwardTaskList"; }

	public string GetUrl() { return "/buyin/colonelAwardTaskList"; }

	[JsonPropertyName("task_info")]
	[Description("任务id或名称")]
	public string TaskInfo { get; set; }

	[JsonPropertyName("status")]
	[Description("0：不限，1：未发布，2：审核中，3：审核未通过，4：未开始，5：进行中，6：已结束, 默认0")]
	public long? Status { get; set; }

	[JsonPropertyName("page")]
	[Description("页数，默认1")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页条数，最大20。默认20")]
	public long? PageSize { get; set; }
}

[Description("支持根据条件筛选团长下赏金任务列表，需团长授权")]
public class BuyinColonelAwardTaskListRsp
{
	[JsonPropertyName("total")]
	[Description("数据总条数")]
	public long Total { get; set; }

	[JsonPropertyName("results")]
	[Description("任务列表")]
	public List<ResultsItem> Results { get; set; }

	public class ResultsItem
	{
		[JsonPropertyName("task_id")]
		[Description("任务 id")]
		public long TaskId { get; set; }

		[JsonPropertyName("task_name")]
		[Description("任务名称")]
		public string TaskName { get; set; }

		[JsonPropertyName("status")]
		[Description("任务状态。1：未发布，2：审核中，3：审核未通过，4：未开始，5：进行中，6：已结束")]
		public long Status { get; set; }

		[JsonPropertyName("task_start_time")]
		[Description("任务开始时间")]
		public string TaskStartTime { get; set; }

		[JsonPropertyName("task_end_time")]
		[Description("任务结束时间")]
		public string TaskEndTime { get; set; }

		[JsonPropertyName("apply_cnt")]
		[Description("已领取人数")]
		public long ApplyCnt { get; set; }

		[JsonPropertyName("promote_cnt")]
		[Description("已推广人数")]
		public long PromoteCnt { get; set; }

		[JsonPropertyName("gmv")]
		[Description("支付 GMV，单位：分")]
		public long Gmv { get; set; }

		[JsonPropertyName("order_cnt")]
		[Description("总订单量")]
		public long OrderCnt { get; set; }

		[JsonPropertyName("reason")]
		[Description("审核未通过原因")]
		public string Reason { get; set; }

		[JsonPropertyName("can_apply")]
		[Description("是否可报名")]
		public bool CanApply { get; set; }
	}

	[JsonPropertyName("ongoing_task_cnt")]
	[Description("进行中的任务数量")]
	public long OngoingTaskCnt { get; set; }
}
