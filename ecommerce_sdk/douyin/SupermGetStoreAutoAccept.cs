namespace ecommerce.sdk.douyin;

[Description("获取自动接单配置")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","店铺ID不能为空","isv.missing-parameter:40011","店铺ID不能为空")]
[DouyinRetCode(40002,"缺少必选参数","门店ID不能为空","isv.missing-parameter:40012","门店ID不能为空")]
[DouyinRetCode(50002,"业务处理失败","请输入正确的操作信息","isv.business-failed:40100","请输入正确的操作信息")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:20201","系统繁忙，请稍后重试")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:20112","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","store_id不存在/错误，超市小时达订单发货需传入订单对应的门店ID","isv.business-failed:50114","store_id不存在/错误，超市小时达订单发货需传入订单对应的门店ID")]
[DouyinRetCode(50002,"业务处理失败","未开通平台运力服务","isv.business-failed:50111","未开通平台运力服务")]
public class SupermGetStoreAutoAcceptReq : IDouyinReq<SupermGetStoreAutoAcceptRsp>
{

	public string GetMethod() { return "superm.getStoreAutoAccept"; }

	public string GetUrl() { return "/superm/getStoreAutoAccept"; }

	[JsonPropertyName("store_id")]
	[Description("门店id")]
	[NotNull]
	public long? StoreId { get; set; }
}

[Description("获取自动接单配置")]
public class SupermGetStoreAutoAcceptRsp
{
	[JsonPropertyName("auto_dispatcher_status")]
	[Description("自动接单状态，1关闭2开启")]
	public long AutoDispatcherStatus { get; set; }
}
