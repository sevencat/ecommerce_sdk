namespace ecommerce.sdk.douyin;

[Description("将文件夹及该文件夹包含的子文件夹和素材移动到回收站。,规则如下：,1. 移动到回收站后，可执行恢复。文件夹下的素材仍占用空间,2. 恢复时默认恢复到移动到回收站前的父文件夹下。若父文件夹也在回收站中或被彻底删除，则恢复到根目录下")]
public class MaterialMoveFolderToRecycleBinReq : IDouyinReq<MaterialMoveFolderToRecycleBinRsp>
{

	public string GetMethod() { return "material.moveFolderToRecycleBin"; }

	public string GetUrl() { return "/material/moveFolderToRecycleBin"; }

	[JsonPropertyName("folder_ids")]
	[Description("移动到回收站的文件夹id列表")]
	[NotNull]
	public List<string> FolderIds { get; set; }
}

[Description("将文件夹及该文件夹包含的子文件夹和素材移动到回收站。,规则如下：,1. 移动到回收站后，可执行恢复。文件夹下的素材仍占用空间,2. 恢复时默认恢复到移动到回收站前的父文件夹下。若父文件夹也在回收站中或被彻底删除，则恢复到根目录下")]
public class MaterialMoveFolderToRecycleBinRsp
{
	[JsonPropertyName("success_ids")]
	[Description("操作成功的id list")]
	public List<string> SuccessIds { get; set; }

	[JsonPropertyName("failed_map")]
	[Description("操作失败的id map")]
	public Dictionary<long,FailedMapItem> FailedMap { get; set; }

	public class FailedMapItem
	{
		[JsonPropertyName("code")]
		[Description("失败code")]
		public int Code { get; set; }

		[JsonPropertyName("msg")]
		[Description("失败原因")]
		public string Msg { get; set; }
	}
}
