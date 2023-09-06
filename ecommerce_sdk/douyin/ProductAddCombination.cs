namespace ecommerce.sdk.douyin;

[Description("创建商品搭配")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2010001","参考返回信息")]
public class ProductAddCombinationReq : IDouyinReq<ProductAddCombinationRsp>
{

	public string GetMethod() { return "product.addCombination"; }

	public string GetUrl() { return "/product/addCombination"; }

	[JsonPropertyName("title")]
	[Description("搭配标题名称")]
	[NotNull]
	public string Title { get; set; }

	[JsonPropertyName("description")]
	[Description("搭配描述语")]
	[NotNull]
	public string Description { get; set; }

	[JsonPropertyName("anchor_image_info")]
	[Description("搭配主图与锚点信息。image中三个字段分别代表图片地址（抖店素材中心地址）、宽、高。,image_hot_area是一个表示锚点信息的数组，数组中每一个元素表示一个锚点，内部包含坐标（point结构）和细节信息。细节信息包括展示内容（商品ID、展示名称）以及朝向（direction字段，值枚举为left，right）。,只有店铺搭配可以填写。")]
	public string AnchorImageInfo { get; set; }

	[JsonPropertyName("creator_type")]
	[Description("创建者类型，店铺创建传1，客服创建传3")]
	[NotNull]
	public long? CreatorType { get; set; }

	[JsonPropertyName("creator_id")]
	[Description("和creator_type保持联动，如果creator_type为1则是店铺ID，如果creator_type为则是客服ID")]
	[NotNull]
	public long? CreatorId { get; set; }

	[JsonPropertyName("create_source")]
	[Description("固定传99，否则校验出错")]
	[NotNull]
	public long? CreateSource { get; set; }

	[JsonPropertyName("product_ids")]
	[Description("商品ID列表")]
	[NotNull]
	public List<long> ProductIds { get; set; }

	[JsonPropertyName("combination_type")]
	[Description("搭配类型，1表示店铺搭配，3表示客服搭配")]
	[NotNull]
	public int? CombinationType { get; set; }

	[JsonPropertyName("combination_subtype")]
	[Description("搭配子类型，总共可以填写0，1，3三个值。,与combination_type保持联动，如果搭配类型为店铺搭配，则对应值可以填写为1（表示有主图的搭配），2（表示无主图）。如果搭配类型为客服搭配，请固定传0。")]
	[NotNull]
	public int? CombinationSubtype { get; set; }

	[JsonPropertyName("owner_type")]
	[Description("搭配归属者类型，请固定传1")]
	[NotNull]
	public int? OwnerType { get; set; }

	[JsonPropertyName("sku_info")]
	[Description("SKU信息，仅客服搭配可以填写")]
	public List<SkuInfoItem> SkuInfo { get; set; }

	public class SkuInfoItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		[NotNull]
		public long? ProductId { get; set; }

		[JsonPropertyName("sku_num_info")]
		[Description("SKU数量信息")]
		public List<SkuNumInfoItem> SkuNumInfo { get; set; }

		public class SkuNumInfoItem
		{
			[JsonPropertyName("sku_id")]
			[Description("SKU ID")]
			[NotNull]
			public long? SkuId { get; set; }

			[JsonPropertyName("num")]
			[Description("SKU个数")]
			[NotNull]
			public long? Num { get; set; }
		}
	}
}

[Description("创建商品搭配")]
public class ProductAddCombinationRsp
{
	[JsonPropertyName("combination_id")]
	[Description("搭配ID")]
	public long CombinationId { get; set; }
}
