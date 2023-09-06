namespace ecommerce.sdk.douyin;

[Description("接口用于团长取消二级团长活动的提报申请")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
public class BuyinActivityProductCancelReq : IDouyinReq<BuyinActivityProductCancelRsp>
{

	public string GetMethod() { return "buyin.activityProductCancel"; }

	public string GetUrl() { return "/buyin/activityProductCancel"; }

	[JsonPropertyName("activity_id")]
	[Description("活动 id")]
	[NotNull]
	public long? ActivityId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品 id")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("origin_activity_id")]
	[Description("原始活动 id")]
	public long? OriginActivityId { get; set; }
}

[Description("接口用于团长取消二级团长活动的提报申请")]
public class BuyinActivityProductCancelRsp
{
	[JsonPropertyName("success")]
	[Description("操作结果（true：操作成功）")]
	public bool Success { get; set; }
}
