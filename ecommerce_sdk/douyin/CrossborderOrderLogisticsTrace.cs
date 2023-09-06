namespace ecommerce.sdk.douyin;

[Description("服务商回传国际干线作业节点")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","1005:接口调用异常，请重试，多次失败请人工反馈","isp.service-error:1005","调用方重试，多次重试失败请联系运营人员")]
[DouyinRetCode(50002,"业务处理失败","1002:【干线发运完成】时,transportation信息overseaTransNo|billNo不能缺失！","isv.business-failed:1002","请根据提示回传正确的参数")]
[DouyinRetCode(50002,"业务处理失败","1000:节点时序状态有误","isv.business-failed:1000","请检查节点时序状态")]
[DouyinRetCode(50002,"业务处理失败","1004:当前状态节点的时间不能早于平台推单成功时间、不能早于上一个状态操作时间，不能晚于系统当前时间","isv.business-failed:1004","请检查当前状态节点的时间参数")]
public class CrossborderOrderLogisticsTraceReq : IDouyinReq<CrossborderOrderLogisticsTraceRsp>
{

	public string GetMethod() { return "crossborder.orderLogisticsTrace"; }

	public string GetUrl() { return "/crossborder/orderLogisticsTrace"; }

	[JsonPropertyName("order_id")]
	[Description("字节电商平台的交易订单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("vendor")]
	[Description("字节给供应链服务商定义的编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("status")]
	[Description("国际物流状态：1干线提货完成  2干线发运完成  3实物到港")]
	[NotNull]
	public long? Status { get; set; }

	[JsonPropertyName("occurrence_time")]
	[Description("物流状态的真实发生时间，yyyy-MM-dd hh:mi:ss")]
	[NotNull]
	public string OccurrenceTime { get; set; }

	[JsonPropertyName("origin")]
	[Description("始发地（国/港口）")]
	[NotNull]
	public string Origin { get; set; }

	[JsonPropertyName("destination")]
	[Description("目的地（国/港口）")]
	[NotNull]
	public string Destination { get; set; }

	[JsonPropertyName("transportation")]
	[Description("国际物流信息（【干线发运完成】状态时，必须提供）")]
	public TransportationItem Transportation { get; set; }

	public class TransportationItem
	{
		[JsonPropertyName("oversea_trans_no")]
		[Description("国际运单号（CC/UPU）一单到底该单号同国内运单号")]
		public string OverseaTransNo { get; set; }

		[JsonPropertyName("bill_no")]
		[Description("提单号（BC）")]
		public string BillNo { get; set; }

		[JsonPropertyName("voyage_no")]
		[Description("航司航班班次号（BC）")]
		public string VoyageNo { get; set; }
	}
}

[Description("服务商回传国际干线作业节点")]
public class CrossborderOrderLogisticsTraceRsp
{
}
