namespace ecommerce.sdk.douyin;

[Description("物流商取消平台寄件单据")]
public class LogisticsCancelOperateOrderReq : IDouyinReq<LogisticsCancelOperateOrderRsp>
{

	public string GetMethod() { return "logistics.cancelOperateOrder"; }

	public string GetUrl() { return "/logistics/cancelOperateOrder"; }

	[JsonPropertyName("waybill_code")]
	[Description("运单号")]
	[NotNull]
	public string WaybillCode { get; set; }

	[JsonPropertyName("reason")]
	[Description("取消原因")]
	[NotNull]
	public string Reason { get; set; }

	[JsonPropertyName("status")]
	[Description("取消")]
	[NotNull]
	public string Status { get; set; }
}

[Description("物流商取消平台寄件单据")]
public class LogisticsCancelOperateOrderRsp
{
	[JsonPropertyName("result")]
	[Description("请求结果（成功-true;失败-false）")]
	public bool Result { get; set; }

	[JsonPropertyName("return_code")]
	[Description("错误编码")]
	public string ReturnCode { get; set; }

	[JsonPropertyName("message")]
	[Description("失败原因")]
	public string Message { get; set; }
}
