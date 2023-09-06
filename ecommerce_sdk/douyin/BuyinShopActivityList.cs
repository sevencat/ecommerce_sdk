namespace ecommerce.sdk.douyin;

[Description("接口用于商家获取可参与的团长活动，支持报名状态筛选，包括已提报和未提报两种状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","不允许继续翻页，请使用游标模式加载更多数据","isv.parameter-invalid:8197","请使用游标模式加载更多数据，详情：https://op.jinritemai.com/docs/notice-docs/5/3237")]
public class BuyinShopActivityListReq : IDouyinReq<BuyinShopActivityListRsp>
{

	public string GetMethod() { return "buyin.ShopActivityList"; }

	public string GetUrl() { return "/buyin/ShopActivityList"; }

	[JsonPropertyName("apply_status")]
	[Description("1、我报名的活动 2、可以报名的活动")]
	[NotNull]
	public int? ApplyStatus { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，从1开始。分页模式下生效，超过10000条会被限制，推荐使用游标模式 retrieve_mode=1")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页条数")]
	public long? PageSize { get; set; }

	[JsonPropertyName("commission_rate_min")]
	[Description("最低佣金率（5.5%,传550）")]
	public int? CommissionRateMin { get; set; }

	[JsonPropertyName("commission_rate_max")]
	[Description("最高佣金率")]
	public int? CommissionRateMax { get; set; }

	[JsonPropertyName("service_rate_min")]
	[Description("最低服务费率")]
	public int? ServiceRateMin { get; set; }

	[JsonPropertyName("service_rate_max")]
	[Description("最高服务费率")]
	public int? ServiceRateMax { get; set; }

	[JsonPropertyName("product_category_id")]
	[Description("类目ID")]
	public int? ProductCategoryId { get; set; }

	[JsonPropertyName("inst_acti_name")]
	[Description("团长名称或活动名称-模糊搜索")]
	public string InstActiName { get; set; }

	[JsonPropertyName("retrieve_mode")]
	[Description("获取模式。0: 分页模式（默认），最多返回10000条数据；1: 游标模式（推荐），返回条数无限制")]
	public int? RetrieveMode { get; set; }

	[JsonPropertyName("cursor")]
	[Description("游标。首页不需要传，请求下一页时需传入上一次请求响应的next_cursor值")]
	public string Cursor { get; set; }

	[JsonPropertyName("colonel_buyin_id")]
	[Description("团长百应ID")]
	public long? ColonelBuyinId { get; set; }
}

[Description("接口用于商家获取可参与的团长活动，支持报名状态筛选，包括已提报和未提报两种状态")]
public class BuyinShopActivityListRsp
{
	[JsonPropertyName("data")]
	[Description("数据")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("activity_id")]
		[Description("活动id")]
		public long ActivityId { get; set; }

		[JsonPropertyName("activity_name")]
		[Description("活动名称")]
		public string ActivityName { get; set; }

		[JsonPropertyName("institution_name")]
		[Description("团长名称")]
		public string InstitutionName { get; set; }

		[JsonPropertyName("wechat_id")]
		[Description("微信号")]
		public string WechatId { get; set; }

		[JsonPropertyName("phone_num")]
		[Description("手机号")]
		public string PhoneNum { get; set; }

		[JsonPropertyName("history_order_num")]
		[Description("活动单品平均成交数")]
		public long HistoryOrderNum { get; set; }

		[JsonPropertyName("history_single_product_num")]
		[Description("出单商品数量")]
		public long HistorySingleProductNum { get; set; }

		[JsonPropertyName("apply_start_time")]
		[Description("活动报名开始时间")]
		public string ApplyStartTime { get; set; }

		[JsonPropertyName("apply_end_time")]
		[Description("活动报名结束时间")]
		public string ApplyEndTime { get; set; }

		[JsonPropertyName("commission_rate")]
		[Description("活动要求最低佣金率")]
		public decimal CommissionRate { get; set; }

		[JsonPropertyName("service_rate")]
		[Description("活动要求最低服务费率")]
		public decimal ServiceRate { get; set; }

		[JsonPropertyName("activity_desc")]
		[Description("活动描述")]
		public string ActivityDesc { get; set; }

		[JsonPropertyName("estimated_single_sale")]
		[Description("预估平均成交销售额")]
		public decimal EstimatedSingleSale { get; set; }

		[JsonPropertyName("apply_num")]
		[Description("已报名商品数")]
		public long ApplyNum { get; set; }

		[JsonPropertyName("audit_pass_num")]
		[Description("审核通过商品数")]
		public long AuditPassNum { get; set; }

		[JsonPropertyName("apply_status")]
		[Description("是否报名该活动：已报名1和未报名0")]
		public int ApplyStatus { get; set; }

		[JsonPropertyName("activity_kind")]
		[Description("活动类型（0:专属招商 1:公开招商 ）")]
		public int ActivityKind { get; set; }

		[JsonPropertyName("institution_id")]
		[Description("机构ID")]
		public long InstitutionId { get; set; }

		[JsonPropertyName("colonel_buyin_id")]
		[Description("团长百应ID")]
		public long ColonelBuyinId { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("数据总数，游标模式下不返回")]
	public long Total { get; set; }

	[JsonPropertyName("next_cursor")]
	[Description("下一页游标。游标模式下返回，最后一页返回空")]
	public string NextCursor { get; set; }
}
