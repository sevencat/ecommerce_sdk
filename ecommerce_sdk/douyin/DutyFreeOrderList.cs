namespace ecommerce.sdk.douyin;

[Description("海南业务-商家拉单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","开始时间必须早于结束时间","isv.business-failed:1002","请检查开始时间、结束时间")]
public class DutyFreeOrderListReq : IDouyinReq<DutyFreeOrderListRsp>
{

	public string GetMethod() { return "dutyFree.orderList"; }

	public string GetUrl() { return "/dutyFree/orderList"; }

	[JsonPropertyName("start_time")]
	[Description("开始时间")]
	[NotNull]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("结束时间，必须大于等于开始时间")]
	[NotNull]
	public string EndTime { get; set; }

	[JsonPropertyName("order_by")]
	[Description("默认按订单（跨境履约单）创建时间搜索")]
	[NotNull]
	public string OrderBy { get; set; }

	[JsonPropertyName("is_desc")]
	[Description("订单排序方式：0按时间升序， 1按时间降序 默认为1")]
	public string IsDesc { get; set; }

	[JsonPropertyName("order_list")]
	[Description("需要查询的订单id列表 如果该字段不为空（列表至少包含 1 个订单号），此时参数只有vendor有用，其他参数不起作用。批量查询数量不超过100。")]
	public List<string> OrderList { get; set; }

	[JsonPropertyName("page")]
	[Description("页数（默认为1）")]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页模板数（默认为10）")]
	public long? Size { get; set; }
}

