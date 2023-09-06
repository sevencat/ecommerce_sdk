namespace ecommerce.sdk.douyin;

[Description("根据条件检索满足要求的订单列表，支持下单时间和更新时间排序；最大支持查询近90天的数据")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","订单查询只支持查询最近90天内的数据","isv.parameter-invalid:20022","需要把下单开始时间设置为最近90天内的时间（如果没有传下单开始时间会默认设置当前时间90天前的时间为下单开始时间）")]
[DouyinRetCode(40004,"非法的参数","订单查询最多支持查询5万","isv.parameter-invalid:20013","翻页查询最多支持查询到5万，需要缩短查询时间范围，降低查询的订单量")]
[DouyinRetCode(40004,"非法的参数","订单查询状态条件超过限制，只支持1个元素","isv.parameter-invalid:20012","状态查询条件是list，但现在只支持传入一个元素，重新组装参数查询")]
[DouyinRetCode(40004,"非法的参数","订单查询开始时间不能为空","isv.parameter-invalid:20011","时间为必传项，下单开始时间和更新开始时间必传一个")]
[DouyinRetCode(40004,"非法的参数","单次查询订单数超过限制","isv.parameter-invalid:20008","单页最大支持100，size设置需要 <= 100")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:20005","如遇到该报错，建议再30秒内重试3~5次，如还是报错可提交工单咨询")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:20004","如遇到该报错，建议再30秒内重试3~5次，如还是报错可提交工单咨询")]
[DouyinRetCode(40004,"非法的参数","查询订单列表页数不能小于0","isv.parameter-invalid:10035","查询页数从0开始，需要输入大于等于0的数")]
[DouyinRetCode(50002,"业务处理失败","店铺ID不能为空","isv.business-failed:20009","需要传入店铺ID")]
[DouyinRetCode(40004,"非法的参数","查询结果中包含非该门店下订单","isv.parameter-invalid:20045","需传入合法的订单id")]
public class OrderSearchListReq : IDouyinReq<OrderSearchListRsp>
{

	public string GetMethod() { return "order.searchList"; }

	public string GetUrl() { return "/order/searchList"; }

	[JsonPropertyName("product")]
	[Description("商品，number型代表商品ID，其它代表商品名称")]
	public string Product { get; set; }

	[JsonPropertyName("b_type")]
	[Description("【下单端】 0、站外   1、火山   2、抖音   3、头条   4、西瓜   5、微信   6、值点app  7、头条lite   8、懂车帝  9、皮皮虾   11、抖音极速版   12、TikTok   13、musically   14、穿山甲   15、火山极速版   16、服务市场   26、番茄小说   27、UG教育营销电商平台   28、Jumanji   29、电商SDK")]
	public long? BType { get; set; }

	[JsonPropertyName("after_sale_status_desc")]
	[Description("售后状态：all-全部，in_aftersale-售后中，refund-退款中，refund_success-退款成功，refund_fail-退款失败，exchange_success-换货成功 aftersale_close-售后关闭")]
	public string AfterSaleStatusDesc { get; set; }

	[JsonPropertyName("tracking_no")]
	[Description("物流单号")]
	public string TrackingNo { get; set; }

	[JsonPropertyName("presell_type")]
	[Description("预售类型：0-普通订单；1-全款预售；2-定金预售；3-定金找货；")]
	public long? PresellType { get; set; }

	[JsonPropertyName("order_type")]
	[Description("订单类型 0、普通订单 2、虚拟商品订单 4、电子券（poi核销） 5、三方核销")]
	public long? OrderType { get; set; }

	[JsonPropertyName("create_time_start")]
	[Description("下单时间：开始，秒级时间戳")]
	public long? CreateTimeStart { get; set; }

	[JsonPropertyName("create_time_end")]
	[Description("下单时间：截止，秒级时间戳")]
	public long? CreateTimeEnd { get; set; }

	[JsonPropertyName("abnormal_order")]
	[Description("异常订单，1-异常取消，2-风控审核中")]
	public long? AbnormalOrder { get; set; }

	[JsonPropertyName("trade_type")]
	[Description("交易类型：0-普通；1-拼团；2-定金预售；3-订金找货；4-拍卖；5-0元单；6-回收；7-寄卖；10-寄样；11-0元抽奖(超级福袋)；12-达人买样；13-普通定制；16-大众竞拍；18-小时达；102-定金预售的赠品单；103-收款；")]
	public long? TradeType { get; set; }

	[JsonPropertyName("combine_status")]
	[Description("状态组合查询，直接输入状态码（只支持一个元素）")]
	public List<CombineStatusItem> CombineStatus { get; set; }

	public class CombineStatusItem
	{
		[JsonPropertyName("order_status")]
		[Description("订单状态，,分隔多个状态；1-待支付；101-部分发货；105-已支付；2-待发货；3-已发货；4-已取消；5-已完成")]
		public string OrderStatus { get; set; }

		[JsonPropertyName("main_status")]
		[Description("【已废弃，不推荐使用】主流程状态，,分隔多个状态；")]
		public string MainStatus { get; set; }
	}

	[JsonPropertyName("update_time_start")]
	[Description("更新时间：开始")]
	public long? UpdateTimeStart { get; set; }

	[JsonPropertyName("update_time_end")]
	[Description("更新时间：截止")]
	public long? UpdateTimeEnd { get; set; }

	[JsonPropertyName("size")]
	[Description("单页大小，限制100以内")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，0页开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("order_by")]
	[Description("排序条件(create_time 订单创建时间；update_time 订单更新时间；默认create_time；)")]
	public string OrderBy { get; set; }

	[JsonPropertyName("order_asc")]
	[Description("排序类型，小到大或大到小，默认大到小")]
	public bool? OrderAsc { get; set; }

	[JsonPropertyName("fulfil_status")]
	[Description("履约状态；如小时达未接单no_accept")]
	public string FulfilStatus { get; set; }
}

[Description("根据条件检索满足要求的订单列表，支持下单时间和更新时间排序；最大支持查询近90天的数据")]
public class OrderSearchListRsp
{
	[JsonPropertyName("page")]
	[Description("页数，从0开始")]
	public long Page { get; set; }

	[JsonPropertyName("total")]
	[Description("总订单数")]
	public long Total { get; set; }

	[JsonPropertyName("size")]
	[Description("单页大小")]
	public long Size { get; set; }

	[JsonPropertyName("shop_order_list")]
	[Description("订单信息")]
	public List<ShopOrderListItem> ShopOrderList { get; set; }

	public class ShopOrderListItem
	{
		[JsonPropertyName("aweme_id")]
		[Description("达人抖音号，样品订单场景下才会返回的申样达人信息；")]
		public string AwemeId { get; set; }

		[JsonPropertyName("user_icon")]
		[Description("达人抖音头像，样品订单场景下才会返回的申样达人信息；")]
		public string UserIcon { get; set; }

		[JsonPropertyName("user_nick_name")]
		[Description("达人抖音昵称，样品订单场景下才会返回的申样达人信息；")]
		public string UserNickName { get; set; }

		[JsonPropertyName("recommend_end_ship_time")]
		[Description("建议商家最晚发货时间，秒")]
		public long RecommendEndShipTime { get; set; }

		[JsonPropertyName("recommend_start_ship_time")]
		[Description("建议商家最早发货时间，秒")]
		public long RecommendStartShipTime { get; set; }

		[JsonPropertyName("receipt_date")]
		[Description("用户选择的预约送达日期")]
		public string ReceiptDate { get; set; }

