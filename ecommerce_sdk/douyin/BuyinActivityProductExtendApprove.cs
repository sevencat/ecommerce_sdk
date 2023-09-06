namespace ecommerce.sdk.douyin;

[Description("本接口用于商家处理团长活动商品的推广延期申请")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","审核延长推广申请失败","isv.business-failed:110110","审核延长推广申请失败")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","已有店铺托管团长，不可以同意非店铺托管团长的延长申请","isv.business-failed:500","已有店铺托管团长，不可以同意非店铺托管团长的延长申请")]
public class BuyinActivityProductExtendApproveReq : IDouyinReq<BuyinActivityProductExtendApproveRsp>
{

	public string GetMethod() { return "buyin.activityProductExtendApprove"; }

	public string GetUrl() { return "/buyin/activityProductExtendApprove"; }

	[JsonPropertyName("activity_id")]
	[Description("活动ID")]
	[NotNull]
	public long? ActivityId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("status")]
	[Description("延长推广的审批状态。1：审核通过；2：审核拒绝")]
	[NotNull]
	public int? Status { get; set; }
}

[Description("本接口用于商家处理团长活动商品的推广延期申请")]
public class BuyinActivityProductExtendApproveRsp
{
	[JsonPropertyName("success")]
	[Description("操作是否成功")]
	public bool Success { get; set; }
}
