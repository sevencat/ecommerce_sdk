namespace ecommerce.sdk.douyin;

[Description("通话录音url回传接口；")]
public class LogisticsVirtualServicePushCallRecordUrlReq : IDouyinReq<LogisticsVirtualServicePushCallRecordUrlRsp>
{

	public string GetMethod() { return "logistics.virtualServicePushCallRecordUrl"; }

	public string GetUrl() { return "/logistics/virtualServicePushCallRecordUrl"; }

	[JsonPropertyName("service_code")]
	[Description("供应商唯一标识；需联系群内抖店虚拟号研发配置生成；")]
	[NotNull]
	public string ServiceCode { get; set; }

	[JsonPropertyName("call_id")]
	[Description("供应商通话id，由供应商自定义，需要保持唯一，标识该次通话，幂等；")]
	[NotNull]
	public string CallId { get; set; }

	[JsonPropertyName("record_url")]
	[Description("供应商通话录音文件url，公网可访问")]
	[NotNull]
	public string RecordUrl { get; set; }
}

[Description("通话录音url回传接口；")]
public class LogisticsVirtualServicePushCallRecordUrlRsp
{
	[JsonPropertyName("success")]
	[Description("是否成功")]
	public bool Success { get; set; }
}
