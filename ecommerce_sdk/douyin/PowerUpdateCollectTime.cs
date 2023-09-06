namespace ecommerce.sdk.douyin;

[Description("物流商改约同步修改接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","-10007:未知错误","isv.business-failed:-10007","人工定位")]
[DouyinRetCode(50002,"业务处理失败","10902:该运单号已超过修改次数阈值","isv.business-failed:10902","修改失败")]
[DouyinRetCode(50002,"业务处理失败","10905:修改时间不在3天内","isv.business-failed:10905","修改失败")]
[DouyinRetCode(50002,"业务处理失败","6405:系统异常","isv.business-failed:6405","修改失败")]
[DouyinRetCode(50002,"业务处理失败","10904:修改时间格式不允许","isv.business-failed:10904","修改失败")]
[DouyinRetCode(50002,"业务处理失败","10901:当前状态不允许修改","isv.business-failed:10901","修改失败")]
[DouyinRetCode(50002,"业务处理失败","10002:系统异常","isv.business-failed:10002","人工定位")]
[DouyinRetCode(50002,"业务处理失败","10906:不满足电联要求","isv.business-failed:10906","传入合法电联记录")]
[DouyinRetCode(50002,"业务处理失败","10000:参数错误","isv.business-failed:10000","检查参数")]
[DouyinRetCode(50002,"业务处理失败","滞留包裹不支持改约","isv.business-failed:10907","检查参数")]
[DouyinRetCode(50002,"业务处理失败","1h不支持改为2h预约时间","isv.business-failed:10014","检查参数")]
public class PowerUpdateCollectTimeReq : IDouyinReq<PowerUpdateCollectTimeRsp>
{

	public string GetMethod() { return "power.updateCollectTime"; }

	public string GetUrl() { return "/power/updateCollectTime"; }

	[JsonPropertyName("waybill_no")]
	[Description("1")]
	public string WaybillNo { get; set; }

	[JsonPropertyName("start_collect_time")]
	[Description("1")]
	public string StartCollectTime { get; set; }

	[JsonPropertyName("end_collect_time")]
	[Description("1")]
	public string EndCollectTime { get; set; }

	[JsonPropertyName("operation_time")]
	[Description("1")]
	public string OperationTime { get; set; }

	[JsonPropertyName("logistics_fulfill_order_no")]
	[Description("1")]
	public string LogisticsFulfillOrderNo { get; set; }

	[JsonPropertyName("call")]
	[Description("1")]
	public bool? Call { get; set; }

	[JsonPropertyName("call_nums")]
	[Description("1")]
	public string CallNums { get; set; }

	[JsonPropertyName("is_connected")]
	[Description("1")]
	public bool? IsConnected { get; set; }

	[JsonPropertyName("call_info")]
	[Description("1")]
	public List<CallInfoItem> CallInfo { get; set; }

	public class CallInfoItem
	{
		[JsonPropertyName("call_number")]
		[Description("1")]
		public string CallNumber { get; set; }

		[JsonPropertyName("caller_name")]
		[Description("1")]
		public string CallerName { get; set; }

		[JsonPropertyName("receive_number")]
		[Description("1")]
		public string ReceiveNumber { get; set; }

		[JsonPropertyName("is_connected")]
		[Description("1")]
		public bool? IsConnected { get; set; }

		[JsonPropertyName("call_time")]
		[Description("1")]
		public string CallTime { get; set; }

		[JsonPropertyName("call_duration")]
		[Description("1")]
		public string CallDuration { get; set; }
	}
}

[Description("物流商改约同步修改接口")]
public class PowerUpdateCollectTimeRsp
{
}
