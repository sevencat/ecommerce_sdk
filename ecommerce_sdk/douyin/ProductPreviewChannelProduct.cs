namespace ecommerce.sdk.douyin;

[Description("预览渠道品信息")]
public class ProductPreviewChannelProductReq : IDouyinReq<ProductPreviewChannelProductRsp>
{

	public string GetMethod() { return "product.previewChannelProduct"; }

	public string GetUrl() { return "/product/previewChannelProduct"; }

	[JsonPropertyName("main_product_id")]
	[Description("主商品ID")]
	[NotNull]
	public long? MainProductId { get; set; }

	[JsonPropertyName("channel_id")]
	[Description("渠道ID")]
	[NotNull]
	public long? ChannelId { get; set; }

	[JsonPropertyName("channel_type")]
	[Description("渠道类型")]
	[NotNull]
	public long? ChannelType { get; set; }
}

[Description("预览渠道品信息")]
public class ProductPreviewChannelProductRsp
{
	[JsonPropertyName("main_product_id")]
	[Description("主商品ID")]
	public long MainProductId { get; set; }

	[JsonPropertyName("channel_id")]
	[Description("渠道ID")]
	public long ChannelId { get; set; }

	[JsonPropertyName("channel_type")]
	[Description("渠道类型")]
	public long ChannelType { get; set; }

	[JsonPropertyName("name")]
	[Description("渠道品标题")]
	public string Name { get; set; }

	[JsonPropertyName("start_time")]
	[Description("有效期开始时间")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("有效期结束时间")]
	public string EndTime { get; set; }

	[JsonPropertyName("price_follow_main")]
	[Description("价格是否跟随主品")]
	public bool PriceFollowMain { get; set; }

	[JsonPropertyName("share_main_stock")]
	[Description("库存是否与主品共享")]
	public bool ShareMainStock { get; set; }

	[JsonPropertyName("is_kol_exclusive")]
	[Description("是否『达人专属』渠道品")]
	public bool IsKolExclusive { get; set; }

	[JsonPropertyName("status")]
	[Description("渠道品状态,0：下架,2：上架,3：封禁")]
	public long Status { get; set; }

	[JsonPropertyName("channel_buy_limit")]
	[Description("限购信息")]
	public ChannelBuyLimitItem ChannelBuyLimit { get; set; }

	public class ChannelBuyLimitItem
	{
		[JsonPropertyName("total_buy_num")]
		[Description("每用户总限购数")]
		public long TotalBuyNum { get; set; }

		[JsonPropertyName("max_buy_num")]
		[Description("单次购买上限")]
		public long MaxBuyNum { get; set; }

		[JsonPropertyName("min_buy_num")]
		[Description("单次限购下限")]
		public long MinBuyNum { get; set; }
	}

	[JsonPropertyName("sku_channel")]
	[Description("SKU信息")]
	public List<SkuChannelItem> SkuChannel { get; set; }

	public class SkuChannelItem
	{
		[JsonPropertyName("sku_id")]
		[Description("主品SKU ID")]
		public long SkuId { get; set; }

		[JsonPropertyName("name")]
		[Description("SKU名称")]
		public string Name { get; set; }

		[JsonPropertyName("sku_channel")]
		[Description("渠道品SKU")]
		public SkuChannelIItem SkuChannelI { get; set; }

		public class SkuChannelIItem
		{
			[JsonPropertyName("code")]
			[Description("渠道品定制SKU商家编码。可忽略，默认使用主商品SKU商家编码。")]
			public string Code { get; set; }

			[JsonPropertyName("sku_id")]
			[Description("主品SKU ID")]
			public long SkuId { get; set; }

			[JsonPropertyName("price")]
			[Description("渠道品SKU价格")]
			public long Price { get; set; }

			[JsonPropertyName("stock_num")]
			[Description("渠道品SKU库存")]
			public long StockNum { get; set; }
		}

		[JsonPropertyName("sku_main")]
		[Description("主品SKU")]
		public SkuMainItem SkuMain { get; set; }

		public class SkuMainItem
		{
			[JsonPropertyName("price")]
			[Description("主品SKU价格")]
			public long Price { get; set; }

			[JsonPropertyName("stock")]
			[Description("主品SKU库存")]
			public long Stock { get; set; }
		}

		[JsonPropertyName("status")]
		[Description("SKU状态,0：渠道品有该SKU,1：渠道品无该SKU")]
		public long Status { get; set; }
	}

	[JsonPropertyName("main_img_material")]
	[Description("渠道品主图信息")]
	public MainImgMaterialItem MainImgMaterial { get; set; }

	public class MainImgMaterialItem
	{
		[JsonPropertyName("img_list")]
		[Description("主图列表")]
		public List<string> ImgList { get; set; }

		[JsonPropertyName("material_type")]
		[Description("素材类型，主图为18")]
		public long MaterialType { get; set; }

		[JsonPropertyName("material_status")]
		[Description("素材状态,0：草稿,1：审核中,2：审核通过,3：审核拒绝")]
		public long MaterialStatus { get; set; }

		[JsonPropertyName("reject_reason")]
		[Description("审核驳回原因")]
		public string RejectReason { get; set; }
	}

	[JsonPropertyName("detail_brief_material")]
	[Description("渠道品详情图信息")]
	public DetailBriefMaterialItem DetailBriefMaterial { get; set; }

	public class DetailBriefMaterialItem
	{
		[JsonPropertyName("reject_reason")]
		[Description("审核驳回原因")]
		public string RejectReason { get; set; }

		[JsonPropertyName("material_status")]
		[Description("素材状态,0：草稿,1：审核中,2：审核通过,3：审核拒绝")]
		public long MaterialStatus { get; set; }

		[JsonPropertyName("material_type")]
		[Description("素材类型，详情图为28")]
		public long MaterialType { get; set; }

		[JsonPropertyName("img_list")]
		[Description("详情图列表")]
		public List<string> ImgList { get; set; }
	}

	[JsonPropertyName("freight_template")]
	[Description("运费模板配置")]
	public FreightTemplateItem FreightTemplate { get; set; }

	public class FreightTemplateItem
	{
		[JsonPropertyName("freight_follow_main")]
		[Description("渠道品运费模板是否与主品保持一致")]
		public bool FreightFollowMain { get; set; }

		[JsonPropertyName("freight_id")]
		[Description("渠道品定制运费模板ID，当设置了freight_follow_main=true时与主品运费模板保持一致；否则需要传值。")]
		public long FreightId { get; set; }
	}
}
