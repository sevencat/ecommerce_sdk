namespace ecommerce.sdk.douyin;

[Description("获取上传镜像仓库的临时token")]
public class OpenCloudV1CrTokenGetReq : IDouyinReq<OpenCloudV1CrTokenGetRsp>
{

	public string GetMethod() { return "openCloud.v1.cr.token.get"; }

	public string GetUrl() { return "/openCloud/v1/cr/token/get"; }

	[JsonPropertyName("volc_account_id")]
	[Description("火山账号，如果使用强管控租户，需要传对应火山id")]
	public long? VolcAccountId { get; set; }
}

[Description("获取上传镜像仓库的临时token")]
public class OpenCloudV1CrTokenGetRsp
{
	[JsonPropertyName("authorization_token")]
	[Description("临时访问token")]
	public string AuthorizationToken { get; set; }

	[JsonPropertyName("expire_time")]
	[Description("过期时间")]
	public string ExpireTime { get; set; }
}
