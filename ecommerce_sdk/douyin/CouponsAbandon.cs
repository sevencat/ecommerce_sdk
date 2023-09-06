namespace ecommerce.sdk.douyin;

[Description("卡券进行售后退款时，需要先进行卡券废弃")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:000002","参数错误")]
[DouyinRetCode(20000,"系统错误","请求重入","isp.service-error:000008","请求重入")]
[DouyinRetCode(20000,"系统错误","数据库访问异常","isp.service-error:030001","数据库访问异常")]
[DouyinRetCode(50002,"业务处理失败","券码状态已变化","isv.business-failed:010002","券码状态已变化")]
[DouyinRetCode(50002,"业务处理失败","010021:卡号错误","isv.business-failed:010021","010021:卡号错误")]
public class CouponsAbandonReq : IDouyinReq<CouponsAbandonRsp>
{

	public string GetMethod() { return "coupons.abandon"; }

	public string GetUrl() { return "/coupons/abandon"; }

	[JsonPropertyName("cert_no")]
	[Description("卡号券码")]
	[NotNull]
	public string CertNo { get; set; }
}

[Description("卡券进行售后退款时，需要先进行卡券废弃")]
public class CouponsAbandonRsp
{
}
