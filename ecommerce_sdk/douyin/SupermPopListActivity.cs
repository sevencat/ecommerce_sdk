namespace ecommerce.sdk.douyin;

[Description("查看小时达活动列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数不合法","isv.parameter-invalid:40100","参数不合法")]
[DouyinRetCode(40004,"非法的参数","操作不合法","isv.parameter-invalid:50100","操作不合法")]
[DouyinRetCode(50002,"业务处理失败","系统异常","isv.business-failed:20100","系统异常")]
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
public class SupermPopListActivityReq : IDouyinReq<SupermPopListActivityRsp>
{

	public string GetMethod() { return "superm.pop.listActivity"; }

	public string GetUrl() { return "/superm/pop/listActivity"; }

	[JsonPropertyName("page")]
	[Description("页码")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页条目数，最大10")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("title")]
	[Description("活动名称")]
	public string Title { get; set; }

	[JsonPropertyName("status")]
	[Description("活动状态,0：创建中,50：未开始,51：进行中,52：已结束,70：已失效,不传：全部")]
	public int? Status { get; set; }

	[JsonPropertyName("shop_stype")]
	[Description("优惠方式 ,1：一口价,不传：查询全部（保留功能，暂不支持）")]
	public int? ShopStype { get; set; }

	[JsonPropertyName("business_code")]
	[Description("业务类型,OrdinaryTimeBuy：直降促销,不传：查询全部（保留功能，暂不支持）")]
	public string BusinessCode { get; set; }

	[JsonPropertyName("activity_type")]
	[Description("活动类型,7：限时限量购,不传：查询全部（保留功能，暂不支持）")]
	public int? ActivityType { get; set; }

	[JsonPropertyName("with_products")]
	[Description("是否同时查询商品信息（同时查询商品信息会提高接口RT，如无必要，请置false）")]
	public bool? WithProducts { get; set; }

	[JsonPropertyName("sd_activity_ids")]
	[Description("商达活动id列表")]
	public List<string> SdActivityIds { get; set; }
}

[Description("查看小时达活动列表")]
public class SupermPopListActivityRsp
{
	[JsonPropertyName("activities")]
	[Description("活动列表")]
	public List<ActivitiesItem> Activities { get; set; }

	public class ActivitiesItem
	{
		[JsonPropertyName("sd_activity_id")]
		[Description("商达活动id")]
		public string SdActivityId { get; set; }

		[JsonPropertyName("activity_type")]
		[Description("活动类型")]
		public int ActivityType { get; set; }

		[JsonPropertyName("title")]
		[Description("活动名称")]
		public string Title { get; set; }

		[JsonPropertyName("time_set_type")]
		[Description("时间类型,0：按起止时间,1：时间段")]
		public int TimeSetType { get; set; }

		[JsonPropertyName("begin_time")]
		[Description("活动开始时间，时间戳（秒）")]
		public long BeginTime { get; set; }

		[JsonPropertyName("end_time")]
		[Description("活动结束时间，时间戳（秒）")]
		public long EndTime { get; set; }

		[JsonPropertyName("order_expire_time")]
		[Description("订单取消时间，秒")]
		public long OrderExpireTime { get; set; }

		[JsonPropertyName("sold_out_type")]
		[Description("动库存售罄设置，0恢复原价，1停止售卖")]
		public int SoldOutType { get; set; }

		[JsonPropertyName("warm_up")]
		[Description("是否预热,0：否")]
		public int WarmUp { get; set; }

		[JsonPropertyName("shop_stype")]
		[Description("优惠方式 ,1：一口价")]
		public int ShopStype { get; set; }

		[JsonPropertyName("business_code")]
		[Description("业务码,OrdinaryTimeBuy：直降促销")]
		public string BusinessCode { get; set; }

		[JsonPropertyName("lock_stock")]
		[Description("是否设置活动库存,0：设置,1：不设置")]
		public int LockStock { get; set; }

		[JsonPropertyName("activity_status")]
		[Description("活动状态,0：创建中,50：未开始,51：进行中,52：已结束,70：已失效")]
		public int ActivityStatus { get; set; }

		[JsonPropertyName("failed_store_count")]
		[Description("活动创建失败门店数")]
		public long FailedStoreCount { get; set; }

		[JsonPropertyName("main_products")]
		[Description("主商品信息")]
		public List<MainProductsItem> MainProducts { get; set; }

		public class MainProductsItem
		{
			[JsonPropertyName("product_id")]
			[Description("商品ID")]
			public string ProductId { get; set; }

			[JsonPropertyName("config_scope")]
			[Description("配置范围,0：sku")]
			public int ConfigScope { get; set; }

			[JsonPropertyName("skus")]
			[Description("主商品sku列表")]
			public List<SkusItem> Skus { get; set; }

			public class SkusItem
			{
				[JsonPropertyName("sku_id")]
				[Description("skuId")]
				public string SkuId { get; set; }

				[JsonPropertyName("specification")]
				[Description("sku名")]
				public string Specification { get; set; }

