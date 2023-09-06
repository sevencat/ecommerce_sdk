namespace ecommerce.sdk.douyin;

[Description("查询定向计划作者列表,查询定向计划作者列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效定向计划ID","isv.parameter-invalid:4114","无效定向计划ID")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
public class BuyinOrienPlanAuthorsReq : IDouyinReq<BuyinOrienPlanAuthorsRsp>
{

	public string GetMethod() { return "buyin.orienPlanAuthors"; }

	public string GetUrl() { return "/buyin/orienPlanAuthors"; }

	[JsonPropertyName("orien_plan_id")]
	[Description("按定向计划ID搜索")]
	[NotNull]
	public string OrienPlanId { get; set; }

	[JsonPropertyName("page")]
	[Description("分页，默认 1")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页数目，最大40，默认20")]
	public long? PageSize { get; set; }

	[JsonPropertyName("audit_status")]
	[Description("1 生效中(默认)  2 待审核 3 审核拒绝")]
	public int? AuditStatus { get; set; }

	[JsonPropertyName("user_name")]
	[Description("按达人昵称搜索")]
	public string UserName { get; set; }

	[JsonPropertyName("buyin_id")]
	[Description("按达人百应ID搜索")]
	public long? BuyinId { get; set; }
}

[Description("查询定向计划作者列表,查询定向计划作者列表")]
public class BuyinOrienPlanAuthorsRsp
{
	[JsonPropertyName("total")]
	[Description("商品定向计划作者数")]
	public long Total { get; set; }

	[JsonPropertyName("orien_plan_authors")]
	[Description("商品定向计划作者列表")]
	public List<OrienPlanAuthorsItem> OrienPlanAuthors { get; set; }

	public class OrienPlanAuthorsItem
	{
		[JsonPropertyName("apply_id")]
		[Description("申请 ID")]
		public long ApplyId { get; set; }

		[JsonPropertyName("orien_plan_id")]
		[Description("定向计划ID")]
		public string OrienPlanId { get; set; }

		[JsonPropertyName("buyin_id")]
		[Description("达人buyin ID")]
		public long BuyinId { get; set; }

		[JsonPropertyName("user_name")]
		[Description("达人昵称")]
		public string UserName { get; set; }

		[JsonPropertyName("apply_time")]
		[Description("申请时间戳")]
		public long ApplyTime { get; set; }

		[JsonPropertyName("apply_suc_time")]
		[Description("申请通过时间戳")]
		public long ApplySucTime { get; set; }

		[JsonPropertyName("audit_status")]
		[Description("1 生效中  2 待审核 3 审核拒绝")]
		public int AuditStatus { get; set; }

		[JsonPropertyName("apply_info")]
		[Description("申请信息")]
		public string ApplyInfo { get; set; }

		[JsonPropertyName("contact_phone")]
		[Description("联系方式")]
		public string ContactPhone { get; set; }

		[JsonPropertyName("end_time")]
		[Description("达人移除时间（商家未修改时和计划结束时间一致）")]
		public long EndTime { get; set; }
	}
}
