namespace ecommerce.sdk.douyin;

[Description("返回类目列表：类目层级、类目名称、类目ID")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
public class AllianceMaterialsProductCategoryReq : IDouyinReq<AllianceMaterialsProductCategoryRsp>
{

	public string GetMethod() { return "alliance.materialsProductCategory"; }

	public string GetUrl() { return "/alliance/materialsProductCategory"; }

	[JsonPropertyName("parent_id")]
	[Description("父类目 （0表示查询一级类目列表）")]
	[NotNull]
	public long? ParentId { get; set; }
}

[Description("返回类目列表：类目层级、类目名称、类目ID")]
public class AllianceMaterialsProductCategoryRsp
{
	[JsonPropertyName("total")]
	[Description("类目总数")]
	public long Total { get; set; }

	[JsonPropertyName("category_list")]
	[Description("类目列表（包含查询的父类目和下一级子类目）")]
	public List<CategoryListItem> CategoryList { get; set; }

	public class CategoryListItem
	{
		[JsonPropertyName("id")]
		[Description("类目ID")]
		public long Id { get; set; }

		[JsonPropertyName("name")]
		[Description("类目名称")]
		public string Name { get; set; }

		[JsonPropertyName("level")]
		[Description("类目层级")]
		public long Level { get; set; }
	}
}
