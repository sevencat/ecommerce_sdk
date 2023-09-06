namespace ecommerce.sdk.douyin;

[Description("支持一级团长查询商家侧延长活动时间申请的处理结果")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
public class BuyinColonelExtendApplyListReq : IDouyinReq<BuyinColonelExtendApplyListRsp>
{

	public string GetMethod() { return "buyin.colonelExtendApplyList"; }

	public string GetUrl() { return "/buyin/colonelExtendApplyList"; }

	[JsonPropertyName("activity_id")]
	[Description("活动 id")]
	public long? ActivityId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品 id")]
	public long? ProductId { get; set; }

	[JsonPropertyName("status")]
	[Description("状态：1-待审核,2-商家同意,3-商家拒绝,4-自动拒绝（如果状态列表有1，则只查询待审核的延长申请，没有1，则查询所有传入状态的延长申请）")]
	[NotNull]
	public List<long> Status { get; set; }

	[JsonPropertyName("page")]
	[Description("页码（默认1）")]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页条数（默认20，最大20）")]
	public long? Size { get; set; }
}

[Description("支持一级团长查询商家侧延长活动时间申请的处理结果")]
public class BuyinColonelExtendApplyListRsp
{
	[JsonPropertyName("extend_applies")]
	[Description("延长申请列表")]
	public List<ExtendAppliesItem> ExtendApplies { get; set; }

	public class ExtendAppliesItem
	{
		[JsonPropertyName("activity_id")]
		[Description("团长活动 id")]
		public long ActivityId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品 id")]
		public long ProductId { get; set; }

		[JsonPropertyName("product_name")]
		[Description("商品名称")]
		public string ProductName { get; set; }

		[JsonPropertyName("product_img")]
		[Description("商品图片")]
		public string ProductImg { get; set; }

		[JsonPropertyName("status")]
		[Description("延长申请状态(1-待审核,2-商家同意,3-商家拒绝,4-自动拒绝)")]
		public long Status { get; set; }

		[JsonPropertyName("end_time")]
		[Description("推广结束时间")]
		public string EndTime { get; set; }

		[JsonPropertyName("origin_buyin_id")]
		[Description("原始团长 buyin_id")]
		public long OriginBuyinId { get; set; }

		[JsonPropertyName("origin_activity_id")]
		[Description("原始活动 id")]
		public long OriginActivityId { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public string UpdateTime { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
