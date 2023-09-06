namespace ecommerce.sdk.douyin;

[Description("商品推广 普通计划查询")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","-")]
public class BuyinSimplePlanListReq : IDouyinReq<BuyinSimplePlanListRsp>
{

	public string GetMethod() { return "buyin.simplePlanList"; }

	public string GetUrl() { return "/buyin/simplePlanList"; }

	[JsonPropertyName("status")]
	[Description("推广状态: 0-全部，1-开启，2-商家关闭，3-下架关闭，4-平台清退，5-运营封禁")]
	public long? Status { get; set; }

	[JsonPropertyName("page")]
	[Description("分页")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页商品数，最大50，默认20")]
	public long? PageSize { get; set; }

	[JsonPropertyName("product_info")]
	[Description("商品名称或者ID")]
	public string ProductInfo { get; set; }
}

[Description("商品推广 普通计划查询")]
public class BuyinSimplePlanListRsp
{
	[JsonPropertyName("total")]
	[Description("推广总条数")]
	public long Total { get; set; }

	[JsonPropertyName("promotions")]
	[Description("ShopPromotion")]
	public List<PromotionsItem> Promotions { get; set; }

	public class PromotionsItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("promotion_id")]
		[Description("推广ID")]
		public long PromotionId { get; set; }

		[JsonPropertyName("status")]
		[Description("推广状态")]
		public long Status { get; set; }

		[JsonPropertyName("title")]
		[Description("商品名称")]
		public string Title { get; set; }

		[JsonPropertyName("price")]
		[Description("商品价格")]
		public long Price { get; set; }

		[JsonPropertyName("cos_ratio")]
		[Description("佣金率*100")]
		public long CosRatio { get; set; }

		[JsonPropertyName("cover")]
		[Description("商品主图")]
		public string Cover { get; set; }

		[JsonPropertyName("return_ratio")]
		[Description("品退率 * 10000，-10000表示没有相关值")]
		public long ReturnRatio { get; set; }

		[JsonPropertyName("complaint_ratio")]
		[Description("客诉率 * 10000,  -10000表示没有相关值")]
		public long ComplaintRatio { get; set; }
	}
}
