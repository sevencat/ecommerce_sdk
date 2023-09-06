namespace ecommerce.sdk.douyin;

[Description("此接口用来帮助商家进行延时收货，商家可以在还有2天到期的时间进行操作，会在原有剩余时间的基础上增加7天。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","用户发货五天后才能延长收货","isv.parameter-invalid:10001","检查入参")]
public class AfterSaleTimeExtendReq : IDouyinReq<AfterSaleTimeExtendRsp>
{

	public string GetMethod() { return "afterSale.timeExtend"; }

	public string GetUrl() { return "/afterSale/timeExtend"; }

	[JsonPropertyName("aftersale_id")]
	[Description("售后单号")]
	[NotNull]
	public long? AftersaleId { get; set; }
}

[Description("此接口用来帮助商家进行延时收货，商家可以在还有2天到期的时间进行操作，会在原有剩余时间的基础上增加7天。")]
public class AfterSaleTimeExtendRsp
{
}
