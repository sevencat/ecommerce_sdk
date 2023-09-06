namespace ecommerce.sdk.douyin;

[Description("保存小时达活动")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数不合法","isv.parameter-invalid:40100","参数不合法")]
[DouyinRetCode(40004,"非法的参数","操作不合法","isv.parameter-invalid:50100","操作不合法")]
[DouyinRetCode(50002,"业务处理失败","数据库访问错误","isv.business-failed:20100","数据库访问错误")]
[DouyinRetCode(50002,"业务处理失败","系统异常","isv.business-failed:20201","系统异常")]
[DouyinRetCode(50002,"业务处理失败","活动不存在","isv.business-failed:20121","活动不存在")]
[DouyinRetCode(50002,"业务处理失败","活动校验不通过","isv.business-failed:20122","活动校验不通过")]
[DouyinRetCode(50002,"业务处理失败","活动创建/更新失败","isv.business-failed:20123","活动创建/更新失败")]
[DouyinRetCode(50002,"业务处理失败","商品不存在","isv.business-failed:20124","商品不存在")]
[DouyinRetCode(50002,"业务处理失败","查询店铺信息异常","isv.business-failed:20125","查询店铺信息异常")]
[DouyinRetCode(50002,"业务处理失败","查询门店信息异常","isv.business-failed:20126","查询门店信息异常")]
[DouyinRetCode(50002,"业务处理失败","商品中心/商品服务错误","isv.business-failed:20221","商品中心/商品服务错误")]
[DouyinRetCode(50002,"业务处理失败","商达营销服务错误","isv.business-failed:20222","商达营销服务错误")]
[DouyinRetCode(50002,"业务处理失败","库存中心服务错误","isv.business-failed:20223","库存中心服务错误")]
[DouyinRetCode(50002,"业务处理失败","营销中心服务错误","isv.business-failed:20224","营销中心服务错误")]
[DouyinRetCode(50002,"业务处理失败","商品中心/商品服务错误","isv.business-failed:20225","商品中心/商品服务错误")]
public class SupermPopSaveActivityReq : IDouyinReq<SupermPopSaveActivityRsp>
{

	public string GetMethod() { return "superm.pop.saveActivity"; }

	public string GetUrl() { return "/superm/pop/saveActivity"; }

	[JsonPropertyName("activity_type")]
	[Description("活动类型,7：限时限量购")]
	[NotNull]
	public int? ActivityType { get; set; }

	[JsonPropertyName("title")]
	[Description("活动名称")]
	[NotNull]
	public string Title { get; set; }

	[JsonPropertyName("time_set_type")]
	[Description("时间类型,0：按起止时间")]
	[NotNull]
	public int? TimeSetType { get; set; }

	[JsonPropertyName("begin_time")]
	[Description("活动开始时间，时间戳（秒）")]
	[NotNull]
	public long? BeginTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("活动结束时间，时间戳（秒）")]
	[NotNull]
	public long? EndTime { get; set; }

	[JsonPropertyName("order_expire_time")]
	[Description("订单取消时间（秒）,选项：300，900，1800")]
	[NotNull]
	public long? OrderExpireTime { get; set; }

	[JsonPropertyName("sold_out_type")]
	[Description("活动库存售罄后类型,0：恢复原价,1：停止售卖")]
	public int? SoldOutType { get; set; }

	[JsonPropertyName("warm_up")]
	[Description("是否预热,0：否")]
	[NotNull]
	public int? WarmUp { get; set; }

	[JsonPropertyName("shop_stype")]
	[Description("优惠方式 ,1：一口价")]
	[NotNull]
	public int? ShopStype { get; set; }

	[JsonPropertyName("business_code")]
	[Description("业务码,OrdinaryTimeBuy：直降促销")]
	[NotNull]
	public string BusinessCode { get; set; }

	[JsonPropertyName("lock_stock")]
	[Description("是否设置活动库存,0：限制,1：不限制")]
	[NotNull]
	public int? LockStock { get; set; }

	[JsonPropertyName("main_skus")]
	[Description("主商品sku信息列表")]
	[NotNull]
	public List<MainSkusItem> MainSkus { get; set; }

	public class MainSkusItem
	{
		[JsonPropertyName("sku_id")]
		[Description("主品skuid")]
		[NotNull]
		public string SkuId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("主品id")]
		[NotNull]
		public string ProductId { get; set; }

		[JsonPropertyName("sub_skus")]
		[Description("子商品sku信息列表")]
		[NotNull]
		public List<SubSkusItem> SubSkus { get; set; }

		public class SubSkusItem
		{
			[JsonPropertyName("sku_id")]
			[Description("子品skuid")]
			[NotNull]
			public string SkuId { get; set; }

			[JsonPropertyName("camp_stock_num")]
			[Description("活动库存，不限制活动库存时传0")]
			[NotNull]
			public long? CampStockNum { get; set; }

			[JsonPropertyName("discount_value")]
			[Description("活动优惠信息,对于一口价的优惠方式，该字段表示金额，单位为分")]
			[NotNull]
			public long? DiscountValue { get; set; }

			[JsonPropertyName("user_limit")]
			[Description("每人限购")]
			[NotNull]
			public long? UserLimit { get; set; }

			[JsonPropertyName("product_id")]
			[Description("子品id")]
			[NotNull]
			public string ProductId { get; set; }

			[JsonPropertyName("store_id")]
			[Description("门店id")]
			[NotNull]
			public string StoreId { get; set; }
		}
	}
}

[Description("保存小时达活动")]
public class SupermPopSaveActivityRsp
{
	[JsonPropertyName("sd_activity_id")]
	[Description("商达活动id")]
	public string SdActivityId { get; set; }
}
