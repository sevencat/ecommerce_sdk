namespace ecommerce.sdk.douyin;

[Description("回收站的素材依然占用用户的存储空间，除非从回收站中彻底删除")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","素材ID无效或状态错误","isv.parameter-invalid:20001","素材不存在，原因有：已被删除或主从延迟导致素材不存在")]
[DouyinRetCode(40004,"非法的参数","数据可能已被修改，请刷新后重新提交","isv.parameter-invalid:22004","重新选择参数，再重试")]
public class MaterialMoveMaterialToRecycleBinReq : IDouyinReq<MaterialMoveMaterialToRecycleBinRsp>
{

	public string GetMethod() { return "material.moveMaterialToRecycleBin"; }

	public string GetUrl() { return "/material/moveMaterialToRecycleBin"; }

	[JsonPropertyName("material_ids")]
	[Description("素材id列表，（1）数量不得超过100；（2）同一级目录下的素材")]
	[NotNull]
	public List<string> MaterialIds { get; set; }
}

[Description("回收站的素材依然占用用户的存储空间，除非从回收站中彻底删除")]
public class MaterialMoveMaterialToRecycleBinRsp
{
	[JsonPropertyName("success_ids")]
	[Description("成功的素材id列表")]
	public List<string> SuccessIds { get; set; }

	[JsonPropertyName("failed_map")]
	[Description("失败素材列表")]
	public Dictionary<string,FailedMapItem> FailedMap { get; set; }

	public class FailedMapItem
	{
		[JsonPropertyName("code")]
		[Description("错误码")]
		public int Code { get; set; }

		[JsonPropertyName("msg")]
		[Description("错误原因")]
		public string Msg { get; set; }
	}
}
