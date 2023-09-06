namespace ecommerce.sdk.douyin;

[Description("订单详情")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","订单号不存在","isv.parameter-invalid:40000","检查订单号是否已取消分配")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:88888","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","10005:系统繁忙，请稍后重试","isv.business-failed:10005","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","1000:系统繁忙，请稍后重试","isv.business-failed:1000","系统繁忙，请稍后重试")]
public class IopOrderInfoReq : IDouyinReq<IopOrderInfoRsp>
{

	public string GetMethod() { return "iop.orderInfo"; }

	public string GetUrl() { return "/iop/orderInfo"; }

	[JsonPropertyName("user_id")]
	[Description("代打店铺id")]
	[NotNull]
	public long? UserId { get; set; }

	[JsonPropertyName("distr_order_id")]
	[Description("代打订单号")]
	[NotNull]
	public string DistrOrderId { get; set; }
}

[Description("订单详情")]
public class IopOrderInfoRsp
{
	[JsonPropertyName("distr_order_id")]
	[Description("代打订单号")]
	public string DistrOrderId { get; set; }

	[JsonPropertyName("user_id")]
	[Description("代打店铺id")]
	public long UserId { get; set; }

	[JsonPropertyName("user_name")]
	[Description("代打店铺自定义名称")]
	public string UserName { get; set; }

	[JsonPropertyName("seller_words")]
	[Description("卖家备注")]
	public string SellerWords { get; set; }

	[JsonPropertyName("distr_time")]
	[Description("分配时间,秒")]
	public long DistrTime { get; set; }

	[JsonPropertyName("distr_status")]
	[Description("分配状态 0：未分配 1：已分配未回传；2已回传; 3已取消")]
	public long DistrStatus { get; set; }

	[JsonPropertyName("product_name")]
	[Description("商品名称")]
	public string ProductName { get; set; }

	[JsonPropertyName("product_count")]
	[Description("商品数量")]
	public long ProductCount { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品id")]
	public string ProductId { get; set; }

	[JsonPropertyName("product_price")]
	[Description("商品价格")]
	public long ProductPrice { get; set; }

	[JsonPropertyName("sku_spec")]
	[Description("规格")]
	public string SkuSpec { get; set; }

	[JsonPropertyName("out_sku_id")]
	[Description("商家配置的sku编码")]
	public string OutSkuId { get; set; }

	[JsonPropertyName("receiver_id")]
	[Description("收件人姓名+电话+详细地址相同,receiver_id字段相同")]
	public string ReceiverId { get; set; }

	[JsonPropertyName("province")]
	[Description("省")]
	public string Province { get; set; }

	[JsonPropertyName("city")]
	[Description("市")]
	public string City { get; set; }

	[JsonPropertyName("district")]
	[Description("区")]
	public string District { get; set; }

	[JsonPropertyName("street")]
	[Description("街道")]
	public string Street { get; set; }

	[JsonPropertyName("province_id")]
	[Description("省ID")]
	public string ProvinceId { get; set; }

	[JsonPropertyName("city_id")]
	[Description("市ID")]
	public string CityId { get; set; }

	[JsonPropertyName("district_id")]
	[Description("区ID")]
	public string DistrictId { get; set; }

	[JsonPropertyName("street_id")]
	[Description("街道IID")]
	public string StreetId { get; set; }

	[JsonPropertyName("distr_cancel_reason")]
	[Description("代发取消原因")]
	public string DistrCancelReason { get; set; }

	[JsonPropertyName("buyer_words")]
	[Description("买家备注")]
	public string BuyerWords { get; set; }

	[JsonPropertyName("distr_order_aftersale_status")]
	[Description("代发单售后状态，1-无售后或售后关闭，2-有售后")]
	public long DistrOrderAftersaleStatus { get; set; }

	[JsonPropertyName("exp_ship_time")]
	[Description("预期发货时间")]
	public long ExpShipTime { get; set; }

	[JsonPropertyName("ship_time")]
	[Description("发货时间")]
	public long ShipTime { get; set; }

	[JsonPropertyName("serial_number_list")]
	[Description("序列号")]
	public List<string> SerialNumberList { get; set; }

	[JsonPropertyName("pack_list")]
	[Description("物流信息")]
	public List<PackListItem> PackList { get; set; }

	public class PackListItem
	{
		[JsonPropertyName("deliver_id")]
		[Description("包裹id")]
		public string DeliverId { get; set; }

		[JsonPropertyName("track_no")]
		[Description("物流单号")]
		public string TrackNo { get; set; }

		[JsonPropertyName("company_code")]
		[Description("物流公司")]
		public string CompanyCode { get; set; }
	}
}
