namespace ecommerce.sdk.douyin;

[Description("获取运费模板列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","获取运费模板列表失败，请稍后重试","isp.service-error:20013","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","20012:size参数格式错误","isv.business-failed:20012","请检查size参数格式")]
[DouyinRetCode(50002,"业务处理失败","20011:page参数格式错误","isv.business-failed:20011","请检查page参数格式")]
[DouyinRetCode(50002,"业务处理失败","422:搜索超过最大字数限制","isv.business-failed:422","请检查参数")]
[DouyinRetCode(50002,"业务处理失败","500:查询运费模版失败","isv.business-failed:500","请稍后重试")]
public class FreightTemplateListReq : IDouyinReq<FreightTemplateListRsp>
{

	public string GetMethod() { return "freightTemplate.list"; }

	public string GetUrl() { return "/freightTemplate/list"; }

	[JsonPropertyName("name")]
	[Description("运费模板名称，支持模糊搜索")]
	public string Name { get; set; }

	[JsonPropertyName("page")]
	[Description("页数（默认为0，第一页从0开始）")]
	public string Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页模板数（默认为10），最大值是100")]
	public string Size { get; set; }
}

[Description("获取运费模板列表")]
public class FreightTemplateListRsp
{
	[Description("运费模版列表")]
	public List<ListItem> List { get; set; }

	public class ListItem
	{
		[JsonPropertyName("template")]
		[Description("运费模版")]
		public TemplateItem Template { get; set; }

		public class TemplateItem
		{
			[JsonPropertyName("id")]
			[Description("运费模板id，可用于商品发布接口使用")]
			public long Id { get; set; }

			[JsonPropertyName("template_name")]
			[Description("运费模板名称")]
			public string TemplateName { get; set; }

			[JsonPropertyName("product_province")]
			[Description("发货省份id")]
			public string ProductProvince { get; set; }

			[JsonPropertyName("product_city")]
			[Description("发货城市id")]
			public string ProductCity { get; set; }

			[JsonPropertyName("calculate_type")]
			[Description("计价方式-1.按重量计价 2.按数量计价")]
			public long CalculateType { get; set; }

			[JsonPropertyName("transfer_type")]
			[Description("快递方式-1.快递 目前仅支持1")]
			public long TransferType { get; set; }

			[JsonPropertyName("rule_type")]
			[Description("模板类型-0:阶梯计价 1:固定运费 2:卖家包邮 3:货到付款")]
			public long RuleType { get; set; }

			[JsonPropertyName("fixed_amount")]
			[Description("固定运费金额(单位:分) 固定运费模板必填 1-9900之间的整数")]
			public long FixedAmount { get; set; }
		}
	}

	[Description("总数")]
	public long Count { get; set; }
}
