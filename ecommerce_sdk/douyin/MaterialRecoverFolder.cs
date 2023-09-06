namespace ecommerce.sdk.douyin;

[Description("从回收站恢复文件夹。按照传入的顺序串行执行。,恢复时默认恢复到删除前的父文件夹中。若删除前的父文件夹已经被删除，则恢复到根目录下。")]
public class MaterialRecoverFolderReq : IDouyinReq<MaterialRecoverFolderRsp>
{

	public string GetMethod() { return "material.recoverFolder"; }

	public string GetUrl() { return "/material/recoverFolder"; }

	[JsonPropertyName("folder_ids")]
	[Description("需要恢复的文件夹的id列表，不能操作系统文件夹（0：根目录 -1：回收站）。批量操作每次最多20个。")]
	public List<string> FolderIds { get; set; }
}

[Description("从回收站恢复文件夹。按照传入的顺序串行执行。,恢复时默认恢复到删除前的父文件夹中。若删除前的父文件夹已经被删除，则恢复到根目录下。")]
public class MaterialRecoverFolderRsp
{
	[JsonPropertyName("success_ids")]
	[Description("操作成功的文件夹列表")]
	public List<string> SuccessIds { get; set; }

	[JsonPropertyName("failed_map")]
	[Description("操作失败的文件夹及失败的详情")]
	public Dictionary<long,FailedMapItem> FailedMap { get; set; }

	public class FailedMapItem
	{
		[JsonPropertyName("code")]
		[Description("操作失败的错误码")]
		public int Code { get; set; }

		[JsonPropertyName("msg")]
		[Description("操作失败的原因")]
		public string Msg { get; set; }
	}
}
