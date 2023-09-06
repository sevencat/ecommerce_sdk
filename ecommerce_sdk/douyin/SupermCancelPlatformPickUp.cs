namespace ecommerce.sdk.douyin;

[Description("运力取消（逆向）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","状态不允许取消","isv.business-failed:50311","状态不允许取消")]
[DouyinRetCode(20000,"系统错误","请求内部服务异常,请重试","isp.service-error:20200","请求内部服务异常,请重试")]
[DouyinRetCode(50002,"业务处理失败","op not found","isv.business-failed:20201","op not found")]
[DouyinRetCode(50002,"业务处理失败","参数错误，不可重试","isv.business-failed:40100","参数错误，不可重试")]
[DouyinRetCode(50002,"业务处理失败","业务错误，此状态下不可重试","isv.business-failed:50300","业务错误，此状态下不可重试")]
public class SupermCancelPlatformPickUpReq : IDouyinReq<SupermCancelPlatformPickUpRsp>
{

	public string GetMethod() { return "superm.cancelPlatformPickUp"; }

	public string GetUrl() { return "/superm/cancelPlatformPickUp"; }

	[JsonPropertyName("aftersale_id")]
	[Description("售后单ID")]
	[NotNull]
	public long? AftersaleId { get; set; }

	[JsonPropertyName("cancel_reason")]
	[Description("取消运力的原因，开发者自定义传入，最大支持50个字符；填写后商家可以在抖店后台查看到。")]
	public string CancelReason { get; set; }
}

[Description("运力取消（逆向）")]
public class SupermCancelPlatformPickUpRsp
{
}
