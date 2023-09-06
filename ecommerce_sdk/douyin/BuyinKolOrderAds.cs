namespace ecommerce.sdk.douyin;

[Description("查询达人的直播间分销、商品分销、活动页分销订单，需要达人百应授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","获取用户客户端账户信息失败","isv.business-failed:4158","获取用户客户端账户信息失败")]
[DouyinRetCode(40004,"非法的参数","无效size","isv.parameter-invalid:1031","无效size")]
[DouyinRetCode(40004,"非法的参数","无效order_ids","isv.parameter-invalid:1032","无效order_ids")]
[DouyinRetCode(40004,"非法的参数","请指定时间范围或订单号","isv.parameter-invalid:1033","请指定时间范围或订单号")]
[DouyinRetCode(40004,"非法的参数","无效开始时间","isv.parameter-invalid:1034","无效开始时间")]
[DouyinRetCode(40004,"非法的参数","无效结束时间","isv.parameter-invalid:1035","无效结束时间")]
[DouyinRetCode(40004,"非法的参数","无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）","isv.parameter-invalid:1036","无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）")]
[DouyinRetCode(40004,"非法的参数","无效 PID","isv.parameter-invalid:1039","无效 PID")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","256:服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","起始查询时间超过了最久查询限制","isv.parameter-invalid:4168","起始查询时间超过了最久查询限制")]
[DouyinRetCode(50002,"业务处理失败","无效订单查询时间类型","isv.business-failed:282","无效订单查询时间类型")]
public class BuyinKolOrderAdsReq : IDouyinReq<BuyinKolOrderAdsRsp>
{

	public string GetMethod() { return "buyin.kolOrderAds"; }

	public string GetUrl() { return "/buyin/kolOrderAds"; }

	[JsonPropertyName("size")]
	[Description("每页订单数目，取值区间： [1, 20]")]
	public long? Size { get; set; }

	[JsonPropertyName("cursor")]
	[Description("下一页索引（第一页传“0”）")]
	public string Cursor { get; set; }

	[JsonPropertyName("start_time")]
	[Description("支付时间开始，最早支持2021年10月01日")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("支付时间结束，该时间不能超过start_time+90")]
	public string EndTime { get; set; }

	[JsonPropertyName("order_ids")]
	[Description("订单号。多个订单号用英文 , 分隔，最多支持10个订单号")]
	public string OrderIds { get; set; }

	[JsonPropertyName("pid")]
	[Description("PID")]
	public string Pid { get; set; }

	[JsonPropertyName("distribution_type")]
	[Description("Live-直播间，ProductDetail-商品详情，Activity-活动（百亿补贴/秒杀）Mix-H5自建活动页")]
	public string DistributionType { get; set; }

	[JsonPropertyName("open_id")]
	[Description("用户抖店open_id")]
	public string OpenId { get; set; }

	[JsonPropertyName("time_type")]
	[Description("查询时间类型。pay: 支付时间（默认）; update：联盟侧更新时间，非订单状态更新时间")]
	public string TimeType { get; set; }

	[JsonPropertyName("query_order_type")]
	[Description("不填或者填0：查询分销订单，1：查询比价订单")]
	public long? QueryOrderType { get; set; }
}

[Description("查询达人的直播间分销、商品分销、活动页分销订单，需要达人百应授权")]
public class BuyinKolOrderAdsRsp
{
	[JsonPropertyName("data")]
	[Description("结果")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("orders")]
		[Description("订单列表")]
		public List<OrdersItem> Orders { get; set; }

		public class OrdersItem
		{
			[JsonPropertyName("order_id")]
			[Description("订单号")]
			public string OrderId { get; set; }

			[JsonPropertyName("product_id")]
			[Description("商品id")]
			public string ProductId { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("product_img")]
			[Description("商品图片URL")]
			public string ProductImg { get; set; }

			[JsonPropertyName("author_account")]
			[Description("作者账号昵称(抖音/火山作者)")]
			public string AuthorAccount { get; set; }

			[JsonPropertyName("author_openid")]
			[Description("作者抖店open_id")]
			public string AuthorOpenid { get; set; }

			[JsonPropertyName("shop_name")]
			[Description("商家名称")]
			public string ShopName { get; set; }

			[JsonPropertyName("total_pay_amount")]
			[Description("订单支付金额，单位分")]
			public long TotalPayAmount { get; set; }

			[JsonPropertyName("commission_rate")]
			[Description("达人佣金率，此处保存为真实数据x1万之后，如真实是0.35，这里是3500")]
			public long CommissionRate { get; set; }

			[JsonPropertyName("estimated_commission")]
			[Description("达人预估佣金收入，单位分")]
			public long EstimatedCommission { get; set; }

			[JsonPropertyName("real_commission")]
			[Description("达人实际佣金收入，单位分")]
			public long RealCommission { get; set; }

			[JsonPropertyName("flow_point")]
			[Description("订单状态(PAY_SUCC:支付完成 REFUND:退款 SETTLE:结算 CONFIRM: 确认收货)")]
			public string FlowPoint { get; set; }

			[JsonPropertyName("app")]
			[Description("App名称（抖音，火山）")]
			public string App { get; set; }

			[JsonPropertyName("buyer_openid")]
			[Description("下单用户抖店open_id")]
			public string BuyerOpenid { get; set; }

			[JsonPropertyName("update_time")]
			[Description("更新时间 [联盟侧订单更新时间]")]
			public string UpdateTime { get; set; }

			[JsonPropertyName("pay_success_time")]
			[Description("付款时间")]
			public string PaySuccessTime { get; set; }

			[JsonPropertyName("settle_time")]
			[Description("结算时间，结算前为空字符串")]
			public string SettleTime { get; set; }

			[JsonPropertyName("pay_goods_amount")]
			[Description("预估参与结算金额")]
			public long PayGoodsAmount { get; set; }

			[JsonPropertyName("settled_goods_amount")]
			[Description("实际参与结算金额")]
			public long SettledGoodsAmount { get; set; }

			[JsonPropertyName("shop_id")]
			[Description("店铺ID")]
			public long ShopId { get; set; }

			[JsonPropertyName("shop_estimated_commission")]
			[Description("店铺预估佣金支出")]
			public long ShopEstimatedCommission { get; set; }

			[JsonPropertyName("shop_real_commission")]
			[Description("店铺实际佣金支出")]
			public long ShopRealCommission { get; set; }

			[JsonPropertyName("estimated_tech_service_fee")]
			[Description("预估平台技术服务费")]
			public long EstimatedTechServiceFee { get; set; }

			[JsonPropertyName("settled_tech_service_fee")]
			[Description("实际参与结算金额")]
			public long SettledTechServiceFee { get; set; }

			[JsonPropertyName("pid_info")]
			[Description("分销订单相关参数")]
			public PidInfoItem PidInfo { get; set; }

			public class PidInfoItem
			{
				[JsonPropertyName("pid")]
				[Description("PID")]
				public string Pid { get; set; }

				[JsonPropertyName("external_info")]
				[Description("外部参数")]
				public string ExternalInfo { get; set; }

				[JsonPropertyName("media_type_name")]
				[Description("Live-直播间，ProductDetail-商品详情，Activity-活动（百亿补贴/秒杀）Mix-H5自建活动页")]
				public string MediaTypeName { get; set; }
			}

			[JsonPropertyName("item_num")]
			[Description("商品数目")]
			public long ItemNum { get; set; }

			[JsonPropertyName("refund_time")]
			[Description("退款订单退款时间")]
			public string RefundTime { get; set; }

			[JsonPropertyName("estimated_total_commission")]
			[Description("总佣金（预估），对应百应订单明细中的总佣金")]
			public long EstimatedTotalCommission { get; set; }

			[JsonPropertyName("pick_source_client_key")]
			[Description("废弃")]
			public string PickSourceClientKey { get; set; }

			[JsonPropertyName("ads_split_rate")]
			[Description("达人/自播商家给直播间分销渠道设置的分成比")]
			public long AdsSplitRate { get; set; }

			[JsonPropertyName("ads_estimated_commission")]
			[Description("Live：直播间分销渠道预估佣金收入，单位分 2. Activity&Mix：预估推广费收入，单位分")]
			public long AdsEstimatedCommission { get; set; }

			[JsonPropertyName("ads_real_commission")]
			[Description("Live：直播间分销渠道实际佣金收入，单位分 2. Activity&Mix：结算推广费收入，单位分")]
			public long AdsRealCommission { get; set; }

			[JsonPropertyName("author_short_id")]
			[Description("达人抖音号")]
			public string AuthorShortId { get; set; }

			[JsonPropertyName("ads_promotion_rate")]
			[Description("达人/自播商家给直播间分销渠道设置的推广费率")]
			public long AdsPromotionRate { get; set; }

			[JsonPropertyName("author_buyin_id")]
			[Description("达人百应ID")]
			public string AuthorBuyinId { get; set; }

			[JsonPropertyName("media_type")]
			[Description("带货体裁。shop_list：橱窗；video：视频；live：直播；others：其他")]
			public string MediaType { get; set; }

			[JsonPropertyName("live_ads_type")]
			[Description("直播间分销模式，Self 或者 Purchase")]
			public string LiveAdsType { get; set; }

			[JsonPropertyName("ads_activity_id")]
			[Description("活动页推广活动Id，1000-超值购 1001-秒杀;若distribution_type为Mix，则为Mix活动ID")]
			public long AdsActivityId { get; set; }

			[JsonPropertyName("ads_estimated_tech_service_fee")]
			[Description("推广技术服务费")]
			public string AdsEstimatedTechServiceFee { get; set; }

			[JsonPropertyName("product_activity_id")]
			[Description("商品参与的活动id，0: 未参加活动 1: 超值购（活动页单品推广）")]
			public string ProductActivityId { get; set; }

			[JsonPropertyName("ads_fans_type")]
			[Description("直播间分销订单：新老粉")]
			public string AdsFansType { get; set; }
		}

		[JsonPropertyName("cursor")]
		[Description("下一页索引")]
		public string Cursor { get; set; }
	}
}
