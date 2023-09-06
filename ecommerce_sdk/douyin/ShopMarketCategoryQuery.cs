namespace ecommerce.sdk.douyin;

[Description("查询店铺的类目信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数检验不通过","isv.parameter-invalid:20130","请检查参数是否合法，是否是有效的类目信息")]
[DouyinRetCode(50002,"业务处理失败","系统异常","isv.business-failed:20131","处理失败，请重试或联系客服处理")]
public class ShopMarketCategoryQueryReq : IDouyinReq<ShopMarketCategoryQueryRsp>
{

	public string GetMethod() { return "shop.marketCategoryQuery"; }

	public string GetUrl() { return "/shop/marketCategoryQuery"; }

	[JsonPropertyName("parent_category_id")]
	[Description("父类目的id，不传则category_id表示一级类目")]
	public long? ParentCategoryId { get; set; }

	[JsonPropertyName("category_id")]
	[Description("类目的id，查询特定类目时必传，不传则查询全部类目")]
	public long? CategoryId { get; set; }
}

[Description("查询店铺的类目信息")]
public class ShopMarketCategoryQueryRsp
{
	[JsonPropertyName("category_info_list")]
	[Description("类目")]
	public List<CategoryInfoListItem> CategoryInfoList { get; set; }

	public class CategoryInfoListItem
	{
		[JsonPropertyName("rank")]
		[Description("类目在同级别优先级权重，越大则越靠前")]
		public long Rank { get; set; }

		[JsonPropertyName("category_id")]
		[Description("分类id")]
		public long CategoryId { get; set; }

		[JsonPropertyName("category_name")]
		[Description("分类名称")]
		public string CategoryName { get; set; }

		[JsonPropertyName("sequence")]
		[Description("同级分类排序")]
		public long Sequence { get; set; }

		[JsonPropertyName("children_category_info_list")]
		[Description("子类目列表")]
		public List<ChildrenCategoryInfoListItem> ChildrenCategoryInfoList { get; set; }

		public class ChildrenCategoryInfoListItem
		{
			[JsonPropertyName("rank")]
			[Description("类目在同级别优先级权重，越大则越靠前")]
			public long Rank { get; set; }

			[JsonPropertyName("category_id")]
			[Description("分类id")]
			public long CategoryId { get; set; }

			[JsonPropertyName("category_name")]
			[Description("分类名称")]
			public string CategoryName { get; set; }

			[JsonPropertyName("sequence")]
			[Description("同级分类排序")]
			public long Sequence { get; set; }
		}
	}
}
