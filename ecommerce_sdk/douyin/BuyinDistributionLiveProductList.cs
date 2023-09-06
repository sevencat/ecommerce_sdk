namespace ecommerce.sdk.douyin;

[Description("获取可分销直播间商品列表信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效百应ID","isv.parameter-invalid:4098","无效百应ID")]
[DouyinRetCode(50002,"业务处理失败","达人未开通分销业务","isv.business-failed:4129","达人未开通分销业务")]
[DouyinRetCode(50002,"业务处理失败","达人未开播","isv.business-failed:4130","达人未开播")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","4126:获取用户客户端账户信息失败","isv.business-failed:4126","获取用户客户端账户信息失败")]
public class BuyinDistributionLiveProductListReq : IDouyinReq<BuyinDistributionLiveProductListRsp>
{

	public string GetMethod() { return "buyin.distributionLiveProductList"; }

	public string GetUrl() { return "/buyin/distributionLiveProductList"; }

	[JsonPropertyName("author_buyin_id")]
	[Description("主播的百应ID")]
	[NotNull]
	public string AuthorBuyinId { get; set; }
}

[Description("获取可分销直播间商品列表信息")]
public class BuyinDistributionLiveProductListRsp
{
	[JsonPropertyName("create_time")]
	[Description("直播间创建时间")]
	public long CreateTime { get; set; }

	[JsonPropertyName("online_num")]
	[Description("在线人数")]
	public long OnlineNum { get; set; }

	[JsonPropertyName("is_rest_assured")]
	[Description("是否支持安心购")]
	public bool IsRestAssured { get; set; }

	[JsonPropertyName("has_kol_coupon")]
	[Description("是否有主播券")]
	public bool HasKolCoupon { get; set; }

	[JsonPropertyName("is_flash_live_room")]
	[Description("是否闪购直播间")]
	public bool IsFlashLiveRoom { get; set; }

	[JsonPropertyName("product_count")]
	[Description("商品总数（不含闪购），最多100")]
	public int ProductCount { get; set; }

	[JsonPropertyName("products")]
	[Description("商品列表（不含闪购）")]
	public List<ProductsItem> Products { get; set; }

	public class ProductsItem
	{
		[JsonPropertyName("list_num")]
		[Description("商品在列表序号")]
		public int ListNum { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("title")]
		[Description("商品名称")]
		public string Title { get; set; }

		[JsonPropertyName("price")]
		[Description("商品价格")]
		public long Price { get; set; }

		[JsonPropertyName("first_cid")]
		[Description("一级类目")]
		public long FirstCid { get; set; }

		[JsonPropertyName("first_cname")]
		[Description("一级类目名称")]
		public string FirstCname { get; set; }

		[JsonPropertyName("second_cid")]
		[Description("二级类目")]
		public long SecondCid { get; set; }

		[JsonPropertyName("second_cname")]
		[Description("二级类目名称")]
		public string SecondCname { get; set; }

		[JsonPropertyName("third_cid")]
		[Description("三级类目")]
		public long ThirdCid { get; set; }

		[JsonPropertyName("third_cname")]
		[Description("三级类目名称")]
		public string ThirdCname { get; set; }

		[JsonPropertyName("category_id")]
		[Description("行业类目ID")]
		public long CategoryId { get; set; }

		[JsonPropertyName("live_room_price")]
		[Description("直播间价格")]
		public long LiveRoomPrice { get; set; }

		[JsonPropertyName("is_explaining")]
		[Description("是否在讲解中")]
		public bool IsExplaining { get; set; }

		[JsonPropertyName("available_coupons")]
		[Description("优惠券列表")]
		public List<AvailableCouponsItem> AvailableCoupons { get; set; }

		public class AvailableCouponsItem
		{
			[JsonPropertyName("coupon_type")]
			[Description("优惠券类型：1 平台券；2 店铺券；3 达人券")]
			public int CouponType { get; set; }

			[JsonPropertyName("type_desc")]
			[Description("券类型名称")]
			public string TypeDesc { get; set; }

			[JsonPropertyName("discount_desc")]
			[Description("券描述")]
			public string DiscountDesc { get; set; }
		}

		[JsonPropertyName("ads_promotion_ratio")]
		[Description("渠道推广费率（X10000）")]
		public AdsPromotionRatioItem AdsPromotionRatio { get; set; }

		public class AdsPromotionRatioItem
		{
			[JsonPropertyName("share_ratio")]
			[Description("新客推广费率")]
			public long ShareRatio { get; set; }

			[JsonPropertyName("old_fans_ratio")]
			[Description("老客推广费率")]
			public long OldFansRatio { get; set; }
		}

		[JsonPropertyName("given_products")]
		[Description("赠品信息")]
		public List<GivenProductsItem> GivenProducts { get; set; }

		public class GivenProductsItem
		{
			[JsonPropertyName("product_id")]
			[Description("商品ID")]
			public long ProductId { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("cover")]
			[Description("商品主图")]
			public string Cover { get; set; }

			[JsonPropertyName("given_skus")]
			[Description("SKU列表")]
			public List<GivenSkusItem> GivenSkus { get; set; }

			public class GivenSkusItem
			{
				[JsonPropertyName("product_id")]
				[Description("商品ID")]
				public long ProductId { get; set; }

				[JsonPropertyName("sku_id")]
				[Description("SKU ID")]
				public long SkuId { get; set; }

				[JsonPropertyName("cover")]
				[Description("sku主图")]
				public string Cover { get; set; }
			}
		}

		[JsonPropertyName("cover")]
		[Description("商品主图")]
		public string Cover { get; set; }
	}

	[JsonPropertyName("flash_products_count")]
	[Description("闪购商品总数")]
	public int FlashProductsCount { get; set; }

	[JsonPropertyName("flash_products")]
	[Description("闪购商品列表")]
	public List<FlashProductsItem> FlashProducts { get; set; }

	public class FlashProductsItem
	{
		[JsonPropertyName("list_num")]
		[Description("商品在列表序号")]
		public int ListNum { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("title")]
		[Description("商品名称")]
		public string Title { get; set; }

		[JsonPropertyName("price")]
		[Description("商品价格")]
		public long Price { get; set; }

		[JsonPropertyName("first_cid")]
		[Description("一级类目")]
		public long FirstCid { get; set; }

		[JsonPropertyName("first_cname")]
		[Description("一级类目名称")]
		public string FirstCname { get; set; }

		[JsonPropertyName("second_cid")]
		[Description("二级类目")]
		public long SecondCid { get; set; }

		[JsonPropertyName("second_cname")]
		[Description("二级类目名称")]
		public string SecondCname { get; set; }

		[JsonPropertyName("third_cid")]
		[Description("三级类目")]
		public long ThirdCid { get; set; }

		[JsonPropertyName("third_cname")]
		[Description("三级类目名称")]
		public string ThirdCname { get; set; }

		[JsonPropertyName("category_id")]
		[Description("行业类目ID")]
		public long CategoryId { get; set; }

		[JsonPropertyName("live_room_price")]
		[Description("直播间价格")]
		public long LiveRoomPrice { get; set; }

		[JsonPropertyName("is_explaining")]
		[Description("是否在讲解中")]
		public bool IsExplaining { get; set; }

		[JsonPropertyName("available_coupons")]
		[Description("优惠券列表")]
		public List<AvailableCouponsItem> AvailableCoupons { get; set; }

		public class AvailableCouponsItem
		{
			[JsonPropertyName("coupon_type")]
			[Description("优惠券类型：1 平台券；2 店铺券；3 达人券")]
			public int CouponType { get; set; }

			[JsonPropertyName("type_desc")]
			[Description("券类型名称")]
			public string TypeDesc { get; set; }

			[JsonPropertyName("discount_desc")]
			[Description("券描述")]
			public string DiscountDesc { get; set; }
		}

		[JsonPropertyName("ads_promotion_ratio")]
		[Description("渠道推广费率（X10000）")]
		public AdsPromotionRatioItem AdsPromotionRatio { get; set; }

		public class AdsPromotionRatioItem
		{
			[JsonPropertyName("share_ratio")]
			[Description("新客推广费率")]
			public long ShareRatio { get; set; }

			[JsonPropertyName("old_fans_ratio")]
			[Description("老客推广费率")]
			public long OldFansRatio { get; set; }
		}

		[JsonPropertyName("given_products")]
		[Description("赠品信息")]
		public List<GivenProductsItem> GivenProducts { get; set; }

		public class GivenProductsItem
		{
			[JsonPropertyName("product_id")]
			[Description("商品ID")]
			public long ProductId { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("cover")]
			[Description("商品主图")]
			public string Cover { get; set; }

			[JsonPropertyName("given_skus")]
			[Description("SKU列表")]
			public List<GivenSkusItem> GivenSkus { get; set; }

			public class GivenSkusItem
			{
				[JsonPropertyName("product_id")]
				[Description("商品ID")]
				public long ProductId { get; set; }

				[JsonPropertyName("sku_id")]
				[Description("SKU ID")]
				public long SkuId { get; set; }

				[JsonPropertyName("cover")]
				[Description("商品主图")]
				public string Cover { get; set; }
			}
		}

		[JsonPropertyName("cover")]
		[Description("主图")]
		public string Cover { get; set; }
	}

	[JsonPropertyName("room_id")]
	[Description("直播间ID")]
	public long RoomId { get; set; }

	[JsonPropertyName("author_nickname")]
	[Description("直播达人昵称")]
	public string AuthorNickname { get; set; }

	[JsonPropertyName("author_buyin_id")]
	[Description("直播达人百应ID")]
	public long AuthorBuyinId { get; set; }

	[JsonPropertyName("lottery_products")]
	[Description("福袋商品")]
	public List<LotteryProductsItem> LotteryProducts { get; set; }

	public class LotteryProductsItem
	{
		[JsonPropertyName("product_info")]
		[Description("福袋商品")]
		public ProductInfoItem ProductInfo { get; set; }

		public class ProductInfoItem
		{
			[JsonPropertyName("list_num")]
			[Description("商品序号")]
			public int ListNum { get; set; }

			[JsonPropertyName("product_id")]
			[Description("商品ID")]
			public long ProductId { get; set; }

			[JsonPropertyName("title")]
			[Description("商品名称")]
			public string Title { get; set; }

			[JsonPropertyName("price")]
			[Description("商品价格")]
			public long Price { get; set; }

			[JsonPropertyName("first_cid")]
			[Description("一级类目")]
			public long FirstCid { get; set; }

			[JsonPropertyName("first_cname")]
			[Description("一级类目名称")]
			public string FirstCname { get; set; }

			[JsonPropertyName("second_cid")]
			[Description("二级类目")]
			public long SecondCid { get; set; }

			[JsonPropertyName("second_cname")]
			[Description("二级类目名称")]
			public string SecondCname { get; set; }

			[JsonPropertyName("third_cid")]
			[Description("三级类目")]
			public long ThirdCid { get; set; }

			[JsonPropertyName("third_cname")]
			[Description("三级类目名称")]
			public string ThirdCname { get; set; }

			[JsonPropertyName("category_id")]
			[Description("行业类目ID")]
			public long CategoryId { get; set; }

			[JsonPropertyName("live_room_price")]
			[Description("直播间价格")]
			public long LiveRoomPrice { get; set; }

			[JsonPropertyName("is_explaining")]
			[Description("是否在讲解中")]
			public bool IsExplaining { get; set; }

			[JsonPropertyName("available_coupons")]
			[Description("优惠券")]
			public List<AvailableCouponsItem> AvailableCoupons { get; set; }

			public class AvailableCouponsItem
			{
				[JsonPropertyName("coupon_type")]
				[Description("优惠券类型：1 平台券；2 店铺券；3 达人券")]
				public int CouponType { get; set; }

				[JsonPropertyName("type_desc")]
				[Description("类型")]
				public string TypeDesc { get; set; }

				[JsonPropertyName("discount_desc")]
				[Description("描述")]
				public string DiscountDesc { get; set; }
			}

			[JsonPropertyName("ads_promotion_ratio")]
			[Description("渠道推广费率（X10000）")]
			public AdsPromotionRatioItem AdsPromotionRatio { get; set; }

			public class AdsPromotionRatioItem
			{
				[JsonPropertyName("share_ratio")]
				[Description("新客")]
				public long ShareRatio { get; set; }

				[JsonPropertyName("old_fans_ratio")]
				[Description("老客")]
				public long OldFansRatio { get; set; }
			}

			[JsonPropertyName("given_products")]
			[Description("赠品信息")]
			public List<GivenProductsItem> GivenProducts { get; set; }

			public class GivenProductsItem
			{
				[JsonPropertyName("product_id")]
				[Description("赠品商品ID")]
				public long ProductId { get; set; }

				[JsonPropertyName("product_name")]
				[Description("赠品商品名称")]
				public string ProductName { get; set; }

				[JsonPropertyName("cover")]
				[Description("赠品主图")]
				public string Cover { get; set; }

				[JsonPropertyName("given_skus")]
				[Description("SKU")]
				public List<GivenSkusItem> GivenSkus { get; set; }

				public class GivenSkusItem
				{
					[JsonPropertyName("product_id")]
					[Description("商品ID")]
					public long ProductId { get; set; }

					[JsonPropertyName("sku_id")]
					[Description("SKU ID")]
					public long SkuId { get; set; }

					[JsonPropertyName("cover")]
					[Description("SKU主图")]
					public string Cover { get; set; }
				}
			}

			[JsonPropertyName("cover")]
			[Description("商品主图")]
			public string Cover { get; set; }
		}

		[JsonPropertyName("lottery_activity_id")]
		[Description("福袋ID")]
		public long LotteryActivityId { get; set; }

		[JsonPropertyName("lottery_product_start_time")]
		[Description("福袋活动开始时间")]
		public long LotteryProductStartTime { get; set; }

		[JsonPropertyName("lottery_product_end_time")]
		[Description("福袋活动结束时间/开奖时间")]
		public long LotteryProductEndTime { get; set; }
	}
}
