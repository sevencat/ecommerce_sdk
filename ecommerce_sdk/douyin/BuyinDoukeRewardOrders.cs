namespace ecommerce.sdk.douyin;

[Description("抖客获取近30天内奖励订单（新客+召回用户）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","分销类型参数错误","isv.parameter-invalid:4414","分销类型参数错误")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效pageSize","isv.parameter-invalid:4415","参数校验失败：无效pageSize")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效时间区间（开始时间不能大于结束时间）","isv.parameter-invalid:4416","参数校验失败：无效时间区间（开始时间不能大于结束时间）")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效 PID","isv.parameter-invalid:4102","参数校验失败：无效 PID")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效开始时间","isv.parameter-invalid:4249","参数校验失败：无效开始时间")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效结束时间","isv.parameter-invalid:4250","参数校验失败：无效结束时间")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
public class BuyinDoukeRewardOrdersReq : IDouyinReq<BuyinDoukeRewardOrdersRsp>
{

	public string GetMethod() { return "buyin.doukeRewardOrders"; }

	public string GetUrl() { return "/buyin/doukeRewardOrders"; }

	[JsonPropertyName("page")]
	[Description("页数，从1开始；")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页订单数目，最大为100")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("pid")]
	[Description("独立抖客PID")]
	public string Pid { get; set; }

	[JsonPropertyName("start_date")]
	[Description("查询开始日期，格式：20230308，奖励订单只保存近30天的订单")]
	public string StartDate { get; set; }

	[JsonPropertyName("end_date")]
	[Description("查询结束日期，格式：20230308，奖励订单只保存近30天的订单")]
	public string EndDate { get; set; }

	[JsonPropertyName("distribution_type")]
	[Description("默认全部，0:全部 1:商品分销 2: 直播间分销 3: mix自建活动页分销 4:频道页分销 99:其他")]
	public long? DistributionType { get; set; }
}

[Description("抖客获取近30天内奖励订单（新客+召回用户）")]
public class BuyinDoukeRewardOrdersRsp
{
	[JsonPropertyName("reward_orders")]
	[Description("奖励订单信息")]
	public List<RewardOrdersItem> RewardOrders { get; set; }

	public class RewardOrdersItem
	{
		[JsonPropertyName("external_info")]
		[Description("扩展参数")]
		public string ExternalInfo { get; set; }

		[JsonPropertyName("pay_date")]
		[Description("成交日期")]
		public string PayDate { get; set; }

		[JsonPropertyName("promotion_info")]
		[Description("推广位信息")]
		public string PromotionInfo { get; set; }

		[JsonPropertyName("reward_order_id")]
		[Description("奖励订单ID")]
		public string RewardOrderId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("成交商品ID")]
		public string ProductId { get; set; }

		[JsonPropertyName("product_name")]
		[Description("成交商品名称")]
		public string ProductName { get; set; }

		[JsonPropertyName("pay_amount")]
		[Description("成交金额")]
		public long PayAmount { get; set; }

		[JsonPropertyName("reward_type")]
		[Description("奖励类型：拉新/召回")]
		public string RewardType { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("查询的奖励订单总数")]
	public long Total { get; set; }
}
