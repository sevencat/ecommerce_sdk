namespace ecommerce.sdk.douyin;

[Description("商家后台，选择筛选条件，然后后台会下载账单数据，下载完后会生成一个download_id ，通过download_id下载文件见/order/downloadToShop接口。如果当天账单数据未完全生成会拦截下载请求。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","账单明细未完全生成，暂不支持下载，避免下载的明细数据不全","isv.business-failed:100027","等5分钟之后重试")]
public class OrderDownloadSettleItemToShopReq : IDouyinReq<OrderDownloadSettleItemToShopRsp>
{

	public string GetMethod() { return "order.downloadSettleItemToShop"; }

	public string GetUrl() { return "/order/downloadSettleItemToShop"; }

	[JsonPropertyName("start_time")]
	[Description("开始时间")]
	[NotNull]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("结束时间")]
	[NotNull]
	public string EndTime { get; set; }

	[JsonPropertyName("time_type")]
	[Description("时间类型 0:结算时间 1：下单时间")]
	[NotNull]
	public string TimeType { get; set; }

	[JsonPropertyName("order_id")]
	[Description("订单ID")]
	public string OrderId { get; set; }

	[JsonPropertyName("bill_id")]
	[Description("字段已作废,勿填")]
	public string BillId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	public string ProductId { get; set; }

	[JsonPropertyName("pay_type")]
	[Description("结算账户 0:全部 1:微信（升级前） 2:微信 3:支付宝 4:合众支付 5:聚合账户")]
	public string PayType { get; set; }

	[JsonPropertyName("flow_type")]
	[Description("业务类型，不传则默认为0 0:全部 1:鲁班广告, 2:值点商城, 3:精选联盟  4:小店自卖")]
	public string FlowType { get; set; }
}

[Description("商家后台，选择筛选条件，然后后台会下载账单数据，下载完后会生成一个download_id ，通过download_id下载文件见/order/downloadToShop接口。如果当天账单数据未完全生成会拦截下载请求。")]
public class OrderDownloadSettleItemToShopRsp
{
	[JsonPropertyName("download_id")]
	[Description("返回的download_id")]
	public string DownloadId { get; set; }

	[JsonPropertyName("code")]
	[Description("状态码")]
	public string Code { get; set; }

	[JsonPropertyName("code_msg")]
	[Description("状态信息")]
	public string CodeMsg { get; set; }
}
