namespace ecommerce.sdk.douyin;

[Description("回收商在用户确认前调整报价接口,回收商在用户确认前调整报价接口")]
public class RecycleChangePriceReq : IDouyinReq<RecycleChangePriceRsp>
{

	public string GetMethod() { return "recycle.changePrice"; }

	public string GetUrl() { return "/recycle/changePrice"; }

	[JsonPropertyName("clue_order_id")]
	[Description("线索单id")]
	[NotNull]
	public long? ClueOrderId { get; set; }

	[JsonPropertyName("recycle_price")]
	[Description("回收价格")]
	[NotNull]
	public long? RecyclePrice { get; set; }

	[JsonPropertyName("consignment_price")]
	[Description("寄卖价格")]
	[NotNull]
	public long? ConsignmentPrice { get; set; }
}

[Description("回收商在用户确认前调整报价接口,回收商在用户确认前调整报价接口")]
public class RecycleChangePriceRsp
{
}
