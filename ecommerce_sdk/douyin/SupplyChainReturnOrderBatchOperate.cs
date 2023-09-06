namespace ecommerce.sdk.douyin;

[Description("批量操作售后单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","请求参数异常","isv.business-failed:1020","修改请求入参")]
[DouyinRetCode(20000,"系统错误","业务处理失败","isp.service-error:1040","根据提示处理")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:1000","重试")]
public class SupplyChainReturnOrderBatchOperateReq : IDouyinReq<SupplyChainReturnOrderBatchOperateRsp>
{

	public string GetMethod() { return "supplyChain.returnOrder.batchOperate"; }

	public string GetUrl() { return "/supplyChain/returnOrder/batchOperate"; }

	[JsonPropertyName("return_order_no_list")]
	[Description("售后单号")]
	[NotNull]
	public List<string> ReturnOrderNoList { get; set; }

	[JsonPropertyName("operate_type")]
	[Description("操作类型，目前支持,同意退款：CONFIRM_REFUNDD,确认收货：CONFIRM_RETURNED,拒绝售后：REJECT")]
	[NotNull]
	public string OperateType { get; set; }

	[JsonPropertyName("refuse_reason")]
	[Description("售后拒绝原因")]
	public string RefuseReason { get; set; }
}

[Description("批量操作售后单")]
public class SupplyChainReturnOrderBatchOperateRsp
{
	[JsonPropertyName("code")]
	[Description("响应码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("响应信息")]
	public string Msg { get; set; }

	[JsonPropertyName("success")]
	[Description("是否操作成功")]
	public bool Success { get; set; }

	[JsonPropertyName("success_order_no_list")]
	[Description("处理成功售后单号列表")]
	public List<string> SuccessOrderNoList { get; set; }

	[JsonPropertyName("failed_order_no_list")]
	[Description("处理失败售后单号列表")]
	public List<string> FailedOrderNoList { get; set; }
}
