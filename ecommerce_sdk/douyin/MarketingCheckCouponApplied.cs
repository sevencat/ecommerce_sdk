namespace ecommerce.sdk.douyin;

[Description("查询用户已领取优惠券核销数量")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:605012000","系统异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","优惠券不存在，请填写正确的券ID","isv.parameter-invalid:605012020","请填写正确的券ID")]
public class MarketingCheckCouponAppliedReq : IDouyinReq<MarketingCheckCouponAppliedRsp>
{

	public string GetMethod() { return "marketing.checkCouponApplied"; }

	public string GetUrl() { return "/marketing/checkCouponApplied"; }

	[JsonPropertyName("coupon_id")]
	[Description("优惠券ID")]
	[NotNull]
	public string CouponId { get; set; }

	[JsonPropertyName("doudian_open_id")]
	[Description("抖店用户open_id")]
	[NotNull]
	public long? DoudianOpenId { get; set; }
}

[Description("查询用户已领取优惠券核销数量")]
public class MarketingCheckCouponAppliedRsp
{
	[JsonPropertyName("used_count")]
	[Description("这个活动优惠id下，用户已使用（已核销）优惠券数量；该统计维度仅包含只包含已领取且已使用。如用户未领取或已领取未使用均不统计；")]
	public long UsedCount { get; set; }
}
