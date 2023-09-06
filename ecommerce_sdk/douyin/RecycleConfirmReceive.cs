namespace ecommerce.sdk.douyin;

[Description("回收商确认收货操作,回收商确认收货操作")]
public class RecycleConfirmReceiveReq : IDouyinReq<RecycleConfirmReceiveRsp>
{

	public string GetMethod() { return "recycle.confirmReceive"; }

	public string GetUrl() { return "/recycle/confirmReceive"; }

	[JsonPropertyName("clue_order_id")]
	[Description("线索单id")]
	[NotNull]
	public long? ClueOrderId { get; set; }
}

[Description("回收商确认收货操作,回收商确认收货操作")]
public class RecycleConfirmReceiveRsp
{
}
