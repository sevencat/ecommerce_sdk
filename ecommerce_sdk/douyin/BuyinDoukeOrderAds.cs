namespace ecommerce.sdk.douyin;

[Description("查询独立抖客分销订单，需要独立抖客百应授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效size","isv.parameter-invalid:4246","参数校验失败：无效size")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效order_ids","isv.parameter-invalid:4247","参数校验失败：无效order_ids")]
[DouyinRetCode(40004,"非法的参数","参数校验失败: 请指定时间范围或订单号","isv.parameter-invalid:4248","参数校验失败: 请指定时间范围或订单号")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效开始时间","isv.parameter-invalid:4249","参数校验失败：无效开始时间")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效结束时间","isv.parameter-invalid:4250","参数校验失败：无效结束时间")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）","isv.parameter-invalid:4251","参数校验失败：无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）")]
[DouyinRetCode(40004,"非法的参数","无效订单查询时间类型","isv.parameter-invalid:4252","无效订单查询时间类型")]
[DouyinRetCode(40004,"非法的参数","起始查询时间超过了最久查询限制","isv.parameter-invalid:4253","起始查询时间超过了最久查询限制")]
[DouyinRetCode(40004,"非法的参数","需【独立抖客】角色授权后访问","isv.parameter-invalid:8198","需【独立抖客】角色授权后访问")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","参数校验失败：无效 PID","isv.business-failed:4102","参数校验失败：无效 PID")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
public class BuyinDoukeOrderAdsReq : IDouyinReq<BuyinDoukeOrderAdsRsp>
{

	public string GetMethod() { return "buyin.doukeOrderAds"; }

	public string GetUrl() { return "/buyin/doukeOrderAds"; }

	[JsonPropertyName("size")]
	[Description("每页订单数目，取值区间： [1, 200]")]
	public long? Size { get; set; }

	[JsonPropertyName("cursor")]
	[Description("下一页索引（第一页传“0”）")]
	public string Cursor { get; set; }

	[JsonPropertyName("start_time")]
	[Description("支付时间开始，最早支持90天前")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("支付时间结束")]
	public string EndTime { get; set; }

	[JsonPropertyName("order_ids")]
	[Description("订单号。多个订单号用英文 , 分隔，最多支持10个订单号")]
	public string OrderIds { get; set; }

	[JsonPropertyName("pid")]
	[Description("抖客PID")]
	public string Pid { get; set; }

	[JsonPropertyName("distribution_type")]
	[Description("分销类型。Live-直播间分销订单，ProductDetail-商品分销订单，ActivityMaterial-活动页订单")]
	public string DistributionType { get; set; }

	[JsonPropertyName("time_type")]
	[Description("查询时间类型。pay: 支付时间（默认）; update：联盟侧更新时间，非订单状态更新时间")]
	public string TimeType { get; set; }

	[JsonPropertyName("query_order_type")]
	[Description("不填或者填0：查询分销订单，1：查询比价订单")]
	public long? QueryOrderType { get; set; }
}

[Description("查询独立抖客分销订单，需要独立抖客百应授权")]
public class BuyinDoukeOrderAdsRsp
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
			[JsonPropertyName("distributor_right_type")]
			[Description("权益类型，下单用券类型，空或者Unknown为无权益，ColonelExclusiveCoupon(抖客团长券)，可能同时存在多个权益，以逗号隔开")]
			public string DistributorRightType { get; set; }

			[JsonPropertyName("product_tags")]
			[Description("商品分销订单-商品标签信息")]
			public ProductTagsItem ProductTags { get; set; }

			public class ProductTagsItem
			{
				[JsonPropertyName("has_supermarket_tag")]
				[Description("是否抖音超市(次日达)商品")]
				public bool HasSupermarketTag { get; set; }

				[JsonPropertyName("has_subsidy_tag")]
				[Description("是否超值购商品")]
				public bool HasSubsidyTag { get; set; }
			}

			[JsonPropertyName("confirm_time")]
			[Description("收货时间")]
			public string ConfirmTime { get; set; }

			[JsonPropertyName("material_id")]
			[Description("活动页物料ID")]
			public string MaterialId { get; set; }

			[JsonPropertyName("author_buyin_id")]
			[Description("被分销达人百应ID（仅直播间分销订单拥有）")]
			public string AuthorBuyinId { get; set; }

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
			[Description("作者账号昵称(抖音/火山作者)（仅直播间分销订单有）")]
			public string AuthorAccount { get; set; }

			[JsonPropertyName("shop_name")]
			[Description("商家名称")]
			public string ShopName { get; set; }

			[JsonPropertyName("total_pay_amount")]
			[Description("订单支付金额，单位分")]
			public long TotalPayAmount { get; set; }

			[JsonPropertyName("flow_point")]
			[Description("订单状态。PAY_SUCC：支付完成； REFUND：退款； SETTLE：结算；CONFIRM：确认收货")]
			public string FlowPoint { get; set; }

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
				[Description("分销回流类型。live： 直播间分销； ProductDetail：商品分销； Activity： 百补和秒杀推广；Shop：店铺导流")]
				public string MediaTypeName { get; set; }
			}

			[JsonPropertyName("item_num")]
			[Description("商品数目")]
			public long ItemNum { get; set; }

			[JsonPropertyName("refund_time")]
			[Description("退款订单退款时间")]
			public string RefundTime { get; set; }

			[JsonPropertyName("ads_estimated_commission")]
			[Description("预估推广费收入，单位分")]
			public long AdsEstimatedCommission { get; set; }

			[JsonPropertyName("ads_real_commission")]
			[Description("实际推广费收入，单位分")]
			public long AdsRealCommission { get; set; }

			[JsonPropertyName("author_short_id")]
			[Description("达人抖音号（仅直播间分销订单有）")]
			public string AuthorShortId { get; set; }

			[JsonPropertyName("ads_promotion_rate")]
			[Description("推广费率")]
			public long AdsPromotionRate { get; set; }

			[JsonPropertyName("media_type")]
			[Description("带货体裁。shop_list：橱窗；video：视频；live：直播；others：其他")]
			public string MediaType { get; set; }

			[JsonPropertyName("ads_activity_id")]
			[Description("活动页推广活动Id，1000-超值购 1001-秒杀;若distribution_type为Mix，则为Mix活动ID")]
			public long AdsActivityId { get; set; }

			[JsonPropertyName("ads_estimated_tech_service_fee")]
			[Description("推广技术服务费")]
			public long AdsEstimatedTechServiceFee { get; set; }

			[JsonPropertyName("ads_fans_type")]
			[Description("直播间分销订单：新老粉")]
			public string AdsFansType { get; set; }

			[JsonPropertyName("product_activity_id")]
			[Description("商品参与的活动id，0: 未参加活动 1: 超值购（活动页单品推广）")]
			public string ProductActivityId { get; set; }
		}

		[JsonPropertyName("cursor")]
		[Description("下一页的索引")]
		public string Cursor { get; set; }
	}
}
