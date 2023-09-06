namespace ecommerce.sdk.douyin;

[Description("1、一次上传的数量限制50张图片且单个图片最大不能超过10M；,2、接口上传成功，素材中心会对素材进行异步审核，审核时效：非风险图片99%在4s内完成审核，风险图片我们会在24h内审核完成；对于审核失败的素材，素材中心会在一定时间内将其删除；,3、上传时需要关注文件夹属性为0-文件夹和1-图片文件夹才可以上传图片，文件夹属性可通过【/material/getFolderInfo】和【/material/searchFolder】查看。,4、2022年11月-素材接口字段变更公告：https://op.jinritemai.com/docs/notice-docs/5/2668 响应参数ByteUrl字段废弃")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","request_id无效","isv.parameter-invalid:20002","使用有效的request_id")]
[DouyinRetCode(50002,"业务处理失败","请求已生效，请勿重复请求","isv.business-failed:31001","并发请求，不要重复请求")]
[DouyinRetCode(40004,"非法的参数","素材数量为空或者超出50个","isv.parameter-invalid:20001","参数错误")]
[DouyinRetCode(50002,"业务处理失败","素材库容量不足","isv.business-failed:30001","联系客服扩容")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10003","内部错误，稍后重试")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10004","系统异常，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","素材涉嫌违规，不能上传","isv.business-failed:22007","素材涉嫌违规，不能上传")]
[DouyinRetCode(50002,"业务处理失败","存在重复图片，请勿上传重复图片","isv.business-failed:31003","本次请求中存在重复图片")]
[DouyinRetCode(50002,"业务处理失败","素材下载失败，请重新上传","isv.business-failed:10010","重新上传")]
[DouyinRetCode(40004,"非法的参数","素材大小超出限制","isv.parameter-invalid:22001","素材大小超出限制，不要重试")]
[DouyinRetCode(50002,"业务处理失败","已退店商家不支持创建素材/文件夹","isv.business-failed:30004","请联系客服，不要重复请求")]
public class MaterialBatchUploadImageSyncReq : IDouyinReq<MaterialBatchUploadImageSyncRsp>
{

	public string GetMethod() { return "material.batchUploadImageSync"; }

	public string GetUrl() { return "/material/batchUploadImageSync"; }

	[JsonPropertyName("materials")]
	[Description("素材信息；一次上传的数量限制50张图片且单个图片最大不能超过10M；")]
	[NotNull]
	public List<MaterialsItem> Materials { get; set; }

	public class MaterialsItem
	{
		[JsonPropertyName("request_id")]
		[Description("该参数仅有2个作用：（1）一次请求中素材的唯一标示；（2）接口防并发，规则是：不同请求所有request_id排序之后拼接起来，若相同视为同一次请求")]
		[NotNull]
		public string RequestId { get; set; }

		[JsonPropertyName("folder_id")]
		[Description("文件夹id，0为素材中心根目录。若想创建文件夹，请参考：https://ehome.bytedance.net/djt/apiManage/doc/preview/946?doc=true")]
		[NotNull]
		public string FolderId { get; set; }

		[JsonPropertyName("name")]
		[Description("素材名称，长度限制为50个字符")]
		[NotNull]
		public string Name { get; set; }

		[JsonPropertyName("url")]
		[Description("图片url，必须是公网可访问地址；如果是二进制上传，请使用file_uri字段。url和file_uri二选一，不能同时为空")]
		public string Url { get; set; }

		[JsonPropertyName("file_uri")]
		[Description("二进制文件对应的uri，获取方式请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
		public string FileUri { get; set; }

		[JsonPropertyName("material_type")]
		[Description("素材类型，请传固定值：photo")]
		[NotNull]
		public string MaterialType { get; set; }
	}

	[JsonPropertyName("need_distinct")]
	[Description("是否需要去重（true/false），默认为false。去重是指：存在已经审核通过且内容相同的图片，直接返回已存在的图片地址。")]
	public bool? NeedDistinct { get; set; }
}

[Description("1、一次上传的数量限制50张图片且单个图片最大不能超过10M；,2、接口上传成功，素材中心会对素材进行异步审核，审核时效：非风险图片99%在4s内完成审核，风险图片我们会在24h内审核完成；对于审核失败的素材，素材中心会在一定时间内将其删除；,3、上传时需要关注文件夹属性为0-文件夹和1-图片文件夹才可以上传图片，文件夹属性可通过【/material/getFolderInfo】和【/material/searchFolder】查看。,4、2022年11月-素材接口字段变更公告：https://op.jinritemai.com/docs/notice-docs/5/2668 响应参数ByteUrl字段废弃")]
public class MaterialBatchUploadImageSyncRsp
{
	[JsonPropertyName("success_map")]
	[Description("成功上传的素材，key为参数中的request_id")]
	public Dictionary<string,SuccessMapItem> SuccessMap { get; set; }

	public class SuccessMapItem
	{
		[Description("素材id，素材中心对素材的唯一编号；可MaterialId调用【/material/queryMaterialDetail】接口，当audit_status=3时获取byte_url；")]
		public string MaterialId { get; set; }

		[Description("素材名称，长度限制为50个字符")]
		public string Name { get; set; }

		[Description("文件夹id，“0”表示将素材上传到了素材中心根目录")]
		public string FolderId { get; set; }

		[Description("上传素材时，传入参数url的取值")]
		public string OriginUrl { get; set; }

		[Description("【已下线】新的URL可使用下列方式获取：方式一：监听【店铺使用doudian_material_auditResultForShop】或【供应商使用doudian_material_auditResultForBSCP】audit_status=3时可以使用byte_url；方式二：根据响应参数调用【/material/queryMaterialDetail】接口，当audit_status=3时获取byte_url；")]
		public string ByteUrl { get; set; }

		[Description("审核状态 1-待审核 2-审核中 3-审核通过 4-审核拒绝审核状态 1-待审核 2-审核中 3-审核通过 4-审核拒绝；注意：只有AuditStatus=3时ByteUrl才会返回；")]
		public int AuditStatus { get; set; }

		[Description("是否为新建的素材，false-表示素材已经存在或者request_id重复使用，true-表示新建")]
		public bool IsNew { get; set; }
	}

	[JsonPropertyName("failed_map")]
	[Description("失败的素材，key为参数中的request_id")]
	public Dictionary<string,FailedMapItem> FailedMap { get; set; }

	public class FailedMapItem
	{
		[Description("失败的code")]
		public int ErrCode { get; set; }

		[Description("失败的原因")]
		public string ErrMsg { get; set; }
	}
}
