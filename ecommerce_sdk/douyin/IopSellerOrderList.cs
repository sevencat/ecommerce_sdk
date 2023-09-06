namespace ecommerce.sdk.douyin;

[Description("商家查询代发订单列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:20000","系统繁忙，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:10000","请检查参数")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:10005","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:1000","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:10008","系统繁忙，请稍后重试")]
public class IopSellerOrderListReq : IDouyinReq<IopSellerOrderListRsp>
{

	public string GetMethod() { return "iop.sellerOrderList"; }

	public string GetUrl() { return "/iop/sellerOrderList"; }

	[JsonPropertyName("start_update_time")]
	[Description("与订单成交时间段二选一传入，更新时间开始时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过半小时")]
	public long? StartUpdateTime { get; set; }

	[JsonPropertyName("end_update_time")]
	[Description("与订单成交时间段二选一传入，更新时间结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过半小时")]
	public long? EndUpdateTime { get; set; }

	[JsonPropertyName("page")]
	[Description("返回页码，页码从 0 开始 PS：当前采用分页返回，数量和页数会一起传")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("返回数量，最大 100")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("product_name")]
	[Description("商品名称，模糊查询，商家可以根据商品筛选所有的订单，分配给某个厂商")]
	public string ProductName { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	public string ProductId { get; set; }

	[JsonPropertyName("shop_order_id")]
	[Description("店铺订单号（父订单号）")]
	public string ShopOrderId { get; set; }

	[JsonPropertyName("order_status")]
	[Description("订单状态 101-部分发货 2-备货中 3-已发货 4-已关闭 5-已完成")]
	public int? OrderStatus { get; set; }

	[JsonPropertyName("distr_order_id")]
	[Description("代打订单号")]
	public string DistrOrderId { get; set; }

	[JsonPropertyName("distr_status")]
	[Description("分配状态0-未分配 1-已经分配 2-已回传 3-已取消")]
	public int? DistrStatus { get; set; }

	[JsonPropertyName("after_sale_status")]
	[Description("售后状态 1-无售后 2-售后中")]
	public int? AfterSaleStatus { get; set; }

	[JsonPropertyName("supplier_shop_id")]
	[Description("绑定的厂商的店铺ID")]
	public long? SupplierShopId { get; set; }

	[JsonPropertyName("province_id")]
	[Description("省ID")]
	public string ProvinceId { get; set; }

	[JsonPropertyName("start_deal_time")]
	[Description("与更新时间段二选一传入，订单成交开始时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总毫秒数 PS：开始时间结束时间间距不超过半小时")]
	public long? StartDealTime { get; set; }

	[JsonPropertyName("end_deal_time")]
	[Description("与更新时间段二选一传入，订单成交结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总毫秒数 PS：开始时间结束时间间距不超过半小时")]
	public long? EndDealTime { get; set; }
}

[Description("商家查询代发订单列表")]
public class IopSellerOrderListRsp
{
	[JsonPropertyName("distr_order_list")]
	[Description("代打订单列表")]
	public List<DistrOrderListItem> DistrOrderList { get; set; }

	public class DistrOrderListItem
	{
		[JsonPropertyName("distr_order_id")]
		[Description("代打订单号")]
		public string DistrOrderId { get; set; }

		[JsonPropertyName("shop_order_id")]
		[Description("店铺订单号（父订单号）")]
		public string ShopOrderId { get; set; }

		[JsonPropertyName("order_status")]
		[Description("订单状态  2-备货中 3-已发货 4-已关闭 5-已完成")]
		public long OrderStatus { get; set; }

		[JsonPropertyName("distr_status")]
		[Description("分配状态0-未分配 1-已经分配 2-已回传 3-已取消")]
		public long DistrStatus { get; set; }

		[JsonPropertyName("distr_time")]
		[Description("分配时间 时间戳 单位秒")]
		public long DistrTime { get; set; }

		[JsonPropertyName("after_sale_status")]
		[Description("售后状态 1-无售后 2-售后中")]
		public int AfterSaleStatus { get; set; }

		[JsonPropertyName("supplier_shop_id")]
		[Description("要绑定的厂商的店铺ID")]
		public long SupplierShopId { get; set; }

		[JsonPropertyName("supplier_shop_name")]
		[Description("厂商店铺名称")]
		public string SupplierShopName { get; set; }

		[JsonPropertyName("exp_ship_time")]
		[Description("承诺发货时间，单位秒")]
		public long ExpShipTime { get; set; }

		[JsonPropertyName("pay_time")]
		[Description("支付时间，单位秒")]
		public long PayTime { get; set; }

		[JsonPropertyName("seller_words")]
		[Description("商家备注")]
		public string SellerWords { get; set; }

		[JsonPropertyName("product_name")]
		[Description("商品名称")]
		public string ProductName { get; set; }

		[JsonPropertyName("product_count")]
		[Description("商品数量")]
		public long ProductCount { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public string ProductId { get; set; }

		[JsonPropertyName("product_price")]
		[Description("商品价格 单位分")]
		public long ProductPrice { get; set; }

		[JsonPropertyName("sku_spec")]
		[Description("规格")]
		public string SkuSpec { get; set; }

		[JsonPropertyName("out_sku_id")]
		[Description("商家配置的sku编码")]
		public string OutSkuId { get; set; }

		[JsonPropertyName("province_id")]
		[Description("省ID")]
		public string ProvinceId { get; set; }

		[JsonPropertyName("province")]
		[Description("省")]
		public string Province { get; set; }

		[JsonPropertyName("city_id")]
		[Description("城市ID")]
		public string CityId { get; set; }

		[JsonPropertyName("city")]
		[Description("城市")]
		public string City { get; set; }

		[JsonPropertyName("district_id")]
		[Description("区ID")]
		public string DistrictId { get; set; }

		[JsonPropertyName("district")]
		[Description("区")]
		public string District { get; set; }

		[JsonPropertyName("street_id")]
		[Description("街道ID")]
		public string StreetId { get; set; }

		[JsonPropertyName("street")]
		[Description("街道")]
		public string Street { get; set; }

		[JsonPropertyName("tracking_no")]
		[Description("运单号")]
		public string TrackingNo { get; set; }

		[JsonPropertyName("company_name")]
		[Description("物流公司")]
		public string CompanyName { get; set; }

		[JsonPropertyName("distr_cancel_reason")]
		[Description("代发取消原因")]
		public string DistrCancelReason { get; set; }

		[JsonPropertyName("pack_list")]
		[Description("物流信息")]
		public List<PackListItem> PackList { get; set; }

		public class PackListItem
		{
			[JsonPropertyName("track_no")]
			[Description("物流单号")]
			public string TrackNo { get; set; }

			[JsonPropertyName("company_code")]
			[Description("快递公司")]
			public string CompanyCode { get; set; }
		}

		[JsonPropertyName("ship_time")]
		[Description("发货时间")]
		public long ShipTime { get; set; }

		[JsonPropertyName("serial_number_list")]
		[Description("序列号")]
		public List<string> SerialNumberList { get; set; }
	}

	[JsonPropertyName("page")]
	[Description("返回页码，页码从 0 开始 PS：当前采用分页返回，数量和页数会一起传")]
	public long Page { get; set; }

	[JsonPropertyName("size")]
	[Description("返回数量，最大 100")]
	public long Size { get; set; }

	[JsonPropertyName("total")]
	[Description("订单总数")]
	public long Total { get; set; }
}
