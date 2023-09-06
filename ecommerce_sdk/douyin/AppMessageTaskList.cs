namespace ecommerce.sdk.douyin;

[Description("获取已发送给服务市场商家消息任务列表")]
[DouyinRetCode(10000,"success","","","")]
public class AppMessageTaskListReq : IDouyinReq<AppMessageTaskListRsp>
{

	public string GetMethod() { return "appMessage.taskList"; }

	public string GetUrl() { return "/appMessage/taskList"; }

	[JsonPropertyName("template_id")]
	[Description("模板id")]
	public long? TemplateId { get; set; }

	[JsonPropertyName("page_no")]
	[Description("页码，从1开始")]
	[NotNull]
	public long? PageNo { get; set; }

	[JsonPropertyName("page_size")]
	[Description("页大小")]
	[NotNull]
	public long? PageSize { get; set; }
}

[Description("获取已发送给服务市场商家消息任务列表")]
public class AppMessageTaskListRsp
{
	[JsonPropertyName("task_list")]
	[Description("消息任务列表")]
	public List<TaskListItem> TaskList { get; set; }

	public class TaskListItem
	{
		[JsonPropertyName("id")]
		[Description("任务id")]
		public long Id { get; set; }

		[JsonPropertyName("app_id")]
		[Description("应用id")]
		public long AppId { get; set; }

		[JsonPropertyName("template_id")]
		[Description("模板id")]
		public long TemplateId { get; set; }

		[JsonPropertyName("msg_param")]
		[Description("消息参数")]
		public string MsgParam { get; set; }

		[JsonPropertyName("send_to")]
		[Description("消息接收方(shop_id)")]
		public string SendTo { get; set; }

		[JsonPropertyName("rid")]
		[Description("业务键")]
		public string Rid { get; set; }

		[JsonPropertyName("send_status")]
		[Description("发送状态,0-待发送,1-频控规则不通过,2-幂等校验不通过,3-发送成功")]
		public int SendStatus { get; set; }

		[JsonPropertyName("success_cnt")]
		[Description("发送成功条数")]
		public long SuccessCnt { get; set; }

		[JsonPropertyName("failure_cnt")]
		[Description("发送失败条数")]
		public long FailureCnt { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public long UpdateTime { get; set; }

		[JsonPropertyName("template_name")]
		[Description("模板名称")]
		public string TemplateName { get; set; }

		[JsonPropertyName("app_name")]
		[Description("应用名称")]
		public string AppName { get; set; }

		[JsonPropertyName("shop_name")]
		[Description("商家名称")]
		public string ShopName { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
