namespace ecommerce.sdk.douyin;

[Description("通过输入品牌名称进行模糊查询，支持品牌中文名(拼音)、英文名，并返回品牌信息,本接口适用于通过前缀匹配的形式对品牌信息，例如想要“安踏”，可以通过搜索“安”来查询，但是搜索“踏”是无法找到的。,注意点：1. 召回的第一个为品牌名称严格匹配项。,2. 单次召回数量最多为10个。,3. 支持中文名称或英文名称，但不可以两个名称一起输入来查询,4. 不支持特殊符号，例如“/”，“ ”，“·”，以及除中英文外的语言")]
public class BrandGetSugReq : IDouyinReq<BrandGetSugRsp>
{

	public string GetMethod() { return "brand.getSug"; }

	public string GetUrl() { return "/brand/getSug"; }

	[JsonPropertyName("query")]
	[Description("前缀匹配的品牌名")]
	[NotNull]
	public string Query { get; set; }

	[JsonPropertyName("user_id")]
	[Description("用户ID，可用默认值0")]
	[NotNull]
	public long? UserId { get; set; }

	[JsonPropertyName("filter_info")]
	[Description("过滤用参数，不填则是全量召回")]
	public FilterInfoItem FilterInfo { get; set; }

	public class FilterInfoItem
	{
		[JsonPropertyName("brand_ids")]
		[Description("品牌ids")]
		public List<long> BrandIds { get; set; }

		[JsonPropertyName("brand_category")]
		[Description("品牌类别")]
		public List<long> BrandCategory { get; set; }

		[JsonPropertyName("status")]
		[Description("品牌状态: 1.在线 2.离线")]
		public long? Status { get; set; }

		[JsonPropertyName("related_ids")]
		[Description("品牌商标关联Id")]
		public List<long> RelatedIds { get; set; }

		[JsonPropertyName("trade_mark_ids")]
		[Description("商标IDs")]
		public List<string> TradeMarkIds { get; set; }

		[JsonPropertyName("audit_status")]
		[Description("废弃字段，请勿填写: 1. 审核中 2. 审核通过 3. 审核拒绝 4. 送审失败")]
		public List<int> AuditStatus { get; set; }
	}

	[JsonPropertyName("read_old")]
	[Description("是否读取老数据 默认为false")]
	[NotNull]
	public bool? ReadOld { get; set; }

	[JsonPropertyName("biz_types")]
	[Description("业务线类型: 0. 国内品牌 1. 跨境品牌 3. 广告")]
	[NotNull]
	public List<int> BizTypes { get; set; }

	[JsonPropertyName("enable_deduplicate")]
	[Description("是否去重，一般选择true")]
	[NotNull]
	public bool? EnableDeduplicate { get; set; }

	[JsonPropertyName("extra_config")]
	[Description("额外配置，无特殊需求请按描述填写")]
	public ExtraConfigItem ExtraConfig { get; set; }

	public class ExtraConfigItem
	{
		[JsonPropertyName("use_origin_brand_info")]
		[Description("是否忽略去重 使用原始品牌信息，默认取false")]
		public bool? UseOriginBrandInfo { get; set; }

		[JsonPropertyName("use_brand_info")]
		[Description("是否忽略新旧映射 使用老品牌信息，默认取false")]
		public bool? UseBrandInfo { get; set; }

		[JsonPropertyName("use_brand_name_deduplicate")]
		[Description("使用品牌名去重，需要和抖店一致请取true")]
		public bool? UseBrandNameDeduplicate { get; set; }
	}
}

[Description("通过输入品牌名称进行模糊查询，支持品牌中文名(拼音)、英文名，并返回品牌信息,本接口适用于通过前缀匹配的形式对品牌信息，例如想要“安踏”，可以通过搜索“安”来查询，但是搜索“踏”是无法找到的。,注意点：1. 召回的第一个为品牌名称严格匹配项。,2. 单次召回数量最多为10个。,3. 支持中文名称或英文名称，但不可以两个名称一起输入来查询,4. 不支持特殊符号，例如“/”，“ ”，“·”，以及除中英文外的语言")]
public class BrandGetSugRsp
{
	[JsonPropertyName("sug_list")]
	[Description("品牌信息列表")]
	public List<SugListItem> SugList { get; set; }

	public class SugListItem
	{
		[JsonPropertyName("brand_id")]
		[Description("品牌ID")]
		public long BrandId { get; set; }

		[JsonPropertyName("brand_name_c_n")]
		[Description("品牌中文名")]
		public string BrandNameCN { get; set; }

		[JsonPropertyName("brand_name_e_n")]
		[Description("品牌英文名")]
		public string BrandNameEN { get; set; }

		[JsonPropertyName("level")]
		[Description("品牌等级")]
		public int Level { get; set; }

		[JsonPropertyName("status")]
		[Description("品牌状态：在线")]
		public int Status { get; set; }

		[JsonPropertyName("brand_alias")]
		[Description("品牌别名")]
		public List<string> BrandAlias { get; set; }

		[JsonPropertyName("create_timestamp")]
		[Description("创建时间")]
		public long CreateTimestamp { get; set; }

		[JsonPropertyName("update_timestamp")]
		[Description("修改时间")]
		public long UpdateTimestamp { get; set; }

		[JsonPropertyName("audit_status")]
		[Description("审核情况 1. 审核中 2. 审核通过 3. 审核拒绝 4. 送审失败")]
		public int AuditStatus { get; set; }

		[JsonPropertyName("biz_type")]
		[Description("业务线类型: 0. 国内品牌 1. 跨境品牌 3. 广告")]
		public int BizType { get; set; }

		[JsonPropertyName("logo")]
		[Description("品牌logo")]
		public string Logo { get; set; }

		[JsonPropertyName("extra")]
		[Description("额外信息")]
		public Dictionary<string,string> Extra { get; set; }
	}
}
