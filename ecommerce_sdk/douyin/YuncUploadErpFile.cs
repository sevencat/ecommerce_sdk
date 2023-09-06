namespace ecommerce.sdk.douyin;

[Description("isv系统上传商品和货品关系数据到抖音侧")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:30001","核对请求入参数")]
[DouyinRetCode(50002,"业务处理失败","验签失败,请检查参数","isv.business-failed:30002","验签失败,请检查参数")]
[DouyinRetCode(50002,"业务处理失败","文件重复，无需上传","isv.business-failed:30003","文件重复，无需上传")]
[DouyinRetCode(50002,"业务处理失败","业务处理错误,请联系客服","isv.business-failed:30004","业务处理错误,请联系客服")]
[DouyinRetCode(50002,"业务处理失败","文件行数不一致，请检查","isv.business-failed:30005","文件行数不一致，请检查")]
public class YuncUploadErpFileReq : IDouyinReq<YuncUploadErpFileRsp>
{

	public string GetMethod() { return "yunc.uploadErpFile"; }

	public string GetUrl() { return "/yunc/uploadErpFile"; }

	[JsonPropertyName("bin_file_uri")]
	[Description("文件资源描述符")]
	[NotNull]
	public object BinFileUri { get; set; }

	[JsonPropertyName("name")]
	[Description("20130702_APPID_文件总数_第几个文件")]
	[NotNull]
	public string Name { get; set; }

	[JsonPropertyName("idempotent")]
	[Description("文件唯一标识")]
	[NotNull]
	public string Idempotent { get; set; }

	[JsonPropertyName("line_number")]
	[Description("文件行数")]
	[NotNull]
	public long? LineNumber { get; set; }

	[JsonPropertyName("file_md5")]
	[Description("文件md5值")]
	[NotNull]
	public string FileMd5 { get; set; }

	[JsonPropertyName("file_number")]
	[Description("文件数目")]
	[NotNull]
	public long? FileNumber { get; set; }

	[JsonPropertyName("total_line_number")]
	[Description("总行数")]
	[NotNull]
	public long? TotalLineNumber { get; set; }

	[JsonPropertyName("bin_original_uri")]
	[Description("和bin_file_uri的值一样")]
	[NotNull]
	public string BinOriginalUri { get; set; }
}

[Description("isv系统上传商品和货品关系数据到抖音侧")]
public class YuncUploadErpFileRsp
{
	[JsonPropertyName("code")]
	[Description("错误编码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("错误描述")]
	public string Msg { get; set; }
}
