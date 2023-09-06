namespace ecommerce.sdk.douyin;

[Description("质检机构上传质检结果（通过不通过之类的）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","订单状态异常","isp.service-error:2019","登录btas处理异常订单")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:3001","重试")]
[DouyinRetCode(20000,"系统错误","质检任务错误","isp.service-error:4002","重试")]
[DouyinRetCode(20000,"系统错误","质检编码重复","isp.service-error:2018","更换质检码")]
public class BtasScSetInspectionResultReq : IDouyinReq<BtasScSetInspectionResultRsp>
{

	public string GetMethod() { return "btas.sc.setInspectionResult"; }

	public string GetUrl() { return "/btas/sc/setInspectionResult"; }

	[JsonPropertyName("order_code")]
	[Description("订单码")]
	[NotNull]
	public string OrderCode { get; set; }

	[JsonPropertyName("result")]
	[Description("质检结果：1-通过，2-不通过，5-无法质检，99-无需质检，触发退货发")]
	[NotNull]
	public int? Result { get; set; }

	[JsonPropertyName("service_status")]
	[Description("1：上传质检报告，2：取消质检报告")]
	[NotNull]
	public int? ServiceStatus { get; set; }

	[JsonPropertyName("service_charge")]
	[Description("回传的这单的质检费用。单位（分）")]
	[NotNull]
	public int? ServiceCharge { get; set; }

	[JsonPropertyName("service_center_id")]
	[Description("质检中心ID")]
	[NotNull]
	public long? ServiceCenterId { get; set; }

	[JsonPropertyName("certification_code")]
	[Description("质检编码,仅字母数字")]
	[NotNull]
	public string CertificationCode { get; set; }

	[JsonPropertyName("result_details")]
	[Description("质检详情。JSON字符串")]
	[NotNull]
	public string ResultDetails { get; set; }

	[JsonPropertyName("inspection_complete_time")]
	[Description("质检完成时间（秒,UTC）")]
	[NotNull]
	public long? InspectionCompleteTime { get; set; }
}

[Description("质检机构上传质检结果（通过不通过之类的）")]
public class BtasScSetInspectionResultRsp
{
}
