namespace ecommerce.sdk.douyin;

[Description("需要新发SPU时，根据SPU的规则，填写属性、图片相关信息，然后提交发布。该接口适用于图书类目商品使用；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","图片格式错误","isv.business-failed:20121017","检查图片链接是否满足要求")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2012001","重试")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:2012004","检查请求参数")]
[DouyinRetCode(50002,"业务处理失败","证明信息参数错误","isv.business-failed:20121020","检查请求参数中的证明信息")]
[DouyinRetCode(50002,"业务处理失败","属性信息有误","isv.business-failed:20121009","检查请求参数中的属性信息")]
[DouyinRetCode(50002,"业务处理失败","数据加载异常","isv.business-failed:2012013","重试")]
public class SpuCreateSpuReq : IDouyinReq<SpuCreateSpuRsp>
{

	public string GetMethod() { return "spu.createSpu"; }

	public string GetUrl() { return "/spu/createSpu"; }

	[JsonPropertyName("category_leaf_id")]
	[Description("叶子类目ID")]
	[NotNull]
	public long? CategoryLeafId { get; set; }

	[JsonPropertyName("spu_images")]
	[Description("SPU图片（/spu/batchUploadImg返回的URL）")]
	public List<string> SpuImages { get; set; }

	[JsonPropertyName("property_infos")]
	[Description("属性信息（/spu/getSpuRule接口可获取）")]
	[NotNull]
	public List<PropertyInfosItem> PropertyInfos { get; set; }

	public class PropertyInfosItem
	{
		[JsonPropertyName("property_id")]
		[Description("属性ID")]
		[NotNull]
		public long? PropertyId { get; set; }

		[JsonPropertyName("values")]
		[Description("属性值")]
		[NotNull]
		public List<ValuesItem> Values { get; set; }

		public class ValuesItem
		{
			[JsonPropertyName("value_id")]
			[Description("属性值ID")]
			[NotNull]
			public long? ValueId { get; set; }

			[JsonPropertyName("value_name")]
			[Description("属性值")]
			[NotNull]
			public string ValueName { get; set; }
		}
	}

	[JsonPropertyName("spu_actual_images")]
	[Description("SPU实物图，用于证明SPU存在，比如包装图，版权页图（/spu/batchUploadImg返回的URL）")]
	public List<string> SpuActualImages { get; set; }

	[JsonPropertyName("materials")]
	[Description("SPU素材")]
	public List<MaterialsItem> Materials { get; set; }

	public class MaterialsItem
	{
		[JsonPropertyName("type")]
		[Description("素材类型，枚举值：1-主图")]
		[NotNull]
		public int? Type { get; set; }

		[JsonPropertyName("name")]
		[Description("素材类型名称")]
		[NotNull]
		public string Name { get; set; }

		[JsonPropertyName("description")]
		[Description("描述信息")]
		[NotNull]
		public string Description { get; set; }

		[JsonPropertyName("content")]
		[Description("素材的实际内容")]
		[NotNull]
		public List<ContentItem> Content { get; set; }

		public class ContentItem
		{
			[JsonPropertyName("content")]
			[Description("素材内容（/spu/batchUploadImg返回的URL）")]
			[NotNull]
			public string ContentI { get; set; }

			[JsonPropertyName("name")]
			[Description("文件的名称")]
			[NotNull]
			public string Name { get; set; }
		}
	}

	[JsonPropertyName("proofs")]
	[Description("证明信息")]
	public List<ProofsItem> Proofs { get; set; }

	public class ProofsItem
	{
		[JsonPropertyName("type")]
		[Description("证明信息（类型：实物图、版权页）")]
		[NotNull]
		public int? Type { get; set; }

		[JsonPropertyName("name")]
		[Description("证明信息类型，枚举值：2-实物图、6-版权页")]
		[NotNull]
		public string Name { get; set; }

		[JsonPropertyName("description")]
		[Description("描述信息")]
		[NotNull]
		public string Description { get; set; }

		[JsonPropertyName("content")]
		[Description("证明材料的实际内容")]
		[NotNull]
		public List<ContentItem> Content { get; set; }

		public class ContentItem
		{
			[JsonPropertyName("content")]
			[Description("证明信息内容（/spu/batchUploadImg返回的URL）")]
			[NotNull]
			public string ContentI { get; set; }

			[JsonPropertyName("name")]
			[Description("文件的名称")]
			[NotNull]
			public string Name { get; set; }
		}
	}
}

[Description("需要新发SPU时，根据SPU的规则，填写属性、图片相关信息，然后提交发布。该接口适用于图书类目商品使用；")]
public class SpuCreateSpuRsp
{
	[JsonPropertyName("spu_id")]
	[Description("SPU的ID")]
	public string SpuId { get; set; }
}
