namespace ecommerce.sdk.douyin;

[Description("【商家】查询厂商管理列表,【商家】查询厂商管理列表")]
public class IopSellerSupplierListReq : IDouyinReq<IopSellerSupplierListRsp>
{

	public string GetMethod() { return "iop.sellerSupplierList"; }

	public string GetUrl() { return "/iop/sellerSupplierList"; }

	[JsonPropertyName("page")]
	[Description("返回页码，页码从 0 开始 PS：当前采用分页返回，数量和页数会一起传")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("返回数量，最大 100")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("bind_status")]
	[Description("绑定状态（未知-0、待审核-1、已通过-2、已拒绝-3、已解绑-4）")]
	public List<int> BindStatus { get; set; }
}

[Description("【商家】查询厂商管理列表,【商家】查询厂商管理列表")]
public class IopSellerSupplierListRsp
{
	[JsonPropertyName("supplier_shop_list")]
	[Description("绑定列表")]
	public List<SupplierShopListItem> SupplierShopList { get; set; }

	public class SupplierShopListItem
	{
		[JsonPropertyName("supplier_shop_name")]
		[Description("厂商店铺名称")]
		public string SupplierShopName { get; set; }

		[JsonPropertyName("supplier_shop_id")]
		[Description("要绑定的厂商的店铺ID")]
		public long SupplierShopId { get; set; }

		[JsonPropertyName("apply_time")]
		[Description("申请时间,秒")]
		public long ApplyTime { get; set; }

		[JsonPropertyName("band_time")]
		[Description("绑定时间,秒")]
		public long BandTime { get; set; }

		[JsonPropertyName("refuse_time")]
		[Description("拒绝时间,秒")]
		public long RefuseTime { get; set; }

		[JsonPropertyName("bind_status")]
		[Description("绑定状态（未知-0、待审核-1、已通过-2、已拒绝-3、已解绑-4）")]
		public int BindStatus { get; set; }
	}

	[JsonPropertyName("page")]
	[Description("返回页码，页码从 0 开始 PS：当前采用分页返回，数量和页数会一起传")]
	public long Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("返回数量，最大 100")]
	public long PageSize { get; set; }

	[JsonPropertyName("total")]
	[Description("总绑定数")]
	public long Total { get; set; }
}
