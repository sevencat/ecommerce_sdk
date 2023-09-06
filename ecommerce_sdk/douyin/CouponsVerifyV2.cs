namespace ecommerce.sdk.douyin;

[Description("卡券核销接口V2版本")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","参数错误","isv.missing-parameter:000002","参数错误")]
[DouyinRetCode(50002,"业务处理失败","010002:非未使用状态电子凭证禁止核销","isv.business-failed:010002","010002:非未使用状态电子凭证禁止核销")]
[DouyinRetCode(50002,"业务处理失败","030001:UpdateCertInfo error","isv.business-failed:030001","030001:UpdateCertInfo error")]
[DouyinRetCode(50002,"业务处理失败","010021:卡号错误","isv.business-failed:010021","010021:卡号错误")]
[DouyinRetCode(50002,"业务处理失败","010009:核销数量超出最大可核销数量","isv.business-failed:010009","010009:核销数量超出最大可核销数量")]
[DouyinRetCode(50002,"业务处理失败","010017:未在有效期内禁止核销","isv.business-failed:010017","010017:未在有效期内禁止核销")]
[DouyinRetCode(50002,"业务处理失败","010006:找不到该电子凭证","isv.business-failed:10006","找不到该电子凭证")]
[DouyinRetCode(50002,"业务处理失败","010014:卡密校验失败","isv.business-failed:010014","010014:卡密校验失败")]
[DouyinRetCode(50002,"业务处理失败","010016:卡券已冻结","isv.business-failed:010016","010016:卡券已冻结")]
public class CouponsVerifyV2Req : IDouyinReq<CouponsVerifyV2Rsp>
{

	public string GetMethod() { return "coupons.verifyV2"; }

	public string GetUrl() { return "/coupons/verifyV2"; }

	[JsonPropertyName("cert_no")]
	[Description("卡券号码")]
	[NotNull]
	public string CertNo { get; set; }

	[JsonPropertyName("verify_time")]
	[Description("核销时间")]
	public string VerifyTime { get; set; }

	[JsonPropertyName("batch_no")]
	[Description("幂等请求id")]
	public string BatchNo { get; set; }

	[JsonPropertyName("verify_count")]
	[Description("当次核销的次数")]
	public long? VerifyCount { get; set; }

	[JsonPropertyName("cert_key")]
	[Description("卡券密码")]
	public string CertKey { get; set; }
}

[Description("卡券核销接口V2版本")]
public class CouponsVerifyV2Rsp
{
}
