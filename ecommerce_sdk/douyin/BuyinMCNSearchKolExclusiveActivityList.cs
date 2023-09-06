namespace ecommerce.sdk.douyin;

[Description("MCN机构查询结算绑定达人某个商品的专属活动列表。注意⚠️：1. 请先通过 /buyin/MCNSearchKolExclusiveProductList 查询专属活动商品ID和店铺ID，避免无效请求；2. 平台专属活动暂不返回；3. 已失效活动不返回。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效商品ID","isv.parameter-invalid:265","无效商品ID")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","无效分页大小","isv.parameter-invalid:4097","无效分页大小")]
[DouyinRetCode(40004,"非法的参数","无效百应ID","isv.parameter-invalid:4173","无效百应ID")]
[DouyinRetCode(40004,"非法的参数","无效page","isv.parameter-invalid:4141","无效page")]
[DouyinRetCode(50002,"业务处理失败","仅支持抖音、火山达人","isv.business-failed:4397","仅支持抖音、火山达人")]
[DouyinRetCode(50002,"业务处理失败","请确认结算绑定关系","isv.business-failed:4396","请确认结算绑定关系")]
public class BuyinMCNSearchKolExclusiveActivityListReq : IDouyinReq<BuyinMCNSearchKolExclusiveActivityListRsp>
{

	public string GetMethod() { return "buyin.MCNSearchKolExclusiveActivityList"; }

	public string GetUrl() { return "/buyin/MCNSearchKolExclusiveActivityList"; }

	[JsonPropertyName("kol_buyin_id")]
	[Description("具有结算绑定关系的达人百应ID")]
	[NotNull]
	public string KolBuyinId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品ID。请通过 /buyin/MCNSearchKolExclusiveProductList 接口查询商品ID")]
	[NotNull]
	public string ProductId { get; set; }

	[JsonPropertyName("page")]
	[Description("分页数，从1开始")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页大小，最大20")]
	public long? PageSize { get; set; }
}

[Description("MCN机构查询结算绑定达人某个商品的专属活动列表。注意⚠️：1. 请先通过 /buyin/MCNSearchKolExclusiveProductList 查询专属活动商品ID和店铺ID，避免无效请求；2. 平台专属活动暂不返回；3. 已失效活动不返回。")]
public class BuyinMCNSearchKolExclusiveActivityListRsp
{
	[JsonPropertyName("activity_infos")]
	[Description("活动列表（暂不返回平台活动，仅返回商家专属活动）")]
	public List<ActivityInfosItem> ActivityInfos { get; set; }

	public class ActivityInfosItem
	{
		[JsonPropertyName("shop_id")]
		[Description("店铺ID")]
		public long ShopId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public string ProductId { get; set; }

		[JsonPropertyName("kol_buyin_id")]
		[Description("达人百应ID")]
		public string KolBuyinId { get; set; }

		[JsonPropertyName("skus")]
		[Description("SKU列表")]
		public List<SkusItem> Skus { get; set; }

		public class SkusItem
		{
			[JsonPropertyName("sku_id")]
			[Description("SKU ID")]
			public string SkuId { get; set; }

			[JsonPropertyName("shop_id")]
			[Description("店铺ID")]
			public long ShopId { get; set; }

			[JsonPropertyName("price")]
			[Description("专属价，单位分")]
			public long Price { get; set; }

			[JsonPropertyName("original_price")]
			[Description("原价，单位分")]
			public long OriginalPrice { get; set; }

			[JsonPropertyName("source_stock_num")]
			[Description("当前sku的总库存")]
			public long SourceStockNum { get; set; }

			[JsonPropertyName("remaining_stock_num")]
			[Description("达人将商家分配的库存中的部分上架，这部分上架的库存剩余库存数")]
			public long RemainingStockNum { get; set; }

			[JsonPropertyName("stock_num")]
			[Description("商家分配给达人的原始库存（商品售出后不会变更）")]
			public long StockNum { get; set; }
		}

		[JsonPropertyName("status")]
		[Description("1： 未生效 2： 生效中")]
		public long Status { get; set; }

		[JsonPropertyName("begin_time")]
		[Description("开始时间")]
		public string BeginTime { get; set; }

		[JsonPropertyName("end_time")]
		[Description("结束时间")]
		public string EndTime { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("活动数")]
	public long Total { get; set; }
}
