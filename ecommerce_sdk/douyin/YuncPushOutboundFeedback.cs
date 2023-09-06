namespace ecommerce.sdk.douyin;

[Description("给外部WMS调用的推送出库信息回传,注意：回告出库状态时，如果有平台的报错信息，需要进行回传信息调整，内部错误可以尝试重试，多次重试失败人工反馈")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","4001:outbound order not found","isv.business-failed:4001","请核实出库单号")]
[DouyinRetCode(50002,"业务处理失败","8000:inventory service sys error","isv.business-failed:8000","请重试")]
[DouyinRetCode(50002,"业务处理失败","4007:出库单已经取消","isv.business-failed:4007","请重新回传")]
[DouyinRetCode(40004,"非法的参数","ParamIllegal","isv.parameter-invalid:1004","请检查ExpireDate后重试")]
[DouyinRetCode(40004,"非法的参数","orderType 类型只能是123","isv.parameter-invalid:4010","请检查orderType后重试")]
[DouyinRetCode(50002,"业务处理失败","不支持的仓系统类型","isv.business-failed:1001","请检查仓库信息后重试")]
[DouyinRetCode(50002,"业务处理失败","warehouse not found or disable","isv.business-failed:12001","请检查仓库信息后重试")]
[DouyinRetCode(50002,"业务处理失败","invoke remote failed","isv.business-failed:1005","请重试")]
[DouyinRetCode(50002,"业务处理失败","invoke remote failed","isv.business-failed:1003","请重试")]
[DouyinRetCode(50002,"业务处理失败","货品数量不一致","isv.business-failed:1071","请核实orderLines和包裹中货品数量是否一致")]
[DouyinRetCode(50002,"业务处理失败","1204:RPCError","isv.business-failed:1204","请重试")]
public class YuncPushOutboundFeedbackReq : IDouyinReq<YuncPushOutboundFeedbackRsp>
{

	public string GetMethod() { return "yunc.pushOutboundFeedback"; }

	public string GetUrl() { return "/yunc/pushOutboundFeedback"; }

	[JsonPropertyName("order_type")]
	[Description("单据类型，必传，1：销售出库，2：调拨出库，3：提货出库，4：跨境提货出库")]
	public long? OrderType { get; set; }

	[JsonPropertyName("outbound_order_no")]
	[Description("字段长度(64):出库单号，必传")]
	public string OutboundOrderNo { get; set; }

	[JsonPropertyName("event_type")]
	[Description("事件类型，必传，创单成功-1、波次组建完成-2、拣货中-3、拣选完成-4、集货完成-5、分拣完成-6、复核中-7、包装完成-8、称重-9、发货完成-10、缺货异常-21")]
	public long? EventType { get; set; }

	[JsonPropertyName("event_description")]
	[Description("字段长度(200):事件描述")]
	public string EventDescription { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("字段长度(16):仓编码，必传")]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("extend")]
	[Description("字段长度(2048):扩展字段")]
	public string Extend { get; set; }

	[JsonPropertyName("slip_no")]
	[Description("字段长度(64):单据变化的流水号,必传，需要保证唯一")]
	public string SlipNo { get; set; }

	[JsonPropertyName("occur_time")]
	[Description("事件发生时间，必传")]
	public long? OccurTime { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("字段长度(32):货主编码，必传")]
	public string OwnerCode { get; set; }

	[JsonPropertyName("package_infos")]
	[Description("包裹信息，订单类型=1时必传")]
	public List<PackageInfosItem> PackageInfos { get; set; }

	public class PackageInfosItem
	{
		[JsonPropertyName("package_no")]
		[Description("字段长度(64):必传，实操层复核打包完即将发快递时,实操层生成的包裹号")]
		public string PackageNo { get; set; }

		[JsonPropertyName("length")]
		[Description("长，单位cm")]
		public long? Length { get; set; }

		[JsonPropertyName("width")]
		[Description("宽，单位cm")]
		public long? Width { get; set; }

		[JsonPropertyName("height")]
		[Description("高，单位cm")]
		public long? Height { get; set; }

		[JsonPropertyName("volume")]
		[Description("体积，单位cm3")]
		public long? Volume { get; set; }

		[JsonPropertyName("weight")]
		[Description("重量，单位g，必传")]
		public long? Weight { get; set; }

		[JsonPropertyName("packed_time")]
		[Description("打包时间")]
		public long? PackedTime { get; set; }

		[JsonPropertyName("shipped_time")]
		[Description("发货时间")]
		public long? ShippedTime { get; set; }

		[JsonPropertyName("create_time")]
		[Description("包裹创建时间")]
		public long? CreateTime { get; set; }

		[JsonPropertyName("logistics")]
		[Description("运输信息")]
		public LogisticsItem Logistics { get; set; }

		public class LogisticsItem
		{
			[JsonPropertyName("express_product_type")]
			[Description("字段长度(64):物流产品类型编码")]
			public string ExpressProductType { get; set; }

			[JsonPropertyName("logistics_code")]
			[Description("字段长度(64):快递公司/物流公司，必传")]
			public string LogisticsCode { get; set; }

			[JsonPropertyName("track_no")]
			[Description("运字段长度(64):单号/面单号，必传")]
			public string TrackNo { get; set; }

			[JsonPropertyName("delivery_mode")]
			[Description("运输方式：物流-1；快递-2；自提-3")]
			public long? DeliveryMode { get; set; }
		}

		[JsonPropertyName("package_items")]
		[Description("货品编码")]
		public List<PackageItemsItem> PackageItems { get; set; }

		public class PackageItemsItem
		{
			[JsonPropertyName("cargo_code")]
			[Description("字段长度(64):货品编码，必传")]
			public string CargoCode { get; set; }

			[JsonPropertyName("cargo_name")]
			[Description("字段长度(200):货品名称")]
			public string CargoName { get; set; }

			[JsonPropertyName("unit")]
			[Description("字段长度(32):包装单位")]
			public string Unit { get; set; }

			[JsonPropertyName("inventory_type")]
			[Description("库存类型，必传,正品-1，残次-2")]
			public long? InventoryType { get; set; }

			[JsonPropertyName("inventory_status")]
			[Description("库存状态,正常-1，质检-2，冻结-3")]
			public long? InventoryStatus { get; set; }

			[JsonPropertyName("quantity")]
			[Description("数量，必传")]
			public long? Quantity { get; set; }

			[JsonPropertyName("batch_info")]
			[Description("批次信息，20220715增加")]
			public BatchInfoItem BatchInfo { get; set; }

			public class BatchInfoItem
			{
				[JsonPropertyName("batch_number")]
				[Description("字段长度(64):批次号，20220715增加")]
				public string BatchNumber { get; set; }

				[JsonPropertyName("product_date")]
				[Description("生产日期，20220715增加")]
				public long? ProductDate { get; set; }

				[JsonPropertyName("expire_date")]
				[Description("失效日期，20220715增加")]
				public long? ExpireDate { get; set; }

				[JsonPropertyName("receipt_date")]
				[Description("入库日期，20220715增加")]
				public long? ReceiptDate { get; set; }

				[JsonPropertyName("supplier_id")]
				[Description("字段长度(64):供应商，20220715增加")]
				public string SupplierId { get; set; }

				[JsonPropertyName("scm_inbound_order")]
				[Description("字段长度(64):scm入库单号，20220715增加")]
				public string ScmInboundOrder { get; set; }

				[JsonPropertyName("lot_id")]
				[Description("字段长度(64):批次id")]
				public string LotId { get; set; }

				[JsonPropertyName("batch_extend")]
				[Description("字段长度(2048):批次扩展字段，json格式")]
				public string BatchExtend { get; set; }
			}

			[JsonPropertyName("line_no")]
			[Description("字段长度(64):出库单行号，20220715增加")]
			public string LineNo { get; set; }
		}

		[JsonPropertyName("composition_mode")]
		[Description("0-普通件、1-子母件、2-独立件，20220715增加")]
		public int? CompositionMode { get; set; }

		[JsonPropertyName("length_unit")]
		[Description("字段长度(32):长宽高单位，20220715增加")]
		public string LengthUnit { get; set; }

		[JsonPropertyName("weight_unit")]
		[Description("字段长度(32):重量单位，20220715增加")]
		public string WeightUnit { get; set; }

		[JsonPropertyName("expect_weight")]
		[Description("理论重量，单位g，必传，20220715增加")]
		public int? ExpectWeight { get; set; }

		[JsonPropertyName("pm_infos")]
		[Description("包裹绑定的包耗材信息")]
		public List<PmInfosItem> PmInfos { get; set; }

		public class PmInfosItem
		{
			[JsonPropertyName("name")]
			[Description("包耗材名称")]
			public string Name { get; set; }

			[JsonPropertyName("pm_type")]
			[Description("包耗材类型 0-包材 1-耗材")]
			public int? PmType { get; set; }

			[JsonPropertyName("num")]
			[Description("包耗材数量")]
			public int? Num { get; set; }

			[JsonPropertyName("owner_id")]
			[Description("包耗材所属货主ID")]
			public long? OwnerId { get; set; }

			[JsonPropertyName("cargo_code")]
			[Description("包耗材对应货主编码")]
			public string CargoCode { get; set; }

			[JsonPropertyName("pm_category")]
			[Description("包耗材类别 0-实际 1-推荐")]
			public int? PmCategory { get; set; }

			[JsonPropertyName("pm_code")]
			[Description("包耗材编码")]
			public string PmCode { get; set; }

			[JsonPropertyName("barcode")]
			[Description("包耗材条码")]
			public string Barcode { get; set; }

			[JsonPropertyName("owner_code")]
			[Description("包耗材所属货主编码")]
			public string OwnerCode { get; set; }

			[JsonPropertyName("owner_name")]
			[Description("包耗材所属货主名称")]
			public string OwnerName { get; set; }

			[JsonPropertyName("source")]
			[Description("包耗材来源 1-自建 2-货品中心")]
			public int? Source { get; set; }
		}
	}

	[JsonPropertyName("order_lines")]
	[Description("订单明细，必传")]
	public List<OrderLinesItem> OrderLines { get; set; }

	public class OrderLinesItem
	{
		[JsonPropertyName("package_no")]
		[Description("包裹号，分批发货事件必传")]
		public string PackageNo { get; set; }

		[JsonPropertyName("line_no")]
		[Description("字段长度(64):出库单行号，必传")]
		public string LineNo { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("字段长度(64):货品编码，必传")]
		public string CargoCode { get; set; }

		[JsonPropertyName("cargo_name")]
		[Description("字段长度(200):货品名称")]
		public string CargoName { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("库存类型，必传，1-正品 2-残次")]
		public long? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态，必传，1-正常 2-质检 3-冻结")]
		public long? InventoryStatus { get; set; }

		[JsonPropertyName("shipped_qty")]
		[Description("实际发货数量，必传")]
		public long? ShippedQty { get; set; }

		[JsonPropertyName("sn_list")]
		[Description("字段长度(2048):序列号，以英文逗号分隔")]
		public string SnList { get; set; }

		[JsonPropertyName("product_date")]
		[Description("生产日期")]
		public long? ProductDate { get; set; }

		[JsonPropertyName("expire_date")]
		[Description("过期日期")]
		public long? ExpireDate { get; set; }

		[JsonPropertyName("batch_code")]
		[Description("字段长度(64):生产批次号")]
		public string BatchCode { get; set; }

		[JsonPropertyName("batch_info")]
		[Description("批属性信息，20220715增加")]
		public BatchInfoItem BatchInfo { get; set; }

		public class BatchInfoItem
		{
			[JsonPropertyName("batch_number")]
			[Description("字段长度(64):批次号，20220715增加")]
			public string BatchNumber { get; set; }

			[JsonPropertyName("product_date")]
			[Description("生产日期，为了和老逻辑兼容  BatchInfo内外都要传此字段，20220715增加")]
			public long? ProductDate { get; set; }

			[JsonPropertyName("expire_date")]
			[Description("过期时间，为了和老逻辑兼容  BatchInfo内外都要传此字段，20220715增加")]
			public long? ExpireDate { get; set; }

			[JsonPropertyName("receipt_date")]
			[Description("入库日期，20220715增加")]
			public long? ReceiptDate { get; set; }

			[JsonPropertyName("supplier_Id")]
			[Description("字段长度(64):供应商，20220715增加")]
			public string SupplierId { get; set; }

			[JsonPropertyName("scm_inbound_order")]
			[Description("字段长度(64):SCM入库单号，20220715增加")]
			public string ScmInboundOrder { get; set; }

			[JsonPropertyName("lot_id")]
			[Description("字段长度(64):批次id")]
			public string LotId { get; set; }

			[JsonPropertyName("batch_extend")]
			[Description("字段长度(2048):批次扩展字段，json格式")]
			public string BatchExtend { get; set; }
		}
	}

	[JsonPropertyName("event_extend_body")]
	[Description("事件扩展结构体，回传缺货异常事件的时候需要填充该字段，20220715增加")]
	public List<EventExtendBodyItem> EventExtendBody { get; set; }

	public class EventExtendBodyItem
	{
		[JsonPropertyName("line_no")]
		[Description("字段长度(64):出库单行号，必传，20220715增加")]
		public string LineNo { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("字段长度(64):货品编码，必传，20220715增加")]
		public string CargoCode { get; set; }

		[JsonPropertyName("num")]
		[Description("数量，20220715增加")]
		public long? Num { get; set; }
	}

	[JsonPropertyName("current_package_no")]
	[Description("当前包裹号，分批发货事件必传")]
	public string CurrentPackageNo { get; set; }
}

[Description("给外部WMS调用的推送出库信息回传,注意：回告出库状态时，如果有平台的报错信息，需要进行回传信息调整，内部错误可以尝试重试，多次重试失败人工反馈")]
public class YuncPushOutboundFeedbackRsp
{
}
