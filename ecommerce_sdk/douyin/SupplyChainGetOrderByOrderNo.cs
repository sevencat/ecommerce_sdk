namespace ecommerce.sdk.douyin;

[Description("根据供货单号查询单据详情。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务异常","isp.service-error:1000","请稍后重试")]
[DouyinRetCode(40004,"非法的参数","非法参数","isv.parameter-invalid:1020","请使用正确的参数")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:2000","业务处理失败，请参考错误描述解决")]
[DouyinRetCode(50002,"业务处理失败","数据不存在","isv.business-failed:2001","检查单号是否正确")]
public class SupplyChainGetOrderByOrderNoReq : IDouyinReq<SupplyChainGetOrderByOrderNoRsp>
{

	public string GetMethod() { return "supplyChain.getOrderByOrderNo"; }

	public string GetUrl() { return "/supplyChain/getOrderByOrderNo"; }

	[JsonPropertyName("order_no")]
	[Description("供货单号")]
	[NotNull]
	public string OrderNo { get; set; }
}

[Description("根据供货单号查询单据详情。")]
public class SupplyChainGetOrderByOrderNoRsp
{
	[JsonPropertyName("order")]
	[Description("订单信息体")]
	public OrderItem Order { get; set; }

	public class OrderItem
	{
		[JsonPropertyName("fx_spu_id")]
		[Description("分销品spuId")]
		public string FxSpuId { get; set; }

		[JsonPropertyName("warehouse_name")]
		[Description("仓name")]
		public string WarehouseName { get; set; }

		[JsonPropertyName("warehouse_code")]
		[Description("仓code")]
		public string WarehouseCode { get; set; }

		[JsonPropertyName("virtual_warehouse_id")]
		[Description("虚拟仓id")]
		public string VirtualWarehouseId { get; set; }

		[JsonPropertyName("sales_type")]
		[Description("经营模式")]
		public string SalesType { get; set; }

		[JsonPropertyName("inventory_mode")]
		[Description("库存模式")]
		public string InventoryMode { get; set; }

		[JsonPropertyName("order_no")]
		[Description("供货单号")]
		public string OrderNo { get; set; }

		[JsonPropertyName("shop_order_id")]
		[Description("抖店交易单号")]
		public string ShopOrderId { get; set; }

		[JsonPropertyName("distributor_id")]
		[Description("分销商id")]
		public long DistributorId { get; set; }

		[JsonPropertyName("distributor_name")]
		[Description("分销商名称")]
		public string DistributorName { get; set; }

		[JsonPropertyName("settlement_type")]
		[Description("结算方式，1=担保交易，2=代销分账")]
		public string SettlementType { get; set; }

		[JsonPropertyName("total_amount")]
		[Description("供货单总金额，单位=分")]
		public long TotalAmount { get; set; }

		[JsonPropertyName("order_status")]
		[Description("订单状态值,0,新创建;5,已接单;10,待发货;20,已发货;-1,已取消")]
		public int OrderStatus { get; set; }

		[JsonPropertyName("order_status_desc")]
		[Description("订单状态描述")]
		public string OrderStatusDesc { get; set; }

		[JsonPropertyName("pre_sale_type")]
		[Description("预售类型")]
		public long PreSaleType { get; set; }

		[JsonPropertyName("out_product_code")]
		[Description("外部货品编码")]
		public string OutProductCode { get; set; }

		[JsonPropertyName("fx_product_id")]
		[Description("分销品skuId")]
		public string FxProductId { get; set; }

		[JsonPropertyName("fx_product_name")]
		[Description("分销品名称")]
		public string FxProductName { get; set; }

		[JsonPropertyName("fx_product_specs")]
		[Description("分销品规格")]
		public string FxProductSpecs { get; set; }

		[JsonPropertyName("quantity")]
		[Description("货品数量")]
		public long Quantity { get; set; }

		[JsonPropertyName("price")]
		[Description("货品单价")]
		public long Price { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品skuId")]
		public string ProductId { get; set; }

		[JsonPropertyName("product_name")]
		[Description("商品名称")]
		public string ProductName { get; set; }

		[JsonPropertyName("product_specs")]
		[Description("商品规格")]
		public string ProductSpecs { get; set; }

		[JsonPropertyName("trade_pay_time")]
		[Description("抖店支付时间")]
		public long TradePayTime { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创单时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("exp_ship_time")]
		[Description("承诺最晚发货时间")]
		public long ExpShipTime { get; set; }

		[JsonPropertyName("ship_time")]
		[Description("实际发货时间")]
		public long ShipTime { get; set; }

		[JsonPropertyName("post_receiver")]
		[Description("收件人姓名【密文】")]
		public string PostReceiver { get; set; }

		[JsonPropertyName("post_tel")]
		[Description("收件人电话【密文】")]
		public string PostTel { get; set; }

		[JsonPropertyName("post_addr")]
		[Description("收件人地址结构")]
		public PostAddrItem PostAddr { get; set; }

		public class PostAddrItem
		{
			[JsonPropertyName("province_name")]
			[Description("省名称")]
			public string ProvinceName { get; set; }

			[JsonPropertyName("city_name")]
			[Description("市名称")]
			public string CityName { get; set; }

			[JsonPropertyName("district_name")]
			[Description("区名称")]
			public string DistrictName { get; set; }

			[JsonPropertyName("street_name")]
			[Description("街道名称")]
			public string StreetName { get; set; }

			[JsonPropertyName("addr_detail")]
			[Description("剩余详细地址【密文】")]
			public string AddrDetail { get; set; }

			[JsonPropertyName("province_id")]
			[Description("省编码")]
			public string ProvinceId { get; set; }

			[JsonPropertyName("city_id")]
			[Description("市编码")]
			public string CityId { get; set; }

			[JsonPropertyName("district_id")]
			[Description("区编码")]
			public string DistrictId { get; set; }

			[JsonPropertyName("street_id")]
			[Description("街道编码")]
			public string StreetId { get; set; }
		}

		[JsonPropertyName("buyer_words")]
		[Description("买家留言")]
		public string BuyerWords { get; set; }

		[JsonPropertyName("shop_words")]
		[Description("店铺留言")]
		public string ShopWords { get; set; }

		[JsonPropertyName("refund_status")]
		[Description("退款状态，-1=退款关闭，0=无退款，1=退款中，2=退款成功")]
		public int RefundStatus { get; set; }

		[JsonPropertyName("open_address_id")]
		[Description("标识收件人地址的id，可用于合单")]
		public string OpenAddressId { get; set; }
	}
}
