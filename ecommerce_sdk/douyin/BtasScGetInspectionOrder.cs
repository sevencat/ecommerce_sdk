namespace ecommerce.sdk.douyin;

[Description("质检机构获取该机构的订单状态信息，包含履约状态，取消状态，送检状态和发货状态等。,注意该字段需要手动配置接口权限，且仅能查询当前机构的订单。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","订单不存在","isp.service-error:4000","重试")]
[DouyinRetCode(40002,"缺少必选参数","参数错误","isv.missing-parameter:2030","检查订单ID和订单码是否传")]
[DouyinRetCode(50002,"业务处理失败","非法访问，没有获取到授权店铺信息","isv.business-failed:-1","-")]
public class BtasScGetInspectionOrderReq : IDouyinReq<BtasScGetInspectionOrderRsp>
{

	public string GetMethod() { return "btas.sc.getInspectionOrder"; }

	public string GetUrl() { return "/btas/sc/getInspectionOrder"; }

	[JsonPropertyName("order_id")]
	[Description("店铺单ID")]
	public string OrderId { get; set; }

	[JsonPropertyName("order_code")]
	[Description("订单码，与订单ID二选一填入")]
	public string OrderCode { get; set; }

	[JsonPropertyName("sc_id")]
	[Description("质检机构ID，不能为空")]
	public long? ScId { get; set; }
}

[Description("质检机构获取该机构的订单状态信息，包含履约状态，取消状态，送检状态和发货状态等。,注意该字段需要手动配置接口权限，且仅能查询当前机构的订单。")]
public class BtasScGetInspectionOrderRsp
{
	[JsonPropertyName("product_orders")]
	[Description("订单列表")]
	public List<ProductOrdersItem> ProductOrders { get; set; }

	public class ProductOrdersItem
	{
		[JsonPropertyName("product_order_id")]
		[Description("商品单ID")]
		public string ProductOrderId { get; set; }

		[JsonPropertyName("order_code")]
		[Description("订单码")]
		public List<string> OrderCode { get; set; }

		[JsonPropertyName("product_order_details")]
		[Description("订单明细，数组长度未1(兼容考虑）")]
		public List<ProductOrderDetailsItem> ProductOrderDetails { get; set; }

		public class ProductOrderDetailsItem
		{
			[JsonPropertyName("shop_id")]
			[Description("店铺ID")]
			public long ShopId { get; set; }

			[JsonPropertyName("order_code")]
			[Description("订单码")]
			public string OrderCode { get; set; }

			[JsonPropertyName("inspection_type")]
			[Description("质检类型。1-实物送检；2-图片送检")]
			public int InspectionType { get; set; }

			[JsonPropertyName("inspection_biz_mod")]
			[Description("质检业务模式。0为后置质检。 10-前置质检多库存；20-前置质检单库存.")]
			public int InspectionBizMod { get; set; }

			[JsonPropertyName("seller_return_type")]
			[Description("商家从质检机构取回货品方式。0:初始化，1:邮寄。2：自提")]
			public int SellerReturnType { get; set; }

			[JsonPropertyName("fulfillment_status")]
			[Description("订单履约状态。不建议依赖该状态做任何逻辑")]
			public int FulfillmentStatus { get; set; }

			[JsonPropertyName("cancel_status")]
			[Description("订单取消状态。0-未取消；1-申请取消；2-订单已经取消；4-仅退款&订单已取消；6-退货退款&订单已取消。,2、4、6均可认为已取消")]
			public int CancelStatus { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("product_img")]
			[Description("商品图片")]
			public string ProductImg { get; set; }

			[JsonPropertyName("product_price")]
			[Description("商品价格")]
			public long ProductPrice { get; set; }

			[JsonPropertyName("extra_properties")]
			[Description("额外属性，JSON字符串")]
			public string ExtraProperties { get; set; }

			[JsonPropertyName("sc_info")]
			[Description("质检机构信息")]
			public ScInfoItem ScInfo { get; set; }

