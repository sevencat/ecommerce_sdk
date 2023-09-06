namespace ecommerce.sdk.douyin;

[Description("查询异步执行的根任务列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","2010001:查询Task信息出错，请稍后重试","isv.business-failed:2010001","请稍后重试")]
public class SupermProductQueryProductSyncTaskReq : IDouyinReq<SupermProductQueryProductSyncTaskRsp>
{

	public string GetMethod() { return "superm.product.queryProductSyncTask"; }

	public string GetUrl() { return "/superm/product/queryProductSyncTask"; }

	[JsonPropertyName("task_type")]
	[Description("任务类型。支持的任务类型有：batch_redistribute_sub_product - 重新分配店铺主品对应的门店子品; sync_sub_products_price - 将店铺主品的价格应用至门店子品；sync_sub_products - 主商品变更后变更结果同步至子商品")]
	[NotNull]
	public string TaskType { get; set; }

	[JsonPropertyName("task_id")]
	[Description("任务ID")]
	public long? TaskId { get; set; }

	[JsonPropertyName("page")]
	[Description("起始页 (从0开始)")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页尺寸 (最大值50)")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("product_id")]
	[Description("主商品ID，传入则查询该主商品的相关任务")]
	public long? ProductId { get; set; }
}

[Description("查询异步执行的根任务列表")]
public class SupermProductQueryProductSyncTaskRsp
{
	[JsonPropertyName("task_list")]
	[Description("任务列表")]
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
	[Description("任务总数")]
	public long Total { get; set; }
}
