namespace ecommerce.sdk.douyin;

[Description("获取可图片鉴定的品牌,获取可鉴定的品牌")]
public class BtasListBrandReq : IDouyinReq<BtasListBrandRsp>
{

	public string GetMethod() { return "btas.listBrand"; }

	public string GetUrl() { return "/btas/listBrand"; }

}

[Description("获取可图片鉴定的品牌,获取可鉴定的品牌")]
public class BtasListBrandRsp
{
	[JsonPropertyName("brand_list")]
	[Description("品牌列表")]
	public List<BrandListItem> BrandList { get; set; }

	public class BrandListItem
	{
		[JsonPropertyName("brand_id")]
		[Description("品牌ID")]
		public long BrandId { get; set; }

		[JsonPropertyName("brand_name")]
		[Description("品牌名称")]
		public string BrandName { get; set; }

		[JsonPropertyName("brand_category_list")]
		[Description("品牌支持类型")]
		public List<BrandCategoryListItem> BrandCategoryList { get; set; }

		public class BrandCategoryListItem
		{
			[JsonPropertyName("id")]
			[Description("支持类型ID")]
			public long Id { get; set; }

			[JsonPropertyName("name")]
			[Description("支持类型名称")]
			public string Name { get; set; }
		}
	}
}
