namespace ecommerce.sdk.douyin;

[Description("在售后详情页，店家在可以选择给售后单添加备注")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","系统错误，请重试","isv.business-failed:10000","系统错误，请重试")]
[DouyinRetCode(50002,"业务处理失败","未填写备注","isv.business-failed:11000","请填写备注信息")]
[DouyinRetCode(50002,"业务处理失败","该售后单不存在","isv.business-failed:11003","请检查售后单信息")]
[DouyinRetCode(50002,"业务处理失败","查询退款记录失败，请稍后重试","isv.business-failed:12000","查询退款记录失败，请稍后重试")]
public class AfterSaleAddOrderRemarkReq : IDouyinReq<AfterSaleAddOrderRemarkRsp>
{

	public string GetMethod() { return "afterSale.addOrderRemark"; }

	public string GetUrl() { return "/afterSale/addOrderRemark"; }

	[JsonPropertyName("order_id")]
	[Description("订单ID，与售后单ID二选一传入")]
	public string OrderId { get; set; }

	[JsonPropertyName("after_sale_id")]
	[Description("售后单ID，与订单ID二选一传入，二者均传入时售后单ID的优先级更高")]
	public string AfterSaleId { get; set; }

	[JsonPropertyName("remark")]
	[Description("商家添加的备注信息")]
	[NotNull]
	public string Remark { get; set; }
}

[Description("在售后详情页，店家在可以选择给售后单添加备注")]
public class AfterSaleAddOrderRemarkRsp
{
}
