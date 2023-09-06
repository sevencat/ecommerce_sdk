namespace ecommerce.sdk.douyin;

[Description("1、 已经被删除的素材，会返回空；,2、只支持查看本店铺的素材,3、2022年11月-素材接口字段变更公告：https://op.jinritemai.com/docs/notice-docs/5/2668 响应参数ByteUrl字段废弃；当audit_status=3时才会返回byte_url；视频请使用vid字段；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","素材不存在或已被删除","isv.parameter-invalid:22002","素材不存在或已被删除")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:20001","参数错误")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:10004","稍后重试")]
public class MaterialQueryMaterialDetailReq : IDouyinReq<MaterialQueryMaterialDetailRsp>
{

	public string GetMethod() { return "material.queryMaterialDetail"; }

	public string GetUrl() { return "/material/queryMaterialDetail"; }

	[JsonPropertyName("material_id")]
	[Description("素材id；可使用【/material/batchUploadImageSync】【/material/uploadImageSync】【/material/searchMaterial  】接口获取")]
	[NotNull]
	public string MaterialId { get; set; }
}

[Description("1、 已经被删除的素材，会返回空；,2、只支持查看本店铺的素材,3、2022年11月-素材接口字段变更公告：https://op.jinritemai.com/docs/notice-docs/5/2668 响应参数ByteUrl字段废弃；当audit_status=3时才会返回byte_url；视频请使用vid字段；")]
public class MaterialQueryMaterialDetailRsp
{
	[JsonPropertyName("material_info")]
	[Description("素材详情")]
	public MaterialInfoItem MaterialInfo { get; set; }

	public class MaterialInfoItem
	{
		[JsonPropertyName("material_id")]
		[Description("素材id；可使用【/material/batchUploadImageSync】【/material/uploadImageSync】【/material/searchMaterial  】接口获取")]
		public string MaterialId { get; set; }

		[JsonPropertyName("folder_id")]
		[Description("文件夹id")]
		public string FolderId { get; set; }

		[JsonPropertyName("origin_url")]
		[Description("开发者上传时传入的公网可访问地址")]
		public string OriginUrl { get; set; }

		[JsonPropertyName("byte_url")]
		[Description("图片url；当audit_status=3时获取byte_url；有值返回；")]
		public string ByteUrl { get; set; }

		[JsonPropertyName("materil_name")]
		[Description("素材名称")]
		public string MaterilName { get; set; }

		[JsonPropertyName("material_type")]
		[Description("素材类型，photo-图片；video-视频；")]
		public string MaterialType { get; set; }

		[JsonPropertyName("operate_status")]
		[Description("素材状态，0-待下载；1-有效； 4-在回收站中；")]
		public int OperateStatus { get; set; }

		[JsonPropertyName("audit_status")]
		[Description("审核状态，1-待审核 2-审核中 3-通过 4-拒绝；注意：只有AuditStatus=3时ByteUrl才会返回；")]
		public int AuditStatus { get; set; }

		[JsonPropertyName("audit_reject_desc")]
		[Description("审核失败的原因")]
		public string AuditRejectDesc { get; set; }

		[JsonPropertyName("size")]
		[Description("大小，单位为byte")]
		public long Size { get; set; }

		[JsonPropertyName("photo_info")]
		[Description("图片信息")]
		public PhotoInfoItem PhotoInfo { get; set; }

		public class PhotoInfoItem
		{
			[JsonPropertyName("height")]
			[Description("图片高度")]
			public int Height { get; set; }

			[JsonPropertyName("width")]
			[Description("图片宽度")]
			public int Width { get; set; }

			[JsonPropertyName("format")]
			[Description("图片格式")]
			public string Format { get; set; }
		}

		[JsonPropertyName("video_info")]
		[Description("视频信息")]
		public VideoInfoItem VideoInfo { get; set; }

		public class VideoInfoItem
		{
			[JsonPropertyName("format")]
			[Description("视频格式")]
			public string Format { get; set; }

			[JsonPropertyName("duration")]
			[Description("视频时长，单位秒")]
			public decimal Duration { get; set; }

			[JsonPropertyName("vid")]
			[Description("vid，用于获取视频播放地址，接口文档见：https://op.jinritemai.com/docs/api-docs/69/2164")]
			public string Vid { get; set; }

			[JsonPropertyName("height")]
			[Description("视频高度")]
			public int Height { get; set; }

			[JsonPropertyName("width")]
			[Description("视频宽度")]
			public int Width { get; set; }

			[JsonPropertyName("video_cover_url")]
			[Description("视频封面地址")]
			public string VideoCoverUrl { get; set; }
		}

		[JsonPropertyName("create_time")]
		[Description("素材创建时间")]
		public string CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("素材最近一次修改时间")]
		public string UpdateTime { get; set; }

		[JsonPropertyName("delete_time")]
		[Description("素材移动到回收站的时间，只有在回收站中，该字段才有意义")]
		public string DeleteTime { get; set; }
	}
}
