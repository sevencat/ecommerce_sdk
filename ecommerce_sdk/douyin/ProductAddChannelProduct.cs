namespace ecommerce.sdk.douyin;

[Description("为主商品创建销售渠道商品")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","达人专属配置不支持库存与主品共享","isv.parameter-invalid:400002","取消勾选库存共享，设置库存信息")]
[DouyinRetCode(40004,"非法的参数","精选联盟权限校验失败","isv.parameter-invalid:400001","请按返回的详细错误信息处理")]
[DouyinRetCode(40004,"非法的参数","渠道主商品为在线审核通过状态才可以创建","isv.parameter-invalid:101045","变更主商品状态")]
[DouyinRetCode(40004,"非法的参数","不支持该商品类型创建渠道品","isv.parameter-invalid:101046","暂不支持奖品、拍卖商品、非卖品、保证金品、闪购商品、定金找货、保险业务等主商品创建渠道品")]
[DouyinRetCode(40004,"非法的参数","渠道商详链接不合法","isv.parameter-invalid:2010001","请检查商详图片链接格式以及是否可用")]
[DouyinRetCode(40004,"非法的参数","开始时间解析异常","isv.parameter-invalid:2010004","请检查开始时间格式")]
[DouyinRetCode(40004,"非法的参数","仅达人带货渠道品可设置达人专属","isv.parameter-invalid:110101051","仅达人带货渠道品可设置达人专属")]
public class ProductAddChannelProductReq : IDouyinReq<ProductAddChannelProductRsp>
{

	public string GetMethod() { return "product.addChannelProduct"; }

	public string GetUrl() { return "/product/addChannelProduct"; }

	[JsonPropertyName("main_product_id")]
	[Description("主商品ID")]
	[NotNull]
	public long? MainProductId { get; set; }

	[JsonPropertyName("channel_type")]
	[Description("渠道类型,3：商家自卖,4：达人带货")]
	[NotNull]
	public long? ChannelType { get; set; }

	[JsonPropertyName("name")]
	[Description("渠道品定制标题。必填")]
	public string Name { get; set; }

	[JsonPropertyName("main_img_list")]
	[Description("渠道品定制主图，最高支持5张。可省略，默认使用主商品主图列表")]
	public List<string> MainImgList { get; set; }

	[JsonPropertyName("start_time")]
	[Description("有效期开始时间。不填开始和结束时间，代表长期有效")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("有效期结束时间。不填开始和结束时间，代表长期有效")]
	public string EndTime { get; set; }

	[JsonPropertyName("price_follow_main")]
	[Description("渠道品SKU价格是否跟随主品")]
	[NotNull]
	public bool? PriceFollowMain { get; set; }

	[JsonPropertyName("share_main_stock")]
	[Description("渠道品SKU库存是否与主商品共享库存")]
	[NotNull]
	public bool? ShareMainStock { get; set; }

	[JsonPropertyName("is_kol_exclusive")]
	[Description("是否『达人专属』渠道品")]
	[NotNull]
	public bool? IsKolExclusive { get; set; }

	[JsonPropertyName("channel_buy_limit")]
	[Description("渠道品限购信息")]
	public ChannelBuyLimitItem ChannelBuyLimit { get; set; }

	public class ChannelBuyLimitItem
	{
		[JsonPropertyName("total_buy_num")]
		[Description("单用户累计购买上限数")]
		public long? TotalBuyNum { get; set; }

		[JsonPropertyName("max_buy_num")]
		[Description("每次购买上限数")]
		public long? MaxBuyNum { get; set; }

		[JsonPropertyName("min_buy_num")]
		[Description("每次至少购买数")]
		public long? MinBuyNum { get; set; }
	}

	[JsonPropertyName("sku_channel")]
	[Description("渠道SKU相关信息")]
	[NotNull]
	public List<SkuChannelItem> SkuChannel { get; set; }

	public class SkuChannelItem
	{
		[JsonPropertyName("stock_set_mode")]
		[Description("库存编辑模式，0=设置绝对值，1=增量设置")]
		public int? StockSetMode { get; set; }

		[JsonPropertyName("code")]
		[Description("渠道品定制SKU商家编码。可忽略，默认使用主商品SKU商家编码。")]
		public string Code { get; set; }

		[JsonPropertyName("sku_id")]
		[Description("主商品SkuID")]
		[NotNull]
		public long? SkuId { get; set; }

		[JsonPropertyName("price")]
		[Description("价格，单位分。设置价格跟随主品时，可不填")]
		public long? Price { get; set; }

		[JsonPropertyName("stock_num")]
		[Description("库存，勿大于主SKU的可售库存。设置库存与主商品共享时，可不填")]
		public long? StockNum { get; set; }
	}

	[JsonPropertyName("detail_brief_img")]
	[Description("渠道品定制详情图，最高支持50张。可省略，默认使用主商品详情图列表")]
	public List<string> DetailBriefImg { get; set; }

	[JsonPropertyName("freight_template")]
	[Description("运费模板信息")]
	public FreightTemplateItem FreightTemplate { get; set; }

	public class FreightTemplateItem
	{
		[JsonPropertyName("freight_follow_main")]
		[Description("渠道品运费模板是否与主品保持一致")]
		public bool? FreightFollowMain { get; set; }

		[JsonPropertyName("freight_id")]
		[Description("渠道品定制运费模板ID，当设置了freight_follow_main=true时与主品运费模板保持一致；否则需要传值。")]
		public long? FreightId { get; set; }
	}
}

[Description("为主商品创建销售渠道商品")]
public class ProductAddChannelProductRsp
{
	[JsonPropertyName("shop_id")]
	[Description("店铺ID")]
	public long ShopId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("主商品ID")]
	public long ProductId { get; set; }

	[JsonPropertyName("channel")]
	[Description("渠道信息")]
	public ChannelItem Channel { get; set; }

	public class ChannelItem
	{
		[JsonPropertyName("channel_type")]
		[Description("渠道类型（3：商家自卖，4：达人带货）")]
		public long ChannelType { get; set; }

		[JsonPropertyName("channel_id")]
		[Description("渠道ID")]
		public long ChannelId { get; set; }
	}

	[JsonPropertyName("is_kol_exclusive")]
	[Description("是否『达人专属』渠道品")]
	public bool IsKolExclusive { get; set; }
}
