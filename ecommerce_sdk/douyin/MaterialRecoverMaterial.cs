namespace ecommerce.sdk.douyin;

[Description("（1）一次不得恢复超过20个素材；（2）如果原父目录不存在，会恢复到素材中心")]
public class MaterialRecoverMaterialReq : IDouyinReq<MaterialRecoverMaterialRsp>
{

	public string GetMethod() { return "material.recoverMaterial"; }

	public string GetUrl() { return "/material/recoverMaterial"; }

	[JsonPropertyName("material_ids")]
	[Description("素材id列表")]
	[NotNull]
	public List<string> MaterialIds { get; set; }
}

[Description("（1）一次不得恢复超过20个素材；（2）如果原父目录不存在，会恢复到素材中心")]
public class MaterialRecoverMaterialRsp
{
	[JsonPropertyName("success_ids")]
	[Description("成功操作的素材id列表")]
	public List<string> SuccessIds { get; set; }

	[JsonPropertyName("failed_map")]
	[Description("失败素材列表及失败原因")]
	public Dictionary<string,FailedMapItem> FailedMap { get; set; }

	public class FailedMapItem
	{
		[JsonPropertyName("code")]
		[Description("错误码")]
		public int Code { get; set; }

		[JsonPropertyName("msg")]
		[Description("错误码描述")]
		public string Msg { get; set; }
	}
}
