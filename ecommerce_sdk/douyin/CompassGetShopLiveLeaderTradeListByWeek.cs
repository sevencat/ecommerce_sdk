namespace ecommerce.sdk.douyin;

[Description("根据行业类目获取罗盘周维度的品牌自播直播交易榜（top200），根据区间参数返回榜单中位于查询区间的直播间列表；同时返回榜单中根据飙升幅度排序后的直播间列表。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","请求参数非法","isv.parameter-invalid:100003","当前只透出top11~30的榜单，请检查请求参数")]
[DouyinRetCode(10001,"请求部分失败","请求下游部分失败","isv.business-part-failed:200001","重试")]
public class CompassGetShopLiveLeaderTradeListByWeekReq : IDouyinReq<CompassGetShopLiveLeaderTradeListByWeekRsp>
{

	public string GetMethod() { return "compass.getShopLiveLeaderTradeListByWeek"; }

	public string GetUrl() { return "/compass/getShopLiveLeaderTradeListByWeek"; }

	[JsonPropertyName("industry_id")]
	[Description("行业大类id")]
	[NotNull]
	public long? IndustryId { get; set; }

	[JsonPropertyName("first_cate_id")]
	[Description("一级类目id")]
	[NotNull]
	public long? FirstCateId { get; set; }

	[JsonPropertyName("begin_time")]
	[Description("查询周的周一时间戳 (一周结束后才有周榜，例如1月23日～1月29日的周榜数据，要等本周结束且1月30日的离线任务结束后才会有数据。所以1月23日～1月29日的周榜数据，要到1月30日10:00后才能请求获取，测试begin_time=1月23日时间戳)")]
	[NotNull]
	public long? BeginTime { get; set; }

	[JsonPropertyName("top_start")]
	[Description("区间开始值，当前区间限制为11～30（若获取榜单11～25名,则top_start=11，top_end=25）")]
	[NotNull]
	public long? TopStart { get; set; }

	[JsonPropertyName("top_end")]
	[Description("区间开始值，当前区间限制为11～30（若获取榜单11～25名,则top_start=11，top_end=25）")]
	[NotNull]
	public long? TopEnd { get; set; }
}

[Description("根据行业类目获取罗盘周维度的品牌自播直播交易榜（top200），根据区间参数返回榜单中位于查询区间的直播间列表；同时返回榜单中根据飙升幅度排序后的直播间列表。")]
public class CompassGetShopLiveLeaderTradeListByWeekRsp
{
	[JsonPropertyName("trade_board_list")]
	[Description("位于区间的交易榜单")]
	public List<TradeBoardListItem> TradeBoardList { get; set; }

	public class TradeBoardListItem
	{
		[JsonPropertyName("author_id")]
		[Description("开播达人id")]
		public long AuthorId { get; set; }

		[JsonPropertyName("nick_name")]
		[Description("开播达人昵称")]
		public string NickName { get; set; }

		[JsonPropertyName("live_start_ts")]
		[Description("开播时间（时间戳：秒）")]
		public long LiveStartTs { get; set; }

		[JsonPropertyName("fans_ucnt_p1d")]
		[Description("开播时粉丝数")]
		public long FansUcntP1d { get; set; }
	}

	[JsonPropertyName("improve_board_list")]
	[Description("位于区间的飙升榜单")]
	public List<ImproveBoardListItem> ImproveBoardList { get; set; }

	public class ImproveBoardListItem
	{
		[JsonPropertyName("author_id")]
		[Description("开播达人id")]
		public long AuthorId { get; set; }

		[JsonPropertyName("nick_name")]
		[Description("开播达人昵称")]
		public string NickName { get; set; }

		[JsonPropertyName("live_start_ts")]
		[Description("开播时间（时间戳：秒）")]
		public long LiveStartTs { get; set; }

		[JsonPropertyName("fans_ucnt_p1d")]
		[Description("开播时粉丝数")]
		public long FansUcntP1d { get; set; }
	}
}
