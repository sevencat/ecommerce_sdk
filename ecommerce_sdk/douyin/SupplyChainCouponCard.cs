namespace ecommerce.sdk.douyin;

[Description("跨境自营店铺首页优惠券卡片")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","网络错误，请稍后重试","isp.service-error:300","网络错误，请稍后重试")]
public class SupplyChainCouponCardReq : IDouyinReq<SupplyChainCouponCardRsp>
{

	public string GetMethod() { return "supplyChain.CouponCard"; }

	public string GetUrl() { return "/supplyChain/CouponCard"; }

	[JsonPropertyName("crowds")]
	[Description("人群包列表")]
	[NotNull]
	public List<CrowdsItem> Crowds { get; set; }

	public class CrowdsItem
	{
		[JsonPropertyName("crowd_id")]
		[Description("人群包id")]
		[NotNull]
		public string CrowdId { get; set; }

		[JsonPropertyName("coupon_meta_ids")]
		[Description("优惠券id列表")]
		[NotNull]
		public List<string> CouponMetaIds { get; set; }

		[JsonPropertyName("content_pool_id")]
		[Description("内容场商品包")]
		[NotNull]
		public string ContentPoolId { get; set; }

		[JsonPropertyName("shopping_mall_pool_id")]
		[Description("泛商城商品包")]
		[NotNull]
		public string ShoppingMallPoolId { get; set; }
	}

	[JsonPropertyName("scene")]
	[Description("场景，根据时新客还是老客，调用不同的Feed策略。1-新客 2-老客")]
	[NotNull]
	public int? Scene { get; set; }

	[JsonPropertyName("store_source")]
	[Description("流量来源")]
	public StoreSourceItem StoreSource { get; set; }

	public class StoreSourceItem
	{
		[JsonPropertyName("store_source_page")]
		[Description("二级page")]
		public string StoreSourcePage { get; set; }

		[JsonPropertyName("store_group_type")]
		[Description("二级tyoe")]
		public string StoreGroupType { get; set; }

		[JsonPropertyName("store_source_method")]
		[Description("二级method")]
		public string StoreSourceMethod { get; set; }
	}
}

[Description("跨境自营店铺首页优惠券卡片")]
public class SupplyChainCouponCardRsp
{
	[JsonPropertyName("coupon_infos")]
	[Description("优惠券信息列表")]
	public List<CouponInfosItem> CouponInfos { get; set; }

	public class CouponInfosItem
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
		[Description("状态：0：未知 1：新建；2：生效；3：已过期；4：禁用；5：已删除")]
		public int Status { get; set; }

		[JsonPropertyName("apply_token")]
		[Description("领券要用的token")]
		public string ApplyToken { get; set; }

		[JsonPropertyName("coupon_apply_status")]
		[Description("券领取按钮状态 - 0-不可领/1-可领取/2-已领取/4-已过使用期限")]
		public int CouponApplyStatus { get; set; }
	}

	[JsonPropertyName("goods_cards")]
	[Description("商品卡片列表（不分页）")]
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

	[JsonPropertyName("is_show")]
	[Description("是否展示该模块")]
	public bool IsShow { get; set; }

	[JsonPropertyName("traffic_type")]
	[Description("流量类型 1-泛商城 2-内容")]
	public int TrafficType { get; set; }
}
