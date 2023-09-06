namespace ecommerce.sdk.douyin;

[Description("使用此接口厂商可以查询所有的已绑定的商家的店铺列表，按申请时间倒序排列")]
public class IopGetSellerListReq : IDouyinReq<IopGetSellerListRsp>
{

	public string GetMethod() { return "iop.getSellerList"; }

	public string GetUrl() { return "/iop/getSellerList"; }

	[JsonPropertyName("page")]
	[Description("返回页码，页码从 0 开始 PS：当前采用分页返回，数量和页数会一起传")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("返回数量，最大 100")]
	public long? PageSize { get; set; }

	[JsonPropertyName("bind_status")]
	[Description("绑定状态（未知-0、申请绑定待审核-1、已通过-2、已拒绝-3、已解绑-4、申请解绑待审核-5）")]
	public List<int> BindStatus { get; set; }
}

[Description("使用此接口厂商可以查询所有的已绑定的商家的店铺列表，按申请时间倒序排列")]
public class IopGetSellerListRsp
{
	[JsonPropertyName("seller_shop_list")]
	[Description("绑定列表")]
	public List<SellerShopListItem> SellerShopList { get; set; }

	public class SellerShopListItem
	{
		[JsonPropertyName("seller_shop_id")]
		[Description("绑定的商家店铺id")]
		public long SellerShopId { get; set; }

		[JsonPropertyName("apply_time")]
		[Description("申请时间，秒")]
		public long ApplyTime { get; set; }

		[JsonPropertyName("band_time")]
		[Description("绑定时间，秒")]
		public long BandTime { get; set; }

		[JsonPropertyName("refuse_time")]
		[Description("拒绝时间，秒")]
		public long RefuseTime { get; set; }

		[JsonPropertyName("seller_shop_name")]
		[Description("商家店铺名称")]
		public string SellerShopName { get; set; }

		[JsonPropertyName("bind_status")]
		[Description("绑定状态（未知-0、申请绑定待审核-1、已通过-2、已拒绝-3、已解绑-4、申请解绑待审核-5）")]
		public int BindStatus { get; set; }
	}

	[JsonPropertyName("page_size")]
	[Description("返回数量，最大 100")]
	public long PageSize { get; set; }

	[JsonPropertyName("total")]
	[Description("总绑定数")]
	public long Total { get; set; }

	[JsonPropertyName("page")]
	[Description("返回页码，页码从 0 开始 PS：当前采用分页返回，数量和页数会一起传")]
	public long Page { get; set; }
}
