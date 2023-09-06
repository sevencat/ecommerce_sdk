namespace ecommerce.sdk.douyin;

[Description("供销平台供货单的分页查询接口。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务错误","isp.service-error:1000","请稍后重试")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:1020","请传入正确的参数")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:2000","请稍后重试")]
public class SupplyChainGetSupplyOrderListReq : IDouyinReq<SupplyChainGetSupplyOrderListRsp>
{

	public string GetMethod() { return "supplyChain.getSupplyOrderList"; }

	public string GetUrl() { return "/supplyChain/getSupplyOrderList"; }

	[JsonPropertyName("fx_product_id")]
	[Description("货品id")]
	public string FxProductId { get; set; }

	[JsonPropertyName("order_status")]
	[Description("单据状态，10待发货，20已发货，-1已取消")]
	public int? OrderStatus { get; set; }

	[JsonPropertyName("create_time_start")]
	[Description("单据创建开始时间戳，秒")]
	public long? CreateTimeStart { get; set; }

	[JsonPropertyName("create_time_end")]
	[Description("单据创建结束时间戳，秒")]
	public long? CreateTimeEnd { get; set; }

	[JsonPropertyName("order_by")]
	[Description("排序条件，当前仅支持create_time 订单创建时间")]
	public string OrderBy { get; set; }

	[JsonPropertyName("order_asc")]
	[Description("是否升序，默认降序")]
	public bool? OrderAsc { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，从1开始")]
	[NotNull]
	public int? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每一页的条数，最大100")]
	[NotNull]
	public int? Size { get; set; }

	[JsonPropertyName("update_time_start")]
	[Description("单据修改开始时间戳，秒")]
	public long? UpdateTimeStart { get; set; }

	[JsonPropertyName("update_time_end")]
	[Description("单据修改结束时间戳，秒")]
	public long? UpdateTimeEnd { get; set; }
}

[Description("供销平台供货单的分页查询接口。")]
public class SupplyChainGetSupplyOrderListRsp
{
	[JsonPropertyName("total")]
	[Description("单据总条数")]
	public long Total { get; set; }

	[JsonPropertyName("order_list")]
	[Description("订单列表")]
	public List<OrderListItem> OrderList { get; set; }

	public class OrderListItem
	{
		[JsonPropertyName("biz_status_desc")]
		[Description("业务子状态描述。详细区分业务内容；0、101订单自流转，182待绑码，185待发货，210部分发货，220全部发货，310部分签收，320全部签收")]
		public string BizStatusDesc { get; set; }

		[JsonPropertyName("biz_status")]
		[Description("业务子状态")]
		public string BizStatus { get; set; }

		[JsonPropertyName("fx_spu_id")]
		[Description("分销品spuId")]
		public string FxSpuId { get; set; }

		[JsonPropertyName("order_no")]
		[Description("供货单号")]
		public string OrderNo { get; set; }

		[JsonPropertyName("shop_order_id")]
		[Description("前台交易店铺单号")]
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
		[Description("订单总金额，单位=分")]
		public long TotalAmount { get; set; }

		[JsonPropertyName("order_status")]
		[Description("订单状态，0 待扣款，10 待发货，20 已发货，-1 已取消")]
		public int OrderStatus { get; set; }

		[JsonPropertyName("order_status_desc")]
		[Description("订单状态描述")]
		public string OrderStatusDesc { get; set; }

		[JsonPropertyName("pre_sale_type")]
		[Description("预售类型，0 现货类型，1 全款预售 2 阶梯发货")]
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
		[Description("货品单价，供货价，单位=分")]
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
		[Description("前台交易支付时间")]
		public long TradePayTime { get; set; }

		[JsonPropertyName("create_time")]
		[Description("订单创建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("exp_ship_time")]
		[Description("承诺最晚发货时间")]
		public long ExpShipTime { get; set; }

		[JsonPropertyName("ship_time")]
		[Description("实际发货时间")]
		public long ShipTime { get; set; }

		[JsonPropertyName("post_addr")]
		[Description("收件人地址")]
		public PostAddrItem PostAddr { get; set; }

		public class PostAddrItem
		{
			[JsonPropertyName("addr_detail")]
			[Description("剩余详细地址【加密】")]
			public string AddrDetail { get; set; }

			[JsonPropertyName("province_id")]
			[Description("省编码")]
			public string ProvinceId { get; set; }

			[JsonPropertyName("province_name")]
			[Description("省名称")]
			public string ProvinceName { get; set; }

			[JsonPropertyName("city_id")]
			[Description("市编码")]
			public string CityId { get; set; }

			[JsonPropertyName("city_name")]
			[Description("市名称")]
			public string CityName { get; set; }

			[JsonPropertyName("town_id")]
			[Description("区编码")]
			public string TownId { get; set; }

			[JsonPropertyName("town_name")]
			[Description("区名称")]
			public string TownName { get; set; }

			[JsonPropertyName("street_id")]
			[Description("街道编码")]
			public string StreetId { get; set; }

			[JsonPropertyName("street_name")]
			[Description("街道名称")]
			public string StreetName { get; set; }
		}

		[JsonPropertyName("post_receiver")]
		[Description("收件人姓名【加密】")]
		public string PostReceiver { get; set; }

		[JsonPropertyName("post_tel")]
		[Description("收件人电话【加密】")]
		public string PostTel { get; set; }

		[JsonPropertyName("sales_type")]
		[Description("经营模式")]
		public string SalesType { get; set; }

		[JsonPropertyName("inventory_mode")]
		[Description("库存模式")]
		public string InventoryMode { get; set; }

		[JsonPropertyName("virtual_warehouse_id")]
		[Description("虚拟仓id")]
		public string VirtualWarehouseId { get; set; }

		[JsonPropertyName("warehouse_code")]
		[Description("仓code")]
		public string WarehouseCode { get; set; }

		[JsonPropertyName("warehouse_name")]
		[Description("仓name")]
		public string WarehouseName { get; set; }

		[JsonPropertyName("buyer_words")]
		[Description("买家留言")]
		public string BuyerWords { get; set; }

		[JsonPropertyName("shop_words")]
		[Description("店铺留言")]
		public string ShopWords { get; set; }

		[JsonPropertyName("refund_status")]
		[Description("发货前的退款状态，-1=退款关闭，0=无退款，1=退款中，2=退款成功；,发货后的退款，属于售后流程，退款内容见售后单；")]
		public int RefundStatus { get; set; }

		[JsonPropertyName("settlement_no")]
		[Description("结算单号")]
		public string SettlementNo { get; set; }

		[JsonPropertyName("settlement_time")]
		[Description("结算时间")]
		public string SettlementTime { get; set; }

		[JsonPropertyName("open_address_id")]
		[Description("标识收件人地址的id，可用于合单")]
		public string OpenAddressId { get; set; }
	}
}
