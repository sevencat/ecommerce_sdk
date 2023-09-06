namespace ecommerce.sdk.douyin;

[Description("订单自动呼叫运力】设置操作")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","店铺ID不能为空","isv.missing-parameter:40011","请确认店铺ID参数格式正确")]
[DouyinRetCode(40002,"缺少必选参数","门店ID不能为空","isv.missing-parameter:40012","请确认门店ID参数格式正确")]
[DouyinRetCode(50002,"业务处理失败","请输入正确的操作信息","isv.business-failed:40100","请输入正确的操作信息")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:20201","系统繁忙，请稍后重试")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:20112","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","store_id不存在/错误，超市小时达订单发货需传入订单对应的门店ID","isv.business-failed:50114","store_id不存在/错误，超市小时达订单发货需传入订单对应的门店ID")]
[DouyinRetCode(50002,"业务处理失败","未开通平台运力服务","isv.business-failed:50111","未开通平台运力服务")]
public class SupermSetStoreAutoCallRiderReq : IDouyinReq<SupermSetStoreAutoCallRiderRsp>
{

	public string GetMethod() { return "superm.setStoreAutoCallRider"; }

	public string GetUrl() { return "/superm/setStoreAutoCallRider"; }

	[JsonPropertyName("store_id")]
	[Description("店铺的门店ID")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("op_type")]
	[Description("自动呼叫运力设置状态；open 开启 close  关闭")]
	[NotNull]
	public string OpType { get; set; }

	[JsonPropertyName("service_type")]
	[Description("自动呼叫运力策略； 0：接单后立即呼叫  1：接单后延迟呼叫")]
	public long? ServiceType { get; set; }

	[JsonPropertyName("delay_time")]
	[Description("接单后延时呼叫时间，service_type为1时生效，单位分钟，范围[1,15] 延迟时间仅支持1-15分钟")]
	public long? DelayTime { get; set; }
}

[Description("订单自动呼叫运力】设置操作")]
public class SupermSetStoreAutoCallRiderRsp
{
}
