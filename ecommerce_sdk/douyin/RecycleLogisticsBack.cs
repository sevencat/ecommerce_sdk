namespace ecommerce.sdk.douyin;

[Description("回收商退货发货,回收商退货发货")]
public class RecycleLogisticsBackReq : IDouyinReq<RecycleLogisticsBackRsp>
{

	public string GetMethod() { return "recycle.logisticsBack"; }

	public string GetUrl() { return "/recycle/logisticsBack"; }

	[JsonPropertyName("clue_order_id")]
	[Description("线索单id")]
	[NotNull]
	public long? ClueOrderId { get; set; }

	[JsonPropertyName("company")]
	[Description("物流公司")]
	[NotNull]
	public string Company { get; set; }

	[JsonPropertyName("company_code")]
	[Description("物流公司编码")]
	[NotNull]
	public string CompanyCode { get; set; }

	[JsonPropertyName("logistics_code")]
	[Description("SF00000003")]
	[NotNull]
	public string LogisticsCode { get; set; }
}

[Description("回收商退货发货,回收商退货发货")]
public class RecycleLogisticsBackRsp
{
	[JsonPropertyName("success")]
	[Description("是否成功")]
	public string Success { get; set; }

	[JsonPropertyName("err_no")]
	[Description("10002")]
	public string ErrNo { get; set; }
}
