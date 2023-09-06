namespace ecommerce.sdk.douyin;

[Description("1、本接口用于查询达人视角下单个或批量推广商品的详情；,2、如商品推广不可推广（如下架、清退、封禁等情况下），接口会返回为空；商品状态查询接口：/buyin/materialsProductStatus,3、调用接口前，请先获取精选联盟业务权限：https://bytedance.feishu.cn/docs/doccnTpYgYuMug26RbiD92VB5Xb ；,4、数据请按需获取，获取的数据越少接口性能越高。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","商品数过多","isv.business-failed:4099","参数校验失败: 商品数过多")]
[DouyinRetCode(50002,"业务处理失败","查询用户信息失败，需要正确的授权角色","isv.business-failed:4348","查询用户信息失败，需要正确的授权角色")]
public class BuyinKolProductsDetailReq : IDouyinReq<BuyinKolProductsDetailRsp>
{

	public string GetMethod() { return "buyin.kolProductsDetail"; }

	public string GetUrl() { return "/buyin/kolProductsDetail"; }

	[JsonPropertyName("product_ids")]
	[Description("商品 ID 列表")]
	[NotNull]
	public List<long> ProductIds { get; set; }

	[JsonPropertyName("fields")]
	[Description("需要获取的字段（取products字段下的一级字段，多个用英文逗号隔开，如果不传默认只返回商品基础信息。强烈建议数据按需获取）")]
	public string Fields { get; set; }
}

[Description("1、本接口用于查询达人视角下单个或批量推广商品的详情；,2、如商品推广不可推广（如下架、清退、封禁等情况下），接口会返回为空；商品状态查询接口：/buyin/materialsProductStatus,3、调用接口前，请先获取精选联盟业务权限：https://bytedance.feishu.cn/docs/doccnTpYgYuMug26RbiD92VB5Xb ；,4、数据请按需获取，获取的数据越少接口性能越高。")]
public class BuyinKolProductsDetailRsp
{
	[JsonPropertyName("products")]
	[Description("商品列表")]
	public List<ProductsItem> Products { get; set; }

	public class ProductsItem
	{
		[JsonPropertyName("detail_brief")]
		[Description("装修详情信息")]
		public DetailBriefItem DetailBrief { get; set; }

		public class DetailBriefItem
		{
			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }

			[JsonPropertyName("component_info")]
			[Description("组件列表")]
			public List<ComponentInfoItem> ComponentInfo { get; set; }

			public class ComponentInfoItem
			{
				[JsonPropertyName("image")]
				[Description("图片组件")]
				public ImageItem Image { get; set; }

				public class ImageItem
				{
					[JsonPropertyName("pic_url")]
					[Description("图片URL")]
					public string PicUrl { get; set; }

					[JsonPropertyName("width")]
					[Description("图片宽度")]
					public short Width { get; set; }

					[JsonPropertyName("height")]
					[Description("图片高度")]
					public short Height { get; set; }
				}
			}
		}

		[JsonPropertyName("base_info")]
		[Description("基础信息")]
		public BaseInfoItem BaseInfo { get; set; }

		public class BaseInfoItem
		{
			[JsonPropertyName("product_id")]
			[Description("商品 ID")]
			public long ProductId { get; set; }

			[JsonPropertyName("title")]
			[Description("商品标题")]
			public string Title { get; set; }

			[JsonPropertyName("price")]
			[Description("商品价格（单位：分）")]
			public long Price { get; set; }

			[JsonPropertyName("first_cid")]
			[Description("商品一级类目")]
			public long FirstCid { get; set; }

			[JsonPropertyName("second_cid")]
			[Description("商品二级类目")]
			public long SecondCid { get; set; }

			[JsonPropertyName("third_cid")]
			[Description("商品三级类目")]
			public long ThirdCid { get; set; }

			[JsonPropertyName("in_stock")]
			[Description("是否有库存")]
			public bool InStock { get; set; }

			[JsonPropertyName("sales")]
			[Description("总销量")]
			public long Sales { get; set; }

			[JsonPropertyName("cover")]
			[Description("商品主图")]
			public string Cover { get; set; }

			[JsonPropertyName("imgs")]
			[Description("商品轮播图")]
			public List<string> Imgs { get; set; }

			[JsonPropertyName("detail_url")]
			[Description("商品链接")]
			public string DetailUrl { get; set; }

			[JsonPropertyName("category_name")]
			[Description("行业类目名称")]
			public string CategoryName { get; set; }

			[JsonPropertyName("category_id")]
			[Description("行业类目 ID")]
			public long CategoryId { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("promotion_info")]
		[Description("推广信息")]
		public PromotionInfoItem PromotionInfo { get; set; }

		public class PromotionInfoItem
		{
			[JsonPropertyName("cos_ratio")]
			[Description("普通佣金比例（10%返回10）")]
			public decimal CosRatio { get; set; }

			[JsonPropertyName("cos_fee")]
			[Description("普通佣金金额（单位为分）")]
			public long CosFee { get; set; }

