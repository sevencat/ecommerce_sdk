namespace ecommerce.sdk.douyin;

[Description("查询属性项的属性值信息")]
public class ProductGetCategoryPropertyValueReq : IDouyinReq<ProductGetCategoryPropertyValueRsp>
{

	public string GetMethod() { return "product.getCategoryPropertyValue"; }

	public string GetUrl() { return "/product/getCategoryPropertyValue"; }

	[JsonPropertyName("category_id")]
	[Description("类目id")]
	[NotNull]
	public long? CategoryId { get; set; }

	[JsonPropertyName("property_id")]
	[Description("属性项id")]
	[NotNull]
	public long? PropertyId { get; set; }
}

[Description("查询属性项的属性值信息")]
public class ProductGetCategoryPropertyValueRsp
{
	[JsonPropertyName("property")]
	[Description("属性")]
	public PropertyItem Property { get; set; }

	public class PropertyItem
	{
		[JsonPropertyName("property_values")]
		[Description("属性值")]
		public List<PropertyValuesItem> PropertyValues { get; set; }

		public class PropertyValuesItem
		{
			[JsonPropertyName("value_pic")]
			[Description("规格值图片")]
			public ValuePicItem ValuePic { get; set; }

			public class ValuePicItem
			{
				[JsonPropertyName("pic_value")]
				[Description("图片，url链接或rgb内容")]
				public string PicValue { get; set; }

				[JsonPropertyName("pic_type")]
				[Description("属性值图片类型,url或rgb")]
				public string PicType { get; set; }
			}

			[JsonPropertyName("property_value_name")]
			[Description("属性值名称")]
			public string PropertyValueName { get; set; }

			[JsonPropertyName("property_value_id")]
			[Description("属性值id")]
			public long PropertyValueId { get; set; }
		}

		[JsonPropertyName("property_id")]
		[Description("属性id")]
		public long PropertyId { get; set; }
	}
}
