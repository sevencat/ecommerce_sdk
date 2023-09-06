namespace ecommerce.sdk.douyin;

[Description("小时达-创建门店优惠卷")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","数据转换错误","isv.business-failed:50202","数据转换错误")]
[DouyinRetCode(50002,"业务处理失败","小时达门店优惠券服务错误","isv.business-failed:20240","小时达门店优惠券服务错误")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40100","参数错误")]
public class SupermPopCreateStoreCouponReq : IDouyinReq<SupermPopCreateStoreCouponRsp>
{

	public string GetMethod() { return "superm.pop.createStoreCoupon"; }

	public string GetUrl() { return "/superm/pop/createStoreCoupon"; }

	[JsonPropertyName("coupon_info")]
	[Description("优惠券信息")]
	[NotNull]
	public CouponInfoItem CouponInfo { get; set; }

	public class CouponInfoItem
	{
		[JsonPropertyName("coupon_name")]
		[Description("优惠券名称")]
		[NotNull]
		public string CouponName { get; set; }

		[JsonPropertyName("valid_period")]
		[Description("浮动有效期（单位：天）,如果period_type = 2需要传递")]
		public long? ValidPeriod { get; set; }

		[JsonPropertyName("start_apply_time")]
		[Description("开始领取时间，秒时间戳")]
		[NotNull]
		public long? StartApplyTime { get; set; }

		[JsonPropertyName("end_apply_time")]
		[Description("结束领取时间，秒时间戳")]
		[NotNull]
		public long? EndApplyTime { get; set; }

		[JsonPropertyName("start_time")]
		[Description("使用时间开始，秒时间戳")]
		public long? StartTime { get; set; }

		[JsonPropertyName("end_time")]
		[Description("使用时间结束，秒时间戳")]
		public long? EndTime { get; set; }

		[JsonPropertyName("period_type")]
		[Description("类型：1固定有效期类型，2浮动有效期类型")]
		public int? PeriodType { get; set; }

		[JsonPropertyName("total_amount")]
		[Description("总数量")]
		[NotNull]
		public long? TotalAmount { get; set; }

		[JsonPropertyName("discount")]
		[Description("折扣券折扣，8.5折传85")]
		public long? Discount { get; set; }

		[JsonPropertyName("threshold")]
		[Description("满减券门槛,满减类型时需要填写")]
		public long? Threshold { get; set; }

		[JsonPropertyName("credit")]
		[Description("满减券，直减券金额,满减、直减类型时需要填写")]
		public long? Credit { get; set; }

		[JsonPropertyName("max_apply_times")]
		[Description("最大领取次数限制")]
		[NotNull]
		public long? MaxApplyTimes { get; set; }

		[JsonPropertyName("sub_type")]
		[Description("券子类型，1:满减 2:直减 3:折扣")]
		[NotNull]
		public int? SubType { get; set; }

		[JsonPropertyName("support_type")]
		[Description("优惠券类型（当前仅支持17,18）,0全部,1商品优惠券,2店铺粉丝券,3达人粉丝圈,4店铺新人券,5全店通用券,6客服专用券,7自有渠道券,8广告单品券,9会员开卡礼,10团长活动券,11达人专属券,12混合出资券,13分享裂变券,15订单商品复购券,16千川广告券,17超市门店券,18门店商品券,19惊喜券,20无忧联盟客服券")]
		[NotNull]
		public int? SupportType { get; set; }
	}

	[JsonPropertyName("store_product_list")]
	[Description("门店商品列表")]
	public List<StoreProductListItem> StoreProductList { get; set; }

	public class StoreProductListItem
	{
		[JsonPropertyName("store_info")]
		[Description("门店信息")]
		[NotNull]
		public StoreInfoItem StoreInfo { get; set; }

		public class StoreInfoItem
		{
			[JsonPropertyName("store_id")]
			[Description("门店id")]
			[NotNull]
			public string StoreId { get; set; }

			[JsonPropertyName("store_name")]
			[Description("门店名称")]
			public string StoreName { get; set; }

			[JsonPropertyName("store_address")]
			[Description("门店地址")]
			public string StoreAddress { get; set; }

			[JsonPropertyName("store_pic_url")]
			[Description("门店图片链接")]
			public string StorePicUrl { get; set; }
		}

		[JsonPropertyName("sub_product_infos")]
		[Description("子品id列表")]
		public List<SubProductInfosItem> SubProductInfos { get; set; }

		public class SubProductInfosItem
		{
			[JsonPropertyName("product_id")]
			[Description("商品id")]
			[NotNull]
			public string ProductId { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("product_pic_url")]
			[Description("商品图片链接")]
			public string ProductPicUrl { get; set; }
		}
	}
}

[Description("小时达-创建门店优惠卷")]
public class SupermPopCreateStoreCouponRsp
{
	[JsonPropertyName("code")]
	[Description("相应code")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("相应信息")]
	public string Msg { get; set; }

	[JsonPropertyName("data")]
	[Description("活动id")]
	public string Data { get; set; }
}
