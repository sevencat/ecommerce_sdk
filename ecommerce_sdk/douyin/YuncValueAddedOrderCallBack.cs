namespace ecommerce.sdk.douyin;

[Description("WMS回传增值服务单数据")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务端异常","isp.service-error:1001","联系服务端研发排查")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:1004","检查参数重新回传")]
[DouyinRetCode(50002,"业务处理失败","仓库编码鉴权失败，操作仓和鉴权仓不一致","isv.business-failed:1003","检查操作仓Code")]
[DouyinRetCode(50002,"业务处理失败","增值服务单不存在","isv.business-failed:21000","检查增值服务单号后重试")]
public class YuncValueAddedOrderCallBackReq : IDouyinReq<YuncValueAddedOrderCallBackRsp>
{

	public string GetMethod() { return "yunc.valueAddedOrderCallBack"; }

	public string GetUrl() { return "/yunc/valueAddedOrderCallBack"; }

	[JsonPropertyName("value_added_order_no")]
	[Description("增值服务单号")]
	[NotNull]
	public string ValueAddedOrderNo { get; set; }

	[JsonPropertyName("event_type")]
	[Description("事件类型 2-待审核 3-审核不通过 4-审核通过 5-作业中 6-已完成")]
	[NotNull]
	public long? EventType { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓编号")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("biz_order_no")]
	[Description("唯一流水号")]
	[NotNull]
	public string BizOrderNo { get; set; }

	[JsonPropertyName("occur_time")]
	[Description("秒级时间戳")]
	[NotNull]
	public long? OccurTime { get; set; }

	[JsonPropertyName("operator")]
	[Description("操作人")]
	[NotNull]
	public string Operator { get; set; }

	[JsonPropertyName("details")]
	[Description("增值服务详情")]
	public List<DetailsItem> Details { get; set; }

	public class DetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("行号")]
		[NotNull]
		public string LineNo { get; set; }

		[JsonPropertyName("actual_qty")]
		[Description("实际数量")]
		[NotNull]
		public long? ActualQty { get; set; }
	}
}

[Description("WMS回传增值服务单数据")]
public class YuncValueAddedOrderCallBackRsp
{
	[JsonPropertyName("code")]
	[Description("错误码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("异常信息")]
	public string Msg { get; set; }

	[JsonPropertyName("data")]
	[Description("data")]
	public string Data { get; set; }
}