			[JsonPropertyName("kol_cos_ratio")]
			[Description("达人佣金比例/抖客推广费率")]
			public decimal KolCosRatio { get; set; }

			[JsonPropertyName("kol_cos_fee")]
			[Description("达人佣金金额/抖客推广费（单位为分）")]
			public long KolCosFee { get; set; }

			[JsonPropertyName("commission_type")]
			[Description("佣金类型（1-团长普通模式，2-团长竞价模式，3-普通佣金，4-商品定向佣金，5-店铺定向佣金，6-提报活动，7-招募佣金，8-托管团长，9-阶梯佣金）")]
			public int CommissionType { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("comment_info")]
		[Description("评论信息")]
		public CommentInfoItem CommentInfo { get; set; }

		public class CommentInfoItem
		{
			[JsonPropertyName("comment_score")]
			[Description("商品评分（5分制，保留一位）")]
			public decimal CommentScore { get; set; }

			[JsonPropertyName("comment_num")]
			[Description("商品评价数目")]
			public long CommentNum { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("month_sale_data")]
		[Description("月售信息")]
		public MonthSaleDataItem MonthSaleData { get; set; }

		public class MonthSaleDataItem
		{
			[JsonPropertyName("order_num")]
			[Description("近30天商品总销量")]
			public long OrderNum { get; set; }

			[JsonPropertyName("view_num")]
			[Description("近30天商品总浏览量")]
			public long ViewNum { get; set; }

			[JsonPropertyName("kol_num")]
			[Description("近30天推广总达人数")]
			public long KolNum { get; set; }

			[JsonPropertyName("daily_statistics")]
			[Description("近30天推广达人数、浏览量、和订单量明细")]
			public List<DailyStatisticsItem> DailyStatistics { get; set; }

			public class DailyStatisticsItem
			{
				[JsonPropertyName("date")]
				[Description("日期")]
				public string Date { get; set; }

				[JsonPropertyName("order_num")]
				[Description("单日商品销量")]
				public long OrderNum { get; set; }

				[JsonPropertyName("view_num")]
				[Description("单日商品浏览量")]
				public long ViewNum { get; set; }

				[JsonPropertyName("kol_num")]
				[Description("单日推广达人数")]
				public long KolNum { get; set; }
			}

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("share_info")]
		[Description("分销信息")]
		public ShareInfoItem ShareInfo { get; set; }

		public class ShareInfoItem
		{
			[JsonPropertyName("sharable")]
			[Description("是否可分销")]
			public bool Sharable { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("brand_info")]
		[Description("品牌信息")]
		public BrandInfoItem BrandInfo { get; set; }

		public class BrandInfoItem
		{
			[JsonPropertyName("brand_id")]
			[Description("品牌 ID")]
			public long BrandId { get; set; }

			[JsonPropertyName("brand_name_cn")]
			[Description("品牌名称")]
			public string BrandNameCn { get; set; }

			[JsonPropertyName("brand_name_en")]
			[Description("品牌英文名")]
			public string BrandNameEn { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("tags")]
		[Description("商品标签")]
		public TagsItem Tags { get; set; }

		public class TagsItem
		{
			[JsonPropertyName("has_supermarket_tag")]
			[Description("是否抖音超市(次日达)商品")]
			public bool HasSupermarketTag { get; set; }

			[JsonPropertyName("has_subsidy_tag")]
			[Description("是否超值购商品")]
			public bool HasSubsidyTag { get; set; }

			[JsonPropertyName("has_douin_goods_tag")]
			[Description("是否有【抖in好物】标签")]
			public string HasDouinGoodsTag { get; set; }

			[JsonPropertyName("has_shop_brand_tag")]
			[Description("是否有品牌旗舰店标签（[品牌]黑标）")]
			public bool HasShopBrandTag { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("activity_info")]
		[Description("【废弃】推荐使用tags字段")]
		public ActivityInfoItem ActivityInfo { get; set; }

		public class ActivityInfoItem
		{
			[JsonPropertyName("activity_type")]
			[Description("活动类型。0：未参加活动；1：超值购")]
			public long ActivityType { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("coupon_info")]
		[Description("券信息")]
		public CouponInfoItem CouponInfo { get; set; }

		public class CouponInfoItem
		{
			[JsonPropertyName("available_coupons")]
			[Description("优惠券列表")]
			public List<AvailableCouponsItem> AvailableCoupons { get; set; }

			public class AvailableCouponsItem
			{
				[JsonPropertyName("coupon_type")]
				[Description("优惠券类型。1： 平台券 2： 店铺券 3： 主播券")]
				public int CouponType { get; set; }

				[JsonPropertyName("type_desc")]
				[Description("优惠券类型描述：平台券/主播券/店铺券")]
				public string TypeDesc { get; set; }

				[JsonPropertyName("discount_desc")]
				[Description("优惠券内容描述")]
				public string DiscountDesc { get; set; }

