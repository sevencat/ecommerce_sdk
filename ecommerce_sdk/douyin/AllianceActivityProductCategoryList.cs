namespace ecommerce.sdk.douyin;

[Description("创建活动时候可选择的类目接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
public class AllianceActivityProductCategoryListReq : IDouyinReq<AllianceActivityProductCategoryListRsp>
{

	public string GetMethod() { return "alliance.activityProductCategoryList"; }

	public string GetUrl() { return "/alliance/activityProductCategoryList"; }

}

[Description("创建活动时候可选择的类目接口")]
public class AllianceActivityProductCategoryListRsp
{
	[JsonPropertyName("category_list")]
	[Description("类目列表")]
	public List<CategoryListItem> CategoryList { get; set; }

	public class CategoryListItem
	{
		[JsonPropertyName("name")]
		[Description("行业类目名称")]
		public string Name { get; set; }

		[JsonPropertyName("category_id")]
		[Description("行业类目ID")]
		public int CategoryId { get; set; }

		[JsonPropertyName("first_categories")]
		[Description("一级类目")]
		public List<FirstCategoriesItem> FirstCategories { get; set; }

		public class FirstCategoriesItem
		{
			[JsonPropertyName("id")]
			[Description("一级类目名 id")]
			public long Id { get; set; }

			[JsonPropertyName("name")]
			[Description("一级类目名称")]
			public string Name { get; set; }
		}
	}
}
