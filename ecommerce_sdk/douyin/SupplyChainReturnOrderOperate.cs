namespace ecommerce.sdk.douyin;

[Description("供应商操作售后单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数解析异常","isv.parameter-invalid:1020","重新填写入参")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:1000","重试")]
[DouyinRetCode(20000,"系统错误","业务处理失败","isp.service-error:1040","根据提示处理")]
public class SupplyChainReturnOrderOperateReq : IDouyinReq<SupplyChainReturnOrderOperateRsp>
{

	public string GetMethod() { return "supplyChain.returnOrder.operate"; }

	public string GetUrl() { return "/supplyChain/returnOrder/operate"; }

	[JsonPropertyName("return_order_no")]
	[Description("售后单号")]
	[NotNull]
	public string ReturnOrderNo { get; set; }

	[JsonPropertyName("operate_type")]
	[Description("操作类型，目前支持,同意退款：CONFIRM_REFUNDD,确认收货：CONFIRM_RETURNED,拒绝售后：REJECT")]
	[NotNull]
	public string OperateType { get; set; }

	[JsonPropertyName("refuse_reason")]
	[Description("售后拒绝原因")]
	public string RefuseReason { get; set; }
}

[Description("供应商操作售后单")]
public class SupplyChainReturnOrderOperateRsp
{
	[JsonPropertyName("code")]
	[Description("请求响应码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("响应信息")]
	public string Msg { get; set; }

	[JsonPropertyName("success")]
	[Description("操作是否成功")]
	public bool Success { get; set; }
}
