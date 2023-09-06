namespace ecommerce.sdk.douyin;

[Description("查询订单的详细信息。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","订单不是该店铺下的订单，无权查询","isv.business-failed:20015","请检查订单号是否正确")]
[DouyinRetCode(40004,"非法的参数","查询订单不存在","isv.parameter-invalid:20014","请检查订单号是否正确")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20004","20000：如遇到该报错，建议再30秒内重试3~5次，如还是报错可提交工单咨询")]
[DouyinRetCode(40004,"非法的参数","订单不存在","isv.parameter-invalid:20001","检查订单号是否正确")]
[DouyinRetCode(40002,"缺少必选参数","请输入查询订单号","isv.missing-parameter:20000","检查订单号是否正确")]
[DouyinRetCode(50002,"业务处理失败","20045:查询失败，订单列表信息异常","isv.business-failed:20045","重试")]
[DouyinRetCode(50002,"业务处理失败","20055:查询失败，订单列表信息异常","isv.business-failed:20055","重试")]
public class OrderOrderDetailReq : IDouyinReq<OrderOrderDetailRsp>
{

	public string GetMethod() { return "order.orderDetail"; }

	public string GetUrl() { return "/order/orderDetail"; }

	[JsonPropertyName("shop_order_id")]
	[Description("店铺父订单号，抖店平台生成，平台下唯一；")]
	[NotNull]
	public string ShopOrderId { get; set; }
}

[Description("查询订单的详细信息。")]
public class OrderOrderDetailRsp
{
	[JsonPropertyName("shop_order_detail")]
	[Description("订单信息")]
	public ShopOrderDetailItem ShopOrderDetail { get; set; }

	public class ShopOrderDetailItem
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

		[JsonPropertyName("receipt_date")]
		[Description("用户选择的预约送达日期")]
		public string ReceiptDate { get; set; }

		[JsonPropertyName("recommend_end_ship_time")]
		[Description("建议商家最晚发货时间，秒")]
		public long RecommendEndShipTime { get; set; }

		[JsonPropertyName("recommend_start_ship_time")]
		[Description("建议商家最早发货时间，秒")]
		public long RecommendStartShipTime { get; set; }

		[JsonPropertyName("order_recycle_info")]
		[Description("回收单信息")]
		public OrderRecycleInfoItem OrderRecycleInfo { get; set; }

		public class OrderRecycleInfoItem
		{
			[JsonPropertyName("appoint_recycle_start_time")]
			[Description("预约拆机开始时间戳，单位：秒")]
			public long AppointRecycleStartTime { get; set; }

			[JsonPropertyName("appoint_recycle_end_time")]
			[Description("预约拆机结束时间戳，单位：秒")]
			public long AppointRecycleEndTime { get; set; }

			[JsonPropertyName("pronduct_desc")]
			[Description("回收商品描述")]
			public string PronductDesc { get; set; }

			[JsonPropertyName("quoted_price")]
			[Description("旧机回收价-单位：分")]
			public long QuotedPrice { get; set; }

			[JsonPropertyName("recycle_order_id")]
			[Description("回收旧机单单号")]
			public string RecycleOrderId { get; set; }

			[JsonPropertyName("recycle_status")]
			[Description("回收状态；1-接单；2-分配师傅；3-师傅上门签到；4-服务商审核；5-回收完成；99-取消")]
			public long RecycleStatus { get; set; }

			[JsonPropertyName("recycle_status_desc")]
			[Description("回收状态")]
			public string RecycleStatusDesc { get; set; }

			[JsonPropertyName("subsidy_receive_status")]
			[Description("旧机回收价发放状态")]
			public string SubsidyReceiveStatus { get; set; }

			[JsonPropertyName("supplier_code")]
			[Description("回收服务商code")]
			public string SupplierCode { get; set; }

			[JsonPropertyName("supplier_name")]
			[Description("服务商名称")]
			public string SupplierName { get; set; }
		}

		[JsonPropertyName("tax_amount_not_come_out")]
		[Description("跨境后置备案订单税费是否未计算完成 0-计算完成 1-未计算完成")]
		public long TaxAmountNotComeOut { get; set; }

		[JsonPropertyName("accept_order_status")]
		[Description("小时达订单的接单状态 0-未接单；1-已接单；2-超时取消，或商家取消")]
		public long AcceptOrderStatus { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺id，抖店平台生成，平台下唯一；")]
		public long ShopId { get; set; }

		[JsonPropertyName("shop_name")]
		[Description("商户名称")]
		public string ShopName { get; set; }

		[JsonPropertyName("open_id")]
		[Description("抖音小程序ID")]
		public string OpenId { get; set; }

		[JsonPropertyName("order_id")]
		[Description("店铺父订单号，抖店平台生成，平台下唯一；")]
		public string OrderId { get; set; }

		[JsonPropertyName("order_level")]
		[Description("订单层级，主订单是2级")]
		public long OrderLevel { get; set; }

		[JsonPropertyName("biz")]
		[Description("【业务来源】 1  -鲁班 2  -小店 3  -好好学习 4  -ev 5  -虚拟 6  -建站 7  -核销 8  -玉石 9  -ez 10 -ep 11 -虚拟卡券 12 -服务市场 13 - EP 视频课 14 - EP 直播课 21 -跨境BBC 22 -跨境BC 23 -跨境CC|UPU 24 -手机充值 25 -拍卖保证金 26 -懂车帝抵扣券 27 -懂车帝返现券 28 -离岛免税 29 -海南会员购 30 -抽奖 31 -清北-企业代付 32 -抖+券 33 -联盟寄样 49 -刀剑 53 -通信卡 66 -加油包 76 -大闸蟹 99 -保险 102-小店海外 108-上门取件收款")]
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
		[Description("交易类型，不推荐使用，已废弃。请使用sku_order_list.trade_type即可。")]
		public long TradeType { get; set; }

		[JsonPropertyName("trade_type_desc")]
		[Description("交易类型描述,不推荐使用，已废弃。请使用sku_order_list. trade_type_desc下即可。")]
		public string TradeTypeDesc { get; set; }

		[JsonPropertyName("order_status")]
		[Description("订单状态1 待确认/待支付（订单创建完毕）105 已支付 2 备货中 101 部分发货 3 已发货（全部发货）4 已取消5 已完成（已收货）")]
		public long OrderStatus { get; set; }

		[JsonPropertyName("order_status_desc")]
		[Description("订单状态描述")]
		public string OrderStatusDesc { get; set; }

		[JsonPropertyName("main_status")]
		[Description("主流程状态，1 待确认/待支付（订单创建完毕）103 部分支付105 已支付2 备货中101 部分发货3 已发货（全部发货）4 已取消5 已完成（已收货）21 发货前退款完结22 发货后退款完结39 收货后退款完结")]
		public long MainStatus { get; set; }

		[JsonPropertyName("main_status_desc")]
		[Description("主流程状态描述")]
		public string MainStatusDesc { get; set; }

		[JsonPropertyName("pay_time")]
		[Description("支付时间，时间戳，秒")]
		public long PayTime { get; set; }

		[JsonPropertyName("order_expire_time")]
		[Description("订单过期时间，时间戳，秒")]
		public long OrderExpireTime { get; set; }

		[JsonPropertyName("finish_time")]
		[Description("订单完成时间，时间戳，秒")]
		public long FinishTime { get; set; }

		[JsonPropertyName("create_time")]
		[Description("下单时间，时间戳，秒")]
		public long CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("订单更新时间，时间戳，秒")]
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
		[Description("订单优惠总金额（单位：分） = 店铺优惠金额 + 平台优惠金额 + 达人优惠金额")]
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

		[JsonPropertyName("encrypt_post_tel")]
		[Description("收件人电话")]
		public string EncryptPostTel { get; set; }

		[JsonPropertyName("encrypt_post_receiver")]
		[Description("收件人姓名")]
		public string EncryptPostReceiver { get; set; }

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

			[JsonPropertyName("encrypt_detail")]
			[Description("详细地址")]
			public string EncryptDetail { get; set; }
		}

		[JsonPropertyName("exp_ship_time")]
		[Description("预计发货时间，时间戳，秒")]
		public long ExpShipTime { get; set; }

		[JsonPropertyName("ship_time")]
		[Description("发货时间，时间戳，秒")]
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
			[Description("发货时间，时间戳，秒")]
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
				[Description("店铺子订单号，抖店平台生成，平台下唯一；注意：一笔订单下有一个子订单和父订单单号相同。")]
				public string SkuOrderId { get; set; }

				[JsonPropertyName("product_id_str")]
				[Description("商品ID，字符串类型")]
				public string ProductIdStr { get; set; }
			}

			[JsonPropertyName("added_services")]
			[Description("物流增值服务列表")]
			public List<AddedServicesItem> AddedServices { get; set; }

			public class AddedServicesItem
			{
				[JsonPropertyName("key")]
				[Description("标签key")]
				public string Key { get; set; }

				[JsonPropertyName("text")]
				[Description("物流服务名称")]
				public string Text { get; set; }

				[JsonPropertyName("help_doc")]
				[Description("抖音大学介绍地址")]
				public string HelpDoc { get; set; }

				[JsonPropertyName("url")]
				[Description("业务跳转地址")]
				public string Url { get; set; }
			}

			[JsonPropertyName("hour_up_pickup_code")]
			[Description("骑手取件码；触发场景①商家：抖超小时达商家通过平台运力发货并选择需要取件码时，该字段有值返回。应用场景①骑手到店后报流水号，门店员工根据流水号【示例值：流水号#1】找到对应包裹。②门店员工与骑手核对取件码，核对无误后交货给骑手；")]
			public string HourUpPickupCode { get; set; }

			[JsonPropertyName("guarantee_amount")]
			[Description("保价金额，单位：分（小时达业务使用）")]
			public long GuaranteeAmount { get; set; }
		}

		[JsonPropertyName("promotion_detail")]
		[Description("优惠信息，用户下单过程中享受到的优惠")]
		public PromotionDetailItem PromotionDetail { get; set; }

		public class PromotionDetailItem
		{
			[JsonPropertyName("shop_discount_detail")]
			[Description("店铺优惠信息")]
			public ShopDiscountDetailItem ShopDiscountDetail { get; set; }

			public class ShopDiscountDetailItem
			{
				[JsonPropertyName("redpack_info")]
				[Description("红包明细")]
				public List<RedpackInfoItem> RedpackInfo { get; set; }

				public class RedpackInfoItem
				{
					[JsonPropertyName("share_discount_cost")]
					[Description("分摊成本")]
					public ShareDiscountCostItem ShareDiscountCost { get; set; }

					public class ShareDiscountCostItem
					{
						[JsonPropertyName("author_cost")]
						[Description("作者承担金额，单位：分")]
						public long AuthorCost { get; set; }

						[JsonPropertyName("shop_cost")]
						[Description("商家承担金额，单位：分")]
						public long ShopCost { get; set; }

						[JsonPropertyName("platform_cost")]
						[Description("平台承担金额，单位：分")]
						public long PlatformCost { get; set; }
					}

					[JsonPropertyName("redpack_trans_id")]
					[Description("红包汇总id")]
					public string RedpackTransId { get; set; }

					[JsonPropertyName("redpack_amount")]
					[Description("红包金额，单位：分")]
					public long RedpackAmount { get; set; }
				}

				[JsonPropertyName("redpack_amount")]
				[Description("红包金额，单位：分")]
				public long RedpackAmount { get; set; }

				[JsonPropertyName("total_amount")]
				[Description("优惠总金额（单位：分）")]
				public long TotalAmount { get; set; }

				[JsonPropertyName("coupon_amount")]
				[Description("券优惠金额（单位：分）")]
				public long CouponAmount { get; set; }

				[JsonPropertyName("full_discount_amount")]
				[Description("活动优惠金额（单位：分）")]
				public long FullDiscountAmount { get; set; }

				[JsonPropertyName("coupon_info")]
				[Description("优惠券信息")]
				public List<CouponInfoItem> CouponInfo { get; set; }

				public class CouponInfoItem
				{
					[JsonPropertyName("coupon_activity_id")]
					[Description("优惠券所属商家活动ID")]
					public string CouponActivityId { get; set; }

					[JsonPropertyName("coupon_id")]
					[Description("订单优惠券ID")]
					public long CouponId { get; set; }

					[JsonPropertyName("coupon_type")]
					[Description("券类型；21-商家折扣券；22-商家直减券；23-商家满减券 ；41-单品折扣券；42-单品直减券；43 单品满减券；")]
					public long CouponType { get; set; }

					[JsonPropertyName("coupon_meta_id")]
					[Description("券批次ID")]
					public string CouponMetaId { get; set; }

					[JsonPropertyName("coupon_amount")]
					[Description("券优惠金额（单位：分）")]
					public long CouponAmount { get; set; }

					[JsonPropertyName("coupon_name")]
					[Description("券名称")]
					public string CouponName { get; set; }

					[JsonPropertyName("share_discount_cost")]
					[Description("成本分摊")]
					public ShareDiscountCostItem ShareDiscountCost { get; set; }

					public class ShareDiscountCostItem
					{
						[JsonPropertyName("platform_cost")]
						[Description("平台承担金额（单位：分）")]
						public long PlatformCost { get; set; }

						[JsonPropertyName("shop_cost")]
						[Description("商家承担金额（单位：分）")]
						public long ShopCost { get; set; }

						[JsonPropertyName("author_cost")]
						[Description("作者承担金额（单位：分）")]
						public long AuthorCost { get; set; }
					}
				}

				[JsonPropertyName("full_discount_info")]
				[Description("优惠活动信息")]
				public List<FullDiscountInfoItem> FullDiscountInfo { get; set; }

				public class FullDiscountInfoItem
				{
					[JsonPropertyName("campaign_activity_id")]
					[Description("商家活动ID")]
					public string CampaignActivityId { get; set; }

					[JsonPropertyName("campaign_id")]
					[Description("活动ID")]
					public long CampaignId { get; set; }

					[JsonPropertyName("campaign_type")]
					[Description("活动类型：100-店铺满减活动 110-平台满减活动 150-立减活动")]
					public long CampaignType { get; set; }

					[JsonPropertyName("share_discount_cost")]
					[Description("成本分摊")]
					public ShareDiscountCostItem ShareDiscountCost { get; set; }

					public class ShareDiscountCostItem
					{
						[JsonPropertyName("platform_cost")]
						[Description("平台承担金额（单位：分）")]
						public long PlatformCost { get; set; }

						[JsonPropertyName("shop_cost")]
						[Description("商家承担金额（单位：分）")]
						public long ShopCost { get; set; }

						[JsonPropertyName("author_cost")]
						[Description("作者承担金额（单位：分）")]
						public long AuthorCost { get; set; }
					}

					[JsonPropertyName("campaign_name")]
					[Description("活动名称")]
					public string CampaignName { get; set; }

					[JsonPropertyName("campaign_amount")]
					[Description("活动优惠金额（单位：分）")]
					public long CampaignAmount { get; set; }

					[JsonPropertyName("campaign_sub_type")]
					[Description("活动子类型：0 店铺活动，1 平台活动")]
					public long CampaignSubType { get; set; }
				}
			}

			[JsonPropertyName("platform_discount_detail")]
			[Description("平台优惠信息")]
			public PlatformDiscountDetailItem PlatformDiscountDetail { get; set; }

			public class PlatformDiscountDetailItem
			{
				[JsonPropertyName("official_deduction_amount")]
				[Description("官方立减金额（单位：分）")]
				public long OfficialDeductionAmount { get; set; }

				[JsonPropertyName("allowance_amount")]
				[Description("购物补贴抵扣金额（单位：分）")]
				public long AllowanceAmount { get; set; }

				[JsonPropertyName("user_balance_amount")]
				[Description("余额抵扣金额（单位：分）")]
				public long UserBalanceAmount { get; set; }

				[JsonPropertyName("total_amount")]
				[Description("优惠总金额（单位：分）")]
				public long TotalAmount { get; set; }

				[JsonPropertyName("coupon_amount")]
				[Description("券优惠金额（单位：分）")]
				public long CouponAmount { get; set; }

				[JsonPropertyName("full_discount_amount")]
				[Description("活动优惠金额（单位：分）")]
				public long FullDiscountAmount { get; set; }

				[JsonPropertyName("coupon_info")]
				[Description("优惠券信息")]
				public List<CouponInfoItem> CouponInfo { get; set; }

				public class CouponInfoItem
				{
					[JsonPropertyName("coupon_id")]
					[Description("订单优惠券ID")]
					public long CouponId { get; set; }

					[JsonPropertyName("coupon_type")]
					[Description("券类型,1-平台折扣券; 2-平台直减券;3-平台满减券;")]
					public long CouponType { get; set; }

					[JsonPropertyName("coupon_meta_id")]
					[Description("券批次ID")]
					public string CouponMetaId { get; set; }

					[JsonPropertyName("coupon_amount")]
					[Description("券优惠金额（单位：分）")]
					public long CouponAmount { get; set; }

					[JsonPropertyName("coupon_name")]
					[Description("券名称")]
					public string CouponName { get; set; }

					[JsonPropertyName("share_discount_cost")]
					[Description("成本分摊")]
					public ShareDiscountCostItem ShareDiscountCost { get; set; }

					public class ShareDiscountCostItem
					{
						[JsonPropertyName("platform_cost")]
						[Description("平台承担金额（单位：分）")]
						public long PlatformCost { get; set; }

						[JsonPropertyName("shop_cost")]
						[Description("商家承担金额（单位：分）")]
						public long ShopCost { get; set; }

						[JsonPropertyName("author_cost")]
						[Description("作者承担金额（单位：分）")]
						public long AuthorCost { get; set; }
					}
				}

				[JsonPropertyName("full_discount_info")]
				[Description("优惠活动信息")]
				public List<FullDiscountInfoItem> FullDiscountInfo { get; set; }

				public class FullDiscountInfoItem
				{
					[JsonPropertyName("campaign_id")]
					[Description("活动ID")]
					public long CampaignId { get; set; }

					[JsonPropertyName("campaign_type")]
					[Description("活动类型；100-店铺满减活动；110-平台满减活动；150-新人首单立减活动；")]
					public long CampaignType { get; set; }

					[JsonPropertyName("share_discount_cost")]
					[Description("成本分摊")]
					public ShareDiscountCostItem ShareDiscountCost { get; set; }

					public class ShareDiscountCostItem
					{
						[JsonPropertyName("platform_cost")]
						[Description("平台承担金额（单位：分）")]
						public long PlatformCost { get; set; }

						[JsonPropertyName("shop_cost")]
						[Description("商家承担金额（单位：分）")]
						public long ShopCost { get; set; }

						[JsonPropertyName("author_cost")]
						[Description("作者承担金额（单位：分）")]
						public long AuthorCost { get; set; }
					}

					[JsonPropertyName("campaign_name")]
					[Description("活动名称")]
					public string CampaignName { get; set; }

					[JsonPropertyName("campaign_amount")]
					[Description("活动优惠金额（单位：分）")]
					public long CampaignAmount { get; set; }

					[JsonPropertyName("campaign_sub_type")]
					[Description("活动子类型：0-店铺活动，1-平台活动")]
					public long CampaignSubType { get; set; }
				}

				[JsonPropertyName("redpack_amount")]
				[Description("红包金额（单位：分）")]
				public long RedpackAmount { get; set; }

				[JsonPropertyName("redpack_info")]
				[Description("红包信息")]
				public List<RedpackInfoItem> RedpackInfo { get; set; }

				public class RedpackInfoItem
				{
					[JsonPropertyName("redpack_trans_id")]
					[Description("红包汇总ID")]
					public string RedpackTransId { get; set; }

					[JsonPropertyName("redpack_amount")]
					[Description("红包金额（单位：分）")]
					public long RedpackAmount { get; set; }

					[JsonPropertyName("share_discount_cost")]
					[Description("成本分摊")]
					public ShareDiscountCostItem ShareDiscountCost { get; set; }

					public class ShareDiscountCostItem
					{
						[JsonPropertyName("platform_cost")]
						[Description("平台承担金额（单位：分）")]
						public long PlatformCost { get; set; }

						[JsonPropertyName("shop_cost")]
						[Description("商家承担金额（单位：分）")]
						public long ShopCost { get; set; }

						[JsonPropertyName("author_cost")]
						[Description("作者承担金额（单位：分）")]
						public long AuthorCost { get; set; }
					}
				}

				[JsonPropertyName("gold_coin_amount")]
				[Description("金币抵扣金额（单位：分）")]
				public long GoldCoinAmount { get; set; }
			}

			[JsonPropertyName("kol_discount_detail")]
			[Description("达人优惠信息")]
			public KolDiscountDetailItem KolDiscountDetail { get; set; }

			public class KolDiscountDetailItem
			{
				[JsonPropertyName("total_amount")]
				[Description("优惠总金额（单位：分）")]
				public long TotalAmount { get; set; }

				[JsonPropertyName("coupon_amount")]
				[Description("券优惠金额（单位：分）")]
				public long CouponAmount { get; set; }

				[JsonPropertyName("full_discount_amount")]
				[Description("活动优惠金额（单位：分）")]
				public long FullDiscountAmount { get; set; }

				[JsonPropertyName("coupon_info")]
				[Description("优惠券信息")]
				public List<CouponInfoItem> CouponInfo { get; set; }

				public class CouponInfoItem
				{
					[JsonPropertyName("coupon_id")]
					[Description("订单优惠券ID")]
					public long CouponId { get; set; }

					[JsonPropertyName("coupon_type")]
					[Description("券类型;52-达人直减券;53-达人满减券;")]
					public long CouponType { get; set; }

					[JsonPropertyName("coupon_meta_id")]
					[Description("券批次ID")]
					public string CouponMetaId { get; set; }

					[JsonPropertyName("coupon_amount")]
					[Description("券优惠金额（单位：分）")]
					public long CouponAmount { get; set; }

					[JsonPropertyName("coupon_name")]
					[Description("券名称")]
					public string CouponName { get; set; }

					[JsonPropertyName("share_discount_cost")]
					[Description("成本分摊")]
					public ShareDiscountCostItem ShareDiscountCost { get; set; }

					public class ShareDiscountCostItem
					{
						[JsonPropertyName("platform_cost")]
						[Description("平台承担金额（单位：分）")]
						public long PlatformCost { get; set; }

						[JsonPropertyName("shop_cost")]
						[Description("商家承担金额（单位：分）")]
						public long ShopCost { get; set; }

						[JsonPropertyName("author_cost")]
						[Description("作者承担金额（单位：分）")]
						public long AuthorCost { get; set; }
					}
				}

				[JsonPropertyName("full_discount_info")]
				[Description("优惠活动信息")]
				public List<FullDiscountInfoItem> FullDiscountInfo { get; set; }

				public class FullDiscountInfoItem
				{
					[JsonPropertyName("campaign_id")]
					[Description("活动ID")]
					public long CampaignId { get; set; }

					[JsonPropertyName("campaign_type")]
					[Description("活动类型；100-店铺满减活动；110-平台满减活动；150-新人首单立减活动；")]
					public long CampaignType { get; set; }

					[JsonPropertyName("share_discount_cost")]
					[Description("成本分摊")]
					public ShareDiscountCostItem ShareDiscountCost { get; set; }

					public class ShareDiscountCostItem
					{
						[JsonPropertyName("platform_cost")]
						[Description("平台承担金额（单位：分）")]
						public long PlatformCost { get; set; }

						[JsonPropertyName("shop_cost")]
						[Description("商家承担金额（单位：分）")]
						public long ShopCost { get; set; }

						[JsonPropertyName("author_cost")]
						[Description("作者承担金额（单位：分）")]
						public long AuthorCost { get; set; }
					}

					[JsonPropertyName("campaign_name")]
					[Description("活动名称")]
					public string CampaignName { get; set; }

					[JsonPropertyName("campaign_amount")]
					[Description("活动优惠金额（单位：分）")]
					public long CampaignAmount { get; set; }

					[JsonPropertyName("campaign_sub_type")]
					[Description("活动子类型：0-店铺活动，1-平台活动")]
					public long CampaignSubType { get; set; }
				}

				[JsonPropertyName("redpack_amount")]
				[Description("红包金额（单位：分）")]
				public long RedpackAmount { get; set; }

				[JsonPropertyName("redpack_info")]
				[Description("红包信息")]
				public List<RedpackInfoItem> RedpackInfo { get; set; }

				public class RedpackInfoItem
				{
					[JsonPropertyName("redpack_trans_id")]
					[Description("红包汇总ID")]
					public string RedpackTransId { get; set; }

					[JsonPropertyName("redpack_amount")]
					[Description("红包金额（单位：分）")]
					public long RedpackAmount { get; set; }

					[JsonPropertyName("share_discount_cost")]
					[Description("成本分摊")]
					public ShareDiscountCostItem ShareDiscountCost { get; set; }

					public class ShareDiscountCostItem
					{
						[JsonPropertyName("platform_cost")]
						[Description("平台承担金额（单位：分）")]
						public long PlatformCost { get; set; }

						[JsonPropertyName("shop_cost")]
						[Description("商家承担金额（单位：分）")]
						public long ShopCost { get; set; }

						[JsonPropertyName("author_cost")]
						[Description("作者承担金额（单位：分）")]
						public long AuthorCost { get; set; }
					}
				}
			}
		}

		[JsonPropertyName("sku_order_list")]
		[Description("订单详情信息，一个主订单下有可以最大返回40个子订单")]
		public List<SkuOrderListItem> SkuOrderList { get; set; }

		public class SkuOrderListItem
		{
			[JsonPropertyName("tax_amount_not_come_out")]
			[Description("跨境后置备案订单税费是否未计算完成 0-计算完成 1-未计算完成")]
			public long TaxAmountNotComeOut { get; set; }

			[JsonPropertyName("goods_price")]
			[Description("商品原价（单位：分）")]
			public long GoodsPrice { get; set; }

			[JsonPropertyName("sku_car_model_desc")]
			[Description("车型")]
			public string SkuCarModelDesc { get; set; }

			[JsonPropertyName("quality_inspection_status")]
			[Description("质检状态;0-无需质检;1-可质检;2-必须质检")]
			public long QualityInspectionStatus { get; set; }

			[JsonPropertyName("order_id")]
			[Description("店铺子订单号，抖店平台生成，平台下唯一；注意：一笔订单下有一个子订单和父订单单号相同。")]
			public string OrderId { get; set; }

			[JsonPropertyName("parent_order_id")]
			[Description("店铺父订单号，抖店平台生成，平台下唯一；")]
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
			[Description("【订单类型】 0-普通订单 2-虚拟商品订单 4-电子券（poi核销） 5-三方核销")]
			public long OrderType { get; set; }

			[JsonPropertyName("order_type_desc")]
			[Description("订单类型描述")]
			public string OrderTypeDesc { get; set; }

			[JsonPropertyName("trade_type")]
			[Description("交易类型：0-普通；1-拼团；2-定金预售；3-订金找货；4-拍卖；5-0元单；6-回收；7-寄卖；10-寄样；11-0元抽奖(超级福袋)；12-达人买样；13-普通定制；16-大众竞拍；18-小时达；102-定金预售的赠品单；103-收款；")]
			public long TradeType { get; set; }

			[JsonPropertyName("trade_type_desc")]
			[Description("交易类型描述")]
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
			[Description("支付时间，时间戳，秒")]
			public long PayTime { get; set; }

			[JsonPropertyName("order_expire_time")]
			[Description("订单过期时间，时间戳，秒")]
			public long OrderExpireTime { get; set; }

			[JsonPropertyName("finish_time")]
			[Description("订单完成时间，时间戳，秒")]
			public long FinishTime { get; set; }

			[JsonPropertyName("create_time")]
			[Description("下单时间，时间戳，秒")]
			public long CreateTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("订单更新时间，时间戳，秒")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("cancel_reason")]
			[Description("取消原因")]
			public string CancelReason { get; set; }

			[JsonPropertyName("b_type")]
			[Description("【下单端】 0-站外 1-火山 2-抖音 3-头条 4-西瓜 5-微信 6-值点app 7、头条lite 8、懂车帝 9、皮皮虾 11、抖音极速版 12、TikTok 13、musically 14、穿山甲 15、火山极速版 16、服务市场 26、番茄小说 27、UG教育营销电商平台 28、Jumanji 29、电商SDK")]
			public long BType { get; set; }

			[JsonPropertyName("b_type_desc")]
			[Description("下单端描述")]
			public string BTypeDesc { get; set; }

			[JsonPropertyName("sub_b_type")]
			[Description("【下单场景】 0-未知 1-app内-原生 2-app内-小程序 3-H5 13-电商SDK-头条 35-电商SDK-头条lite")]
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
			[Description("直播主播id（达人）;仅直播间和橱窗产生的订单会有值返回;")]
			public long AuthorId { get; set; }

			[JsonPropertyName("author_name")]
			[Description("直播主播名称;仅直播间和橱窗产生的订单会有值返回")]
			public string AuthorName { get; set; }

			[JsonPropertyName("theme_type")]
			[Description("【下单来源】 0-其他 1-直播间（废弃）")]
			public string ThemeType { get; set; }

			[JsonPropertyName("theme_type_desc")]
			[Description("下单来源描述（废弃）")]
			public string ThemeTypeDesc { get; set; }

			[JsonPropertyName("app_id")]
			[Description("具体某个小程序的ID")]
			public long AppId { get; set; }

			[JsonPropertyName("room_id")]
			[Description("直播间id，有值则代表订单来自直播间")]
			public long RoomId { get; set; }

			[JsonPropertyName("content_id")]
			[Description("内容id。（该字段无实际意义，已废弃）")]
			public string ContentId { get; set; }

			[JsonPropertyName("video_id")]
			[Description("视频id，有值则代表订单来自短视频")]
			public string VideoId { get; set; }

			[JsonPropertyName("origin_id")]
			[Description("已废弃，流量来源id")]
			public string OriginId { get; set; }

			[JsonPropertyName("cid")]
			[Description("已废弃，广告id")]
			public long Cid { get; set; }

			[JsonPropertyName("c_biz")]
			[Description("【C端流量来源】 0-unknown  2-精选联盟  8-小店自卖")]
			public long CBiz { get; set; }

			[JsonPropertyName("c_biz_desc")]
			[Description("C端流量来源业务类型描述")]
			public string CBizDesc { get; set; }

			[JsonPropertyName("page_id")]
			[Description("鲁班广告落地页ID")]
			public long PageId { get; set; }

			[JsonPropertyName("pay_type")]
			[Description("【支付类型】 0-货到付款 1-微信 2-支付宝 3-小程序 4-银行卡 5、余额 7、无需支付（0元单） 8、DOU分期（信用支付） 9、新卡支付")]
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
			[Description("订单优惠总金额（单位：分） = 店铺优惠金额 + 平台优惠金额 + 达人优惠金额")]
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

			[JsonPropertyName("encrypt_post_tel")]
			[Description("收件人电话")]
			public string EncryptPostTel { get; set; }

			[JsonPropertyName("encrypt_post_receiver")]
			[Description("收件人姓名")]
			public string EncryptPostReceiver { get; set; }

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

				[JsonPropertyName("encrypt_detail")]
				[Description("详细地址")]
				public string EncryptDetail { get; set; }
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
			[Description("【商品类型】 0-实体 1-虚拟")]
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
			[Description("【库存扣减方式】 1-下单减库存 2-支付减库存")]
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

			[JsonPropertyName("promotion_detail")]
			[Description("优惠信息")]
			public PromotionDetailItem PromotionDetail { get; set; }

			public class PromotionDetailItem
			{
				[JsonPropertyName("shop_discount_detail")]
				[Description("店铺优惠信息")]
				public ShopDiscountDetailItem ShopDiscountDetail { get; set; }

				public class ShopDiscountDetailItem
				{
					[JsonPropertyName("redpack_amount")]
					[Description("红包金额，单位：分")]
					public long RedpackAmount { get; set; }

					[JsonPropertyName("redpack_info")]
					[Description("红包信息")]
					public List<RedpackInfoItem> RedpackInfo { get; set; }

					public class RedpackInfoItem
					{
						[JsonPropertyName("redpack_trans_id")]
						[Description("红包汇总id")]
						public string RedpackTransId { get; set; }

						[JsonPropertyName("redpack_amount")]
						[Description("红包金额，单位：分")]
						public long RedpackAmount { get; set; }

						[JsonPropertyName("share_discount_cost")]
						[Description("分摊明细")]
						public ShareDiscountCostItem ShareDiscountCost { get; set; }

						public class ShareDiscountCostItem
						{
							[JsonPropertyName("platform_cost")]
							[Description("平台承担金额，单位：分")]
							public long PlatformCost { get; set; }

							[JsonPropertyName("shop_cost")]
							[Description("商家承担金额，单位：分")]
							public long ShopCost { get; set; }

							[JsonPropertyName("author_cost")]
							[Description("作者承担金额，单位：分")]
							public long AuthorCost { get; set; }
						}
					}

					[JsonPropertyName("total_amount")]
					[Description("优惠总金额（单位：分）")]
					public long TotalAmount { get; set; }

					[JsonPropertyName("coupon_amount")]
					[Description("券优惠金额（单位：分）")]
					public long CouponAmount { get; set; }

					[JsonPropertyName("full_discount_amount")]
					[Description("活动优惠金额（单位：分）")]
					public long FullDiscountAmount { get; set; }

					[JsonPropertyName("coupon_info")]
					[Description("优惠券信息")]
					public List<CouponInfoItem> CouponInfo { get; set; }

					public class CouponInfoItem
					{
						[JsonPropertyName("coupon_activity_id")]
						[Description("优惠券所属商家活动ID")]
						public string CouponActivityId { get; set; }

						[JsonPropertyName("coupon_id")]
						[Description("订单优惠券ID")]
						public long CouponId { get; set; }

						[JsonPropertyName("coupon_type")]
						[Description("券类型；21-商家折扣券；22-商家直减券；23-商家满减券 ；41-单品折扣券；42-单品直减券；43 单品满减券；")]
						public long CouponType { get; set; }

						[JsonPropertyName("coupon_meta_id")]
						[Description("券批次ID")]
						public string CouponMetaId { get; set; }

						[JsonPropertyName("coupon_amount")]
						[Description("券优惠金额（单位：分）")]
						public long CouponAmount { get; set; }

						[JsonPropertyName("coupon_name")]
						[Description("券名称")]
						public string CouponName { get; set; }

						[JsonPropertyName("share_discount_cost")]
						[Description("成本分摊")]
						public ShareDiscountCostItem ShareDiscountCost { get; set; }

						public class ShareDiscountCostItem
						{
							[JsonPropertyName("platform_cost")]
							[Description("平台承担金额（单位：分）")]
							public long PlatformCost { get; set; }

							[JsonPropertyName("shop_cost")]
							[Description("商家承担金额（单位：分）")]
							public long ShopCost { get; set; }

							[JsonPropertyName("author_cost")]
							[Description("作者承担金额（单位：分）")]
							public long AuthorCost { get; set; }
						}
					}

					[JsonPropertyName("full_discount_info")]
					[Description("优惠活动信息")]
					public List<FullDiscountInfoItem> FullDiscountInfo { get; set; }

					public class FullDiscountInfoItem
					{
						[JsonPropertyName("campaign_activity_id")]
						[Description("商家活动ID")]
						public string CampaignActivityId { get; set; }

						[JsonPropertyName("campaign_id")]
						[Description("活动ID")]
						public long CampaignId { get; set; }

						[JsonPropertyName("campaign_type")]
						[Description("活动类型；100-店铺满减活动；110-平台满减活动；150-新人首单立减活动；")]
						public long CampaignType { get; set; }

						[JsonPropertyName("share_discount_cost")]
						[Description("成本分摊")]
						public ShareDiscountCostItem ShareDiscountCost { get; set; }

						public class ShareDiscountCostItem
						{
							[JsonPropertyName("platform_cost")]
							[Description("平台承担金额（单位：分）")]
							public long PlatformCost { get; set; }

							[JsonPropertyName("shop_cost")]
							[Description("商家承担金额（单位：分）")]
							public long ShopCost { get; set; }

							[JsonPropertyName("author_cost")]
							[Description("作者承担金额（单位：分）")]
							public long AuthorCost { get; set; }
						}

						[JsonPropertyName("campaign_name")]
						[Description("活动名称")]
						public string CampaignName { get; set; }

						[JsonPropertyName("campaign_amount")]
						[Description("活动优惠金额（单位：分）")]
						public long CampaignAmount { get; set; }

						[JsonPropertyName("campaign_sub_type")]
						[Description("活动子类型：0-店铺活动，1-平台活动")]
						public long CampaignSubType { get; set; }
					}
				}

				[JsonPropertyName("platform_discount_detail")]
				[Description("平台优惠信息")]
				public PlatformDiscountDetailItem PlatformDiscountDetail { get; set; }

				public class PlatformDiscountDetailItem
				{
					[JsonPropertyName("official_deduction_amount")]
					[Description("官方立减金额（单位：分）")]
					public long OfficialDeductionAmount { get; set; }

					[JsonPropertyName("allowance_amount")]
					[Description("购物补贴抵扣金额（单位：分）")]
					public long AllowanceAmount { get; set; }

					[JsonPropertyName("user_balance_amount")]
					[Description("余额抵扣金额（单位：分）")]
					public long UserBalanceAmount { get; set; }

					[JsonPropertyName("total_amount")]
					[Description("优惠总金额（单位：分）")]
					public long TotalAmount { get; set; }

					[JsonPropertyName("coupon_amount")]
					[Description("券优惠金额（单位：分）")]
					public long CouponAmount { get; set; }

					[JsonPropertyName("full_discount_amount")]
					[Description("活动优惠金额（单位：分）")]
					public long FullDiscountAmount { get; set; }

					[JsonPropertyName("coupon_info")]
					[Description("优惠券信息")]
					public List<CouponInfoItem> CouponInfo { get; set; }

					public class CouponInfoItem
					{
						[JsonPropertyName("coupon_id")]
						[Description("订单优惠券ID")]
						public long CouponId { get; set; }

						[JsonPropertyName("coupon_type")]
						[Description("券类型,1-平台折扣券; 2-平台直减券;3-平台满减券;")]
						public long CouponType { get; set; }

						[JsonPropertyName("coupon_meta_id")]
						[Description("券批次ID")]
						public string CouponMetaId { get; set; }

						[JsonPropertyName("coupon_amount")]
						[Description("券优惠金额（单位：分）")]
						public long CouponAmount { get; set; }

						[JsonPropertyName("coupon_name")]
						[Description("券名称")]
						public string CouponName { get; set; }

						[JsonPropertyName("share_discount_cost")]
						[Description("成本分摊")]
						public ShareDiscountCostItem ShareDiscountCost { get; set; }

						public class ShareDiscountCostItem
						{
							[JsonPropertyName("platform_cost")]
							[Description("平台承担金额（单位：分）")]
							public long PlatformCost { get; set; }

							[JsonPropertyName("shop_cost")]
							[Description("商家承担金额（单位：分）")]
							public long ShopCost { get; set; }

							[JsonPropertyName("author_cost")]
							[Description("作者承担金额（单位：分）")]
							public long AuthorCost { get; set; }
						}
					}

					[JsonPropertyName("full_discount_info")]
					[Description("优惠活动信息")]
					public List<FullDiscountInfoItem> FullDiscountInfo { get; set; }

					public class FullDiscountInfoItem
					{
						[JsonPropertyName("campaign_id")]
						[Description("活动ID")]
						public long CampaignId { get; set; }

						[JsonPropertyName("campaign_type")]
						[Description("活动类型；100-店铺满减活动；110-平台满减活动；150-新人首单立减活动；")]
						public long CampaignType { get; set; }

						[JsonPropertyName("share_discount_cost")]
						[Description("成本分摊")]
						public ShareDiscountCostItem ShareDiscountCost { get; set; }

						public class ShareDiscountCostItem
						{
							[JsonPropertyName("platform_cost")]
							[Description("平台承担金额（单位：分）")]
							public long PlatformCost { get; set; }

							[JsonPropertyName("shop_cost")]
							[Description("商家承担金额（单位：分）")]
							public long ShopCost { get; set; }

							[JsonPropertyName("author_cost")]
							[Description("作者承担金额（单位：分）")]
							public long AuthorCost { get; set; }
						}

						[JsonPropertyName("campaign_name")]
						[Description("活动名称")]
						public string CampaignName { get; set; }

						[JsonPropertyName("campaign_amount")]
						[Description("活动优惠金额（单位：分）")]
						public long CampaignAmount { get; set; }

						[JsonPropertyName("campaign_sub_type")]
						[Description("活动子类型：0 店铺活动，1 平台活动")]
						public long CampaignSubType { get; set; }
					}

					[JsonPropertyName("redpack_amount")]
					[Description("红包金额（单位：分）")]
					public long RedpackAmount { get; set; }

					[JsonPropertyName("redpack_info")]
					[Description("红包信息")]
					public List<RedpackInfoItem> RedpackInfo { get; set; }

					public class RedpackInfoItem
					{
						[JsonPropertyName("redpack_trans_id")]
						[Description("红包汇总ID")]
						public string RedpackTransId { get; set; }

						[JsonPropertyName("redpack_amount")]
						[Description("红包金额（单位：分）")]
						public long RedpackAmount { get; set; }

						[JsonPropertyName("share_discount_cost")]
						[Description("成本分摊")]
						public ShareDiscountCostItem ShareDiscountCost { get; set; }

						public class ShareDiscountCostItem
						{
							[JsonPropertyName("platform_cost")]
							[Description("平台承担金额（单位：分）")]
							public long PlatformCost { get; set; }

							[JsonPropertyName("shop_cost")]
							[Description("商家承担金额（单位：分）")]
							public long ShopCost { get; set; }

							[JsonPropertyName("author_cost")]
							[Description("作者承担金额（单位：分）")]
							public long AuthorCost { get; set; }
						}
					}

					[JsonPropertyName("gold_coin_amount")]
					[Description("金币抵扣金额（单位：分）")]
					public long GoldCoinAmount { get; set; }
				}

				[JsonPropertyName("kol_discount_detail")]
				[Description("达人优惠信息")]
				public KolDiscountDetailItem KolDiscountDetail { get; set; }

				public class KolDiscountDetailItem
				{
					[JsonPropertyName("total_amount")]
					[Description("优惠总金额（单位：分）")]
					public long TotalAmount { get; set; }

					[JsonPropertyName("coupon_amount")]
					[Description("券优惠金额（单位：分）")]
					public long CouponAmount { get; set; }

					[JsonPropertyName("full_discount_amount")]
					[Description("活动优惠金额（单位：分）")]
					public long FullDiscountAmount { get; set; }

					[JsonPropertyName("coupon_info")]
					[Description("优惠券信息")]
					public List<CouponInfoItem> CouponInfo { get; set; }

					public class CouponInfoItem
					{
						[JsonPropertyName("coupon_id")]
						[Description("订单优惠券ID")]
						public long CouponId { get; set; }

						[JsonPropertyName("coupon_type")]
						[Description("券类型;52-达人直减券;53-达人满减券;")]
						public long CouponType { get; set; }

						[JsonPropertyName("coupon_meta_id")]
						[Description("券批次ID")]
						public string CouponMetaId { get; set; }

						[JsonPropertyName("coupon_amount")]
						[Description("券优惠金额（单位：分）")]
						public long CouponAmount { get; set; }

						[JsonPropertyName("coupon_name")]
						[Description("券名称")]
						public string CouponName { get; set; }

						[JsonPropertyName("share_discount_cost")]
						[Description("成本分摊")]
						public ShareDiscountCostItem ShareDiscountCost { get; set; }

						public class ShareDiscountCostItem
						{
							[JsonPropertyName("platform_cost")]
							[Description("平台承担金额（单位：分）")]
							public long PlatformCost { get; set; }

							[JsonPropertyName("shop_cost")]
							[Description("商家承担金额（单位：分）")]
							public long ShopCost { get; set; }

							[JsonPropertyName("author_cost")]
							[Description("作者承担金额（单位：分）")]
							public long AuthorCost { get; set; }
						}
					}

					[JsonPropertyName("full_discount_info")]
					[Description("优惠活动信息")]
					public List<FullDiscountInfoItem> FullDiscountInfo { get; set; }

					public class FullDiscountInfoItem
					{
						[JsonPropertyName("campaign_id")]
						[Description("活动ID")]
						public long CampaignId { get; set; }

						[JsonPropertyName("campaign_type")]
						[Description("活动类型：100-店铺满减活动 110-平台满减活动 150-立减活动")]
						public long CampaignType { get; set; }

						[JsonPropertyName("share_discount_cost")]
						[Description("成本分摊")]
						public ShareDiscountCostItem ShareDiscountCost { get; set; }

						public class ShareDiscountCostItem
						{
							[JsonPropertyName("platform_cost")]
							[Description("平台承担金额（单位：分）")]
							public long PlatformCost { get; set; }

							[JsonPropertyName("shop_cost")]
							[Description("商家承担金额（单位：分）")]
							public long ShopCost { get; set; }

							[JsonPropertyName("author_cost")]
							[Description("作者承担金额（单位：分）")]
							public long AuthorCost { get; set; }
						}

						[JsonPropertyName("campaign_name")]
						[Description("活动名称")]
						public string CampaignName { get; set; }

						[JsonPropertyName("campaign_amount")]
						[Description("活动优惠金额（单位：分）")]
						public long CampaignAmount { get; set; }

						[JsonPropertyName("campaign_sub_type")]
						[Description("活动子类型：0-店铺活动，1-平台活动")]
						public long CampaignSubType { get; set; }
					}

					[JsonPropertyName("redpack_amount")]
					[Description("红包金额（单位：分）")]
					public long RedpackAmount { get; set; }

					[JsonPropertyName("redpack_info")]
					[Description("红包信息")]
					public List<RedpackInfoItem> RedpackInfo { get; set; }

					public class RedpackInfoItem
					{
						[JsonPropertyName("redpack_trans_id")]
						[Description("红包汇总ID")]
						public string RedpackTransId { get; set; }

						[JsonPropertyName("redpack_amount")]
						[Description("红包金额（单位：分）")]
						public long RedpackAmount { get; set; }

						[JsonPropertyName("share_discount_cost")]
						[Description("成本分摊")]
						public ShareDiscountCostItem ShareDiscountCost { get; set; }

						public class ShareDiscountCostItem
						{
							[JsonPropertyName("platform_cost")]
							[Description("平台承担金额（单位：分）")]
							public long PlatformCost { get; set; }

							[JsonPropertyName("shop_cost")]
							[Description("作者承担金额（单位：分）")]
							public long ShopCost { get; set; }

							[JsonPropertyName("author_cost")]
							[Description("作者承担金额（单位：分）")]
							public long AuthorCost { get; set; }
						}
					}
				}
			}

			[JsonPropertyName("campaign_info")]
			[Description("活动信息，其中活动金额会体现到商品价格中（比如商品原价是100元，参加活动优惠20元，那商品现价就为80元）")]
			public List<CampaignInfoItem> CampaignInfo { get; set; }

			public class CampaignInfoItem
			{
				[JsonPropertyName("campaign_activity_id")]
				[Description("商家活动ID")]
				public string CampaignActivityId { get; set; }

				[JsonPropertyName("campaign_id")]
				[Description("活动ID")]
				public long CampaignId { get; set; }

				[JsonPropertyName("campaign_type")]
				[Description("活动类型：7-限时特卖 10-定金预售 11-定金预售尾款部分 13-达人专属价 14-限时限量限人 120-拼团")]
				public long CampaignType { get; set; }

				[JsonPropertyName("share_discount_cost")]
				[Description("成本分摊")]
				public ShareDiscountCostItem ShareDiscountCost { get; set; }

				public class ShareDiscountCostItem
				{
					[JsonPropertyName("platform_cost")]
					[Description("平台承担金额（单位：分）")]
					public long PlatformCost { get; set; }

					[JsonPropertyName("shop_cost")]
					[Description("商家承担金额（单位：分）")]
					public long ShopCost { get; set; }

					[JsonPropertyName("author_cost")]
					[Description("作者承担金额（单位：分）")]
					public long AuthorCost { get; set; }
				}

				[JsonPropertyName("campaign_name")]
				[Description("活动名称")]
				public string CampaignName { get; set; }

				[JsonPropertyName("campaign_amount")]
				[Description("活动金额（单位：分）")]
				public long CampaignAmount { get; set; }

				[JsonPropertyName("campaign_sub_type")]
				[Description("活动子类型：0-店铺活动，1-平台活动")]
				public long CampaignSubType { get; set; }
			}

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

			[JsonPropertyName("product_pic")]
			[Description("商品图片")]
			public string ProductPic { get; set; }

			[JsonPropertyName("is_comment")]
			[Description("是否评价 :1-已评价，0-未评价，2 -追评")]
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
			[Description("预售类型 ，0-现货类型，1-全款预售，2-阶梯发货")]
			public long PreSaleType { get; set; }

			[JsonPropertyName("after_sale_info")]
			[Description("售后信息")]
			public AfterSaleInfoItem AfterSaleInfo { get; set; }

			public class AfterSaleInfoItem
			{
				[JsonPropertyName("after_sale_status")]
				[Description("售后状态；6-售后申请；27-拒绝售后申请；12-售后成功；7-售后退货中；11-售后已发货；29-售后退货拒绝；13-【换货返回：换货售后换货商家发货】，【补寄返回：补寄待用户收货】； 14-【换货返回：（换货）售后换货用户收货】，【补寄返回：（补寄）用户已收货】 ；28-售后失败；51-订单取消成功；53-逆向交易已完成；")]
				public long AfterSaleStatus { get; set; }

				[JsonPropertyName("after_sale_type")]
				[Description("售后类型 ；0-退货退款;1-已发货仅退款;2-未发货仅退款;3-换货;4-系统取消;5-用户取消;6-价保;7-补寄;")]
				public long AfterSaleType { get; set; }

				[JsonPropertyName("refund_status")]
				[Description("退款状态:1-待退款；3-退款成功； 4-退款失败；当买家发起售后后又主动取消售后，此时after_sale_status=28并且refund_status=1的状态不变，不会流转至4状态；")]
				public long RefundStatus { get; set; }
			}

			[JsonPropertyName("writeoff_info")]
			[Description("核销信息")]
			public List<WriteoffInfoItem> WriteoffInfo { get; set; }

			public class WriteoffInfoItem
			{
				[JsonPropertyName("writeoff_no")]
				[Description("核销券码")]
				public string WriteoffNo { get; set; }

				[JsonPropertyName("writeoff_start_time")]
				[Description("核销有效开始时间")]
				public long WriteoffStartTime { get; set; }

				[JsonPropertyName("writeoff_expire_time")]
				[Description("核销过期时间")]
				public long WriteoffExpireTime { get; set; }

				[JsonPropertyName("writeoff_status")]
				[Description("核销状态")]
				public long WriteoffStatus { get; set; }

				[JsonPropertyName("writeoff_status_desc")]
				[Description("核销状态文案")]
				public string WriteoffStatusDesc { get; set; }

				[JsonPropertyName("verify_order_id")]
				[Description("核销店铺订单id")]
				public string VerifyOrderId { get; set; }

				[JsonPropertyName("writeoff_no_mask")]
				[Description("脱敏核销券码")]
				public string WriteoffNoMask { get; set; }

				[JsonPropertyName("writtenoff_count")]
				[Description("已核销次数")]
				public long WrittenoffCount { get; set; }

				[JsonPropertyName("writeoff_total_count")]
				[Description("总核销次数")]
				public long WriteoffTotalCount { get; set; }
			}

			[JsonPropertyName("relation_order")]
			[Description("关联订单")]
			public RelationOrderItem RelationOrder { get; set; }

			public class RelationOrderItem
			{
				[JsonPropertyName("write_off_no")]
				[Description("核销券码")]
				public string WriteOffNo { get; set; }

				[JsonPropertyName("relation_order_id")]
				[Description("关联店铺单订单id")]
				public string RelationOrderId { get; set; }
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
			[Description("1-邮寄，2-自提")]
			public long ReceiveType { get; set; }

			[JsonPropertyName("need_serial_number")]
			[Description("是否需要上传序列号，用于判断发货时是否需要上传商品序列号（IMEI码或SN码），true 表示是3C数码商品，需要上传序列号")]
			public bool NeedSerialNumber { get; set; }

			[JsonPropertyName("ad_env_type")]
			[Description("广告来源，video-短视频  live-直播")]
			public string AdEnvType { get; set; }

			[JsonPropertyName("product_id_str")]
			[Description("商品ID，字符串类型")]
			public string ProductIdStr { get; set; }

			[JsonPropertyName("appointment_ship_time")]
			[Description("预约发货时间")]
			public long AppointmentShipTime { get; set; }

			[JsonPropertyName("room_id_str")]
			[Description("直播房间ID，字符串类型")]
			public string RoomIdStr { get; set; }

			[JsonPropertyName("given_product_type")]
			[Description("绑定类型  MASTER-主品单  FREE-免费赠品")]
			public string GivenProductType { get; set; }

			[JsonPropertyName("master_sku_order_id")]
			[Description("废弃，使用master_sku_order_id_list；绑定的主品sku单单号 如果given_product_type=FREE 则master_sku_order_id为主品sku单单号")]
			public string MasterSkuOrderId { get; set; }

			[JsonPropertyName("card_voucher")]
			[Description("商品卡券基本信息")]
			public CardVoucherItem CardVoucher { get; set; }

			public class CardVoucherItem
			{
				[JsonPropertyName("valid_days")]
				[Description("自领取之日起有效天数(如果存在优先使用)")]
				public long ValidDays { get; set; }

				[JsonPropertyName("valid_start")]
				[Description("卡券开始时间")]
				public long ValidStart { get; set; }

				[JsonPropertyName("valid_end")]
				[Description("卡券截止时间")]
				public long ValidEnd { get; set; }
			}

			[JsonPropertyName("bundle_sku_info")]
			[Description("组套商品子商品列表")]
			public List<BundleSkuInfoItem> BundleSkuInfo { get; set; }

			public class BundleSkuInfoItem
			{
				[JsonPropertyName("picture_url")]
				[Description("子商品图片")]
				public string PictureUrl { get; set; }

				[JsonPropertyName("product_id")]
				[Description("子商品在抖店的ID")]
				public string ProductId { get; set; }

				[JsonPropertyName("product_name")]
				[Description("子商品名称")]
				public string ProductName { get; set; }

				[JsonPropertyName("sku_id")]
				[Description("子商品在抖店的SkuId")]
				public string SkuId { get; set; }

				[JsonPropertyName("item_num")]
				[Description("子商品数量")]
				public long ItemNum { get; set; }

				[JsonPropertyName("code")]
				[Description("组套子商品外部编码")]
				public string Code { get; set; }
			}

			[JsonPropertyName("account_list")]
			[Description("当order_type=2，order_type_desc为虚拟订单时该参数会返回信息")]
			public AccountListItem AccountList { get; set; }

			public class AccountListItem
			{
				[JsonPropertyName("account_info")]
				[Description("买家账号信息")]
				public List<AccountInfoItem> AccountInfo { get; set; }

				public class AccountInfoItem
				{
					[JsonPropertyName("account_name")]
					[Description("买家账号名称")]
					public string AccountName { get; set; }

					[JsonPropertyName("account_type")]
					[Description("买家账号类型;账号类型；枚举值：Mobile-手机号;Email-邮箱 ; IdCard-身份证;  Passport-护照;  BankCard-银行卡;  Number-纯数学;  NumberLetter-数字字母混合;")]
					public string AccountType { get; set; }

					[JsonPropertyName("encrypt_account_id")]
					[Description("账号值")]
					public string EncryptAccountId { get; set; }
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

			[JsonPropertyName("is_activity")]
			[Description("是否是补贴品订单")]
			public bool IsActivity { get; set; }

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
				[Description("详细信息（脱敏后）")]
				public string Detail { get; set; }
			}

			[JsonPropertyName("contract_info")]
			[Description("合约信息")]
			public ContractInfoItem ContractInfo { get; set; }

			public class ContractInfoItem
			{
				[JsonPropertyName("encrypt_mobile_no")]
				[Description("办理合约的手机号")]
				public string EncryptMobileNo { get; set; }
			}

			[JsonPropertyName("master_sku_order_id_list")]
			[Description("绑定的主品sku单单号 如果given_product_type=FREE 则master_sku_order_id_list为主品sku单单号")]
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
				[Description("满几件赠或满几元赠，满元赠场景单位是分")]
				public string GivenProductActivityValue { get; set; }
			}

			[JsonPropertyName("quality_check_info")]
			[Description("质检信息")]
			public QualityCheckInfoItem QualityCheckInfo { get; set; }

			public class QualityCheckInfoItem
			{
				[JsonPropertyName("check_result_code")]
				[Description("质检结果  WATI_CHECT:待质检, CHECK_PASS:质检通过, CHECK_FAIL:质检不通过")]
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
		[Description("插旗信息：0-灰 1-紫 2-青 3-绿 4-橙 5-红")]
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

			[JsonPropertyName("sku_price")]
			[Description("sku单价，单位：分")]
			public long SkuPrice { get; set; }

			[JsonPropertyName("pay_success")]
			[Description("是否支付成功")]
			public bool PaySuccess { get; set; }

			[JsonPropertyName("sku_order_id")]
			[Description("店铺子订单号，抖店平台生成，平台下唯一；注意：一笔订单下有一个子订单和父订单单号相同。")]
			public string SkuOrderId { get; set; }

			[JsonPropertyName("campaign_id")]
			[Description("活动id")]
			public string CampaignId { get; set; }

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
			[Description("阶段单总金额，单位分，为订单金额phase_sum_amount+运费phase_post_amount,为支付金额phase_pay_amount+优惠金额phase_promotion_amoun")]
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
			[JsonPropertyName("encrypt_id_card_no")]
			[Description("证件号")]
			public string EncryptIdCardNo { get; set; }

			[JsonPropertyName("encrypt_id_card_name")]
			[Description("证件姓名")]
			public string EncryptIdCardName { get; set; }
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
			[Description("标签key")]
			public string Key { get; set; }

			[JsonPropertyName("text")]
			[Description("标签名称")]
			public string Text { get; set; }

			[JsonPropertyName("help_doc")]
			[Description("帮助文档")]
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
		[Description("用户特征标签；")]
		public List<UserTagUiItem> UserTagUi { get; set; }

		public class UserTagUiItem
		{
			[JsonPropertyName("key")]
			[Description("标签key；【key: user_profile_buy_frequency = text: 服务优先】；【key: user_profile_buy_frequency = text: 高频购买 】；【key: user_profile_shop_customer_type = text: 店铺新客 】；,【key:user_profile_shop_customer_type = text:店铺老客】；")]
			public string Key { get; set; }

			[JsonPropertyName("text")]
			[Description("标签名称；【key: user_profile_buy_frequency = text: 服务优先】；【key: user_profile_buy_frequency = text: 高频购买 】；【key: user_profile_shop_customer_type = text: 店铺新客 】；,【key:user_profile_shop_customer_type = text:店铺老客】；")]
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
			[Description("详细地址（脱敏后）")]
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
		[Description("预计最晚送达时间，Unix时间戳：秒；当early_arrival=false时使用，仅小时达业务返回；")]
		public long LatestReceiptTime { get; set; }

		[JsonPropertyName("early_arrival")]
		[Description("是否尽快送达，true-是（配合target_arrival_time字段使用），false-否（配合earliest_receipt_time和latest_receipt_time使用），仅小时达业务返回；")]
		public bool EarlyArrival { get; set; }

		[JsonPropertyName("target_arrival_time")]
		[Description("尽快送达的时间点，Unix时间戳：秒；当early_arrival=true时使用，仅小时达业务返回；")]
		public long TargetArrivalTime { get; set; }

		[JsonPropertyName("packing_amount")]
		[Description("打包费，单位：分；")]
		public long PackingAmount { get; set; }

		[JsonPropertyName("supermarket_order_serial_no")]
		[Description("门店流水号，日内按下单时间从“1”递增生成，仅小时达业务返回；（注：商家自定义小票需加上日期信息，格式为“日期-流水号”，例如“18-1”，便于骑手取货）")]
		public string SupermarketOrderSerialNo { get; set; }

		[JsonPropertyName("tax_amount")]
		[Description("税费(子单税费之和)")]
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
			[Description("双地址标签")]
			public string Text { get; set; }

			[JsonPropertyName("hover_text")]
			[Description("双地址标签hover提示")]
			public string HoverText { get; set; }
		}

		[JsonPropertyName("mask_pay_tel")]
		[Description("脱敏下单人手机号（鲜花订单）")]
		public string MaskPayTel { get; set; }

		[JsonPropertyName("encrypt_pay_tel")]
		[Description("下单人手机号（鲜花订单）")]
		public string EncryptPayTel { get; set; }

		[JsonPropertyName("greet_words")]
		[Description("贺卡文字(鲜花订单)")]
		public string GreetWords { get; set; }

		[JsonPropertyName("open_address_id")]
		[Description("标识收件人地址的id，可用于合单")]
		public string OpenAddressId { get; set; }
	}
}
