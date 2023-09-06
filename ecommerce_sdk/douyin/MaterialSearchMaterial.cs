namespace ecommerce.sdk.douyin;

[Description("1、不会返回已经删除的素材；,2、请至少传入一个入参，如果没有任何搜索条件，即：除page_num、page_size、order_type之外的字段都为空，会返【查询失败，未上传任何查询参数】错误。,3、2022年11月-素材接口字段变更公告：https://op.jinritemai.com/docs/notice-docs/5/2668 响应参数ByteUrl字段废弃；当audit_status=3时才会返回byte_url；视频请使用vid字段")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","文件夹ID错误，请输入正确的文件夹ID","isv.parameter-invalid:20001","文件夹id不正确")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10004","系统异常，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:10003","系统异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","查询数量超出限制，请通过筛选素材名称/状态/日期等缩小范围","isv.parameter-invalid:31002","查询数量超出限制，请通过筛选素材名称/状态/日期等缩小范围")]
[DouyinRetCode(50002,"业务处理失败","系统异常，请稍后重试","isv.business-failed:10006","系统异常，请稍后重试")]
public class MaterialSearchMaterialReq : IDouyinReq<MaterialSearchMaterialRsp>
{

	public string GetMethod() { return "material.searchMaterial"; }

	public string GetUrl() { return "/material/searchMaterial"; }

	[JsonPropertyName("material_id")]
	[Description("素材id；可使用【/material/batchUploadImageSync】【/material/uploadImageSync】【/material/searchMaterial  】接口获取")]
	public string MaterialId { get; set; }

	[JsonPropertyName("material_name")]
	[Description("文件名称，支持模糊匹配")]
	public string MaterialName { get; set; }

	[JsonPropertyName("material_type")]
	[Description("素材类型，空-不限； photo-图片；video-视频；")]
	public List<string> MaterialType { get; set; }

	[JsonPropertyName("operate_status")]
	[Description("素材状态，0-待下载；1-有效；4-回收站中；")]
	public List<int> OperateStatus { get; set; }

	[JsonPropertyName("audit_status")]
	[Description("审核状态，1-待审核；2-审核中；3-通过 ；4-拒绝；注意：只有AuditStatus=3时ByteUrl才会返回；")]
	public List<int> AuditStatus { get; set; }

	[JsonPropertyName("create_time_start")]
	[Description("搜索创建开始时间，格式：yyyy-MM-dd HH:mm:ss")]
	public string CreateTimeStart { get; set; }

	[JsonPropertyName("create_time_end")]
	[Description("搜索创建结束时间，格式：yyyy-MM-dd HH:mm:ss")]
	public string CreateTimeEnd { get; set; }

	[JsonPropertyName("folder_id")]
	[Description("文件夹id，0-素材中心； -1-回收站；")]
	public string FolderId { get; set; }

	[JsonPropertyName("material_id_list")]
	[Description("素材id列表")]
	public List<string> MaterialIdList { get; set; }

	[JsonPropertyName("page_num")]
	[Description("第几页，1，2，……，默认值：1")]
	public int? PageNum { get; set; }

	[JsonPropertyName("page_size")]
	[Description("页大小，1，2，……，100，默认值：50")]
	public int? PageSize { get; set; }

	[JsonPropertyName("order_type")]
	[Description("排序方式，0-按照创建时间倒序 ；1-按照创建时间升序；6-按照素材大小降序；7-按照素材大小升序；")]
	public int? OrderType { get; set; }
}

[Description("1、不会返回已经删除的素材；,2、请至少传入一个入参，如果没有任何搜索条件，即：除page_num、page_size、order_type之外的字段都为空，会返【查询失败，未上传任何查询参数】错误。,3、2022年11月-素材接口字段变更公告：https://op.jinritemai.com/docs/notice-docs/5/2668 响应参数ByteUrl字段废弃；当audit_status=3时才会返回byte_url；视频请使用vid字段")]
public class MaterialSearchMaterialRsp
{
	[JsonPropertyName("material_info_list")]
	[Description("素材列表信息")]
	public List<MaterialInfoListItem> MaterialInfoList { get; set; }

	public class MaterialInfoListItem
	{
		[JsonPropertyName("material_id")]
		[Description("素材id；可使用【/material/batchUploadImageSync】【/material/uploadImageSync】【/material/searchMaterial  】接口获取")]
		public string MaterialId { get; set; }

		[JsonPropertyName("folder_id")]
		[Description("父文件夹id")]
		public string FolderId { get; set; }

		[JsonPropertyName("origin_url")]
		[Description("开发者创建素材时传入的公网可访问url")]
		public string OriginUrl { get; set; }

		[JsonPropertyName("byte_url")]
		[Description("图片url；视频请使用vid；")]
		public string ByteUrl { get; set; }

		[JsonPropertyName("material_name")]
		[Description("素材名称")]
		public string MaterialName { get; set; }

		[JsonPropertyName("material_type")]
		[Description("素材类型，photo-图片；video-视频；")]
		public string MaterialType { get; set; }

		[JsonPropertyName("operate_status")]
		[Description("素材状态，0-待下载；1-有效；4-回收站中；6-已删除；")]
		public int OperateStatus { get; set; }

		[JsonPropertyName("audit_status")]
		[Description("审核状态；1-待审核；2-审核中；3-通过 4-拒绝；注意：只有audit_status =3时才会返回byte_url；")]
		public int AuditStatus { get; set; }

		[JsonPropertyName("audit_reject_desc")]
		[Description("审核失败的原因")]
		public string AuditRejectDesc { get; set; }

		[JsonPropertyName("size")]
		[Description("文件大小，单位KB")]
		public long Size { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建素材的时间，格式：yyyy-MM-dd HH:mm:ss")]
		public string CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("最近一次更新素材的时间，格式：yyyy-MM-dd HH:mm:ss")]
		public string UpdateTime { get; set; }

		[JsonPropertyName("delete_time")]
		[Description("移动到回收站的时间，格式：yyyy-MM-dd HH:mm:ss")]
		public string DeleteTime { get; set; }

		[JsonPropertyName("photoInfo")]
		[Description("图片信息")]
		public PhotoInfoItem PhotoInfo { get; set; }

		public class PhotoInfoItem
		{
			[JsonPropertyName("height")]
			[Description("图片高度，单位px")]
			public int Height { get; set; }

			[JsonPropertyName("width")]
			[Description("图片宽度，单位px")]
			public int Width { get; set; }

			[JsonPropertyName("format")]
			[Description("图片格式")]
			public string Format { get; set; }
		}

		[JsonPropertyName("videoInfo")]
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

			[JsonPropertyName("video_cover_url")]
			[Description("视频封面地址")]
			public string VideoCoverUrl { get; set; }

			[JsonPropertyName("height")]
			[Description("视频高度，单位px")]
			public int Height { get; set; }

			[JsonPropertyName("width")]
			[Description("视频宽度，单位px")]
			public int Width { get; set; }

			[JsonPropertyName("size")]
			[Description("视频大小，单位B")]
			public long Size { get; set; }
		}
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
