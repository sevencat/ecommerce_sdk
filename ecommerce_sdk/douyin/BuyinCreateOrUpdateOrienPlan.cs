namespace ecommerce.sdk.douyin;

[Description("1. 支持使用抖店卖家授权将抖店商品加入精选联盟定向计划。,2. 支持使用抖店卖家授权针对已加入精选联盟定向计划的商品进行佣金修改，下调自然日T+1生效，上调立即生效。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效定向计划ID","isv.parameter-invalid:4114","无效定向计划ID")]
[DouyinRetCode(40004,"非法的参数","无效佣金率","isv.parameter-invalid:4109","无效佣金率")]
[DouyinRetCode(40004,"非法的参数","无效结束时间","isv.parameter-invalid:4107","无效结束时间")]
[DouyinRetCode(40004,"非法的参数","无效商品ID","isv.parameter-invalid:4106","无效商品ID")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","存在同样佣金率和截止时间的计划","isv.business-failed:4111","存在同样佣金率和截止时间的计划")]
[DouyinRetCode(50002,"业务处理失败","创建定向计划失败","isv.business-failed:4110","创建定向计划失败")]
[DouyinRetCode(50002,"业务处理失败","商家已被关闭推广，无法使用平台功能","isv.business-failed:4102","商家已被关闭推广，无法使用平台功能")]
public class BuyinCreateOrUpdateOrienPlanReq : IDouyinReq<BuyinCreateOrUpdateOrienPlanRsp>
{

	public string GetMethod() { return "buyin.createOrUpdateOrienPlan"; }

	public string GetUrl() { return "/buyin/createOrUpdateOrienPlan"; }

	[JsonPropertyName("is_create")]
	[Description("是否创建")]
	[NotNull]
	public bool? IsCreate { get; set; }

	[JsonPropertyName("plan")]
	[Description("定向计划")]
	[NotNull]
	public PlanItem Plan { get; set; }

	public class PlanItem
	{
		[JsonPropertyName("orien_plan_id")]
		[Description("定向计划ID（is_create = false 时必填）")]
		public string OrienPlanId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID（创建时必填）")]
		public long? ProductId { get; set; }

		[JsonPropertyName("cos_ratio")]
		[Description("取值区间：[0,80] 的整数（创建时必填）")]
		public decimal? CosRatio { get; set; }

		[JsonPropertyName("apply_type")]
		[Description("是否可以申请。1： 不可以申请（默认值）；2：可以申请")]
		public int? ApplyType { get; set; }

		[JsonPropertyName("restricted_type")]
		[Description("是否开启限制。1： 无限制(默认值)；2： 有限制")]
		public int? RestrictedType { get; set; }

		[JsonPropertyName("author_level")]
		[Description("作者登机限制。0：无限制（默认值）；3：大于等于level 3；4：大于等于level 4；5：大于等于level 5；6：大于等于level 6。 restricted_type = 1 时不生效")]
		public int? AuthorLevel { get; set; }

		[JsonPropertyName("audit_type")]
		[Description("审核设置。1：申请自动通过（默认值）；2：申请需要审核。创建时：apply_type = 2时必填，apply_type = 1时该字段无效")]
		public int? AuditType { get; set; }

		[JsonPropertyName("end_time")]
		[Description("定向计划过期时间戳")]
		public long? EndTime { get; set; }
	}
}

[Description("1. 支持使用抖店卖家授权将抖店商品加入精选联盟定向计划。,2. 支持使用抖店卖家授权针对已加入精选联盟定向计划的商品进行佣金修改，下调自然日T+1生效，上调立即生效。")]
public class BuyinCreateOrUpdateOrienPlanRsp
{
	[JsonPropertyName("plan_id")]
	[Description("定向计划ID")]
	public string PlanId { get; set; }
}
