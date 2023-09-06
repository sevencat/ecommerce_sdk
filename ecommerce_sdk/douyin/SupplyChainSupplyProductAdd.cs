namespace ecommerce.sdk.douyin;

[Description("创建供应链产品")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","1020:参数异常，请检查后重试|缺失必填的类目属性:上市年份季节;","isv.business-failed:1020","检查后重试")]
[DouyinRetCode(50002,"业务处理失败","3200:创建分销品错误|外部货品编码 5017835326802 已被另一个spu级货品 7200578387159843107 使用, 请检查后重试","isv.business-failed:3200","检查后重试")]
[DouyinRetCode(50002,"业务处理失败","3206:规格图与主规格不匹配","isv.business-failed:3206","检查后重试")]
[DouyinRetCode(50002,"业务处理失败","3000:查询供应商错误请重试","isv.business-failed:3000","重试")]
[DouyinRetCode(50002,"业务处理失败","4003:查询仓信息错误","isv.business-failed:4003","检查后重试")]
[DouyinRetCode(50002,"业务处理失败","3202:获取产品发布规则失败","isv.business-failed:3202","重试")]
[DouyinRetCode(50002,"业务处理失败","3203:获取SPU规则失败","isv.business-failed:3203","重试")]
public class SupplyChainSupplyProductAddReq : IDouyinReq<SupplyChainSupplyProductAddRsp>
{

	public string GetMethod() { return "supplyChain.supplyProduct.add"; }

	public string GetUrl() { return "/supplyChain/supplyProduct/add"; }

	[JsonPropertyName("outer_product_id")]
	[Description("推荐使用，外部商家编码，支持字符串")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("category_leaf_id")]
	[Description("叶子类目ID通过/supplier/getSupplierCategory接口获取")]
	[NotNull]
	public long? CategoryLeafId { get; set; }

	[JsonPropertyName("name")]
	[Description("商品名称，最多60个字符(30个汉字)，不能含emoj表情")]
	[NotNull]
	public string Name { get; set; }

	[JsonPropertyName("recommend_remark")]
	[Description("商家推荐语，不能含emoj表情")]
	public string RecommendRemark { get; set; }

	[JsonPropertyName("pic")]
	[Description("商品轮播图，多张图片用 ,|, 分开，第一张图为主图，最多5张，至少600x600，大小不超过1M。")]
	[NotNull]
	public string Pic { get; set; }

	[JsonPropertyName("description")]
	[Description("商品描述，目前只支持图片。多张图片用 ,|, 分开。不能用其他网站的文本粘贴，这样会出现css样式不兼容。")]
	[NotNull]
	public string Description { get; set; }

	[JsonPropertyName("weight")]
	[Description("重量")]
	[NotNull]
	public decimal? Weight { get; set; }

	[JsonPropertyName("weight_unit")]
	[Description("重量单位，0-kg, 1-g")]
	[NotNull]
	public long? WeightUnit { get; set; }

	[JsonPropertyName("remark")]
	[Description("预留字段，供应商可见备注")]
	public string Remark { get; set; }

	[JsonPropertyName("quality_list")]
	[Description("资质，可通过/suppyProduct/GetSupplyProductUpdateRule获取")]
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
	[Description("如果不填，则规格名为各级规格名用 ,-, 自动生成")]
	public string SpecName { get; set; }

	[JsonPropertyName("specs")]
	[Description("通用规格，能被同类产品通用。多规格用^分隔，规格与规格值用|分隔，多个规格值用,分隔。")]
	[NotNull]
	public string Specs { get; set; }

	[JsonPropertyName("spec_prices")]
	[Description("sku详情，数量应该等于规格1规格2规格3，sku数量和规格组合数必须一致， sku库存数量必须大于0。suggest_retail_price表示建议零售价不能低于supply_price.stockNum因为历史原因格式是驼峰注意，incremental目前只支持传true,sync_stock_List在只有全国仓模式下也是个数组")]
	[NotNull]
	public string SpecPrices { get; set; }

	[JsonPropertyName("spec_pic")]
	[Description("如颜色-尺寸, 颜色就是主规格, 颜色如黑,白,黄,它们图片url以逗号分隔 注：,pic,、,description,、,spec_pic,这三个字段里的传入的图片数量总和，不得超过50张。")]
	public string SpecPic { get; set; }

	[JsonPropertyName("product_format_new")]
	[Description("属性，通过/supplyProduct/getSupplyProductUpdateRule获取 格式：{property_id:[{value:value,name:property_name,diy_type:0}]} name的类型是string，value和diy_type的类型是number")]
	[NotNull]
	public string ProductFormatNew { get; set; }

	[JsonPropertyName("extends")]
	[Description("扩展信息")]
	public Dictionary<string,string> Extends { get; set; }

	[JsonPropertyName("white_back_ground_pic_url")]
	[Description("素材中心url")]
	public string WhiteBackGroundPicUrl { get; set; }
}

[Description("创建供应链产品")]
public class SupplyChainSupplyProductAddRsp
{
	[JsonPropertyName("product_id")]
	[Description("product_id")]
	public long ProductId { get; set; }

	[JsonPropertyName("outer_product_id")]
	[Description("outer_product_id")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("create_time")]
	[Description("create_time")]
	public long CreateTime { get; set; }

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
