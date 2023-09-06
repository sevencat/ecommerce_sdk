namespace ecommerce.sdk.douyin;

[Description("获取消息模版列表")]
[DouyinRetCode(10000,"success","","","")]
public class AppMessageTemplateListReq : IDouyinReq<AppMessageTemplateListRsp>
{

	public string GetMethod() { return "appMessage.templateList"; }

	public string GetUrl() { return "/appMessage/templateList"; }

	[JsonPropertyName("page_index")]
	[Description("页码，从1开始")]
	[NotNull]
	public long? PageIndex { get; set; }

	[JsonPropertyName("page_size")]
	[Description("页大小")]
	[NotNull]
	public long? PageSize { get; set; }
}

[Description("获取消息模版列表")]
public class AppMessageTemplateListRsp
{
	[JsonPropertyName("template_list")]
	[Description("消息模板列表")]
	public List<TemplateListItem> TemplateList { get; set; }

	public class TemplateListItem
	{
		[JsonPropertyName("template_id")]
		[Description("模板id")]
		public long TemplateId { get; set; }

		[JsonPropertyName("status")]
		[Description("模板状态,0-待上线,1-已上线,2-已下线")]
		public int Status { get; set; }

		[JsonPropertyName("msg_type")]
		[Description("消息模板类型,1-待处理任务,2-效果报道（含周报日报）,3-能力升级提醒,4-服务维护提醒")]
		public int MsgType { get; set; }

		[JsonPropertyName("title")]
		[Description("模板标题")]
		public string Title { get; set; }

		[JsonPropertyName("content")]
		[Description("模板内容")]
		public string Content { get; set; }

		[JsonPropertyName("example")]
		[Description("模板示例")]
		public string Example { get; set; }

		[JsonPropertyName("params")]
		[Description("参数列表")]
		public List<ParamsItem> Params { get; set; }

		public class ParamsItem
		{
			[JsonPropertyName("param_name")]
			[Description("参数名称")]
			public string ParamName { get; set; }

			[JsonPropertyName("example_value")]
			[Description("示例值")]
			public string ExampleValue { get; set; }

			[JsonPropertyName("is_necessary")]
			[Description("是否必须,0-否,1-是")]
			public long IsNecessary { get; set; }

			[JsonPropertyName("param_desc")]
			[Description("参数描述")]
			public string ParamDesc { get; set; }
		}

		[JsonPropertyName("template_name")]
		[Description("模板名称")]
		public string TemplateName { get; set; }

		[JsonPropertyName("description")]
		[Description("模板描述")]
		public string Description { get; set; }

		[JsonPropertyName("msg_type_str")]
		[Description("模板类型string格式")]
		public string MsgTypeStr { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
