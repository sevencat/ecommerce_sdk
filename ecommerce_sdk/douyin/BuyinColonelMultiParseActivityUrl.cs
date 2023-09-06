namespace ecommerce.sdk.douyin;

[Description("支持获取团长活动商品链接活动信息以及费率信息")]
public class BuyinColonelMultiParseActivityUrlReq : IDouyinReq<BuyinColonelMultiParseActivityUrlRsp>
{

	public string GetMethod() { return "buyin.colonelMultiParseActivityUrl"; }

	public string GetUrl() { return "/buyin/colonelMultiParseActivityUrl"; }

	[JsonPropertyName("activity_url")]
	[Description("活动商品链接列表，最多20个")]
	[NotNull]
	public List<string> ActivityUrl { get; set; }
}

[Description("支持获取团长活动商品链接活动信息以及费率信息")]
public class BuyinColonelMultiParseActivityUrlRsp
{
	[JsonPropertyName("results")]
	[Description("结果集，key：活动商品链接，value:链接信息")]
	public Dictionary<string,ResultsItem> Results { get; set; }

	public class ResultsItem
	{
		[JsonPropertyName("code")]
		[Description("0-成功")]
		public long Code { get; set; }

		[JsonPropertyName("msg")]
		[Description("解析失败原因")]
		public string Msg { get; set; }

		[JsonPropertyName("is_promote")]
		[Description("链接是否在推广中")]
		public bool IsPromote { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品 id")]
		public long ProductId { get; set; }

		[JsonPropertyName("activity_id")]
		[Description("活动 id")]
		public long ActivityId { get; set; }

		[JsonPropertyName("buyin_id")]
		[Description("团长百应 id")]
		public long BuyinId { get; set; }

		[JsonPropertyName("origin_activity_id")]
		[Description("原始活动 id（非一级报二级为0）")]
		public long OriginActivityId { get; set; }

		[JsonPropertyName("origin_buyin_id")]
		[Description("原始团长buyin_id(非一级报二级为0)")]
		public long OriginBuyinId { get; set; }

		[JsonPropertyName("commission_rate")]
		[Description("佣金率(10.11%返回1011)")]
		public long CommissionRate { get; set; }

		[JsonPropertyName("service_rate")]
		[Description("服务费率（10.11%返回1011)")]
		public long ServiceRate { get; set; }
	}
}
