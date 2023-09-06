namespace ecommerce.sdk.douyin;

[Description("彻底删除的素材不占用用户空间，不可恢复")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10004","系统异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","素材ID无效或状态错误","isv.parameter-invalid:20001","素材不存在，原因有：已被删除或主从延迟导致素材不存在")]
[DouyinRetCode(40004,"非法的参数","数据可能已被修改，请刷新后重新提交","isv.parameter-invalid:22004","有并发请求，修改参数重新请求")]
[DouyinRetCode(40004,"非法的参数","请求已生效，请勿重复请求","isv.parameter-invalid:31001","并发请求，不要重试")]
public class MaterialDeleteMaterialReq : IDouyinReq<MaterialDeleteMaterialRsp>
{

	public string GetMethod() { return "material.deleteMaterial"; }

	public string GetUrl() { return "/material/deleteMaterial"; }

	[JsonPropertyName("material_ids")]
	[Description("要删除的素材id列表，最大不得超过100个，只支持删除同一级目录下的素材")]
	[NotNull]
	public List<string> MaterialIds { get; set; }
}

[Description("彻底删除的素材不占用用户空间，不可恢复")]
public class MaterialDeleteMaterialRsp
{
	[JsonPropertyName("success_ids")]
	[Description("操作成功的素材id")]
	public List<string> SuccessIds { get; set; }

	[JsonPropertyName("failed_map")]
	[Description("操作失败的素材id和原因")]
	public Dictionary<string,FailedMapItem> FailedMap { get; set; }

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
