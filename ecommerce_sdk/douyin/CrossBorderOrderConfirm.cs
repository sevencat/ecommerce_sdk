namespace ecommerce.sdk.douyin;

[Description("服务商接单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","订单状态不支持当前行为，请刷新后重试","isv.business-failed:1005","请检查订单状态")]
[DouyinRetCode(50002,"业务处理失败","推送的物流状态不对，请查证后重试, 当前状态是 跨境履约单创建成功","isv.business-failed:1004","请检查物流状态")]
[DouyinRetCode(50002,"业务处理失败","请求太频繁","isv.business-failed:1002","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","1006:record not found","isv.business-failed:1006","请检查后重试")]
public class CrossBorderOrderConfirmReq : IDouyinReq<CrossBorderOrderConfirmRsp>
{

	public string GetMethod() { return "crossBorder.orderConfirm"; }

	public string GetUrl() { return "/crossBorder/orderConfirm"; }

	[JsonPropertyName("vendor")]
	[Description("字节给供应链服务商定义的编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("order_id")]
	[Description("字节电商平台的交易订单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("status")]
	[Description("接单状态")]
	[NotNull]
	public int? Status { get; set; }

	[JsonPropertyName("occurrence_time")]
	[Description("物流状态的真实发生时间")]
	[NotNull]
	public string OccurrenceTime { get; set; }

	[JsonPropertyName("error_info")]
	[Description("接单失败")]
	public ErrorInfoItem ErrorInfo { get; set; }

	public class ErrorInfoItem
	{
		[JsonPropertyName("error_code")]
		[Description("错误码")]
		public string ErrorCode { get; set; }

		[JsonPropertyName("error_msg")]
		[Description("错误信息")]
		public string ErrorMsg { get; set; }
	}

	[JsonPropertyName("deliver_info")]
	[Description("运单信息")]
	public DeliverInfoItem DeliverInfo { get; set; }

	public class DeliverInfoItem
	{
		[JsonPropertyName("carrier")]
		[Description("快递公司编码")]
		public string Carrier { get; set; }

		[JsonPropertyName("trans_no")]
		[Description("运单号")]
		public string TransNo { get; set; }

		[JsonPropertyName("ship_address")]
		[Description("发货地址")]
		public string ShipAddress { get; set; }

		[JsonPropertyName("waybill")]
		[Description("电子面单url(pdf格式)")]
		public string Waybill { get; set; }

		[JsonPropertyName("product_num")]
		[Description("商品件数")]
		public long? ProductNum { get; set; }

		[JsonPropertyName("mark")]
		[Description("大头笔")]
		public string Mark { get; set; }

		[JsonPropertyName("delivery_name")]
		[Description("发货人姓名")]
		public string DeliveryName { get; set; }

		[JsonPropertyName("delivery_tel")]
		[Description("发货人电话")]
		public string DeliveryTel { get; set; }
	}
}

[Description("服务商接单")]
public class CrossBorderOrderConfirmRsp
{
}
