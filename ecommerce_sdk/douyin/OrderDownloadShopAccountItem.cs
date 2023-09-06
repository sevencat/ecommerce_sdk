namespace ecommerce.sdk.douyin;

[Description("请求下载资金流水明细，得到download_id,download_id获取文件需要从order/downloadShopAccountItemFile接口获取，数据T+1生成，建议第二天15点之后下载")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数异常，请检查参数","isv.parameter-invalid:500","输入合法参数")]
public class OrderDownloadShopAccountItemReq : IDouyinReq<OrderDownloadShopAccountItemRsp>
{

	public string GetMethod() { return "order.downloadShopAccountItem"; }

	public string GetUrl() { return "/order/downloadShopAccountItem"; }

	[JsonPropertyName("start_time")]
	[Description("开始时间")]
	public string StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("结束时间")]
	public string EndTime { get; set; }

	[JsonPropertyName("order_id")]
	[Description("订单号(如果订单号未传，则时间必须传)")]
	public string OrderId { get; set; }

	[JsonPropertyName("account_type")]
	[Description("动账账户 0: 所有 1: 微信 2:支付宝 3:合众支付 4:聚合支付")]
	public int? AccountType { get; set; }

	[JsonPropertyName("biz_type")]
	[Description("计费类型 0:全部 1:鲁班广告 2:精选联盟 3:值点商城 4:小店自卖 5:橙子建站 6:POI 7:抖+ 8:穿山甲 9:服务市场 10:服务市场外包客服 11:学浪")]
	public int? BizType { get; set; }

	[JsonPropertyName("time_type")]
	[Description("时间类型 0 动账时间 1 下单时间")]
	public int? TimeType { get; set; }

	[JsonPropertyName("product_id")]
	[Description("产品id")]
	public string ProductId { get; set; }
}

[Description("请求下载资金流水明细，得到download_id,download_id获取文件需要从order/downloadShopAccountItemFile接口获取，数据T+1生成，建议第二天15点之后下载")]
public class OrderDownloadShopAccountItemRsp
{
	[JsonPropertyName("code")]
	[Description("返回code 100000为成功，其他为失败")]
	public string Code { get; set; }

	[JsonPropertyName("code_msg")]
	[Description("返回描述")]
	public string CodeMsg { get; set; }

	[JsonPropertyName("download_id")]
	[Description("下载id，有效期24小时")]
	public string DownloadId { get; set; }
}
