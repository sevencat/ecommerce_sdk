namespace ecommerce.sdk.douyin;

[Description("新增、编辑、删除装修分类（仅限超市）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数检验不通过","isv.parameter-invalid:20115","请检查参数是否合法，是否是有效的类目信息")]
[DouyinRetCode(50002,"业务处理失败","系统异常","isv.business-failed:20116","处理失败，请重试或联系客服处理")]
[DouyinRetCode(50002,"业务处理失败","参数检验不通过","isv.business-failed:20120","请检查参数是否合法，是否是有效的类目信息")]
[DouyinRetCode(50002,"业务处理失败","参数为空，请检查","isv.business-failed:10000","请检查参数是否符合规范")]
[DouyinRetCode(50002,"业务处理失败","参数检验不通过","isv.business-failed:20125","请检查参数是否合法，是否是有效的类目信息")]
public class ShopMarketCategoryOperateReq : IDouyinReq<ShopMarketCategoryOperateRsp>
{

	public string GetMethod() { return "shop.marketCategoryOperate"; }

	public string GetUrl() { return "/shop/marketCategoryOperate"; }

	[JsonPropertyName("operate_type")]
	[Description("操作类型：创建、更新、删除,create创建：categoryId parentCategoryId 只有以下两种情况（0等同于nil）:,nil nil 表示创建一个一级分类，,nil parentCategoryId 表示创建一个二级分类；,update编辑：categoryId parentCategoryId 只有以下两种情况：,categoryId nil 表示编辑一个一级分类，,categoryId parentCategoryId 表示编辑一个二级分类；,delete删除：categoryId parentCategoryId 只有以下两种情况：,categoryId nil 表示删除一个一级分类，,categoryId parentCategoryId 表示删除一个二级分类；")]
	[NotNull]
	public string OperateType { get; set; }

	[JsonPropertyName("parent_category_id")]
	[Description("父类目的id，传0或者不传则category_id表示一级类目")]
	public long? ParentCategoryId { get; set; }

	[JsonPropertyName("category_id")]
	[Description("类目的id,创建的时候不传或传0，编辑删除的时候必传")]
	public long? CategoryId { get; set; }

	[JsonPropertyName("sequence")]
	[Description("表示类目在同级别排序的索引位置（从0开始），-1表示倒数第一，-2倒数第二，以此类推。不传则不变化（create时默认后面追加,修改顺序请使用update方法）")]
	public long? Sequence { get; set; }

	[JsonPropertyName("category_name")]
	[Description("类目名称，创建操作时必填名称")]
	public string CategoryName { get; set; }

	[JsonPropertyName("rank")]
	[Description("类目在同级别优先级权重，越大则越靠前，范围[0,100000]")]
	public long? Rank { get; set; }
}

[Description("新增、编辑、删除装修分类（仅限超市）")]
public class ShopMarketCategoryOperateRsp
{
	[JsonPropertyName("category_id")]
	[Description("创建、编辑、删除的类目id")]
	public long CategoryId { get; set; }
}
