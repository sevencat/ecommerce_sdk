namespace ecommerce.sdk.douyin;

[Description("库存调整(盘点和转移), 如云仓")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","1005:invoke remote failed","isv.business-failed:1005","请重试")]
[DouyinRetCode(40004,"非法的参数","如果adjust_reason=盘点, 每一组line_no下的details.$.adjust_list.size 必须是1","isv.parameter-invalid:840001","请检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","如果adjust_reason=转移, 每一组line_no下的details.$.adjust_list.size 必须是2, 且调整数量正负相抵.","isv.parameter-invalid:840002","如果adjust_reason=转移, 每一组line_no下的details.$.adjust_list.size 必须是2, 且调整数量正负相抵.")]
[DouyinRetCode(50002,"业务处理失败","warehouse not found or disable","isv.business-failed:12001","请重试")]
[DouyinRetCode(50002,"业务处理失败","owner info not found","isv.business-failed:9000","请检查货主信息后重试")]
[DouyinRetCode(50002,"业务处理失败","查询不到货品信息","isv.business-failed:7000","请检查货品信息后重试")]
[DouyinRetCode(20000,"系统错误","幂等调用异常","isp.service-error:1007","请重试")]
[DouyinRetCode(40004,"非法的参数","鉴权失败","isv.parameter-invalid:1003","请检查仓库、货主与货品的关系")]
public class YuncAdjustInventoryReq : IDouyinReq<YuncAdjustInventoryRsp>
{

	public string GetMethod() { return "yunc.adjustInventory"; }

	public string GetUrl() { return "/yunc/adjustInventory"; }

	[JsonPropertyName("inventory_adjust_no")]
	[Description("字段长度(64):库存调整单号")]
	[NotNull]
	public string InventoryAdjustNo { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("字段长度(16):仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("adjust_reason")]
	[Description("调整原因（1-库存盘点，2-库存转移）")]
	[NotNull]
	public short? AdjustReason { get; set; }

	[JsonPropertyName("adjust_time")]
	[Description("调整时间 秒级时间戳")]
	[NotNull]
	public long? AdjustTime { get; set; }

	[JsonPropertyName("remark")]
	[Description("字段长度(1024):备注")]
	[NotNull]
	public string Remark { get; set; }

	[JsonPropertyName("details")]
	[Description("调整明细")]
	public List<DetailsItem> Details { get; set; }

	public class DetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("字段长度(32):行号")]
		[NotNull]
		public string LineNo { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("字段长度(64):平台货品编码")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("erp_sku_id")]
		[Description("字段长度(64):ERP商品ID")]
		public string ErpSkuId { get; set; }

		[JsonPropertyName("owner_code")]
		[Description("字段长度(32):货主编码")]
		[NotNull]
		public string OwnerCode { get; set; }

		[JsonPropertyName("owner_name")]
		[Description("字段长度(128):货主名称")]
		public string OwnerName { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺ID")]
		public long? ShopId { get; set; }

		[JsonPropertyName("adjust_list")]
		[Description("调整列表")]
		[NotNull]
		public List<AdjustListItem> AdjustList { get; set; }

		public class AdjustListItem
		{
			[JsonPropertyName("inventory_type")]
			[Description("库存类型（1-正品/良品，2-次品/残品）")]
			[NotNull]
			public short? InventoryType { get; set; }

			[JsonPropertyName("inventory_status")]
			[Description("库存状态（1-正常，2-质检，3-冻结）")]
			[NotNull]
			public short? InventoryStatus { get; set; }

			[JsonPropertyName("batch_no")]
			[Description("字段长度(32):批次号")]
			public string BatchNo { get; set; }

			[JsonPropertyName("adjust_type")]
			[Description("调整方向（1-调增，2-调减）")]
			[NotNull]
			public short? AdjustType { get; set; }

			[JsonPropertyName("adjust_qty")]
			[Description("调整数量（正整数）")]
			[NotNull]
			public int? AdjustQty { get; set; }

			[JsonPropertyName("product_date")]
			[Description("生产日期，秒级时间戳")]
			public long? ProductDate { get; set; }

			[JsonPropertyName("expire_date")]
			[Description("过期日期，秒级时间戳")]
			public long? ExpireDate { get; set; }

			[JsonPropertyName("receipt_date")]
			[Description("入库日期，秒级时间戳（20220715增加）")]
			public long? ReceiptDate { get; set; }

			[JsonPropertyName("supplier_id")]
			[Description("字段长度(64):供应商ID（20220715增加）")]
			public string SupplierId { get; set; }

			[JsonPropertyName("scm_inbound_order")]
			[Description("字段长度(64):SCM入库单号（20220715增加）")]
			public string ScmInboundOrder { get; set; }

			[JsonPropertyName("lot_id")]
			[Description("字段长度(64): 批次id")]
			public string LotId { get; set; }

			[JsonPropertyName("batch_extend")]
			[Description("字段长度(2048): 批次扩展字段，json格式")]
			public string BatchExtend { get; set; }

			[JsonPropertyName("responsible_dept")]
			[Description("责任部门枚举 100:仓内原因;110:供应商原因")]
			public long? ResponsibleDept { get; set; }

			[JsonPropertyName("reason_code")]
			[Description("原因code枚举 1100001:丢失找回;1100002:出库少发；1100003:误盘;1100004:其他(其他reason_msg必填)；1110001:货物收错；1110002:供应商多送;2110001:箱内少货;2110002:开箱不良;2110003:供应商少送")]
			public long? ReasonCode { get; set; }

			[JsonPropertyName("reason_msg")]
			[Description("原因描述")]
			public string ReasonMsg { get; set; }

			[JsonPropertyName("reason_files")]
			[Description("原因证明材料")]
			public List<string> ReasonFiles { get; set; }
		}
	}
}

[Description("库存调整(盘点和转移), 如云仓")]
public class YuncAdjustInventoryRsp
{
	[JsonPropertyName("data")]
	[Description("响应数据")]
	public string Data { get; set; }
}
