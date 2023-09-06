namespace ecommerce.sdk.douyin;

[Description("1、单个图片最大不能超过10M；支持的格式有：png/jpg/webp/gif；,2、接口上传成功，素材中心会对素材进行异步审核，审核时效：非风险图片99%在4s内完成审核，风险图片我们会在24h内审核完成；对于审核失败的素材，素材中心会在一定时间内将其删除。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","解析素材格式失败","isv.parameter-invalid:20001","素材的格式不是素材中心支持的")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:10003","系统异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","素材库容量不足","isv.parameter-invalid:30001","删除无用素材 或 联系客服扩容")]
[DouyinRetCode(40004,"非法的参数","请求已生效，请勿重复请求","isv.parameter-invalid:310001","并发请求，勿重试")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:10004","系统异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","素材涉嫌违规，不能上传","isv.parameter-invalid:22007","素材涉嫌违规，不能上传")]
[DouyinRetCode(40004,"非法的参数","素材大小超出限制","isv.parameter-invalid:22001","素材大小超出限制")]
[DouyinRetCode(50002,"业务处理失败","素材下载失败，请重新上传","isv.business-failed:10010","素材下载失败，请重新上传")]
public class MaterialUploadImageSyncForIsvReq : IDouyinReq<MaterialUploadImageSyncForIsvRsp>
{

	public string GetMethod() { return "material.uploadImageSyncForIsv"; }

	public string GetUrl() { return "/material/uploadImageSyncForIsv"; }

	[JsonPropertyName("folder_id")]
	[Description("文件夹id，0为根目录")]
	[NotNull]
	public string FolderId { get; set; }

	[JsonPropertyName("url")]
	[Description("图片url，必须是公网可访问。url和file_uri二选一，不能同时为空，如果2者都不为空取url")]
	public string Url { get; set; }

	[JsonPropertyName("name")]
	[Description("图片名称，开发者自定义，不得超过50个字符。")]
	[NotNull]
	public string Name { get; set; }

	[JsonPropertyName("file_uri")]
	[Description("二进制文件对应的uri，获取方式请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
	public object FileUri { get; set; }

	[JsonPropertyName("need_distinct")]
	[Description("是否需要去重（true/false），默认为false。去重是指：存在已经审核通过且内容相同的图片，直接返回已存在的图片地址。")]
	[NotNull]
	public bool? NeedDistinct { get; set; }
}

[Description("1、单个图片最大不能超过10M；支持的格式有：png/jpg/webp/gif；,2、接口上传成功，素材中心会对素材进行异步审核，审核时效：非风险图片99%在4s内完成审核，风险图片我们会在24h内审核完成；对于审核失败的素材，素材中心会在一定时间内将其删除。")]
public class MaterialUploadImageSyncForIsvRsp
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

	[JsonPropertyName("audit_status")]
	[Description("素材审核状态; 1-等待审核; 2-审核中; 3-通过; 4-拒绝;注意：只有AuditStatus=3时ByteUrl才会返回；")]
	public int AuditStatus { get; set; }

	[JsonPropertyName("byte_url")]
	[Description("非审核通过的图片，将不返回该字段。")]
	public string ByteUrl { get; set; }
}
