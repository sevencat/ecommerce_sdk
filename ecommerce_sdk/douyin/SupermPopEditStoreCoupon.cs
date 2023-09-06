namespace ecommerce.sdk.douyin;

[Description("小时达-编辑门店优惠券")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","数据转换错误","isv.business-failed:20240","数据转换错误")]
[DouyinRetCode(50002,"业务处理失败","小时达门店优惠券服务错误","isv.business-failed:50202","小时达门店优惠券服务错误")]
[DouyinRetCode(50002,"业务处理失败","券库存不能减少","isv.business-failed:1000","券库存不能减少")]
public class SupermPopEditStoreCouponReq : IDouyinReq<SupermPopEditStoreCouponRsp>
{

	public string GetMethod() { return "superm.pop.EditStoreCoupon"; }

	public string GetUrl() { return "/superm/pop/EditStoreCoupon"; }

	[JsonPropertyName("activity_id")]
	[Description("活动id")]
	[NotNull]
	public string ActivityId { get; set; }

	[JsonPropertyName("coupon_info")]
	[Description("优惠卷信息")]
	public CouponInfoItem CouponInfo { get; set; }

	public class CouponInfoItem
	{
		[JsonPropertyName("total_amount")]
		[Description("总数量")]
		[NotNull]
		public long? TotalAmount { get; set; }
	}
}

[Description("小时达-编辑门店优惠券")]
public class SupermPopEditStoreCouponRsp
{
	[JsonPropertyName("code")]
	[Description("响应code")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("响应msg")]
	public string Msg { get; set; }
}
