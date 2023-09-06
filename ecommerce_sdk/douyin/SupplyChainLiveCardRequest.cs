namespace ecommerce.sdk.douyin;

[Description("首页直播组件")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","网络错误，请稍后重试","isp.service-error:300","网络错误，请稍后重试")]
public class SupplyChainLiveCardRequestReq : IDouyinReq<SupplyChainLiveCardRequestRsp>
{

	public string GetMethod() { return "supplyChain.LiveCardRequest"; }

	public string GetUrl() { return "/supplyChain/LiveCardRequest"; }

	[JsonPropertyName("product_id")]
	[Description("商品id")]
	public string ProductId { get; set; }

	[JsonPropertyName("store_source")]
	[Description("来源")]
	public StoreSourceItem StoreSource { get; set; }

	public class StoreSourceItem
	{
		[JsonPropertyName("store_source_page")]
		[Description("来源page")]
		public string StoreSourcePage { get; set; }

		[JsonPropertyName("store_group_type")]
		[Description("来源tyoe")]
		public string StoreGroupType { get; set; }

		[JsonPropertyName("store_source_method")]
		[Description("来源method")]
		public string StoreSourceMethod { get; set; }
	}

	[JsonPropertyName("room_id")]
	[Description("直播间")]
	public string RoomId { get; set; }
}

[Description("首页直播组件")]
public class SupplyChainLiveCardRequestRsp
{
	[JsonPropertyName("goods_cards")]
	[Description("商品卡片")]
	public List<GoodsCardsItem> GoodsCards { get; set; }

	public class GoodsCardsItem
	{
		[JsonPropertyName("is_activity_price")]
		[Description("是否是惠后价")]
		public bool IsActivityPrice { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品id")]
		public string ProductId { get; set; }

		[JsonPropertyName("promotion_id")]
		[Description("渠道id")]
		public string PromotionId { get; set; }

		[JsonPropertyName("img_url")]
		[Description("商品url")]
		public string ImgUrl { get; set; }

		[JsonPropertyName("sell_num")]
		[Description("销量")]
		public long SellNum { get; set; }

		[JsonPropertyName("show_price")]
		[Description("价格")]
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
		[Description("标签")]
		public List<string> Tags { get; set; }

		[JsonPropertyName("detail_url")]
		[Description("无埋点的商详链接")]
		public string DetailUrl { get; set; }
	}

	[JsonPropertyName("is_show")]
	[Description("是否展示该模块")]
	public bool IsShow { get; set; }

	[JsonPropertyName("author_avatar_url")]
	[Description("达人头像")]
	public string AuthorAvatarUrl { get; set; }
}
