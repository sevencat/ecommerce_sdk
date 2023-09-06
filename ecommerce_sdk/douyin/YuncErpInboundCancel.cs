namespace ecommerce.sdk.douyin;

[Description("取消toB入库单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","62303015:调用仓储失败","isv.business-failed:62303015","62303015:调用仓储失败")]
[DouyinRetCode(50002,"业务处理失败","500:500","isv.business-failed:500","500:500")]
[DouyinRetCode(50002,"业务处理失败","100102:取消送仓单失败，仓库可能已作业","isv.business-failed:100102","100102:取消送仓单失败，仓库可能已作业")]
[DouyinRetCode(50002,"业务处理失败","1001:调用wms取消入库单失败","isv.business-failed:1001","1001:调用wms取消入库单失败")]
[DouyinRetCode(50002,"业务处理失败","100100:ownerCode字段缺失","isv.business-failed:100100","货主编码ownerCode必填，请补充后重试！")]
[DouyinRetCode(20001,"内部服务超时","1103:内部服务超时，请重试","isp.service-timeout-error:1103","请重试")]
[DouyinRetCode(50002,"业务处理失败","9003:取消送仓单失败，仓库已作业","isv.business-failed:9003","取消送仓单失败，仓库已作业")]
[DouyinRetCode(50002,"业务处理失败","9023:500","isv.business-failed:9023","500")]
public class YuncErpInboundCancelReq : IDouyinReq<YuncErpInboundCancelRsp>
{

	public string GetMethod() { return "yunc.erpInboundCancel"; }

	public string GetUrl() { return "/yunc/erpInboundCancel"; }

	[JsonPropertyName("biz_order_no")]
	[Description("入库单号")]
	[NotNull]
	public string BizOrderNo { get; set; }

	[JsonPropertyName("action_type")]
	[Description("操作类型")]
	[NotNull]
	public short? ActionType { get; set; }

	[JsonPropertyName("cancel_reason")]
	[Description("取消原因")]
	[NotNull]
	public string CancelReason { get; set; }

	[JsonPropertyName("order_type")]
	[Description("订单类型")]
	[NotNull]
	public string OrderType { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }
}

[Description("取消toB入库单")]
public class YuncErpInboundCancelRsp
{
}
