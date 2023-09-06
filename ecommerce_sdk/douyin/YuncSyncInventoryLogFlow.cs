namespace ecommerce.sdk.douyin;

[Description("外部同步库存流水")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务异常","isp.service-error:1000","请重试")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:1001","请核对参数")]
[DouyinRetCode(40004,"非法的参数","鉴权失败","isv.parameter-invalid:1002","请核实服务商编码或仓库编码")]
[DouyinRetCode(50002,"业务处理失败","幂等检查失败","isv.business-failed:1005","请检查是否重复发送")]
public class YuncSyncInventoryLogFlowReq : IDouyinReq<YuncSyncInventoryLogFlowRsp>
{

	public string GetMethod() { return "yunc.syncInventoryLogFlow"; }

	public string GetUrl() { return "/yunc/syncInventoryLogFlow"; }

	[JsonPropertyName("idempotent_no")]
	[Description("(字段长度: 50)幂等键本次请求的唯一键 最大50个字符")]
	[NotNull]
	public string IdempotentNo { get; set; }

	[JsonPropertyName("total_lines")]
	[Description("总行数")]
	[NotNull]
	public long? TotalLines { get; set; }

	[JsonPropertyName("current_page")]
	[Description("当前页数")]
	[NotNull]
	public long? CurrentPage { get; set; }

	[JsonPropertyName("page_size")]
	[Description("本页回传的实际总行数。  不超过500， 否则分多次回传")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("(字段长度: 16)仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("(字段长度: 32)货主编码")]
	[NotNull]
	public string OwnerCode { get; set; }

	[JsonPropertyName("snapshot_time")]
	[Description("操作时间/发生时间 yyyy-MM-dd 对应库存快照业务时间,精确到天")]
	[NotNull]
	public string SnapshotTime { get; set; }

	[JsonPropertyName("api_time")]
	[Description("接口发送时间,秒级")]
	[NotNull]
	public long? ApiTime { get; set; }

	[JsonPropertyName("details")]
	[Description("库存流水明细")]
	[NotNull]
	public List<DetailsItem> Details { get; set; }

	public class DetailsItem
	{
		[JsonPropertyName("occur_time")]
		[Description("业务发生时间,秒级")]
		[NotNull]
		public long? OccurTime { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("(字段长度：64)货品编码")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("cargo_type")]
		[Description("1-普通货品  2-包材  3-耗材")]
		[NotNull]
		public long? CargoType { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("库存类型 1-正品 2-残品")]
		[NotNull]
		public long? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态 1-正常 2-质检 3-冻结")]
		[NotNull]
		public long? InventoryStatus { get; set; }

		[JsonPropertyName("lot_no")]
		[Description("(字段长度：16)批次号")]
		[NotNull]
		public string LotNo { get; set; }

		[JsonPropertyName("product_date")]
		[Description("生产日期")]
		[NotNull]
		public long? ProductDate { get; set; }

		[JsonPropertyName("expire_date")]
		[Description("失效日期")]
		[NotNull]
		public long? ExpireDate { get; set; }

		[JsonPropertyName("receipt_date")]
		[Description("入库日期")]
		[NotNull]
		public long? ReceiptDate { get; set; }

		[JsonPropertyName("supplier_id")]
		[Description("(字段长度：16)供应商")]
		[NotNull]
		public string SupplierId { get; set; }

		[JsonPropertyName("scm_inbound_order")]
		[Description("(字段长度：64)入库单号")]
		[NotNull]
		public string ScmInboundOrder { get; set; }

		[JsonPropertyName("order_type")]
		[Description("(字段长度：32)订单类型 采购入库:PURCHASE_IN;  销退入库:SALE_RETURN_IN;  调拨入库:TRANSFER_IN;  其他入库:OTHER_IN;  销售出库:SALE_OUT;  退仓出库:RTV_OUT;  调拨出库:TRANSFER_OUT;  加工出库:PROCESS_OUT;  加工入库:PROCESS_IN;  转移入库:TRANSFER_PLUS;  转移出库:TRANSFER_REDUCE;  库存调整:INVENTORY_ADJUST")]
		[NotNull]
		public string OrderType { get; set; }

		[JsonPropertyName("wms_order_no")]
		[Description("(字段长度：64)本流水对应的WMS端的入库/出库/库调单号")]
		[NotNull]
		public string WmsOrderNo { get; set; }

		[JsonPropertyName("erp_order_no")]
		[Description("(字段长度：64)本流水对应的上游的单号,入库单号(erp_order_no)、出库单号(erp_order_no)")]
		[NotNull]
		public string ErpOrderNo { get; set; }

		[JsonPropertyName("change_qty")]
		[Description("变更数量  可负")]
		[NotNull]
		public long? ChangeQty { get; set; }

		[JsonPropertyName("unit")]
		[Description("(字段长度：8)单位, 现均默认件")]
		[NotNull]
		public string Unit { get; set; }

		[JsonPropertyName("lot_id")]
		[Description("字段长度(128):批次ID 唯一标识一组批次属性 batch_number + product_date + expire_date + receipt_date + supplier_id + scm_inbound_order + batch_extend")]
		public string LotId { get; set; }

		[JsonPropertyName("batch_extend")]
		[Description("批属性扩展字段，json形式(仅接收规定key)")]
		public string BatchExtend { get; set; }
	}
}

[Description("外部同步库存流水")]
public class YuncSyncInventoryLogFlowRsp
{
	[JsonPropertyName("code")]
	[Description("响应码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("响应信息")]
	public string Msg { get; set; }
}
