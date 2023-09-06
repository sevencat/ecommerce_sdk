namespace ecommerce.sdk.douyin;

[Description("商家处理完充值请求后，异步回调告知平台充值结果")]
public class TopupResultReq : IDouyinReq<TopupResultRsp>
{

	public string GetMethod() { return "topup.result"; }

	public string GetUrl() { return "/topup/result"; }

	[JsonPropertyName("trade_order_no")]
	[Description("订单号")]
	[NotNull]
	public string TradeOrderNo { get; set; }

	[JsonPropertyName("topup_biz")]
	[Description("充值业务")]
	[NotNull]
	public string TopupBiz { get; set; }

	[JsonPropertyName("seller_order_no")]
	[Description("商家充值单号")]
	[NotNull]
	public string SellerOrderNo { get; set; }

	[JsonPropertyName("seller_order_status")]
	[Description("充值结果")]
	[NotNull]
	public string SellerOrderStatus { get; set; }

	[JsonPropertyName("err_code")]
	[Description("错误码")]
	public string ErrCode { get; set; }

	[JsonPropertyName("err_desc")]
	[Description("错误信息")]
	public string ErrDesc { get; set; }
}

[Description("商家处理完充值请求后，异步回调告知平台充值结果")]
public class TopupResultRsp
{
	[JsonPropertyName("trade_order_no")]
	[Description("平台订单号")]
	public string TradeOrderNo { get; set; }

	[JsonPropertyName("topup_biz")]
	[Description("充值业务")]
	public string TopupBiz { get; set; }

	[JsonPropertyName("result")]
	[Description("平台接口充值结果失败")]
	public string Result { get; set; }

	[JsonPropertyName("seller_order_no")]
	[Description("商家充值单号")]
	public string SellerOrderNo { get; set; }

	[JsonPropertyName("err_code")]
	[Description("错误码")]
	public string ErrCode { get; set; }

	[JsonPropertyName("err_desc")]
	[Description("错误信息")]
	public string ErrDesc { get; set; }
}
