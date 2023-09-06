namespace ecommerce.sdk.douyin;

[Description("商家接单,海南业务-商家接单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:1005","请重试")]
[DouyinRetCode(50002,"业务处理失败","推送的物流状态不对，请查证后重试, 当前状态是 服务商接单成功","isv.business-failed:1004","物流状态不对，请查证后重试")]
public class DutyFreeOrderConfirmReq : IDouyinReq<DutyFreeOrderConfirmRsp>
{

	public string GetMethod() { return "dutyFree.orderConfirm"; }

	public string GetUrl() { return "/dutyFree/orderConfirm"; }

	[JsonPropertyName("order_id")]
	[Description("订单ID")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("status")]
	[Description("接单状态：0 接单成功， 1 接单失败")]
	[NotNull]
	public int? Status { get; set; }

	[JsonPropertyName("occurrence_time")]
	[Description("物流状态的真实发生时间，yyyy-MM-dd hh:mi:ss（北京时间）")]
	[NotNull]
	public string OccurrenceTime { get; set; }

	[JsonPropertyName("error_info")]
	[Description("接单失败，status传入1时必填")]
	public ErrorInfoItem ErrorInfo { get; set; }

	public class ErrorInfoItem
	{
		[JsonPropertyName("error_code")]
		[Description("返回失败编码，商家只回传不可逆转的失败。")]
		[NotNull]
		public string ErrorCode { get; set; }

		[JsonPropertyName("error_msg")]
		[Description("返回详细失败原因")]
		[NotNull]
		public string ErrorMsg { get; set; }
	}
}

[Description("商家接单,海南业务-商家接单")]
public class DutyFreeOrderConfirmRsp
{
}
