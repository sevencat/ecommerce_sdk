namespace ecommerce.sdk.douyin;

[Description("批量查询某个创建者创建的搭配id")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2022001","联系负责人排查")]
[DouyinRetCode(40004,"非法的参数","参数异常","isv.parameter-invalid:2022002","检查参数")]
public class ProductCombinationListReq : IDouyinReq<ProductCombinationListRsp>
{

	public string GetMethod() { return "product.combinationList"; }

	public string GetUrl() { return "/product/combinationList"; }

	[JsonPropertyName("creator_id")]
	[Description("搭配创建者id，调用方传入，与创建者类型匹配的店铺id/达人id/客服账号id")]
	[NotNull]
	public long? CreatorId { get; set; }

	[JsonPropertyName("creator_type")]
	[Description("搭配创建者类型，1 店铺，2 达人，3 客服")]
	[NotNull]
	public long? CreatorType { get; set; }

	[JsonPropertyName("page")]
	[Description("分页数，从1开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页数据，最多20")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("exclude_combination_ids")]
	[Description("过滤的搭配id")]
	public List<long> ExcludeCombinationIds { get; set; }

	[JsonPropertyName("status_list")]
	[Description("搭配状态，只允许传固定值1（代表有效搭配）")]
	public List<long> StatusList { get; set; }

	[JsonPropertyName("product_id")]
	[Description("搭配关联的商品id")]
	public long? ProductId { get; set; }

	[JsonPropertyName("combination_type")]
	[Description("搭配类型，根据创建者分为三种类型：1 卖家搭配类型（店铺创建，包含有主图和无主图），2 达人搭配类型（达人创建，均无主图）, 3 客服搭配（客服创建，均无主图）")]
	public int? CombinationType { get; set; }

	[JsonPropertyName("combination_sub_type")]
	[Description("搭配子类型，0 默认搭配子类型，1 固定搭配子类型, 2 临时搭配子类型；,达人搭配和客服搭配只有默认搭配子类型；卖家搭配有固定搭配子类型（有主图）和临时搭配子类型（无主图）。")]
	public int? CombinationSubType { get; set; }
}

[Description("批量查询某个创建者创建的搭配id")]
public class ProductCombinationListRsp
{
	[JsonPropertyName("combination_list")]
	[Description("搭配id列表")]
	public List<CombinationListItem> CombinationList { get; set; }

	public class CombinationListItem
	{
		[JsonPropertyName("combination_id")]
		[Description("搭配id")]
		public long CombinationId { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("搭配总数量")]
	public long Total { get; set; }
}
