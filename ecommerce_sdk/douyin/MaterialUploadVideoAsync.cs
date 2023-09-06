namespace ecommerce.sdk.douyin;

[Description("1. 视频大小限200M;,2. 接口同步接受上传视频的请求，异步处理：视频的下载、格式校验、审核等过程；,3. 视频的审核时间根据素材中心素材数量而定，大部分视频在1分钟内能审核完，小部分视频审核时间会达到天级别，请耐心等待；,4、上传时需要关注文件夹属性，只有0（文件夹）和2（视频文件夹）才可以上传视频。文件夹属性可通过【/material/getFolderInfo】和【/material/searchFolder】查看。,5. 审核拒绝的视频将在15日内被定期清理，请慎用。,其他问题请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:20001","请检查参数")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:10004","系统异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","素材大小超出限制","isv.parameter-invalid:22001","视频大小超出限制，勿重复操作")]
[DouyinRetCode(40004,"非法的参数","请求已生效，请勿重复请求","isv.parameter-invalid:31001","并发请求导致，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","素材库容量不足","isv.parameter-invalid:30001","容量不足，删除部分素材后重试")]
[DouyinRetCode(50002,"业务处理失败","素材下载失败，请重新上传","isv.business-failed:10010","素材下载失败，请重新上传")]
public class MaterialUploadVideoAsyncReq : IDouyinReq<MaterialUploadVideoAsyncRsp>
{

	public string GetMethod() { return "material.uploadVideoAsync"; }

	public string GetUrl() { return "/material/uploadVideoAsync"; }

	[JsonPropertyName("folder_id")]
	[Description("父文件夹id，0为根目录。若需要创建文件夹，请参考：https://ehome.bytedance.net/djt/apiManage/doc/preview/946?doc=true")]
	[NotNull]
	public string FolderId { get; set; }

	[JsonPropertyName("url")]
	[Description("视频url，url和file_uri二选一，不能同时为空，如果2者都传则取url")]
	public string Url { get; set; }

	[JsonPropertyName("name")]
	[Description("视频名称，不得超过50个字符，最好带上后缀")]
	[NotNull]
	public string Name { get; set; }

	[JsonPropertyName("file_uri")]
	[Description("二进制文件对应的uri，获取方式请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
	public object FileUri { get; set; }
}

[Description("1. 视频大小限200M;,2. 接口同步接受上传视频的请求，异步处理：视频的下载、格式校验、审核等过程；,3. 视频的审核时间根据素材中心素材数量而定，大部分视频在1分钟内能审核完，小部分视频审核时间会达到天级别，请耐心等待；,4、上传时需要关注文件夹属性，只有0（文件夹）和2（视频文件夹）才可以上传视频。文件夹属性可通过【/material/getFolderInfo】和【/material/searchFolder】查看。,5. 审核拒绝的视频将在15日内被定期清理，请慎用。,其他问题请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
public class MaterialUploadVideoAsyncRsp
{
	[JsonPropertyName("material_id")]
	[Description("素材id")]
	public string MaterialId { get; set; }

	[JsonPropertyName("folder_id")]
	[Description("素材所在文件夹id，0-素材中心的根目录")]
	public string FolderId { get; set; }

	[JsonPropertyName("is_new")]
	[Description("是否是新建，false-重复请求 true-新建")]
	public bool IsNew { get; set; }

	[JsonPropertyName("audit_status")]
	[Description("素材审核状态 0-下载中 1-等待审核 2-审核中 3-通过 4-拒绝")]
	public int AuditStatus { get; set; }
}
