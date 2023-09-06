namespace ecommerce.sdk.douyin;

[Description("使用场景： 1、必须先调用【/microapp/UpdateStaticFileMeta 】接口，需先请求path路径成功上传后，并审核通过； 2、使用相同的path路径请求该接口；注意如返回为空表示未上传path或path不存在； 3、path：最大支持一次上传1000个，接口仅返回path路径存在并审核通过的链接，失败的不返回。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数有误","isv.parameter-invalid:8000002","请参考文档填写正确参数")]
[DouyinRetCode(40004,"非法的参数","appKey参数有误","isv.parameter-invalid:8000006","请填写正确的 appKey")]
[DouyinRetCode(20000,"系统错误","内部错误","isp.service-error:8000001","联系开放平台同学解决")]
public class MicroappGetStaticFileUrlBatchReq : IDouyinReq<MicroappGetStaticFileUrlBatchRsp>
{

	public string GetMethod() { return "microapp.GetStaticFileUrlBatch"; }

	public string GetUrl() { return "/microapp/GetStaticFileUrlBatch"; }

	[JsonPropertyName("store_type")]
	[Description("选择文件场景， 1：素材中心， 2：TOS临时文件，3: ImageX。")]
	[NotNull]
	public int? StoreType { get; set; }

	[JsonPropertyName("path")]
	[Description("文件path路径，请先调用【/microapp/UpdateStaticFileMeta 】上传并审核通过的。")]
	[NotNull]
	public List<string> Path { get; set; }

	[JsonPropertyName("bucket_name")]
	[Description("【目前暂不支持，后续有规划开放】bucket名称，在后端tos场景才需要传")]
	public string BucketName { get; set; }
}

[Description("使用场景： 1、必须先调用【/microapp/UpdateStaticFileMeta 】接口，需先请求path路径成功上传后，并审核通过； 2、使用相同的path路径请求该接口；注意如返回为空表示未上传path或path不存在； 3、path：最大支持一次上传1000个，接口仅返回path路径存在并审核通过的链接，失败的不返回。")]
public class MicroappGetStaticFileUrlBatchRsp
{
	[JsonPropertyName("url_map")]
	[Description("文件信息， key为path，value为url；注意：批量获取时接口仅返回path路径存在并审核通过的链接，失败的不返回；单个获取时失败返回为空；")]
	public Dictionary<string,string> UrlMap { get; set; }
}
