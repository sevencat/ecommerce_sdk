namespace ecommerce.sdk.douyin;

[Description("删除电子围栏")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","围栏id不存在","isv.parameter-invalid:2","修改参数")]
[DouyinRetCode(20000,"系统错误","删除围栏失败","isp.service-error:9999","重试")]
public class WarehouseDelFenceReq : IDouyinReq<WarehouseDelFenceRsp>
{

	public string GetMethod() { return "warehouse.delFence"; }

	public string GetUrl() { return "/warehouse/delFence"; }

	[JsonPropertyName("fence_id")]
	[Description("内部围栏id(和外部2选1，如果传了，则优先使用这个)")]
	public long? FenceId { get; set; }

	[JsonPropertyName("out_fence_id")]
	[Description("外部围栏id")]
	public string OutFenceId { get; set; }
}

[Description("删除电子围栏")]
public class WarehouseDelFenceRsp
{
}
