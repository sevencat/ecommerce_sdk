namespace ecommerce.sdk.douyin;

[Description("查询店铺联盟推广，最多查询10000条记录")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效size","isv.parameter-invalid:1031","无效分页大小")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
public class BuyinQueryShopAllianceProductsReq : IDouyinReq<BuyinQueryShopAllianceProductsRsp>
{

	public string GetMethod() { return "buyin.queryShopAllianceProducts"; }

	public string GetUrl() { return "/buyin/queryShopAllianceProducts"; }

	[JsonPropertyName("page")]
	[Description("分页页数，从1开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("分页大小，最大20")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("product_ids")]
	[Description("商品ID列表，用“,”分隔")]
	public List<long> ProductIds { get; set; }

	[JsonPropertyName("status")]
	[Description("商品状态。2：商品在架；3：商家关闭推广；4：商品下架；6：平台治理关闭；99：商家删除")]
	public long? Status { get; set; }

	[JsonPropertyName("title")]
	[Description("商品名称")]
	public string Title { get; set; }

	[JsonPropertyName("in_stock")]
	[Description("是否有库存")]
	public bool? InStock { get; set; }

	[JsonPropertyName("check_status")]
	[Description("审核状态。 0：未审核；2：审核未通过；3：审核通过")]
	public List<long> CheckStatus { get; set; }

	[JsonPropertyName("sort_by")]
	[Description("排序字段。 update_time: 更新时间; cos_ratio: 佣金率")]
	public string SortBy { get; set; }

	[JsonPropertyName("sort_order")]
	[Description("排序方式（Desc或者Asc）。Desc：降序；Asc：生序")]
	public string SortOrder { get; set; }

	[JsonPropertyName("fields")]
	[Description("加载更多的字段，如 is_exclusive")]
	public List<string> Fields { get; set; }
}

[Description("查询店铺联盟推广，最多查询10000条记录")]
public class BuyinQueryShopAllianceProductsRsp
{
	[JsonPropertyName("total")]
	[Description("总数，最大10000")]
	public long Total { get; set; }

	[JsonPropertyName("product_list")]
	[Description("商品列表")]
	public List<ProductListItem> ProductList { get; set; }

	public class ProductListItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("title")]
		[Description("商品名称")]
		public string Title { get; set; }

		[JsonPropertyName("cover")]
		[Description("商品主图")]
		public string Cover { get; set; }

		[JsonPropertyName("price")]
		[Description("商品售价（单位为分）")]
		public long Price { get; set; }

		[JsonPropertyName("market_price")]
		[Description("市场价 (单位为分)")]
		public long MarketPrice { get; set; }

		[JsonPropertyName("status")]
		[Description("商品状态，2：商品在架；3：商家关闭推广；4：商品下架；6：平台治理关闭；99：商家删除")]
		public long Status { get; set; }

		[JsonPropertyName("cos_ratio")]
		[Description("普通佣金率，值乘以了100， 如50%返回50")]
		public decimal CosRatio { get; set; }

		[JsonPropertyName("detail_url")]
		[Description("商品链接")]
		public string DetailUrl { get; set; }

		[JsonPropertyName("sales")]
		[Description("销量（单位为分）")]
		public long Sales { get; set; }

		[JsonPropertyName("cos_fee")]
		[Description("佣金（单位为分）")]
		public long CosFee { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间戳")]
		public long UpdateTime { get; set; }

		[JsonPropertyName("imgs")]
		[Description("图片列表")]
		public List<string> Imgs { get; set; }

		[JsonPropertyName("check_status")]
		[Description("审核状态。 0：未审核；2：审核未通过；3：审核通过")]
		public long CheckStatus { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间戳")]
		public long CreateTime { get; set; }

		[JsonPropertyName("is_exclusive")]
		[Description("是否开启专属计划")]
		public bool IsExclusive { get; set; }
	}
}
