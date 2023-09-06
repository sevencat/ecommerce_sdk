namespace ecommerce.sdk.douyin;

[Description("获取供销产品列表")]
public class SupplyChainSupplyProductGetSupplyProductListReq : IDouyinReq<SupplyChainSupplyProductGetSupplyProductListRsp>
{

	public string GetMethod() { return "supplyChain.supplyProduct.getSupplyProductList"; }

	public string GetUrl() { return "/supplyChain/supplyProduct/getSupplyProductList"; }

	[JsonPropertyName("status")]
	[Description("主状态值")]
	public int? Status { get; set; }

	[JsonPropertyName("sub_status")]
	[Description("子状态值")]
	public int? SubStatus { get; set; }

	[JsonPropertyName("create_start_time")]
	[Description("创建开始时间")]
	public long? CreateStartTime { get; set; }

	[JsonPropertyName("create_end_time")]
	[Description("创建结束时间")]
	public long? CreateEndTime { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，第一页从1开始")]
	public int? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页大小， 不传或超过50会默认设置为50")]
	public int? Size { get; set; }

	[JsonPropertyName("update_start_time")]
	[Description("更新开始时间")]
	public long? UpdateStartTime { get; set; }

	[JsonPropertyName("update_end_time")]
	[Description("更新结束时间")]
	public long? UpdateEndTime { get; set; }
}

[Description("获取供销产品列表")]
public class SupplyChainSupplyProductGetSupplyProductListRsp
{
	[JsonPropertyName("data")]
	[Description("返回值")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("product_id")]
		[Description("分销productid")]
		public long ProductId { get; set; }

		[JsonPropertyName("name")]
		[Description("产品名称")]
		public string Name { get; set; }

		[JsonPropertyName("status")]
		[Description("状态")]
		public int Status { get; set; }

		[JsonPropertyName("sub_status")]
		[Description("子状态")]
		public int SubStatus { get; set; }

		[JsonPropertyName("outer_product_id")]
		[Description("外部商品编码")]
		public string OuterProductId { get; set; }

		[JsonPropertyName("category_detail")]
		[Description("类目信息")]
		public CategoryDetailItem CategoryDetail { get; set; }

		public class CategoryDetailItem
		{
			[JsonPropertyName("first_cid")]
			[Description("一级类目")]
			public long FirstCid { get; set; }

			[JsonPropertyName("second_cid")]
			[Description("二级类目")]
			public long SecondCid { get; set; }

			[JsonPropertyName("third_cid")]
			[Description("三级类目")]
			public long ThirdCid { get; set; }

			[JsonPropertyName("fourth_cid")]
			[Description("四级类目")]
			public long FourthCid { get; set; }

			[JsonPropertyName("first_cname")]
			[Description("一级类目名称")]
			public string FirstCname { get; set; }

			[JsonPropertyName("second_cname")]
			[Description("二级类目名称")]
			public string SecondCname { get; set; }

			[JsonPropertyName("third_cname")]
			[Description("三级类目名称")]
			public string ThirdCname { get; set; }

			[JsonPropertyName("fourth_cname")]
			[Description("四级类目名称")]
			public string FourthCname { get; set; }
		}

		[JsonPropertyName("img")]
		[Description("主图地址")]
		public string Img { get; set; }

		[JsonPropertyName("standard_brand_id")]
		[Description("品牌id")]
		public long StandardBrandId { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public long UpdateTime { get; set; }
	}

	[JsonPropertyName("page")]
	[Description("当前页数")]
	public int Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页大小")]
	public int Size { get; set; }

	[JsonPropertyName("total")]
	[Description("总页数")]
	public long Total { get; set; }
}
