namespace ecommerce.sdk.douyin;

[Description("设置门店自动接单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","店铺ID不能为空","isv.missing-parameter:40011","请确认店铺ID参数格式正确")]
[DouyinRetCode(40002,"缺少必选参数","门店ID不能为空","isv.missing-parameter:40012","请确认门店ID参数格式正确")]
[DouyinRetCode(50002,"业务处理失败","请输入正确的操作信息","isv.business-failed:40100","请输入正确的操作信息")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:20201","系统繁忙，请稍后重试")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:20112","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","store_id不存在/错误，超市小时达订单发货需传入订单对应的门店ID","isv.business-failed:50114","store_id不存在/错误，超市小时达订单发货需传入订单对应的门店ID")]
[DouyinRetCode(50002,"业务处理失败","未开通平台运力服务","isv.business-failed:50111","未开通平台运力服务")]
public class SupermSetStoreAutoAcceptReq : IDouyinReq<SupermSetStoreAutoAcceptRsp>
{

	public string GetMethod() { return "superm.setStoreAutoAccept"; }

	public string GetUrl() { return "/superm/setStoreAutoAccept"; }

	[JsonPropertyName("store_id")]
	[Description("门店id")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("op_type")]
	[Description("设置自动接单状态；open 开启 close  关闭")]
	[NotNull]
	public string OpType { get; set; }
}

[Description("设置门店自动接单")]
public class SupermSetStoreAutoAcceptRsp
{
}
