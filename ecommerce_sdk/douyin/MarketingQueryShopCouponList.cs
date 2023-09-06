namespace ecommerce.sdk.douyin;

[Description("查询店铺优惠券信息，与商家工作台优惠券管理模块功能一致；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","店铺优惠券查询异常，缺少分页参数","isv.parameter-invalid:605012024","请填写正确的分页参数")]
[DouyinRetCode(40004,"非法的参数","店铺优惠券查询异常，分页参数不合法","isv.parameter-invalid:605012025","请填写正确的分页参数，PageNo <= 20")]
[DouyinRetCode(40004,"非法的参数","店铺优惠券查询异常，时间格式不正确","isv.parameter-invalid:605012026","max_start_apply_time不能早于min_start_apply_time")]
[DouyinRetCode(20000,"系统错误","店铺优惠券查询异常，请稍后重试","isp.service-error:605012000","店铺优惠券查询异常，请稍后重试")]
public class MarketingQueryShopCouponListReq : IDouyinReq<MarketingQueryShopCouponListRsp>
{

	public string GetMethod() { return "marketing.queryShopCouponList"; }

	public string GetUrl() { return "/marketing/queryShopCouponList"; }

	[JsonPropertyName("coupon_type")]
	[Description("优惠券类型。 0表示全部。,1：会员开卡礼；3：商品优惠券；4：店铺粉丝券；5：达人粉丝券；6：店铺新人券；7：全店通用券；8：客服专享卷；9：自有渠道券；12：团长活动券；13：达人专属券；15：订单商品复购券；16：直播投流券；20：无忧服务客服券；23：电商品牌广告券")]
	public long? CouponType { get; set; }

	[JsonPropertyName("content_type")]
	[Description("优惠内容。 0表示全部。,1：店铺满减券；2：店铺直减券；3：店铺折扣券；11：指定商品满减券；12：指定商品直减券；13：指定商品折扣券；")]
	public long? ContentType { get; set; }

	[JsonPropertyName("status")]
	[Description("优惠券状态。 0表示全部。,1: 未生效，2：生效中。3：已过期，4：已作废")]
	public long? Status { get; set; }

	[JsonPropertyName("min_start_apply_time")]
	[Description("领取时间范围，最小领取时间")]
	public long? MinStartApplyTime { get; set; }

	[JsonPropertyName("max_start_apply_time")]
	[Description("领取时间范围，最大领取时间")]
	public long? MaxStartApplyTime { get; set; }

	[JsonPropertyName("page_no")]
	[Description("分页参数，页数；从0开始")]
	[NotNull]
	public long? PageNo { get; set; }

	[JsonPropertyName("page_size")]
	[Description("分页参数，每页大小，最大20；")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("coupon_id")]
	[Description("优惠券ID，用于定向查询")]
	public string CouponId { get; set; }

	[JsonPropertyName("conpon_name")]
	[Description("优惠券名称，用于模糊查询")]
	public string ConponName { get; set; }
}

[Description("查询店铺优惠券信息，与商家工作台优惠券管理模块功能一致；")]
public class MarketingQueryShopCouponListRsp
{
	[JsonPropertyName("coupon_list")]
	[Description("优惠券列表")]
	public List<CouponListItem> CouponList { get; set; }

	public class CouponListItem
	{
		[JsonPropertyName("coupon_id")]
		[Description("优惠券ID")]
		public string CouponId { get; set; }

		[JsonPropertyName("coupon_name")]
		[Description("优惠券名称")]
		public string CouponName { get; set; }

		[JsonPropertyName("status")]
		[Description("优惠券状态。1: 未生效，2：生效中。3：已过期，4：已作废")]
		public long Status { get; set; }

		[JsonPropertyName("coupon_type")]
		[Description("优惠券类型。见入参枚举")]
		public long CouponType { get; set; }

		[JsonPropertyName("limit_kol_id")]
		[Description("达人kol_id")]
		public long LimitKolId { get; set; }

		[JsonPropertyName("sub_type")]
		[Description("优惠内容。1:满减券 2:直减券 3:折扣券")]
		public long SubType { get; set; }

		[JsonPropertyName("discount")]
		[Description("折扣券折扣，8.5折为85")]
		public long Discount { get; set; }

		[JsonPropertyName("threshold")]
		[Description("满减券门槛。单位分")]
		public long Threshold { get; set; }

		[JsonPropertyName("credit")]
		[Description("满减券，直减券金额。单位分")]
		public long Credit { get; set; }

		[JsonPropertyName("biz_type")]
		[Description("优惠券类型")]
		public long BizType { get; set; }

		[JsonPropertyName("start_apply_time")]
		[Description("券领取开始时间")]
		public long StartApplyTime { get; set; }

		[JsonPropertyName("end_apply_time")]
		[Description("券领取结束时间")]
		public long EndApplyTime { get; set; }

		[JsonPropertyName("coupon_validity_type")]
		[Description("有效类型：1固定有效期类型，2浮动有效期类型")]
		public long CouponValidityType { get; set; }

		[JsonPropertyName("coupon_valid_period")]
		[Description("有效期，单位s")]
		public long CouponValidPeriod { get; set; }

		[JsonPropertyName("coupon_start_time")]
		[Description("券使用开始时间")]
		public long CouponStartTime { get; set; }

		[JsonPropertyName("coupon_end_time")]
		[Description("券使用结束时间")]
		public long CouponEndTime { get; set; }

		[JsonPropertyName("coupon_max_apply_times")]
		[Description("每人限领")]
		public long CouponMaxApplyTimes { get; set; }

		[JsonPropertyName("total_amount")]
		[Description("发放量")]
		public long TotalAmount { get; set; }

		[JsonPropertyName("used_amount")]
		[Description("已核销量")]
		public long UsedAmount { get; set; }

		[JsonPropertyName("left_amount")]
		[Description("剩余未发放量")]
		public long LeftAmount { get; set; }

		[JsonPropertyName("range_type")]
		[Description("限类型。1：商品维度，3：店铺维度")]
		public long RangeType { get; set; }

		[JsonPropertyName("range_value")]
		[Description("商品券类型返回参加活动的商品集合，店铺通用权限返回店铺id")]
		public string RangeValue { get; set; }

		[JsonPropertyName("store_id")]
		[Description("门店券store_id")]
		public long StoreId { get; set; }

		[JsonPropertyName("max_credit_limit")]
		[Description("最大优惠金额，单位分")]
		public long MaxCreditLimit { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总量")]
	public long Total { get; set; }
}
