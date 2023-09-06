namespace ecommerce.sdk.douyin;

[Description("获取商家的联盟订单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效size","isv.parameter-invalid:1031","无效size")]
[DouyinRetCode(40004,"非法的参数","无效order_ids","isv.parameter-invalid:1032","无效order_ids")]
[DouyinRetCode(40004,"非法的参数","起始查询时间超过了最久查询限制","isv.parameter-invalid:4168","起始查询时间超过了最久查询限制")]
[DouyinRetCode(40004,"非法的参数","无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）","isv.parameter-invalid:1039","无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","请指定时间范围或订单号","isv.parameter-invalid:1033","请指定时间范围或订单号")]
public class BuyinQueryShopAllianceOrderReq : IDouyinReq<BuyinQueryShopAllianceOrderRsp>
{

	public string GetMethod() { return "buyin.queryShopAllianceOrder"; }

	public string GetUrl() { return "/buyin/queryShopAllianceOrder"; }

	[JsonPropertyName("size")]
	[Description("每页订单数目，取值区间： [1, 20]")]
	public long? Size { get; set; }

	[JsonPropertyName("cursor")]
	[Description("下一页索引(第一页传0)")]
	[NotNull]
	public string Cursor { get; set; }

	[JsonPropertyName("start_time")]
	[Description("支付时间开始，最早支持2021年01月01日")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("支付时间结束，该时间不能超过start_time+90天")]
	public string EndTime { get; set; }

	[JsonPropertyName("order_ids")]
	[Description("订单号列表，, 分隔, 最多20个订单号")]
	public string OrderIds { get; set; }

	[JsonPropertyName("time_type")]
	[Description("查询时间类型。pay: 支付时间（默认）; update：联盟侧更新时间，非订单状态更新时间")]
	public string TimeType { get; set; }
}

[Description("获取商家的联盟订单")]
public class BuyinQueryShopAllianceOrderRsp
{
	[JsonPropertyName("data")]
	[Description("返回数据")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("orders")]
		[Description("订单列表")]
		public List<OrdersItem> Orders { get; set; }

		public class OrdersItem
		{
			[JsonPropertyName("distributor_name")]
			[Description("独立抖客昵称")]
			public string DistributorName { get; set; }

			[JsonPropertyName("distributor_buyin_id")]
			[Description("独立抖客百应ID")]
			public string DistributorBuyinId { get; set; }

			[JsonPropertyName("ads_real_commission")]
			[Description("独立抖客实际推广费")]
			public string AdsRealCommission { get; set; }

			[JsonPropertyName("ads_estimated_commission")]
			[Description("独立抖客预估推广费")]
			public string AdsEstimatedCommission { get; set; }

			[JsonPropertyName("ads_promotion_rate")]
			[Description("独立抖客推广费率，此处保存为真实数据x1万之后")]
			public string AdsPromotionRate { get; set; }

			[JsonPropertyName("buyer_app_id")]
			[Description("购买端APP ID(1128:抖音，2329:抖音极速版，1112: 火山，32: 西瓜， 13: 头条)")]
			public string BuyerAppId { get; set; }

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
			[Description("达人预估佣金收入，单位分，机构和达人有绑定关系时返回")]
			public long EstimatedCommission { get; set; }

			[JsonPropertyName("real_commission")]
			[Description("达人实际佣金收入，单位分")]
			public long RealCommission { get; set; }

			[JsonPropertyName("flow_point")]
			[Description("订单状态(PAY_SUCC:支付完成 REFUND:退款 SETTLE:结算 CONFIRM:确认收货)")]
			public string FlowPoint { get; set; }

			[JsonPropertyName("app")]
			[Description("App名称（抖音，火山，西瓜，头条）")]
			public string App { get; set; }

			[JsonPropertyName("update_time")]
			[Description("联盟侧订单更新时间")]
			public string UpdateTime { get; set; }

