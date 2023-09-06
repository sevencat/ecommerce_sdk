namespace ecommerce.sdk.douyin;

[Description("数据T+1生成，建议第二天12点之后查询，,即中午12点之前请求前天的数据，12点之后再请求昨天的数据。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","621000704:调用下游失败，请稍后重试","isv.business-failed:621000704","请重试")]
[DouyinRetCode(50002,"业务处理失败","621000625:当前没有权限访问","isv.business-failed:621000625","请检查是否拥有权限")]
[DouyinRetCode(50002,"业务处理失败","621000602:参数非法","isv.business-failed:621000602","")]
public class CompassCommonProductQueryDataReq : IDouyinReq<CompassCommonProductQueryDataRsp>
{

	public string GetMethod() { return "compass.CommonProductQueryData"; }

	public string GetUrl() { return "/compass/CommonProductQueryData"; }

	[JsonPropertyName("end_date")]
	[Description("周期结束时间,T-1;如3月24号查询近7天的数据，入参date_type=21&&end_date=“2023-03-23”")]
	[NotNull]
	public string EndDate { get; set; }

	[JsonPropertyName("date_type")]
	[Description("REALTIME          = 1   // 实时 BeginDate和EndDate都不传入 表示查询今日实时数据 BeginDate和EndDate都传入 表示查询BeginDate～EndDate的实时数据；     DAY               = 2   // 自然日 BeginDate和EndDate都传入 表示查询趋势 只传入BeginDate表示查询该自然日；     WEEK              = 3   // 自然周 传入BeginDate（周一的日期） 指定对应自然周；     MONTH             = 4   // 自然月 传入BeginDate（月一号的日期） 指定对应自然月；     LAST_ONE_DAYS     = 20  // 近一日；     LAST_SEVEN_DAYS   = 21  // 近七日 当日为基准；     LAST_THREE_DAYS   = 22  // 近三日 当日为基准；     LAST_ONE_MONTH    = 23  // 近30日 当日为基准；")]
	[NotNull]
	public int? DateType { get; set; }

	[JsonPropertyName("activity_id")]
	[Description("大促id，非大促默认使用空字符串“”")]
	public string ActivityId { get; set; }

	[JsonPropertyName("begin_date")]
	[Description("周期开始时间")]
	[NotNull]
	public string BeginDate { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品id")]
	[NotNull]
	public string ProductId { get; set; }

	[JsonPropertyName("page_no")]
	[Description("页码，默认为1")]
	public long? PageNo { get; set; }

	[JsonPropertyName("page_size")]
	[Description("页面大小，默认为10")]
	public long? PageSize { get; set; }

	[JsonPropertyName("sorted_field")]
	[Description("排序字段，支持product_show_ucnt,product_click_ucnt,product_click_ratio,pay_ucnt,pay_cnt,product_pay_ratio")]
	public string SortedField { get; set; }

	[JsonPropertyName("is_asc")]
	[Description("排序方向，默认降序")]
	public bool? IsAsc { get; set; }
}

[Description("数据T+1生成，建议第二天12点之后查询，,即中午12点之前请求前天的数据，12点之后再请求昨天的数据。")]
public class CompassCommonProductQueryDataRsp
{
	[JsonPropertyName("product_list")]
	[Description("商品数据")]
	public List<ProductListItem> ProductList { get; set; }

	public class ProductListItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品id")]
		public long ProductId { get; set; }

		[JsonPropertyName("query")]
		[Description("搜索词")]
		public string Query { get; set; }

		[JsonPropertyName("product_show_ucnt")]
		[Description("商品曝光人数")]
		public long ProductShowUcnt { get; set; }

		[JsonPropertyName("product_click_ucnt")]
		[Description("商品点击人数")]
		public long ProductClickUcnt { get; set; }

		[JsonPropertyName("product_click_ratio")]
		[Description("商品点击率, 0.2表示20%")]
		public decimal ProductClickRatio { get; set; }

		[JsonPropertyName("product_pay_ucnt")]
		[Description("商品成交人数")]
		public long ProductPayUcnt { get; set; }

		[JsonPropertyName("product_pay_ratio")]
		[Description("商品成交率, 0.2表示20%")]
		public decimal ProductPayRatio { get; set; }

		[JsonPropertyName("product_pay_cnt")]
		[Description("商品成交次数")]
		public long ProductPayCnt { get; set; }
	}
}
