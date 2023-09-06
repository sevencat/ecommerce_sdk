namespace ecommerce.sdk.douyin;

[Description("回告翻仓出库单信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","1000:内部异常","isv.business-failed:1000","内部异常，请联系系统人员处理")]
[DouyinRetCode(50002,"业务处理失败","13002:单据正在处理中","isv.business-failed:13002","请求正在处理，请稍候重试")]
[DouyinRetCode(50002,"业务处理失败","1202:数据库记录不存在，请确认后重试","isv.business-failed:1202","确认单据是否已创建")]
[DouyinRetCode(50002,"业务处理失败","1001:参数异常","isv.business-failed:1001","请检查参数是否合法")]
[DouyinRetCode(50002,"业务处理失败","12000:获取仓库信息失败，请检查编码是否有效","isv.business-failed:12000","检查仓库信息")]
public class YuncReflowOutboundCallbackReq : IDouyinReq<YuncReflowOutboundCallbackRsp>
{

	public string GetMethod() { return "yunc.reflow.outboundCallback"; }

	public string GetUrl() { return "/yunc/reflow/outboundCallback"; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("outbound_order_no")]
	[Description("出库单号")]
	[NotNull]
	public string OutboundOrderNo { get; set; }

	[JsonPropertyName("order_type")]
	[Description("出库单类型（XSCK-销售出库，TCCK-退仓出库，DBCK-调拨出库，QTCK-其他出库，SCCK-生产出库）")]
	[NotNull]
	public string OrderType { get; set; }

	[JsonPropertyName("event_type")]
	[Description("事件类型（1-创单成功，2-波次组建完成，3-拣货中，4-拣选完成，5-集货完成，6-分拣完成，7-复核中，8-打包完成，9-称重，21-缺货异常，10-发货完成，20-单据取消）")]
	[NotNull]
	public int? EventType { get; set; }

	[JsonPropertyName("extend")]
	[Description("扩展字段")]
	public Dictionary<string,string> Extend { get; set; }

	[JsonPropertyName("slip_no")]
	[Description("幂等号（唯一流水号，必填）")]
	public string SlipNo { get; set; }

	[JsonPropertyName("occur_time")]
	[Description("事件发生时间（必填）")]
	public long? OccurTime { get; set; }

	[JsonPropertyName("package_infos")]
	[Description("包裹明细（event_type=10 & order_type=XSCK时必填）")]
	public List<PackageInfosItem> PackageInfos { get; set; }

	public class PackageInfosItem
	{
		[JsonPropertyName("package_no")]
		[Description("包裹号（必填）")]
		public string PackageNo { get; set; }

		[JsonPropertyName("length")]
		[Description("长（必填，可为0）")]
		public long? Length { get; set; }

		[JsonPropertyName("width")]
		[Description("宽（必填，可为0）")]
		public long? Width { get; set; }

		[JsonPropertyName("height")]
		[Description("高（必填，可为0）")]
		public long? Height { get; set; }

		[JsonPropertyName("length_unit")]
		[Description("长度单位（必填，mm,cm,m）")]
		public string LengthUnit { get; set; }

		[JsonPropertyName("volume")]
		[Description("体积（必填，可为0）")]
		public long? Volume { get; set; }

		[JsonPropertyName("volume_unit")]
		[Description("体积单位（必填，mm3,cm3,m3）")]
		public string VolumeUnit { get; set; }

		[JsonPropertyName("actual_weight")]
		[Description("称重重量（必填，可为0）")]
		public long? ActualWeight { get; set; }

		[JsonPropertyName("expect_weight")]
		[Description("理论重量（必填，可为0）")]
		public long? ExpectWeight { get; set; }

		[JsonPropertyName("weight_unit")]
		[Description("重量单位（必填，mg,g,kg）")]
		public string WeightUnit { get; set; }

		[JsonPropertyName("packed_time")]
		[Description("打包时间（必填）")]
		public long? PackedTime { get; set; }

		[JsonPropertyName("shipped_time")]
		[Description("发货时间（必填）")]
		public long? ShippedTime { get; set; }

		[JsonPropertyName("create_time")]
		[Description("包裹创建时间（必填）")]
		public long? CreateTime { get; set; }

		[JsonPropertyName("logistics")]
		[Description("运输信息")]
		public LogisticsItem Logistics { get; set; }

		public class LogisticsItem
		{
			[JsonPropertyName("express")]
			[Description("快递公司/物流公司（必填）")]
			public string Express { get; set; }

			[JsonPropertyName("track_no")]
			[Description("运单号/面单号（必填）")]
			public string TrackNo { get; set; }

			[JsonPropertyName("delivery_mode")]
			[Description("运输方式（1-物流，2-快递，3-自提）")]
			public short? DeliveryMode { get; set; }
		}

		[JsonPropertyName("package_items")]
		[Description("货品信息（必填）")]
		public List<PackageItemsItem> PackageItems { get; set; }

