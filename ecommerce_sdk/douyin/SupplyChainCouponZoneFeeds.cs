namespace ecommerce.sdk.douyin;

[Description("二级承接页初始化")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","网络错误，请稍后重试","isp.service-error:300","网络错误，请稍后重试")]
public class SupplyChainCouponZoneFeedsReq : IDouyinReq<SupplyChainCouponZoneFeedsRsp>
{

	public string GetMethod() { return "supplyChain.CouponZoneFeeds"; }

	public string GetUrl() { return "/supplyChain/CouponZoneFeeds"; }

	[JsonPropertyName("coupon_meta_id")]
	[Description("优惠券id")]
	[NotNull]
	public string CouponMetaId { get; set; }

	[JsonPropertyName("scene")]
	[Description("场景，根据时新客还是老客，调用不同的Feed策略。1-新客 2-老客")]
	[NotNull]
	public int? Scene { get; set; }

	[JsonPropertyName("enter_time")]
	[Description("进入页面的时间，单位：秒")]
	[NotNull]
	public string EnterTime { get; set; }
}

[Description("二级承接页初始化")]
public class SupplyChainCouponZoneFeedsRsp
{
	[JsonPropertyName("tab_list")]
	[Description("tab列表")]
	public List<TabListItem> TabList { get; set; }

	public class TabListItem
	{
		[JsonPropertyName("tab_code")]
		[Description("tab编码")]
		public int TabCode { get; set; }

		[JsonPropertyName("tab_name")]
		[Description("tab名称")]
		public string TabName { get; set; }

		[JsonPropertyName("is_tab_name_show")]
		[Description("是否显示tab")]
		public bool IsTabNameShow { get; set; }

		[JsonPropertyName("goods_feed")]
		[Description("商品卡片feed流")]
		public GoodsFeedItem GoodsFeed { get; set; }

		public class GoodsFeedItem
		{
			[JsonPropertyName("goods_cards")]
			[Description("商品卡片列表")]
			public List<GoodsCardsItem> GoodsCards { get; set; }

			public class GoodsCardsItem
			{
				[JsonPropertyName("is_activity_price")]
				[Description("是否是惠后价")]
				public bool IsActivityPrice { get; set; }

				[JsonPropertyName("promotion_source")]
				[Description("商品来源")]
				public long PromotionSource { get; set; }

				[JsonPropertyName("product_id")]
				[Description("商品ID")]
				public string ProductId { get; set; }

				[JsonPropertyName("promotion_id")]
				[Description("商品promotionId")]
				public string PromotionId { get; set; }

				[JsonPropertyName("img_url")]
				[Description("商品展示图片地址")]
				public string ImgUrl { get; set; }

				[JsonPropertyName("sell_num")]
				[Description("销量")]
				public long SellNum { get; set; }

				[JsonPropertyName("show_price")]
				[Description("展示价格")]
				public long ShowPrice { get; set; }

				[JsonPropertyName("title")]
				[Description("标题")]
				public string Title { get; set; }

				[JsonPropertyName("show_new_user_tag")]
				[Description("是否展示新用户专享tag（新客卡片场景）")]
				public bool ShowNewUserTag { get; set; }

				[JsonPropertyName("show_hot_sell_tag")]
				[Description("是否展示热卖tag")]
				public bool ShowHotSellTag { get; set; }

				[JsonPropertyName("is_live_product")]
				[Description("是否是当前直播中商品（直播卡片场景）")]
				public bool IsLiveProduct { get; set; }

				[JsonPropertyName("tags")]
				[Description("商品标")]
				public List<string> Tags { get; set; }

				[JsonPropertyName("detail_url")]
				[Description("商详跳转URL")]
				public string DetailUrl { get; set; }
			}

			[JsonPropertyName("cursor")]
			[Description("feeds游标")]
			public long Cursor { get; set; }

			[JsonPropertyName("feed_end")]
			[Description("是否已到底")]
			public bool FeedEnd { get; set; }
		}
	}

	[JsonPropertyName("coupon_info")]
	[Description("优惠券信息")]
	public CouponInfoItem CouponInfo { get; set; }

	public class CouponInfoItem
	{
		[JsonPropertyName("coupon_meta_id")]
		[Description("优惠券id")]
		public string CouponMetaId { get; set; }

		[JsonPropertyName("start_time")]
		[Description("券开始生效时间")]
		public long StartTime { get; set; }

		[JsonPropertyName("expire_time")]
		[Description("券过期时间")]
		public long ExpireTime { get; set; }

		[JsonPropertyName("credit")]
		[Description("金额（by分）")]
		public long Credit { get; set; }

		[JsonPropertyName("threshold")]
		[Description("门槛（by分）")]
		public long Threshold { get; set; }

		[JsonPropertyName("status")]
		[Description("优惠券批次状态：0：未知 1：新建；2：生效；3：已过期；4：禁用；5：已删除")]
		public int Status { get; set; }

		[JsonPropertyName("apply_token")]
		[Description("领券要用的token")]
		public string ApplyToken { get; set; }

		[JsonPropertyName("coupon_apply_status")]
		[Description("券领取按钮状态 - 0-不可领/1-可领取/2-已领取/4-已过使用期限")]
		public int CouponApplyStatus { get; set; }
	}
}
