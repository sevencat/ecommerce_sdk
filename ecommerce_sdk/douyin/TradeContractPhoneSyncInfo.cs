namespace ecommerce.sdk.douyin;

[Description("提供给外部，用来同步合约机办理结果。")]
public class TradeContractPhoneSyncInfoReq : IDouyinReq<TradeContractPhoneSyncInfoRsp>
{

	public string GetMethod() { return "trade.contractPhone.sync_info"; }

	public string GetUrl() { return "/trade/contractPhone/sync_info"; }

	[JsonPropertyName("shop_order_id")]
	[Description("店铺单id")]
	[NotNull]
	public string ShopOrderId { get; set; }

	[JsonPropertyName("sku_order_id")]
	[Description("sku单id")]
	[NotNull]
	public string SkuOrderId { get; set; }

	[JsonPropertyName("phone_number")]
	[Description("合约手机号码")]
	[NotNull]
	public string PhoneNumber { get; set; }

	[JsonPropertyName("update_time")]
	[Description("发生的时间（单位毫秒）")]
	[NotNull]
	public long? UpdateTime { get; set; }

	[JsonPropertyName("contract_result")]
	[Description("1：合约待办理，2：合约办理中，3：合约办理成功，4：合约办理失败")]
	[NotNull]
	public long? ContractResult { get; set; }

	[JsonPropertyName("remark")]
	[Description("合约办理回传备注")]
	public string Remark { get; set; }
}

[Description("提供给外部，用来同步合约机办理结果。")]
public class TradeContractPhoneSyncInfoRsp
{
	[JsonPropertyName("ret_biz")]
	[Description("返回结构")]
	public RetBizItem RetBiz { get; set; }

	public class RetBizItem
	{
		[JsonPropertyName("ret_code")]
		[Description("0：回传成功，30004：回传异常请重试，30005：订单信息有误，30007：回传参数错误，30009：订单状态不合法")]
		public long RetCode { get; set; }

		[JsonPropertyName("ret_msg")]
		[Description("返回信息")]
		public string RetMsg { get; set; }
	}
}
