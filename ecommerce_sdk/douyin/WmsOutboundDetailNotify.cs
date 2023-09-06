namespace ecommerce.sdk.douyin;

[Description("WMS出库时，信息回传调用")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"服务不可用","查询WMS物流产品信息失败，编号=u003eSE0136：java.net.SocketException: Connection reset","isp.service-error:-1","")]
public class WmsOutboundDetailNotifyReq : IDouyinReq<WmsOutboundDetailNotifyRsp>
{

	public string GetMethod() { return "wms.outboundDetailNotify"; }

	public string GetUrl() { return "/wms/outboundDetailNotify"; }

	[JsonPropertyName("business_no")]
	[Description("业务通知单号")]
	[NotNull]
	public string BusinessNo { get; set; }

	[JsonPropertyName("reciept_no")]
	[Description("wms出库单号")]
	[NotNull]
	public string RecieptNo { get; set; }

	[JsonPropertyName("operate_time")]
	[Description("出库时间")]
	[NotNull]
	public string OperateTime { get; set; }

	[JsonPropertyName("warehouse_no")]
	[Description("仓库编码")]
	[NotNull]
	public string WarehouseNo { get; set; }

	[JsonPropertyName("logistics_list")]
	[Description("物流信息")]
	[NotNull]
	public List<LogisticsListItem> LogisticsList { get; set; }

	public class LogisticsListItem
	{
		[JsonPropertyName("weight")]
		[Description("重量")]
		public decimal? Weight { get; set; }

		[JsonPropertyName("length")]
		[Description("长")]
		public decimal? Length { get; set; }

		[JsonPropertyName("width")]
		[Description("宽")]
		public decimal? Width { get; set; }

		[JsonPropertyName("height")]
		[Description("高")]
		public decimal? Height { get; set; }

		[JsonPropertyName("logistics_company_no")]
		[Description("物流公司编码")]
		public string LogisticsCompanyNo { get; set; }

		[JsonPropertyName("logistics_service")]
		[Description("物流产品编码")]
		public string LogisticsService { get; set; }

		[JsonPropertyName("waybill_no")]
		[Description("运单号")]
		public string WaybillNo { get; set; }

		[JsonPropertyName("sku_list")]
		[Description("sku信息")]
		[NotNull]
		public List<SkuListItem> SkuList { get; set; }

		public class SkuListItem
		{
			[JsonPropertyName("sku_no")]
			[Description("sku编码")]
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
		}
	}

	[JsonPropertyName("business_type")]
	[Description("业务类型，10采购退货，20调拨，30 销售订单，40 其他出库")]
	public int? BusinessType { get; set; }

	[JsonPropertyName("sub_type")]
	[Description("子类型，1配货结果通知，2，发货通知，3，仓库签收通知。如果business_type=30,此字段必填。")]
	public int? SubType { get; set; }

	[JsonPropertyName("order_line_list")]
	[Description("明细行")]
	public List<OrderLineListItem> OrderLineList { get; set; }

	public class OrderLineListItem
	{
		[JsonPropertyName("sku_no")]
		[Description("sku编码")]
		[NotNull]
		public string SkuNo { get; set; }

		[JsonPropertyName("quality_level")]
		[Description("质量等级  1正品2次品")]
		public int? QualityLevel { get; set; }

		[JsonPropertyName("line_no")]
		[Description("行号")]
		public long? LineNo { get; set; }

		[JsonPropertyName("quantity")]
		[Description("数量")]
		[NotNull]
		public string Quantity { get; set; }

		[JsonPropertyName("batchs")]
		[Description("批次")]
		public List<BatchsItem> Batchs { get; set; }

		public class BatchsItem
		{
			[JsonPropertyName("batch_no")]
			[Description("批次号")]
			[NotNull]
			public string BatchNo { get; set; }

			[JsonPropertyName("production_date")]
			[Description("生产日期")]
			[NotNull]
			public string ProductionDate { get; set; }

			[JsonPropertyName("expiration_date")]
			[Description("过期日期")]
			public string ExpirationDate { get; set; }

			[JsonPropertyName("origin_area")]
			[Description("原产地")]
			public string OriginArea { get; set; }

			[JsonPropertyName("quantity")]
			[Description("数量")]
			[NotNull]
			public int? Quantity { get; set; }
		}
	}

	[JsonPropertyName("box_list")]
	[Description("箱单")]
	public List<BoxListItem> BoxList { get; set; }

	public class BoxListItem
	{
		[JsonPropertyName("sku_no")]
		[Description("sku")]
		[NotNull]
		public string SkuNo { get; set; }

		[JsonPropertyName("box_id")]
		[Description("boxid")]
		[NotNull]
		public string BoxId { get; set; }

		[JsonPropertyName("origin_area")]
		[Description("生产日期")]
		[NotNull]
		public string OriginArea { get; set; }

		[JsonPropertyName("quantity")]
		[Description("数量")]
		[NotNull]
		public int? Quantity { get; set; }

		[JsonPropertyName("data_code")]
		[Description("生产日期")]
		[NotNull]
		public string DataCode { get; set; }
	}
}

[Description("WMS出库时，信息回传调用")]
public class WmsOutboundDetailNotifyRsp
{
}
