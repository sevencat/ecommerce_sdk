namespace ecommerce.sdk.douyin;

[Description("查询资金流水明细，查询方式为时间轮训方式，数据T+1生成，建议第二天15点之后查询。如因任务积压导致延迟的情况，建议重试。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","500:参数异常，请检查参数start_time","isv.parameter-invalid:500","请检查参数")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:100001","系统错误")]
public class OrderGetShopAccountItemReq : IDouyinReq<OrderGetShopAccountItemRsp>
{

	public string GetMethod() { return "order.getShopAccountItem"; }

	public string GetUrl() { return "/order/getShopAccountItem"; }

	[JsonPropertyName("start_time")]
	[Description("开始时间")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("结束时间")]
	public string EndTime { get; set; }

	[JsonPropertyName("order_id")]
	[Description("订单号(如果订单号未传，则时间必须传)")]
	public string OrderId { get; set; }

	[JsonPropertyName("size")]
	[Description("查询数量(不传默认100，最大为1000)")]
	public int? Size { get; set; }

	[JsonPropertyName("account_type")]
	[Description("动账账户 0: 所有 1: 微信 2:支付宝 3:合众支付 4:聚合支付")]
	public int? AccountType { get; set; }

	[JsonPropertyName("biz_type")]
	[Description("计费类型 0:全部 1:鲁班广告 2:精选联盟 3:值点商城 4:小店自卖 5:橙子建站 6:POI 7:抖+ 8:穿山甲 9:服务市场 10:服务市场外包客服 11:学浪")]
	public int? BizType { get; set; }

	[JsonPropertyName("time_type")]
	[Description("时间类型 0 动账时间 1 下单时间")]
	public int? TimeType { get; set; }

	[JsonPropertyName("start_index")]
	[Description("开始下标  请求值为上一次响应参数的next_index，第一次请求不传")]
	public string StartIndex { get; set; }

	[JsonPropertyName("product_id")]
	[Description("产品id")]
	public string ProductId { get; set; }
}

[Description("查询资金流水明细，查询方式为时间轮训方式，数据T+1生成，建议第二天15点之后查询。如因任务积压导致延迟的情况，建议重试。")]
public class OrderGetShopAccountItemRsp
{
	[JsonPropertyName("code")]
	[Description("返回code 100000为成功，其他为失败")]
	public string Code { get; set; }

	[JsonPropertyName("code_msg")]
	[Description("返回描述")]
	public string CodeMsg { get; set; }

	[JsonPropertyName("data")]
	[Description("资金流水明细")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("bill_time")]
		[Description("动账时间")]
		public string BillTime { get; set; }

		[JsonPropertyName("fund_flow")]
		[Description("动账方向  0:入账 1:出账")]
		public int FundFlow { get; set; }

		[JsonPropertyName("fund_flow_desc")]
		[Description("动账方向描述  出账、入账")]
		public string FundFlowDesc { get; set; }

		[JsonPropertyName("account_amount")]
		[Description("动账金额(分)")]
		public long AccountAmount { get; set; }

		[JsonPropertyName("account_bill_desc")]
		[Description("动账摘要")]
		public string AccountBillDesc { get; set; }

		[JsonPropertyName("account_bill_desc_tag")]
		[Description("动账摘要 0：其他 1：达人带货佣金 2：达人佣金退款 3：订单结算 4：部分结算 5：运费单结算 6：服务费返还 7：平台补贴扣回 8：退款失败退票 9：结算重复扣款调账 10：保证金退款 11：提现 12：提现退票 13：极速退款分账 14：小额打款(原因:补差价) 15：小额打款(原因:其他) 16：小额打款(原因:商品补偿) 17：小额打款(原因:运费补偿) 18：小额打款退票 19：已退款 20：运费险扣减货款 21：支付BIC服务费 22：BIC服务费退票  23: 原路退")]
		public int AccountBillDescTag { get; set; }

		[JsonPropertyName("biz_type")]
		[Description("计费类型  0:全部 1:鲁班广告 2:精选联盟 3:值点商城 4:小店自卖 5:橙子建站 6:POI 7:抖+ 8:穿山甲 9:服务市场 10:服务市场外包客服 11:学浪")]
		public int BizType { get; set; }

		[JsonPropertyName("biz_type_desc")]
		[Description("计费类型描述")]
		public string BizTypeDesc { get; set; }

		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("shop_order_id")]
		[Description("店铺单号")]
		public string ShopOrderId { get; set; }

		[JsonPropertyName("after_sale_service_no")]
		[Description("【商家无需使用】售后编号非售后接口的售后单id；该字段为账单售后编号id；")]
		public string AfterSaleServiceNo { get; set; }

		[JsonPropertyName("business_order_create_time")]
		[Description("下单时间")]
		public string BusinessOrderCreateTime { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public string ProductId { get; set; }

		[JsonPropertyName("pay_amount")]
		[Description("订单实付应结，单位：分；只包含用户实际支付的金额，不含各类补贴（如：平台补贴、达人补贴、支付补贴等）")]
		public long PayAmount { get; set; }

		[JsonPropertyName("promotion_amount")]
		[Description("实际平台补贴(分)")]
		public long PromotionAmount { get; set; }

		[JsonPropertyName("refund_amount")]
		[Description("订单退款(分)")]
		public long RefundAmount { get; set; }

		[JsonPropertyName("platform_service_fee")]
		[Description("平台服务费(分)")]
		public long PlatformServiceFee { get; set; }

		[JsonPropertyName("commission")]
		[Description("佣金(分)")]
		public long Commission { get; set; }

		[JsonPropertyName("channel_fee")]
		[Description("渠道分成(分)")]
		public long ChannelFee { get; set; }

		[JsonPropertyName("colonel_service_fee")]
		[Description("招商服务费(分)")]
		public long ColonelServiceFee { get; set; }

		[JsonPropertyName("account_type")]
		[Description("动账账户  1: 微信 2:支付宝 3:合众支付 4:聚合支付")]
		public int AccountType { get; set; }

		[JsonPropertyName("account_type_desc")]
		[Description("动账账户")]
		public string AccountTypeDesc { get; set; }

		[JsonPropertyName("author_coupon_subsidy")]
		[Description("实际达人补贴(分)")]
		public long AuthorCouponSubsidy { get; set; }

		[JsonPropertyName("post_amount")]
		[Description("运费(分)")]
		public long PostAmount { get; set; }

		[JsonPropertyName("account_trade_no")]
		[Description("动账流水号(唯一)")]
		public string AccountTradeNo { get; set; }

		[JsonPropertyName("order_type")]
		[Description("订单类型  0：普通订单  1：定金(已退款) 2：定金(尾款已支付) 3：定金(尾款未支付) 4：尾款(尾款已支付) 5：尾款(已退款)")]
		public int OrderType { get; set; }

		[JsonPropertyName("order_type_desc")]
		[Description("订单类型描述")]
		public string OrderTypeDesc { get; set; }

		[JsonPropertyName("actual_zt_pay_promotion")]
		[Description("实际抖音支付补贴(分)")]
		public long ActualZtPayPromotion { get; set; }

		[JsonPropertyName("actual_zr_pay_promotion")]
		[Description("实际DOU分期营销补贴(分)")]
		public long ActualZrPayPromotion { get; set; }

		[JsonPropertyName("channel_promotion_fee")]
		[Description("直播间站外推广(分)")]
		public long ChannelPromotionFee { get; set; }

		[JsonPropertyName("other_sharing_amount")]
		[Description("其他分成金额(分)")]
		public long OtherSharingAmount { get; set; }

		[JsonPropertyName("remark")]
		[Description("备注")]
		public string Remark { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺id")]
		public string ShopId { get; set; }

		[JsonPropertyName("trans_scene")]
		[Description("动账场景")]
		public string TransScene { get; set; }

		[JsonPropertyName("trans_scene_tag")]
		[Description("动账场景 0:其他 1:消费者赔付 2:小额打款 3:判罚扣款 4:物流赔付 5:充值保证金 6:权益保险 7:欠票扣款-商家开票 8:公益捐款 9:上门取件运费 10:供应链QIC费用 11:抖音支付与商家联合补贴营销活动 12:抖音月付与商家联合补贴营销活动 13:抖音月付与商家联合贴息活动 14:放心借·贷款还款 15:人工调账 16:提前收款 17:充值千川广告费 18:营销费用-评价有礼 19:年框返点 20:抖店货款充值云仓服务账户 21:供应链平台代发费用 22:退款-结算后退款-退用户 23:退款-订单退款触发-退补贴 24:退款-价保补差退回 25:退款-退转付扣减商家货款 26:,退款-极速退二阶段商家资金回补 27:退款-商家赔付扣减商家货款 28:退款-极速退二次售后-退用户 29:上门取件平台分佣 30:货款结算入账 31:货款完结分账-执照注销场景 32:保证金垫付退款结算分账 33:福袋业务结算入账 34:退款-订单退款触发-分账 35:退款-订单退款触发-退分账 36:退款-价保补差 37:退款-退款失败资金退回 38:退款-赔付失败资金退回 39:上门取件结算入账 40:上门取件保司理赔金 41:上门取件平台激励金 42:上门取件平台改派补贴 43:佣金入账 44:提现 45:提现退票")]
		public int TransSceneTag { get; set; }

		[JsonPropertyName("free_commission_flag")]
		[Description("是否免佣, 枚举值为是/否或为空")]
		public string FreeCommissionFlag { get; set; }

		[JsonPropertyName("real_free_commission_amount")]
		[Description("免佣金额(分)")]
		public long RealFreeCommissionAmount { get; set; }
	}

	[JsonPropertyName("next_start_index")]
	[Description("下一次请求参数start_index 的值")]
	public string NextStartIndex { get; set; }

	[JsonPropertyName("next_start_time")]
	[Description("下一次请求参数start_time的值")]
	public string NextStartTime { get; set; }

	[JsonPropertyName("size")]
	[Description("查询数量，请求参数size传了值得话为请求参数传的值，未传的话，值为100")]
	public int Size { get; set; }

	[JsonPropertyName("data_size")]
	[Description("返回结果data的数量")]
	public int DataSize { get; set; }

	[JsonPropertyName("is_end")]
	[Description("判断查询是否结束。0 未结束, 1 结束。未结束时，需要把next_start_index作为下一次请求的start_index,next_start_time作为下一次请求的start_time。")]
	public int IsEnd { get; set; }
}
