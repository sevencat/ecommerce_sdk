namespace ecommerce.sdk.douyin;

[Description("根据创建时间过滤某段时间内的镜像列表")]
public class OpenCloudV1ImageVersionListReq : IDouyinReq<OpenCloudV1ImageVersionListRsp>
{

	public string GetMethod() { return "openCloud.v1.imageVersion.list"; }

	public string GetUrl() { return "/openCloud/v1/imageVersion/list"; }

	[JsonPropertyName("cs_id")]
	[Description("容器服务id")]
	public string CsId { get; set; }

	[JsonPropertyName("start_time")]
	[Description("镜像创建的开始时间")]
	public long? StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("镜像创建的开始时间")]
	public long? EndTime { get; set; }

	[JsonPropertyName("status")]
	[Description("构建状态 1:构建中，2：构建成功；3：构建异常")]
	public int? Status { get; set; }

	[JsonPropertyName("volc_account_id")]
	[Description("火山账号，如果使用强管控租户，需要传对应火山id")]
	public long? VolcAccountId { get; set; }

	[JsonPropertyName("page_index")]
	[Description("页码，从1开始")]
	[NotNull]
	public int? PageIndex { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页数量，最大100个")]
	[NotNull]
	public int? PageSize { get; set; }
}

[Description("根据创建时间过滤某段时间内的镜像列表")]
public class OpenCloudV1ImageVersionListRsp
{
	[JsonPropertyName("image_versions")]
	[Description("镜像列表")]
	public List<ImageVersionsItem> ImageVersions { get; set; }

	public class ImageVersionsItem
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

	[JsonPropertyName("total")]
	[Description("镜像总数")]
	public long Total { get; set; }
}
