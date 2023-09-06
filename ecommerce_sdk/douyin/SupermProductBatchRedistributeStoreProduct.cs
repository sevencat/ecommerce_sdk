namespace ecommerce.sdk.douyin;

[Description("重新分配店铺主品对应的门店子品 (异步执行)")]
public class SupermProductBatchRedistributeStoreProductReq : IDouyinReq<SupermProductBatchRedistributeStoreProductRsp>
{

	public string GetMethod() { return "superm.product.batchRedistributeStoreProduct"; }

	public string GetUrl() { return "/superm/product/batchRedistributeStoreProduct"; }

	[JsonPropertyName("task_params")]
	[Description("重新分配任务参数")]
	[NotNull]
	public TaskParamsItem TaskParams { get; set; }

	public class TaskParamsItem
	{
		[JsonPropertyName("main_product_id")]
		[Description("店铺主商品ID")]
		[NotNull]
		public long? MainProductId { get; set; }

		[JsonPropertyName("add_store_ids")]
		[Description("需要铺品的门店ID列表")]
		public List<long> AddStoreIds { get; set; }

		[JsonPropertyName("del_store_ids")]
		[Description("需要删除子品的门店ID列表")]
		public List<long> DelStoreIds { get; set; }
	}
}

[Description("重新分配店铺主品对应的门店子品 (异步执行)")]
public class SupermProductBatchRedistributeStoreProductRsp
{
	[JsonPropertyName("root_task_id")]
	[Description("异步任务根任务ID")]
	public long RootTaskId { get; set; }
}
