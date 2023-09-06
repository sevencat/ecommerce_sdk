namespace ecommerce.sdk.douyin;

[Description("ISV上传静态资源后绑定相对路径")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数有误","isv.parameter-invalid:8000002","请参考文档填写正确参数")]
[DouyinRetCode(40004,"非法的参数","appKey参数有误","isv.parameter-invalid:8000006","请填写正确的 appKey")]
[DouyinRetCode(20000,"系统错误","内部错误","isp.service-error:8000001","联系开放平台同学解决")]
[DouyinRetCode(20000,"系统错误","内部错误","isp.service-error:8000004","联系开放平台同学解决")]
[DouyinRetCode(50002,"业务处理失败","静态资源path字段有重复值，请检查","isv.business-failed:9900007","使用新的path")]
public class MicroappUpdateStaticFileMetaReq : IDouyinReq<MicroappUpdateStaticFileMetaRsp>
{

	public string GetMethod() { return "microapp.UpdateStaticFileMeta"; }

	public string GetUrl() { return "/microapp/UpdateStaticFileMeta"; }

	[JsonPropertyName("store_type")]
	[Description("存储类型。 1: 素材中心。 3:ImageX")]
	public int? StoreType { get; set; }

	[JsonPropertyName("path")]
	[Description("文件相对路径，前端请求获取文件时需填该值")]
	[NotNull]
	public string Path { get; set; }

	[JsonPropertyName("material_id")]
	[Description("素材id，由素材中心接口返回")]
	public string MaterialId { get; set; }

	[JsonPropertyName("file_size")]
	[Description("文件大小, 单位为B")]
	public long? FileSize { get; set; }
}

[Description("ISV上传静态资源后绑定相对路径")]
public class MicroappUpdateStaticFileMetaRsp
{
}
