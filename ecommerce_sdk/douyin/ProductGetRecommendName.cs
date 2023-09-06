namespace ecommerce.sdk.douyin;

[Description("调用该接口前，请先使用【/product/getProductUpdateRule】接口查询类目id响应结果recommend_name_rule.satisfy_prefix是否=true，当类目id为true时，再使用该接口查询类目id的推荐结果，当类目id为false时该接口查询结果会为空。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2010001","重试")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:2010004","检查参数")]
[DouyinRetCode(40004,"非法的参数","不存在有效的标题推荐类场景","isv.parameter-invalid:2010342","检查scene参数")]
public class ProductGetRecommendNameReq : IDouyinReq<ProductGetRecommendNameRsp>
{

	public string GetMethod() { return "product.getRecommendName"; }

	public string GetUrl() { return "/product/getRecommendName"; }

	[JsonPropertyName("scene")]
	[Description("暂时仅开放一种场景：1. product_name_prefix，表示基于 命中的商品类目属性 推荐 商品标题前缀")]
	[NotNull]
	public List<string> Scene { get; set; }

	[JsonPropertyName("category_leaf_id")]
	[Description("商品叶子类目id，请先使用【/product/getProductUpdateRule】接口查询类目id查看recommend_name_rule. satisfy_prefix是否=true")]
	[NotNull]
	public long? CategoryLeafId { get; set; }

	[JsonPropertyName("first_cid")]
	[Description("一级类目id，scene为product_name_prefix时必传，没有时传0")]
	[NotNull]
	public long? FirstCid { get; set; }

	[JsonPropertyName("first_cid_name")]
	[Description("一级类目名，scene为product_name_prefix时必传")]
	[NotNull]
	public string FirstCidName { get; set; }

	[JsonPropertyName("second_cid")]
	[Description("二级类目id，scene为product_name_prefix时必传，没有时传0")]
	[NotNull]
	public long? SecondCid { get; set; }

	[JsonPropertyName("second_cid_name")]
	[Description("二级类目名，scene为product_name_prefix时必传")]
	[NotNull]
	public string SecondCidName { get; set; }

	[JsonPropertyName("third_cid")]
	[Description("三级类目id，scene为product_name_prefix时必传，没有时传0")]
	[NotNull]
	public long? ThirdCid { get; set; }

	[JsonPropertyName("third_cid_name")]
	[Description("三级类目名，scene为product_name_prefix时必传")]
	[NotNull]
	public string ThirdCidName { get; set; }

	[JsonPropertyName("select_property")]
	[Description("商品类目属性，参考select_property:{1687:[{value:0,name:填入品牌名}],3320:[{value:18972,name:99新}]}")]
	[NotNull]
	public Dictionary<long,object> SelectProperty { get; set; }
}

[Description("调用该接口前，请先使用【/product/getProductUpdateRule】接口查询类目id响应结果recommend_name_rule.satisfy_prefix是否=true，当类目id为true时，再使用该接口查询类目id的推荐结果，当类目id为false时该接口查询结果会为空。")]
public class ProductGetRecommendNameRsp
{
	[JsonPropertyName("recommend_name")]
	[Description("商品标题推荐结果，当返回值为空时，使用【/product/getProductUpdateRule】接口查询类目id查看recommend_name_rule.satisfy_prefix是否=true")]
	public List<RecommendNameItem> RecommendName { get; set; }

	public class RecommendNameItem
	{
		[JsonPropertyName("recommend_scene")]
		[Description("推荐场景")]
		public string RecommendScene { get; set; }

		[JsonPropertyName("recommend_value")]
		[Description("推荐结果")]
		public string RecommendValue { get; set; }
	}
}
