namespace ecommerce.sdk.douyin;

[Description("1、商家在抖店后台售后小助手配置取消发货自动退策略；,2、当用户发起退款申请，且商家判断符合仅退款的场景时，可以调用取消发货接口同步平台取消发货；,3、命中策略后该售后单自动执行退款操作；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","序列化失败，可能为入参问题，请检查。","isv.business-failed:11004","检查后重试")]
[DouyinRetCode(20000,"系统错误","参数错误","isp.service-error:10002","通常为不应该发生的系统错误，请检查售后单状态，谨慎重试")]
[DouyinRetCode(50002,"业务处理失败","参数错误","isv.business-failed:11000","请检查入参")]
[DouyinRetCode(50002,"业务处理失败","系统错误","isv.business-failed:10000","可能为系统处理超时，请检查后重试")]
[DouyinRetCode(50002,"业务处理失败","店铺未设置或启用售后小助手策略，请店铺通过抖店后台或以下链接进行设置：https://fxg.jinritemai.com/ffa/morder/aftersale/assistant/list","isv.business-failed:11002","检查是否开启小助手策略")]
[DouyinRetCode(50002,"业务处理失败","售后单已被其他自动退款方式命中,售后小助手策略不再执行","isv.business-failed:12001","查看售后单状态")]
[DouyinRetCode(50002,"业务处理失败","该售后单不存在","isv.business-failed:11003","检查入参后重试")]
[DouyinRetCode(50002,"业务处理失败","获取售后小助手策略失败","isv.business-failed:12000","请检查后重试")]
public class AfterSaleCancelSendGoodsSuccessReq : IDouyinReq<AfterSaleCancelSendGoodsSuccessRsp>
{

	public string GetMethod() { return "afterSale.CancelSendGoodsSuccess"; }

	public string GetUrl() { return "/afterSale/CancelSendGoodsSuccess"; }

	[JsonPropertyName("aftersale_id")]
	[Description("售后单ID")]
	[NotNull]
	public string AftersaleId { get; set; }

	[JsonPropertyName("op_time")]
	[Description("unix时间戳，单位为秒")]
	[NotNull]
	public long? OpTime { get; set; }
}

[Description("1、商家在抖店后台售后小助手配置取消发货自动退策略；,2、当用户发起退款申请，且商家判断符合仅退款的场景时，可以调用取消发货接口同步平台取消发货；,3、命中策略后该售后单自动执行退款操作；")]
public class AfterSaleCancelSendGoodsSuccessRsp
{
}
