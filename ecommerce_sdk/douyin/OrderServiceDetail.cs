namespace ecommerce.sdk.douyin;

[Description("商家服务单详情")]
public class OrderServiceDetailReq : IDouyinReq<OrderServiceDetailRsp>
{

	public string GetMethod() { return "order.serviceDetail"; }

	public string GetUrl() { return "/order/serviceDetail"; }

	[JsonPropertyName("service_id")]
	[Description("服务请求列表中获取的id")]
	[NotNull]
	public long? ServiceId { get; set; }
}

[Description("商家服务单详情")]
public class OrderServiceDetailRsp
{
	[JsonPropertyName("detail")]
	[Description("详情")]
	public DetailItem Detail { get; set; }

	public class DetailItem
	{
		[JsonPropertyName("id")]
		[Description("服务请求ID")]
		public long Id { get; set; }

		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public long OrderId { get; set; }

		[JsonPropertyName("operate_status")]
		[Description("操作状态，增加审核中状态码；枚举：0-待处理,5-用户确认中,10-平台介入中,100-已完结")]
		public int OperateStatus { get; set; }

		[JsonPropertyName("detail")]
		[Description("服务单详情")]
		public string DetailI { get; set; }

		[JsonPropertyName("reply")]
		[Description("商家答复内容")]
		public string Reply { get; set; }

		[JsonPropertyName("create_time")]
		[Description("服务单创建时间")]
		public string CreateTime { get; set; }

		[JsonPropertyName("service_type")]
		[Description("服务单类型，枚举")]
		public long ServiceType { get; set; }

		[JsonPropertyName("reply_time")]
		[Description("最新回复时间")]
		public string ReplyTime { get; set; }

		[JsonPropertyName("operate_status_desc")]
		[Description("操作状态含义，增加审核中状态")]
		public string OperateStatusDesc { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺id")]
		public long ShopId { get; set; }

		[JsonPropertyName("is_reject")]
		[Description("是否为被审核驳回的服务单")]
		public long IsReject { get; set; }

		[JsonPropertyName("reject_detail")]
		[Description("驳回内容")]
		public string RejectDetail { get; set; }

		[JsonPropertyName("reject_time")]
		[Description("驳回时间")]
		public string RejectTime { get; set; }

		// [JsonPropertyName("reject_time")]
		// [Description("驳回时间")]
		// public string RejectTime { get; set; }

		[JsonPropertyName("proof_demo")]
		[Description("凭证demo url")]
		public string ProofDemo { get; set; }

		[JsonPropertyName("evidence_required")]
		[Description("是否必须上传凭证")]
		public long EvidenceRequired { get; set; }

		[JsonPropertyName("img_list")]
		[Description("图片url 数组json")]
		public List<string> ImgList { get; set; }

		[JsonPropertyName("expiration_time")]
		[Description("超时时间")]
		public string ExpirationTime { get; set; }

		[JsonPropertyName("close_time")]
		[Description("关闭时间")]
		public string CloseTime { get; set; }

		[JsonPropertyName("close_detail")]
		[Description("关闭原因")]
		public string CloseDetail { get; set; }

		[JsonPropertyName("first_reply_time")]
		[Description("首次回复时间")]
		public string FirstReplyTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("服务单更新时间时间")]
		public string UpdateTime { get; set; }
	}

	[JsonPropertyName("logs")]
	[Description("日志")]
	public List<LogsItem> Logs { get; set; }

	public class LogsItem
	{
		[JsonPropertyName("create_time")]
		[Description("创建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("content")]
		[Description("内容")]
		public string Content { get; set; }

		[JsonPropertyName("img_list")]
		[Description("图片列表")]
		public List<string> ImgList { get; set; }

		[JsonPropertyName("service_log_type")]
		[Description("日志类型")]
		public int ServiceLogType { get; set; }

		[JsonPropertyName("operate_name")]
		[Description("平台客服")]
		public string OperateName { get; set; }

		[JsonPropertyName("service_detail")]
		[Description("服务详情")]
		public string ServiceDetail { get; set; }

		[JsonPropertyName("reply_detail")]
		[Description("回复内容")]
		public string ReplyDetail { get; set; }

		[JsonPropertyName("close_detail")]
		[Description("关闭原因")]
		public string CloseDetail { get; set; }

		[JsonPropertyName("reject_detail")]
		[Description("驳回内容")]
		public string RejectDetail { get; set; }

		[JsonPropertyName("deal_time")]
		[Description("24小时")]
		public string DealTime { get; set; }
	}
}
