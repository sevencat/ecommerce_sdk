namespace ecommerce.sdk.douyin;

[Description("商家查看定向计划列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","商家已被关闭推广，无法使用平台功能","isv.business-failed:4102","商家已被关闭推广，无法使用平台功能")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍候再试","isp.service-error:256","服务打瞌睡了，请稍候再试")]
public class BuyinOrienPlanListReq : IDouyinReq<BuyinOrienPlanListRsp>
{

	public string GetMethod() { return "buyin.orienPlanList"; }

	public string GetUrl() { return "/buyin/orienPlanList"; }

	[JsonPropertyName("page")]
	[Description("分页。最小值取1，最大取100")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页数目。默认20，最大40")]
	public long? PageSize { get; set; }

	[JsonPropertyName("product_id")]
	[Description("按商品ID搜索")]
	public long? ProductId { get; set; }

	[JsonPropertyName("product_name")]
	[Description("按商品名称搜索")]
	public string ProductName { get; set; }

	[JsonPropertyName("orien_plan_id")]
	[Description("定向计划ID")]
	public string OrienPlanId { get; set; }
}

[Description("商家查看定向计划列表")]
public class BuyinOrienPlanListRsp
{
	[JsonPropertyName("total")]
	[Description("定向计划总数")]
	public long Total { get; set; }

	[JsonPropertyName("orien_plans")]
	[Description("商品定向计划列表")]
	public List<OrienPlansItem> OrienPlans { get; set; }

	public class OrienPlansItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("orien_plans")]
		[Description("定向计划列表")]
		public List<OrienPlansIItem> OrienPlansI { get; set; }

		public class OrienPlansIItem
		{
			[JsonPropertyName("orien_plan_id")]
			[Description("定向计划ID")]
			public string OrienPlanId { get; set; }

			[JsonPropertyName("product_id")]
			[Description("商品ID")]
			public long ProductId { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("cover")]
			[Description("封面")]
			public string Cover { get; set; }

			[JsonPropertyName("plan_status")]
			[Description("计划状态。1：定向计划投放中；2：定向计划已关闭；3：定向计划关闭中（仍在投放中）")]
			public int PlanStatus { get; set; }

			[JsonPropertyName("cos_ratio")]
			[Description("佣金率X100。值为[0,80]之间的整数")]
			public decimal CosRatio { get; set; }

			[JsonPropertyName("apply_type")]
			[Description("申请设置。1：不可以申请（默认值）；2：可以申请")]
			public int ApplyType { get; set; }

			[JsonPropertyName("restricted_type")]
			[Description("限制设置：1：无限制(默认值)；2；有限制")]
			public int RestrictedType { get; set; }

			[JsonPropertyName("author_level")]
			[Description("作者等级限制。restricted_type = 1 时不生效。0-无限制，3-大于等于level 3，4-大于等于level 4，5-大于等于level 5，6-大于等于level 6")]
			public int AuthorLevel { get; set; }

			[JsonPropertyName("audit_type")]
			[Description("审核设置。1：申请自动通过，2：申请需要审核")]
			public int AuditType { get; set; }

			[JsonPropertyName("start_time")]
			[Description("定向计划开始时间")]
			public long StartTime { get; set; }

			[JsonPropertyName("end_time")]
			[Description("定向计划过期时间")]
			public long EndTime { get; set; }

			[JsonPropertyName("create_time")]
			[Description("定向计划创建时间")]
			public long CreateTime { get; set; }

			[JsonPropertyName("kol_num")]
			[Description("达人数")]
			public long KolNum { get; set; }

			[JsonPropertyName("price")]
			[Description("商品价格（单位：分）")]
			public long Price { get; set; }

			[JsonPropertyName("new_cos_ratio")]
			[Description("将要生效的佣金率")]
			public decimal NewCosRatio { get; set; }

			[JsonPropertyName("new_cos_ratio_start_time")]
			[Description("将要生效佣金率的生效时间")]
			public long NewCosRatioStartTime { get; set; }
		}
	}
}