			[JsonPropertyName("pay_success_time")]
			[Description("付款时间")]
			public string PaySuccessTime { get; set; }

			[JsonPropertyName("settle_time")]
			[Description("结算时间，结算前为空字符串")]
			public string SettleTime { get; set; }

			[JsonPropertyName("pay_goods_amount")]
			[Description("预估参与结算金额，单位分")]
			public long PayGoodsAmount { get; set; }

			[JsonPropertyName("settled_goods_amount")]
			[Description("实际参与结算金额，单位分")]
			public long SettledGoodsAmount { get; set; }

			[JsonPropertyName("shop_id")]
			[Description("店铺ID")]
			public long ShopId { get; set; }

			[JsonPropertyName("shop_estimated_commission")]
			[Description("商家预估佣金支出，单位分")]
			public long ShopEstimatedCommission { get; set; }

			[JsonPropertyName("shop_real_commission")]
			[Description("商家实际佣金支出，单位分")]
			public long ShopRealCommission { get; set; }

			[JsonPropertyName("colonel_order_info")]
			[Description("团长信息")]
			public ColonelOrderInfoItem ColonelOrderInfo { get; set; }

			public class ColonelOrderInfoItem
			{
				[JsonPropertyName("commission_rate")]
				[Description("团长服务费率，此处保存为真实数据x1万之后，如真实是0.35，这里是3500")]
				public long CommissionRate { get; set; }

				[JsonPropertyName("activity_id")]
				[Description("团长活动ID")]
				public long ActivityId { get; set; }

				[JsonPropertyName("estimated_commission")]
				[Description("团长预估服务费，单位分")]
				public long EstimatedCommission { get; set; }

				[JsonPropertyName("real_commission")]
				[Description("团长结算服务费，单位分")]
				public long RealCommission { get; set; }

				[JsonPropertyName("institution_id")]
				[Description("团长机构ID")]
				public long InstitutionId { get; set; }

				[JsonPropertyName("institution_name")]
				[Description("团长机构名称")]
				public string InstitutionName { get; set; }

				[JsonPropertyName("colonel_buyin_id")]
				[Description("团长百应ID")]
				public long ColonelBuyinId { get; set; }
			}

			[JsonPropertyName("settled_tech_service_fee")]
			[Description("平台结算技术服务费，单位分")]
			public long SettledTechServiceFee { get; set; }

			[JsonPropertyName("item_num")]
			[Description("商品数目")]
			public long ItemNum { get; set; }

			[JsonPropertyName("refund_time")]
			[Description("退款时间")]
			public string RefundTime { get; set; }

			[JsonPropertyName("estimated_total_commission")]
			[Description("总佣金（预估），对应百应订单明细中的总佣金，单位分")]
			public long EstimatedTotalCommission { get; set; }

			[JsonPropertyName("author_short_id")]
			[Description("作者抖音号")]
			public string AuthorShortId { get; set; }

			[JsonPropertyName("author_buyin_id")]
			[Description("达人百应ID")]
			public string AuthorBuyinId { get; set; }

			[JsonPropertyName("media_type")]
			[Description("带货体裁。shop_list：橱窗；video：视频；live：直播；others：其他")]
			public string MediaType { get; set; }

			[JsonPropertyName("app_id")]
			[Description("APP ID(1128:抖音，1112: 火山，32: 西瓜， 13: 头条)")]
			public int AppId { get; set; }

			[JsonPropertyName("media_id")]
			[Description("视频/直播间 id")]
			public long MediaId { get; set; }

			[JsonPropertyName("confirm_time")]
			[Description("确认收货时间")]
			public string ConfirmTime { get; set; }

			[JsonPropertyName("extra")]
			[Description("其他")]
			public Dictionary<string,string> Extra { get; set; }
		}

		[JsonPropertyName("cursor")]
		[Description("下一页的索引")]
		public string Cursor { get; set; }
	}
}
