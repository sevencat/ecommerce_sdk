namespace ecommerce.sdk.douyin;

[Description("获取店铺的已授权品牌列表")]
public class ShopBrandListReq : IDouyinReq<ShopBrandListRsp>
{

	public string GetMethod() { return "shop.brandList"; }

	public string GetUrl() { return "/shop/brandList"; }

}

[Description("获取店铺的已授权品牌列表")]
public class ShopBrandListRsp
{
	[JsonPropertyName("data")]
	[Description("返回值")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("id")]
		[Description("品牌ID")]
		public long Id { get; set; }

		[JsonPropertyName("brand_chinese_name")]
		[Description("品牌中文名")]
		public string BrandChineseName { get; set; }

		[JsonPropertyName("brand_english_name")]
		[Description("品牌英文名")]
		public string BrandEnglishName { get; set; }

		[JsonPropertyName("brand_reg_num")]
		[Description("商标注册号")]
		public string BrandRegNum { get; set; }
	}
}
