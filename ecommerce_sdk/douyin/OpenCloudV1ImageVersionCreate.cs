namespace ecommerce.sdk.douyin;

[Description("上传程序包构建镜像")]
public class OpenCloudV1ImageVersionCreateReq : IDouyinReq<OpenCloudV1ImageVersionCreateRsp>
{

	public string GetMethod() { return "openCloud.v1.imageVersion.create"; }

	public string GetUrl() { return "/openCloud/v1/imageVersion/create"; }

	[JsonPropertyName("cs_id")]
	[Description("容器服务id")]
	[NotNull]
	public string CsId { get; set; }

	[JsonPropertyName("version_name")]
	[Description("版本名称")]
	[NotNull]
	public string VersionName { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	[NotNull]
	public string Remark { get; set; }

	[JsonPropertyName("file_uri")]
	[Description("程序包上传素材中心后返回的uri")]
	[NotNull]
	public object FileUri { get; set; }

	[JsonPropertyName("file_name")]
	[Description("文件名称")]
	[NotNull]
	public string FileName { get; set; }

	[JsonPropertyName("cs_name")]
	[Description("容器名称")]
	[NotNull]
	public string CsName { get; set; }

	[JsonPropertyName("volc_account_id")]
	[Description("火山账号，如果使用强管控租户，需要传对应火山id")]
	public long? VolcAccountId { get; set; }
}

[Description("上传程序包构建镜像")]
public class OpenCloudV1ImageVersionCreateRsp
{
	[JsonPropertyName("version_id")]
	[Description("镜像版本id")]
	public string VersionId { get; set; }
}
