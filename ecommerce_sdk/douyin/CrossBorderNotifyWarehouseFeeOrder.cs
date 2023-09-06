namespace ecommerce.sdk.douyin;

[Description("服务商回传仓租计费明细")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统内部错误","isp.service-error:1005","联系平台研发")]
[DouyinRetCode(40004,"非法的参数","参数非法","isv.parameter-invalid:20001","修正参数重新传参")]
[DouyinRetCode(20000,"系统错误","系统内部错误","isp.service-error:20002","联系平台研发")]
[DouyinRetCode(50002,"业务处理失败","无效的状态越迁","isv.business-failed:20003","联系平台研发")]
[DouyinRetCode(50002,"业务处理失败","存在重复的记录","isv.business-failed:20004","联系平台研发")]
[DouyinRetCode(80000,"风控拦截","未授权访问","isv.risk-control-failed:20005","获取授权")]
public class CrossBorderNotifyWarehouseFeeOrderReq : IDouyinReq<CrossBorderNotifyWarehouseFeeOrderRsp>
{

	public string GetMethod() { return "crossBorder.notifyWarehouseFeeOrder"; }

	public string GetUrl() { return "/crossBorder/notifyWarehouseFeeOrder"; }

	[JsonPropertyName("ws_store_no")]
	[Description("仓租单号")]
	[NotNull]
	public string WsStoreNo { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("fee_date")]
	[Description("计费日期。 十位秒级时间戳，需要截断时分秒，否则会被校验住报错。 如 1640966400  表示2022-01-01 00:00:00")]
	[NotNull]
	public long? FeeDate { get; set; }

	[JsonPropertyName("need_charge")]
	[Description("是否需要计费")]
	[NotNull]
	public bool? NeedCharge { get; set; }

	[JsonPropertyName("vendor")]
	[Description("服务商编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("detail_list")]
	[Description("当仓租单需要计费时必传")]
	public List<DetailListItem> DetailList { get; set; }

	public class DetailListItem
	{
		[JsonPropertyName("cargo_code")]
		[Description("货品编码")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("order_no")]
		[Description("订单号")]
		[NotNull]
		public string OrderNo { get; set; }

		[JsonPropertyName("order_type")]
		[Description("订单类型  采购入库：PURCHASE_IN;  销退入库：SALE_RETURN_IN;  库存调整（盘盈）：INVENTORY_ADJUST")]
		[NotNull]
		public string OrderType { get; set; }

		[JsonPropertyName("stock_num")]
		[Description("结算库存数（T-1日期末库存）")]
		[NotNull]
		public long? StockNum { get; set; }

		[JsonPropertyName("warehouse_area_type")]
		[Description("库区类型：  1-普通区 2-恒温区")]
		[NotNull]
		public int? WarehouseAreaType { get; set; }

		[JsonPropertyName("storage_age")]
		[Description("库龄（单位是天），10天")]
		[NotNull]
		public long? StorageAge { get; set; }

		[JsonPropertyName("bar_code")]
		[Description("货品条码")]
		public string BarCode { get; set; }

		[JsonPropertyName("length")]
		[Description("长（单位 mm）")]
		[NotNull]
		public long? Length { get; set; }

		[JsonPropertyName("width")]
		[Description("宽（单位 mm）")]
		[NotNull]
		public long? Width { get; set; }

		[JsonPropertyName("height")]
		[Description("高（单位 mm）")]
		[NotNull]
		public long? Height { get; set; }
	}
}

[Description("服务商回传仓租计费明细")]
public class CrossBorderNotifyWarehouseFeeOrderRsp
{
}
