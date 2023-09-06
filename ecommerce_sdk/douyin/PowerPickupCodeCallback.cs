namespace ecommerce.sdk.douyin;

[Description("略")]
public class PowerPickupCodeCallbackReq : IDouyinReq<PowerPickupCodeCallbackRsp>
{

	public string GetMethod() { return "power.pickupCodeCallback"; }

	public string GetUrl() { return "/power/pickupCodeCallback"; }

	[JsonPropertyName("waybill_code")]
	[Description("运单号")]
	[NotNull]
	public string WaybillCode { get; set; }

	[JsonPropertyName("express_company")]
	[Description("快递公司")]
	[NotNull]
	public string ExpressCompany { get; set; }

	[JsonPropertyName("partner_code")]
	[Description("服务商编码")]
	[NotNull]
	public string PartnerCode { get; set; }

	[JsonPropertyName("pick_code")]
	[Description("取件码")]
	[NotNull]
	public string PickCode { get; set; }

	[JsonPropertyName("pick_site_type")]
	[Description("取件点类型")]
	[NotNull]
	public string PickSiteType { get; set; }

	[JsonPropertyName("pick_site_name")]
	[Description("取件点名称")]
	[NotNull]
	public string PickSiteName { get; set; }

	[JsonPropertyName("pick_site_code")]
	[Description("取站点编码")]
	[NotNull]
	public string PickSiteCode { get; set; }

	[JsonPropertyName("pick_site_address")]
	[Description("取件点详细地址")]
	[NotNull]
	public string PickSiteAddress { get; set; }

	[JsonPropertyName("pick_site_phone")]
	[Description("取件点联系方式")]
	[NotNull]
	public string PickSitePhone { get; set; }

	[JsonPropertyName("partner_source")]
	[Description("请求方服务商来源")]
	[NotNull]
	public string PartnerSource { get; set; }

	[JsonPropertyName("operation_time")]
	[Description("操作时间")]
	[NotNull]
	public string OperationTime { get; set; }

	[JsonPropertyName("extend")]
	[Description("拓展字段")]
	public Dictionary<string,string> Extend { get; set; }
}

[Description("略")]
public class PowerPickupCodeCallbackRsp
{
	[JsonPropertyName("result")]
	[Description("请求结果")]
	public bool Result { get; set; }

	[JsonPropertyName("return_code")]
	[Description("返回码")]
	public string ReturnCode { get; set; }

	[JsonPropertyName("message")]
	[Description("返回信息")]
	public string Message { get; set; }
}
