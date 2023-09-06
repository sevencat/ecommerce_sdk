namespace ecommerce.sdk.douyin;

[Description("根据筛选条件批量查询售后单列表，单次最多返回100个")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:1020","参数修改")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:1000","重试")]
[DouyinRetCode(20000,"系统错误","业务处理失败","isp.service-error:1040","根据提示处理")]
public class SupplyChainQueryReturnOrderListReq : IDouyinReq<SupplyChainQueryReturnOrderListRsp>
{

	public string GetMethod() { return "supplyChain.queryReturnOrderList"; }

	public string GetUrl() { return "/supplyChain/queryReturnOrderList"; }

	[JsonPropertyName("after_sale_order_no")]
	[Description("售后单号")]
	public string AfterSaleOrderNo { get; set; }

	[JsonPropertyName("channel_trade_order_no")]
	[Description("供货单号")]
	public string ChannelTradeOrderNo { get; set; }

	[JsonPropertyName("standard_order_status")]
	[Description("订单标准状态；1-待抖店同意退款，2-待供应商同意退款，3-待买家退货，4-待供应商收货，5-退款中，6-退款成功，7-售后仲裁中，20-售后取消，21-售后关闭，22-售后拒绝")]
	public int? StandardOrderStatus { get; set; }

	[JsonPropertyName("create_date_begin")]
	[Description("创建时间开始，单位为秒（查询范围包含开始值）")]
	public long? CreateDateBegin { get; set; }

	[JsonPropertyName("create_date_end")]
	[Description("创建结束开始，单位为秒（查询范围包含开始值）")]
	public long? CreateDateEnd { get; set; }

	[JsonPropertyName("page")]
	[Description("页数，从1开始")]
	[NotNull]
	public int? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页数量，最多100个")]
	[NotNull]
	public int? Size { get; set; }

	[JsonPropertyName("order_type")]
	[Description("售后类型；1-退货退款，3-仅退款")]
	public int? OrderType { get; set; }

	[JsonPropertyName("order_asc")]
	[Description("是否创建时间升序排列")]
	public bool? OrderAsc { get; set; }
}

[Description("根据筛选条件批量查询售后单列表，单次最多返回100个")]
public class SupplyChainQueryReturnOrderListRsp
{
	[JsonPropertyName("code")]
	[Description("响应状态码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("响应信息")]
	public string Msg { get; set; }

	[JsonPropertyName("order_list")]
	[Description("售后单信息列表")]
	public List<OrderListItem> OrderList { get; set; }

	public class OrderListItem
	{
		[JsonPropertyName("return_order_no")]
		[Description("售后单号")]
		public string ReturnOrderNo { get; set; }

		[JsonPropertyName("out_order_id")]
		[Description("供销售后关联的抖店售后单号")]
		public string OutOrderId { get; set; }

		[JsonPropertyName("channel_code")]
		[Description("渠道类型")]
		public string ChannelCode { get; set; }

		[JsonPropertyName("reverse_type")]
		[Description("售后类型；1-退货退款，3-仅退款")]
		public long ReverseType { get; set; }

		[JsonPropertyName("supplier_id")]
		[Description("供应商Id")]
		public long SupplierId { get; set; }

		[JsonPropertyName("supplier_name")]
		[Description("供应商名称")]
		public string SupplierName { get; set; }

		[JsonPropertyName("distributor_id")]
		[Description("分销商Id")]
		public long DistributorId { get; set; }

		[JsonPropertyName("distributor_name")]
		[Description("分销商名称")]
		public string DistributorName { get; set; }

		[JsonPropertyName("trade_order_no")]
		[Description("售后单关联的供货单号")]
		public string TradeOrderNo { get; set; }

		[JsonPropertyName("return_total_cnt")]
		[Description("售后数量")]
		public int ReturnTotalCnt { get; set; }

		[JsonPropertyName("return_total_amount")]
		[Description("售后金额，单位：分")]
		public long ReturnTotalAmount { get; set; }

		[JsonPropertyName("is_settled")]
		[Description("是否结算")]
		public bool IsSettled { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间（单位为秒）")]
		public long CreateTime { get; set; }

		[JsonPropertyName("exp_refund_time")]
		[Description("期望退款时间（单位为秒）,超时自动同意退款(仅退款)，超时自动确认收货(退货退款)")]
		public long ExpRefundTime { get; set; }

		[JsonPropertyName("standard_order_status")]
		[Description("订单标准状态；1-待抖店同意退款，2-待供应商同意退款，3-待买家退货，4-待供应商收货，5-退款中，6-退款成功，9-售后仲裁中，20-售后取消，21-售后关闭，22-售后拒绝")]
		public int StandardOrderStatus { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("当前搜索条件下，匹配到的总数量")]
	public long Total { get; set; }
}
