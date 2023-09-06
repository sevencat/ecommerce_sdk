namespace ecommerce.sdk.douyin;

[Description("服务商向平台回告入库和提货出库信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","理货报告已存在","isv.business-failed:16002","无需重试")]
[DouyinRetCode(50002,"业务处理失败","1005:接口调用异常，请重试，多次失败请人工反馈","isv.business-failed:1005","暂无")]
[DouyinRetCode(40004,"非法的参数","1002:参数错误","isv.parameter-invalid:1002","核实参数")]
[DouyinRetCode(50002,"业务处理失败","7000:查询不到货品信息","isv.business-failed:7000","理货报告中的货品编码错误")]
[DouyinRetCode(50002,"业务处理失败","1004:回告事件类型不正确，请核实后重试","isv.business-failed:1004","正确回传事件顺序")]
[DouyinRetCode(50002,"业务处理失败","9001:调用货品中心有误","isv.business-failed:9001","货品编码错误")]
[DouyinRetCode(40004,"非法的参数","16003:理货报告url为空","isv.parameter-invalid:16003","填写理货报告url")]
[DouyinRetCode(50002,"业务处理失败","2022:请回传毫秒级别时间戳","isv.business-failed:2022","请回传毫秒级别时间戳")]
[DouyinRetCode(50002,"业务处理失败","14003:unsupported status change, current status is :[OutboundOrderStatusAccepted OutboundOrderCompleteOk], next event status is :%!s(MISSING)","isv.business-failed:14003","状态异常，请检查后重试")]
[DouyinRetCode(50002,"业务处理失败","1001:服务商鉴权失败","isv.business-failed:1001","服务商鉴权失败")]
public class CrossborderWarehouseInOutboundEventReq : IDouyinReq<CrossborderWarehouseInOutboundEventRsp>
{

	public string GetMethod() { return "crossborder.warehouseInOutboundEvent"; }

	public string GetUrl() { return "/crossborder/warehouseInOutboundEvent"; }

	[JsonPropertyName("in_outbound_event_type")]
	[Description("200:入库单仓库已接单 210:入库单接单异常 300:货物到仓 310:货物到仓异常 400:开始理货 410:理货异常 420:理货完成 500:上架完成 510:上架异常 600:入库单取消 1200:出库单已接单 1210:出库单接单异常 1300:提货完成 1310:提货异常 1400:出库单取消 1250:出库理货开始 1260:出库理货异常 1270:出库理货完成")]
	[NotNull]
	public long? InOutboundEventType { get; set; }

	[JsonPropertyName("source_order_no")]
	[Description("来源单据号")]
	[NotNull]
	public string SourceOrderNo { get; set; }

	[JsonPropertyName("sp_order_no")]
	[Description("服务商单据编号")]
	public string SpOrderNo { get; set; }

	[JsonPropertyName("occurrence_time")]
	[Description("实操时间戳 单位：s")]
	[NotNull]
	public long? OccurrenceTime { get; set; }

	[JsonPropertyName("tally_report_url")]
	[Description("理货报告附件url，当回告节点为理货完成时，必传")]
	public List<TallyReportUrlItem> TallyReportUrl { get; set; }

	public class TallyReportUrlItem
	{
		[JsonPropertyName("url")]
		[Description("附件url")]
		[NotNull]
		public string Url { get; set; }

		[JsonPropertyName("name")]
		[Description("附件名称")]
		[NotNull]
		public string Name { get; set; }
	}

	[JsonPropertyName("inbound_cargo_infos")]
	[Description("入库货品信息，回传“上架完成”时，必传")]
	public List<InboundCargoInfosItem> InboundCargoInfos { get; set; }

	public class InboundCargoInfosItem
	{
		[JsonPropertyName("cargo_code")]
		[Description("货品编码")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("actual_stack_count")]
		[Description("实际上架数量")]
		[NotNull]
		public int? ActualStackCount { get; set; }

		[JsonPropertyName("good_cargo_count")]
		[Description("良品数量")]
		[NotNull]
		public int? GoodCargoCount { get; set; }

		[JsonPropertyName("defective_cargo_count")]
		[Description("次品数量")]
		[NotNull]
		public int? DefectiveCargoCount { get; set; }

		[JsonPropertyName("expiry_date")]
		[Description("失效日期 yyyy-MM-dd HH:mm:ss")]
		[NotNull]
		public string ExpiryDate { get; set; }
	}

	[JsonPropertyName("outbound_cargo_infos")]
	[Description("出库货品信息，回传“提货完成”时，必传")]
	public List<OutboundCargoInfosItem> OutboundCargoInfos { get; set; }

	public class OutboundCargoInfosItem
	{
		[JsonPropertyName("cargo_code")]
		[Description("货品编码")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("quality_grade")]
		[Description("质量等级 1:良品 2:次品")]
		[NotNull]
		public long? QualityGrade { get; set; }

