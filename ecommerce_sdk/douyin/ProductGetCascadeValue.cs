namespace ecommerce.sdk.douyin;

[Description("获取级联属性，当前属性有下级属性值，选中当前属性值，通过此接口请求下级级联属性值；")]
public class ProductGetCascadeValueReq : IDouyinReq<ProductGetCascadeValueRsp>
{

	public string GetMethod() { return "product.getCascadeValue"; }

	public string GetUrl() { return "/product/getCascadeValue"; }

	[JsonPropertyName("category_id")]
	[Description("类目id")]
	[NotNull]
	public long? CategoryId { get; set; }

	[JsonPropertyName("property_id")]
	[Description("属性id")]
	[NotNull]
	public long? PropertyId { get; set; }

	[JsonPropertyName("cascade_info")]
	[Description("级联参数，传当前属性属性值")]
	[NotNull]
	public List<CascadeInfoItem> CascadeInfo { get; set; }

	public class CascadeInfoItem
	{
		[JsonPropertyName("value_id")]
		[Description("属性值id")]
		[NotNull]
		public long? ValueId { get; set; }

		[JsonPropertyName("value_name")]
		[Description("属性值名称")]
		[NotNull]
		public string ValueName { get; set; }

		[JsonPropertyName("cascade_id")]
		[Description("级联id，第一次传0，后续查询使用上一次的查询结果中的cascade_id")]
		[NotNull]
		public long? CascadeId { get; set; }
	}
}

[Description("获取级联属性，当前属性有下级属性值，选中当前属性值，通过此接口请求下级级联属性值；")]
public class ProductGetCascadeValueRsp
{
	[JsonPropertyName("properties")]
	[Description("级联属性")]
	public List<PropertiesItem> Properties { get; set; }

	public class PropertiesItem
	{
		[JsonPropertyName("property_id")]
		[Description("属性id")]
		public long PropertyId { get; set; }

		[JsonPropertyName("property_values")]
		[Description("属性内容")]
		public List<PropertyValuesItem> PropertyValues { get; set; }

		public class PropertyValuesItem
		{
			[JsonPropertyName("property_value_id")]
			[Description("属性值id")]
			public long PropertyValueId { get; set; }

			[JsonPropertyName("property_value_name")]
			[Description("属性值名称")]
			public string PropertyValueName { get; set; }

			[JsonPropertyName("cascade_id")]
			[Description("级联id")]
			public long CascadeId { get; set; }
		}

		[JsonPropertyName("has_sub_property")]
		[Description("是否有下级属性")]
		public bool HasSubProperty { get; set; }
	}
}
