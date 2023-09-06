namespace ecommerce.sdk.douyin;

[Description("跨境类自营店铺首页领券")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","领取失败","isv.business-failed:1","领取失败")]
[DouyinRetCode(50002,"业务处理失败","领取失败，请稍后重试","isv.business-failed:2","领取失败，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","网络错误，请稍后重试","isv.business-failed:300","网络错误，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","网络错误，请稍后重试","isv.business-failed:-1000009","网络错误，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","网络错误，请稍后重试","isv.business-failed:3","网络错误，请稍后重试")]
public class SupplyChainApplyCouponReq : IDouyinReq<SupplyChainApplyCouponRsp>
{

	public string GetMethod() { return "supplyChain.applyCoupon"; }

	public string GetUrl() { return "/supplyChain/applyCoupon"; }

	[JsonPropertyName("coupon_meta_id")]
	[Description("优惠券id")]
	[NotNull]
	public string CouponMetaId { get; set; }

	[JsonPropertyName("token")]
	[Description("token")]
	[NotNull]
	public string Token { get; set; }
}

[Description("跨境类自营店铺首页领券")]
public class SupplyChainApplyCouponRsp
{
}
