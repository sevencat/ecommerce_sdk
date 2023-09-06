namespace ecommerce.sdk.douyin;

[Description("抖客商品专属券查询，只能查询抖客专属券，不返回商品的通用券")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","当前商品没有对应的专属优惠券","isv.parameter-invalid:4452","当前商品没有对应的专属优惠券")]
[DouyinRetCode(10001,"请求部分失败","服务打瞌睡了，请稍后再试","isv.business-part-failed:256","服务打瞌睡了，请稍后再试")]
public class BuyinDoukeProductExclusiveCouponReq : IDouyinReq<BuyinDoukeProductExclusiveCouponRsp>
{

	public string GetMethod() { return "buyin.doukeProductExclusiveCoupon"; }

	public string GetUrl() { return "/buyin/doukeProductExclusiveCoupon"; }

	[JsonPropertyName("product_url")]
	[Description("商品链接")]
	[NotNull]
	public string ProductUrl { get; set; }
}

[Description("抖客商品专属券查询，只能查询抖客专属券，不返回商品的通用券")]
public class BuyinDoukeProductExclusiveCouponRsp
{
	[JsonPropertyName("is_coupon_product")]
	[Description("是否包含优惠券")]
	public bool IsCouponProduct { get; set; }

	[JsonPropertyName("coupons")]
	[Description("优惠券信息")]
	public List<CouponsItem> Coupons { get; set; }

	public class CouponsItem
	{
		[JsonPropertyName("coupon_type")]
		[Description("优惠券类型,0：无效券类型,1：抖客团长渠道券")]
		public int CouponType { get; set; }

		[JsonPropertyName("status")]
		[Description("优惠券状态,1 新建,2 生效,3 过期,4 失效,5  删除")]
		public int Status { get; set; }

		[JsonPropertyName("coupon_sub_type")]
		[Description("优惠类型,1 满减,2  直减,3  折扣")]
		public int CouponSubType { get; set; }

		[JsonPropertyName("discount")]
		[Description("折扣券折扣，8.5折则为85")]
		public long Discount { get; set; }

		[JsonPropertyName("threshold")]
		[Description("满减门槛，金额分")]
		public long Threshold { get; set; }

		[JsonPropertyName("credit")]
		[Description("满减/直减金额，金额分")]
		public long Credit { get; set; }

		[JsonPropertyName("start_apply_time")]
		[Description("券领取开始时间")]
		public long StartApplyTime { get; set; }

		[JsonPropertyName("end_apply_time")]
		[Description("券领取结束时间")]
		public long EndApplyTime { get; set; }

		[JsonPropertyName("coupon_validity_type")]
		[Description("券使用有效期类型：1固定有效期类型，2浮动有效期类型")]
		public int CouponValidityType { get; set; }

		[JsonPropertyName("coupon_valid_period")]
		[Description("浮动有效期，单位s")]
		public long CouponValidPeriod { get; set; }

		[JsonPropertyName("coupon_start_time")]
		[Description("券使用开始时间")]
		public long CouponStartTime { get; set; }

		[JsonPropertyName("coupon_end_time")]
		[Description("券使用结束时间")]
		public long CouponEndTime { get; set; }

		[JsonPropertyName("total_amount")]
		[Description("券总数量")]
		public long TotalAmount { get; set; }

		[JsonPropertyName("left_amount")]
		[Description("剩余数量")]
		public long LeftAmount { get; set; }
	}
}
