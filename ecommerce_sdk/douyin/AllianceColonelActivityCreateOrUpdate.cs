namespace ecommerce.sdk.douyin;

[Description("该接口用于团长活动的创建和编辑")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","机构结算账户不存在或部分开通，需要全部开通","isv.business-failed:4136","机构结算账户不存在或部分开通，需要全部开通")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","暂时不支持创建公开招商","isv.business-failed:100","暂时不支持创建公开招商")]
[DouyinRetCode(40004,"非法的参数","推广结束时间必须大于报名结束时间","isv.parameter-invalid:4131","推广结束时间必须大于报名结束时间")]
[DouyinRetCode(50002,"业务处理失败","活动的推广开始时间不能早于今天","isv.business-failed:10000","活动的推广开始时间不能早于今天")]
[DouyinRetCode(50002,"业务处理失败","只能修改自己创建的团长活动","isv.business-failed:110110","只能修改自己创建的团长活动，请检查")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
[DouyinRetCode(50002,"业务处理失败","报名截止时间应不早于今天","isv.business-failed:500","报名截止时间应不早于今天")]
[DouyinRetCode(40004,"非法的参数","活动信息填写不规范，请重新填写","isv.parameter-invalid:71100","活动信息填写不规范，请重新填写")]
public class AllianceColonelActivityCreateOrUpdateReq : IDouyinReq<AllianceColonelActivityCreateOrUpdateRsp>
{

	public string GetMethod() { return "alliance.colonelActivityCreateOrUpdate"; }

	public string GetUrl() { return "/alliance/colonelActivityCreateOrUpdate"; }

	[JsonPropertyName("activity_id")]
	[Description("活动ID")]
	public long? ActivityId { get; set; }

	[JsonPropertyName("application_limited")]
	[Description("是否有报名门槛，默认无门槛")]
	[NotNull]
	public bool? ApplicationLimited { get; set; }

	[JsonPropertyName("is_new_shop")]
	[Description("报名门槛-新手店铺，当 application_limited = true 时必填：false 可报名（默认），true 不可报名")]
	public bool? IsNewShop { get; set; }

	[JsonPropertyName("shop_type")]
	[Description("报名门槛-店铺类型支持复选,当 application_limited = 1 时必填：0:普通店，1:专营店，2:旗舰店，3:专卖店，4:商场店，6:卖场型旗舰店，7：官方旗舰单，8：企业店，9:个体")]
	public string ShopType { get; set; }

	[JsonPropertyName("activity_name")]
	[Description("活动名称,不超过30个汉字")]
	[NotNull]
	public string ActivityName { get; set; }

	[JsonPropertyName("activity_desc")]
	[Description("活动描述,不超过200个汉字")]
	[NotNull]
	public string ActivityDesc { get; set; }

	[JsonPropertyName("apply_start_time")]
	[Description("商品报名开始时间")]
	[NotNull]
	public string ApplyStartTime { get; set; }

	[JsonPropertyName("apply_end_time")]
	[Description("商品报名结束时间")]
	[NotNull]
	public string ApplyEndTime { get; set; }

	[JsonPropertyName("promote_start_time")]
	[Description("推广开始时间")]
	public string PromoteStartTime { get; set; }

	[JsonPropertyName("promote_end_time")]
	[Description("推广结束时间")]
	public string PromoteEndTime { get; set; }

	[JsonPropertyName("commission_rate")]
	[Description("最低商品佣金率X100，小于等于50。服务费率+佣金率不能高于90%")]
	[NotNull]
	public string CommissionRate { get; set; }

	[JsonPropertyName("service_rate")]
	[Description("团长服务费率X100，不超过40（服务费率不能超过40%）")]
	[NotNull]
	public string ServiceRate { get; set; }

	[JsonPropertyName("wechat_id")]
	[Description("微信号")]
	public string WechatId { get; set; }

	[JsonPropertyName("phone_num")]
	[Description("手机号")]
	public string PhoneNum { get; set; }

	[JsonPropertyName("estimated_single_sale")]
	[Description("预估单品销售额，单位元")]
	[NotNull]
	public string EstimatedSingleSale { get; set; }

	[JsonPropertyName("activity_type")]
	[Description("活动类型（1 全部商家 2 指定商家）")]
	[NotNull]
	public long? ActivityType { get; set; }

	[JsonPropertyName("specified_shop_ids")]
	[Description("指定商家ID （入参为店铺的shop_id，当 application_scope =1 时必填）")]
	public string SpecifiedShopIds { get; set; }

	[JsonPropertyName("online")]
	[Description("是否上线活动，默认不上线")]
	[NotNull]
	public bool? Online { get; set; }

	[JsonPropertyName("categories")]
	[Description("招商类目:支持复选：门捷列夫行业类目，传数字，多个用英文逗号隔开。类目获取接口：/alliance/activityProductCategoryList")]
	public string Categories { get; set; }

	[JsonPropertyName("shop_score")]
	[Description("报名门槛-店铺体验分（填整数，0表示不限）")]
	public int? ShopScore { get; set; }

	[JsonPropertyName("activity_kind")]
	[Description("活动类型 0:专属招商 1:公开招商")]
	public long? ActivityKind { get; set; }

	[JsonPropertyName("min_promotion_days")]
	[Description("最短推广周期，不传默认90天（目前只能支持以下天数：30，90，180，360）")]
	public long? MinPromotionDays { get; set; }

	[JsonPropertyName("threshold_cross_border")]
	[Description("跨境店铺是否可以报名，不传表示可报名")]
	public long? ThresholdCrossBorder { get; set; }

	[JsonPropertyName("min_exclusion_duration")]
	[Description("团长活动侧设置的限时独家期限 0-6个月，不传默认为 0")]
	public long? MinExclusionDuration { get; set; }
}

[Description("该接口用于团长活动的创建和编辑")]
public class AllianceColonelActivityCreateOrUpdateRsp
{
	[JsonPropertyName("institution_id")]
	[Description("机构ID")]
	public long InstitutionId { get; set; }

	[JsonPropertyName("activity_id")]
	[Description("活动ID")]
	public long ActivityId { get; set; }
}
