namespace ecommerce.sdk.douyin;

[Description("创建文件夹。,创建文件夹存在如下的限制：,1. 文件夹名称最多20个字符,2. 每个文件夹下最多包含100个子文件夹,3. 文件夹的最大层级为10层,4. 一个父文件夹下的子文件夹不允许重名,5. 累计创建的文件夹数量不能超过10万")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误，请调整参数","isv.parameter-invalid:20001","参数不正确，调整参数")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10004","系统异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","同一父文件夹下，最多有100个子文件夹","isv.parameter-invalid:21001","同一父文件夹下，最多有100个子文件夹")]
[DouyinRetCode(40004,"非法的参数","待创建的文件夹属性和父级文件夹属性不一致","isv.parameter-invalid:21007","图片文件夹只能存文件，视频文件夹只能存视频")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10003","系统异常，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","文件夹层数超出最大限制","isv.business-failed:21002","文件夹层数超出最大限制")]
[DouyinRetCode(50002,"业务处理失败","素材中心尚未初始化，请联系客服或稍后重试","isv.business-failed:30003","素材中心尚未初始化，请联系客服或稍后重试")]
public class MaterialCreateFolderReq : IDouyinReq<MaterialCreateFolderRsp>
{

	public string GetMethod() { return "material.createFolder"; }

	public string GetUrl() { return "/material/createFolder"; }

	[JsonPropertyName("name")]
	[Description("文件夹名称。最多20字符")]
	[NotNull]
	public string Name { get; set; }

	[JsonPropertyName("parent_folder_id")]
	[Description("父文件夹id，根目录为0。不传该参数默认在根目录下创建文件夹")]
	public string ParentFolderId { get; set; }

	[JsonPropertyName("type")]
	[Description("文件夹类型。0-用户自建")]
	[NotNull]
	public int? Type { get; set; }
}

[Description("创建文件夹。,创建文件夹存在如下的限制：,1. 文件夹名称最多20个字符,2. 每个文件夹下最多包含100个子文件夹,3. 文件夹的最大层级为10层,4. 一个父文件夹下的子文件夹不允许重名,5. 累计创建的文件夹数量不能超过10万")]
public class MaterialCreateFolderRsp
{
	[JsonPropertyName("folder_id")]
	[Description("文件夹id，全局唯一")]
	public string FolderId { get; set; }

	[JsonPropertyName("parent_folder_id")]
	[Description("父文件夹id，全局唯一")]
	public string ParentFolderId { get; set; }

	[JsonPropertyName("name")]
	[Description("文件夹名称")]
	public string Name { get; set; }

	[JsonPropertyName("type")]
	[Description("文件夹类型。0-用户自建 1-默认 2-系统文件夹")]
	public int Type { get; set; }

	[JsonPropertyName("is_new")]
	[Description("判断文件夹是否为新创建的；,若父文件夹下存在同名文件夹，创建时返回该同名文件夹id，is_new为false；,若不存在同名文件夹且创建成功，则is_new为true，表示为新创建的文件夹。")]
	public bool IsNew { get; set; }
}
