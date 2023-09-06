namespace ecommerce.sdk.douyin;

[Description("素材中心同步创建图片素材接口,1、如需上传多个素材，请使用批量上传图片接口：【/material/batchUploadImageSync】且单个图片最大不能超过10M；支持的格式有：png/jpg；,3、接口上传成功，素材中心会对素材进行异步审核，审核时效：非风险图片99%在4s内完成审核，风险图片我们会在24h内审核完成；对于审核失败的素材，素材中心会在一定时间内将其删除。,4、上传时需要关注文件夹属性，只有0（文件夹）和1（图片文件夹）才可以上传图片。文件夹属性可通过【/material/getFolderInfo】和【/material/searchFolder】查看；,5、2022年11月-素材接口字段变更公告：https://op.jinritemai.com/docs/notice-docs/5/2668 响应参数ByteUrl字段废弃；只有AuditStatus=3时ByteUrl才会返回；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","解析素材格式失败","isv.parameter-invalid:20001","素材的格式不是素材中心支持的")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10003","系统异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","素材库容量不足","isv.parameter-invalid:30001","联系客服扩容")]
[DouyinRetCode(40004,"非法的参数","请求已生效，请勿重复请求","isv.parameter-invalid:31001","并发请求，勿重试")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:10004","系统异常，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","素材涉嫌违规，不能上传","isv.business-failed:22007","素材涉嫌违规，不能上传")]
[DouyinRetCode(50002,"业务处理失败","存在重复图片，请勿上传重复图片","isv.business-failed:31003","同一个请求中，存在重复图片")]
[DouyinRetCode(50002,"业务处理失败","素材大小超出限制","isv.business-failed:22001","素材大小超出限制")]
[DouyinRetCode(50002,"业务处理失败","素材下载失败，请重新上传","isv.business-failed:10010","素材下载失败，请重新上传")]
[DouyinRetCode(50002,"业务处理失败","当前文件夹下不支持创建该类素材","isv.business-failed:22006","请确定文件夹属性是否支持上传图片")]
[DouyinRetCode(50002,"业务处理失败","30004:已退店商家不支持创建素材/文件夹","isv.business-failed:30004","请检查店铺状态")]
public class MaterialUploadImageSyncReq : IDouyinReq<MaterialUploadImageSyncRsp>
{

	public string GetMethod() { return "material.uploadImageSync"; }

	public string GetUrl() { return "/material/uploadImageSync"; }

	[JsonPropertyName("folder_id")]
	[Description("文件夹id，0为根目录")]
	[NotNull]
	public string FolderId { get; set; }

	[JsonPropertyName("url")]
	[Description("图片url，必须是公网可访问。url和file_uri二选一，不能同时为空，如果2者都不为空取url")]
	public string Url { get; set; }

	[JsonPropertyName("material_name")]
	[Description("图片名称，开发者自定义，不得超过50个字符。")]
	[NotNull]
	public string MaterialName { get; set; }

	[JsonPropertyName("file_uri")]
	[Description("二进制文件对应的uri，获取方式请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
	public object FileUri { get; set; }

	[JsonPropertyName("need_distinct")]
	[Description("是否需要去重（true/false），默认为false。去重是指：存在已经审核通过且内容相同的图片，直接返回已存在的图片地址。")]
	public bool? NeedDistinct { get; set; }
}

[Description("素材中心同步创建图片素材接口,1、如需上传多个素材，请使用批量上传图片接口：【/material/batchUploadImageSync】且单个图片最大不能超过10M；支持的格式有：png/jpg；,3、接口上传成功，素材中心会对素材进行异步审核，审核时效：非风险图片99%在4s内完成审核，风险图片我们会在24h内审核完成；对于审核失败的素材，素材中心会在一定时间内将其删除。,4、上传时需要关注文件夹属性，只有0（文件夹）和1（图片文件夹）才可以上传图片。文件夹属性可通过【/material/getFolderInfo】和【/material/searchFolder】查看；,5、2022年11月-素材接口字段变更公告：https://op.jinritemai.com/docs/notice-docs/5/2668 响应参数ByteUrl字段废弃；只有AuditStatus=3时ByteUrl才会返回；")]
public class MaterialUploadImageSyncRsp
{
	[JsonPropertyName("material_id")]
	[Description("素材id；MaterialId调用【/material/queryMaterialDetail】接口，当audit_status=3时获取byte_url；")]
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
	[Description("【已下线】新的URL可使用下列方式获取：方式一：可监听【店铺使用doudian_material_auditResultForShop】或【供应商使用doudian_material_auditResultForBSCP】audit_status=3时可以使用byte_url；方式二：根据响应参数MaterialId调用【/material/queryMaterialDetail】接口，当audit_status=3时获取byte_url；")]
	public string ByteUrl { get; set; }
}
