namespace ecommerce.sdk.douyin;

[Description("门店时段容量查询列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40100","参数错误")]
[DouyinRetCode(50002,"业务处理失败","数据转换错误","isv.business-failed:50202","数据转换错误")]
[DouyinRetCode(50002,"业务处理失败","获取组织关系失败","isv.business-failed:20232","获取组织关系失败")]
[DouyinRetCode(50002,"业务处理失败","门店查询服务失败","isv.business-failed:20233","门店查询服务失败")]
public class SupermCapacityRuleQueryListReq : IDouyinReq<SupermCapacityRuleQueryListRsp>
{

	public string GetMethod() { return "superm.capacityRule.queryList"; }

	public string GetUrl() { return "/superm/capacityRule/queryList"; }

	[JsonPropertyName("page_query")]
	[Description("查询条件")]
	[NotNull]
	public PageQueryItem PageQuery { get; set; }

	public class PageQueryItem
	{
		[JsonPropertyName("rule_query")]
		[Description("规则")]
		[NotNull]
		public RuleQueryItem RuleQuery { get; set; }

		public class RuleQueryItem
		{
			[JsonPropertyName("rule_entity_type")]
			[Description("规则归属类型 ，本期只有 1: 企业")]
			[NotNull]
			public int? RuleEntityType { get; set; }

			[JsonPropertyName("rule_name")]
			[Description("规则名")]
			public string RuleName { get; set; }

			[JsonPropertyName("create_time_start")]
			[Description("开始时间 秒级时间戳")]
			public long? CreateTimeStart { get; set; }

			[JsonPropertyName("create_time_end")]
			[Description("结束时间 秒级时间戳")]
			public long? CreateTimeEnd { get; set; }

			[JsonPropertyName("creator")]
			[Description("创建人")]
			public string Creator { get; set; }

			[JsonPropertyName("status")]
			[Description("规则状态，1启用，2不启用")]
			public int? Status { get; set; }

			[JsonPropertyName("capacity_target_type")]
			[Description("作业产能类型 本期只有 1:门店")]
			public int? CapacityTargetType { get; set; }

			[JsonPropertyName("capacity_target_code")]
			[Description("门店id")]
			public List<string> CapacityTargetCode { get; set; }
		}

		[JsonPropertyName("current_page")]
		[Description("页码，从1计算")]
		[NotNull]
		public int? CurrentPage { get; set; }

		[JsonPropertyName("page_size")]
		[Description("pageSize")]
		[NotNull]
		public int? PageSize { get; set; }
	}
}

[Description("门店时段容量查询列表")]
public class SupermCapacityRuleQueryListRsp
{
	[JsonPropertyName("page_dto")]
	[Description("查询到的实体信息")]
	public PageDtoItem PageDto { get; set; }

	public class PageDtoItem
	{
		[JsonPropertyName("rule_dtos")]
		[Description("规则列表")]
		public List<RuleDtosItem> RuleDtos { get; set; }

		public class RuleDtosItem
		{
			[JsonPropertyName("rule_dto")]
			[Description("规则尸体")]
			public RuleDtoItem RuleDto { get; set; }

			public class RuleDtoItem
			{
				[JsonPropertyName("rule_id")]
				[Description("id")]
				public string RuleId { get; set; }

				[JsonPropertyName("rule_name")]
				[Description("规则名")]
				public string RuleName { get; set; }

				[JsonPropertyName("rule_entity_type")]
				[Description("规则归属类型 ，本期只有 1: 企业")]
				public int RuleEntityType { get; set; }

				[JsonPropertyName("date_limit_enable")]
				[Description("是否启用单日限制，1启用2不启用")]
				public int DateLimitEnable { get; set; }

				[JsonPropertyName("date_limit_bound")]
				[Description("单日限制上限（如果启用单日限制，则必填）")]
				public long DateLimitBound { get; set; }

				[JsonPropertyName("all_store")]
				[Description("是否勾选全部门店（1是，2否）")]
				public int AllStore { get; set; }

				[JsonPropertyName("status")]
				[Description("规则状态，1启用，2不启用")]
				public int Status { get; set; }

				[JsonPropertyName("creator")]
				[Description("创建人")]
				public string Creator { get; set; }

				[JsonPropertyName("create_time")]
				[Description("创建时间")]
				public long CreateTime { get; set; }

				[JsonPropertyName("updater")]
				[Description("更新人")]
				public string Updater { get; set; }
			}

			[JsonPropertyName("relations")]
			[Description("关联的门店信息")]
			public List<RelationsItem> Relations { get; set; }

			public class RelationsItem
			{
				[JsonPropertyName("rule_id")]
				[Description("id")]
				public string RuleId { get; set; }

				[JsonPropertyName("capacity_target_type")]
				[Description("作业产能类型 本期只有 1:门店")]
				public int CapacityTargetType { get; set; }

				[JsonPropertyName("capacity_target_code")]
				[Description("仓编码,门店编码等 本期只有门店ID")]
				public string CapacityTargetCode { get; set; }
			}
		}

		[JsonPropertyName("current_page")]
		[Description("页码，从1计")]
		public int CurrentPage { get; set; }

		[JsonPropertyName("page_size")]
		[Description("pageSize")]
		public int PageSize { get; set; }

		[JsonPropertyName("total_count")]
		[Description("总数")]
		public long TotalCount { get; set; }
	}
}