[Description("海南业务-商家拉单")]
public class DutyFreeOrderListRsp
{
	[JsonPropertyName("data")]
	[Description("订单数据结构")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单编号")]
		public string OrderId { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("商家店铺在电商平台的ID")]
		public long ShopId { get; set; }

		[JsonPropertyName("status")]
		[Description("状态")]
		public int Status { get; set; }

		[JsonPropertyName("customs_clear_type")]
		[Description("清关模式（4离岛免税, 5离岛补购）")]
		public int CustomsClearType { get; set; }

		[JsonPropertyName("goods_value")]
		[Description("商品销售价格（限时特卖则为限时特卖价格）（单位：分）")]
		public long GoodsValue { get; set; }

		[JsonPropertyName("freight")]
		[Description("运杂费（含物流保费） 免邮传0，单位是分")]
		public long Freight { get; set; }

		[JsonPropertyName("discount")]
		[Description("优惠总金额 ，单位是分")]
		public long Discount { get; set; }

		[JsonPropertyName("actural_paid")]
		[Description("实际支付金额（商品销售价格+运杂费-优惠总金额），单位是分")]
		public long ActuralPaid { get; set; }

		[JsonPropertyName("buyer_reg_no")]
		[Description("订购人（即离岛人）注册号")]
		public string BuyerRegNo { get; set; }

		[JsonPropertyName("buyer_name")]
		[Description("订购人姓名")]
		public string BuyerName { get; set; }

		[JsonPropertyName("buyer_telephone")]
		[Description("订购人电话")]
		public string BuyerTelephone { get; set; }

		[JsonPropertyName("buyer_id_type")]
		[Description("订购人证件类型 1-身份证,2-其它。 限定为身份证，填“1”")]
		public string BuyerIdType { get; set; }

		[JsonPropertyName("buyer_id_number")]
		[Description("订购人证件号码")]
		public string BuyerIdNumber { get; set; }

		[JsonPropertyName("consignee")]
		[Description("收货人姓名")]
		public string Consignee { get; set; }

		[JsonPropertyName("consignee_telephone")]
		[Description("收货人电话")]
		public string ConsigneeTelephone { get; set; }

		[JsonPropertyName("consignee_address")]
		[Description("收货地址")]
		public string ConsigneeAddress { get; set; }

		[JsonPropertyName("pay_transaction_id")]
		[Description("支付企业唯一的支付流水号")]
		public string PayTransactionId { get; set; }

		[JsonPropertyName("create_time")]
		[Description("跨境履约单创建时间（UnixTime 以ms为单位）")]
		public long CreateTime { get; set; }

		[JsonPropertyName("pay_time")]
		[Description("支付完成时间（UnixTime 以ms为单位）")]
		public long PayTime { get; set; }

		[JsonPropertyName("pre_sale_type")]
		[Description("预售类型 （0: 现货发货模式，1: 全款预售发货模式）")]
		public int PreSaleType { get; set; }

		[JsonPropertyName("order_detail_list")]
		[Description("订单明细信息")]
		public List<OrderDetailListItem> OrderDetailList { get; set; }

		public class OrderDetailListItem
		{
			[JsonPropertyName("sku_id")]
			[Description("字节平台商品sku id")]
			public long SkuId { get; set; }

			[JsonPropertyName("item_name")]
			[Description("平台商品名称 （商家在电商平台创建的名称）")]
			public string ItemName { get; set; }

			[JsonPropertyName("qty")]
			[Description("购买数量")]
			public long Qty { get; set; }

			[JsonPropertyName("price")]
			[Description("销售单价(如果是限时特卖，则为限时特卖价格)，单位分")]
			public long Price { get; set; }

			[JsonPropertyName("total_price")]
			[Description("销售总价(price*qty)，单位分")]
			public long TotalPrice { get; set; }

			[JsonPropertyName("out_sku_id")]
			[Description("外部定义sku_id")]
			public string OutSkuId { get; set; }

			[JsonPropertyName("is_suit")]
			[Description("是否套装（0否1是）")]
			public int IsSuit { get; set; }

			[JsonPropertyName("suit_num")]
			[Description("套装数量")]
			public long SuitNum { get; set; }

			[JsonPropertyName("cdf_category")]
			[Description("海关分类限制编码")]
			public string CdfCategory { get; set; }

			[JsonPropertyName("volume")]
			[Description("净含量（单位ML），酒类关注")]
			public long Volume { get; set; }

			[JsonPropertyName("discount")]
			[Description("优惠总金额，单位分")]
			public long Discount { get; set; }

			[JsonPropertyName("coupon_amount")]
			[Description("优惠券优惠总金额，单位分")]
			public long CouponAmount { get; set; }

			[JsonPropertyName("fulldiscount_amount")]
			[Description("满减活动优惠总金额，单位分")]
			public long FulldiscountAmount { get; set; }

			[JsonPropertyName("bar_code")]
			[Description("条形码")]
			public string BarCode { get; set; }

			[JsonPropertyName("original_price")]
			[Description("商品原始价格")]
			public long OriginalPrice { get; set; }
		}

		[JsonPropertyName("delivery_method")]
		[Description("提货方式（1邮寄、2离岛自提）")]
		public int DeliveryMethod { get; set; }

		[JsonPropertyName("pay_type")]
		[Description("支付类型 (1：微信，2：支付宝,·4：银行卡,5：余额, 8：Dou分期, 9：新卡支付）")]
		public int PayType { get; set; }

		[JsonPropertyName("leave_type")]
		[Description("离岛方式（ 1:飞机 2:火车 3:轮渡）")]
		public int LeaveType { get; set; }

		[JsonPropertyName("leave_date")]
		[Description("离岛时间（UnixTime 以s为单位）")]
		public long LeaveDate { get; set; }

		[JsonPropertyName("frequency_no")]
		[Description("交通班次号")]
		public string FrequencyNo { get; set; }

		[JsonPropertyName("delivery_location")]
		[Description("自提点地址")]
		public string DeliveryLocation { get; set; }

		[JsonPropertyName("no_public_discount")]
		[Description("非普惠优惠总金额，单位是分")]
		public long NoPublicDiscount { get; set; }

		[JsonPropertyName("order_date")]
		[Description("用户下单时间")]
		public long OrderDate { get; set; }

		[JsonPropertyName("exp_ship_time")]
		[Description("最晚发货时间")]
		public long ExpShipTime { get; set; }
	}

	[JsonPropertyName("has_next")]
	[Description("是否还有下一页")]
	public bool HasNext { get; set; }

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
