namespace ecommerce.sdk.douyin;

[Description("查询MCN机构的抖音、火山、西瓜和头条的联盟订单（MCN机构需要与达人需完成账号绑定），需要MCN机构百应授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效size","isv.parameter-invalid:1031","参数校验失败：无效size")]
[DouyinRetCode(40004,"非法的参数","无效order_ids","isv.parameter-invalid:1032","参数校验失败：无效order_ids")]
[DouyinRetCode(40004,"非法的参数","请指定时间范围或订单号","isv.parameter-invalid:1033","参数校验失败: 请指定时间范围或订单号")]
[DouyinRetCode(40004,"非法的参数","无效开始时间","isv.parameter-invalid:1034","参数校验失败：无效开始时间")]
[DouyinRetCode(40004,"非法的参数","无效结束时间","isv.parameter-invalid:1035","参数校验失败：无效结束时间")]
[DouyinRetCode(40004,"非法的参数","无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）","isv.parameter-invalid:1036","参数校验失败：无效时间区间（开始时间不能大于结束时间，并且不能小于t-90d）")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","起始查询时间超过了最久查询限制","isv.business-failed:4168","起始查询时间超过了最久查询限制")]
[DouyinRetCode(50002,"业务处理失败","需【电商MCN机构】角色授权后访问","isv.business-failed:4196","需【电商MCN机构】角色授权后访问")]
public class BuyinInstituteOrderMCNReq : IDouyinReq<BuyinInstituteOrderMCNRsp>
{

	public string GetMethod() { return "buyin.instituteOrderMCN"; }

	public string GetUrl() { return "/buyin/instituteOrderMCN"; }

	[JsonPropertyName("size")]
	[Description("每页订单数目，取值区间： [1, 200]")]
	public long? Size { get; set; }

	[JsonPropertyName("cursor")]
	[Description("下一页索引（第一页传“0”）")]
	public string Cursor { get; set; }

	[JsonPropertyName("start_time")]
	[Description("支付时间开始，最早支持2021年01月01日")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("支付时间结束，该时间不能超过start_time+90")]
	public string EndTime { get; set; }

	[JsonPropertyName("order_ids")]
	[Description("订单号，时间范围和订单号必须指定至少一个。多个订单号用英文 , 分隔，最多支持10个订单号")]
	public string OrderIds { get; set; }

	[JsonPropertyName("time_type")]
	[Description("查询时间类型。pay: 支付时间（默认）; update：联盟侧更新时间，非订单状态更新时间")]
	public string TimeType { get; set; }
}

[Description("查询MCN机构的抖音、火山、西瓜和头条的联盟订单（MCN机构需要与达人需完成账号绑定），需要MCN机构百应授权")]
public class BuyinInstituteOrderMCNRsp
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
			[Description("达人佣金率，此处保存为真实数据x1万之后，如真实是35%，这里是3500")]
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
			[Description("App名称（抖音，火山，西瓜，头条）")]
			public string App { get; set; }

			[JsonPropertyName("update_time")]
			[Description("更新时间  [联盟侧订单更新时间]")]
			public string UpdateTime { get; set; }

			[JsonPropertyName("pay_success_time")]
			[Description("付款时间")]
			public string PaySuccessTime { get; set; }

			[JsonPropertyName("settle_time")]
			[Description("结算时间")]
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
			[Description("预估佣金支出")]
			public long ShopEstimatedCommission { get; set; }

			[JsonPropertyName("shop_real_commission")]
			[Description("实际佣金支出")]
			public long ShopRealCommission { get; set; }

			[JsonPropertyName("alliance_split_rate")]
			[Description("分成比例")]
			public long AllianceSplitRate { get; set; }

			[JsonPropertyName("tech_service_fee_rate")]
			[Description("平台技术服务费率")]
			public long TechServiceFeeRate { get; set; }

			[JsonPropertyName("estimated_tech_service_fee")]
			[Description("预估平台技术服务费")]
			public long EstimatedTechServiceFee { get; set; }

			[JsonPropertyName("settled_tech_service_fee")]
			[Description("结算平台技术服务费")]
			public long SettledTechServiceFee { get; set; }

			[JsonPropertyName("estimated_institution_commission")]
			[Description("预估机构分成")]
			public long EstimatedInstitutionCommission { get; set; }

			[JsonPropertyName("institution_commission")]
			[Description("机构分成")]
			public long InstitutionCommission { get; set; }

			[JsonPropertyName("pid_info")]
			[Description("分销PID信息")]
			public PidInfoItem PidInfo { get; set; }

			public class PidInfoItem
			{
				[JsonPropertyName("pid")]
				[Description("PID")]
				public string Pid { get; set; }

				[JsonPropertyName("external_info")]
				[Description("自定义参数")]
				public string ExternalInfo { get; set; }

				[JsonPropertyName("media_type_name")]
				[Description("分销类型，直播：Live, 商品: ProductDetail")]
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

			[JsonPropertyName("ads_estimated_commission")]
			[Description("渠道预估佣金收入，单位分")]
			public long AdsEstimatedCommission { get; set; }

			[JsonPropertyName("ads_real_commission")]
			[Description("渠道实际佣金收入，单位分")]
			public long AdsRealCommission { get; set; }

			[JsonPropertyName("author_short_id")]
			[Description("作者抖音/火山号")]
			public string AuthorShortId { get; set; }

			[JsonPropertyName("ads_promotion_rate")]
			[Description("达人/自播商家给渠道设置的推广费率")]
			public long AdsPromotionRate { get; set; }

			[JsonPropertyName("extra")]
			[Description("其他")]
			public Dictionary<string,string> Extra { get; set; }

			[JsonPropertyName("author_buyin_id")]
			[Description("达人百应ID")]
			public string AuthorBuyinId { get; set; }

			[JsonPropertyName("media_type")]
			[Description("带货体裁类型。shop_list：橱窗；video：视频；live：直播；others：其他")]
			public string MediaType { get; set; }

			[JsonPropertyName("media_id")]
			[Description("带货体裁 id（只返回视频/直播间 id）")]
			public long MediaId { get; set; }

			[JsonPropertyName("pay_subsidy")]
			[Description("支付补贴（单位：分）")]
			public long PaySubsidy { get; set; }

			[JsonPropertyName("platform_subsidy")]
			[Description("平台补贴（单位：分）")]
			public long PlatformSubsidy { get; set; }

			[JsonPropertyName("author_subsidy")]
			[Description("达人补贴（单位：分）")]
			public long AuthorSubsidy { get; set; }

			[JsonPropertyName("estimated_user_stepped_commission")]
			[Description("达人预估奖励佣金收入（单位：分）")]
			public long EstimatedUserSteppedCommission { get; set; }

			[JsonPropertyName("estimated_inst_stepped_commission")]
			[Description("机构预估奖励佣金收入（单位：分）")]
			public long EstimatedInstSteppedCommission { get; set; }

			[JsonPropertyName("settle_user_stepped_commission")]
			[Description("达人结算奖励佣金收入（单位：分）")]
			public long SettleUserSteppedCommission { get; set; }

			[JsonPropertyName("settle_inst_stepped_commission")]
			[Description("机构结算奖励佣金收入（单位：分）")]
			public long SettleInstSteppedCommission { get; set; }

			[JsonPropertyName("is_stepped_plan")]
			[Description("是否为阶梯佣金")]
			public bool IsSteppedPlan { get; set; }
		}

		[JsonPropertyName("cursor")]
		[Description("下一页索引")]
		public string Cursor { get; set; }
	}
}
