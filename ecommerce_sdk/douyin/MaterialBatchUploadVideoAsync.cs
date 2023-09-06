namespace ecommerce.sdk.douyin;

[Description("1. 一次上传视频的数量限制50个；,2. 每个视频大小限200M；,3. 接口同步接受上传视频的请求，异步处理：视频的下载、格式校验、审核等过程；,4. 视频的审核时间根据素材中心素材数量而定，大部分视频在1分钟内能审核完，小部分视频审核时间会达到天级别，请耐心等待,5. 审核拒绝的视频将在15日内被定期清理，请慎用。,6.上传时需要关注文件夹属性，只有0（文件夹）和2（视频文件夹）才可以上传视频。文件夹属性可通过【/material/getFolderInfo】和【/material/searchFolder】查看。,其他问题请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","参数错误","isp.service-error:20001","检查参数")]
public class MaterialBatchUploadVideoAsyncReq : IDouyinReq<MaterialBatchUploadVideoAsyncRsp>
{

	public string GetMethod() { return "material.batchUploadVideoAsync"; }

	public string GetUrl() { return "/material/batchUploadVideoAsync"; }

	[JsonPropertyName("materials")]
	[Description("素材信息")]
	[NotNull]
	public List<MaterialsItem> Materials { get; set; }

	public class MaterialsItem
	{
		[JsonPropertyName("request_id")]
		[Description("该参数仅有2个作用：（1）一次请求中素材的唯一标示；（2）接口防并发，规则是：不同请求所有request_id排序之后拼接起来，若相同视为同一次请求")]
		[NotNull]
		public string RequestId { get; set; }

		[JsonPropertyName("folder_id")]
		[Description("文件夹id，“0”为素材中心根目录。若想创建文件夹，请参考：https://ehome.bytedance.net/djt/apiManage/doc/preview/946?doc=true")]
		[NotNull]
		public string FolderId { get; set; }

		[JsonPropertyName("name")]
		[Description("素材名称，长度限制为50个字符，最好带上后缀")]
		[NotNull]
		public string Name { get; set; }

		[JsonPropertyName("url")]
		[Description("视频url。如果是二进制上传，请使用file_uri字段。url和file_uri二选一，不能同时为空")]
		public string Url { get; set; }

		[JsonPropertyName("file_uri")]
		[Description("二进制文件对应的uri，获取方式请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
		public object FileUri { get; set; }

		[JsonPropertyName("material_type")]
		[Description("素材类型，请传固定值：video")]
		[NotNull]
		public string MaterialType { get; set; }
	}
}

[Description("1. 一次上传视频的数量限制50个；,2. 每个视频大小限200M；,3. 接口同步接受上传视频的请求，异步处理：视频的下载、格式校验、审核等过程；,4. 视频的审核时间根据素材中心素材数量而定，大部分视频在1分钟内能审核完，小部分视频审核时间会达到天级别，请耐心等待,5. 审核拒绝的视频将在15日内被定期清理，请慎用。,6.上传时需要关注文件夹属性，只有0（文件夹）和2（视频文件夹）才可以上传视频。文件夹属性可通过【/material/getFolderInfo】和【/material/searchFolder】查看。,其他问题请参考：https://op.jinritemai.com/docs/guide-docs/171/1719")]
public class MaterialBatchUploadVideoAsyncRsp
{
	[JsonPropertyName("success_map")]
	[Description("成功上传的素材，key为参数中的request_id")]
	public Dictionary<string,SuccessMapItem> SuccessMap { get; set; }

	public class SuccessMapItem
	{
		[Description("素材id，素材中心对素材的唯一编号")]
		public string MaterialId { get; set; }

		[Description("素材名称，长度限制为50个字符")]
		public string Name { get; set; }

		[Description("文件夹id，“0”表示将素材上传到了素材中心根目录")]
		public string FolderId { get; set; }

		[Description("上传素材时，传入参数url的取值")]
		public string OriginUrl { get; set; }

		[Description("审核状态 0-下载中 1-待审核 2-审核中 3-审核通过 4-审核拒绝")]
		public int AuditStatus { get; set; }

		[Description("是否为新建的素材，true-表示新建")]
		public bool IsNew { get; set; }
	}

	[JsonPropertyName("failed_map")]
	[Description("失败的素材，key为参数中的request_id")]
	public Dictionary<string,FailedMapItem> FailedMap { get; set; }

	public class FailedMapItem
	{
		[Description("错误码")]
		public int ErrCode { get; set; }

		[Description("错误描述")]
		public string ErrMsg { get; set; }
	}
}
