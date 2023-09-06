namespace ecommerce.sdk.douyin;

[Description("二级承接页商品卡片分页")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","网络错误，请稍后重试","isp.service-error:300","网络错误，请稍后重试")]
public class SupplyChainCouponZoneFeedsPageReq : IDouyinReq<SupplyChainCouponZoneFeedsPageRsp>
{

	public string GetMethod() { return "supplyChain.CouponZoneFeedsPage"; }

	public string GetUrl() { return "/supplyChain/CouponZoneFeedsPage"; }

	[JsonPropertyName("coupon_meta_id")]
	[Description("优惠券id")]
	[NotNull]
	public string CouponMetaId { get; set; }

	[JsonPropertyName("cursor")]
	[Description("游标")]
	[NotNull]
	public long? Cursor { get; set; }

	[JsonPropertyName("tab_code")]
	[Description("tab编码")]
	[NotNull]
	public int? TabCode { get; set; }

	[JsonPropertyName("enter_time")]
	[Description("进入页面的时间，单位：秒")]
	[NotNull]
	public string EnterTime { get; set; }
}

[Description("二级承接页商品卡片分页")]
public class SupplyChainCouponZoneFeedsPageRsp
{
	[JsonPropertyName("goods_feed")]
	[Description("商品feed")]
	public GoodsFeedItem GoodsFeed { get; set; }

	public class GoodsFeedItem
	{
		[JsonPropertyName("goods_cards")]
		[Description("商品卡片")]
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
			[Description("商品id")]
			public string ProductId { get; set; }

			[JsonPropertyName("promotion_id")]
			[Description("推广id")]
			public string PromotionId { get; set; }

			[JsonPropertyName("img_url")]
			[Description("图片url")]
			public string ImgUrl { get; set; }

			[JsonPropertyName("sell_num")]
			[Description("销量")]
			public long SellNum { get; set; }

			[JsonPropertyName("show_price")]
			[Description("惠后价/原价")]
			public long ShowPrice { get; set; }

			[JsonPropertyName("title")]
			[Description("标题")]
			public string Title { get; set; }

			[JsonPropertyName("show_new_user_tag")]
			[Description("是否展示新人首单tag （新客组件）")]
			public bool ShowNewUserTag { get; set; }

			[JsonPropertyName("show_hot_sell_tag")]
			[Description("是否展示热卖标 （老客组件）")]
			public bool ShowHotSellTag { get; set; }

			[JsonPropertyName("is_live_product")]
			[Description("是否是刚看的直播商品 （直播间商品组件）")]
			public bool IsLiveProduct { get; set; }

			[JsonPropertyName("tags")]
			[Description("商品标（目前只有假一赔十）")]
			public List<string> Tags { get; set; }

			[JsonPropertyName("detail_url")]
			[Description("无埋点的商详链接")]
			public string DetailUrl { get; set; }
		}

		[JsonPropertyName("cursor")]
		[Description("当前游标")]
		public long Cursor { get; set; }

		[JsonPropertyName("feed_end")]
		[Description("feed是否已结束")]
		public bool FeedEnd { get; set; }
	}
}
