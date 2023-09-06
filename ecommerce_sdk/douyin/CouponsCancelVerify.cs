namespace ecommerce.sdk.douyin;

[Description("当卡券核销错误之后，取消核销时候使用")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:000002","参数错误")]
[DouyinRetCode(20000,"系统错误","数据库访问异常","isp.service-error:030001","数据库访问异常")]
[DouyinRetCode(50002,"业务处理失败","QueryCertInfo cert verifyCount check error","isv.business-failed:010009","010009:QueryCertInfo cert verifyCount check error")]
[DouyinRetCode(50002,"业务处理失败","卡号错误","isv.business-failed:010021","卡号错误,请检查")]
[DouyinRetCode(50002,"业务处理失败","QueryCertInfo cert status check error","isv.business-failed:10002","010002:QueryCertInfo cert status check error")]
[DouyinRetCode(50002,"业务处理失败","010016:卡券已冻结","isv.business-failed:010016","010016:卡券已冻结")]
public class CouponsCancelVerifyReq : IDouyinReq<CouponsCancelVerifyRsp>
{

	public string GetMethod() { return "coupons.cancelVerify"; }

	public string GetUrl() { return "/coupons/cancelVerify"; }

	[JsonPropertyName("cert_no")]
	[Description("卡号券码")]
	[NotNull]
	public string CertNo { get; set; }

	[JsonPropertyName("batch_no")]
	[Description("幂等请求编号")]
	public string BatchNo { get; set; }

	[JsonPropertyName("cancel_verify_count")]
	[Description("取消核销总次数")]
	public long? CancelVerifyCount { get; set; }
}

[Description("当卡券核销错误之后，取消核销时候使用")]
public class CouponsCancelVerifyRsp
{
}
