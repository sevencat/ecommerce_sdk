namespace ecommerce.sdk.douyin;

[Description("取消电子面单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","取消总数/取号总数超过最大比例","isv.business-failed:88888","请检查取消总数/取号总数")]
public class IopWaybillCancelReq : IDouyinReq<IopWaybillCancelRsp>
{

	public string GetMethod() { return "iop.waybillCancel"; }

	public string GetUrl() { return "/iop/waybillCancel"; }

	[JsonPropertyName("user_id")]
	[Description("代打店铺id")]
	[NotNull]
	public long? UserId { get; set; }

	[JsonPropertyName("company_code")]
	[Description("物流服务商编码")]
	[NotNull]
	public string CompanyCode { get; set; }

	[JsonPropertyName("track_no")]
	[Description("运单号")]
	[NotNull]
	public string TrackNo { get; set; }
}

[Description("取消电子面单")]
public class IopWaybillCancelRsp
{
	[JsonPropertyName("return_result")]
	[Description("返回结果")]
	public bool ReturnResult { get; set; }
}
