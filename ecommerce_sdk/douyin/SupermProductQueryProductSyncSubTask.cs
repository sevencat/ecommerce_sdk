namespace ecommerce.sdk.douyin;

[Description("查询根任务下的子任务列表")]
public class SupermProductQueryProductSyncSubTaskReq : IDouyinReq<SupermProductQueryProductSyncSubTaskRsp>
{

	public string GetMethod() { return "superm.product.queryProductSyncSubTask"; }

	public string GetUrl() { return "/superm/product/queryProductSyncSubTask"; }

	[JsonPropertyName("root_task_id")]
	[Description("根任务ID")]
	[NotNull]
	public long? RootTaskId { get; set; }

	[JsonPropertyName("page")]
	[Description("起始页 (从0开始)")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页尺寸 (最大值50)")]
	[NotNull]
	public long? Size { get; set; }
}

[Description("查询根任务下的子任务列表")]
public class SupermProductQueryProductSyncSubTaskRsp
{
	[JsonPropertyName("task_list")]
	[Description("子任务列表")]
	public List<TaskListItem> TaskList { get; set; }

	public class TaskListItem
	{
		[JsonPropertyName("task_id")]
		[Description("任务ID")]
		public long TaskId { get; set; }

		[JsonPropertyName("root_task_id")]
		[Description("根任务ID")]
		public long RootTaskId { get; set; }

		[JsonPropertyName("task_status")]
		[Description("任务执行状态。支持的枚举有：waiting - 待执行; running - 执行中；completed - 执行完成； cancelled - 任务取消；error - 执行出错； unknown - 未知状态")]
		public string TaskStatus { get; set; }

		[JsonPropertyName("sync_result")]
		[Description("业务执行结果，任务执行状态为completed执行完成时生效。支持的枚举值有：success - 同步成功； fail - 同步失败")]
		public string SyncResult { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("错误信息")]
		public string ErrMsg { get; set; }

		[JsonPropertyName("main_product_id")]
		[Description("店铺主商品ID")]
		public long MainProductId { get; set; }

		[JsonPropertyName("store_id")]
		[Description("门店ID")]
		public long StoreId { get; set; }

		[JsonPropertyName("sub_product_id")]
		[Description("门店子商品ID")]
		public long SubProductId { get; set; }
	}

	[JsonPropertyName("page")]
	[Description("起始页 (从0开始)")]
	public long Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页尺寸 (最大值50)")]
	public long Size { get; set; }

	[JsonPropertyName("total")]
	[Description("子任务总数")]
	public long Total { get; set; }
}
