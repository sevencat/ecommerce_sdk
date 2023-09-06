namespace ecommerce.sdk.douyin;

[Description("门店时段容量更新")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","获取组织关系失败","isv.business-failed:20232","获取组织关系失败")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40100","参数错误")]
[DouyinRetCode(50002,"业务处理失败","门店查询服务失败","isv.business-failed:20233","门店查询服务失败")]
[DouyinRetCode(50002,"业务处理失败","数据转换错误","isv.business-failed:50202","数据转换错误")]
public class SupermCapacityRuleUpdateReq : IDouyinReq<SupermCapacityRuleUpdateRsp>
{

	public string GetMethod() { return "superm.capacityRule.update"; }

	public string GetUrl() { return "/superm/capacityRule/update"; }

	[JsonPropertyName("rule_operate_param")]
	[Description("产能规则实体")]
	[NotNull]
	public RuleOperateParamItem RuleOperateParam { get; set; }

	public class RuleOperateParamItem
	{
		[JsonPropertyName("rule_dto")]
		[Description("产能规则")]
		public RuleDtoItem RuleDto { get; set; }

		public class RuleDtoItem
		{
			[JsonPropertyName("rule_id")]
			[Description("规则id")]
			[NotNull]
			public string RuleId { get; set; }

			[JsonPropertyName("rule_name")]
			[Description("规则名")]
			[NotNull]
			public string RuleName { get; set; }

			[JsonPropertyName("rule_entity_type")]
			[Description("规则归属类型 ，本期只有 1: 企业")]
			[NotNull]
			public int? RuleEntityType { get; set; }

			[JsonPropertyName("date_limit_enable")]
			[Description("是否启用单日限制，1启用2不启用")]
			[NotNull]
			public int? DateLimitEnable { get; set; }

			[JsonPropertyName("date_limit_bound")]
			[Description("单日限制上限（如果启用单日限制，则必填）")]
			public long? DateLimitBound { get; set; }

			[JsonPropertyName("all_store")]
			[Description("是否勾选全部门店（1是，2否）")]
			[NotNull]
			public int? AllStore { get; set; }

			[JsonPropertyName("status")]
			[Description("规则状态，1启用，2不启用")]
			[NotNull]
			public int? Status { get; set; }
		}

		[JsonPropertyName("relations")]
		[Description("关联的门店信息")]
		public List<RelationsItem> Relations { get; set; }

		public class RelationsItem
		{
			[JsonPropertyName("capacity_target_type")]
			[Description("作业产能类型 本期只有 1:门店")]
			[NotNull]
			public int? CapacityTargetType { get; set; }

			[JsonPropertyName("capacity_target_code")]
			[Description("仓编码,门店编码等 本期只有门店ID")]
			[NotNull]
			public string CapacityTargetCode { get; set; }
		}

		[JsonPropertyName("details")]
		[Description("规则详情")]
		public List<DetailsItem> Details { get; set; }

		public class DetailsItem
		{
			[JsonPropertyName("start_date")]
			[Description("开始日期(2022-06-17)")]
			[NotNull]
			public string StartDate { get; set; }

			[JsonPropertyName("end_date")]
			[Description("结束日期(2022-06-17)")]
			[NotNull]
			public string EndDate { get; set; }

			[JsonPropertyName("start_time")]
			[Description("开始时间(19:00)")]
			[NotNull]
			public string StartTime { get; set; }

			[JsonPropertyName("end_time")]
			[Description("结束时间(23:00)")]
			[NotNull]
			public string EndTime { get; set; }

			[JsonPropertyName("time_interval")]
			[Description("产能限单时段，目前仅支持60")]
			[NotNull]
			public int? TimeInterval { get; set; }

			[JsonPropertyName("time_limit_bound")]
			[Description("产能限制单量")]
			[NotNull]
			public int? TimeLimitBound { get; set; }
		}
	}
}

[Description("门店时段容量更新")]
public class SupermCapacityRuleUpdateRsp
{
}
