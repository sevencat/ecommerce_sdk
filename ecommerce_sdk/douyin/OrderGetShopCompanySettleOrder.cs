namespace ecommerce.sdk.douyin;

[Description("查询抖超小时达子公司的结算明细。数据T+1生成，建议第二天15点之后查询。如因任务积压导致延迟的情况，建议重试。")]
[DouyinRetCode(10000,"success","","","")]
public class OrderGetShopCompanySettleOrderReq : IDouyinReq<OrderGetShopCompanySettleOrderRsp>
{

	public string GetMethod() { return "order.getShopCompanySettleOrder"; }

	public string GetUrl() { return "/order/getShopCompanySettleOrder"; }

	[JsonPropertyName("page_no")]
	[Description("页码，从0开始")]
	[NotNull]
	public long? PageNo { get; set; }

	[JsonPropertyName("page_size")]
	[Description("分页大小，取值范围[1, 100]")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("role_type")]
	[Description("子公司，默认COMPANY；")]
	[NotNull]
	public string RoleType { get; set; }

	[JsonPropertyName("role_id")]
	[Description("子公司id")]
	[NotNull]
	public string RoleId { get; set; }

	[JsonPropertyName("start_time")]
	[Description("起始时间")]
	[NotNull]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("截止时间")]
	[NotNull]
	public string EndTime { get; set; }

	[JsonPropertyName("order_id")]
	[Description("订单号（子单号维度，即sku单维度）")]
	public string OrderId { get; set; }

	[JsonPropertyName("pay_type")]
	[Description("支付方式;PA-聚合支付，WX-微信支付；")]
	public string PayType { get; set; }
}

[Description("查询抖超小时达子公司的结算明细。数据T+1生成，建议第二天15点之后查询。如因任务积压导致延迟的情况，建议重试。")]
public class OrderGetShopCompanySettleOrderRsp
{
	[JsonPropertyName("code")]
	[Description("返回码")]
	public string Code { get; set; }

	[JsonPropertyName("code_msg")]
	[Description("返回消息")]
	public string CodeMsg { get; set; }

	[JsonPropertyName("data")]
	[Description("返回的订单信息")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("settle_time")]
		[Description("结算时间")]
		public string SettleTime { get; set; }

		[JsonPropertyName("request_no")]
		[Description("结算请求单号")]
		public string RequestNo { get; set; }

		[JsonPropertyName("shop_order_id")]
		[Description("店铺单号（主订单）")]
		public string ShopOrderId { get; set; }

		[JsonPropertyName("order_id")]
		[Description("订单号（子单号）")]
		public string OrderId { get; set; }

		[JsonPropertyName("settle_amount")]
		[Description("结算金额；单位：分")]
		public long SettleAmount { get; set; }

		[JsonPropertyName("pay_type_desc")]
		[Description("账户类型")]
		public string PayTypeDesc { get; set; }

		[JsonPropertyName("trade_type_desc")]
		[Description("结算交易类型")]
		public string TradeTypeDesc { get; set; }

		[JsonPropertyName("contains_refund_before_settle")]
		[Description("是否有结算前退款；")]
		public string ContainsRefundBeforeSettle { get; set; }

		[JsonPropertyName("order_time")]
		[Description("下单时间")]
		public string OrderTime { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品id（主商品）")]
		public string ProductId { get; set; }

		[JsonPropertyName("goods_count")]
		[Description("商品数量")]
		public int GoodsCount { get; set; }

		[JsonPropertyName("flow_type_desc")]
		[Description("流量标识")]
		public string FlowTypeDesc { get; set; }

		[JsonPropertyName("order_type")]
		[Description("订单类型")]
		public string OrderType { get; set; }

		[JsonPropertyName("total_amount")]
		[Description("订单总价；单位：分")]
		public long TotalAmount { get; set; }

		[JsonPropertyName("total_goods_amount")]
		[Description("货款总价；单位：分")]
		public long TotalGoodsAmount { get; set; }

		[JsonPropertyName("post_amount")]
		[Description("运费；单位：分")]
		public long PostAmount { get; set; }

		[JsonPropertyName("shop_coupon")]
		[Description("店铺补贴金额；单位：分")]
		public long ShopCoupon { get; set; }

		[JsonPropertyName("refund_before_settle")]
		[Description("结算前退款金额；单位：分")]
		public long RefundBeforeSettle { get; set; }

		[JsonPropertyName("platform_coupon")]
		[Description("平台补贴；单位：分")]
		public long PlatformCoupon { get; set; }

		[JsonPropertyName("author_coupon")]
		[Description("达人补贴；单位：分")]
		public long AuthorCoupon { get; set; }

		[JsonPropertyName("zt_pay_promotion")]
		[Description("抖音支付补贴；单位：分")]
		public long ZtPayPromotion { get; set; }

		[JsonPropertyName("zr_pay_promotion")]
		[Description("抖音月付补贴单位：分")]
		public long ZrPayPromotion { get; set; }

		[JsonPropertyName("real_pay_amount")]
		[Description("用户实付金额；单位：分")]
		public long RealPayAmount { get; set; }

		[JsonPropertyName("total_income")]
		[Description("总收入；单位：分")]
		public long TotalIncome { get; set; }

		[JsonPropertyName("platform_service_fee")]
		[Description("平台服务费；单位：分")]
		public long PlatformServiceFee { get; set; }

		[JsonPropertyName("commission")]
		[Description("佣金；单位：分")]
		public long Commission { get; set; }

		[JsonPropertyName("good_learn_channel_fee")]
		[Description("渠道分成；单位：分")]
		public long GoodLearnChannelFee { get; set; }

		[JsonPropertyName("colonel_service_fee")]
		[Description("招商技术服务费；单位：分")]
		public long ColonelServiceFee { get; set; }

		[JsonPropertyName("channel_promotion_fee")]
		[Description("直播间站外推广费用；单位：分")]
		public long ChannelPromotionFee { get; set; }

		[JsonPropertyName("other_sharing_amount")]
		[Description("其他分成；单位：分")]
		public long OtherSharingAmount { get; set; }

		[JsonPropertyName("total_outcome")]
		[Description("总支出；单位：分")]
		public long TotalOutcome { get; set; }

		[JsonPropertyName("remark")]
		[Description("备注")]
		public string Remark { get; set; }

		[JsonPropertyName("other_sharing_amount_explain")]
		[Description("其他分成说明")]
		public string OtherSharingAmountExplain { get; set; }

		[JsonPropertyName("packing_amount")]
		[Description("打包费；单位：分")]
		public long PackingAmount { get; set; }
	}

	[JsonPropertyName("page_no")]
	[Description("页码")]
	public long PageNo { get; set; }

	[JsonPropertyName("page_size")]
	[Description("页面大小")]
	public long PageSize { get; set; }
}
