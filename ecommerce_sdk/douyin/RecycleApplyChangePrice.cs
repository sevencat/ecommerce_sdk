namespace ecommerce.sdk.douyin;

[Description("回收商申请调价,回收商申请调价")]
public class RecycleApplyChangePriceReq : IDouyinReq<RecycleApplyChangePriceRsp>
{

	public string GetMethod() { return "recycle.applyChangePrice"; }

	public string GetUrl() { return "/recycle/applyChangePrice"; }

	[JsonPropertyName("clue_order_id")]
	[Description("线索单id")]
	[NotNull]
	public long? ClueOrderId { get; set; }

	[JsonPropertyName("price")]
	[Description("价格")]
	[NotNull]
	public long? Price { get; set; }
}

[Description("回收商申请调价,回收商申请调价")]
public class RecycleApplyChangePriceRsp
{
	[JsonPropertyName("message")]
	[Description("错误信息")]
	public string Message { get; set; }

	[JsonPropertyName("err_no")]
	[Description("错误代码")]
	public long ErrNo { get; set; }
}
