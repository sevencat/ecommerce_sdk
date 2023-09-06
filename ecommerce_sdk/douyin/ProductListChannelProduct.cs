namespace ecommerce.sdk.douyin;

[Description("检索渠道商品")]
public class ProductListChannelProductReq : IDouyinReq<ProductListChannelProductRsp>
{

	public string GetMethod() { return "product.listChannelProduct"; }

	public string GetUrl() { return "/product/listChannelProduct"; }

	[JsonPropertyName("main_product_id")]
	[Description("主商品ID。不需要此查询条件可传0")]
	[NotNull]
	public long? MainProductId { get; set; }

	[JsonPropertyName("channel_id")]
	[Description("渠道ID")]
	public List<long> ChannelId { get; set; }

	[JsonPropertyName("channel_type")]
	[Description("渠道类型：3商家自卖，4达人带货")]
	public List<long> ChannelType { get; set; }

	[JsonPropertyName("kol_id")]
	[Description("绑定的达人ID")]
	public List<long> KolId { get; set; }

	[JsonPropertyName("status")]
	[Description("渠道品状态：0下架，2上架，3封禁")]
	public long? Status { get; set; }

	[JsonPropertyName("start_time")]
	[Description("有效期开始时间")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("有效期结束时间")]
	public string EndTime { get; set; }

	[JsonPropertyName("page")]
	[Description("第几页，从1开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页数量，默认20，最多50")]
	[NotNull]
	public long? Size { get; set; }
}

[Description("检索渠道商品")]
public class ProductListChannelProductRsp
{
	[JsonPropertyName("data")]
	[Description("渠道品列表")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("name")]
		[Description("渠道品标题")]
		public string Name { get; set; }

		[JsonPropertyName("main_product_id")]
		[Description("主商品ID")]
		public long MainProductId { get; set; }

		[JsonPropertyName("channel_id")]
		[Description("渠道ID")]
		public long ChannelId { get; set; }

		[JsonPropertyName("channel_type")]
		[Description("渠道类型")]
		public long ChannelType { get; set; }

		[JsonPropertyName("start_time")]
		[Description("有效期开始时间")]
		public string StartTime { get; set; }

		[JsonPropertyName("end_time")]
		[Description("有效期结束时间")]
		public string EndTime { get; set; }

		[JsonPropertyName("status")]
		[Description("渠道品状态,0：下架,2：上架,3：封禁")]
		public long Status { get; set; }

		[JsonPropertyName("kol_info")]
		[Description("绑定达人信息")]
		public KolInfoItem KolInfo { get; set; }

		public class KolInfoItem
		{
			[JsonPropertyName("bind_kol_num")]
			[Description("绑定达人数量")]
			public long BindKolNum { get; set; }

			[JsonPropertyName("bind_all")]
			[Description("绑定所有")]
			public bool BindAll { get; set; }
		}
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }

	[JsonPropertyName("page")]
	[Description("当前页面数")]
	public long Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页数目大小")]
	public long Size { get; set; }

	[JsonPropertyName("main_img_material")]
	[Description("渠道品主图信息")]
	public MainImgMaterialItem MainImgMaterial { get; set; }

	public class MainImgMaterialItem
	{
		[JsonPropertyName("material_type")]
		[Description("素材类型，主图为18")]
		public long MaterialType { get; set; }

		[JsonPropertyName("reject_reason")]
		[Description("审核驳回原因")]
		public string RejectReason { get; set; }

		[JsonPropertyName("material_status")]
		[Description("素材状态,0：草稿,1：审核中,2：审核通过,3：审核拒绝")]
		public long MaterialStatus { get; set; }
	}

	[JsonPropertyName("detail_brief_material")]
	[Description("渠道品详情图信息")]
	public DetailBriefMaterialItem DetailBriefMaterial { get; set; }

	public class DetailBriefMaterialItem
	{
		[JsonPropertyName("material_status")]
		[Description("素材状态,0：草稿,1：审核中,2：审核通过,3：审核拒绝")]
		public long MaterialStatus { get; set; }

		[JsonPropertyName("reject_reason")]
		[Description("审核驳回原因")]
		public string RejectReason { get; set; }

		[JsonPropertyName("material_type")]
		[Description("素材类型，详情图为28")]
		public long MaterialType { get; set; }
	}
}
