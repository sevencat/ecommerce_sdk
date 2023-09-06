namespace ecommerce.sdk.douyin;

[Description("该接口用于获取活动页物料列表，需要获取抖客授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效活动状态","isv.parameter-invalid:4412","无效活动状态")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
public class BuyinDoukeActivityMaterialListReq : IDouyinReq<BuyinDoukeActivityMaterialListRsp>
{

	public string GetMethod() { return "buyin.doukeActivityMaterialList"; }

	public string GetUrl() { return "/buyin/doukeActivityMaterialList"; }

	[JsonPropertyName("page")]
	[Description("分页（从1开始）")]
	[NotNull]
	public int? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页的数量（小于等于20）")]
	[NotNull]
	public int? PageSize { get; set; }

	[JsonPropertyName("activity_status")]
	[Description("活动状态（不填默认返回进行中活动，1:待开始，2:进行中，3: 已结束）")]
	public int? ActivityStatus { get; set; }
}

[Description("该接口用于获取活动页物料列表，需要获取抖客授权")]
public class BuyinDoukeActivityMaterialListRsp
{
	[JsonPropertyName("activity_material_list")]
	[Description("活动页物料列表")]
	public List<ActivityMaterialListItem> ActivityMaterialList { get; set; }

	public class ActivityMaterialListItem
	{
		[JsonPropertyName("activity_main_cover")]
		[Description("活动主图")]
		public string ActivityMainCover { get; set; }

		[JsonPropertyName("activity_promotion_cover")]
		[Description("活动推广配图")]
		public string ActivityPromotionCover { get; set; }

		[JsonPropertyName("activity_preview_cover")]
		[Description("活动预览图")]
		public string ActivityPreviewCover { get; set; }

		[JsonPropertyName("activity_promotion_asset")]
		[Description("活动推广素材")]
		public string ActivityPromotionAsset { get; set; }

		[JsonPropertyName("activity_type")]
		[Description("活动类型，0:频道活动，1:营销活动")]
		public string ActivityType { get; set; }

		[JsonPropertyName("activity_id")]
		[Description("活动ID")]
		public string ActivityId { get; set; }

		[JsonPropertyName("material_id")]
		[Description("活动页物料ID")]
		public long MaterialId { get; set; }

		[JsonPropertyName("activity_name")]
		[Description("活动名称")]
		public string ActivityName { get; set; }

		[JsonPropertyName("activity_validity_type")]
		[Description("活动有效类型（0:短期（限时）活动，1:长期活动）")]
		public int ActivityValidityType { get; set; }

		[JsonPropertyName("start_time")]
		[Description("短期（限时）活动开始时间")]
		public long StartTime { get; set; }

		[JsonPropertyName("end_time")]
		[Description("短期（限时）活动结束时间")]
		public long EndTime { get; set; }

		[JsonPropertyName("activity_rule")]
		[Description("推广规则")]
		public string ActivityRule { get; set; }

		[JsonPropertyName("activity_rule_link")]
		[Description("活动推广规则详情链接")]
		public string ActivityRuleLink { get; set; }

		[JsonPropertyName("activity_status")]
		[Description("活动状态（1:待开始，2:进行中，3: 已结束）")]
		public int ActivityStatus { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("活动页物料总数")]
	public long Total { get; set; }
}
