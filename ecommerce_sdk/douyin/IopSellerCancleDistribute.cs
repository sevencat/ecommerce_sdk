namespace ecommerce.sdk.douyin;

[Description("【商家】取消分配代发订单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","一次最多取消:100","isv.business-failed:10000","请检查订单数量")]
public class IopSellerCancleDistributeReq : IDouyinReq<IopSellerCancleDistributeRsp>
{

	public string GetMethod() { return "iop.sellerCancleDistribute"; }

	public string GetUrl() { return "/iop/sellerCancleDistribute"; }

	[JsonPropertyName("distr_order_ids")]
	[Description("代打订单号")]
	[NotNull]
	public List<string> DistrOrderIds { get; set; }
}

[Description("【商家】取消分配代发订单")]
public class IopSellerCancleDistributeRsp
{
	[JsonPropertyName("succ_distr_order_ids")]
	[Description("操作成功的代打订单号")]
	public List<string> SuccDistrOrderIds { get; set; }

	[JsonPropertyName("fail_distr_order_ids")]
	[Description("操作失败的代打订单号")]
	public Dictionary<string,string> FailDistrOrderIds { get; set; }
}
