namespace ecommerce.sdk.douyin;

[Description("电子面单服务订购审核回调函数")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","10501:不能重复审核","isv.business-failed:10501","请检查请求参数")]
public class LogisticsNetsiteApplyCallbackReq : IDouyinReq<LogisticsNetsiteApplyCallbackRsp>
{

	public string GetMethod() { return "logistics.netsiteApplyCallback"; }

	public string GetUrl() { return "/logistics/netsiteApplyCallback"; }

	[JsonPropertyName("book_id")]
	[Description("订购id")]
	[NotNull]
	public string BookId { get; set; }

	[JsonPropertyName("result")]
	[Description("审核结果 （通过-true, 不通过 - false）")]
	[NotNull]
	public bool? Result { get; set; }

	[JsonPropertyName("remark")]
	[Description("审核意见，不通过是可以备注本字段")]
	public string Remark { get; set; }

	[JsonPropertyName("company")]
	[Description("物流商编码")]
	public string Company { get; set; }

	[JsonPropertyName("action")]
	[Description("1")]
	public int? Action { get; set; }
}

[Description("电子面单服务订购审核回调函数")]
public class LogisticsNetsiteApplyCallbackRsp
{
}
