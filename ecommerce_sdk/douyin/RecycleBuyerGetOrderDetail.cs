namespace ecommerce.sdk.douyin;

[Description("获得订单详情。")]
public class RecycleBuyerGetOrderDetailReq : IDouyinReq<RecycleBuyerGetOrderDetailRsp>
{

	public string GetMethod() { return "recycle.buyerGetOrderDetail"; }

	public string GetUrl() { return "/recycle/buyerGetOrderDetail"; }

	[JsonPropertyName("clue_order_id")]
	[Description("线索单ID")]
	[NotNull]
	public string ClueOrderId { get; set; }
}

[Description("获得订单详情。")]
public class RecycleBuyerGetOrderDetailRsp
{
	[JsonPropertyName("detail")]
	[Description("详情")]
	public DetailItem Detail { get; set; }

	public class DetailItem
	{
		[JsonPropertyName("clue_order_id")]
		[Description("线索订单")]
		public string ClueOrderId { get; set; }

		[JsonPropertyName("trade_type")]
		[Description("0: 还未确认 6:回收单 7:寄卖单")]
		public int TradeType { get; set; }

		[JsonPropertyName("clue_id")]
		[Description("线索")]
		public string ClueId { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建订单时间，时间戳，秒")]
		public string CreateTime { get; set; }

		[JsonPropertyName("close_time")]
		[Description("订单关闭时间，时间戳，秒")]
		public string CloseTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间，时间戳，秒")]
		public string UpdateTime { get; set; }

		[JsonPropertyName("clue_order_status")]
		[Description("订单状态，1 // 刚创建（待估价） 4 // 商家已估价 7 // 用户确认估价 10 // 用户已寄出 13 // 商家已签收 16 // 商家已报价（待确认报价） 19 // 寄售中 22 // 待结算 （交易完成） 25 // 退货待寄出（交易关闭） 28 // 无需寄出货物（交易关闭） 31 // 用户取消（未形成交易单） 34// 已寄出货物（交易关闭） 37 // 已结算 40 // 退货已签收")]
		public int ClueOrderStatus { get; set; }

		[JsonPropertyName("app_id")]
		[Description("小程序所处的appid")]
		public string AppId { get; set; }

		[JsonPropertyName("theme_type")]
		[Description("https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/framework/scene-value/")]
		public string ThemeType { get; set; }

		[JsonPropertyName("product_name")]
		[Description("商品名称")]
		public string ProductName { get; set; }

		[JsonPropertyName("product_pic")]
		[Description("商品主图")]
		public string ProductPic { get; set; }

		[JsonPropertyName("sku")]
		[Description("系列+型号，sku的描述")]
		public string Sku { get; set; }

		[JsonPropertyName("picture")]
		[Description("商品图片")]
		public string Picture { get; set; }

		[JsonPropertyName("purchase_way")]
		[Description("购买渠道  1-国内商场购买 2-海外代购 3-亲友赠送 4-二手购买 6-其他")]
		public int PurchaseWay { get; set; }

		[JsonPropertyName("proof")]
		[Description("购买凭证")]
		public string Proof { get; set; }

		[JsonPropertyName("vintage")]
		[Description("成色")]
		public string Vintage { get; set; }

		[JsonPropertyName("notes")]
		[Description("备注")]
		public string Notes { get; set; }

		[JsonPropertyName("logistics_code")]
		[Description("物流单号")]
		public string LogisticsCode { get; set; }

		[JsonPropertyName("sent_time")]
		[Description("寄出时间，时间戳，秒")]
		public string SentTime { get; set; }

		[JsonPropertyName("sent_way")]
		[Description("寄出方式 1-上门取件 2-自寄")]
		public int SentWay { get; set; }

		[JsonPropertyName("encrypt_shop_address")]
		[Description("收件地址")]
		public string EncryptShopAddress { get; set; }

		[JsonPropertyName("encrypt_shop_phone")]
		[Description("收件人电话")]
		public string EncryptShopPhone { get; set; }

		[JsonPropertyName("encrypt_shop_name")]
		[Description("收件人姓名")]
		public string EncryptShopName { get; set; }

		[JsonPropertyName("encrypt_user_address")]
		[Description("发件/取件地址")]
		public string EncryptUserAddress { get; set; }

		[JsonPropertyName("encrypt_user_name")]
		[Description("发件人姓名")]
		public string EncryptUserName { get; set; }

		[JsonPropertyName("encrypt_user_phone")]
		[Description("发件人电话")]
		public string EncryptUserPhone { get; set; }

		[JsonPropertyName("price_create_time")]
		[Description("估价时间，时间戳，秒")]
		public string PriceCreateTime { get; set; }

		[JsonPropertyName("price_confirm_time")]
		[Description("确认估价时间，时间戳，秒")]
		public string PriceConfirmTime { get; set; }

		[JsonPropertyName("recycle_price")]
		[Description("回收价，单位分 通过价格变化来区分是否改价")]
		public string RecyclePrice { get; set; }

		[JsonPropertyName("recycle_commission")]
		[Description("平台服务费，单位分")]
		public string RecycleCommission { get; set; }

		[JsonPropertyName("consignment_price")]
		[Description("寄卖价，单位分 通过价格变化来区分是否改价")]
		public string ConsignmentPrice { get; set; }

		[JsonPropertyName("consignment_fee")]
		[Description("商家服务费，单位分")]
		public string ConsignmentFee { get; set; }

		[JsonPropertyName("consignment_commission")]
		[Description("平台服务费，单位分")]
		public string ConsignmentCommission { get; set; }

		[JsonPropertyName("consignment_period")]
		[Description("寄售周期 单位秒")]
		public int ConsignmentPeriod { get; set; }

		[JsonPropertyName("knockdown_type")]
		[Description("成交类型 6-回收交易 7-寄卖交易")]
		public int KnockdownType { get; set; }

		[JsonPropertyName("knockdown_time")]
		[Description("成交时间，时间戳，秒")]
		public string KnockdownTime { get; set; }

		[JsonPropertyName("termination_time")]
		[Description("终止时间，时间戳，秒")]
		public string TerminationTime { get; set; }

		[JsonPropertyName("termination_side")]
		[Description("终止方")]
		public string TerminationSide { get; set; }

		[JsonPropertyName("termination_reason")]
		[Description("终止原因")]
		public string TerminationReason { get; set; }

		[JsonPropertyName("reverse_logistics_code")]
		[Description("退件物流id")]
		public string ReverseLogisticsCode { get; set; }

		[JsonPropertyName("shop_consignment_time")]
		[Description("寄售开始时间，时间戳，秒")]
		public string ShopConsignmentTime { get; set; }

		[JsonPropertyName("category_name")]
		[Description("类目")]
		public string CategoryName { get; set; }

		[JsonPropertyName("brand_name")]
		[Description("品牌")]
		public string BrandName { get; set; }

		[JsonPropertyName("series_name")]
		[Description("系列")]
		public string SeriesName { get; set; }

		[JsonPropertyName("model_name")]
		[Description("型号")]
		public string ModelName { get; set; }

		[JsonPropertyName("source_key")]
		[Description("线索来源")]
		public string SourceKey { get; set; }
	}
}
