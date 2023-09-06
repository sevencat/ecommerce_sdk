namespace ecommerce.sdk.douyin;

[Description("使用场景：,1、不传aftersale_id查询抖店支持的全量拒绝原因列表,2、传aftersale_id，商家查询该笔售后单可选的拒绝原因列表，注意：仅支持已发货的售后查询，备货中未发货订单返回为空。,3、如返回为空,有如下场景：,1)该售后单已完结或已审核，处于非可拒绝状态。,2)系统查询超时，建议重试。,3)仅支持已发货的售后查询，备货中未发货订单返回为空。,注意：备货中未发货订单如需拒绝请使用物流发货接口拒绝即可。,常见问题：https://op.jinritemai.com/docs/question-docs/93/2823")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","10000:系统错误，请重试","isv.business-failed:10000","重试")]
public class AfterSaleRejectReasonCodeListReq : IDouyinReq<AfterSaleRejectReasonCodeListRsp>
{

	public string GetMethod() { return "afterSale.rejectReasonCodeList"; }

	public string GetUrl() { return "/afterSale/rejectReasonCodeList"; }

	[JsonPropertyName("aftersale_id")]
	[Description("传入售后单id时，返回该笔售后单可选择的拒绝原因列表；仅支持已发货的售后查询，备货中未发货订单返回为空。")]
	public long? AftersaleId { get; set; }
}

[Description("使用场景：,1、不传aftersale_id查询抖店支持的全量拒绝原因列表,2、传aftersale_id，商家查询该笔售后单可选的拒绝原因列表，注意：仅支持已发货的售后查询，备货中未发货订单返回为空。,3、如返回为空,有如下场景：,1)该售后单已完结或已审核，处于非可拒绝状态。,2)系统查询超时，建议重试。,3)仅支持已发货的售后查询，备货中未发货订单返回为空。,注意：备货中未发货订单如需拒绝请使用物流发货接口拒绝即可。,常见问题：https://op.jinritemai.com/docs/question-docs/93/2823")]
public class AfterSaleRejectReasonCodeListRsp
{
	[JsonPropertyName("items")]
	[Description("售后商家拒绝原因详情列表")]
	public List<ItemsItem> Items { get; set; }

	public class ItemsItem
	{
		[JsonPropertyName("reject_reason_code")]
		[Description("售后审核拒绝原因枚举编码")]
		public long RejectReasonCode { get; set; }

		[JsonPropertyName("reason")]
		[Description("售后审核拒绝原因文案")]
		public string Reason { get; set; }

		[JsonPropertyName("evidence_description")]
		[Description("凭证描述文案")]
		public string EvidenceDescription { get; set; }

		[JsonPropertyName("evidence_need")]
		[Description("是否需要上传凭证，Y必填，N非必填")]
		public string EvidenceNeed { get; set; }

		[JsonPropertyName("image")]
		[Description("凭证示例图片链接")]
		public string Image { get; set; }

		[JsonPropertyName("order_type")]
		[Description("订单类型，即订单信息中order_type   枚举：0-普通实物订单 1-全款预售订单  2-虚拟商品订单 3-快闪店订单 4-电子券  5-三方核销 6-服务市场 -1-通用,不考虑订单类型")]
		public long OrderType { get; set; }

		[JsonPropertyName("pkg")]
		[Description("是否收到货，0未收到 1收到 -1通用,不考虑是否收到货")]
		public long Pkg { get; set; }
	}
}
