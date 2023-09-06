namespace ecommerce.sdk.douyin;

[Description("产品编辑，编辑规则请查看/supplyProduct/getSupplyProductUpdateRule")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","编辑分销品错误","isv.business-failed:3207","编辑分销品错误")]
[DouyinRetCode(50002,"业务处理失败","分销品供货价不能是0","isv.business-failed:3206","分销品供货价不能是0")]
public class SupplyChainSupplyProductEditReq : IDouyinReq<SupplyChainSupplyProductEditRsp>
{

	public string GetMethod() { return "supplyChain.supplyProduct.edit"; }

	public string GetUrl() { return "/supplyChain/supplyProduct/edit"; }

	[JsonPropertyName("product_id")]
	[Description("产品id")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("category_leaf_id")]
	[Description("叶子类目ID通过getSupplyProductUpdateRule")]
	[NotNull]
	public long? CategoryLeafId { get; set; }

	[JsonPropertyName("name")]
	[Description("商品名称，最多60个字符(30个汉字)，不能含emoj表情")]
	[NotNull]
	public string Name { get; set; }

	[JsonPropertyName("recommend_remark")]
	[Description("商家推荐语，不能含emoj表情商品轮播图，多张图片用 ,|, 分开，第一张图为主图，最多5张，至少600x600，大小不超过1M 注：,pic,、,description,、,spec_pic,这三个字段里的传入的图片数量总和，不得超过50张。")]
	public string RecommendRemark { get; set; }

	[JsonPropertyName("pic")]
	[Description("产品轮播图，多张图片用 ,|, 分开，第一张图为主图，最多5张，至少600x600，大小不超过1M 注：,pic,、,description,、,spec_pic,这三个字段里的传入的图片数量总和，不得超过50张。")]
	[NotNull]
	public string Pic { get; set; }

	[JsonPropertyName("description")]
	[Description("商品描述，目前只支持图片。多张图片用 ,|, 分开。不能用其他网站的文本粘贴，这样会出现css样式不兼容。")]
	[NotNull]
	public string Description { get; set; }

	[JsonPropertyName("weight")]
	[Description("重量")]
	public decimal? Weight { get; set; }

	[JsonPropertyName("weight_unit")]
	[Description("重量单位，0-kg, 1-g")]
	public long? WeightUnit { get; set; }

	[JsonPropertyName("remark")]
	[Description("商家可见备注")]
	public string Remark { get; set; }

	[JsonPropertyName("quality_list")]
	[Description("资质列表")]
	public List<QualityListItem> QualityList { get; set; }

	public class QualityListItem
	{
		[JsonPropertyName("quality_key")]
		[Description("资质key")]
		[NotNull]
		public string QualityKey { get; set; }

		[JsonPropertyName("quality_name")]
		[Description("资质名称")]
		[NotNull]
		public string QualityName { get; set; }

		[JsonPropertyName("quality_attachments")]
		[Description("资质")]
		[NotNull]
		public List<QualityAttachmentsItem> QualityAttachments { get; set; }

		public class QualityAttachmentsItem
		{
			[JsonPropertyName("media_type")]
			[Description("1-图片，2-pdf")]
			[NotNull]
			public long? MediaType { get; set; }

			[JsonPropertyName("url")]
			[Description("凭证url")]
			[NotNull]
			public string Url { get; set; }
		}
	}

	[JsonPropertyName("spec_name")]
	[Description("规格名为各级规格名用 ,-, 分割")]
	[NotNull]
	public string SpecName { get; set; }

	[JsonPropertyName("specs")]
	[Description("通用规格，能被同类商品通用。多规格用^分隔，规格与规格值用|分隔，多个规格值用,分隔。")]
	[NotNull]
	public string Specs { get; set; }

	[JsonPropertyName("spec_prices")]
	[Description("sku详情，只支持全量编辑, 否则会视为删除,  对于非新增的sku,不支持同时编辑价格或库存, 编辑已有sku注意传递内外部id, 供销平台的id是数字")]
	[NotNull]
	public string SpecPrices { get; set; }

	[JsonPropertyName("spec_pic")]
	[Description("如颜色-尺寸, 颜色就是主规格, 颜色如黑,白,黄,它们图片url以逗号分隔 注：,pic,、,description,、,spec_pic,这三个字段里的传入的图片数量总和，不得超过50张。")]
	public string SpecPic { get; set; }

	[JsonPropertyName("product_format_new")]
	[Description("类目属性")]
	[NotNull]
	public string ProductFormatNew { get; set; }

	[JsonPropertyName("spu_id")]
	[Description("spu_id")]
	public long? SpuId { get; set; }

	[JsonPropertyName("extends")]
	[Description("扩展信息")]
	public Dictionary<string,string> Extends { get; set; }

	[JsonPropertyName("outer_product_id")]
	[Description("外部product id")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("standard_brand_id")]
	[Description("品牌id，通过/supplyProduct/getSupplyProductUpdateRule获取，无品牌id则传596120136")]
	public long? StandardBrandId { get; set; }

	[JsonPropertyName("white_back_ground_pic_url")]
	[Description("白底图url")]
	public string WhiteBackGroundPicUrl { get; set; }

	[JsonPropertyName("long_pic_url")]
	[Description("3:4长图url")]
	public string LongPicUrl { get; set; }
}

[Description("产品编辑，编辑规则请查看/supplyProduct/getSupplyProductUpdateRule")]
public class SupplyChainSupplyProductEditRsp
{
	[JsonPropertyName("product_id")]
	[Description("供应链产品id")]
	public long ProductId { get; set; }

	[JsonPropertyName("outer_product_id")]
	[Description("外部产品编码")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("sku_list")]
	[Description("sku列表")]
	public List<SkuListItem> SkuList { get; set; }

	public class SkuListItem
	{
		[JsonPropertyName("outer_sku_id")]
		[Description("外部skuid")]
		public string OuterSkuId { get; set; }

		[JsonPropertyName("sku_id")]
		[Description("供应链skuid")]
		public long SkuId { get; set; }
	}
}
