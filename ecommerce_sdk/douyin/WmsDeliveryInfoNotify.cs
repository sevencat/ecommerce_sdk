namespace ecommerce.sdk.douyin;

[Description("仓储系统回传发货信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","通用业务错误码","isv.business-failed:-1","参考返回值中的message字段")]
public class WmsDeliveryInfoNotifyReq : IDouyinReq<WmsDeliveryInfoNotifyRsp>
{

	public string GetMethod() { return "wms.deliveryInfoNotify"; }

	public string GetUrl() { return "/wms/deliveryInfoNotify"; }

	[JsonPropertyName("tracking_no")]
	[Description("运单号")]
	[NotNull]
	public string TrackingNo { get; set; }

	[JsonPropertyName("operator_type")]
	[Description("操作类型")]
	[NotNull]
	public string OperatorType { get; set; }

	[JsonPropertyName("operator_des")]
	[Description("描述")]
	[NotNull]
	public string OperatorDes { get; set; }

	[JsonPropertyName("operator_time")]
	[Description("时间")]
	[NotNull]
	public string OperatorTime { get; set; }

	[JsonPropertyName("operator_user")]
	[Description("操作人")]
	public string OperatorUser { get; set; }

	[JsonPropertyName("operator_remark")]
	[Description("备注")]
	public string OperatorRemark { get; set; }

	[JsonPropertyName("timestamp")]
	[Description("时间戳")]
	public string Timestamp { get; set; }
}

[Description("仓储系统回传发货信息")]
public class WmsDeliveryInfoNotifyRsp
{
}