		[JsonPropertyName("quantity")]
		[Description("货品数量")]
		[NotNull]
		public int? Quantity { get; set; }

		[JsonPropertyName("extend")]
		[Description("扩展信息")]
		public Dictionary<string,string> Extend { get; set; }
	}

	[JsonPropertyName("error_reason")]
	[Description("异常原因")]
	public string ErrorReason { get; set; }

	[JsonPropertyName("vendor")]
	[Description("服务商编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("tally_report")]
	[Description("理货报告")]
	public TallyReportItem TallyReport { get; set; }

	public class TallyReportItem
	{
		[JsonPropertyName("tally_order_id")]
		[Description("理货单id")]
		[NotNull]
		public string TallyOrderId { get; set; }

		[JsonPropertyName("customs_order_id")]
		[Description("报关单号")]
		public string CustomsOrderId { get; set; }

		[JsonPropertyName("tally_total_qty")]
		[Description("理货总件数")]
		[NotNull]
		public int? TallyTotalQty { get; set; }

		[JsonPropertyName("customs_qty")]
		[Description("报关数量")]
		public int? CustomsQty { get; set; }

		[JsonPropertyName("outbound_tally_date")]
		[Description("出库理货日期，秒")]
		public long? OutboundTallyDate { get; set; }

		[JsonPropertyName("arrival_date")]
		[Description("到库日期，秒")]
		public long? ArrivalDate { get; set; }

		[JsonPropertyName("tally_completed_time")]
		[Description("理货完成日期，秒")]
		[NotNull]
		public long? TallyCompletedTime { get; set; }

		[JsonPropertyName("tally_report_cargo_details")]
		[Description("理货货品明细")]
		[NotNull]
		public List<TallyReportCargoDetailsItem> TallyReportCargoDetails { get; set; }

		public class TallyReportCargoDetailsItem
		{
			[JsonPropertyName("cargo_code")]
			[Description("货品编码")]
			[NotNull]
			public string CargoCode { get; set; }

			[JsonPropertyName("origin_country")]
			[Description("原产国代码（海关原产国代码）")]
			[NotNull]
			public string OriginCountry { get; set; }

			[JsonPropertyName("cargo_name")]
			[Description("货品名称")]
			[NotNull]
			public string CargoName { get; set; }

			[JsonPropertyName("length")]
			[Description("长")]
			[NotNull]
			public int? Length { get; set; }

			[JsonPropertyName("width")]
			[Description("宽")]
			[NotNull]
			public int? Width { get; set; }

			[JsonPropertyName("height")]
			[Description("高")]
			[NotNull]
			public int? Height { get; set; }

			[JsonPropertyName("volume")]
			[Description("体积")]
			[NotNull]
			public long? Volume { get; set; }

			[JsonPropertyName("length_unit")]
			[Description("长度单位，默认mm，可填mm，m，MM，M")]
			public string LengthUnit { get; set; }

			[JsonPropertyName("weight")]
			[Description("重量")]
			[NotNull]
			public int? Weight { get; set; }

			[JsonPropertyName("weight_unit")]
			[Description("重量单位，默认g，可填g，kg，G，KG")]
			public string WeightUnit { get; set; }

			[JsonPropertyName("barcode")]
			[Description("商品条码")]
			[NotNull]
			public string Barcode { get; set; }

			[JsonPropertyName("good_qty")]
			[Description("理货件数（良品）")]
			[NotNull]
			public int? GoodQty { get; set; }

			[JsonPropertyName("defective_qty")]
			[Description("理货件数（次品）")]
			[NotNull]
			public int? DefectiveQty { get; set; }

			[JsonPropertyName("customs_qty")]
			[Description("报关数量")]
			public int? CustomsQty { get; set; }

			[JsonPropertyName("receive_qty")]
			[Description("实收数量")]
			[NotNull]
			public int? ReceiveQty { get; set; }

			[JsonPropertyName("product_batch_no")]
			[Description("生产批次")]
			public string ProductBatchNo { get; set; }

			[JsonPropertyName("product_date")]
			[Description("生产日期，秒")]
			[NotNull]
			public long? ProductDate { get; set; }

			[JsonPropertyName("expiration_date")]
			[Description("失效日期，秒")]
			public long? ExpirationDate { get; set; }

			[JsonPropertyName("difference")]
			[Description("该货品ID，xx产国，总预约到货数为XX，实际理货件数为XX，差异为XX ，若遇同品多行需在表述中注明商品存在多条理货明细，需商家关注")]
			[NotNull]
			public string Difference { get; set; }

			[JsonPropertyName("remark")]
			[Description("备注")]
			public string Remark { get; set; }
		}
	}

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	public string WarehouseCode { get; set; }
}

[Description("服务商向平台回告入库和提货出库信息")]
public class CrossborderWarehouseInOutboundEventRsp
{
	[JsonPropertyName("code")]
	[Description("响应状态码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("响应信息")]
	public string Msg { get; set; }
}
