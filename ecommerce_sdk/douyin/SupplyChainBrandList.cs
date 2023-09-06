namespace ecommerce.sdk.douyin;

[Description("获取品牌信息")]
public class SupplyChainBrandListReq : IDouyinReq<SupplyChainBrandListRsp>
{

	public string GetMethod() { return "supplyChain.brand.list"; }

	public string GetUrl() { return "/supplyChain/brand/list"; }

	[JsonPropertyName("category_id")]
	[Description("类目id")]
	[NotNull]
	public long? CategoryId { get; set; }

	[JsonPropertyName("brand_name")]
	[Description("品牌前缀")]
	[NotNull]
	public string BrandName { get; set; }
}

[Description("获取品牌信息")]
public class SupplyChainBrandListRsp
{
	[JsonPropertyName("auth_brand_list")]
	[Description("品牌列表")]
	public List<AuthBrandListItem> AuthBrandList { get; set; }

	public class AuthBrandListItem
	{
		[JsonPropertyName("name_cn")]
		[Description("品牌中文名")]
		public string NameCn { get; set; }

		[JsonPropertyName("name_en")]
		[Description("品牌英文名")]
		public string NameEn { get; set; }

		[JsonPropertyName("brand_id")]
		[Description("品牌id")]
		public long BrandId { get; set; }
	}
}
