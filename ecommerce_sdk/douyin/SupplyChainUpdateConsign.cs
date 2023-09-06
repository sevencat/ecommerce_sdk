namespace ecommerce.sdk.douyin;

[Description("为已发货的供货单更新发货物流")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:2000","请参考错误信息，或联系对接人员")]
public class SupplyChainUpdateConsignReq : IDouyinReq<SupplyChainUpdateConsignRsp>
{

	public string GetMethod() { return "supplyChain.updateConsign"; }

	public string GetUrl() { return "/supplyChain/updateConsign"; }

	[JsonPropertyName("order_no")]
	[Description("供货单号")]
	[NotNull]
	public string OrderNo { get; set; }

	[JsonPropertyName("tms_code")]
	[Description("发货的物流商编码")]
	[NotNull]
	public string TmsCode { get; set; }

	[JsonPropertyName("tracking_no")]
	[Description("发货的运单号")]
	[NotNull]
	public string TrackingNo { get; set; }

	[JsonPropertyName("old_tms_code")]
	[Description("【必填】上一次发货的物流商编码或者空字符串")]
	public string OldTmsCode { get; set; }

	[JsonPropertyName("old_tracking_no")]
	[Description("【必填】上一次发货的运单号或者空字符串")]
	public string OldTrackingNo { get; set; }

	[JsonPropertyName("new_ship_cnt")]
	[Description("【非必填】只有在需要修改件数的时候才填写。当前不支持即修改运单，又修改件数。在修改件数时，新老运单需要填写一样的内容")]
	public int? NewShipCnt { get; set; }
}

[Description("为已发货的供货单更新发货物流")]
public class SupplyChainUpdateConsignRsp
{
	[JsonPropertyName("success")]
	[Description("true=调用成功")]
	public bool Success { get; set; }
}