		[JsonPropertyName("accept_order_status")]
		[Description("小时达订单接单状态；0-未接单；1-已接单；2-超时取消，或商家取消")]
		public long AcceptOrderStatus { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺ID")]
		public long ShopId { get; set; }

		[JsonPropertyName("shop_name")]
		[Description("商户名称")]
		public string ShopName { get; set; }

		[JsonPropertyName("open_id")]
		[Description("抖音小程序ID")]
		public string OpenId { get; set; }

		[JsonPropertyName("order_id")]
		[Description("店铺订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("order_level")]
		[Description("订单层级")]
		public long OrderLevel { get; set; }

		[JsonPropertyName("biz")]
		[Description("【业务来源】 1、鲁班 2、小店 3、好好学习 4、ev 5、虚拟 6、建站 7、核销 8、玉石 9、ez 10、ep 11、虚拟卡券 12、服务市场 13、EP视频课 14、EP直播课 21、跨境BBC 22、跨境BC 23、跨境CC,UPC 24、手机充值 25、拍卖保证金 26、懂车帝抵扣券 27、懂车帝返现券 28、离岛免税 29、海南会员购 30、抽奖 32、dou+券 76、大闸蟹 99、保险 102、小店海外")]
		public long Biz { get; set; }

		[JsonPropertyName("biz_desc")]
		[Description("业务来源描述")]
		public string BizDesc { get; set; }

		[JsonPropertyName("order_type")]
		[Description("【订单类型】 0、普通订单 2、虚拟商品订单 4、电子券（poi核销） 5、三方核销")]
		public long OrderType { get; set; }

		[JsonPropertyName("order_type_desc")]
		[Description("订单类型描述")]
		public string OrderTypeDesc { get; set; }

		[JsonPropertyName("trade_type")]
		[Description("【已废弃】请使用sku_order_list.trade_type")]
		public long TradeType { get; set; }

		[JsonPropertyName("trade_type_desc")]
		[Description("【已废弃】请使用sku_order_list. trade_type_desc")]
		public string TradeTypeDesc { get; set; }

		[JsonPropertyName("order_status")]
		[Description("订单状态;1 待确认/待支付-订单创建完毕;105-已支付; 2-备货中； 101-部分发货; 3-已发货（全部发货）;4- 已取消;5 已完成（已收货）;")]
		public long OrderStatus { get; set; }

		[JsonPropertyName("order_status_desc")]
		[Description("订单状态描述")]
		public string OrderStatusDesc { get; set; }

		[JsonPropertyName("main_status")]
		[Description("主流程状态")]
		public long MainStatus { get; set; }

		[JsonPropertyName("main_status_desc")]
		[Description("主流程状态描述")]
		public string MainStatusDesc { get; set; }

		[JsonPropertyName("pay_time")]
		[Description("支付时间")]
		public long PayTime { get; set; }

		[JsonPropertyName("order_expire_time")]
		[Description("订单过期时间")]
		public long OrderExpireTime { get; set; }

		[JsonPropertyName("finish_time")]
		[Description("订单完成时间")]
		public long FinishTime { get; set; }

		[JsonPropertyName("create_time")]
		[Description("下单时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("订单更新时间")]
		public long UpdateTime { get; set; }

		[JsonPropertyName("cancel_reason")]
		[Description("取消原因")]
		public string CancelReason { get; set; }

		[JsonPropertyName("buyer_words")]
		[Description("买家留言")]
		public string BuyerWords { get; set; }

		[JsonPropertyName("seller_words")]
		[Description("商家备注")]
		public string SellerWords { get; set; }

		[JsonPropertyName("b_type")]
		[Description("【下单端】 0、站外 1、火山 2、抖音 3、头条 4、西瓜 5、微信 6、值点app 7、头条lite 8、懂车帝 9、皮皮虾 11、抖音极速版 12、TikTok 13、musically 14、穿山甲 15、火山极速版 16、服务市场 26、番茄小说 27、UG教育营销电商平台 28、Jumanji 29、电商SDK")]
		public long BType { get; set; }

		[JsonPropertyName("b_type_desc")]
		[Description("下单端描述")]
		public string BTypeDesc { get; set; }

		[JsonPropertyName("sub_b_type")]
		[Description("【下单场景】 0、未知 1、app内-原生 2、app内-小程序 3、H5 13、电商SDK-头条 35、电商SDK-头条lite")]
		public long SubBType { get; set; }

		[JsonPropertyName("sub_b_type_desc")]
		[Description("下单场景描述")]
		public string SubBTypeDesc { get; set; }

		[JsonPropertyName("app_id")]
		[Description("具体某个小程序的ID")]
		public long AppId { get; set; }

		[JsonPropertyName("pay_type")]
		[Description("【支付类型】 0、货到付款 1 、微信 2、支付宝 3、小程序 4、银行卡 5、余额 7、无需支付（0元单） 8、DOU分期（信用支付） 9、新卡支付 12、先用后付")]
		public long PayType { get; set; }

		[JsonPropertyName("channel_payment_no")]
		[Description("支付渠道的流水号")]
		public string ChannelPaymentNo { get; set; }

		[JsonPropertyName("order_amount")]
		[Description("订单金额（单位：分）")]
		public long OrderAmount { get; set; }

		[JsonPropertyName("pay_amount")]
		[Description("支付金额（单位：分）")]
		public long PayAmount { get; set; }

		[JsonPropertyName("post_amount")]
		[Description("快递费（单位：分）")]
		public long PostAmount { get; set; }

		[JsonPropertyName("post_insurance_amount")]
		[Description("运费险金额（单位：分）")]
		public long PostInsuranceAmount { get; set; }

		[JsonPropertyName("modify_amount")]
		[Description("改价金额变化量（单位：分）")]
		public long ModifyAmount { get; set; }

		[JsonPropertyName("modify_post_amount")]
		[Description("改价运费金额变化量（单位：分）")]
		public long ModifyPostAmount { get; set; }

		[JsonPropertyName("promotion_amount")]
		[Description("订单优惠总金额（单位：分）= 店铺优惠金额+ 平台优惠金额+ 达人优惠金额")]
		public long PromotionAmount { get; set; }

		[JsonPropertyName("promotion_shop_amount")]
		[Description("店铺优惠金额（单位：分），属于店铺的优惠活动、优惠券、红包的总优惠金额")]
		public long PromotionShopAmount { get; set; }

		[JsonPropertyName("promotion_platform_amount")]
		[Description("平台优惠金额（单位：分），属于平台的优惠活动、优惠券、红包的总优惠金额")]
		public long PromotionPlatformAmount { get; set; }

		[JsonPropertyName("shop_cost_amount")]
		[Description("商家承担金额（单位：分），订单参与活动和优惠中商家承担部分的总金额")]
		public long ShopCostAmount { get; set; }

		[JsonPropertyName("platform_cost_amount")]
		[Description("平台承担金额（单位：分），订单参与活动和优惠中平台+作者（达人）承担部分的总金额,包含作者（达人）承担金额：platform_cost_amount = only_platform_cost_amount + author_cost_amount")]
		public long PlatformCostAmount { get; set; }

		[JsonPropertyName("promotion_talent_amount")]
		[Description("达人优惠金额（单位：分），属于达人的优惠活动、优惠券、红包的总优惠金额")]
		public long PromotionTalentAmount { get; set; }

		[JsonPropertyName("promotion_pay_amount")]
		[Description("支付优惠金额（单位：分），支付渠道上的优惠金额")]
		public long PromotionPayAmount { get; set; }

		[JsonPropertyName("post_tel")]
		[Description("收件人电话")]
		public string PostTel { get; set; }

		[JsonPropertyName("post_receiver")]
		[Description("收件人姓名")]
		public string PostReceiver { get; set; }

		[JsonPropertyName("post_addr")]
		[Description("收件人地址")]
		public PostAddrItem PostAddr { get; set; }

		public class PostAddrItem
		{
			[JsonPropertyName("province")]
			[Description("省/直辖市")]
			public ProvinceItem Province { get; set; }

			public class ProvinceItem
			{
				[JsonPropertyName("name")]
				[Description("名称")]
				public string Name { get; set; }

				[JsonPropertyName("id")]
				[Description("地区ID")]
				public string Id { get; set; }
			}

			[JsonPropertyName("city")]
			[Description("市")]
			public CityItem City { get; set; }

			public class CityItem
			{
				[JsonPropertyName("name")]
				[Description("名称")]
				public string Name { get; set; }

				[JsonPropertyName("id")]
				[Description("地区ID")]
				public string Id { get; set; }
			}

			[JsonPropertyName("town")]
			[Description("区县")]
			public TownItem Town { get; set; }

			public class TownItem
			{
				[JsonPropertyName("name")]
				[Description("名称")]
				public string Name { get; set; }

				[JsonPropertyName("id")]
				[Description("地区ID")]
				public string Id { get; set; }
			}

			[JsonPropertyName("street")]
			[Description("街道")]
			public StreetItem Street { get; set; }

			public class StreetItem
			{
				[JsonPropertyName("name")]
				[Description("名称")]
				public string Name { get; set; }

				[JsonPropertyName("id")]
				[Description("地区ID")]
				public string Id { get; set; }
			}

			[JsonPropertyName("detail")]
			[Description("详细地址")]
			public string Detail { get; set; }
		}

		[JsonPropertyName("exp_ship_time")]
		[Description("预计发货时间")]
		public long ExpShipTime { get; set; }

		[JsonPropertyName("ship_time")]
		[Description("发货时间")]
		public long ShipTime { get; set; }

		[JsonPropertyName("logistics_info")]
		[Description("物流信息")]
		public List<LogisticsInfoItem> LogisticsInfo { get; set; }

		public class LogisticsInfoItem
		{
			[JsonPropertyName("tracking_no")]
			[Description("物流单号")]
			public string TrackingNo { get; set; }

			[JsonPropertyName("company")]
			[Description("物流公司")]
			public string Company { get; set; }

			[JsonPropertyName("ship_time")]
			[Description("发货时间")]
			public long ShipTime { get; set; }

			[JsonPropertyName("delivery_id")]
			[Description("包裹id")]
			public string DeliveryId { get; set; }

			[JsonPropertyName("company_name")]
			[Description("物流公司名称")]
			public string CompanyName { get; set; }

			[JsonPropertyName("product_info")]
			[Description("商品信息")]
			public List<ProductInfoItem> ProductInfo { get; set; }

			public class ProductInfoItem
			{
				[JsonPropertyName("product_name")]
				[Description("商品名称")]
				public string ProductName { get; set; }

				[JsonPropertyName("price")]
				[Description("商品价格")]
				public long Price { get; set; }

				[JsonPropertyName("outer_sku_id")]
				[Description("商家编码")]
				public string OuterSkuId { get; set; }

				[JsonPropertyName("sku_id")]
				[Description("商品skuId")]
				public long SkuId { get; set; }

				[JsonPropertyName("sku_specs")]
				[Description("规格信息")]
				public List<SkuSpecsItem> SkuSpecs { get; set; }

				public class SkuSpecsItem
				{
					[JsonPropertyName("name")]
					[Description("规格名称")]
					public string Name { get; set; }

					[JsonPropertyName("value")]
					[Description("规格值")]
					public string Value { get; set; }
				}

				[JsonPropertyName("product_count")]
				[Description("发货商品数量")]
				public long ProductCount { get; set; }

				[JsonPropertyName("product_id")]
				[Description("商品ID")]
				public long ProductId { get; set; }

				[JsonPropertyName("sku_order_id")]
				[Description("商品单ID")]
				public string SkuOrderId { get; set; }

				[JsonPropertyName("product_id_str")]
				[Description("商品ID，字符串型")]
				public string ProductIdStr { get; set; }
			}

			[JsonPropertyName("hour_up_pickup_code")]
			[Description("骑手取件码；触发场景①商家：抖超小时达商家通过平台运力发货并选择需要取件码时，该字段有值返回。应用场景①骑手到店后报流水号，门店员工根据流水号【示例值：流水号#1】找到对应包裹。②门店员工与骑手核对取件码，核对无误后交货给骑手；")]
			public string HourUpPickupCode { get; set; }

			[JsonPropertyName("guarantee_amount")]
			[Description("小时达订单保价金额，单位：分")]
			public long GuaranteeAmount { get; set; }
		}

		[JsonPropertyName("sku_order_list")]
		[Description("商品单信息")]
		public List<SkuOrderListItem> SkuOrderList { get; set; }

		public class SkuOrderListItem
		{
			[JsonPropertyName("goods_price")]
			[Description("商品原价")]
			public long GoodsPrice { get; set; }

			[JsonPropertyName("quality_inspection_status")]
			[Description("质检状态；0-无需质检;1-可质检;2-必须质检")]
			public long QualityInspectionStatus { get; set; }

			[JsonPropertyName("order_id")]
			[Description("商品订单号")]
			public string OrderId { get; set; }

			[JsonPropertyName("parent_order_id")]
			[Description("父订单号（店铺订单号）")]
			public string ParentOrderId { get; set; }

			[JsonPropertyName("order_level")]
			[Description("订单层级")]
			public long OrderLevel { get; set; }

			[JsonPropertyName("biz")]
			[Description("【业务来源】 1、鲁班 2、小店 3、好好学习 4、ev 5、虚拟 6、建站 7、核销 8、玉石 9、ez 10、ep 11、虚拟卡券 12、服务市场 13、EP视频课 14、EP直播课 21、跨境BBC 22、跨境BC 23、跨境CC,UPC 24、手机充值 25、拍卖保证金 26、懂车帝抵扣券 27、懂车帝返现券 28、离岛免税 29、海南会员购 30、抽奖 32、dou+券 76、大闸蟹 99、保险 102、小店海外")]
			public long Biz { get; set; }

			[JsonPropertyName("biz_desc")]
			[Description("业务来源描述")]
			public string BizDesc { get; set; }

			[JsonPropertyName("order_type")]
			[Description("【订单类型】 0、普通订单 2、虚拟商品订单 4、电子券（poi核销） 5、三方核销")]
			public long OrderType { get; set; }

			[JsonPropertyName("order_type_desc")]
			[Description("订单类型描述")]
			public string OrderTypeDesc { get; set; }

			[JsonPropertyName("trade_type")]
			[Description("交易类型；0-普通；1-拼团；2-定金预售；3-订金找货；4-拍卖；5-0元单；6-回收；7-寄卖；10-寄样；11-零元抽奖；12-达人买样；13-普通定制；16-大众竞拍；18-小时达；102-定金预售的赠品单；103-收款；和trade_type_desc成对出现")]
			public long TradeType { get; set; }

			[JsonPropertyName("trade_type_desc")]
			[Description("交易类型描述；和trade_type成对出现")]
			public string TradeTypeDesc { get; set; }

			[JsonPropertyName("order_status")]
			[Description("订单状态")]
			public long OrderStatus { get; set; }

			[JsonPropertyName("order_status_desc")]
			[Description("订单状态描述")]
			public string OrderStatusDesc { get; set; }

			[JsonPropertyName("main_status")]
			[Description("主流程状态")]
			public long MainStatus { get; set; }

			[JsonPropertyName("main_status_desc")]
			[Description("主流程状态描述")]
			public string MainStatusDesc { get; set; }

			[JsonPropertyName("pay_time")]
			[Description("支付时间")]
			public long PayTime { get; set; }

			[JsonPropertyName("order_expire_time")]
			[Description("订单过期时间")]
			public long OrderExpireTime { get; set; }

			[JsonPropertyName("finish_time")]
			[Description("订单完成时间")]
			public long FinishTime { get; set; }

			[JsonPropertyName("create_time")]
			[Description("下单时间")]
			public long CreateTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("订单更新时间")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("cancel_reason")]
			[Description("取消原因")]
			public string CancelReason { get; set; }

			[JsonPropertyName("b_type")]
			[Description("【下单端】 0、站外 1、火山 2、抖音 3、头条 4、西瓜 5、微信 6、值点app 7、头条lite 8、懂车帝 9、皮皮虾 11、抖音极速版 12、TikTok 13、musically 14、穿山甲 15、火山极速版 16、服务市场 26、番茄小说 27、UG教育营销电商平台 28、Jumanji 29、电商SDK")]
			public long BType { get; set; }

			[JsonPropertyName("b_type_desc")]
			[Description("下单端描述")]
			public string BTypeDesc { get; set; }

			[JsonPropertyName("sub_b_type")]
			[Description("【下单场景】 0、未知 1、app内-原生 2、app内-小程序 3、H5 13、电商SDK-头条 35、电商SDK-头条lite")]
			public long SubBType { get; set; }

			[JsonPropertyName("sub_b_type_desc")]
			[Description("下单场景描述")]
			public string SubBTypeDesc { get; set; }

			[JsonPropertyName("send_pay")]
			[Description("已废弃，不推荐使用。流量来源：1-鲁班广告 2-联盟 3-商城 4-自主经营 5-线索通支付表单 6-抖音门店 7-抖+ 8-穿山甲")]
			public long SendPay { get; set; }

			[JsonPropertyName("send_pay_desc")]
			[Description("已废弃，不推荐使用。流量来源描述")]
			public string SendPayDesc { get; set; }

			[JsonPropertyName("author_id")]
			[Description("直播主播id（达人）")]
			public long AuthorId { get; set; }

			[JsonPropertyName("author_name")]
			[Description("直播主播名称")]
			public string AuthorName { get; set; }

			[JsonPropertyName("theme_type")]
			[Description("【下单来源】 0、其他 1、直播间")]
			public string ThemeType { get; set; }

			[JsonPropertyName("theme_type_desc")]
			[Description("下单来源描述")]
			public string ThemeTypeDesc { get; set; }

			[JsonPropertyName("app_id")]
			[Description("小程序id")]
			public long AppId { get; set; }

			[JsonPropertyName("room_id")]
			[Description("直播间id")]
			public long RoomId { get; set; }

			[JsonPropertyName("content_id")]
			[Description("内容id")]
			public string ContentId { get; set; }

			[JsonPropertyName("video_id")]
			[Description("视频id")]
			public string VideoId { get; set; }

			[JsonPropertyName("origin_id")]
			[Description("流量来源id")]
			public string OriginId { get; set; }

			[JsonPropertyName("cid")]
			[Description("创意id（creative_id）")]
			public long Cid { get; set; }

			[JsonPropertyName("c_biz")]
			[Description("【C端流量来源】 0-unknown 2-精选联盟 8-小店自卖")]
			public long CBiz { get; set; }

			[JsonPropertyName("c_biz_desc")]
			[Description("C端流量来源业务类型描述")]
			public string CBizDesc { get; set; }

			[JsonPropertyName("page_id")]
			[Description("鲁班广告落地页ID")]
			public long PageId { get; set; }

			[JsonPropertyName("pay_type")]
			[Description("【支付类型】 0、货到付款 1 、微信 2、支付宝 3、小程序 4、银行卡 5、余额 7、无需支付（0元单） 8、DOU分期（信用支付） 9、新卡支付")]
			public long PayType { get; set; }

			[JsonPropertyName("channel_payment_no")]
			[Description("支付渠道的流水号")]
			public string ChannelPaymentNo { get; set; }

			[JsonPropertyName("order_amount")]
			[Description("订单金额（单位：分）")]
			public long OrderAmount { get; set; }

			[JsonPropertyName("pay_amount")]
			[Description("支付金额（单位：分）")]
			public long PayAmount { get; set; }

			[JsonPropertyName("post_insurance_amount")]
			[Description("运费险金额（单位：分）")]
			public long PostInsuranceAmount { get; set; }

			[JsonPropertyName("modify_amount")]
			[Description("改价金额变化量（单位：分）")]
			public long ModifyAmount { get; set; }

			[JsonPropertyName("modify_post_amount")]
			[Description("改价运费金额变化量（单位：分）")]
			public long ModifyPostAmount { get; set; }

			[JsonPropertyName("promotion_amount")]
			[Description("订单优惠总金额（单位：分）= 店铺优惠金额+ 平台优惠金额+ 达人优惠金额")]
			public long PromotionAmount { get; set; }

			[JsonPropertyName("promotion_shop_amount")]
			[Description("店铺优惠金额（单位：分），属于店铺的优惠活动、优惠券、红包的总优惠金额")]
			public long PromotionShopAmount { get; set; }

			[JsonPropertyName("promotion_platform_amount")]
			[Description("平台优惠金额（单位：分），属于平台的优惠活动、优惠券、红包的总优惠金额")]
			public long PromotionPlatformAmount { get; set; }

			[JsonPropertyName("shop_cost_amount")]
			[Description("商家承担金额（单位：分），订单参与活动和优惠中商家承担部分的总金额")]
			public long ShopCostAmount { get; set; }

			[JsonPropertyName("platform_cost_amount")]
			[Description("平台承担金额（单位：分），订单参与活动和优惠中平台+作者（达人）承担部分的总金额,包含作者（达人）承担金额：platform_cost_amount = only_platform_cost_amount + author_cost_amount")]
			public long PlatformCostAmount { get; set; }

			[JsonPropertyName("promotion_talent_amount")]
			[Description("达人优惠金额（单位：分），属于达人的优惠活动、优惠券、红包的总优惠金额")]
			public long PromotionTalentAmount { get; set; }

			[JsonPropertyName("promotion_pay_amount")]
			[Description("支付优惠金额（单位：分），支付渠道上的优惠金额")]
			public long PromotionPayAmount { get; set; }

			[JsonPropertyName("code")]
			[Description("商家后台商品编码")]
			public string Code { get; set; }

			[JsonPropertyName("post_tel")]
			[Description("收件人电话")]
			public string PostTel { get; set; }

			[JsonPropertyName("post_receiver")]
			[Description("收件人姓名")]
			public string PostReceiver { get; set; }

			[JsonPropertyName("post_addr")]
			[Description("收件人地址")]
			public PostAddrItem PostAddr { get; set; }

			public class PostAddrItem
			{
				[JsonPropertyName("province")]
				[Description("省/直辖市")]
				public ProvinceItem Province { get; set; }

				public class ProvinceItem
				{
					[JsonPropertyName("name")]
					[Description("名称")]
					public string Name { get; set; }

					[JsonPropertyName("id")]
					[Description("地区ID")]
					public string Id { get; set; }
				}

				[JsonPropertyName("city")]
				[Description("市")]
				public CityItem City { get; set; }

				public class CityItem
				{
					[JsonPropertyName("name")]
					[Description("名称")]
					public string Name { get; set; }

					[JsonPropertyName("id")]
					[Description("地区ID")]
					public string Id { get; set; }
				}

				[JsonPropertyName("town")]
				[Description("区县")]
				public TownItem Town { get; set; }

				public class TownItem
				{
					[JsonPropertyName("name")]
					[Description("名称")]
					public string Name { get; set; }

					[JsonPropertyName("id")]
					[Description("地区ID")]
					public string Id { get; set; }
				}

				[JsonPropertyName("street")]
				[Description("街道")]
				public StreetItem Street { get; set; }

				public class StreetItem
				{
					[JsonPropertyName("name")]
					[Description("名称")]
					public string Name { get; set; }

					[JsonPropertyName("id")]
					[Description("地区ID")]
					public string Id { get; set; }
				}

				[JsonPropertyName("detail")]
				[Description("详细地址")]
				public string Detail { get; set; }
			}

			[JsonPropertyName("exp_ship_time")]
			[Description("预计发货时间")]
			public long ExpShipTime { get; set; }

			[JsonPropertyName("ship_time")]
			[Description("发货时间")]
			public long ShipTime { get; set; }

			[JsonPropertyName("logistics_receipt_time")]
			[Description("物流收货时间")]
			public long LogisticsReceiptTime { get; set; }

			[JsonPropertyName("confirm_receipt_time")]
			[Description("用户确认收货时间")]
			public long ConfirmReceiptTime { get; set; }

			[JsonPropertyName("goods_type")]
			[Description("【商品类型】 0、实体 1、虚拟")]
			public long GoodsType { get; set; }

			[JsonPropertyName("product_id")]
			[Description("商品ID")]
			public long ProductId { get; set; }

			[JsonPropertyName("sku_id")]
			[Description("商品skuId")]
			public long SkuId { get; set; }

			[JsonPropertyName("spec")]
			[Description("规格信息")]
			public List<SpecItem> Spec { get; set; }

			public class SpecItem
			{
				[JsonPropertyName("name")]
				[Description("规格名称")]
				public string Name { get; set; }

				[JsonPropertyName("value")]
				[Description("规格值")]
				public string Value { get; set; }
			}

			[JsonPropertyName("first_cid")]
			[Description("一级类目")]
			public long FirstCid { get; set; }

			[JsonPropertyName("second_cid")]
			[Description("二级类目")]
			public long SecondCid { get; set; }

			[JsonPropertyName("third_cid")]
			[Description("三级类目")]
			public long ThirdCid { get; set; }

			[JsonPropertyName("fourth_cid")]
			[Description("四级类目")]
			public long FourthCid { get; set; }

			[JsonPropertyName("out_sku_id")]
			[Description("外部Skuid")]
			public string OutSkuId { get; set; }

			[JsonPropertyName("supplier_id")]
			[Description("sku外部供应商编码")]
			public string SupplierId { get; set; }

			[JsonPropertyName("out_product_id")]
			[Description("商品外部编码")]
			public string OutProductId { get; set; }

			[JsonPropertyName("warehouse_ids")]
			[Description("仓id，废弃，使用inventory_list")]
			public List<string> WarehouseIds { get; set; }

			[JsonPropertyName("out_warehouse_ids")]
			[Description("外部仓id，废弃，使用inventory_list")]
			public List<string> OutWarehouseIds { get; set; }

			[JsonPropertyName("inventory_type")]
			[Description("库存类型，普通库存/区域库存，废弃，使用inventory_list")]
			public string InventoryType { get; set; }

			[JsonPropertyName("inventory_type_desc")]
			[Description("库存类型描述，废弃，使用inventory_list")]
			public string InventoryTypeDesc { get; set; }

			[JsonPropertyName("reduce_stock_type")]
			[Description("【库存扣减方式】 1、下单减库存 2、支付减库存")]
			public long ReduceStockType { get; set; }

			[JsonPropertyName("reduce_stock_type_desc")]
			[Description("库存扣减方式名称")]
			public string ReduceStockTypeDesc { get; set; }

			[JsonPropertyName("origin_amount")]
			[Description("商品现价（单位：分）")]
			public long OriginAmount { get; set; }

			[JsonPropertyName("has_tax")]
			[Description("是否包税")]
			public bool HasTax { get; set; }

			[JsonPropertyName("item_num")]
			[Description("订单商品数量")]
			public long ItemNum { get; set; }

			[JsonPropertyName("sum_amount")]
			[Description("商品现价*件数")]
			public long SumAmount { get; set; }

			[JsonPropertyName("source_platform")]
			[Description("商品来源平台")]
			public string SourcePlatform { get; set; }

			[JsonPropertyName("product_pic")]
			[Description("商品图片")]
			public string ProductPic { get; set; }

			[JsonPropertyName("is_comment")]
			[Description("是否评价 :1已评价，0未评价，2表示追评")]
			public long IsComment { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("inventory_list")]
			[Description("仓库信息")]
			public List<InventoryListItem> InventoryList { get; set; }

			public class InventoryListItem
			{
				[JsonPropertyName("warehouse_id")]
				[Description("仓id")]
				public string WarehouseId { get; set; }

				[JsonPropertyName("out_warehouse_id")]
				[Description("外部仓id")]
				public string OutWarehouseId { get; set; }

				[JsonPropertyName("inventory_type")]
				[Description("库存类型，普通库存/区域库存")]
				public long InventoryType { get; set; }

				[JsonPropertyName("inventory_type_desc")]
				[Description("库存类型描述")]
				public string InventoryTypeDesc { get; set; }

				[JsonPropertyName("count")]
				[Description("库存变更数量")]
				public long Count { get; set; }

				[JsonPropertyName("warehouse_type")]
				[Description("仓类型：0-商家仓，1-跨境仓，2-云仓")]
				public long WarehouseType { get; set; }
			}

			[JsonPropertyName("post_amount")]
			[Description("运费（单位：分）")]
			public long PostAmount { get; set; }

			[JsonPropertyName("pre_sale_type")]
			[Description("预售类型 ，0 现货类型，1 全款预售 2 阶梯发货")]
			public long PreSaleType { get; set; }

			[JsonPropertyName("after_sale_info")]
			[Description("售后信息")]
			public AfterSaleInfoItem AfterSaleInfo { get; set; }

			public class AfterSaleInfoItem
			{
				[JsonPropertyName("after_sale_status")]
				[Description("售后状态，0-售后初始化， 6-售后申请， 7-售后退货中， 27-拒绝售后申请， 12-售后成功， 28-售后失败， 11-售后已发货， 29-退货后拒绝退款， 13-售后换货商家发货， 14-售后换货用户收货， 51-取消成功， 53-逆向交易完成")]
				public long AfterSaleStatus { get; set; }

				[JsonPropertyName("after_sale_type")]
				[Description("售后类型:0 售后退货退款:1-售后退款 2-售前退款 3-换货 4-系统取消 5-用户取消")]
				public long AfterSaleType { get; set; }

				[JsonPropertyName("refund_status")]
				[Description("退款状态:1-待退款；3-退款成功； 4-退款失败；当买家发起售后后又主动取消售后，此时after_sale_status=28并且refund_status=1的状态不变，不会流转至4状态；")]
				public long RefundStatus { get; set; }
			}

			[JsonPropertyName("promotion_redpack_amount")]
			[Description("红包优惠金额（单位：分）")]
			public long PromotionRedpackAmount { get; set; }

			[JsonPropertyName("promotion_redpack_platform_amount")]
			[Description("平台红包优惠金额（单位：分），属于平台的红包的优惠金额")]
			public long PromotionRedpackPlatformAmount { get; set; }

			[JsonPropertyName("promotion_redpack_talent_amount")]
			[Description("达人红包优惠金额（单位：分），属于达人的红包的优惠金额")]
			public long PromotionRedpackTalentAmount { get; set; }

			[JsonPropertyName("receive_type")]
			[Description("1:邮寄，2:自提")]
			public long ReceiveType { get; set; }

			[JsonPropertyName("need_serial_number")]
			[Description("是否需要上传序列号，用于判断发货时是否需要上传商品序列号（IMEI码或SN码），true 表示是3C数码商品，需要上传序列号")]
			public bool NeedSerialNumber { get; set; }

			[JsonPropertyName("ad_env_type")]
			[Description("广告来源，video：短视频 live：直播")]
			public string AdEnvType { get; set; }

			[JsonPropertyName("sku_order_tag_ui")]
			[Description("商品单标签")]
			public List<SkuOrderTagUiItem> SkuOrderTagUi { get; set; }

			public class SkuOrderTagUiItem
			{
				[JsonPropertyName("key")]
				[Description("标签key")]
				public string Key { get; set; }

				[JsonPropertyName("text")]
				[Description("标签文案")]
				public string Text { get; set; }

				[JsonPropertyName("hover_text")]
				[Description("标签备注文案")]
				public string HoverText { get; set; }

				[JsonPropertyName("tag_type")]
				[Description("标签类型，如颜色")]
				public string TagType { get; set; }

				[JsonPropertyName("help_doc")]
				[Description("帮助文档")]
				public string HelpDoc { get; set; }

				[JsonPropertyName("sort")]
				[Description("排序")]
				public long Sort { get; set; }

				[JsonPropertyName("extra")]
				[Description("标签其他信息")]
				public string Extra { get; set; }
			}

			[JsonPropertyName("product_id_str")]
			[Description("商品ID，字符串型")]
			public string ProductIdStr { get; set; }

			[JsonPropertyName("appointment_ship_time")]
			[Description("预约发货时间")]
			public long AppointmentShipTime { get; set; }

			[JsonPropertyName("room_id_str")]
			[Description("直播房间ID，字符串类型")]
			public string RoomIdStr { get; set; }

			[JsonPropertyName("given_product_type")]
			[Description("绑定类型 MASTER-主品单 FREE-免费赠品")]
			public string GivenProductType { get; set; }

			[JsonPropertyName("master_sku_order_id")]
			[Description("废弃，使用master_sku_order_id_list；绑定的主品sku单单号 如果given_product_type=FREE 则master_sku_order_id_list为主品sku单单号")]
			public string MasterSkuOrderId { get; set; }

			[JsonPropertyName("card_voucher")]
			[Description("商品卡券基本信息")]
			public CardVoucherItem CardVoucher { get; set; }

			public class CardVoucherItem
			{
				[JsonPropertyName("valid_days")]
				[Description("自领取之日起有效天数(如果有值优先使用该字段)")]
				public long ValidDays { get; set; }

				[JsonPropertyName("valid_start")]
				[Description("卡券开始时间")]
				public long ValidStart { get; set; }

				[JsonPropertyName("valid_end")]
				[Description("卡券截止日期")]
				public long ValidEnd { get; set; }
			}

			[JsonPropertyName("bundle_sku_info")]
			[Description("组套商品子商品列表")]
			public List<BundleSkuInfoItem> BundleSkuInfo { get; set; }

			public class BundleSkuInfoItem
			{
				[JsonPropertyName("product_id")]
				[Description("组套商品子商品ID")]
				public string ProductId { get; set; }

				[JsonPropertyName("sku_id")]
				[Description("组套商品子商品SKU_ID")]
				public string SkuId { get; set; }

				[JsonPropertyName("product_name")]
				[Description("组套商品子商品名称")]
				public string ProductName { get; set; }

				[JsonPropertyName("item_num")]
				[Description("组套商品子商品数量")]
				public long ItemNum { get; set; }

				[JsonPropertyName("picture_url")]
				[Description("组商品子商品图片")]
				public string PictureUrl { get; set; }

				[JsonPropertyName("code")]
				[Description("组套子商品外部编码")]
				public string Code { get; set; }
			}

			[JsonPropertyName("account_list")]
			[Description("账号信息list")]
			public AccountListItem AccountList { get; set; }

			public class AccountListItem
			{
				[JsonPropertyName("account_info")]
				[Description("账号信息")]
				public List<AccountInfoItem> AccountInfo { get; set; }

				public class AccountInfoItem
				{
					[JsonPropertyName("account_name")]
					[Description("账号名称")]
					public string AccountName { get; set; }

					[JsonPropertyName("account_type")]
					[Description("账号类型；枚举值：Mobile ：手机号;Email ：邮箱 ; IdCard ：身份证; Passport ：护照; BankCard ：银行卡; Number ：纯数学; NumberLetter ：数字字母混合;")]
					public string AccountType { get; set; }

					[JsonPropertyName("account_id")]
					[Description("账号值")]
					public string AccountId { get; set; }
				}
			}

			[JsonPropertyName("sku_customization_info")]
			[Description("定制商品信息")]
			public List<SkuCustomizationInfoItem> SkuCustomizationInfo { get; set; }

			public class SkuCustomizationInfoItem
			{
				[JsonPropertyName("detail")]
				[Description("定制详情")]
				public DetailItem Detail { get; set; }

				public class DetailItem
				{
					[JsonPropertyName("pic")]
					[Description("定制图片信息")]
					public List<PicItem> Pic { get; set; }

					public class PicItem
					{
						[JsonPropertyName("id")]
						[Description("id")]
						public long Id { get; set; }

						[JsonPropertyName("url")]
						[Description("url")]
						public string Url { get; set; }
					}

					[JsonPropertyName("text")]
					[Description("定制文案信息")]
					public List<TextItem> Text { get; set; }

					public class TextItem
					{
						[JsonPropertyName("id")]
						[Description("id")]
						public long Id { get; set; }

						[JsonPropertyName("key")]
						[Description("key")]
						public string Key { get; set; }

						[JsonPropertyName("content")]
						[Description("content")]
						public string Content { get; set; }
					}

					[JsonPropertyName("extra")]
					[Description("额外信息")]
					public string Extra { get; set; }
				}
			}

			[JsonPropertyName("author_cost_amount")]
			[Description("作者（达人）承担金额（单位：分），订单参与活动和优惠中作者（达人）承担部分的总金额")]
			public long AuthorCostAmount { get; set; }

			[JsonPropertyName("only_platform_cost_amount")]
			[Description("仅平台承担金额（单位：分），订单参与活动和优惠中平台承担部分的总金额")]
			public long OnlyPlatformCostAmount { get; set; }

			[JsonPropertyName("promise_info")]
			[Description("履约时效信息(json串)")]
			public string PromiseInfo { get; set; }

			[JsonPropertyName("store_info")]
			[Description("门店信息")]
			public StoreInfoItem StoreInfo { get; set; }

			public class StoreInfoItem
			{
				[JsonPropertyName("store_id")]
				[Description("门店id")]
				public string StoreId { get; set; }

				[JsonPropertyName("store_name")]
				[Description("门店名称")]
				public string StoreName { get; set; }

				[JsonPropertyName("store_tel")]
				[Description("门店电话")]
				public string StoreTel { get; set; }

				[JsonPropertyName("store_address")]
				[Description("门店地址")]
				public StoreAddressItem StoreAddress { get; set; }

				public class StoreAddressItem
				{
					[JsonPropertyName("province")]
					[Description("省")]
					public ProvinceItem Province { get; set; }

					public class ProvinceItem
					{
						[JsonPropertyName("name")]
						[Description("名称")]
						public string Name { get; set; }

						[JsonPropertyName("id")]
						[Description("id")]
						public string Id { get; set; }
					}

					[JsonPropertyName("city")]
					[Description("市")]
					public CityItem City { get; set; }

					public class CityItem
					{
						[JsonPropertyName("name")]
						[Description("名称")]
						public string Name { get; set; }

						[JsonPropertyName("id")]
						[Description("id")]
						public string Id { get; set; }
					}

					[JsonPropertyName("town")]
					[Description("县/区")]
					public TownItem Town { get; set; }

					public class TownItem
					{
						[JsonPropertyName("name")]
						[Description("名称")]
						public string Name { get; set; }

						[JsonPropertyName("id")]
						[Description("id")]
						public string Id { get; set; }
					}

					[JsonPropertyName("street")]
					[Description("街道")]
					public StreetItem Street { get; set; }

					public class StreetItem
					{
						[JsonPropertyName("name")]
						[Description("名称")]
						public string Name { get; set; }

						[JsonPropertyName("id")]
						[Description("id")]
						public string Id { get; set; }
					}

					[JsonPropertyName("detail")]
					[Description("详细信息")]
					public string Detail { get; set; }
				}

				[JsonPropertyName("extra")]
				[Description("扩展字段")]
				public string Extra { get; set; }
			}

			[JsonPropertyName("mask_post_receiver")]
			[Description("收件人姓名（脱敏后）")]
			public string MaskPostReceiver { get; set; }

			[JsonPropertyName("mask_post_tel")]
			[Description("收件人电话（脱敏后）")]
			public string MaskPostTel { get; set; }

			[JsonPropertyName("mask_post_addr")]
			[Description("收件人地址（脱敏后）")]
			public MaskPostAddrItem MaskPostAddr { get; set; }

			public class MaskPostAddrItem
			{
				[JsonPropertyName("province")]
				[Description("省")]
				public ProvinceItem Province { get; set; }

				public class ProvinceItem
				{
					[JsonPropertyName("name")]
					[Description("名称")]
					public string Name { get; set; }

					[JsonPropertyName("id")]
					[Description("id")]
					public string Id { get; set; }
				}

				[JsonPropertyName("city")]
				[Description("市")]
				public CityItem City { get; set; }

				public class CityItem
				{
					[JsonPropertyName("name")]
					[Description("名称")]
					public string Name { get; set; }

					[JsonPropertyName("id")]
					[Description("id")]
					public string Id { get; set; }
				}

				[JsonPropertyName("town")]
				[Description("县/区")]
				public TownItem Town { get; set; }

				public class TownItem
				{
					[JsonPropertyName("name")]
					[Description("名称")]
					public string Name { get; set; }

					[JsonPropertyName("id")]
					[Description("id")]
					public string Id { get; set; }
				}

				[JsonPropertyName("street")]
				[Description("街道")]
				public StreetItem Street { get; set; }

				public class StreetItem
				{
					[JsonPropertyName("name")]
					[Description("名称")]
					public string Name { get; set; }

					[JsonPropertyName("id")]
					[Description("id")]
					public string Id { get; set; }
				}

				[JsonPropertyName("detail")]
				[Description("详细地址")]
				public string Detail { get; set; }
			}

			[JsonPropertyName("contract_info")]
			[Description("合约信息")]
			public ContractInfoItem ContractInfo { get; set; }

			public class ContractInfoItem
			{
				[JsonPropertyName("mobile_no")]
				[Description("办理合约的手机号")]
				public string MobileNo { get; set; }
			}

			[JsonPropertyName("master_sku_order_id_list")]
			[Description("绑定的主品sku单单号 如果given_product_type=FREE 则master_sku_order_id为主品sku单单号")]
			public List<string> MasterSkuOrderIdList { get; set; }

			[JsonPropertyName("given_product_activity_info")]
			[Description("赠品活动信息")]
			public GivenProductActivityInfoItem GivenProductActivityInfo { get; set; }

			public class GivenProductActivityInfoItem
			{
				[JsonPropertyName("given_product_activity_type")]
				[Description("NORMAL-普通的买赠，AMOUNT-满件赠，PRICE-满元赠")]
				public string GivenProductActivityType { get; set; }

				[JsonPropertyName("given_product_activity_value")]
				[Description("满几件赠或满几元赠，满几元赠场景单位是分")]
				public string GivenProductActivityValue { get; set; }
			}

			[JsonPropertyName("quality_check_info")]
			[Description("质检信息")]
			public QualityCheckInfoItem QualityCheckInfo { get; set; }

			public class QualityCheckInfoItem
			{
				[JsonPropertyName("check_result_code")]
				[Description("质检结果 WATI_CHECT:待质检, CHECK_PASS:质检通过, CHECK_FAIL:质检不通过")]
				public string CheckResultCode { get; set; }

				[JsonPropertyName("check_fail_msg")]
				[Description("质检异常信息描述文案")]
				public string CheckFailMsg { get; set; }

				[JsonPropertyName("resend_check_time")]
				[Description("重新送检截止时间")]
				public long ResendCheckTime { get; set; }
			}

			[JsonPropertyName("sku_yun_warehouse_info")]
			[Description("sku云仓择仓信息（云仓业务使用，非商品区域仓功能使用）")]
			public List<SkuYunWarehouseInfoItem> SkuYunWarehouseInfo { get; set; }

			public class SkuYunWarehouseInfoItem
			{
				[JsonPropertyName("pre_allocated_yun_warehouse_info")]
				[Description("预分配云仓信息")]
				public PreAllocatedYunWarehouseInfoItem PreAllocatedYunWarehouseInfo { get; set; }

				public class PreAllocatedYunWarehouseInfoItem
				{
					[JsonPropertyName("yun_warehouse_code")]
					[Description("云仓code")]
					public string YunWarehouseCode { get; set; }

					[JsonPropertyName("yun_warehouse_name")]
					[Description("云仓名称")]
					public string YunWarehouseName { get; set; }
				}

				[JsonPropertyName("real_yun_warehouse_info")]
				[Description("云仓实仓信息")]
				public RealYunWarehouseInfoItem RealYunWarehouseInfo { get; set; }

				public class RealYunWarehouseInfoItem
				{
					[JsonPropertyName("yun_warehouse_code")]
					[Description("云仓code")]
					public string YunWarehouseCode { get; set; }

					[JsonPropertyName("yun_warehouse_name")]
					[Description("云仓名称")]
					public string YunWarehouseName { get; set; }
				}

				[JsonPropertyName("current_business_stage")]
				[Description("当前业务阶段 1-未分配 2-已分配未发货 2-已发货")]
				public long CurrentBusinessStage { get; set; }

				[JsonPropertyName("sku_id")]
				[Description("该仓对应的skuId")]
				public string SkuId { get; set; }

				[JsonPropertyName("sku_count")]
				[Description("sku数量")]
				public long SkuCount { get; set; }
			}

			[JsonPropertyName("tax_amount")]
			[Description("税费")]
			public long TaxAmount { get; set; }
		}

		[JsonPropertyName("seller_remark_stars")]
		[Description("卖家订单标记 小旗子star取值0～5，分别表示 灰紫青绿橙红")]
		public long SellerRemarkStars { get; set; }

		[JsonPropertyName("order_phase_list")]
		[Description("定金预售阶段单")]
		public List<OrderPhaseListItem> OrderPhaseList { get; set; }

		public class OrderPhaseListItem
		{
			[JsonPropertyName("phase_order_id")]
			[Description("阶段单id")]
			public string PhaseOrderId { get; set; }

			[JsonPropertyName("total_phase")]
			[Description("总共有几阶段")]
			public long TotalPhase { get; set; }

			[JsonPropertyName("current_phase")]
			[Description("第几阶段")]
			public long CurrentPhase { get; set; }

			[JsonPropertyName("pay_success")]
			[Description("是否支付成功")]
			public bool PaySuccess { get; set; }

			[JsonPropertyName("sku_order_id")]
			[Description("商品单ID")]
			public string SkuOrderId { get; set; }

			[JsonPropertyName("campaign_id")]
			[Description("活动id")]
			public long CampaignId { get; set; }

			[JsonPropertyName("phase_payable_price")]
			[Description("阶段价格：定金单价、尾款单价，单位：分")]
			public long PhasePayablePrice { get; set; }

			[JsonPropertyName("phase_pay_type")]
			[Description("支付类型:0-货到付款, 1-微信, 2-支付宝, 3-小程序, 4-银行卡, 5-余额, 7-无需支付, 8-放心花(信用支付), 9-新卡支付")]
			public long PhasePayType { get; set; }

			[JsonPropertyName("phase_open_time")]
			[Description("阶段单开始开启支付时间，时间戳")]
			public long PhaseOpenTime { get; set; }

			[JsonPropertyName("phase_pay_time")]
			[Description("阶段单支付成功时间，时间戳")]
			public long PhasePayTime { get; set; }

			[JsonPropertyName("phase_close_time")]
			[Description("阶段单关闭时间，时间戳")]
			public long PhaseCloseTime { get; set; }

			[JsonPropertyName("channel_payment_no")]
			[Description("渠道支付订单号")]
			public string ChannelPaymentNo { get; set; }

			[JsonPropertyName("phase_order_amount")]
			[Description("阶段单总金额，单位分，为订单金额phase_sum_amount+运费phase_post_amount,为支付金额phase_pay_amount+优惠金额phase_promotion_amount")]
			public long PhaseOrderAmount { get; set; }

			[JsonPropertyName("phase_sum_amount")]
			[Description("阶段单订单金额，单位分")]
			public long PhaseSumAmount { get; set; }

			[JsonPropertyName("phase_post_amount")]
			[Description("阶段单运费金额，单位分")]
			public long PhasePostAmount { get; set; }

			[JsonPropertyName("phase_pay_amount")]
			[Description("阶段单用户实际支付金额，单位分")]
			public long PhasePayAmount { get; set; }

			[JsonPropertyName("phase_promotion_amount")]
			[Description("阶段单总优惠金额，单位分")]
			public long PhasePromotionAmount { get; set; }

			[JsonPropertyName("current_phase_status_desc")]
			[Description("阶段状态描述")]
			public string CurrentPhaseStatusDesc { get; set; }

			[JsonPropertyName("sku_price")]
			[Description("sku单价，单位：分")]
			public long SkuPrice { get; set; }
		}

		[JsonPropertyName("doudian_open_id")]
		[Description("用户唯一id，规则详见：https://op.jinritemai.com/docs/guide-docs/1368/4416")]
		public string DoudianOpenId { get; set; }

		[JsonPropertyName("serial_number_list")]
		[Description("商品序列号（IMEI码或SN码）")]
		public List<string> SerialNumberList { get; set; }

		[JsonPropertyName("promotion_redpack_amount")]
		[Description("红包优惠金额（单位：分）")]
		public long PromotionRedpackAmount { get; set; }

		[JsonPropertyName("promotion_redpack_platform_amount")]
		[Description("平台红包优惠金额（单位：分），属于平台的红包的优惠金额")]
		public long PromotionRedpackPlatformAmount { get; set; }

		[JsonPropertyName("promotion_redpack_talent_amount")]
		[Description("达人红包优惠金额（单位：分），属于达人的红包的优惠金额")]
		public long PromotionRedpackTalentAmount { get; set; }

		[JsonPropertyName("user_id_info")]
		[Description("用户证件信息")]
		public UserIdInfoItem UserIdInfo { get; set; }

		public class UserIdInfoItem
		{
			[JsonPropertyName("id_card_no")]
			[Description("证件号")]
			public string IdCardNo { get; set; }

			[JsonPropertyName("id_card_name")]
			[Description("证件姓名")]
			public string IdCardName { get; set; }
		}

		[JsonPropertyName("appointment_ship_time")]
		[Description("预约发货时间")]
		public long AppointmentShipTime { get; set; }

		[JsonPropertyName("d_car_shop_biz_data")]
		[Description("懂车帝购车信息")]
		public DCarShopBizDataItem DCarShopBizData { get; set; }

		public class DCarShopBizDataItem
		{
			[JsonPropertyName("poi_id")]
			[Description("选择的门店ID")]
			public string PoiId { get; set; }

			[JsonPropertyName("poi_name")]
			[Description("选择的门店名称")]
			public string PoiName { get; set; }

			[JsonPropertyName("poi_addr")]
			[Description("选择的门店地址")]
			public string PoiAddr { get; set; }

			[JsonPropertyName("poi_tel")]
			[Description("选择的门店电话")]
			public string PoiTel { get; set; }

			[JsonPropertyName("coupon_right")]
			[Description("权益信息")]
			public List<CouponRightItem> CouponRight { get; set; }

			public class CouponRightItem
			{
				[JsonPropertyName("right_type")]
				[Description("权益类型")]
				public long RightType { get; set; }

				[JsonPropertyName("right_name")]
				[Description("权益名称")]
				public string RightName { get; set; }

				[JsonPropertyName("quota")]
				[Description("权益面值")]
				public long Quota { get; set; }
			}

			[JsonPropertyName("poi_pname")]
			[Description("选择的门店所在省")]
			public string PoiPname { get; set; }

			[JsonPropertyName("poi_city_name")]
			[Description("选择的门店所在市")]
			public string PoiCityName { get; set; }

			[JsonPropertyName("poi_adname")]
			[Description("选择的门店所在区县")]
			public string PoiAdname { get; set; }
		}

		[JsonPropertyName("shop_order_tag_ui")]
		[Description("店铺单标签")]
		public List<ShopOrderTagUiItem> ShopOrderTagUi { get; set; }

		public class ShopOrderTagUiItem
		{
			[JsonPropertyName("key")]
			[Description("标签Key")]
			public string Key { get; set; }

			[JsonPropertyName("text")]
			[Description("标签说明")]
			public string Text { get; set; }

			[JsonPropertyName("help_doc")]
			[Description("帮助文档地址")]
			public string HelpDoc { get; set; }
		}

		[JsonPropertyName("total_promotion_amount")]
		[Description("总优惠金额（单位：分），total_promotion_amount = promotion_amount + post_promotion_amount")]
		public long TotalPromotionAmount { get; set; }

		[JsonPropertyName("post_origin_amount")]
		[Description("运费原价（单位：分），post_origin_amount = post_amount + post_promotion_amount")]
		public long PostOriginAmount { get; set; }

		[JsonPropertyName("post_promotion_amount")]
		[Description("运费优惠金额（单位：分）")]
		public long PostPromotionAmount { get; set; }

		[JsonPropertyName("user_tag_ui")]
		[Description("用户特征标签")]
		public List<UserTagUiItem> UserTagUi { get; set; }

		public class UserTagUiItem
		{
			[JsonPropertyName("key")]
			[Description("标签key")]
			public string Key { get; set; }

			[JsonPropertyName("text")]
			[Description("标签名称")]
			public string Text { get; set; }
		}

		[JsonPropertyName("author_cost_amount")]
		[Description("作者（达人）承担金额（单位：分），订单参与活动和优惠中作者（达人）承担部分的总金额")]
		public long AuthorCostAmount { get; set; }

		[JsonPropertyName("only_platform_cost_amount")]
		[Description("仅平台承担金额（单位：分），订单参与活动和优惠中平台承担部分的总金额")]
		public long OnlyPlatformCostAmount { get; set; }

		[JsonPropertyName("promise_info")]
		[Description("履约时效信息(json串)")]
		public string PromiseInfo { get; set; }

		[JsonPropertyName("mask_post_receiver")]
		[Description("收件人姓名（脱敏后）")]
		public string MaskPostReceiver { get; set; }

		[JsonPropertyName("mask_post_tel")]
		[Description("收件人电话（脱敏后）")]
		public string MaskPostTel { get; set; }

		[JsonPropertyName("mask_post_addr")]
		[Description("收件人地址（脱敏后）")]
		public MaskPostAddrItem MaskPostAddr { get; set; }

		public class MaskPostAddrItem
		{
			[JsonPropertyName("province")]
			[Description("省")]
			public ProvinceItem Province { get; set; }

			public class ProvinceItem
			{
				[JsonPropertyName("name")]
				[Description("名称")]
				public string Name { get; set; }

				[JsonPropertyName("id")]
				[Description("id")]
				public string Id { get; set; }
			}

			[JsonPropertyName("city")]
			[Description("市")]
			public CityItem City { get; set; }

			public class CityItem
			{
				[JsonPropertyName("name")]
				[Description("名称")]
				public string Name { get; set; }

				[JsonPropertyName("id")]
				[Description("id")]
				public string Id { get; set; }
			}

			[JsonPropertyName("town")]
			[Description("县/区")]
			public TownItem Town { get; set; }

			public class TownItem
			{
				[JsonPropertyName("name")]
				[Description("名称")]
				public string Name { get; set; }

				[JsonPropertyName("id")]
				[Description("id")]
				public string Id { get; set; }
			}

			[JsonPropertyName("street")]
			[Description("街道")]
			public StreetItem Street { get; set; }

			public class StreetItem
			{
				[JsonPropertyName("name")]
				[Description("名称")]
				public string Name { get; set; }

				[JsonPropertyName("id")]
				[Description("id")]
				public string Id { get; set; }
			}

			[JsonPropertyName("detail")]
			[Description("详细地址")]
			public string Detail { get; set; }
		}

		[JsonPropertyName("user_coordinate")]
		[Description("买家收货地址经纬度信息，高德坐标系；")]
		public UserCoordinateItem UserCoordinate { get; set; }

		public class UserCoordinateItem
		{
			[JsonPropertyName("user_coordinate_longitude")]
			[Description("买家收货地址经度信息，高德坐标系；")]
			public string UserCoordinateLongitude { get; set; }

			[JsonPropertyName("user_coordinate_latitude")]
			[Description("买家收货地址纬度信息，高德坐标系；")]
			public string UserCoordinateLatitude { get; set; }
		}

		[JsonPropertyName("earliest_receipt_time")]
		[Description("预计最早送达时间，Unix时间戳：秒；当early_arrival=false时使用，仅小时达业务返回；")]
		public long EarliestReceiptTime { get; set; }

		[JsonPropertyName("latest_receipt_time")]
		[Description("latest_receipt_time：预计最晚送达时间，Unix时间戳：秒；当early_arrival=false时使用，仅小时达业务返回；")]
		public long LatestReceiptTime { get; set; }

		[JsonPropertyName("early_arrival")]
		[Description("early_arrival：是否尽快送达，true-是（配合target_arrival_time字段使用），false-否（配合earliest_receipt_time和latest_receipt_time使用），仅小时达业务返回；")]
		public bool EarlyArrival { get; set; }

		[JsonPropertyName("target_arrival_time")]
		[Description("尽快送达的时间点，Unix时间戳：秒；当early_arrival=true时使用，仅小时达业务返回；")]
		public long TargetArrivalTime { get; set; }

		[JsonPropertyName("packing_amount")]
		[Description("打包费，单位：分")]
		public long PackingAmount { get; set; }

		[JsonPropertyName("supermarket_order_serial_no")]
		[Description("门店流水号；仅小时达业务返回")]
		public string SupermarketOrderSerialNo { get; set; }

		[JsonPropertyName("tax_amount")]
		[Description("税费（子单税费之和）")]
		public long TaxAmount { get; set; }

		[JsonPropertyName("address_tag_ui")]
		[Description("地址标签列表")]
		public List<AddressTagUiItem> AddressTagUi { get; set; }

		public class AddressTagUiItem
		{
			[JsonPropertyName("key")]
			[Description("双地址标签 key")]
			public string Key { get; set; }

			[JsonPropertyName("text")]
			[Description("双地址")]
			public string Text { get; set; }

			[JsonPropertyName("hover_text")]
			[Description("双地址 hover 提示")]
			public string HoverText { get; set; }
		}

		[JsonPropertyName("greet_words")]
		[Description("鲜花订单的贺卡内容")]
		public string GreetWords { get; set; }

		[JsonPropertyName("mask_pay_tel")]
		[Description("脱敏后的下单人手机号(鲜花订单)")]
		public string MaskPayTel { get; set; }

		[JsonPropertyName("pay_tel")]
		[Description("加密后的下单人手机号（鲜花订单）")]
		public string PayTel { get; set; }

		[JsonPropertyName("open_address_id")]
		[Description("标识收件人地址的id，可用于合单")]
		public string OpenAddressId { get; set; }
	}
}
