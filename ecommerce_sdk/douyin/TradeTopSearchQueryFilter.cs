namespace ecommerce.sdk.douyin;

[Description("商家编辑商品时，根据商家自填的标题、属性、商详等信息，对TopSearchQueryPredict接口生成的推荐词进行过滤和新增，避免推荐词与已有标题重复、与自填属性冲突等问题。")]
public class TradeTopSearchQueryFilterReq : IDouyinReq<TradeTopSearchQueryFilterRsp>
{

	public string GetMethod() { return "trade.TopSearchQueryFilter"; }

	public string GetUrl() { return "/trade/TopSearchQueryFilter"; }

	[JsonPropertyName("query")]
	[Description("根据TopSearchQueryPredict接口获取推荐热搜词列表")]
	[NotNull]
	public List<string> Query { get; set; }

	[JsonPropertyName("category_id")]
	[Description("叶子类目ID")]
	[NotNull]
	public long? CategoryId { get; set; }

	[JsonPropertyName("title")]
	[Description("标题名称")]
	[NotNull]
	public string Title { get; set; }

	[JsonPropertyName("attr")]
	[Description("key:自填属性项ID, value:自填属性值列表")]
	[NotNull]
	public Dictionary<long,object> Attr { get; set; }

	[JsonPropertyName("ocr_text")]
	[Description("商详图抽取OCR文字列表")]
	[NotNull]
	public List<string> OcrText { get; set; }
}

[Description("商家编辑商品时，根据商家自填的标题、属性、商详等信息，对TopSearchQueryPredict接口生成的推荐词进行过滤和新增，避免推荐词与已有标题重复、与自填属性冲突等问题。")]
public class TradeTopSearchQueryFilterRsp
{
	[JsonPropertyName("result")]
	[Description("过滤后热搜词结果")]
	public List<string> Result { get; set; }
}
