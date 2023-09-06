namespace ecommerce.sdk.douyin;

[Description("qic流程订单商家发货接口，调用后会绑定订单和订单码，并生成qic入库单，,delivery_type 是 【0】&& ship_type 是【1】，对应一单一包裹模式；,delivery_type 是 【0】&& ship_type 是【3】，对应混订单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","传入订单码有误","isv.parameter-invalid:6011","订单码不存在，确认输入的订单码是否有误")]
[DouyinRetCode(40004,"非法的参数","质检机构有误","isv.parameter-invalid:-1","请检查发货策略是否配置，稍后重试")]
[DouyinRetCode(50002,"业务处理失败","该订单不是待绑码状态，不允许绑码","isv.business-failed:6071","该订单不需要操作绑码")]
[DouyinRetCode(50002,"业务处理失败","订单处理中，请稍后再试","isv.business-failed:1001","请稍后重试")]
[DouyinRetCode(40004,"非法的参数","商家发货包裹已经存在，不支持重发","isv.parameter-invalid:1000","商家发货包裹已经存在，不支持重发")]
[DouyinRetCode(20000,"系统错误","调用下游超时","isp.service-error:6014","接口超时，请重试")]
[DouyinRetCode(50002,"业务处理失败","6012:该订单码已绑定，不可再被绑定","isv.business-failed:6012","请检查订单码是否正确，更换订单码")]
[DouyinRetCode(50002,"业务处理失败","订单不存在","isv.business-failed:6038","请检查订单是否正确，确认无误稍后重试")]
[DouyinRetCode(50002,"业务处理失败","订单码不存在","isv.business-failed:6011","请检查订单码是否正确，确认无误稍后重试")]
[DouyinRetCode(40004,"非法的参数","非法操作","isv.parameter-invalid:6041","订单不属于当前店铺")]
public class OrderCodeErpShopBindOrderCodeReq : IDouyinReq<OrderCodeErpShopBindOrderCodeRsp>
{

	public string GetMethod() { return "orderCode.erpShopBindOrderCode"; }

	public string GetUrl() { return "/orderCode/erpShopBindOrderCode"; }

	[JsonPropertyName("shop_package_id")]
	[Description("商家包裹id")]
	[NotNull]
	public string ShopPackageId { get; set; }

	[JsonPropertyName("delivery_type")]
	[Description("送检方式")]
	[NotNull]
	public long? DeliveryType { get; set; }

	[JsonPropertyName("ship_type")]
	[Description("出仓方式")]
	[NotNull]
	public long? ShipType { get; set; }

	[JsonPropertyName("order_list")]
	[Description("订单列表")]
	[NotNull]
	public List<OrderListItem> OrderList { get; set; }

	public class OrderListItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单id")]
		[NotNull]
		public long? OrderId { get; set; }

		[JsonPropertyName("order_code")]
		[Description("订单码")]
		[NotNull]
		public string OrderCode { get; set; }

		[JsonPropertyName("logistics_code")]
		[Description("运单号")]
		public string LogisticsCode { get; set; }

		[JsonPropertyName("logistics_id")]
		[Description("物流公司id")]
		public long? LogisticsId { get; set; }

		[JsonPropertyName("order_detail")]
		[Description("商品详情")]
		public List<OrderDetailItem> OrderDetail { get; set; }

		public class OrderDetailItem
		{
			[JsonPropertyName("combo_id")]
			[Description("该订单购买的商品对应平台的 sku_id")]
			[NotNull]
			public long? ComboId { get; set; }

			[JsonPropertyName("shop_qty")]
			[Description("发货数量")]
			[NotNull]
			public long? ShopQty { get; set; }

			[JsonPropertyName("sku_barcode")]
			[Description("商品条码")]
			public string SkuBarcode { get; set; }

			[JsonPropertyName("unique_code")]
			[Description("商品唯一标识编码  （如：海宁基地服饰的溯源码信息）")]
			public string UniqueCode { get; set; }

			[JsonPropertyName("lot01")]
			[Description("批次属性01")]
			public string Lot01 { get; set; }
		}
	}
}

[Description("qic流程订单商家发货接口，调用后会绑定订单和订单码，并生成qic入库单，,delivery_type 是 【0】&& ship_type 是【1】，对应一单一包裹模式；,delivery_type 是 【0】&& ship_type 是【3】，对应混订单")]
public class OrderCodeErpShopBindOrderCodeRsp
{
}
