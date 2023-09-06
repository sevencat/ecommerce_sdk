namespace ecommerce.sdk.douyin;

[Description("可查询MCN机构绑定达人周期内百应商达合作订单（包含纯佣及坑位费订单）数据情况")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","无效size","isv.parameter-invalid:1031","无效size")]
[DouyinRetCode(40004,"非法的参数","无效开始时间","isv.parameter-invalid:1034","无效开始时间")]
[DouyinRetCode(40004,"非法的参数","无效结束时间","isv.parameter-invalid:1035","无效结束时间")]
[DouyinRetCode(40004,"非法的参数","无效用户","isv.parameter-invalid:4157","无效用户")]
[DouyinRetCode(40004,"非法的参数","订单类型无效","isv.parameter-invalid:263","订单类型无效")]
[DouyinRetCode(50002,"业务处理失败","达人不属于机构","isv.business-failed:4510","达人不属于机构")]
[DouyinRetCode(50002,"业务处理失败","需【电商MCN机构】角色授权后访问","isv.business-failed:4196","需【电商MCN机构】角色授权后访问")]
public class BuyinServiceFeeOrderListReq : IDouyinReq<BuyinServiceFeeOrderListRsp>
{

	public string GetMethod() { return "buyin.serviceFeeOrderList"; }

	public string GetUrl() { return "/buyin/serviceFeeOrderList"; }

	[JsonPropertyName("start_time")]
	[Description("订单更新开始时间")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("订单更新结束时间")]
	public string EndTime { get; set; }

	[JsonPropertyName("kol_buyin_id")]
	[Description("达人百应ID")]
	[NotNull]
	public string KolBuyinId { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，起始1")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("分页大小，20")]
	[NotNull]
	public long? PageSize { get; set; }
}

[Description("可查询MCN机构绑定达人周期内百应商达合作订单（包含纯佣及坑位费订单）数据情况")]
public class BuyinServiceFeeOrderListRsp
{
	[JsonPropertyName("order_list")]
	[Description("订单列表")]
	public List<OrderListItem> OrderList { get; set; }

	public class OrderListItem
	{
		[JsonPropertyName("order_fee")]
		[Description("订单服务费，单位分")]
		public long OrderFee { get; set; }

		[JsonPropertyName("refund_fee")]
		[Description("订单已退还服务费，单位分")]
		public long RefundFee { get; set; }

		[JsonPropertyName("real_fee")]
		[Description("订单实际结算(转账)服务费，单位分")]
		public long RealFee { get; set; }

		[JsonPropertyName("order_id")]
		[Description("订单id")]
		public long OrderId { get; set; }

		[JsonPropertyName("status")]
		[Description("当前主状态。20：待签署 商家发起待达人签署；30：待交付 达人已签署；40：待验收 达人已交付；50：已完成 商家已验收；60： 取消中 一方发起取消 70：已结束 非正常结束")]
		public long Status { get; set; }

		[JsonPropertyName("order_type")]
		[Description("合作模式。 1：纯佣金；2：等比例；3：一口价")]
		public int OrderType { get; set; }

		[JsonPropertyName("product_info")]
		[Description("商品信息")]
		public List<ProductInfoItem> ProductInfo { get; set; }

		public class ProductInfoItem
		{
			[JsonPropertyName("product_id")]
			[Description("商品id")]
			public string ProductId { get; set; }

			[JsonPropertyName("product_url")]
			[Description("商品链接(普通链接或团长链接) 。目前仅外部机构订单有数据")]
			public string ProductUrl { get; set; }

			[JsonPropertyName("live_price")]
			[Description("约定直播价格,单位分")]
			public long LivePrice { get; set; }

			[JsonPropertyName("min_stock")]
			[Description("库存量")]
			public long MinStock { get; set; }

			[JsonPropertyName("custom_rate")]
			[Description("佣金率（0-100）")]
			public long CustomRate { get; set; }

			[JsonPropertyName("is_presell")]
			[Description("是否预授商品")]
			public bool IsPresell { get; set; }
		}

		[JsonPropertyName("live_type")]
		[Description("直播类型 1专场 2混场")]
		public long LiveType { get; set; }

		[JsonPropertyName("has_shop_entrance")]
		[Description("是否品牌专场直播")]
		public bool HasShopEntrance { get; set; }

		[JsonPropertyName("min_gmv")]
		[Description("最低结算额,单位分")]
		public long MinGmv { get; set; }

		[JsonPropertyName("live_start_time")]
		[Description("直播开始时间")]
		public string LiveStartTime { get; set; }

		[JsonPropertyName("live_end_time")]
		[Description("直播结束时间")]
		public string LiveEndTime { get; set; }

		[JsonPropertyName("introduce_duration")]
		[Description("单品介绍时长，单位秒")]
		public long IntroduceDuration { get; set; }

		[JsonPropertyName("max_deliver_time")]
		[Description("最大发货时间，单位秒")]
		public long MaxDeliverTime { get; set; }

		[JsonPropertyName("assure_price")]
		[Description("是否保价 0:约定不保价 1:约定保价")]
		public long AssurePrice { get; set; }

		[JsonPropertyName("assure_price_channel")]
		[Description("是否渠道等价 1:全渠道最低价，允许与其他渠道等价 2:全渠道最低价，不可与其他渠道等价")]
		public long AssurePriceChannel { get; set; }

		[JsonPropertyName("assure_price_pred")]
		[Description("保价前x日")]
		public long AssurePricePred { get; set; }

		[JsonPropertyName("assure_price_postd")]
		[Description("保价后x日")]
		public long AssurePricePostd { get; set; }

		[JsonPropertyName("ad_act")]
		[Description("是否投放广告 0:约定不投放广告 1:约定投放广告")]
		public long AdAct { get; set; }

		[JsonPropertyName("ad_act_amount")]
		[Description("广告投放额,单位分")]
		public long AdActAmount { get; set; }

		[JsonPropertyName("ad_act_role")]
		[Description("广告投放方 1商家 2达人")]
		public long AdActRole { get; set; }

		[JsonPropertyName("addon")]
		[Description("其它约定(补充说明)")]
		public string Addon { get; set; }

		[JsonPropertyName("create_time")]
		[Description("订单创建时间")]
		public string CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("订单更新时间")]
		public string UpdateTime { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
