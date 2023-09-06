namespace ecommerce.sdk.douyin;

[Description("商家绑定前置质检订单的质检码，绑定过后可以发货。 对于单库存商品，系统后台自动绑定。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:-1","重试")]
public class BtasSellerBindOrderCodeWithPreInspectionCodeReq : IDouyinReq<BtasSellerBindOrderCodeWithPreInspectionCodeRsp>
{

	public string GetMethod() { return "btas.SellerBindOrderCodeWithPreInspectionCode"; }

	public string GetUrl() { return "/btas/SellerBindOrderCodeWithPreInspectionCode"; }

	[JsonPropertyName("order_code")]
	[Description("订单码")]
	[NotNull]
	public string OrderCode { get; set; }

	[JsonPropertyName("inspection_code")]
	[Description("质检证书编号，仅字母数字")]
	[NotNull]
	public string InspectionCode { get; set; }

	[JsonPropertyName("inspection_sc_id")]
	[Description("质检机构ID")]
	[NotNull]
	public long? InspectionScId { get; set; }
}

[Description("商家绑定前置质检订单的质检码，绑定过后可以发货。 对于单库存商品，系统后台自动绑定。")]
public class BtasSellerBindOrderCodeWithPreInspectionCodeRsp
{
}
