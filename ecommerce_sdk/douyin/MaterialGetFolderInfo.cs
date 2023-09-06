namespace ecommerce.sdk.douyin;

[Description("1、通过文件夹id，查询文件夹下的文件夹和素材。接口返回所有的子文件夹，分页返回素材。,2、2022年11月-素材接口字段变更公告：https://op.jinritemai.com/docs/notice-docs/5/2668 响应参数ByteUrl字段废弃；当audit_status=3时才会返回byte_url；视频请使用vid字段")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","文件夹ID无效或文件夹已被彻底删除","isv.parameter-invalid:20001","文件夹id不存或已被彻底删除")]
[DouyinRetCode(40004,"非法的参数","查询数量超出限制，请通过筛选素材名称/状态/日期等缩小范围","isv.parameter-invalid:31002","查询数量超出限制，请通过筛选素材名称/状态/日期等缩小范围")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10004","重试")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10006","重试")]
public class MaterialGetFolderInfoReq : IDouyinReq<MaterialGetFolderInfoRsp>
{

	public string GetMethod() { return "material.getFolderInfo"; }

	public string GetUrl() { return "/material/getFolderInfo"; }

	[JsonPropertyName("folder_id")]
	[Description("文件夹id")]
	[NotNull]
	public string FolderId { get; set; }

	[JsonPropertyName("page_num")]
	[Description("分页的页数，从1开始")]
	[NotNull]
	public int? PageNum { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页返回的数量。最大为100，默认为50")]
	[NotNull]
	public int? PageSize { get; set; }
}

[Description("1、通过文件夹id，查询文件夹下的文件夹和素材。接口返回所有的子文件夹，分页返回素材。,2、2022年11月-素材接口字段变更公告：https://op.jinritemai.com/docs/notice-docs/5/2668 响应参数ByteUrl字段废弃；当audit_status=3时才会返回byte_url；视频请使用vid字段")]
public class MaterialGetFolderInfoRsp
{
	[JsonPropertyName("folder_info")]
	[Description("文件夹信息")]
	public FolderInfoItem FolderInfo { get; set; }

	public class FolderInfoItem
	{
		[JsonPropertyName("folder_id")]
		[Description("文件夹id")]
		public string FolderId { get; set; }

		[JsonPropertyName("folder_type")]
		[Description("文件夹类型")]
		public int FolderType { get; set; }

		[JsonPropertyName("folder_name")]
		[Description("文件夹名称")]
		public string FolderName { get; set; }

		[JsonPropertyName("operate_status")]
		[Description("文件夹状态，1-有效 4-在回收站中")]
		public int OperateStatus { get; set; }

		[JsonPropertyName("child_folder")]
		[Description("子文件夹列表")]
		public List<ChildFolderItem> ChildFolder { get; set; }

		public class ChildFolderItem
		{
			[JsonPropertyName("folder_id")]
			[Description("文件夹id")]
			public string FolderId { get; set; }

			[JsonPropertyName("folder_type")]
			[Description("文件夹类型")]
			public int FolderType { get; set; }

			[JsonPropertyName("folder_name")]
			[Description("文件夹名称")]
			public string FolderName { get; set; }

			[JsonPropertyName("operate_status")]
			[Description("文件夹状态，1-有效 4-在回收站中")]
			public int OperateStatus { get; set; }

			[JsonPropertyName("parent_folder_id")]
			[Description("父文件夹id")]
			public string ParentFolderId { get; set; }

			[JsonPropertyName("create_time")]
			[Description("文件夹创建时间")]
			public string CreateTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("文件夹最近一次修改时间")]
			public string UpdateTime { get; set; }

			[JsonPropertyName("delete_time")]
			[Description("文件夹移动到回收站的时间，只有在回收站中，该字段才有意义")]
			public string DeleteTime { get; set; }

			[JsonPropertyName("folder_attr")]
			[Description("文件夹属性，0-文件夹（不限素材类型），1-图片文件夹（只能上传图片），2-视频文件夹（只能上传视频）")]
			public int FolderAttr { get; set; }
		}

		[JsonPropertyName("child_material")]
		[Description("素材列表")]
		public List<ChildMaterialItem> ChildMaterial { get; set; }

		public class ChildMaterialItem
		{
			[JsonPropertyName("material_id")]
			[Description("素材id")]
			public string MaterialId { get; set; }

			[JsonPropertyName("folder_id")]
			[Description("文件夹id")]
			public string FolderId { get; set; }

			[JsonPropertyName("origin_url")]
			[Description("开发者创建素材是传入的公网可访问url")]
			public string OriginUrl { get; set; }

			[JsonPropertyName("byte_url")]
			[Description("图片url，当audit_status=3时才会返回byte_url；视频请使用vid字段；")]
			public string ByteUrl { get; set; }

			[JsonPropertyName("materil_name")]
			[Description("素材名称")]
			public string MaterilName { get; set; }

			[JsonPropertyName("material_type")]
			[Description("素材类型，photo-图片；video-视频；")]
			public string MaterialType { get; set; }

			[JsonPropertyName("operate_status")]
			[Description("状态，0-待下载；1-有效；4-在回收站中；")]
			public int OperateStatus { get; set; }

			[JsonPropertyName("audit_status")]
			[Description("审核状态，1-待审核；2-审核中；3-通过 4-拒绝；注意：只有audit_status =3时byte_url才会返回；")]
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
				[Description("视频时长")]
				public decimal Duration { get; set; }

				[JsonPropertyName("vid")]
				[Description("视频云vid，根据该字段获取视频播放信息等https://op.jinritemai.com/docs/api-docs/69/2164")]
				public string Vid { get; set; }

				[JsonPropertyName("video_cover_url")]
				[Description("视频封面")]
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

		[JsonPropertyName("parent_folder_id")]
		[Description("父文件夹id，0-素材中心根目录")]
		public string ParentFolderId { get; set; }

		[JsonPropertyName("create_time")]
		[Description("文件夹创建时间")]
		public string CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("文件夹最近一次修改时间")]
		public string UpdateTime { get; set; }

		[JsonPropertyName("delete_time")]
		[Description("文件夹移动到回收站的时间，只有在回收站中，该字段才有意义")]
		public string DeleteTime { get; set; }

		[JsonPropertyName("total_child_material_num")]
		[Description("文件夹下素材总数目")]
		public long TotalChildMaterialNum { get; set; }

		[JsonPropertyName("folder_attr")]
		[Description("文件夹属性，0-文件夹（不限素材类型），1-图片文件夹（只能上传图片），2-视频文件夹（只能上传视频）")]
		public int FolderAttr { get; set; }
	}
}
