namespace ecommerce.sdk.douyin;

[Description("回传质检通过和价格,回传质检通过和价格")]
public class RecycleQualityTestingResultReq : IDouyinReq<RecycleQualityTestingResultRsp>
{

	public string GetMethod() { return "recycle.qualityTestingResult"; }

	public string GetUrl() { return "/recycle/qualityTestingResult"; }

	[JsonPropertyName("recycle_price")]
	[Description("回收价")]
	public long? RecyclePrice { get; set; }

	[JsonPropertyName("consignment_price")]
	[Description("寄卖价")]
	public long? ConsignmentPrice { get; set; }

	[JsonPropertyName("clue_order_id")]
	[Description("回收订单ID")]
	[NotNull]
	public long? ClueOrderId { get; set; }

	[JsonPropertyName("is_passed")]
	[Description("是否通过 1: 通过 2:不通过")]
	[NotNull]
	public long? IsPassed { get; set; }

	[JsonPropertyName("failed_reason")]
	[Description("不通过必传 不通过理由 1 货品成色太差； 2 货品与线索单不一致；  3 货品为假； 4 协商一致退货； 5 其他。")]
	public long? FailedReason { get; set; }
}

[Description("回传质检通过和价格,回传质检通过和价格")]
public class RecycleQualityTestingResultRsp
{
}
