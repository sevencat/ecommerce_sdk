namespace ecommerce.sdk.douyin;

[Description("查询自动呼叫运力配置")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","店铺ID不能为空","isv.missing-parameter:40011","店铺ID不能为空")]
[DouyinRetCode(40002,"缺少必选参数","门店ID不能为空","isv.missing-parameter:40012","门店ID不能为空")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:20201","系统繁忙，请稍后重试")]
public class SupermGetStoreAutoCallRiderInfoReq : IDouyinReq<SupermGetStoreAutoCallRiderInfoRsp>
{

	public string GetMethod() { return "superm.getStoreAutoCallRiderInfo"; }

	public string GetUrl() { return "/superm/getStoreAutoCallRiderInfo"; }

	[JsonPropertyName("store_id")]
	[Description("商家的门店编号")]
	[NotNull]
	public long? StoreId { get; set; }
}

[Description("查询自动呼叫运力配置")]
public class SupermGetStoreAutoCallRiderInfoRsp
{
	[JsonPropertyName("autocall_info")]
	[Description("自动呼叫设置信息")]
	public AutocallInfoItem AutocallInfo { get; set; }

	public class AutocallInfoItem
	{
		[JsonPropertyName("service_status")]
		[Description("自动呼叫运力设置状态；1：关闭 2：开启")]
		public long ServiceStatus { get; set; }

		[JsonPropertyName("service_type")]
		[Description("自动呼叫运力策略； 0：接单后立即呼叫  1：接单后延迟呼叫")]
		public long ServiceType { get; set; }

		[JsonPropertyName("delay_time")]
		[Description("接单后延时呼叫时间，service_type为1时生效，单位min，范围[1,15]")]
		public long DelayTime { get; set; }
	}
}
