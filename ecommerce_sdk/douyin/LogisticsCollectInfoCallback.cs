namespace ecommerce.sdk.douyin;

[Description("作为服务商确认接单的依据，在揽收前可多次更新，揽收之后取消会失败，快递员信息或者网点信息回传会驱动运单变为已接单")]
public class LogisticsCollectInfoCallbackReq : IDouyinReq<LogisticsCollectInfoCallbackRsp>
{

	public string GetMethod() { return "logistics.collectInfoCallback"; }

	public string GetUrl() { return "/logistics/collectInfoCallback"; }

	[JsonPropertyName("biz_type")]
	[Description("courier：快递员信息,netInfo：网点信息,all：全部")]
	[NotNull]
	public string BizType { get; set; }

	[JsonPropertyName("operate_time")]
	[Description("更新时间戳")]
	[NotNull]
	public long? OperateTime { get; set; }

	[JsonPropertyName("request_id")]
	[Description("唯一码")]
	[NotNull]
	public string RequestId { get; set; }

	[JsonPropertyName("waybill_code")]
	[Description("运单号")]
	[NotNull]
	public string WaybillCode { get; set; }

	[JsonPropertyName("collect_info")]
	[Description("揽收网点&快递员信息")]
	[NotNull]
	public CollectInfoItem CollectInfo { get; set; }

	public class CollectInfoItem
	{
		[JsonPropertyName("courier_name")]
		[Description("快递员名称")]
		public string CourierName { get; set; }

		[JsonPropertyName("courier_tel")]
		[Description("联系电话")]
		public string CourierTel { get; set; }

		[JsonPropertyName("net_code")]
		[Description("网点编码")]
		public string NetCode { get; set; }

		[JsonPropertyName("net_name")]
		[Description("网点名称")]
		public string NetName { get; set; }

		[JsonPropertyName("net_tel")]
		[Description("网点联系电话")]
		public string NetTel { get; set; }
	}
}

[Description("作为服务商确认接单的依据，在揽收前可多次更新，揽收之后取消会失败，快递员信息或者网点信息回传会驱动运单变为已接单")]
public class LogisticsCollectInfoCallbackRsp
{
	[JsonPropertyName("result")]
	[Description("请求结果")]
	public bool Result { get; set; }

	[JsonPropertyName("return_code")]
	[Description("失败编码")]
	public string ReturnCode { get; set; }

	[JsonPropertyName("message")]
	[Description("失败原因")]
	public string Message { get; set; }
}
