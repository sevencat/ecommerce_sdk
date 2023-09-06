namespace ecommerce.sdk.douyin;

[Description("MCN机构查询结算绑定的达人的专属活动商品列表，包括平台和商家的专属价活动商品。可通过/buyin/MCNSearchKolExclusiveActivityList 查询商家专属价活动列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效page","isv.parameter-invalid:4141","无效page")]
[DouyinRetCode(40004,"非法的参数","无效分页大小","isv.parameter-invalid:4097","无效分页大小")]
[DouyinRetCode(40004,"非法的参数","无效百应ID","isv.parameter-invalid:4173","无效百应ID")]
[DouyinRetCode(50002,"业务处理失败","仅支持抖音、火山达人","isv.business-failed:4397","仅支持抖音、火山达人")]
[DouyinRetCode(50002,"业务处理失败","请确认结算绑定关系","isv.business-failed:4396","请确认结算绑定关系")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
public class BuyinMCNSearchKolExclusiveProductListReq : IDouyinReq<BuyinMCNSearchKolExclusiveProductListRsp>
{

	public string GetMethod() { return "buyin.MCNSearchKolExclusiveProductList"; }

	public string GetUrl() { return "/buyin/MCNSearchKolExclusiveProductList"; }

	[JsonPropertyName("kol_buyin_id")]
	[Description("具有结算绑定关系的达人百应ID")]
	[NotNull]
	public string KolBuyinId { get; set; }

	[JsonPropertyName("page")]
	[Description("分页数，从1开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页大小，最大20")]
	[NotNull]
	public long? PageSize { get; set; }
}

[Description("MCN机构查询结算绑定的达人的专属活动商品列表，包括平台和商家的专属价活动商品。可通过/buyin/MCNSearchKolExclusiveActivityList 查询商家专属价活动列表")]
public class BuyinMCNSearchKolExclusiveProductListRsp
{
	[JsonPropertyName("kol_exclusive_product_infos")]
	[Description("专属商品列表，包括商家配置专属商品和平台专属商品")]
	public List<KolExclusiveProductInfosItem> KolExclusiveProductInfos { get; set; }

	public class KolExclusiveProductInfosItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public string ProductId { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺ID")]
		public long ShopId { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
