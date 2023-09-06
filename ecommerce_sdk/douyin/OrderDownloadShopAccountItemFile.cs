namespace ecommerce.sdk.douyin;

[Description("1、通过download_id下载文件,download_id从【order/downloadShopAccountItem】接口获取,2、download_id有效期24小时,3、url链接时效为1小时")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","下载记录不存在","isv.parameter-invalid:100002","重新生成download_id去下载文件")]
[DouyinRetCode(50002,"业务处理失败","文件还未生成","isv.business-failed:100015","等待文件生成完成")]
[DouyinRetCode(50002,"业务处理失败","下载文件失败","isv.business-failed:100025","重新下载")]
[DouyinRetCode(40004,"非法的参数","文件已经失效","isv.parameter-invalid:100016","重新生成download_id去下载文件")]
public class OrderDownloadShopAccountItemFileReq : IDouyinReq<OrderDownloadShopAccountItemFileRsp>
{

	public string GetMethod() { return "order.downloadShopAccountItemFile"; }

	public string GetUrl() { return "/order/downloadShopAccountItemFile"; }

	[JsonPropertyName("download_id")]
	[Description("下载id，有效期24小时；")]
	[NotNull]
	public string DownloadId { get; set; }
}

[Description("1、通过download_id下载文件,download_id从【order/downloadShopAccountItem】接口获取,2、download_id有效期24小时,3、url链接时效为1小时")]
public class OrderDownloadShopAccountItemFileRsp
{
	[JsonPropertyName("url")]
	[Description("文件url，链接时效为1小时")]
	public string Url { get; set; }
}
