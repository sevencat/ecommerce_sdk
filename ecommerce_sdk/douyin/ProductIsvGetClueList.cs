namespace ecommerce.sdk.douyin;

[Description("提供给isv，根据店铺获取线索")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","查询店铺失败","isp.service-error:501","联系开发者")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:502","联系开发者")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:503","联系开发者")]
[DouyinRetCode(40004,"非法的参数","分页参数不能小于0","isv.parameter-invalid:504","分页参数不能小于0")]
[DouyinRetCode(40004,"非法的参数","渠道类型不存在","isv.parameter-invalid:505","渠道类型不存在")]
public class ProductIsvGetClueListReq : IDouyinReq<ProductIsvGetClueListRsp>
{

	public string GetMethod() { return "product.isv.getClueList"; }

	public string GetUrl() { return "/product/isv/getClueList"; }

	[JsonPropertyName("source_channel_code")]
	[Description("渠道，competitive：搜索热招商机，shop_exclusive：店铺专属商机，query_none_less：搜索蓝海商机，industry_selected：行业趋势商机")]
	[NotNull]
	public string SourceChannelCode { get; set; }

	[JsonPropertyName("first_cid")]
	[Description("一级类目id")]
	public long? FirstCid { get; set; }

	[JsonPropertyName("second_cid")]
	[Description("二级类目id")]
	public long? SecondCid { get; set; }

	[JsonPropertyName("clue_info")]
	[Description("品牌名或线索名")]
	public string ClueInfo { get; set; }

	[JsonPropertyName("current")]
	[Description("当前页(从1开始)")]
	[NotNull]
	public long? Current { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页条数")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("competitive_clue_type")]
	[Description("爆款类型，0：趋势爆款，1：行业爆款，2：品牌爆款，3：货源地爆款")]
	public int? CompetitiveClueType { get; set; }
}

[Description("提供给isv，根据店铺获取线索")]
public class ProductIsvGetClueListRsp
{
	[JsonPropertyName("data")]
	[Description("返回值")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("clue_id")]
		[Description("线索id")]
		public long ClueId { get; set; }

		[JsonPropertyName("clue_name")]
		[Description("线索名")]
		public string ClueName { get; set; }

		[JsonPropertyName("pic_url")]
		[Description("图片链接")]
		public string PicUrl { get; set; }

		[JsonPropertyName("first_cid")]
		[Description("一级类目id")]
		public long FirstCid { get; set; }

		[JsonPropertyName("first_name")]
		[Description("一级类目名称")]
		public string FirstName { get; set; }

		[JsonPropertyName("second_cid")]
		[Description("二级类目id")]
		public long SecondCid { get; set; }

		[JsonPropertyName("second_name")]
		[Description("二级类目名称")]
		public string SecondName { get; set; }

		[JsonPropertyName("brand_id")]
		[Description("品牌id")]
		public long BrandId { get; set; }

		[JsonPropertyName("brand_name_cn")]
		[Description("品牌中文名")]
		public string BrandNameCn { get; set; }

		[JsonPropertyName("brand_name_en")]
		[Description("品牌英文名")]
		public string BrandNameEn { get; set; }

		[JsonPropertyName("price_min")]
		[Description("最低价格（分）")]
		public long PriceMin { get; set; }

		[JsonPropertyName("price_max")]
		[Description("最高价格（分）")]
		public long PriceMax { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总条数")]
	public long Total { get; set; }
}