			public class ScInfoItem
			{
				[JsonPropertyName("sc_id")]
				[Description("机构ID")]
				public long ScId { get; set; }

				[JsonPropertyName("sc_name")]
				[Description("机构名称")]
				public string ScName { get; set; }

				[JsonPropertyName("sc_phone")]
				[Description("机构电话")]
				public string ScPhone { get; set; }

				[JsonPropertyName("sc_manager")]
				[Description("管理人")]
				public string ScManager { get; set; }

				[JsonPropertyName("sc_province")]
				[Description("机构地址_省")]
				public string ScProvince { get; set; }

				[JsonPropertyName("sc_city")]
				[Description("机构地址_市")]
				public string ScCity { get; set; }

				[JsonPropertyName("sc_district")]
				[Description("机构地址_区")]
				public string ScDistrict { get; set; }

				[JsonPropertyName("sc_street")]
				[Description("机构地址_街道")]
				public string ScStreet { get; set; }

				[JsonPropertyName("sc_address")]
				[Description("机构地址明细")]
				public string ScAddress { get; set; }

				[JsonPropertyName("sc_province_id")]
				[Description("机构地址_省ID")]
				public long ScProvinceId { get; set; }

				[JsonPropertyName("sc_city_id")]
				[Description("机构地址_市ID")]
				public long ScCityId { get; set; }

				[JsonPropertyName("sc_district_id")]
				[Description("机构地址_区ID")]
				public long ScDistrictId { get; set; }

				[JsonPropertyName("sc_street_id")]
				[Description("机构地址_街道ID")]
				public long ScStreetId { get; set; }
			}

			[JsonPropertyName("certification_code")]
			[Description("质检码")]
			public string CertificationCode { get; set; }

			[JsonPropertyName("inspection_result")]
			[Description("质检结果。1-通过，2-不通过，5-无法质检，99-无需质检，触发退货发货")]
			public long InspectionResult { get; set; }

			[JsonPropertyName("send2_sc_courier_info")]
			[Description("商家送往质检机构物流信息")]
			public Send2ScCourierInfoItem Send2ScCourierInfo { get; set; }

			public class Send2ScCourierInfoItem
			{
				[JsonPropertyName("logistics_name_en")]
				[Description("物流公司名称英文")]
				public string LogisticsNameEn { get; set; }

				[JsonPropertyName("logistics_name_cn")]
				[Description("物流公司名称中文")]
				public string LogisticsNameCn { get; set; }

				[JsonPropertyName("logistics_type")]
				[Description("快递公司产品类型")]
				public string LogisticsType { get; set; }

				[JsonPropertyName("courier_code")]
				[Description("物流编号")]
				public string CourierCode { get; set; }
			}

			[JsonPropertyName("send2_buyer_courier_info")]
			[Description("质检机构发往消费者物流信息")]
			public Send2BuyerCourierInfoItem Send2BuyerCourierInfo { get; set; }

			public class Send2BuyerCourierInfoItem
			{
				[JsonPropertyName("logistics_name_en")]
				[Description("物流公司名称英文")]
				public string LogisticsNameEn { get; set; }

				[JsonPropertyName("logistics_name_cn")]
				[Description("物流公司名称中文")]
				public string LogisticsNameCn { get; set; }

				[JsonPropertyName("logistics_type")]
				[Description("快递公司产品类型")]
				public string LogisticsType { get; set; }

				[JsonPropertyName("courier_code")]
				[Description("物流编号")]
				public string CourierCode { get; set; }
			}

			[JsonPropertyName("seller_shipping_time")]
			[Description("商家送检时间")]
			public long SellerShippingTime { get; set; }

			[JsonPropertyName("sc_receive_time")]
			[Description("机构收货时间")]
			public long ScReceiveTime { get; set; }

			[JsonPropertyName("sc_shipping_time")]
			[Description("机构发货时间")]
			public long ScShippingTime { get; set; }
		}
	}

	[JsonPropertyName("order_id")]
	[Description("订单ID")]
	public string OrderId { get; set; }
}
