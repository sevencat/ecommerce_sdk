namespace ecommerce.sdk.douyin;

[Description("某个失败状态的镜像重新构建")]
public class OpenCloudV1ImageVersionRebuildReq : IDouyinReq<OpenCloudV1ImageVersionRebuildRsp>
{

	public string GetMethod() { return "openCloud.v1.imageVersion.rebuild"; }

	public string GetUrl() { return "/openCloud/v1/imageVersion/rebuild"; }

	[JsonPropertyName("version_id")]
	[Description("镜像id")]
	[NotNull]
	public string VersionId { get; set; }

	[JsonPropertyName("volc_account_id")]
	[Description("火山账号，如果使用强管控租户，需要传对应火山id")]
	public long? VolcAccountId { get; set; }
}

[Description("某个失败状态的镜像重新构建")]
public class OpenCloudV1ImageVersionRebuildRsp
{
}
