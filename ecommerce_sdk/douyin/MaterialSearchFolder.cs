namespace ecommerce.sdk.douyin;

[Description("搜索文件夹，（1）不会返回已经删除的文件夹，（2）如果没有任何搜索条件，即：除page_num、page_size、order_type之外的字段都为空，会返【查询失败，未上传任何查询参数】错误。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","文件夹ID无效或文件夹已被彻底删除","isv.parameter-invalid:20001","文件夹不存在的原因有：（1）主从延迟导致；（2）已被删除")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10004","系统异常，请稍后重试")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10006","系统异常，请稍后重试")]
public class MaterialSearchFolderReq : IDouyinReq<MaterialSearchFolderRsp>
{

	public string GetMethod() { return "material.searchFolder"; }

	public string GetUrl() { return "/material/searchFolder"; }

	[JsonPropertyName("order_by")]
	[Description("排序方式 0-创建时间倒序 1-创建时间正序 2-修改时间倒序 3-修改时间正序 4-文件夹名倒序 5-文件夹名正序")]
	[NotNull]
	public int? OrderBy { get; set; }

	[JsonPropertyName("page_num")]
	[Description("分页的页数，从1开始")]
	[NotNull]
	public int? PageNum { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页返回的数量。最大为100，默认为50")]
	[NotNull]
	public int? PageSize { get; set; }

	[JsonPropertyName("name")]
	[Description("需要搜索的文件名片段")]
	public string Name { get; set; }

	[JsonPropertyName("folder_id")]
	[Description("文件夹id")]
	public string FolderId { get; set; }

	[JsonPropertyName("create_time_start")]
	[Description("创建时间最小值，包含这一秒")]
	public string CreateTimeStart { get; set; }

	[JsonPropertyName("create_time_end")]
	[Description("创建时间最大值，包含这一秒")]
	public string CreateTimeEnd { get; set; }

	[JsonPropertyName("parent_folder_id")]
	[Description("父文件夹id")]
	public string ParentFolderId { get; set; }

	[JsonPropertyName("operate_status")]
	[Description("文件夹状态。1-有效 4-在回收站中")]
	public List<int> OperateStatus { get; set; }
}

[Description("搜索文件夹，（1）不会返回已经删除的文件夹，（2）如果没有任何搜索条件，即：除page_num、page_size、order_type之外的字段都为空，会返【查询失败，未上传任何查询参数】错误。")]
public class MaterialSearchFolderRsp
{
	[JsonPropertyName("folder_info_list")]
	[Description("文件夹列表")]
	public List<FolderInfoListItem> FolderInfoList { get; set; }

	public class FolderInfoListItem
	{
		[JsonPropertyName("folder_id")]
		[Description("文件夹id")]
		public string FolderId { get; set; }

		[JsonPropertyName("folder_type")]
		[Description("文件夹类型 0-用户创建 1-默认 2-系统文件夹")]
		public int FolderType { get; set; }

		[JsonPropertyName("name")]
		[Description("文件夹名称")]
		public string Name { get; set; }

		[JsonPropertyName("operate_status")]
		[Description("文件夹状态。1-有效 4-在回收站中")]
		public int OperateStatus { get; set; }

		[JsonPropertyName("parent_folder_id")]
		[Description("父文件夹id")]
		public string ParentFolderId { get; set; }

		[JsonPropertyName("create_time")]
		[Description("文件夹创建时间")]
		public string CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("文件夹最近一次编辑时间")]
		public string UpdateTime { get; set; }

		[JsonPropertyName("delete_time")]
		[Description("文件夹删除时间。当文件夹在回收站时返回，未删除时为")]
		public string DeleteTime { get; set; }

		[JsonPropertyName("folder_attr")]
		[Description("文件夹属性，0-文件夹（不限素材类型），1-图片文件夹（只能上传图片），2-视频文件夹（只能上传视频）")]
		public string FolderAttr { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("符合筛选条件的文件夹数量")]
	public long Total { get; set; }
}
