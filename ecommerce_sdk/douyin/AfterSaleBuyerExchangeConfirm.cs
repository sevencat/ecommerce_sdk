namespace ecommerce.sdk.douyin;

[Description("用户填写换货物流后，商家处理，确认是否收到换货，并二次发货")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","此订单状态已经发生变化，请刷新","isv.parameter-invalid:10007","检查售后单状态")]
[DouyinRetCode(50002,"业务处理失败","参数错误，请修改后重试","isv.business-failed:10002","检查售后单状态")]
[DouyinRetCode(20000,"服务不可用","系统超时，请重试","isp.service-error:10001","检查并重试")]
[DouyinRetCode(50002,"业务处理失败","存在非本店铺订单，该操作被禁止","isv.business-failed:10004","检查参数后重试")]
public class AfterSaleBuyerExchangeConfirmReq : IDouyinReq<AfterSaleBuyerExchangeConfirmRsp>
{

	public string GetMethod() { return "afterSale.buyerExchangeConfirm"; }

	public string GetUrl() { return "/afterSale/buyerExchangeConfirm"; }

	[JsonPropertyName("aftersale_id")]
	[Description("可以从/afterSale/refundProcessDetail接口或者消息监听获取")]
	[NotNull]
	public long? AftersaleId { get; set; }

	[JsonPropertyName("is_reject")]
	[Description("处理方式： false：确认仓库收到退回货货物并二次发货（或直接退款） true：拒绝")]
	[NotNull]
	public bool? IsReject { get; set; }

	[JsonPropertyName("action")]
	[Description("s_reject为false时，必填，用于指定换货操作行为；换货动作： refund_agree ： 同意换货转退款 exchange_agree：同意换货并发货")]
	public string Action { get; set; }

	[JsonPropertyName("comment")]
	[Description("is_reject = true 时需要选择拒绝原因；具体各个可选值对应的拒绝原因见下表")]
	public string Comment { get; set; }

	[JsonPropertyName("evidence")]
	[Description("凭证图片，只能传一张")]
	public List<string> Evidence { get; set; }

	[JsonPropertyName("logistics_code")]
	[Description("is_reject = false时需要上传物流单号")]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("company_code")]
	[Description("is_reject = false时需要上传物流公司编号 ，如圆通为yuantong")]
	public string CompanyCode { get; set; }
}

[Description("用户填写换货物流后，商家处理，确认是否收到换货，并二次发货")]
public class AfterSaleBuyerExchangeConfirmRsp
{
}
