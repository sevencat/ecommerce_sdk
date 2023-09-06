namespace ecommerce.sdk.douyin;

[Description("查询代打订单列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","结束时间不可以小于开始时间","isv.parameter-invalid:10000","检查参数是否正确")]
[DouyinRetCode(20000,"系统错误","(空字符串)","isp.service-error:88888","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:1000","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:10005","系统繁忙，请稍后重试")]
public class IopOrderListReq : IDouyinReq<IopOrderListRsp>
{

	public string GetMethod() { return "iop.orderList"; }

	public string GetUrl() { return "/iop/orderList"; }

	[JsonPropertyName("start_update_time")]
	[Description("与分配时间段二选一传入，更新时间开始时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过半小时，更新时间段与分配时间段均传入时以更新时间段为准")]
	public long? StartUpdateTime { get; set; }

	[JsonPropertyName("end_update_time")]
	[Description("与分配时间段二选一传入，更新时间开始时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过半小时，更新时间段与分配时间段均传入时以更新时间段为准")]
	public long? EndUpdateTime { get; set; }

	[JsonPropertyName("page")]
	[Description("返回页码，页码从 0 开始 PS：当前采用分页返回，数量和页数会一起传")]
	[NotNull]
	public int? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("返回数量，最大 100")]
	[NotNull]
	public int? Size { get; set; }

	[JsonPropertyName("distr_status")]
	[Description("分配状态 1-已分配未回传 2-已回传 3-已取消")]
	public long? DistrStatus { get; set; }

	[JsonPropertyName("start_distr_time")]
	[Description("与更新时间段二选一传入，分配时间开始时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过半小时，更新时间段与分配时间段均传入时以更新时间段为准")]
	public long? StartDistrTime { get; set; }

	[JsonPropertyName("end_distr_time")]
	[Description("与更新时间段二选一传入，分配时间结束时间的时间戳，指格林威治时间 1970 年 01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数 PS：开始时间结束时间间距不超过半小时，更新时间段与分配时间段均传入时以更新时间段为准")]
	public long? EndDistrTime { get; set; }
}

[Description("查询代打订单列表")]
public class IopOrderListRsp
{
	[JsonPropertyName("order_list")]
	[Description("订单列表")]
	public List<OrderListItem> OrderList { get; set; }

	public class OrderListItem
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
		[Description("分配状态  1：已分配未回传；2已回传; 3已取消")]
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
		[Description("街道ID")]
		public string StreetId { get; set; }

		[JsonPropertyName("distr_cancel_reason")]
		[Description("代发取消原因")]
		public string DistrCancelReason { get; set; }

		[JsonPropertyName("buyer_words")]
		[Description("买家备注")]
		public string BuyerWords { get; set; }

		[JsonPropertyName("aftersale_status")]
		[Description("1无售后 2有售后")]
		public long AftersaleStatus { get; set; }

		[JsonPropertyName("exp_ship_time")]
		[Description("期望发货时间，单位s")]
		public long ExpShipTime { get; set; }

		[JsonPropertyName("spec")]
		[Description("规格信息")]
		public List<SpecItem> Spec { get; set; }

		public class SpecItem
		{
			[JsonPropertyName("name")]
			[Description("规格名称")]
			public string Name { get; set; }

			[JsonPropertyName("value")]
			[Description("规格值")]
			public string Value { get; set; }
		}

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

	[JsonPropertyName("total")]
	[Description("订单总数")]
	public long Total { get; set; }
}