		public class PackageItemsItem
		{
			[JsonPropertyName("line_no")]
			[Description("行号（必填）")]
			public string LineNo { get; set; }

			[JsonPropertyName("cargo_code")]
			[Description("货品编码（必填）")]
			public string CargoCode { get; set; }

			[JsonPropertyName("cargo_name")]
			[Description("货品名称（必填）")]
			public string CargoName { get; set; }

			[JsonPropertyName("unit")]
			[Description("包装单位（必填）")]
			public string Unit { get; set; }

			[JsonPropertyName("inventory_type")]
			[Description("库存类型（必填，1-正品，2-残品）")]
			public int? InventoryType { get; set; }

			[JsonPropertyName("inventory_status")]
			[Description("库存状态（必填，1-正常，2-质检，3-冻结）")]
			public int? InventoryStatus { get; set; }

			[JsonPropertyName("quantity")]
			[Description("数量（必填）")]
			public long? Quantity { get; set; }

			[JsonPropertyName("batch_info")]
			[Description("批属性")]
			public BatchInfoItem BatchInfo { get; set; }

			public class BatchInfoItem
			{
				[JsonPropertyName("batch_number")]
				[Description("批次号")]
				public string BatchNumber { get; set; }

				[JsonPropertyName("product_date")]
				[Description("生产日期")]
				public long? ProductDate { get; set; }

				[JsonPropertyName("expire_date")]
				[Description("失效日期")]
				public long? ExpireDate { get; set; }

				[JsonPropertyName("receipt_date")]
				[Description("入库日期")]
				public long? ReceiptDate { get; set; }

				[JsonPropertyName("supplier_id")]
				[Description("供应商ID")]
				public string SupplierId { get; set; }

				[JsonPropertyName("scm_inbound_order")]
				[Description("SCM入库单号")]
				public string ScmInboundOrder { get; set; }
			}
		}

		[JsonPropertyName("pm_infos")]
		[Description("包耗材信息")]
		public List<PmInfosItem> PmInfos { get; set; }

		public class PmInfosItem
		{
			[JsonPropertyName("code")]
			[Description("包耗材编码")]
			public string Code { get; set; }

			[JsonPropertyName("name")]
			[Description("包耗材名称")]
			public string Name { get; set; }

			[JsonPropertyName("type")]
			[Description("包耗材类型（0-包材，1-耗材）")]
			public int? Type { get; set; }

			[JsonPropertyName("category")]
			[Description("包耗材类别（0-实际，1-推荐）")]
			public int? Category { get; set; }

			[JsonPropertyName("num")]
			[Description("数量")]
			public int? Num { get; set; }

			[JsonPropertyName("cargo_code")]
			[Description("对应货品编码")]
			public string CargoCode { get; set; }

			[JsonPropertyName("bar_code")]
			[Description("包耗材条码")]
			public string BarCode { get; set; }

			[JsonPropertyName("owner_code")]
			[Description("所属货主编码")]
			public string OwnerCode { get; set; }

			[JsonPropertyName("owner_name")]
			[Description("所属货主名称")]
			public string OwnerName { get; set; }
		}

		[JsonPropertyName("composition_mode")]
		[Description("包裹组成方式（必填，0-普通件，1-子母件，2-独立件）")]
		public int? CompositionMode { get; set; }
	}

	[JsonPropertyName("details")]
	[Description("出库单明细（event_type=10时必填）")]
	public List<DetailsItem> Details { get; set; }

	public class DetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("行号（必填）")]
		public string LineNo { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("货品编码（必填）")]
		public string CargoCode { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("库存类型（必填，1-正品，2-残品）")]
		public int? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态（必填，1-正常，2-质检，3-冻结）")]
		public int? InventoryStatus { get; set; }

		[JsonPropertyName("shipped_qty")]
		[Description("实际出库数量（必填）")]
		public long? ShippedQty { get; set; }

		[JsonPropertyName("batch_info")]
		[Description("批属性")]
		public BatchInfoItem BatchInfo { get; set; }

		public class BatchInfoItem
		{
			[JsonPropertyName("batch_number")]
			[Description("批次号")]
			public string BatchNumber { get; set; }

			[JsonPropertyName("product_date")]
			[Description("生产日期")]
			public long? ProductDate { get; set; }

			[JsonPropertyName("expire_date")]
			[Description("失效日期")]
			public long? ExpireDate { get; set; }

			[JsonPropertyName("receipt_date")]
			[Description("入库日期")]
			public long? ReceiptDate { get; set; }

			[JsonPropertyName("supplier_id")]
			[Description("供应商ID")]
			public string SupplierId { get; set; }

			[JsonPropertyName("scm_inbound_order")]
			[Description("SCM入库单号")]
			public string ScmInboundOrder { get; set; }
		}
	}
}

[Description("回告翻仓出库单信息")]
public class YuncReflowOutboundCallbackRsp
{
	[JsonPropertyName("code")]
	[Description("错误码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("错误信息")]
	public string Msg { get; set; }
}
