namespace ecommerce.sdk.douyin;

[Description("根据ISBN查询书名，主要用于图书SPU类目")]
public class SpuQueryBookNameByISBNReq : IDouyinReq<SpuQueryBookNameByISBNRsp>
{

	public string GetMethod() { return "spu.queryBookNameByISBN"; }

	public string GetUrl() { return "/spu/queryBookNameByISBN"; }

	[JsonPropertyName("category_leaf_id")]
	[Description("类目ID")]
	public long? CategoryLeafId { get; set; }

	[JsonPropertyName("isbn")]
	[Description("ISBN编号")]
	[NotNull]
	public string Isbn { get; set; }

	[JsonPropertyName("page_no")]
	[Description("当前页数。默认从0开始")]
	[NotNull]
	public long? PageNo { get; set; }

	[JsonPropertyName("page_size")]
	[Description("页大小。范围1-100")]
	[NotNull]
	public long? PageSize { get; set; }
}

[Description("根据ISBN查询书名，主要用于图书SPU类目")]
public class SpuQueryBookNameByISBNRsp
{
	[JsonPropertyName("data")]
	[Description("查询到的数据")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("spu_id")]
		[Description("spu id")]
		public string SpuId { get; set; }

		[JsonPropertyName("book_name")]
		[Description("图书的书名")]
		public string BookName { get; set; }

		[JsonPropertyName("category_leaf_id")]
		[Description("类目ID")]
		public long CategoryLeafId { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
