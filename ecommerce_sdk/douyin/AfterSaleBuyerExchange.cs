namespace ecommerce.sdk.douyin;

[Description("商家处理换货请求，此接口负责商家处理买家申请换货后的场景。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","此订单状态已经发生变化，请刷新","isv.business-failed:10007","检查售后单状态")]
[DouyinRetCode(50002,"业务处理失败","售后类型无法处理","isv.business-failed:10002","检查售后单状态")]
[DouyinRetCode(20000,"服务不可用","服务器繁忙，请刷新后重试","isp.service-error:10001","检查后重试")]
public class AfterSaleBuyerExchangeReq : IDouyinReq<AfterSaleBuyerExchangeRsp>
{

	public string GetMethod() { return "afterSale.buyerExchange"; }

	public string GetUrl() { return "/afterSale/buyerExchange"; }

	[JsonPropertyName("aftersale_id")]
	[Description("售后ID")]
	[NotNull]
	public long? AftersaleId { get; set; }

	[JsonPropertyName("is_reject")]
	[Description("是否拒绝")]
	[NotNull]
	public bool? IsReject { get; set; }

	[JsonPropertyName("sms_id")]
	[Description("短信模板ID")]
	public long? SmsId { get; set; }

	[JsonPropertyName("comment")]
	[Description("商家留言")]
	public string Comment { get; set; }

	[JsonPropertyName("evidence")]
	[Description("商家凭证")]
	public List<string> Evidence { get; set; }

	[JsonPropertyName("address_id")]
	[Description("商家选择的换货地址")]
	public long? AddressId { get; set; }

	[JsonPropertyName("remark")]
	[Description("商家备注")]
	public string Remark { get; set; }
}

[Description("商家处理换货请求，此接口负责商家处理买家申请换货后的场景。")]
public class AfterSaleBuyerExchangeRsp
{
}