				[JsonPropertyName("img")]
				[Description("sku图")]
				public string Img { get; set; }

				[JsonPropertyName("success_store_count")]
				[Description("生效门店数")]
				public long SuccessStoreCount { get; set; }

				[JsonPropertyName("failed_store_count")]
				[Description("失败门店数")]
				public long FailedStoreCount { get; set; }

				[JsonPropertyName("process_store_count")]
				[Description("处理中门店数")]
				public long ProcessStoreCount { get; set; }

				[JsonPropertyName("disabled_store_count")]
				[Description("失效门店数")]
				public long DisabledStoreCount { get; set; }

				[JsonPropertyName("detail_status")]
				[Description("商品参加活动的详细状态,1：创建中,2：创建成功,3：作废,4：创建失败,5：部分创建成功")]
				public int DetailStatus { get; set; }

				[JsonPropertyName("sub_skus")]
				[Description("子品列表")]
				public List<SubSkusItem> SubSkus { get; set; }

				public class SubSkusItem
				{
					[JsonPropertyName("sku_id")]
					[Description("skuId")]
					public string SkuId { get; set; }

					[JsonPropertyName("camp_stock_num")]
					[Description("活动库存")]
					public long CampStockNum { get; set; }

					[JsonPropertyName("discount_value")]
					[Description("活动优惠信息,对于一口价优惠方式：金额，单位分")]
					public long DiscountValue { get; set; }

					[JsonPropertyName("user_limit")]
					[Description("每人限购")]
					public long UserLimit { get; set; }

					[JsonPropertyName("specification")]
					[Description("sku名")]
					public string Specification { get; set; }

					[JsonPropertyName("img")]
					[Description("sku图")]
					public string Img { get; set; }

					[JsonPropertyName("origin_price")]
					[Description("原价，单位分")]
					public long OriginPrice { get; set; }

					[JsonPropertyName("stock")]
					[Description("当前库存")]
					public long Stock { get; set; }

					[JsonPropertyName("camp_left_stock_num")]
					[Description("活动剩余库存")]
					public long CampLeftStockNum { get; set; }

					[JsonPropertyName("spec_id")]
					[Description("规格属性")]
					public long SpecId { get; set; }

					[JsonPropertyName("spec_detail_id1")]
					[Description("规格属性")]
					public long SpecDetailId1 { get; set; }

					[JsonPropertyName("spec_detail_id2")]
					[Description("规格属性")]
					public long SpecDetailId2 { get; set; }

					[JsonPropertyName("spec_detail_id3")]
					[Description("规格属性")]
					public long SpecDetailId3 { get; set; }

					[JsonPropertyName("product_id")]
					[Description("商品id")]
					public string ProductId { get; set; }

					[JsonPropertyName("product_img")]
					[Description("商品主图")]
					public string ProductImg { get; set; }

					[JsonPropertyName("product_name")]
					[Description("商品名")]
					public string ProductName { get; set; }

					[JsonPropertyName("main_product_id")]
					[Description("主商品id")]
					public long MainProductId { get; set; }

					[JsonPropertyName("main_sku_id")]
					[Description("主商品skuid")]
					public long MainSkuId { get; set; }

					[JsonPropertyName("store")]
					[Description("门店信息")]
					public StoreItem Store { get; set; }

					public class StoreItem
					{
						[JsonPropertyName("store_id")]
						[Description("门店id")]
						public string StoreId { get; set; }

						[JsonPropertyName("name")]
						[Description("门店名")]
						public string Name { get; set; }

						[JsonPropertyName("store_code")]
						[Description("门店编码")]
						public string StoreCode { get; set; }

						[JsonPropertyName("rel_shop_id")]
						[Description("所属店铺ID")]
						public string RelShopId { get; set; }

						[JsonPropertyName("province")]
						[Description("省")]
						public string Province { get; set; }

						[JsonPropertyName("city")]
						[Description("市")]
						public string City { get; set; }

						[JsonPropertyName("district")]
						[Description("区")]
						public string District { get; set; }

						[JsonPropertyName("town")]
						[Description("4级地址 街道/镇")]
						public string Town { get; set; }

						[JsonPropertyName("address")]
						[Description("详细地址")]
						public string Address { get; set; }

						[JsonPropertyName("contact")]
						[Description("联系方式")]
						public string Contact { get; set; }
					}

					[JsonPropertyName("detail_status")]
					[Description("商品参加活动的详细状态,1：创建中,2：创建成功,3：作废,4：创建失败,5：部分创建成功")]
					public int DetailStatus { get; set; }

					[JsonPropertyName("detail_status_reason")]
					[Description("商品参加活动的详细状态说明")]
					public string DetailStatusReason { get; set; }
				}
			}

			[JsonPropertyName("name")]
			[Description("商品名")]
			public string Name { get; set; }

			[JsonPropertyName("img")]
			[Description("商品图")]
			public string Img { get; set; }
		}
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
