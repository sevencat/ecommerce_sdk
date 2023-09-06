namespace ecommerce.sdk.douyin;

[Description("服务商向平台回告运单信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"服务不可用","接口调用异常，请重试，多次失败请人工反馈","isp.service-error:1005","")]
[DouyinRetCode(20000,"服务不可用","NotifyLogisticsInfo err","isp.service-error:-1","")]
public class CrossborderTakingLogisticsInfoReq : IDouyinReq<CrossborderTakingLogisticsInfoRsp>
{

	public string GetMethod() { return "crossborder.takingLogisticsInfo"; }

	public string GetUrl() { return "/crossborder/takingLogisticsInfo"; }

	[JsonPropertyName("vendor")]
	[Description("服务商编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("order_id")]
	[Description("交易单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("domestic_carrier")]
	[Description("物流公司编码")]
	[NotNull]
	public string DomesticCarrier { get; set; }

	[JsonPropertyName("domestic_trans_no")]
	[Description("物流单号")]
	[NotNull]
	public string DomesticTransNo { get; set; }

	[JsonPropertyName("express_code")]
	[Description("物流企业代码，四字中文编码")]
	public string ExpressCode { get; set; }

	[JsonPropertyName("express_cop_code")]
	[Description("物流企业海关编码")]
	[NotNull]
	public string ExpressCopCode { get; set; }

	[JsonPropertyName("express_cop_name")]
	[Description("物流企业名称")]
	[NotNull]
	public string ExpressCopName { get; set; }

	[JsonPropertyName("sort_code")]
	[Description("三段码")]
	public string SortCode { get; set; }

	[JsonPropertyName("remark01")]
	[Description("物流备用字段01")]
	public string Remark01 { get; set; }

	[JsonPropertyName("remark02")]
	[Description("物流备用字段02")]
	public string Remark02 { get; set; }

	[JsonPropertyName("remark03")]
	[Description("物流备用字段03")]
	public string Remark03 { get; set; }

	[JsonPropertyName("remark04")]
	[Description("物流备用字段04")]
	public string Remark04 { get; set; }

	[JsonPropertyName("remark05")]
	[Description("物流备用字段05")]
	public string Remark05 { get; set; }

	[JsonPropertyName("remark06")]
	[Description("物流备用字段06")]
	public string Remark06 { get; set; }

	[JsonPropertyName("remark07")]
	[Description("物流备用字段07")]
	public string Remark07 { get; set; }

	[JsonPropertyName("remark08")]
	[Description("物流备用字段08")]
	public string Remark08 { get; set; }

	[JsonPropertyName("remark09")]
	[Description("物流备用字段09")]
	public string Remark09 { get; set; }

	[JsonPropertyName("remark10")]
	[Description("物流备用字段10")]
	public string Remark10 { get; set; }
}

[Description("服务商向平台回告运单信息")]
public class CrossborderTakingLogisticsInfoRsp
{
	[JsonPropertyName("code")]
	[Description("成功")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("成功")]
	public string Msg { get; set; }
}
