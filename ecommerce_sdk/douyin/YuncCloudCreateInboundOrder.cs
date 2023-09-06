namespace ecommerce.sdk.douyin;

[Description("销退单入库")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","62303009:下发仓储单据失败","isv.business-failed:62303009","联系erp确认配置")]
[DouyinRetCode(50002,"业务处理失败","100200:r_express_no字段缺失","isv.business-failed:100200","联系erp确认配置")]
[DouyinRetCode(50002,"业务处理失败","62303002:接收订单异常，商家未入驻","isv.business-failed:62303002","联系erp确认配置")]
[DouyinRetCode(50002,"业务处理失败","62302630:货品不存在","isv.business-failed:62302630","联系erp确认配置")]
[DouyinRetCode(50002,"业务处理失败","100100:erpSkuId字段缺失","isv.business-failed:100100","请检查erp_sku_id字段")]
[DouyinRetCode(50002,"业务处理失败","1249:该订单已存在，无需重复下发","isv.business-failed:1249","该订单已存在，无需重复下发")]
[DouyinRetCode(50002,"业务处理失败","62302617:查询条件不能为空","isv.business-failed:62302617","查询条件不能为空，请检查参数信息")]
[DouyinRetCode(50002,"业务处理失败","500:500","isv.business-failed:500","业务处理失败")]
[DouyinRetCode(20001,"内部服务超时","服务超时，请重试","isp.service-timeout-error:1103","请重试")]
[DouyinRetCode(50002,"业务处理失败","1001:相同LFO已在创建中","isv.business-failed:1001","业务处理中")]
[DouyinRetCode(50002,"业务处理失败","1271:手工单号重复，请更换","isv.business-failed:1271","手工单号重复，请更换")]
public class YuncCloudCreateInboundOrderReq : IDouyinReq<YuncCloudCreateInboundOrderRsp>
{

	public string GetMethod() { return "yunc.cloudCreateInboundOrder"; }

	public string GetUrl() { return "/yunc/cloudCreateInboundOrder"; }

	[JsonPropertyName("trade_return_no")]
	[Description("交易退货单号")]
	public string TradeReturnNo { get; set; }

	[JsonPropertyName("biz_order_no")]
	[Description("入库单号 必传")]
	[NotNull]
	public string BizOrderNo { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺id 必传")]
	public long? ShopId { get; set; }

	[JsonPropertyName("biz_order_id")]
	[Description("原交易单号 必传")]
	public string BizOrderId { get; set; }

	[JsonPropertyName("s_express_no")]
	[Description("原运单号")]
	public string SExpressNo { get; set; }

	[JsonPropertyName("s_express_name")]
	[Description("原快递公司编码")]
	public string SExpressName { get; set; }

	[JsonPropertyName("r_express_no")]
	[Description("退货运单号 必传")]
	public string RExpressNo { get; set; }

	[JsonPropertyName("r_express_name")]
	[Description("退货快递公司编码 必传")]
	public string RExpressName { get; set; }

	[JsonPropertyName("return_type")]
	[Description("退货类型  1：部分，2：整单")]
	public int? ReturnType { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("extend")]
	[Description("扩展字段")]
	public string Extend { get; set; }

	[JsonPropertyName("order_details")]
	[Description("商品列表")]
	[NotNull]
	public List<OrderDetailsItem> OrderDetails { get; set; }

	public class OrderDetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("行号")]
		[NotNull]
		public string LineNo { get; set; }

		[JsonPropertyName("biz_order_no")]
		[Description("入库单号")]
		[NotNull]
		public string BizOrderNo { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("平台货品编码 平台货品编码/商品编码两者必填其一，建议优先填写平台货品编码")]
		public string CargoCode { get; set; }

		[JsonPropertyName("erp_sku_id")]
		[Description("ERP商品编码 平台货品编码/商品编码两者必填其一，建议优先填写平台货品编码")]
		public string ErpSkuId { get; set; }

		[JsonPropertyName("expect_qty")]
		[Description("应收数量")]
		[NotNull]
		public int? ExpectQty { get; set; }

		[JsonPropertyName("purchase_price")]
		[Description("采购价")]
		public string PurchasePrice { get; set; }

		[JsonPropertyName("currency")]
		[Description("币种")]
		public string Currency { get; set; }

		[JsonPropertyName("sn_list")]
		[Description("唯一码")]
		public string SnList { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("库存类型 1--ZP：正品，2--CP：残品")]
		[NotNull]
		public int? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态 1--ZC：正常，3：冷结，2：质检")]
		[NotNull]
		public int? InventoryStatus { get; set; }

		[JsonPropertyName("is_batch_assigned")]
		[Description("是否强制收货批次 0:否 1:是")]
		[NotNull]
		public int? IsBatchAssigned { get; set; }

		[JsonPropertyName("product_date")]
		[Description("生产日期 时间戳 秒")]
		public long? ProductDate { get; set; }

		[JsonPropertyName("expire_date")]
		[Description("过期日期 时间戳 秒")]
		public long? ExpireDate { get; set; }

		[JsonPropertyName("batch_code")]
		[Description("批次号")]
		public string BatchCode { get; set; }

		[JsonPropertyName("extend")]
		[Description("扩展字段")]
		public string Extend { get; set; }
	}

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }

	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	public string ShopName { get; set; }
}

[Description("销退单入库")]
public class YuncCloudCreateInboundOrderRsp
{
	[JsonPropertyName("data")]
	[Description("响应数据")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("logistics_no")]
		[Description("Lo编码")]
		public string LogisticsNo { get; set; }
	}
}
