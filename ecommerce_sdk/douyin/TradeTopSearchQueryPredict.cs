namespace ecommerce.sdk.douyin;

[Description("商家发布商品时，根据上传主图进行热搜词推荐，帮助商家标题填写，提升商品曝光及GMV；,接口申请条件：该能力仅限微应用场景开放，如您想作为微应用开发者对接，可联系您的类目运营。详见：https://op.jinritemai.com/docs/mona-docs/1186/2728")]
public class TradeTopSearchQueryPredictReq : IDouyinReq<TradeTopSearchQueryPredictRsp>
{

	public string GetMethod() { return "trade.TopSearchQueryPredict"; }

	public string GetUrl() { return "/trade/TopSearchQueryPredict"; }

	[JsonPropertyName("category_id")]
	[Description("叶子类目ID；通过【/shop/getShopCategory】接口获取，填写错误id接口返回为空。")]
	public long? CategoryId { get; set; }

	[JsonPropertyName("image")]
	[Description("首图信息")]
	public ImageItem Image { get; set; }

	public class ImageItem
	{
		[JsonPropertyName("image_url")]
		[Description("首图url，url公网可访问地址即可。")]
		public string ImageUrl { get; set; }
	}
}

[Description("商家发布商品时，根据上传主图进行热搜词推荐，帮助商家标题填写，提升商品曝光及GMV；,接口申请条件：该能力仅限微应用场景开放，如您想作为微应用开发者对接，可联系您的类目运营。详见：https://op.jinritemai.com/docs/mona-docs/1186/2728")]
public class TradeTopSearchQueryPredictRsp
{
	[JsonPropertyName("result")]
	[Description("推荐热搜词")]
	public List<string> Result { get; set; }
}
