namespace ecommerce.sdk.douyin;

[Description("分拨直送服务商回传支线单据")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:1002","检查参数")]
[DouyinRetCode(40004,"非法的参数","单据非法","isv.parameter-invalid:1003","检查运单号是否正确")]
[DouyinRetCode(50002,"业务处理失败","节点时序状态有误","isv.business-failed:1004","检查事件是否有时序问题")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:1005","可以联系运营，进行oncall 技术")]
[DouyinRetCode(40004,"非法的参数","记录不存在","isv.parameter-invalid:1006","记录不存在")]
public class CrossBorderReceiveFeederInfoReq : IDouyinReq<CrossBorderReceiveFeederInfoRsp>
{

	public string GetMethod() { return "crossBorder.receiveFeederInfo"; }

	public string GetUrl() { return "/crossBorder/receiveFeederInfo"; }

	[JsonPropertyName("operator")]
	[Description("操作人(账号)")]
	[NotNull]
	public string Operator { get; set; }

	[JsonPropertyName("data")]
	[Description("分拨直送数据")]
	[NotNull]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("bagging_num")]
		[Description("集包号")]
		public string BaggingNum { get; set; }

		[JsonPropertyName("event_type")]
		[Description("事件类型（EventType），1:节点扭转事件 2:异常上报事件")]
		[NotNull]
		public long? EventType { get; set; }

		[JsonPropertyName("event_code")]
		[Description("事件code（EventCode）")]
		[NotNull]
		public string EventCode { get; set; }

		[JsonPropertyName("event_msg")]
		[Description("事件msg（EventMsg)")]
		[NotNull]
		public string EventMsg { get; set; }

		[JsonPropertyName("occurrence_time")]
		[Description("毫秒时间戳")]
		[NotNull]
		public long? OccurrenceTime { get; set; }

		[JsonPropertyName("waybill_no")]
		[Description("运单号")]
		[NotNull]
		public string WaybillNo { get; set; }

		[JsonPropertyName("pics")]
		[Description("图片url列表 最多5张")]
		public List<string> Pics { get; set; }
	}

	[JsonPropertyName("vendor")]
	[Description("字节给供应链服务商定义的编码")]
	[NotNull]
	public string Vendor { get; set; }
}

[Description("分拨直送服务商回传支线单据")]
public class CrossBorderReceiveFeederInfoRsp
{
	[JsonPropertyName("code")]
	[Description("0 表示成功")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("msg信息")]
	public string Msg { get; set; }
}
