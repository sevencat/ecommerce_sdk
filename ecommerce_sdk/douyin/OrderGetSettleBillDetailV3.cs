namespace ecommerce.sdk.douyin;

[Description("已结算的订单才会有数据，数据T+1生成，建议第二天15点之后查询。如因任务积压导致延迟的情况，建议重试。,1、推荐使用start_index方式查询")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","请检查参数","isv.parameter-invalid:100026","请检查参数")]
[DouyinRetCode(50002,"业务处理失败","100010:DB异常","isv.business-failed:100010","请重试")]
public class OrderGetSettleBillDetailV3Req : IDouyinReq<OrderGetSettleBillDetailV3Rsp>
{

	public string GetMethod() { return "order.getSettleBillDetailV3"; }

	public string GetUrl() { return "/order/getSettleBillDetailV3"; }

	[JsonPropertyName("size")]
	[Description("页数，支持范围1~100")]
	public long? Size { get; set; }

	[JsonPropertyName("start_time")]
	[Description("查询开始时间，格式为：yyyy-MM-dd HH:mm:ss，订单号未传的情况下，开始时间必须传，注意：分页查询时，除首次查询外，应填入上一次返回的next_start_time")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("查询结束时间，和end_time的时间间隔建议不超过7天，格式为：yyyy-MM-dd HH:mm:ss，订单号未传的情况下，结束时间必须传")]
	public string EndTime { get; set; }

	[JsonPropertyName("order_id")]
	[Description("SKU单，子订单号，支持通过英文逗号分隔传入多个参数")]
	public string OrderId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品id")]
	public string ProductId { get; set; }

	[JsonPropertyName("pay_type")]
	[Description("结算账户，不传则默认为全部，枚举： 1（微信：升级前）、 2（微信）、 3（支付宝）、 4（合众支付）、 5（聚合账户），支持通过英文逗号分隔传入多个参数")]
	public string PayType { get; set; }

	[JsonPropertyName("flow_type")]
	[Description("业务类型，不传则默认为全部，枚举： 1（鲁班广告）、2（值点商城）, 3（精选联盟）、 4（小店自卖）")]
	public string FlowType { get; set; }

	[JsonPropertyName("time_type")]
	[Description("时间类型 ，不传则默认为结算时间，枚举： 0（结算时间） 1（下单时间）")]
	public string TimeType { get; set; }

	[JsonPropertyName("start_index")]
	[Description("查询开始索引，注意：分页查询时，除首次查询可不填外，应填入上一次返回的next_start_index")]
	public string StartIndex { get; set; }
}

[Description("已结算的订单才会有数据，数据T+1生成，建议第二天15点之后查询。如因任务积压导致延迟的情况，建议重试。,1、推荐使用start_index方式查询")]
public class OrderGetSettleBillDetailV3Rsp
{
	[JsonPropertyName("code")]
	[Description("返回code 100000为成功，其他为失败")]
	public string Code { get; set; }

	[JsonPropertyName("code_msg")]
	[Description("返回信息描述，失败状态下会有失败描述")]
	public string CodeMsg { get; set; }

	[JsonPropertyName("data")]
	[Description("订单流水明细列表")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("settle_time")]
		[Description("结算时间")]
		public string SettleTime { get; set; }

		[JsonPropertyName("request_no")]
		[Description("结算单号")]
		public string RequestNo { get; set; }

		[JsonPropertyName("shop_order_id")]
		[Description("订单号")]
		public string ShopOrderId { get; set; }

		[JsonPropertyName("order_id")]
		[Description("子订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("settle_amount")]
		[Description("商家实收（分）")]
		public long SettleAmount { get; set; }

		[JsonPropertyName("pay_type_desc")]
		[Description("货款结算对应的账户类型： “聚合账户”“微信”“支付宝”“微信升级前”“合众支付”等")]
		public string PayTypeDesc { get; set; }

		[JsonPropertyName("trade_type")]
		[Description("结算单类型 0 ：已结算 1 ：结算后退款-原路退回 2： 保证金退款-支出退回 3： 结算后退款-非原路退回")]
		public int TradeType { get; set; }

		[JsonPropertyName("is_contains_refund_before_settle")]
		[Description("是否包含结算前退款 0：不包含 1：包含")]
		public int IsContainsRefundBeforeSettle { get; set; }

		[JsonPropertyName("order_time")]
		[Description("下单时间")]
		public string OrderTime { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品id")]
		public string ProductId { get; set; }

		[JsonPropertyName("goods_count")]
		[Description("商品数量")]
		public int GoodsCount { get; set; }

		[JsonPropertyName("flow_type_desc")]
		[Description("业务类型: 鲁班广告、商城、精选联盟、小店自卖等")]
		public string FlowTypeDesc { get; set; }

		[JsonPropertyName("order_type")]
		[Description("订单类型：普通订单、尾款(尾款已支付)、尾款(已退款)、定金(已退款)、定金(尾款已支付)、定金(尾款未支付)")]
		public string OrderType { get; set; }

		[JsonPropertyName("total_amount")]
		[Description("订单总价（分）")]
		public long TotalAmount { get; set; }

		[JsonPropertyName("total_goods_amount")]
		[Description("商品总价（分）")]
		public long TotalGoodsAmount { get; set; }

		[JsonPropertyName("post_amount")]
		[Description("运费（分）")]
		public long PostAmount { get; set; }

		[JsonPropertyName("shop_coupon")]
		[Description("店铺券（分）")]
		public long ShopCoupon { get; set; }

		[JsonPropertyName("refund_before_settle")]
		[Description("结算前退款金额（分） （结算前退货+运费-店铺券）")]
		public long RefundBeforeSettle { get; set; }

		[JsonPropertyName("platform_coupon")]
		[Description("平台补贴（分）")]
		public long PlatformCoupon { get; set; }

		[JsonPropertyName("author_coupon")]
		[Description("达人补贴（分）")]
		public long AuthorCoupon { get; set; }

		[JsonPropertyName("zt_pay_promotion")]
		[Description("抖音支付补贴（分）")]
		public long ZtPayPromotion { get; set; }

		[JsonPropertyName("zr_pay_promotion")]
		[Description("DOU分期营销补贴（分）")]
		public long ZrPayPromotion { get; set; }

		[JsonPropertyName("real_pay_amount")]
		[Description("用户实付（分）")]
		public long RealPayAmount { get; set; }

		[JsonPropertyName("total_income")]
		[Description("收入合计（分）")]
		public long TotalIncome { get; set; }

		[JsonPropertyName("platform_service_fee")]
		[Description("平台服务费（分）")]
		public long PlatformServiceFee { get; set; }

		[JsonPropertyName("commission")]
		[Description("佣金（分）")]
		public long Commission { get; set; }

		[JsonPropertyName("good_learn_channel_fee")]
		[Description("渠道分成（分）")]
		public long GoodLearnChannelFee { get; set; }

		[JsonPropertyName("colonel_service_fee")]
		[Description("团长服务费（分）")]
		public long ColonelServiceFee { get; set; }

		[JsonPropertyName("channel_promotion_fee")]
		[Description("直播间站外推广（分）")]
		public long ChannelPromotionFee { get; set; }

		[JsonPropertyName("other_sharing_amount")]
		[Description("其他分成（分）")]
		public long OtherSharingAmount { get; set; }

		[JsonPropertyName("total_outcome")]
		[Description("合计支出")]
		public long TotalOutcome { get; set; }

		[JsonPropertyName("remark")]
		[Description("备注")]
		public string Remark { get; set; }

		[JsonPropertyName("packing_amount")]
		[Description("打包费，单位：分")]
		public long PackingAmount { get; set; }

		[JsonPropertyName("free_commission_flag")]
		[Description("是否免佣，枚举值为“是/否”或为空")]
		public string FreeCommissionFlag { get; set; }

		[JsonPropertyName("real_free_commission_amount")]
		[Description("免佣金额，单位：分")]
		public long RealFreeCommissionAmount { get; set; }
	}

	[JsonPropertyName("size")]
	[Description("请求的size")]
	public long Size { get; set; }

	[JsonPropertyName("next_start_index")]
	[Description("下一次查询start_index")]
	public string NextStartIndex { get; set; }

	[JsonPropertyName("next_start_time")]
	[Description("下一次查询start_time")]
	public string NextStartTime { get; set; }

	[JsonPropertyName("is_end")]
	[Description("判断查询是否结束。0 未结束, 1 结束。未结束时，需要把next_start_index作为下一次请求的start_index,next_start_time作为下一次请求的start_time")]
	public int IsEnd { get; set; }

	[JsonPropertyName("data_size")]
	[Description("结果data的大小")]
	public long DataSize { get; set; }
}
