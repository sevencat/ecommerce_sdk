namespace ecommerce.sdk.douyin;

[Description("根据关键属性或者ID查询SPU")]
public class SpuGetSpuReq : IDouyinReq<SpuGetSpuRsp>
{

	public string GetMethod() { return "spu.getSpu"; }

	public string GetUrl() { return "/spu/getSpu"; }

	[JsonPropertyName("category_leaf_id")]
	[Description("叶子类目ID")]
	public long? CategoryLeafId { get; set; }

	[JsonPropertyName("key_properties")]
	[Description("关键属性")]
	public List<KeyPropertiesItem> KeyProperties { get; set; }

	public class KeyPropertiesItem
	{
		[JsonPropertyName("property_id")]
		[Description("属性ID")]
		public long? PropertyId { get; set; }

		[JsonPropertyName("property_values")]
		[Description("属性值")]
		public List<PropertyValuesItem> PropertyValues { get; set; }

		public class PropertyValuesItem
		{
			[JsonPropertyName("value_id")]
			[Description("属性值ID")]
			public long? ValueId { get; set; }

			[JsonPropertyName("value_name")]
			[Description("属性值")]
			public string ValueName { get; set; }
		}
	}

	[JsonPropertyName("spu_id")]
	[Description("SPU ID（传SPUID时，关键属性不用传，传关键属性时，SPU ID不用传，两个都传的情况下，会以SPU ID为准，查询SPU）")]
	public long? SpuId { get; set; }
}

[Description("根据关键属性或者ID查询SPU")]
public class SpuGetSpuRsp
{
	[JsonPropertyName("spu_id")]
	[Description("SPU ID")]
	public long SpuId { get; set; }

	[JsonPropertyName("spu_name")]
	[Description("SPU名")]
	public string SpuName { get; set; }

	[JsonPropertyName("category_leaf_id")]
	[Description("类目ID")]
	public long CategoryLeafId { get; set; }

	[JsonPropertyName("property_infos")]
	[Description("属性信息")]
	public List<PropertyInfosItem> PropertyInfos { get; set; }

	public class PropertyInfosItem
	{
		[JsonPropertyName("property_id")]
		[Description("属性ID")]
		public long PropertyId { get; set; }

		[JsonPropertyName("property_values")]
		[Description("属性值")]
		public List<PropertyValuesItem> PropertyValues { get; set; }

		public class PropertyValuesItem
		{
			[JsonPropertyName("value_id")]
			[Description("属性值ID")]
			public long ValueId { get; set; }

			[JsonPropertyName("value_name")]
			[Description("属性值")]
			public string ValueName { get; set; }
		}

		[JsonPropertyName("property_name")]
		[Description("属性名")]
		public string PropertyName { get; set; }

		[JsonPropertyName("property_type")]
		[Description("属性类型，0 绑定属性 1关键属性 2销售属性")]
		public long PropertyType { get; set; }
	}

	[JsonPropertyName("cspus")]
	[Description("CSPU信息")]
	public List<CspusItem> Cspus { get; set; }

	public class CspusItem
	{
		[JsonPropertyName("cspu_id")]
		[Description("CSPU ID")]
		public long CspuId { get; set; }

		[JsonPropertyName("spu_id")]
		[Description("SPU ID")]
		public long SpuId { get; set; }

		[JsonPropertyName("sale_properties")]
		[Description("销售属性")]
		public List<SalePropertiesItem> SaleProperties { get; set; }

		public class SalePropertiesItem
		{
			[JsonPropertyName("property_id")]
			[Description("属性ID")]
			public long PropertyId { get; set; }

			[JsonPropertyName("property_name")]
			[Description("属性名")]
			public string PropertyName { get; set; }

			[JsonPropertyName("value_id")]
			[Description("属性值ID")]
			public long ValueId { get; set; }

			[JsonPropertyName("value_name")]
			[Description("属性值")]
			public string ValueName { get; set; }
		}
	}

	[JsonPropertyName("status")]
	[Description("1:上线，2:下线，3:审核中，4:审核不通过")]
	public long Status { get; set; }
}
