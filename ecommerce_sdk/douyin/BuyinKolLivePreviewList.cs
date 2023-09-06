namespace ecommerce.sdk.douyin;

[Description("达人获取自己的直播预告及商品信息列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败: 无效分页大小","isv.parameter-invalid:4127","参数校验失败: 无效分页大小")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效百应ID","isv.parameter-invalid:4098","无效百应ID")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，下游服务调用错误","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","达人没有直播预告功能权限","isv.parameter-invalid:4109","请开通直播预告权限")]
[DouyinRetCode(50002,"业务处理失败","当前达人未开通分销自营业务权限","isv.business-failed:4110","当前达人未开通分销自营业务权限")]
public class BuyinKolLivePreviewListReq : IDouyinReq<BuyinKolLivePreviewListRsp>
{

	public string GetMethod() { return "buyin.kolLivePreviewList"; }

	public string GetUrl() { return "/buyin/kolLivePreviewList"; }

	[JsonPropertyName("need_product_info")]
	[Description("是否需要预告对应的商品信息。需要商品信息会增加接口耗时，默认false")]
	public bool? NeedProductInfo { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，从1开始")]
	public int? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页直播预告数量。默认20，最大100")]
	public int? PageSize { get; set; }
}

[Description("达人获取自己的直播预告及商品信息列表")]
public class BuyinKolLivePreviewListRsp
{
	[JsonPropertyName("total")]
	[Description("预告总数")]
	public long Total { get; set; }

	[JsonPropertyName("previews")]
	[Description("直播预告及商品信息列表")]
	public List<PreviewsItem> Previews { get; set; }

	public class PreviewsItem
	{
		[JsonPropertyName("preview_id")]
		[Description("预告ID")]
		public long PreviewId { get; set; }

		[JsonPropertyName("booking_num")]
		[Description("预约预告人数")]
		public int BookingNum { get; set; }

		[JsonPropertyName("start_time")]
		[Description("直播开始时间")]
		public long StartTime { get; set; }

		[JsonPropertyName("product_count")]
		[Description("商品数量")]
		public long ProductCount { get; set; }

		[JsonPropertyName("products")]
		[Description("商品详情列表")]
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
			[Description("商品售价（原价，单位为分）")]
			public long Price { get; set; }

			[JsonPropertyName("first_cid")]
			[Description("商品一级类目")]
			public long FirstCid { get; set; }

			[JsonPropertyName("first_cname")]
			[Description("一级类目名称")]
			public string FirstCname { get; set; }

			[JsonPropertyName("second_cid")]
			[Description("商品二级类目")]
			public long SecondCid { get; set; }

			[JsonPropertyName("second_cname")]
			[Description("二级类目名称")]
			public string SecondCname { get; set; }

			[JsonPropertyName("third_cid")]
			[Description("商品三级类目")]
			public long ThirdCid { get; set; }

			[JsonPropertyName("third_cname")]
			[Description("三级类目名称")]
			public string ThirdCname { get; set; }

			[JsonPropertyName("category_id")]
			[Description("行业类目")]
			public long CategoryId { get; set; }

			[JsonPropertyName("ads_promotion_ratio")]
			[Description("渠道推广费率")]
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

			[JsonPropertyName("cover")]
			[Description("商品主图")]
			public string Cover { get; set; }

			[JsonPropertyName("preview_price")]
			[Description("商品预告开播价，单位分")]
			public long PreviewPrice { get; set; }

			[JsonPropertyName("product_desc")]
			[Description("商品卖点")]
			public string ProductDesc { get; set; }
		}
	}
}
