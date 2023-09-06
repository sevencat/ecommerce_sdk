namespace ecommerce.sdk.douyin;

[Description("WMS回传入库数据时使用")]
public class WmsInboundDetailNotifyReq : IDouyinReq<WmsInboundDetailNotifyRsp>
{

	public string GetMethod() { return "wms.inboundDetailNotify"; }

	public string GetUrl() { return "/wms/inboundDetailNotify"; }

	[JsonPropertyName("business_no")]
	[Description("业务单据号")]
	[NotNull]
	public string BusinessNo { get; set; }

	[JsonPropertyName("reciept_no")]
	[Description("WMS入库单据号")]
	[NotNull]
	public string RecieptNo { get; set; }

	[JsonPropertyName("sku_list")]
	[Description("sku列表")]
	[NotNull]
	public List<SkuListItem> SkuList { get; set; }

	public class SkuListItem
	{
		[JsonPropertyName("sku_no")]
		[Description("sku编号")]
		[NotNull]
		public string SkuNo { get; set; }

		[JsonPropertyName("sku_name")]
		[Description("sku名称")]
		public string SkuName { get; set; }

		[JsonPropertyName("quantity")]
		[Description("数量")]
		[NotNull]
		public long? Quantity { get; set; }

		[JsonPropertyName("sn_list")]
		[Description("sn列表")]
		public List<string> SnList { get; set; }

		[JsonPropertyName("quality_level")]
		[Description("品质等级：1 良品，2 不良品")]
		public int? QualityLevel { get; set; }

		[JsonPropertyName("line_no")]
		[Description("行号")]
		public int? LineNo { get; set; }

		[JsonPropertyName("batchs")]
		[Description("批次")]
		public List<BatchsItem> Batchs { get; set; }

		public class BatchsItem
		{
			[JsonPropertyName("batch_no")]
			[Description("批次号")]
			public string BatchNo { get; set; }

			[JsonPropertyName("production_date")]
			[Description("生产日期")]
			public string ProductionDate { get; set; }

			[JsonPropertyName("expiration_date")]
			[Description("过期日期")]
			public string ExpirationDate { get; set; }

			[JsonPropertyName("origin_area")]
			[Description("原产地")]
			public string OriginArea { get; set; }

			[JsonPropertyName("quantity")]
			[Description("数量")]
			public int? Quantity { get; set; }
		}
	}

	[JsonPropertyName("business_type")]
	[Description("业务类型，10采购，20销售，30，其他入库，40调拨入库")]
	[NotNull]
	public int? BusinessType { get; set; }

	[JsonPropertyName("warehouse_no")]
	[Description("入库仓库编码，外部编码")]
	public string WarehouseNo { get; set; }

	[JsonPropertyName("sub_type")]
	[Description("子类型，暂不使用，保留字段")]
	public int? SubType { get; set; }

	[JsonPropertyName("operate_time")]
	[Description("入库时间")]
	[NotNull]
	public string OperateTime { get; set; }

	[JsonPropertyName("box_list")]
	[Description("box")]
	public List<BoxListItem> BoxList { get; set; }

	public class BoxListItem
	{
		[JsonPropertyName("sku_no")]
		[Description("sku编码")]
		public string SkuNo { get; set; }

		[JsonPropertyName("box_id")]
		[Description("箱单id")]
		public string BoxId { get; set; }

		[JsonPropertyName("origin_area")]
		[Description("原产地")]
		public string OriginArea { get; set; }

		[JsonPropertyName("quantity")]
		[Description("数量")]
		public int? Quantity { get; set; }

		[JsonPropertyName("data_code")]
		[Description("生产日期")]
		public string DataCode { get; set; }
	}
}

[Description("WMS回传入库数据时使用")]
public class WmsInboundDetailNotifyRsp
{
}
