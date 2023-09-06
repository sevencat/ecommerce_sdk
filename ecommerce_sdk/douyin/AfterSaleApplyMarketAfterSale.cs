namespace ecommerce.sdk.douyin;

[Description("超市申请缺重/缺货")]
public class AfterSaleApplyMarketAfterSaleReq : IDouyinReq<AfterSaleApplyMarketAfterSaleRsp>
{

	public string GetMethod() { return "afterSale.ApplyMarketAfterSale"; }

	public string GetUrl() { return "/afterSale/ApplyMarketAfterSale"; }

	[JsonPropertyName("sku_order_id")]
	[Description("商品单订单ID")]
	[NotNull]
	public long? SkuOrderId { get; set; }

	[JsonPropertyName("miss_gram")]
	[Description("缺重克数，非缺重场景不传；单位 毫克")]
	public long? MissGram { get; set; }

	[JsonPropertyName("refund_amount")]
	[Description("退款金额，单位分。 只缺重有效，缺货/拒签场景由系统计费算出。 最多不会超过订单金额")]
	public long? RefundAmount { get; set; }

	[JsonPropertyName("item_count")]
	[Description("退款金额如果传了，就按传的金额退；不传由平台根据件数来分摊计算（特别注只有整单退才会退运费，否则运费不退；缺货暂时不支持按件数退，只能整单退；）")]
	public long? ItemCount { get; set; }

	[JsonPropertyName("after_sale_reason")]
	[Description("售后原因枚举 MissGram = 1缺重，必传克数、金额； MissItem = 2缺货，只支持整单退； RefuseSign = 3 拒收，支持按件数退，金额由抖音计算")]
	[NotNull]
	public int? AfterSaleReason { get; set; }

	[JsonPropertyName("store_id")]
	[Description("门店ID，传了就做检验，不传默认通过，由isv自行保证权限")]
	public long? StoreId { get; set; }
}

[Description("超市申请缺重/缺货")]
public class AfterSaleApplyMarketAfterSaleRsp
{
	[JsonPropertyName("after_sale_id")]
	[Description("售后ID")]
	public string AfterSaleId { get; set; }
}
