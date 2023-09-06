namespace ecommerce.sdk.douyin;

[Description("在发布商品的时候需要填写商品资质，可以通过这个接口获取当前类目下需要填写的资质列表。,本接口返回的是否必填信息在发布商品时可能会由于商家信息/提交的商品信息出现动态变动，如发布商品时提示有资质未填写，请增加该资质后再进行发布。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","请指定类目","isv.business-failed:2010004","请检查类目信息")]
[DouyinRetCode(50002,"业务处理失败","获取类目配置失败，请稍后重试","isv.business-failed:2010001","请稍后重试")]
public class ProductQualificationConfigReq : IDouyinReq<ProductQualificationConfigRsp>
{

	public string GetMethod() { return "product.qualificationConfig"; }

	public string GetUrl() { return "/product/qualificationConfig"; }

	[JsonPropertyName("category_id")]
	[Description("类目ID")]
	[NotNull]
	public long? CategoryId { get; set; }
}

[Description("在发布商品的时候需要填写商品资质，可以通过这个接口获取当前类目下需要填写的资质列表。,本接口返回的是否必填信息在发布商品时可能会由于商家信息/提交的商品信息出现动态变动，如发布商品时提示有资质未填写，请增加该资质后再进行发布。")]
public class ProductQualificationConfigRsp
{
	[JsonPropertyName("config_list")]
	[Description("资质列表")]
	public List<ConfigListItem> ConfigList { get; set; }

	public class ConfigListItem
	{
		[JsonPropertyName("key")]
		[Description("资质ID")]
		public string Key { get; set; }

		[JsonPropertyName("name")]
		[Description("资质名")]
		public string Name { get; set; }

		[JsonPropertyName("text_list")]
		[Description("填写提示")]
		public List<string> TextList { get; set; }

		[JsonPropertyName("is_required")]
		[Description("是否必填")]
		public bool IsRequired { get; set; }

		[JsonPropertyName("matchable_rule")]
		[Description("商品类目属性可能触发的规则（会导致资质是否必填发生变化）")]
		public List<MatchableRuleItem> MatchableRule { get; set; }

		public class MatchableRuleItem
		{
			[JsonPropertyName("rule_clause")]
			[Description("key为类目属性id，当该属性填了如下属性值时，命中规则")]
			public Dictionary<long,RuleClauseItem> RuleClause { get; set; }

			public class RuleClauseItem
			{
				[JsonPropertyName("property_values")]
				[Description("属性值id数组")]
				public List<long> PropertyValues { get; set; }

				[JsonPropertyName("operand_str")]
				[Description("等于、不等于")]
				public string OperandStr { get; set; }
			}

			[JsonPropertyName("is_qualification_required")]
			[Description("命中该规则后 该资质是否必填")]
			public bool IsQualificationRequired { get; set; }
		}
	}
}
