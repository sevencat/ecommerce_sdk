namespace ecommerce.sdk.douyin;

[Description("创建入库单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","下发仓储单据失败","isp.service-error:62303009","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","部分货品不存在[BNS012-黑色踩脚]","isv.business-failed:62302630","货品信息校验不通过，按提示修改")]
[DouyinRetCode(50002,"业务处理失败","62302617:查询条件不能为空","isv.business-failed:62302617","查询条件不能为空")]
[DouyinRetCode(50002,"业务处理失败","1249:该订单已存在，无需重复下发","isv.business-failed:1249","该订单已存在，无需重复下发")]
[DouyinRetCode(50002,"业务处理失败","100100:expectedQty字段缺失","isv.business-failed:100100","请检查expect_qty字段")]
[DouyinRetCode(50002,"业务处理失败","100102:库存异常","isv.business-failed:100102","库存异常，请检查库存之后操作")]
[DouyinRetCode(50002,"业务处理失败","9021:缺少必要参数：送仓明细","isv.business-failed:9021","缺少必要参数：送仓明细")]
public class YuncErpInboundCreateReq : IDouyinReq<YuncErpInboundCreateRsp>
{

	public string GetMethod() { return "yunc.erpInboundCreate"; }

	public string GetUrl() { return "/yunc/erpInboundCreate"; }

	[JsonPropertyName("biz_order_no")]
	[Description("入库单号")]
	[NotNull]
	public string BizOrderNo { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺id（不强校验，填0即可）")]
	[NotNull]
	public long? ShopId { get; set; }

	[JsonPropertyName("order_type")]
	[Description("CGRK 采购入库  DBRK 调拨入库 QTRK其它入库  SCRK生产入库 2BXTRK 2B销退入库")]
	[NotNull]
	public string OrderType { get; set; }

	[JsonPropertyName("action_type")]
	[Description("操作类型 1：新增")]
	[NotNull]
	public short? ActionType { get; set; }

	[JsonPropertyName("related_orders")]
	[Description("关联单据信息")]
	public string RelatedOrders { get; set; }

	[JsonPropertyName("plan_arr_time")]
	[Description("计划到达时间")]
	public long? PlanArrTime { get; set; }

	[JsonPropertyName("late_arr_time")]
	[Description("最晚到达时间")]
	public long? LateArrTime { get; set; }

	[JsonPropertyName("supplier_code")]
	[Description("供应商编码")]
	public string SupplierCode { get; set; }

	[JsonPropertyName("supplier_name")]
	[Description("供应商名称")]
	public string SupplierName { get; set; }

	[JsonPropertyName("delivery_mode")]
	[Description("配送模式（1：物流 2：快递 3：自送）")]
	[NotNull]
	public short? DeliveryMode { get; set; }

	[JsonPropertyName("delivery_extend")]
	[Description("配送扩展字段")]
	public string DeliveryExtend { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓code")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("extend")]
	[Description("扩展字段")]
	public string Extend { get; set; }

	[JsonPropertyName("order_details")]
	[Description("明细")]
	[NotNull]
	public List<OrderDetailsItem> OrderDetails { get; set; }

	public class OrderDetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("行号")]
		[NotNull]
		public string LineNo { get; set; }

		[JsonPropertyName("biz_order_no")]
		[Description("单号")]
		[NotNull]
		public string BizOrderNo { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("平台货品编码 平台货品编码/商品编码两者必填其一，建议优先填写平台货品编码")]
		public string CargoCode { get; set; }

		[JsonPropertyName("erp_sku_id")]
		[Description("商品编码 平台货品编码/商品编码两者必填其一，建议优先填写平台货品编码")]
		public string ErpSkuId { get; set; }

		[JsonPropertyName("expect_qty")]
		[Description("预计收货数量")]
		[NotNull]
		public int? ExpectQty { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("库存类型 1：正品 2：次品")]
		[NotNull]
		public short? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态 1：正常 2：质检 3：冻结")]
		[NotNull]
		public short? InventoryStatus { get; set; }

		[JsonPropertyName("is_batch_assigned")]
		[Description("是否指定批次")]
		[NotNull]
		public short? IsBatchAssigned { get; set; }

		[JsonPropertyName("sn_list")]
		[Description("唯一码")]
		public string SnList { get; set; }

		[JsonPropertyName("product_date")]
		[Description("生产日期")]
		public long? ProductDate { get; set; }

		[JsonPropertyName("expire_date")]
		[Description("过期时间")]
		public long? ExpireDate { get; set; }

		[JsonPropertyName("batch_code")]
		[Description("批次编码")]
		public string BatchCode { get; set; }

		[JsonPropertyName("purchase_price")]
		[Description("采购价格")]
		public long? PurchasePrice { get; set; }

		[JsonPropertyName("currency")]
		[Description("币种")]
		public string Currency { get; set; }

		[JsonPropertyName("extend")]
		[Description("扩展字段")]
		public string Extend { get; set; }
	}

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }
}

[Description("创建入库单")]
public class YuncErpInboundCreateRsp
{
}
