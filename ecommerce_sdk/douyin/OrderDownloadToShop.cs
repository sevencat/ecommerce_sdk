namespace ecommerce.sdk.douyin;

[Description("查询该下载文件是否已经生成并返回下载链接,download_id从/order/downloadSettleItemToShop接口获取,状态码,链接时效为1小时，失效后需重新调此接口获取新的链接,100000-成功")]
[DouyinRetCode(10000,"success","","","")]
public class OrderDownloadToShopReq : IDouyinReq<OrderDownloadToShopRsp>
{

	public string GetMethod() { return "order.downloadToShop"; }

	public string GetUrl() { return "/order/downloadToShop"; }

	[JsonPropertyName("download_id")]
	[Description("生成的download_id")]
	[NotNull]
	public string DownloadId { get; set; }
}

[Description("查询该下载文件是否已经生成并返回下载链接,download_id从/order/downloadSettleItemToShop接口获取,状态码,链接时效为1小时，失效后需重新调此接口获取新的链接,100000-成功")]
public class OrderDownloadToShopRsp
{
	[JsonPropertyName("code")]
	[Description("状态码    100000-成功   100002-下载记录不存在   100015-文件还未生成   100016-文件已经失效   100025-文件生成失败")]
	public string Code { get; set; }

	[JsonPropertyName("code_msg")]
	[Description("状态说明")]
	public string CodeMsg { get; set; }

	[JsonPropertyName("url")]
	[Description("生成的下载链接")]
	public string Url { get; set; }
}
