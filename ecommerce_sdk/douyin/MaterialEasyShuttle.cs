namespace ecommerce.sdk.douyin;

[Description("批量删除或移动到回收站该文件夹下的子文件夹和素材，或只操作素材,规则如下：,1. 移动到回收站后，可执行恢复。文件夹下的素材仍占用空间,2. 恢复时默认恢复到移动到回收站前的父文件夹下。若父文件夹也在回收站中或被彻底删除，则恢复到根目录下,3. 彻底删除的素材不占用用户空间，不可恢复")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:20001","修改参数")]
[DouyinRetCode(20000,"系统错误","系统内部错误","isp.service-error:10007","重试")]
[DouyinRetCode(20000,"系统错误","系统内部错误","isp.service-error:10004","重试")]
[DouyinRetCode(20000,"系统错误","系统内部错误","isp.service-error:10003","重试")]
public class MaterialEasyShuttleReq : IDouyinReq<MaterialEasyShuttleRsp>
{

	public string GetMethod() { return "material.easyShuttle"; }

	public string GetUrl() { return "/material/easyShuttle"; }

	[JsonPropertyName("folder_id_list")]
	[Description("文件夹ID列表，对该文件夹下的文件夹或素材进行操作；0:开放平台；1:图片根目录；2:视频根目录；-1:回收站")]
	[NotNull]
	public List<string> FolderIdList { get; set; }

	[JsonPropertyName("operate_type")]
	[Description("操作类型：移到回收站：to_recycle，彻底删除：delete_forever")]
	[NotNull]
	public string OperateType { get; set; }

	[JsonPropertyName("material_type_list")]
	[Description("操作的素材类型")]
	[NotNull]
	public List<string> MaterialTypeList { get; set; }

	[JsonPropertyName("only_material")]
	[Description("是否只操作素材")]
	public bool? OnlyMaterial { get; set; }

	[JsonPropertyName("create_time_end")]
	[Description("所操作的素材或文件夹的创建时间在该时间点之前")]
	public string CreateTimeEnd { get; set; }
}

[Description("批量删除或移动到回收站该文件夹下的子文件夹和素材，或只操作素材,规则如下：,1. 移动到回收站后，可执行恢复。文件夹下的素材仍占用空间,2. 恢复时默认恢复到移动到回收站前的父文件夹下。若父文件夹也在回收站中或被彻底删除，则恢复到根目录下,3. 彻底删除的素材不占用用户空间，不可恢复")]
public class MaterialEasyShuttleRsp
{
}
