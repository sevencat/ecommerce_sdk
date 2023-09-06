namespace ecommerce.sdk.douyin;

[Description("获取供应商可选类目")]
[DouyinRetCode(10000,"success","","","")]
public class SupplyChainGetSupplierCategoryReq : IDouyinReq<SupplyChainGetSupplierCategoryRsp>
{

	public string GetMethod() { return "supplyChain.getSupplierCategory"; }

	public string GetUrl() { return "/supplyChain/getSupplierCategory"; }

	[JsonPropertyName("category_id")]
	[Description("父类目id，根据父id可以获取子类目。首次请求传值为0 可以获取所有一级类目。循环调用接口获取最小层级类目id，根据响应参数判断is_leaf=true或false。is_leaf=true表示是叶子节点，获取最小层级类目id，is_leaf=false表示不是子节点，请求参数cid=上一次响应参数id，直到获取最小层级类目id。")]
	[NotNull]
	public long? CategoryId { get; set; }
}

[Description("获取供应商可选类目")]
public class SupplyChainGetSupplierCategoryRsp
{
	[JsonPropertyName("data")]
	[Description("返回值")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("id")]
		[Description("类目id，用于产品发布和更新")]
		public long Id { get; set; }

		[JsonPropertyName("name")]
		[Description("类目名称")]
		public string Name { get; set; }

		[JsonPropertyName("parent_id")]
		[Description("父类目id")]
		public long ParentId { get; set; }

		[JsonPropertyName("level")]
		[Description("类目级别：1，2，3级类目")]
		public int Level { get; set; }

		[JsonPropertyName("is_leaf")]
		[Description("是否叶子类目")]
		public bool IsLeaf { get; set; }
	}
}
