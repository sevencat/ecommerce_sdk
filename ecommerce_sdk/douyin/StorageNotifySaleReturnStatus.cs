namespace ecommerce.sdk.douyin;

[Description("回告销退单状态,用于仓储服务商回告销退单状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","InnerError","isp.service-error:1001","请重试")]
[DouyinRetCode(50002,"业务处理失败","5002:sale return order not found","isv.business-failed:5002","请重试")]
[DouyinRetCode(40002,"缺少必选参数","request cannot be nil","isv.missing-parameter:1004","请检查请求体后重试")]
[DouyinRetCode(40002,"缺少必选参数","logisticsNo is illegal","isv.missing-parameter:1004","请检查logisticsNo后重试")]
[DouyinRetCode(40002,"缺少必选参数","VendorNo is illegal","isv.missing-parameter:1004","请检查VendorNo后重试")]
[DouyinRetCode(40002,"缺少必选参数","Status is illegal","isv.missing-parameter:1004","请检查Status后重试")]
[DouyinRetCode(40004,"非法的参数","remark format is illegal","isv.parameter-invalid:1004","请检查remark格式后重试")]
public class StorageNotifySaleReturnStatusReq : IDouyinReq<StorageNotifySaleReturnStatusRsp>
{

	public string GetMethod() { return "storage.notifySaleReturnStatus"; }

	public string GetUrl() { return "/storage/notifySaleReturnStatus"; }

	[JsonPropertyName("logistics_no")]
	[Description("物流订单号")]
	[NotNull]
	public string LogisticsNo { get; set; }

	[JsonPropertyName("vendor")]
	[Description("服务商编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("status")]
	[Description("状态")]
	[NotNull]
	public int? Status { get; set; }

	[JsonPropertyName("occurrence_time")]
	[Description("业务发生时间")]
	[NotNull]
	public long? OccurrenceTime { get; set; }

	[JsonPropertyName("reason")]
	[Description("备注，格式严格校验")]
	public string Reason { get; set; }

	[JsonPropertyName("logistics_fulfil_no")]
	[Description("物流履约单号")]
	public string LogisticsFulfilNo { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓编码")]
	public string WarehouseCode { get; set; }
}

[Description("回告销退单状态,用于仓储服务商回告销退单状态")]
public class StorageNotifySaleReturnStatusRsp
{
}
