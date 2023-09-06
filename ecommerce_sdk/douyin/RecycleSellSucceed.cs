namespace ecommerce.sdk.douyin;

[Description("寄售成功,寄售成功")]
public class RecycleSellSucceedReq : IDouyinReq<RecycleSellSucceedRsp>
{

	public string GetMethod() { return "recycle.sellSucceed"; }

	public string GetUrl() { return "/recycle/sellSucceed"; }

	[JsonPropertyName("clue_order_id")]
	[Description("线索单id")]
	[NotNull]
	public long? ClueOrderId { get; set; }
}

[Description("寄售成功,寄售成功")]
public class RecycleSellSucceedRsp
{
}
