namespace ecommerce.sdk.douyin;

[Description("商家在抖店后台售后小助手配置退货入仓自动退策略；,当用户发起退货退款申请，商家同意且退货商品返回到商家仓内，由商家确认质检无误后入仓；,命中策略后该售后单自动执行退款操作。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","序列化错误","isv.parameter-invalid:11004","通常为入参问题，请检查后重试")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:10002","通常为严重的系统错误问题，请检查并谨慎重试。")]
[DouyinRetCode(50002,"业务处理失败","系统错误，请重试","isv.business-failed:10000","通常为超时，请检查后重试")]
[DouyinRetCode(50002,"业务处理失败","售后单类型与策略限制不符合，未命中此策略","isv.business-failed:12001","检查后重试")]
[DouyinRetCode(50002,"业务处理失败","店铺未设置或启用售后小助手策略，请店铺通过抖店后台或以下链接进行设置：https://fxg.jinritemai.com/ffa/morder/aftersale/assistant/list","isv.business-failed:11002","检查小助手是否开启")]
[DouyinRetCode(50002,"业务处理失败","参数错误","isv.business-failed:11000","通常为入参错误，请检查")]
[DouyinRetCode(50002,"业务处理失败","获取售后小助手策略失败","isv.business-failed:12000","请检查后重试")]
public class AfterSaleReturnGoodsToWareHouseSuccessReq : IDouyinReq<AfterSaleReturnGoodsToWareHouseSuccessRsp>
{

	public string GetMethod() { return "afterSale.returnGoodsToWareHouseSuccess"; }

	public string GetUrl() { return "/afterSale/returnGoodsToWareHouseSuccess"; }

	[JsonPropertyName("aftersale_id")]
	[Description("售后单Id")]
	[NotNull]
	public string AftersaleId { get; set; }

	[JsonPropertyName("op_time")]
	[Description("商家确认退货入仓时间，Unix时间戳，时间为秒")]
	[NotNull]
	public long? OpTime { get; set; }

	[JsonPropertyName("tracking_no")]
	[Description("用户退货物流单号")]
	public string TrackingNo { get; set; }

	[JsonPropertyName("logistics_company_code")]
	[Description("物流公司代号")]
	public string LogisticsCompanyCode { get; set; }
}

[Description("商家在抖店后台售后小助手配置退货入仓自动退策略；,当用户发起退货退款申请，商家同意且退货商品返回到商家仓内，由商家确认质检无误后入仓；,命中策略后该售后单自动执行退款操作。")]
public class AfterSaleReturnGoodsToWareHouseSuccessRsp
{
}
