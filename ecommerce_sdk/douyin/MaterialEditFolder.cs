namespace ecommerce.sdk.douyin;

[Description("支持重命名、移动文件夹位置这两种操作。可以同时进行重命名 和 移动文件夹这两个操作。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","文件夹ID错误，请输入正确的文件夹ID","isv.parameter-invalid:20001","文件夹id不存，检查参数")]
public class MaterialEditFolderReq : IDouyinReq<MaterialEditFolderRsp>
{

	public string GetMethod() { return "material.editFolder"; }

	public string GetUrl() { return "/material/editFolder"; }

	[JsonPropertyName("folder_id")]
	[Description("文件夹id，不能操作系统文件夹（0：根目录 -1：回收站）")]
	[NotNull]
	public string FolderId { get; set; }

	[JsonPropertyName("name")]
	[Description("新的文件夹名称")]
	public string Name { get; set; }

	[JsonPropertyName("to_folder_id")]
	[Description("需要移动到的父文件夹id")]
	public string ToFolderId { get; set; }
}

[Description("支持重命名、移动文件夹位置这两种操作。可以同时进行重命名 和 移动文件夹这两个操作。")]
public class MaterialEditFolderRsp
{
}
