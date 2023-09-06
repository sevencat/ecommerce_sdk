namespace ecommerce.sdk.douyin;

[Description("获取服务单列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","时间格式不正确","isv.business-failed:10002","-")]
public class OrderGetServiceListReq : IDouyinReq<OrderGetServiceListRsp>
{

	public string GetMethod() { return "order.getServiceList"; }

	public string GetUrl() { return "/order/getServiceList"; }

	[JsonPropertyName("start_time")]
	[Description("创建开始时间时间戳")]
	[NotNull]
	public long? StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("创建结束时间时间戳，必须大于开始时间")]
	[NotNull]
	public long? EndTime { get; set; }

	[JsonPropertyName("status")]
	[Description("1、不传代表获取全部服务请求     2、操作状态：0 #待处理 10 #审核中 100 #已关闭")]
	public int? Status { get; set; }

	[JsonPropertyName("order_id")]
	[Description("订单id")]
	public long? OrderId { get; set; }

	[JsonPropertyName("service_id")]
	[Description("服务单id")]
	public long? ServiceId { get; set; }

	[JsonPropertyName("order_by")]
	[Description("1、默认按服务单创建时间搜索     2、值为“create_time”：按服务单创建时间；值为“update_time”：按服务单更新时间")]
	public string OrderBy { get; set; }

	[JsonPropertyName("page")]
	[Description("页数（默认值为1，第一页从1开始）")]
	public int? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页订单数（默认为10，最大100），超过100则会按照最大值100处理")]
	public int? Size { get; set; }

	[JsonPropertyName("order")]
	[Description("排序方式：ASC按时间升序，  DESC按时间降序     默认DESC")]
	public string Order { get; set; }
}

[Description("获取服务单列表")]
public class OrderGetServiceListRsp
{
	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }

	[JsonPropertyName("list")]
	[Description("列表")]
	public List<ListItem> List { get; set; }

	public class ListItem
	{
		[JsonPropertyName("id")]
		[Description("服务请求ID")]
		public long Id { get; set; }

		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public long OrderId { get; set; }

		[JsonPropertyName("operate_status")]
		[Description("操作状态")]
		public int OperateStatus { get; set; }

		[JsonPropertyName("detail")]
		[Description("服务单详情")]
		public string Detail { get; set; }

		[JsonPropertyName("reply")]
		[Description("回复内容")]
		public string Reply { get; set; }

		[JsonPropertyName("create_time")]
		[Description("服务创建时间")]
		public string CreateTime { get; set; }

		[JsonPropertyName("service_type")]
		[Description("服务类型")]
		public long ServiceType { get; set; }

		[JsonPropertyName("reply_time")]
		[Description("回复时间")]
		public string ReplyTime { get; set; }

		[JsonPropertyName("operate_status_desc")]
		[Description("操作状态含义")]
		public string OperateStatusDesc { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺id")]
		public long ShopId { get; set; }

		[JsonPropertyName("update_time")]
		[Description("服务更新时间时间")]
		public string UpdateTime { get; set; }
	}
}
