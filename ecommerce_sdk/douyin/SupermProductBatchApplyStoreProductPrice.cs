namespace ecommerce.sdk.douyin;

[Description("将店铺主品的价格应用至门店子品 (异步执行)")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","2010004:功能尚未开放","isv.business-failed:2010004","联系运营开通为抖音超市二期商家")]
public class SupermProductBatchApplyStoreProductPriceReq : IDouyinReq<SupermProductBatchApplyStoreProductPriceRsp>
{

	public string GetMethod() { return "superm.product.batchApplyStoreProductPrice"; }

	public string GetUrl() { return "/superm/product/batchApplyStoreProductPrice"; }

	[JsonPropertyName("task_params")]
	[Description("异步任务参数")]
	[NotNull]
	public TaskParamsItem TaskParams { get; set; }

	public class TaskParamsItem
	{
		[JsonPropertyName("main_product_id")]
		[Description("店铺主商品ID")]
		[NotNull]
		public long? MainProductId { get; set; }
	}
}

[Description("将店铺主品的价格应用至门店子品 (异步执行)")]
public class SupermProductBatchApplyStoreProductPriceRsp
{
	[JsonPropertyName("root_task_id")]
	[Description("异步任务根任务ID")]
	public long RootTaskId { get; set; }
}
