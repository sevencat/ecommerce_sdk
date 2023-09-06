namespace ecommerce.sdk.douyin;

[Description("回收服务商在推送上门拆旧的能力范围时，需要按照类目+地址维度推送，所以在推送之前，会查询字节的回收类目信息")]
public class LogisticsQueryRecycleCateByLevelForPagingReq : IDouyinReq<LogisticsQueryRecycleCateByLevelForPagingRsp>
{

	public string GetMethod() { return "logistics.QueryRecycleCateByLevelForPaging"; }

	public string GetUrl() { return "/logistics/QueryRecycleCateByLevelForPaging"; }

	[JsonPropertyName("level")]
	[Description("类目层级（1：一级类目，2：二级类目，3：三级类目），如不填写，则查询所有层级的类目")]
	public int? Level { get; set; }

	[JsonPropertyName("page_num")]
	[Description("当前页（page_num > 0）")]
	[NotNull]
	public int? PageNum { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页大小（0 < page_size <= 100）")]
	[NotNull]
	public int? PageSize { get; set; }
}

[Description("回收服务商在推送上门拆旧的能力范围时，需要按照类目+地址维度推送，所以在推送之前，会查询字节的回收类目信息")]
public class LogisticsQueryRecycleCateByLevelForPagingRsp
{
	[JsonPropertyName("total")]
	[Description("总条数")]
	public long Total { get; set; }

	[JsonPropertyName("data")]
	[Description("类目信息列表")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("code")]
		[Description("类目编码")]
		public string Code { get; set; }

		[JsonPropertyName("name")]
		[Description("类目名称")]
		public string Name { get; set; }

		[JsonPropertyName("level")]
		[Description("类目层级")]
		public int Level { get; set; }

		[JsonPropertyName("parent_code")]
		[Description("父类目编码")]
		public string ParentCode { get; set; }
	}
}
