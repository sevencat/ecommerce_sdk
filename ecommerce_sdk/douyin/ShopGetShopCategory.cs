namespace ecommerce.sdk.douyin;

[Description("请一定使用最小层级类目id，发布商品或更新商品。,接口使用注意点：,1、第一次请求cid=0获取所有一级类目,2、先判断enable=true，如果enable=false表示该类目已经失效，请勿使用。,3、循环获取最小层级类目id方式：再判断is_leaf=true或false。is_leaf=true表示是叶子节点，最小层级类目id。is_leaf=false表示不是子节点，请求参数cid=上一次响应参数id，直到获取最小层级类目id。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:2012004","检查参数")]
[DouyinRetCode(50002,"业务处理失败","获取类目信息失败","isv.business-failed:2012013","重试")]
[DouyinRetCode(50002,"业务处理失败","获取商家信息失败，请重试","isv.business-failed:2012001","重试")]
public class ShopGetShopCategoryReq : IDouyinReq<ShopGetShopCategoryRsp>
{

	public string GetMethod() { return "shop.getShopCategory"; }

	public string GetUrl() { return "/shop/getShopCategory"; }

	[JsonPropertyName("cid")]
	[Description("父类目id，根据父id可以获取子类目。首次请求传值为0 可以获取所有一级类目。循环调用接口获取最小层级类目id，根据响应参数判断is_leaf=true或false。is_leaf=true表示是叶子节点，获取最小层级类目id，is_leaf=false表示不是子节点，请求参数cid=上一次响应参数id，直到获取最小层级类目id。")]
	[NotNull]
	public long? Cid { get; set; }
}

[Description("请一定使用最小层级类目id，发布商品或更新商品。,接口使用注意点：,1、第一次请求cid=0获取所有一级类目,2、先判断enable=true，如果enable=false表示该类目已经失效，请勿使用。,3、循环获取最小层级类目id方式：再判断is_leaf=true或false。is_leaf=true表示是叶子节点，最小层级类目id。is_leaf=false表示不是子节点，请求参数cid=上一次响应参数id，直到获取最小层级类目id。")]
public class ShopGetShopCategoryRsp
{
	[JsonPropertyName("data")]
	[Description("返回参数列表")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("id")]
		[Description("类目id，用于商品发布和更新，对应请求参数category_leaf_id字段")]
		public long Id { get; set; }

		[JsonPropertyName("name")]
		[Description("类目名称")]
		public string Name { get; set; }

		[JsonPropertyName("level")]
		[Description("类目级别：1，2，3级类目")]
		public long Level { get; set; }

		[JsonPropertyName("parent_id")]
		[Description("类目父级父类目id")]
		public long ParentId { get; set; }

		[JsonPropertyName("is_leaf")]
		[Description("是否是叶子节点；is_leaf=true表示是叶子节点，最小层级类目id。is_leaf=false表示不是子节点，请求参数cid=上一次响应参数id，直到获取最小层级类目id")]
		public bool IsLeaf { get; set; }

		[JsonPropertyName("enable")]
		[Description("类目使用有效；enable=true有效，如果enable=false表示该类目已经失效，请勿使用")]
		public bool Enable { get; set; }
	}
}
