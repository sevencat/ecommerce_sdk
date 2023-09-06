namespace ecommerce.sdk.douyin;

[Description("获取发布详细信息")]
public class OpenCloudV1DeployTicketDetailReq : IDouyinReq<OpenCloudV1DeployTicketDetailRsp>
{

	public string GetMethod() { return "openCloud.v1.deployTicket.detail"; }

	public string GetUrl() { return "/openCloud/v1/deployTicket/detail"; }

	[JsonPropertyName("cs_id")]
	[Description("容器id")]
	[NotNull]
	public string CsId { get; set; }

	[JsonPropertyName("ticket_id")]
	[Description("发布单id")]
	[NotNull]
	public string TicketId { get; set; }

	[JsonPropertyName("volc_account_id")]
	[Description("如果是强管控租户，需要传火山账号id")]
	public long? VolcAccountId { get; set; }
}

[Description("获取发布详细信息")]
public class OpenCloudV1DeployTicketDetailRsp
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
		[Description("发布单类型")]
		public int TicketType { get; set; }

		[JsonPropertyName("ticket_status")]
		[Description("发布单状态。0:待审批；10:待部署；20:部署中；40:部分成功，但是存在异常；98:取消发布；99:部署失败；100:部署成功；110:已回滚；")]
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

	[JsonPropertyName("cs")]
	[Description("容器信息")]
	public CsItem Cs { get; set; }

	public class CsItem
	{
		[JsonPropertyName("cs_id")]
		[Description("容器服务Id")]
		public string CsId { get; set; }

		[JsonPropertyName("cs_name")]
		[Description("容器服务名称")]
		public string CsName { get; set; }

		[JsonPropertyName("cluster_name")]
		[Description("关联集群名称")]
		public string ClusterName { get; set; }

		[JsonPropertyName("cs_resource_status")]
		[Description("容器资源状态")]
		public int CsResourceStatus { get; set; }

		[JsonPropertyName("instance_spec")]
		[Description("实例配置")]
		public InstanceSpecItem InstanceSpec { get; set; }

		public class InstanceSpecItem
		{
			[JsonPropertyName("requested_cpu")]
			[Description("CPU请求 单位:核")]
			public string RequestedCpu { get; set; }

			[JsonPropertyName("requested_memory")]
			[Description("内存请求 单位:MiB")]
			public string RequestedMemory { get; set; }

			[JsonPropertyName("limited_cpu")]
			[Description("CPU上限 单位:核")]
			public string LimitedCpu { get; set; }

			[JsonPropertyName("limited_memory")]
			[Description("内存上限 单位:MiB")]
			public string LimitedMemory { get; set; }

			[JsonPropertyName("instance_num")]
			[Description("实例个数")]
			public int InstanceNum { get; set; }

			[JsonPropertyName("cron_str")]
			[Description("cron 表达式")]
			public string CronStr { get; set; }
		}

		[JsonPropertyName("create_time")]
		[Description("创建时间")]
		public int CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public int UpdateTime { get; set; }

		[JsonPropertyName("cs_type")]
		[Description("容器服务类型。1:无状态部署；2：cronjob")]
		public int CsType { get; set; }

		[JsonPropertyName("image_id")]
		[Description("镜像 id")]
		public string ImageId { get; set; }

		[JsonPropertyName("image_desc")]
		[Description("镜像描述")]
		public string ImageDesc { get; set; }

		[JsonPropertyName("image_type")]
		[Description("镜像类型。1:官方镜像；2:自定义镜像")]
		public int ImageType { get; set; }

		[JsonPropertyName("custom_image")]
		[Description("自定义镜像")]
		public CustomImageItem CustomImage { get; set; }

		public class CustomImageItem
		{
			[JsonPropertyName("repo")]
			[Description("镜像名称")]
			public string Repo { get; set; }

			[JsonPropertyName("tag_name")]
			[Description("镜像版本")]
			public string TagName { get; set; }

			[JsonPropertyName("contain_code_package")]
			[Description("镜像是否包含代码包")]
			public bool ContainCodePackage { get; set; }
		}

		[JsonPropertyName("cs_env")]
		[Description("环境信息；1:测试；2:线上")]
		public int CsEnv { get; set; }
	}

	[JsonPropertyName("image_version")]
	[Description("镜像信息")]
	public ImageVersionItem ImageVersion { get; set; }

	public class ImageVersionItem
	{
		[JsonPropertyName("version_id")]
		[Description("镜像版本id")]
		public string VersionId { get; set; }

		[JsonPropertyName("cs_id")]
		[Description("容器服务id")]
		public string CsId { get; set; }

		[JsonPropertyName("version_name")]
		[Description("版本名称")]
		public string VersionName { get; set; }

		[JsonPropertyName("status")]
		[Description("构建状态 1:构建中，2：构建成功；3：构建异常")]
		public int Status { get; set; }

		[JsonPropertyName("remark")]
		[Description("备注")]
		public string Remark { get; set; }

		[JsonPropertyName("file_name")]
		[Description("文件名称")]
		public string FileName { get; set; }

		[JsonPropertyName("failed_reason")]
		[Description("构建失败原因")]
		public string FailedReason { get; set; }

		[JsonPropertyName("create_time")]
		[Description("构建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("cs_name")]
		[Description("容器服务名称")]
		public string CsName { get; set; }
	}
}
