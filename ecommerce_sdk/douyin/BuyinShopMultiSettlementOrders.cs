namespace ecommerce.sdk.douyin;

[Description("查询商家分次结算订单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效size","isv.parameter-invalid:1031","无效size")]
[DouyinRetCode(40004,"非法的参数","无效订单查询时间类型","isv.parameter-invalid:282","无效订单查询时间类型")]
[DouyinRetCode(40004,"非法的参数","无效order_ids","isv.parameter-invalid:1032","无效order_ids")]
[DouyinRetCode(40004,"非法的参数","请指定时间范围或订单号","isv.parameter-invalid:1033","请指定时间范围或订单号")]
[DouyinRetCode(40004,"非法的参数","无效开始时间","isv.parameter-invalid:1034","无效开始时间")]
[DouyinRetCode(40004,"非法的参数","无效结束时间","isv.parameter-invalid:1035","无效结束时间")]
[DouyinRetCode(40004,"非法的参数","无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）","isv.parameter-invalid:1036","无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","无效cursor","isv.parameter-invalid:284","无效cursor")]
public class BuyinShopMultiSettlementOrdersReq : IDouyinReq<BuyinShopMultiSettlementOrdersRsp>
{

	public string GetMethod() { return "buyin.shopMultiSettlementOrders"; }

	public string GetUrl() { return "/buyin/shopMultiSettlementOrders"; }

	[JsonPropertyName("size")]
	[Description("查询数目，最大100")]
	public long? Size { get; set; }

	[JsonPropertyName("cursor")]
	[Description("下一页索引，第一页传‘0’")]
	public string Cursor { get; set; }

	[JsonPropertyName("time_type")]
	[Description("查询时间类型：settle（结算时间），update（更新时间，默认值）")]
	public string TimeType { get; set; }

	[JsonPropertyName("start_time")]
	[Description("开始时间")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("结束时间，与开始时间相差不能超过90天")]
	public string EndTime { get; set; }

	[JsonPropertyName("order_ids")]
	[Description("订单号列表")]
	public string OrderIds { get; set; }
}

[Description("查询商家分次结算订单")]
public class BuyinShopMultiSettlementOrdersRsp
{
	[JsonPropertyName("data")]
	[Description("返回结果")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("orders")]
		[Description("订单列表")]
		public List<OrdersItem> Orders { get; set; }

		public class OrdersItem
		{
			[JsonPropertyName("ads_buyin_id")]
			[Description("独立抖客百应ID")]
			public string AdsBuyinId { get; set; }

			[JsonPropertyName("order_id")]
			[Description("订单号")]
			public string OrderId { get; set; }

			[JsonPropertyName("product_id")]
			[Description("商品id")]
			public string ProductId { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("author_buyin_id")]
			[Description("达人百应ID(火山订单返回达人抖音百应ID，西瓜订单返回达人头条百应ID)")]
			public string AuthorBuyinId { get; set; }

			[JsonPropertyName("author_account")]
			[Description("作者账号昵称(抖音/火山作者)")]
			public string AuthorAccount { get; set; }

			[JsonPropertyName("short_id")]
			[Description("作者火山/抖音号")]
			public string ShortId { get; set; }

			[JsonPropertyName("shop_id")]
			[Description("店铺ID")]
			public long ShopId { get; set; }

			[JsonPropertyName("settle_shop_commission")]
			[Description("商家结算基础佣金支出，单位分")]
			public long SettleShopCommission { get; set; }

			[JsonPropertyName("is_stepped_plan")]
			[Description("是否阶梯佣金")]
			public bool IsSteppedPlan { get; set; }

			[JsonPropertyName("colonel_buyin_id")]
			[Description("团长百应ID")]
			public string ColonelBuyinId { get; set; }

			[JsonPropertyName("colonel_institution_name")]
			[Description("团长名称")]
			public string ColonelInstitutionName { get; set; }

			[JsonPropertyName("colonel_activity_id")]
			[Description("团长活动ID")]
			public long ColonelActivityId { get; set; }

			[JsonPropertyName("settle_colonel_commission")]
			[Description("一级团长服务费，单位分")]
			public long SettleColonelCommission { get; set; }

			[JsonPropertyName("settle_colonel_tech_service_fee")]
			[Description("一级团长平台技术服务费，单位分")]
			public long SettleColonelTechServiceFee { get; set; }

			// [JsonPropertyName("ads_buyin_id")]
			// [Description("抖客百应ID")]
			// public string AdsBuyinId { get; set; }

			[JsonPropertyName("distribution_type")]
			[Description("结算模式,directIn-直推;intersect-跨播;member-会员绑定;live_appoint-直播预约")]
			public string DistributionType { get; set; }

			[JsonPropertyName("pid")]
			[Description("pid")]
			public string Pid { get; set; }

			[JsonPropertyName("site_name")]
			[Description("渠道名称")]
			public string SiteName { get; set; }

			[JsonPropertyName("settle_ads_tech_service_fee")]
			[Description("抖客结算平台服务费，单位分")]
			public long SettleAdsTechServiceFee { get; set; }

			[JsonPropertyName("settle_ads_commission")]
			[Description("抖客结算佣金，单位分")]
			public long SettleAdsCommission { get; set; }

			[JsonPropertyName("real_service_fee")]
			[Description("实际服务费，单位分")]
			public long RealServiceFee { get; set; }

			[JsonPropertyName("phase_id")]
			[Description("第 phase_id 次结算")]
			public long PhaseId { get; set; }

			[JsonPropertyName("settle_time")]
			[Description("结算时间")]
			public string SettleTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("更新时间")]
			public string UpdateTime { get; set; }
		}

		[JsonPropertyName("cursor")]
		[Description("下一页的索引，最返回空时结束")]
		public string Cursor { get; set; }
	}
}
