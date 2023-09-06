namespace ecommerce.sdk.douyin;

[Description("接口用于团长报名二级团长活动,支持托管商品报名")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败，请查看具体错误信息","isv.business-failed:110110","业务处理失败，请查看具体错误信息")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:500","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","小数服务费率不合法，必须为两位小数","isv.business-failed:8192","小数服务费率不合法，必须为两位小数")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
public class BuyinOriginColonelApplyActivitiesReq : IDouyinReq<BuyinOriginColonelApplyActivitiesRsp>
{

	public string GetMethod() { return "buyin.originColonelApplyActivities"; }

	public string GetUrl() { return "/buyin/originColonelApplyActivities"; }

	[JsonPropertyName("activity_id")]
	[Description("活动ID")]
	[NotNull]
	public long? ActivityId { get; set; }

	[JsonPropertyName("phone_number")]
	[Description("联系电话")]
	[NotNull]
	public string PhoneNumber { get; set; }

	[JsonPropertyName("products")]
	[Description("商品列表")]
	[NotNull]
	public List<ProductsItem> Products { get; set; }

	public class ProductsItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		[NotNull]
		public long? ProductId { get; set; }

		[JsonPropertyName("origin_activity_id")]
		[Description("原始活动ID（托管商品传0）")]
		[NotNull]
		public long? OriginActivityId { get; set; }

		[JsonPropertyName("promotion_end_time")]
		[Description("商品推广结束时间")]
		public string PromotionEndTime { get; set; }
	}

	[JsonPropertyName("service_ratio")]
	[Description("招商服务费率。 服务费率+佣金率小于90（必须为两位小数）")]
	public string ServiceRatio { get; set; }
}

[Description("接口用于团长报名二级团长活动,支持托管商品报名")]
public class BuyinOriginColonelApplyActivitiesRsp
{
	[JsonPropertyName("total")]
	[Description("操作的商品数量")]
	public long Total { get; set; }

	[JsonPropertyName("result")]
	[Description("结果")]
	public List<ResultItem> Result { get; set; }

	public class ResultItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("is_success")]
		[Description("操作结果是否成功")]
		public bool IsSuccess { get; set; }

		[JsonPropertyName("error_code")]
		[Description("当前商品操作的错误码，成功为0")]
		public long ErrorCode { get; set; }

		[JsonPropertyName("error_msg")]
		[Description("当前商品操作的错误原因，成功为success")]
		public string ErrorMsg { get; set; }
	}
}
