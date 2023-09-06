namespace ecommerce.sdk.douyin;

[Description("接口用于商家查询指定团长活动的活动详情")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","活动不存在","isv.business-failed:500","活动不存在")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","请检查参数")]
[DouyinRetCode(20000,"系统错误","服务器打瞌睡了，请稍候再试","isp.service-error:256","服务器打瞌睡了，请稍候再试")]
public class BuyinShopActivityDetailReq : IDouyinReq<BuyinShopActivityDetailRsp>
{

	public string GetMethod() { return "buyin.shopActivityDetail"; }

	public string GetUrl() { return "/buyin/shopActivityDetail"; }

	[JsonPropertyName("activity_id")]
	[Description("活动ID")]
	[NotNull]
	public long? ActivityId { get; set; }
}

[Description("接口用于商家查询指定团长活动的活动详情")]
public class BuyinShopActivityDetailRsp
{
	[JsonPropertyName("partner_id")]
	[Description("机构ID")]
	public long PartnerId { get; set; }

	[JsonPropertyName("activity_id")]
	[Description("活动ID")]
	public long ActivityId { get; set; }

	[JsonPropertyName("is_new_shop")]
	[Description("报名门槛-是否限制新手店铺")]
	public bool IsNewShop { get; set; }

	[JsonPropertyName("shop_type")]
	[Description("报名门槛（0：普通店，1：专营店，2：旗舰店，3：专卖店，4：商场店,5:专卖型旗舰店，6:官方旗舰店，7:企业店，8:个体店）")]
	public List<long> ShopType { get; set; }

	[JsonPropertyName("activity_name")]
	[Description("活动名称")]
	public string ActivityName { get; set; }

	[JsonPropertyName("activity_desc")]
	[Description("活动描述")]
	public string ActivityDesc { get; set; }

	[JsonPropertyName("apply_start_time")]
	[Description("活动报名开始时间")]
	public string ApplyStartTime { get; set; }

	[JsonPropertyName("apply_end_time")]
	[Description("活动报名结束时间")]
	public string ApplyEndTime { get; set; }

	[JsonPropertyName("commission_rate")]
	[Description("活动要求的最低佣金率")]
	public string CommissionRate { get; set; }

	[JsonPropertyName("service_rate")]
	[Description("活动要求的最低服务费率")]
	public string ServiceRate { get; set; }

	[JsonPropertyName("wechat_id")]
	[Description("微信号（返回微信号密文，需通过 https://op.jinritemai.com/docs/api-docs/61/2829 解密）")]
	public string WechatId { get; set; }

	[JsonPropertyName("phone_num")]
	[Description("手机号（返回联系电话密文，需通过 https://op.jinritemai.com/docs/api-docs/61/2829 解密）")]
	public string PhoneNum { get; set; }

	[JsonPropertyName("estimated_single_sale")]
	[Description("预估销售额")]
	public string EstimatedSingleSale { get; set; }

	[JsonPropertyName("activity_type")]
	[Description("活动类型（1 全部商家 2 指定商家）")]
	public long ActivityType { get; set; }

	[JsonPropertyName("specified_shop_ids")]
	[Description("指定商家ID")]
	public string SpecifiedShopIds { get; set; }

	[JsonPropertyName("categories")]
	[Description("招商类目")]
	public List<long> Categories { get; set; }

	[JsonPropertyName("shop_score")]
	[Description("报名门槛-店铺体验分选项，0：不限")]
	public int ShopScore { get; set; }

	[JsonPropertyName("min_promotion_days")]
	[Description("最短推广周期，0：不限；>0:具体天数；现在只有0、15、30、60、90")]
	public long MinPromotionDays { get; set; }

	[JsonPropertyName("threshold_cross_border")]
	[Description("跨境店铺 可/不可 报名（0:跨境店铺可报名，1:跨境店铺不可报名）")]
	public long ThresholdCrossBorder { get; set; }

	[JsonPropertyName("has_threshold")]
	[Description("是否有报名门槛")]
	public bool HasThreshold { get; set; }

	[JsonPropertyName("colonel_buyin_id")]
	[Description("团长百应ID")]
	public long ColonelBuyinId { get; set; }

	[JsonPropertyName("months_of_protection")]
	[Description("团长活动设置的限时独家期限 0-6个月，单位：月")]
	public long MonthsOfProtection { get; set; }

	[JsonPropertyName("colonel_name")]
	[Description("团长名称")]
	public string ColonelName { get; set; }
}
