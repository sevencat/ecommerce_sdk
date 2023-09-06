namespace ecommerce.sdk.douyin;

[Description("查询跨境订单列表,查询跨境订单列表")]
public class CrossBorderOrderListReq : IDouyinReq<CrossBorderOrderListRsp>
{

	public string GetMethod() { return "crossBorder.orderList"; }

	public string GetUrl() { return "/crossBorder/orderList"; }

	[JsonPropertyName("vendor")]
	[Description("字节给供应链服务商定义的编码")]
	[NotNull]
	public string Vendor { get; set; }

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
	[Description("页数（默认为0，第一页从0开始）")]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页模板数（默认为10）")]
	public long? Size { get; set; }
}

[Description("查询跨境订单列表,查询跨境订单列表")]
public class CrossBorderOrderListRsp
{
	[JsonPropertyName("data")]
	[Description("订单数据结构")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单编号 （交易订单号）")]
		public string OrderId { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("商家店铺在电商平台的ID")]
		public long ShopId { get; set; }

		[JsonPropertyName("status")]
		[Description("BC/BBC模式：该字段返回支付单申报未完成（具体见上表枚举值），以下字段均不展示，只展示当前及以上字段；其它状态均展示全部字段 CC模式：无区分")]
		public int Status { get; set; }

		[JsonPropertyName("ebp_code")]
		[Description("电商平台代码（电商平台海关备案编码）")]
		public string EbpCode { get; set; }

		[JsonPropertyName("ebp_name")]
		[Description("电商平台名称 （电商平台海关备案名称）")]
		public string EbpName { get; set; }

		[JsonPropertyName("ie_flag")]
		[Description("进出口标志   I-进口,E-出口")]
		public string IeFlag { get; set; }

		[JsonPropertyName("customs_clear_type")]
		[Description("通关模式  1BBC  2BC  3CC")]
		public int CustomsClearType { get; set; }

		[JsonPropertyName("customs_code")]
		[Description("申报海关代码 （海关关区代码）目前业务和portCode保持一致")]
		public string CustomsCode { get; set; }

		[JsonPropertyName("port_code")]
		[Description("口岸海关代码  商品实际进出我国关境口岸海关 的关区代码  （海关关区代码）")]
		public string PortCode { get; set; }

		[JsonPropertyName("warehouse_code")]
		[Description("仓库编码（商家自定义商家仓code）")]
		public string WarehouseCode { get; set; }

		[JsonPropertyName("goods_value")]
		[Description("商品实际成交价， 含非现金抵扣金额,（商品不含税价*商品数量）单位是分")]
		public long GoodsValue { get; set; }

		[JsonPropertyName("freight")]
		[Description("运杂费（含物流保费） 免邮传0  单位是分")]
		public long Freight { get; set; }

		[JsonPropertyName("discount")]
		[Description("非现金抵扣金额（不含支付满减）  使用积分等非现金支付金额，无则填写 0 单位是分")]
		public long Discount { get; set; }

		[JsonPropertyName("tax_total")]
		[Description("代扣税款  企业预先代扣的税款金额，无则填写“0” 单位是分")]
		public string TaxTotal { get; set; }

		[JsonPropertyName("actural_paid")]
		[Description("实际支付金额（商品价格+运杂费+代扣税款- 非现金抵扣金额）单位是分")]
		public long ActuralPaid { get; set; }

		[JsonPropertyName("insured_fee")]
		[Description("物流保费（物流保价费）  一般传0  单位是分")]
		public long InsuredFee { get; set; }

		[JsonPropertyName("currency")]
		[Description("币制 限定为人民币，填写“142”")]
		public string Currency { get; set; }

		[JsonPropertyName("buyer_reg_no")]
		[Description("订购人注册号")]
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

		[JsonPropertyName("pay_code")]
		[Description("支付企业编码（BC/BBC下发）")]
		public string PayCode { get; set; }

		[JsonPropertyName("pay_name")]
		[Description("支付企业在海关注册登记的企业名称")]
		public string PayName { get; set; }

		[JsonPropertyName("pay_transaction_id")]
		[Description("支付企业唯一的支付流水号")]
		public string PayTransactionId { get; set; }

		[JsonPropertyName("pack_no")]
		[Description("件数  件数为包裹数量， 限定为“1”")]
		public long PackNo { get; set; }

		[JsonPropertyName("note")]
		[Description("订单申报备注（扩展字段预留）")]
		public string Note { get; set; }

		[JsonPropertyName("create_time")]
		[Description("跨境履约单创建时间（UnixTime 以ms为单位）")]
		public long CreateTime { get; set; }

		[JsonPropertyName("pay_time")]
		[Description("支付完成时间（UnixTime 以ms为单位）")]
		public long PayTime { get; set; }

		[JsonPropertyName("ebc_code")]
		[Description("电商企业备案编码")]
		public string EbcCode { get; set; }

		[JsonPropertyName("ebc_name")]
		[Description("电商企业备案名称")]
		public string EbcName { get; set; }

		[JsonPropertyName("scsp_warehouse_code")]
		[Description("服务商仓库编码（KA商家无需使用）")]
		public string ScspWarehouseCode { get; set; }

		[JsonPropertyName("order_detail_list")]
		[Description("订单明细信息")]
		public List<OrderDetailListItem> OrderDetailList { get; set; }

		public class OrderDetailListItem
		{
			[JsonPropertyName("gnum")]
			[Description("订单明细序号")]
			public long Gnum { get; set; }

			[JsonPropertyName("sku_id")]
			[Description("字节平台商品sku id")]
			public string SkuId { get; set; }

			[JsonPropertyName("item_no")]
			[Description("商家货号（商家仓储自定义货品编码）")]
			public string ItemNo { get; set; }

			[JsonPropertyName("item_name")]
			[Description("平台商品名称 （商家在电商平台创建的名称）")]
			public string ItemName { get; set; }

			[JsonPropertyName("g_model")]
			[Description("商品规格型号")]
			public string GModel { get; set; }

			[JsonPropertyName("item_describe")]
			[Description("平台商品描述 （商家在电商平台创建的描述 ）")]
			public string ItemDescribe { get; set; }

			[JsonPropertyName("bar_code")]
			[Description("条形码（SKU条形码）")]
			public string BarCode { get; set; }

			[JsonPropertyName("unit")]
			[Description("法定计量单位")]
			public string Unit { get; set; }

			[JsonPropertyName("qty")]
			[Description("商品实际数量")]
			public long Qty { get; set; }

			[JsonPropertyName("price")]
			[Description("单价（商品不含税价，不含运费保费）   单位是分 BBC/BC：单价；CC：实付单价")]
			public long Price { get; set; }

			[JsonPropertyName("total_price")]
			[Description("总价   单位是分 BBC/BC总价（商品不含税价，不含保费运费）；CC：实付总价")]
			public long TotalPrice { get; set; }

			[JsonPropertyName("currency")]
			[Description("币制")]
			public string Currency { get; set; }

			[JsonPropertyName("country")]
			[Description("原产国")]
			public string Country { get; set; }

			[JsonPropertyName("hs_code")]
			[Description("跨境商品HSCODE税号编码（CC商品无该信息）")]
			public string HsCode { get; set; }

			[JsonPropertyName("first_measure_qty")]
			[Description("法一数量 （第一法定计量单位数量）")]
			public string FirstMeasureQty { get; set; }

			[JsonPropertyName("second_measure_qty")]
			[Description("法二数量 （第二法定计量单位数量）")]
			public string SecondMeasureQty { get; set; }

			[JsonPropertyName("first_measure_unit")]
			[Description("法一计量单位")]
			public string FirstMeasureUnit { get; set; }

			[JsonPropertyName("second_measure_unit")]
			[Description("法二计量单位")]
			public string SecondMeasureUnit { get; set; }

			[JsonPropertyName("note")]
			[Description("备注")]
			public string Note { get; set; }
		}

		[JsonPropertyName("pre_sale_type")]
		[Description("预售类型 0:现货发货模式，1:全款预售发货模式")]
		public int PreSaleType { get; set; }

		[JsonPropertyName("exp_ship_time")]
		[Description("发货超时时间")]
		public long ExpShipTime { get; set; }

		[JsonPropertyName("wh_type")]
		[Description("服务商仓类型")]
		public int WhType { get; set; }

		[JsonPropertyName("order_declare")]
		[Description("订单申报类型 1服务商申报, 2平台申报")]
		public int OrderDeclare { get; set; }

		[JsonPropertyName("logistics_declare")]
		[Description("运单申报类型，1服务商申报，2平台申报")]
		public int LogisticsDeclare { get; set; }

		[JsonPropertyName("inventory_declare")]
		[Description("清单申报类型，1服务商申报，2平台申报")]
		public int InventoryDeclare { get; set; }
	}

	[JsonPropertyName("has_next")]
	[Description("是否还有下一页")]
	public bool HasNext { get; set; }

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
