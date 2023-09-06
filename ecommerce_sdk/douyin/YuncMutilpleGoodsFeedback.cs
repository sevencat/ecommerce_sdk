namespace ecommerce.sdk.douyin;

[Description("给外部wms用于无头包裹信息回传")]
public class YuncMutilpleGoodsFeedbackReq : IDouyinReq<YuncMutilpleGoodsFeedbackRsp>
{

	public string GetMethod() { return "yunc.mutilpleGoodsFeedback"; }

	public string GetUrl() { return "/yunc/mutilpleGoodsFeedback"; }

	[JsonPropertyName("track_no")]
	[Description("运单号，必填")]
	public string TrackNo { get; set; }

	[JsonPropertyName("express_code")]
	[Description("快递公司编码，必填")]
	public string ExpressCode { get; set; }

	[JsonPropertyName("occor_time")]
	[Description("仓收包时间，秒级时间戳")]
	public long? OccorTime { get; set; }

	[JsonPropertyName("extend")]
	[Description("扩展字段")]
	public string Extend { get; set; }
}

[Description("给外部wms用于无头包裹信息回传")]
public class YuncMutilpleGoodsFeedbackRsp
{
	[JsonPropertyName("code")]
	[Description("响应编码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("响应信息")]
	public string Msg { get; set; }
}
