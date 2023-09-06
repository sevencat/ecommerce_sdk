namespace ecommerce.sdk.douyin;

[Description("查询渠道商品绑定的达人列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","非法渠道信息","isv.parameter-invalid:4371","非法渠道信息")]
[DouyinRetCode(40004,"非法的参数","参数校验失败: 无效分页大小","isv.parameter-invalid:4097","参数校验失败: 无效分页大小")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","非法渠道/未查到该渠道达人信息","isv.parameter-invalid:4369","非法渠道/未查到该渠道达人信息")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","当前商品推广未开启，请更换商品推广","isv.parameter-invalid:1069","当前商品推广未开启，请更换商品推广")]
public class BuyinChannelBindAuthorsReq : IDouyinReq<BuyinChannelBindAuthorsRsp>
{

	public string GetMethod() { return "buyin.channelBindAuthors"; }

	public string GetUrl() { return "/buyin/channelBindAuthors"; }

	[JsonPropertyName("channel_id")]
	[Description("渠道id")]
	[NotNull]
	public long? ChannelId { get; set; }

	[JsonPropertyName("channel_type")]
	[Description("渠道绑定类型 1: 店铺自卖，2：达人带货")]
	[NotNull]
	public int? ChannelType { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品id")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("page")]
	[Description("分页 从1开始")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("分页大小 最大值50")]
	public long? PageSize { get; set; }
}

[Description("查询渠道商品绑定的达人列表")]
public class BuyinChannelBindAuthorsRsp
{
	[JsonPropertyName("is_all")]
	[Description("是否绑定了全部达人/全部店播达人")]
	public bool IsAll { get; set; }

	[JsonPropertyName("total")]
	[Description("绑定的达人数量")]
	public long Total { get; set; }

	[JsonPropertyName("authors")]
	[Description("绑定的达人信息")]
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
