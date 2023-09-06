namespace ecommerce.sdk.douyin;

[Description("1. 视频大小限200M; 2. 接口同步接受上传视频的请求，异步处理：视频的下载、格式校验、审核等过程； 3. 视频的审核时间根据素材中心素材数量而定，大部分视频在1分钟内能审核完，小部分视频审核时间会达到天级别，请耐心等待；  4. 审核拒绝的视频将在15日内被定期清理，请慎用。 其他问题请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","解析素材格式失败","isv.parameter-invalid:20001","素材的格式不是素材中心支持的")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:10003","系统异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","素材库容量不足","isv.parameter-invalid:30001","删除无用素材 或 联系客服扩容")]
[DouyinRetCode(40004,"非法的参数","请求已生效，请勿重复请求","isv.parameter-invalid:310001","并发请求，勿重试")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:10004","系统异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","素材涉嫌违规，不能上传","isv.parameter-invalid:22007","素材涉嫌违规，不能上传")]
[DouyinRetCode(40004,"非法的参数","素材大小超出限制","isv.parameter-invalid:22001","素材大小超出限制")]
[DouyinRetCode(50002,"业务处理失败","素材下载失败，请重新上传","isv.business-failed:10010","素材下载失败，请重新上传")]
public class MaterialUploadVideoAsyncForIsvReq : IDouyinReq<MaterialUploadVideoAsyncForIsvRsp>
{

	public string GetMethod() { return "material.uploadVideoAsyncForIsv"; }

	public string GetUrl() { return "/material/uploadVideoAsyncForIsv"; }

	[JsonPropertyName("folder_id")]
	[Description("文件夹id，0为根目录")]
	[NotNull]
	public string FolderId { get; set; }

	[JsonPropertyName("url")]
	[Description("图片url，必须是公网可访问。url和file_uri二选一，不能同时为空，如果2者都不为空取url")]
	public string Url { get; set; }

	[JsonPropertyName("name")]
	[Description("视频名称，开发者自定义，不得超过50个字符。")]
	[NotNull]
	public string Name { get; set; }

	[JsonPropertyName("file_uri")]
	[Description("二进制文件对应的uri，获取方式请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
	public object FileUri { get; set; }
}

[Description("1. 视频大小限200M; 2. 接口同步接受上传视频的请求，异步处理：视频的下载、格式校验、审核等过程； 3. 视频的审核时间根据素材中心素材数量而定，大部分视频在1分钟内能审核完，小部分视频审核时间会达到天级别，请耐心等待；  4. 审核拒绝的视频将在15日内被定期清理，请慎用。 其他问题请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
public class MaterialUploadVideoAsyncForIsvRsp
{
	[JsonPropertyName("material_id")]
	[Description("素材id")]
	public string MaterialId { get; set; }

	[JsonPropertyName("folder_id")]
	[Description("素材所在文件夹id，0-素材中心的根目录；其他值-表示对应的文件夹id；")]
	public string FolderId { get; set; }

	[JsonPropertyName("is_new")]
	[Description("是否是新建，true-新建")]
	public bool IsNew { get; set; }
}
