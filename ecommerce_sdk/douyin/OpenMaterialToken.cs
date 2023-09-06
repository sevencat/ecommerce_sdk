namespace ecommerce.sdk.douyin;

[Description("获取素材上传接口访问token")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","100000:参数错误","isv.business-failed:100000","联系开放平台同学")]
public class OpenMaterialTokenReq : IDouyinReq<OpenMaterialTokenRsp>
{

	public string GetMethod() { return "open.materialToken"; }

	public string GetUrl() { return "/open/materialToken"; }

	[JsonPropertyName("upload_num")]
	[Description("需要上传的素材数量")]
	[NotNull]
	public long? UploadNum { get; set; }

	[JsonPropertyName("file_extension")]
	[Description("文件后缀名称，必须以.开头")]
	public string FileExtension { get; set; }

	[JsonPropertyName("biz_type")]
	[Description("业务类型， 1: 素材中心 。 2: ImageX")]
	public int? BizType { get; set; }

	[JsonPropertyName("store_keys_array_json")]
	[Description("当 biz_type 为 2，则可以自定义路径名")]
	public string StoreKeysArrayJson { get; set; }
}

[Description("获取素材上传接口访问token")]
public class OpenMaterialTokenRsp
{
	[JsonPropertyName("auth_query")]
	[Description("获取下载地址query")]
	public string AuthQuery { get; set; }
}
