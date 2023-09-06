namespace ecommerce.sdk.douyin;

[Description("服务商接收锁单请求后，根据实际锁单情况回告平台")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","接口调用异常，请重试，多次失败请人工反馈","isp.service-error:1005","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","回告节点时序有误，请先回告出库完成节点","isv.business-failed:10002","请先回告出库完成节点")]
[DouyinRetCode(20000,"系统错误","接口调用异常，请重试，多次失败请人工反馈","isp.service-error:99999","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","交易单已关闭，请核实交易单状态","isv.business-failed:10003","请核实交易单状态")]
public class CrossborderOrderInterceptionReq : IDouyinReq<CrossborderOrderInterceptionRsp>
{

	public string GetMethod() { return "crossborder.OrderInterception"; }

	public string GetUrl() { return "/crossborder/OrderInterception"; }

	[JsonPropertyName("vendor")]
	[Description("服务商编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("order_id")]
	[Description("交易单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("occurrence_time")]
	[Description("节点发生时间 yyyy-MM-dd HH:mm:ss")]
	[NotNull]
	public string OccurrenceTime { get; set; }

	[JsonPropertyName("status")]
	[Description("节点状态 4：锁单成功 5：锁单失败")]
	[NotNull]
	public long? Status { get; set; }
}

[Description("服务商接收锁单请求后，根据实际锁单情况回告平台")]
public class CrossborderOrderInterceptionRsp
{
	[JsonPropertyName("code")]
	[Description("响应状态码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("响应信息")]
	public string Msg { get; set; }
}
