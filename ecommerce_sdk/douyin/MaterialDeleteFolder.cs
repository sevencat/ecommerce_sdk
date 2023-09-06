namespace ecommerce.sdk.douyin;

[Description("彻底删除文件夹，包括当前文件夹和当前文件夹包含的所有子文件夹和素材。删除后不可查询。,批量操作时，要求入参中的所有文件夹在同一个父文件夹下。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","系统文件夹，不可操作","isv.parameter-invalid:20001","参数错误")]
public class MaterialDeleteFolderReq : IDouyinReq<MaterialDeleteFolderRsp>
{

	public string GetMethod() { return "material.deleteFolder"; }

	public string GetUrl() { return "/material/deleteFolder"; }

	[JsonPropertyName("folder_ids")]
	[Description("文件夹id list，最多不超过20个")]
	public List<string> FolderIds { get; set; }
}

[Description("彻底删除文件夹，包括当前文件夹和当前文件夹包含的所有子文件夹和素材。删除后不可查询。,批量操作时，要求入参中的所有文件夹在同一个父文件夹下。")]
public class MaterialDeleteFolderRsp
{
	[JsonPropertyName("success_ids")]
	[Description("操作成功的文件夹id列表")]
	public List<string> SuccessIds { get; set; }

	[JsonPropertyName("failed_map")]
	[Description("操作失败的的文件夹及错误详情")]
	public Dictionary<string,FailedMapItem> FailedMap { get; set; }

	public class FailedMapItem
	{
		[JsonPropertyName("code")]
		[Description("错误码")]
		public int Code { get; set; }

		[JsonPropertyName("msg")]
		[Description("错误码的描述字段")]
		public string Msg { get; set; }
	}
}
