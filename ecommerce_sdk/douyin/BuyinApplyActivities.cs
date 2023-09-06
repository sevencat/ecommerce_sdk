namespace ecommerce.sdk.douyin;

[Description("支持店铺授权将抖店商品申请提报到团长活动中。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","活动报名时间已结束，不支持继续报名","isv.business-failed:110110","活动报名时间已结束，不支持继续报名")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:500","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","小数服务费率不合法，必须为两位小数","isv.business-failed:8192","小数服务费率不合法，必须为两位小数")]
[DouyinRetCode(50002,"业务处理失败","请检查输入参数","isv.business-failed:10001","请检查输入参数")]
public class BuyinApplyActivitiesReq : IDouyinReq<BuyinApplyActivitiesRsp>
{

	public string GetMethod() { return "buyin.applyActivities"; }

	public string GetUrl() { return "/buyin/applyActivities"; }

	[JsonPropertyName("activity_id")]
	[Description("团长活动ID")]
	[NotNull]
	public long? ActivityId { get; set; }

	[JsonPropertyName("service_rate")]
	[Description("招商服务费率。 服务费率+佣金率小于90（废弃）")]
	[NotNull]
	public long? ServiceRate { get; set; }

	[JsonPropertyName("phone_number")]
	[Description("店铺联系电话")]
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

		[JsonPropertyName("activity_price")]
		[Description("活动价（单位分）")]
		[NotNull]
		public long? ActivityPrice { get; set; }

		[JsonPropertyName("commission_rate")]
		[Description("佣金比例，设置范围[1%,50%]不小于改团长活动设置佣金率（废弃）")]
		[NotNull]
		public long? CommissionRate { get; set; }

		[JsonPropertyName("promotion_stock")]
		[Description("参与活动库存")]
		public long? PromotionStock { get; set; }

		[JsonPropertyName("gift_info")]
		[Description("赠品（15个字以内，填写可提供赠品详情）")]
		public string GiftInfo { get; set; }

		[JsonPropertyName("promotion_step")]
		[Description("活动价实现方式（15个字以内，如满减、提供优惠券、拍立减、限时活动价）")]
		public string PromotionStep { get; set; }

		[JsonPropertyName("product_activity_ratio")]
		[Description("佣金比例，设置范围[0,80%]，并且不能不小于该团长活动设置佣金率（必须为两位小数）")]
		public string ProductActivityRatio { get; set; }

		[JsonPropertyName("promotion_end_time")]
		[Description("商品推广结束时间（不传默认为当前时间往后数90天）")]
		public string PromotionEndTime { get; set; }

		[JsonPropertyName("months_of_protection")]
		[Description("开启独家保护的时长。单位：月；范围：[0,12]，0表示不开启")]
		public int? MonthsOfProtection { get; set; }
	}

	[JsonPropertyName("service_ratio")]
	[Description("招商服务费率。 服务费率+佣金率小于90（必须为两位小数）")]
	public string ServiceRatio { get; set; }
}

[Description("支持店铺授权将抖店商品申请提报到团长活动中。")]
public class BuyinApplyActivitiesRsp
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
		[Description("操作结果。 true：成功；false：失败")]
		public bool IsSuccess { get; set; }

		[JsonPropertyName("error_code")]
		[Description("当前商品操作的错误码，成功为0")]
		public long ErrorCode { get; set; }

		[JsonPropertyName("error_msg")]
		[Description("当前商品操作的错误原因，成功为success")]
		public string ErrorMsg { get; set; }
	}
}