				[JsonPropertyName("apply_start_time")]
				[Description("优惠券领取开始时间")]
				public string ApplyStartTime { get; set; }

				[JsonPropertyName("apply_end_time")]
				[Description("优惠券领取结束时间")]
				public string ApplyEndTime { get; set; }

				[JsonPropertyName("validity_type")]
				[Description("优惠券有效期类型：1固定有效期类型，2浮动有效期类型")]
				public long ValidityType { get; set; }

				[JsonPropertyName("use_start_time")]
				[Description("1固定有效期类型，优惠券使用开始时间")]
				public string UseStartTime { get; set; }

				[JsonPropertyName("use_end_time")]
				[Description("1固定有效期类型，优惠券使用结束时间")]
				public string UseEndTime { get; set; }

				[JsonPropertyName("valid_period")]
				[Description("2浮动有效期类型，领取优惠券后有效期，单位s")]
				public long ValidPeriod { get; set; }
			}

			[JsonPropertyName("coupon_price")]
			[Description("券后价（单位：分）")]
			public long CouponPrice { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("presell_info")]
		[Description("预售信息")]
		public PresellInfoItem PresellInfo { get; set; }

		public class PresellInfoItem
		{
			[JsonPropertyName("presell_type")]
			[Description("预售类型。0:非预售，1;全款预售，2:阶梯库存")]
			public long PresellType { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("rights_info")]
		[Description("权益信息")]
		public RightsInfoItem RightsInfo { get; set; }

		public class RightsInfoItem
		{
			[JsonPropertyName("is_assured")]
			[Description("是否提供安心购服务")]
			public bool IsAssured { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("logistics_info")]
		[Description("物流信息")]
		public LogisticsInfoItem LogisticsInfo { get; set; }

		public class LogisticsInfoItem
		{
			[JsonPropertyName("text")]
			[Description("商品物流说明")]
			public string Text { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("qualification_info")]
		[Description("资质信息")]
		public QualificationInfoItem QualificationInfo { get; set; }

		public class QualificationInfoItem
		{
			[JsonPropertyName("has_sxt")]
			[Description("是否具有短视频随心推资质")]
			public bool HasSxt { get; set; }

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}

		[JsonPropertyName("shop_info")]
		[Description("店铺信息")]
		public ShopInfoItem ShopInfo { get; set; }

		public class ShopInfoItem
		{
			[JsonPropertyName("shop_id")]
			[Description("店铺 ID")]
			public long ShopId { get; set; }

			[JsonPropertyName("shop_name")]
			[Description("店铺名称")]
			public string ShopName { get; set; }

			[JsonPropertyName("shop_total_score")]
			[Description("商家得分")]
			public ShopTotalScoreItem ShopTotalScore { get; set; }

			public class ShopTotalScoreItem
			{
				[JsonPropertyName("shop_score")]
				[Description("商家体验分")]
				public ShopScoreItem ShopScore { get; set; }

				public class ShopScoreItem
				{
					[JsonPropertyName("text")]
					[Description("文本")]
					public string Text { get; set; }

					[JsonPropertyName("score")]
					[Description("得分")]
					public string Score { get; set; }

					[JsonPropertyName("level")]
					[Description("等级。1: 高；2: 中；3:低; 4: 差")]
					public short Level { get; set; }
				}

				[JsonPropertyName("product_score")]
				[Description("商品体验分")]
				public ProductScoreItem ProductScore { get; set; }

				public class ProductScoreItem
				{
					[JsonPropertyName("text")]
					[Description("文本")]
					public string Text { get; set; }

					[JsonPropertyName("score")]
					[Description("得分")]
					public string Score { get; set; }

					[JsonPropertyName("level")]
					[Description("等级。1: 高；2: 中；3:低; 4: 差")]
					public short Level { get; set; }
				}

				[JsonPropertyName("logistics_score")]
				[Description("物流体验分")]
				public LogisticsScoreItem LogisticsScore { get; set; }

				public class LogisticsScoreItem
				{
					[JsonPropertyName("text")]
					[Description("文本")]
					public string Text { get; set; }

					[JsonPropertyName("score")]
					[Description("得分")]
					public string Score { get; set; }

					[JsonPropertyName("level")]
					[Description("等级。1: 高；2: 中；3:低; 4: 差")]
					public short Level { get; set; }
				}

				[JsonPropertyName("service_score")]
				[Description("商家服务分")]
				public ServiceScoreItem ServiceScore { get; set; }

				public class ServiceScoreItem
				{
					[JsonPropertyName("text")]
					[Description("文本")]
					public string Text { get; set; }

					[JsonPropertyName("score")]
					[Description("得分")]
					public string Score { get; set; }

					[JsonPropertyName("level")]
					[Description("等级。1: 高；2: 中；3:低; 4: 差")]
					public short Level { get; set; }
				}
			}

			[JsonPropertyName("success")]
			[Description("数据是否可用")]
			public bool Success { get; set; }
		}
	}
}
