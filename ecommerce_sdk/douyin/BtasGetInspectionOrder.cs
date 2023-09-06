namespace ecommerce.sdk.douyin;

[Description("BTAS质检商家查询订单明细信息（是否需要质检、获取质检码、是否线上质检、是否前置质检、订单状态等）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","订单不存在","isv.business-failed:4000","确认订单编码是否正确")]
[DouyinRetCode(50002,"业务处理失败","2030:参数错误","isv.business-failed:2030","检查订单号")]
public class BtasGetInspectionOrderReq : IDouyinReq<BtasGetInspectionOrderRsp>
{

	public string GetMethod() { return "btas.getInspectionOrder"; }

	public string GetUrl() { return "/btas/getInspectionOrder"; }

	[JsonPropertyName("order_id")]
	[Description("父订单（店铺单）编号")]
	public string OrderId { get; set; }

	[JsonPropertyName("order_code")]
	[Description("订单码，与店铺单ID二选一。")]
	public string OrderCode { get; set; }
}

[Description("BTAS质检商家查询订单明细信息（是否需要质检、获取质检码、是否线上质检、是否前置质检、订单状态等）")]
public class BtasGetInspectionOrderRsp
{
	[JsonPropertyName("order_id")]
	[Description("父订单（店铺单）编号")]
	public string OrderId { get; set; }

	[JsonPropertyName("product_orders")]
	[Description("商品单内容，根据订单ID查可能返回多条数据，根据orderCode查仅有一条数据。")]
	public List<ProductOrdersItem> ProductOrders { get; set; }

	public class ProductOrdersItem
	{
		[JsonPropertyName("product_order_id")]
		[Description("商品单编号")]
		public string ProductOrderId { get; set; }

		[JsonPropertyName("order_code")]
		[Description("订单码（202302废弃）")]
		public List<string> OrderCode { get; set; }

		[JsonPropertyName("product_order_details")]
		[Description("订单明细")]
		public List<ProductOrderDetailsItem> ProductOrderDetails { get; set; }

		public class ProductOrderDetailsItem
		{
			[JsonPropertyName("sc_shipping_time")]
			[Description("质检机构发货时间")]
			public long ScShippingTime { get; set; }

			[JsonPropertyName("sc_receive_time")]
			[Description("质检机构收货时间")]
			public long ScReceiveTime { get; set; }

			[JsonPropertyName("seller_shipping_time")]
			[Description("商家送检时间")]
			public long SellerShippingTime { get; set; }

			[JsonPropertyName("send_2buyer_courier_info")]
			[Description("发往消费者物流信息")]
			public Send2buyerCourierInfoItem Send2buyerCourierInfo { get; set; }

			public class Send2buyerCourierInfoItem
			{
				[JsonPropertyName("logistics_name_en")]
				[Description("快递公司英文名")]
				public string LogisticsNameEn { get; set; }

				[JsonPropertyName("logistics_name_cn")]
				[Description("快递公司中文名")]
				public string LogisticsNameCn { get; set; }

				[JsonPropertyName("logistics_type")]
				[Description("快递公司产品类型，见电子面单文档")]
				public string LogisticsType { get; set; }

				[JsonPropertyName("courier_code")]
				[Description("快递单号")]
				public string CourierCode { get; set; }
			}

			[JsonPropertyName("send_2sc_courier_info")]
			[Description("商家送检物流信息")]
			public Send2scCourierInfoItem Send2scCourierInfo { get; set; }

			public class Send2scCourierInfoItem
			{
				[JsonPropertyName("courier_code")]
				[Description("快递单号")]
				public string CourierCode { get; set; }

				[JsonPropertyName("logistics_type")]
				[Description("快递公司产品类型，见电子面单文档")]
				public string LogisticsType { get; set; }

				[JsonPropertyName("logistics_name_cn")]
				[Description("快递公司中文名")]
				public string LogisticsNameCn { get; set; }

				[JsonPropertyName("logistics_name_en")]
				[Description("快递公司英文名")]
				public string LogisticsNameEn { get; set; }
			}

			[JsonPropertyName("inspection_result")]
			[Description("质检结果。1-通过，2-不通过，5-无法质检，99-无需质检，触发退货发货")]
			public long InspectionResult { get; set; }

			[JsonPropertyName("sc_info")]
			[Description("质检机构信息。字段可能为空")]
			public ScInfoItem ScInfo { get; set; }

			public class ScInfoItem
			{
				[JsonPropertyName("sc_address")]
				[Description("机构详细地址")]
				public string ScAddress { get; set; }

				[JsonPropertyName("sc_street")]
				[Description("机构地址_街道")]
				public string ScStreet { get; set; }

				[JsonPropertyName("sc_district")]
				[Description("机构地址_区")]
				public string ScDistrict { get; set; }

				[JsonPropertyName("sc_city")]
				[Description("机构地址_市")]
				public string ScCity { get; set; }

				[JsonPropertyName("sc_province")]
				[Description("机构地址_省")]
				public string ScProvince { get; set; }

				[JsonPropertyName("sc_phone")]
				[Description("机构联系电话")]
				public string ScPhone { get; set; }

				[JsonPropertyName("sc_name")]
				[Description("质检机构名称")]
				public string ScName { get; set; }

				[JsonPropertyName("sc_id")]
				[Description("质检机构ID")]
				public long ScId { get; set; }
			}

			[JsonPropertyName("order_code")]
			[Description("订单码")]
			public string OrderCode { get; set; }

			[JsonPropertyName("inspection_type")]
			[Description("质检类型。1-线下质检，2-线上质检。")]
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
			[Description("商品价格（分）")]
			public long ProductPrice { get; set; }

			[JsonPropertyName("extra_properties")]
			[Description("额外属性，JSON格式")]
			public string ExtraProperties { get; set; }
		}
	}
}
