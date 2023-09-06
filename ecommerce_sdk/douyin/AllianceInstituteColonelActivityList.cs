namespace ecommerce.sdk.douyin;

[Description("本接口用于获取机构创建的团长活动列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","根据接口文档检查下入参是否合法")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务内部错误，稍候再试")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
public class AllianceInstituteColonelActivityListReq : IDouyinReq<AllianceInstituteColonelActivityListRsp>
{

	public string GetMethod() { return "alliance.instituteColonelActivityList"; }

	public string GetUrl() { return "/alliance/instituteColonelActivityList"; }

	[JsonPropertyName("status")]
	[Description("活动状态。0：任意状态； 1：未上线； 2：报名未开始； 3：报名中； 4：推广未开始； 5：推广中； 7：报名结束")]
	[NotNull]
	public int? Status { get; set; }

	[JsonPropertyName("search_type")]
	[Description("排序选项，0:创建时间； 1:活动报名开始时间排序；2:活动报名结束时间排序")]
	[NotNull]
	public long? SearchType { get; set; }

	[JsonPropertyName("sort_type")]
	[Description("排序顺序, 0：升序；1：降序")]
	[NotNull]
	public long? SortType { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，从1开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页数量（最大20）")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("activity_info")]
	[Description("活动信息，支持通过活动ID和活动名称搜索")]
	public string ActivityInfo { get; set; }
}

[Description("本接口用于获取机构创建的团长活动列表")]
public class AllianceInstituteColonelActivityListRsp
{
	[JsonPropertyName("institution_id")]
	[Description("机构ID")]
	public long InstitutionId { get; set; }

	[JsonPropertyName("total")]
	[Description("活动条数")]
	public long Total { get; set; }

	[JsonPropertyName("activity_list")]
	[Description("活动列表")]
	public List<ActivityListItem> ActivityList { get; set; }

	public class ActivityListItem
	{
		[JsonPropertyName("activity_id")]
		[Description("活动ID")]
		public long ActivityId { get; set; }

		[JsonPropertyName("activity_name")]
		[Description("活动名称")]
		public string ActivityName { get; set; }

		[JsonPropertyName("activity_start_time")]
		[Description("活动开始时间")]
		public string ActivityStartTime { get; set; }

		[JsonPropertyName("activity_end_time")]
		[Description("活动结束时间")]
		public string ActivityEndTime { get; set; }

		[JsonPropertyName("status")]
		[Description("活动状态，1:未上线；2:报名未开始；3:报名中；4:推广未开始；5:推广中；7:报名结束")]
		public int Status { get; set; }

		[JsonPropertyName("application_start_time")]
		[Description("活动报名开始时间")]
		public string ApplicationStartTime { get; set; }

		[JsonPropertyName("application_end_time")]
		[Description("活动报名结束时间")]
		public string ApplicationEndTime { get; set; }

		[JsonPropertyName("categories_limit")]
		[Description("行业类目限制")]
		public Dictionary<long,string> CategoriesLimit { get; set; }
	}

	[JsonPropertyName("colonel_buyin_id")]
	[Description("团长百应ID")]
	public long ColonelBuyinId { get; set; }
}
