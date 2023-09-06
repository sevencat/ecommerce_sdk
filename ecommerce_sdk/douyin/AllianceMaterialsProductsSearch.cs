namespace ecommerce.sdk.douyin;

[Description("本接口用于检索小店联盟商品。可根据筛选条件过滤出满足条件的商品，也可根据排序条件对检索出来的商品进行排序。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败: 无效搜索类型","isv.parameter-invalid:4098","请重试")]
[DouyinRetCode(40004,"非法的参数","参数校验失败: 无效分页大小","isv.parameter-invalid:4097","请重试")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","请重试")]
public class AllianceMaterialsProductsSearchReq : IDouyinReq<AllianceMaterialsProductsSearchRsp>
{

	public string GetMethod() { return "alliance.materialsProductsSearch"; }

	public string GetUrl() { return "/alliance/materialsProductsSearch"; }

	[JsonPropertyName("title")]
	[Description("商品标题，返回标题中包含某个关键词的商品")]
	public string Title { get; set; }

	[JsonPropertyName("first_cids")]
	[Description("筛选商品一级类目")]
	public List<long> FirstCids { get; set; }

	[JsonPropertyName("second_cids")]
	[Description("筛选商品二级类目")]
	public List<long> SecondCids { get; set; }

	[JsonPropertyName("third_cids")]
	[Description("筛选商品三级类目")]
	public List<long> ThirdCids { get; set; }

	[JsonPropertyName("price_min")]
	[Description("筛选价格区间-最小值（单位为分）")]
	public int? PriceMin { get; set; }

	[JsonPropertyName("price_max")]
	[Description("筛选价格区间-最大值（单位为分）")]
	public int? PriceMax { get; set; }

	[JsonPropertyName("sell_num_min")]
	[Description("筛选历史销量区间-最小值")]
	public int? SellNumMin { get; set; }

	[JsonPropertyName("sell_num_max")]
	[Description("筛选历史销量区间-最大值")]
	public int? SellNumMax { get; set; }

	[JsonPropertyName("search_type")]
	[Description("召回结果排序条件，0默认排序1历史销量排序2价格排序3佣金金额排序4佣金比例排序；")]
	[NotNull]
	public int? SearchType { get; set; }

	[JsonPropertyName("sort_type")]
	[Description("排序顺序（0升序1降序）")]
	[NotNull]
	public int? SortType { get; set; }

	[JsonPropertyName("cos_fee_min")]
	[Description("筛选普通佣金区间-最小值（单位为分）")]
	public int? CosFeeMin { get; set; }

	[JsonPropertyName("cos_fee_max")]
	[Description("筛选普通佣金区间-最大值（单位为分）")]
	public int? CosFeeMax { get; set; }

	[JsonPropertyName("cos_ratio_min")]
	[Description("筛选普通佣金率区间-最小值 （乘100，例如1.1%为110）")]
	public int? CosRatioMin { get; set; }

	[JsonPropertyName("cos_ratio_max")]
	[Description("筛选普通佣金率区间-最大值（乘100，例如1.1%为110）")]
	public int? CosRatioMax { get; set; }

	[JsonPropertyName("page")]
	[Description("分页（从1开始）")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页的数量（小于等于20）")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("share_status")]
	[Description("获取商品分销状态。1: 仅返回可分销商品；0:返回全量商品")]
	public int? ShareStatus { get; set; }

	[JsonPropertyName("activity_id")]
	[Description("【废弃】推荐使用tag字段。")]
	public long? ActivityId { get; set; }

	[JsonPropertyName("tag")]
	[Description("商品标签。 0:返回全量商品; 1:返回超值购商品; 2:返回抖音超市(次日达)商品")]
	public long? Tag { get; set; }
}

[Description("本接口用于检索小店联盟商品。可根据筛选条件过滤出满足条件的商品，也可根据排序条件对检索出来的商品进行排序。")]
public class AllianceMaterialsProductsSearchRsp
{
	[JsonPropertyName("total")]
	[Description("商品总数")]
	public long Total { get; set; }

	[JsonPropertyName("products")]
	[Description("商品列表")]
	public List<ProductsItem> Products { get; set; }

	public class ProductsItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品id")]
		public long ProductId { get; set; }

		[JsonPropertyName("title")]
		[Description("商品标题")]
		public string Title { get; set; }

		[JsonPropertyName("price")]
		[Description("商品售价（单位为分）")]
		public long Price { get; set; }

		[JsonPropertyName("cos_ratio")]
		[Description("普通佣金比例（乘100，例如10%为10）")]
		public decimal CosRatio { get; set; }

		[JsonPropertyName("cos_fee")]
		[Description("普通佣金金额（单位为分）")]
		public long CosFee { get; set; }

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
		[Description("历史总销量")]
		public long Sales { get; set; }

		[JsonPropertyName("cover")]
		[Description("商品主图")]
		public string Cover { get; set; }

		[JsonPropertyName("detail_url")]
		[Description("商品链接（普通计划链接）")]
		public string DetailUrl { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺ID")]
		public long ShopId { get; set; }

		[JsonPropertyName("shop_name")]
		[Description("店铺名称")]
		public string ShopName { get; set; }

		[JsonPropertyName("coupon_price")]
		[Description("券后价（单位：分）")]
		public long CouponPrice { get; set; }

		[JsonPropertyName("sharable")]
		[Description("是否可分销")]
		public bool Sharable { get; set; }

		[JsonPropertyName("activity_id")]
		[Description("商品参与活动id。0:未参加活动；1: 超值购")]
		public long ActivityId { get; set; }

		[JsonPropertyName("presell_type")]
		[Description("预售类型。0:非预售，1;全款预售，2:阶梯库存")]
		public long PresellType { get; set; }

		[JsonPropertyName("available_coupons")]
		[Description("优惠券列表")]
		public List<AvailableCouponsItem> AvailableCoupons { get; set; }

		public class AvailableCouponsItem
		{
			[JsonPropertyName("coupon_type")]
			[Description("优惠券类型：1 平台券 2 店铺券 3 主播券")]
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
	}
}
