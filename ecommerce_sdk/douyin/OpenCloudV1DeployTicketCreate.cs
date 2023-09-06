namespace ecommerce.sdk.douyin;

[Description("创建发布单")]
public class OpenCloudV1DeployTicketCreateReq : IDouyinReq<OpenCloudV1DeployTicketCreateRsp>
{

	public string GetMethod() { return "openCloud.v1.deployTicket.create"; }

	public string GetUrl() { return "/openCloud/v1/deployTicket/create"; }

	[JsonPropertyName("config_id")]
	[Description("配置id")]
	[NotNull]
	public string ConfigId { get; set; }

	[JsonPropertyName("cs_id")]
	[Description("容器服务id")]
	[NotNull]
	public string CsId { get; set; }

	[JsonPropertyName("image_version_id")]
	[Description("镜像版本id")]
	[NotNull]
	public string ImageVersionId { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("upgrade_strategy")]
	[Description("实例更新策略。1:滚动更新；2:重新创建")]
	public int? UpgradeStrategy { get; set; }

	[JsonPropertyName("max_unavailable")]
	[Description("最大不可用，百分比，范围[0-100]")]
	public int? MaxUnavailable { get; set; }

	[JsonPropertyName("max_surge")]
	[Description("最大超量，百分比，范围[0-100]")]
	public int? MaxSurge { get; set; }

	[JsonPropertyName("cron_job_advanced_conf")]
	[Description("高级配置")]
	public CronJobAdvancedConfItem CronJobAdvancedConf { get; set; }

	public class CronJobAdvancedConfItem
	{
		[JsonPropertyName("successful_jobs_history_limit")]
		[Description("成功任务保留数, 取值: 空,[0,65535], 默认 空")]
		public int? SuccessfulJobsHistoryLimit { get; set; }

		[JsonPropertyName("failed_jobs_history_limit")]
		[Description("失败任务保留数, 取值: 空,[0,65535], 默认 空")]
		public int? FailedJobsHistoryLimit { get; set; }

		[JsonPropertyName("concurrency_policy")]
		[Description("并发策略, 默认 Allow。 0:允许, 默认；1：禁止；2:替换")]
		[NotNull]
		public int? ConcurrencyPolicy { get; set; }

		[JsonPropertyName("completions")]
		[Description("成功运行次数, 取值: 空,[0,65535], 默认 空")]
		public int? Completions { get; set; }

		[JsonPropertyName("parallelism")]
		[Description("可并行数, 取值: 空,[0,65535], 默认 空")]
		public int? Parallelism { get; set; }

		[JsonPropertyName("active_deadline_seconds")]
		[Description("最大超时时间, 取值: 空,[0,65535] 默认 空, 单位: 秒")]
		public long? ActiveDeadlineSeconds { get; set; }

		[JsonPropertyName("backoff_limit")]
		[Description("重试次数, 取值: 空,[0,65535], 默认 空")]
		public int? BackoffLimit { get; set; }

		[JsonPropertyName("restart_policy")]
		[Description("重启策略。0:永不重启；1：失败时重启")]
		[NotNull]
		public int? RestartPolicy { get; set; }
	}

	[JsonPropertyName("volc_account_id")]
	[Description("火山账号，如果使用强管控租户，需要传对应火山id")]
	public long? VolcAccountId { get; set; }
}

[Description("创建发布单")]
public class OpenCloudV1DeployTicketCreateRsp
{
	[JsonPropertyName("ticket")]
	[Description("发布单信息")]
	public TicketItem Ticket { get; set; }

	public class TicketItem
	{
		[JsonPropertyName("name")]
		[Description("发布单名称")]
		public string Name { get; set; }

		[JsonPropertyName("ticket_id")]
		[Description("发布单id")]
		public string TicketId { get; set; }

		[JsonPropertyName("ticket_type")]
		[Description("发布单类型。0:正常发布；1:重启发布；2:回退发布")]
		public int TicketType { get; set; }

		[JsonPropertyName("ticket_status")]
		[Description("发布单状态。0:待审批；10:待部署；20:部署中；40：部分成功，但是存在异常；98:取消发布；99:部署失败； 100:部署成功；110:已回滚")]
		public int TicketStatus { get; set; }

		[JsonPropertyName("config_id")]
		[Description("配置id")]
		public string ConfigId { get; set; }

		[JsonPropertyName("cs_id")]
		[Description("容器服务id")]
		public string CsId { get; set; }

		[JsonPropertyName("image_version_id")]
		[Description("镜像版本id")]
		public string ImageVersionId { get; set; }

		[JsonPropertyName("remark")]
		[Description("备注")]
		public string Remark { get; set; }

		[JsonPropertyName("upgrade_strategy")]
		[Description("升级策略。1:滚动更新；2:重新创建")]
		public int UpgradeStrategy { get; set; }

		[JsonPropertyName("max_unavailable")]
		[Description("最大不可用，百分比，范围[0-100]")]
		public int MaxUnavailable { get; set; }

		[JsonPropertyName("max_surge")]
		[Description("最大超量，百分比，范围[0-100]")]
		public int MaxSurge { get; set; }

		[JsonPropertyName("extra")]
		[Description("附加信息")]
		public Dictionary<string,string> Extra { get; set; }

		[JsonPropertyName("use_time")]
		[Description("发布耗时")]
		public int UseTime { get; set; }

		[JsonPropertyName("show_instance_list")]
		[Description("是否需要展示实例列表")]
		public bool ShowInstanceList { get; set; }

		[JsonPropertyName("confirm_time")]
		[Description("确认时间")]
		public int ConfirmTime { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间")]
		public int CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public int UpdateTime { get; set; }

		[JsonPropertyName("max_unavailable_num")]
		[Description("最大不可用，以实例个数为单位")]
		public int MaxUnavailableNum { get; set; }

		[JsonPropertyName("max_surge_num")]
		[Description("最大超量，以实例个数为单位")]
		public int MaxSurgeNum { get; set; }
	}
}
