namespace ecommerce.sdk.douyin;

[Description("【商家】查看代发订单详情,【商家】查看代发订单详情")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","代发订单不能为空","isv.parameter-invalid:10000","请检查代发单号")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20000","重试")]
[DouyinRetCode(50002,"业务处理失败","代发单不存在","isv.business-failed:40000","代发单不存在")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:1000","系统繁忙，请稍后重试")]
public class IopSellerOrderInfoReq : IDouyinReq<IopSellerOrderInfoRsp>
{

	public string GetMethod() { return "iop.sellerOrderInfo"; }

	public string GetUrl() { return "/iop/sellerOrderInfo"; }

	[JsonPropertyName("distr_order_id")]
	[Description("代打订单号")]
	[NotNull]
	public string DistrOrderId { get; set; }
}

[Description("【商家】查看代发订单详情,【商家】查看代发订单详情")]
public class IopSellerOrderInfoRsp
{
	[JsonPropertyName("distr_order_detail")]
	[Description("代发订单详情")]
	public DistrOrderDetailItem DistrOrderDetail { get; set; }

	public class DistrOrderDetailItem
	{
		[JsonPropertyName("distr_order_id")]
		[Description("代打订单号")]
		public string DistrOrderId { get; set; }

		[JsonPropertyName("shop_order_id")]
		[Description("店铺单id")]
		public string ShopOrderId { get; set; }

		[JsonPropertyName("order_status")]
		[Description("订单状态  101-部分发货 2-备货中 3-已发货 4-已关闭 5-已完成")]
		public long OrderStatus { get; set; }

		[JsonPropertyName("distr_status")]
		[Description("分配状态0-未分配 1-已经分配 2-已回传 3-已取消")]
		public long DistrStatus { get; set; }

		[JsonPropertyName("distr_time")]
		[Description("分配时间 单位秒")]
		public long DistrTime { get; set; }

		[JsonPropertyName("after_sale_status")]
		[Description("1-无售后 2-售后中")]
		public int AfterSaleStatus { get; set; }

		[JsonPropertyName("supplier_shop_id")]
		[Description("要绑定的厂商的店铺ID")]
		public long SupplierShopId { get; set; }

		[JsonPropertyName("supplier_shop_name")]
		[Description("厂商店铺名称")]
		public string SupplierShopName { get; set; }

		[JsonPropertyName("exp_ship_time")]
		[Description("承诺发货时间 单位秒")]
		public long ExpShipTime { get; set; }

		[JsonPropertyName("pay_time")]
		[Description("支付时间 单位秒")]
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
		[Description("市ID")]
		public string CityId { get; set; }

		[JsonPropertyName("city")]
		[Description("市")]
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
			[Description("运单号")]
			public string TrackNo { get; set; }

			[JsonPropertyName("company_code")]
			[Description("物流公司")]
			public string CompanyCode { get; set; }
		}

		[JsonPropertyName("ship_time")]
		[Description("发货时间")]
		public long ShipTime { get; set; }

		[JsonPropertyName("serial_number_list")]
		[Description("序列号")]
		public List<string> SerialNumberList { get; set; }
	}
}
