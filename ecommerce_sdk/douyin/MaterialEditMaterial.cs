namespace ecommerce.sdk.douyin;

[Description("支持编辑素材名称，移动素材到新的文件夹下")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","素材不存在或已被删除","isv.business-failed:20001","素材不存在或已被彻底删除")]
public class MaterialEditMaterialReq : IDouyinReq<MaterialEditMaterialRsp>
{

	public string GetMethod() { return "material.editMaterial"; }

	public string GetUrl() { return "/material/editMaterial"; }

	[JsonPropertyName("material_id")]
	[Description("素材id")]
	[NotNull]
	public string MaterialId { get; set; }

	[JsonPropertyName("material_name")]
	[Description("素材名称，不得超过50个字符")]
	public string MaterialName { get; set; }

	[JsonPropertyName("to_folder_id")]
	[Description("目标文件夹id，0--素材中心")]
	public string ToFolderId { get; set; }
}

[Description("支持编辑素材名称，移动素材到新的文件夹下")]
public class MaterialEditMaterialRsp
{
}
