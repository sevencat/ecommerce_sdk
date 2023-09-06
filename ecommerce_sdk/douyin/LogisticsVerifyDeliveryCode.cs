namespace ecommerce.sdk.douyin;

[Description("寄件场景，末端服务商调用字节接口验证寄件码")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","-","isp.service-error:10001","修改请求参数")]
[DouyinRetCode(20000,"系统错误","-","isp.service-error:10002","接口重试")]
[DouyinRetCode(20000,"系统错误","-","isp.service-error:10003","联系开发人员")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10101","订单不存在")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10102","订单已取消")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10201","当前状态不支持核销寄件码")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10202","寄件码错误")]
public class LogisticsVerifyDeliveryCodeReq : IDouyinReq<LogisticsVerifyDeliveryCodeRsp>
{

	public string GetMethod() { return "logistics.verifyDeliveryCode"; }

	public string GetUrl() { return "/logistics/verifyDeliveryCode"; }

	[JsonPropertyName("bizType")]
	[Description("业务类型；,枚举：COURIER_STATION--驿站寄件")]
	[NotNull]
	public string BizType { get; set; }

	[JsonPropertyName("orderId")]
	[Description("订单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("deliveryCode")]
	[Description("寄件码")]
	[NotNull]
	public string DeliveryCode { get; set; }

	[JsonPropertyName("operationTime")]
	[Description("操作时间（格式：yyyy-MM-dd HH:mm:ss，24小时制）")]
	[NotNull]
	public string OperationTime { get; set; }

	[JsonPropertyName("partnerCode")]
	[Description("服务商编码")]
	[NotNull]
	public string PartnerCode { get; set; }

	[JsonPropertyName("postCode")]
	[Description("驿站编码")]
	[NotNull]
	public string PostCode { get; set; }

	[JsonPropertyName("postName")]
	[Description("驿站名称")]
	[NotNull]
	public string PostName { get; set; }

	[JsonPropertyName("brandCode")]
	[Description("品牌编码")]
	[NotNull]
	public string BrandCode { get; set; }
}

[Description("寄件场景，末端服务商调用字节接口验证寄件码")]
public class LogisticsVerifyDeliveryCodeRsp
{
	[JsonPropertyName("errCode")]
	[Description("失败原因编码（处理成功默认回传“0”）")]
	public string ErrCode { get; set; }

	[JsonPropertyName("errReason")]
	[Description("失败原因描述")]
	public string ErrReason { get; set; }
}
