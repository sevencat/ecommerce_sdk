namespace ecommerce.sdk.douyin;

[Description("抖客查询开通直播间分销业务的达人列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","无效分页大小","isv.parameter-invalid:4097","无效分页大小")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","需【抖客】角色授权后访问","isv.business-failed:4198","需【抖客】角色授权后访问")]
public class BuyinLiveShareMaterialReq : IDouyinReq<BuyinLiveShareMaterialRsp>
{

	public string GetMethod() { return "buyin.liveShareMaterial"; }

	public string GetUrl() { return "/buyin/liveShareMaterial"; }

	[JsonPropertyName("author_type")]
	[Description("1 品牌 2 达人(默认值)")]
	public int? AuthorType { get; set; }

	[JsonPropertyName("author_levels")]
	[Description("作者电商等级，0-7级")]
	public List<int> AuthorLevels { get; set; }

	[JsonPropertyName("frist_cids")]
	[Description("商品行业类目，列表类型；使用【/alliance/activityProductCategoryList】接口获取")]
	public List<string> FristCids { get; set; }

	[JsonPropertyName("author_info")]
	[Description("达人昵称或者账号")]
	public string AuthorInfo { get; set; }

	[JsonPropertyName("page")]
	[Description("分页，1开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("分页大小")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("sort_by")]
	[Description("排序字段: 1-综合；2-销量；3-佣金率；4-粉丝数")]
	public int? SortBy { get; set; }

	[JsonPropertyName("sort_type")]
	[Description("排序方式：0-降序；1-升序")]
	public int? SortType { get; set; }

	[JsonPropertyName("live_status")]
	[Description("开关播状态：0:所有，1:开播，2:关播")]
	public long? LiveStatus { get; set; }
}

[Description("抖客查询开通直播间分销业务的达人列表")]
public class BuyinLiveShareMaterialRsp
{
	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }

	[JsonPropertyName("data")]
	[Description("列表")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("author_openid")]
		[Description("达人open_id（该字段废弃使用，请使用buyin_id）")]
		public string AuthorOpenid { get; set; }

		[JsonPropertyName("author_name")]
		[Description("达人昵称")]
		public string AuthorName { get; set; }

		[JsonPropertyName("author_pic")]
		[Description("头像")]
		public string AuthorPic { get; set; }

		[JsonPropertyName("author_level")]
		[Description("达人等级")]
		public long AuthorLevel { get; set; }

		[JsonPropertyName("product_category")]
		[Description("商品类别")]
		public List<string> ProductCategory { get; set; }

		[JsonPropertyName("province")]
		[Description("作者省份")]
		public string Province { get; set; }

		[JsonPropertyName("city")]
		[Description("作者城市")]
		public string City { get; set; }

		[JsonPropertyName("average_gmv")]
		[Description("场均gmv")]
		public string AverageGmv { get; set; }

		[JsonPropertyName("fans_num")]
		[Description("粉丝数量")]
		public long FansNum { get; set; }

		[JsonPropertyName("average_commission_rate")]
		[Description("平均佣金率")]
		public string AverageCommissionRate { get; set; }

		[JsonPropertyName("room_id")]
		[Description("直播间id")]
		public string RoomId { get; set; }

		[JsonPropertyName("is_live")]
		[Description("正在直播")]
		public bool IsLive { get; set; }

		[JsonPropertyName("is_ecom")]
		[Description("正在带货直播")]
		public bool IsEcom { get; set; }

		[JsonPropertyName("gender")]
		[Description("性别 male/ female/ 未知")]
		public string Gender { get; set; }

		[JsonPropertyName("buyin_id")]
		[Description("主播百应ID")]
		public string BuyinId { get; set; }

		[JsonPropertyName("live_preview_auth")]
		[Description("该达人是否开通了直播预告权限")]
		public bool LivePreviewAuth { get; set; }

		[JsonPropertyName("has_redpack")]
		[Description("该达人是否配置了生效中的抖客红包")]
		public bool HasRedpack { get; set; }
	}
}
