namespace ecommerce.sdk.douyin;

[Description("查询店铺可绑定渠道品的自播达人帐号，包括官方帐号和渠道授权帐号")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效分页参数","isv.parameter-invalid:4141","无效分页参数")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
public class BuyinQueryShopSelfAuthorsReq : IDouyinReq<BuyinQueryShopSelfAuthorsRsp>
{

	public string GetMethod() { return "buyin.queryShopSelfAuthors"; }

	public string GetUrl() { return "/buyin/queryShopSelfAuthors"; }

	[JsonPropertyName("page")]
	[Description("分页 从1开始")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("分页大小 最大20")]
	public long? PageSize { get; set; }
}

[Description("查询店铺可绑定渠道品的自播达人帐号，包括官方帐号和渠道授权帐号")]
public class BuyinQueryShopSelfAuthorsRsp
{
	[JsonPropertyName("total")]
	[Description("总数量")]
	public long Total { get; set; }

	[JsonPropertyName("authors")]
	[Description("达人信息")]
	public List<AuthorsItem> Authors { get; set; }

	public class AuthorsItem
	{
		[JsonPropertyName("author_app")]
		[Description("达人帐号的客户端,1128：抖音,2329：抖音极速版,1112：火山,13：头条")]
		public long AuthorApp { get; set; }

		[JsonPropertyName("author_id")]
		[Description("达人uid")]
		public long AuthorId { get; set; }

		[JsonPropertyName("author_type")]
		[Description("0:店铺官方帐号 1:店铺渠道授权帐号 2: 普通达人帐号")]
		public int AuthorType { get; set; }

		[JsonPropertyName("buyin_id")]
		[Description("达人的百应id")]
		public long BuyinId { get; set; }

		[JsonPropertyName("account_name")]
		[Description("账户名称")]
		public string AccountName { get; set; }

		[JsonPropertyName("avatar_url")]
		[Description("达人头像")]
		public string AvatarUrl { get; set; }
	}
}
