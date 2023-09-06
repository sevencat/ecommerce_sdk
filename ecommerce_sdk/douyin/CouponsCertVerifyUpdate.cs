namespace ecommerce.sdk.douyin;

[Description("1、卡券核销次数更新,2、卡券API使用前提：,  自研开发者对接卡券API，需联系店铺的行业运营获取卡券资质，否则无法使用卡券API接口。如何联系店铺的行业运营?https://op.jinritemai.com/docs/question-docs/45/1777")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","参数错误","isv.missing-parameter:000002","参数错误")]
[DouyinRetCode(50002,"业务处理失败","010017:卡券已过期","isv.business-failed:010017","010017:卡券已过期")]
[DouyinRetCode(50002,"业务处理失败","010009:卡券核销次数超过可核销次数","isv.business-failed:010009","010009:卡券核销次数超过可核销次数")]
[DouyinRetCode(50002,"业务处理失败","010002:cert status check error","isv.business-failed:010002","010002:cert status check error")]
[DouyinRetCode(50002,"业务处理失败","010021:卡号错误","isv.business-failed:10021","请检查卡号是否存在")]
public class CouponsCertVerifyUpdateReq : IDouyinReq<CouponsCertVerifyUpdateRsp>
{

	public string GetMethod() { return "coupons.certVerifyUpdate"; }

	public string GetUrl() { return "/coupons/certVerifyUpdate"; }

	[JsonPropertyName("cert_no")]
	[Description("卡号券码")]
	[NotNull]
	public string CertNo { get; set; }

	[JsonPropertyName("update_time")]
	[Description("更新时间")]
	[NotNull]
	public string UpdateTime { get; set; }

	[JsonPropertyName("update_verify_count")]
	[Description("更新核销次数")]
	[NotNull]
	public long? UpdateVerifyCount { get; set; }

	[JsonPropertyName("batch_no")]
	[Description("幂等请求编号")]
	[NotNull]
	public string BatchNo { get; set; }

	[JsonPropertyName("extra")]
	[Description("额外信息")]
	public string Extra { get; set; }
}

[Description("1、卡券核销次数更新,2、卡券API使用前提：,  自研开发者对接卡券API，需联系店铺的行业运营获取卡券资质，否则无法使用卡券API接口。如何联系店铺的行业运营?https://op.jinritemai.com/docs/question-docs/45/1777")]
public class CouponsCertVerifyUpdateRsp
{
}
