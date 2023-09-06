namespace ecommerce.sdk.douyin;

[Description("1、基于商品图片进行类目预测，可以用于商品发布辅助,2、基于商品内容，包括商品类目、属性等，推荐出商品合理的类目，可用于类目信息错填判断。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2010001","重试")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:2010004","检查参数")]
[DouyinRetCode(50002,"业务处理失败","2010013:获取账号信息失败","isv.business-failed:2010013","获取账号信息失败，请稍后重试")]
public class ProductGetRecommendCategoryReq : IDouyinReq<ProductGetRecommendCategoryRsp>
{

	public string GetMethod() { return "product.GetRecommendCategory"; }

	public string GetUrl() { return "/product/GetRecommendCategory"; }

	[JsonPropertyName("scene")]
	[Description("category_infer: 基于标题、图片等推断商品类目；product_info: 表示基于商品内容进行类目错放判断，需要传入商品类目、属性等；smart_publish: 表示图片预测类目，需要传入商品主图；")]
	[NotNull]
	public string Scene { get; set; }

	[JsonPropertyName("pic")]
	[Description("商品主图图片url，scene为smart_publish时必传")]
	public List<PicItem> Pic { get; set; }

	public class PicItem
	{
		[JsonPropertyName("url")]
		[Description("图片链接，必须是素材中心的url")]
		[NotNull]
		public string Url { get; set; }
	}

	[JsonPropertyName("category_leaf_id")]
	[Description("商品类目id，scene为product_info时必传")]
	public long? CategoryLeafId { get; set; }

	[JsonPropertyName("name")]
	[Description("商品标题，scene为category_infer时必填; sense为product_info时选填")]
	public string Name { get; set; }

	[JsonPropertyName("product_format_new")]
	[Description("商品类目属性")]
	public Dictionary<long,ProductFormatNewItem> ProductFormatNew { get; set; }

	public class ProductFormatNewItem
	{
		[JsonPropertyName("value")]
		[Description("属性id")]
		public long? Value { get; set; }

		[JsonPropertyName("name")]
		[Description("属性名称")]
		public string Name { get; set; }
	}

	[JsonPropertyName("standard_brand_id")]
	[Description("品牌id")]
	public long? StandardBrandId { get; set; }
}

[Description("1、基于商品图片进行类目预测，可以用于商品发布辅助,2、基于商品内容，包括商品类目、属性等，推荐出商品合理的类目，可用于类目信息错填判断。")]
public class ProductGetRecommendCategoryRsp
{
	[JsonPropertyName("categoryDetails")]
	[Description("推荐类目结果")]
	public List<CategoryDetailsItem> CategoryDetails { get; set; }

	public class CategoryDetailsItem
	{
		[JsonPropertyName("category_detail")]
		[Description("类目详情")]
		public CategoryDetailItem CategoryDetail { get; set; }

		public class CategoryDetailItem
		{
			[JsonPropertyName("first_cid")]
			[Description("一级类目id")]
			public long FirstCid { get; set; }

			[JsonPropertyName("first_cname")]
			[Description("一级类目名称")]
			public string FirstCname { get; set; }

			[JsonPropertyName("second_cid")]
			[Description("二级类目id")]
			public long SecondCid { get; set; }

			[JsonPropertyName("second_cname")]
			[Description("二级类目名称")]
			public string SecondCname { get; set; }

			[JsonPropertyName("third_cid")]
			[Description("三级类目id")]
			public long ThirdCid { get; set; }

			[JsonPropertyName("third_cname")]
			[Description("三级类目名称")]
			public string ThirdCname { get; set; }

			[JsonPropertyName("fourth_cid")]
			[Description("四级类目id")]
			public long FourthCid { get; set; }

			[JsonPropertyName("fourth_cname")]
			[Description("四级类目名称")]
			public string FourthCname { get; set; }
		}

		[JsonPropertyName("qualification_status")]
		[Description("类目资质状态，0有资质；1资质过期；2无资质")]
		public long QualificationStatus { get; set; }
	}
}
