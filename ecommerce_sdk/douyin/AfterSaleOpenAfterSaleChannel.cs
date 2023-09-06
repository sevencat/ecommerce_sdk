namespace ecommerce.sdk.douyin;

[Description("商家打开售后通道")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","无权操作此订单","isv.business-failed:11001","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","系统错误，请重试","isv.business-failed:10000","系统错误，请重试")]
[DouyinRetCode(50002,"业务处理失败","售后入口已经打开，请联系买家在用户端申请售后","isv.business-failed:12000","售后入口已经打开，请联系买家在用户端申请售后")]
public class AfterSaleOpenAfterSaleChannelReq : IDouyinReq<AfterSaleOpenAfterSaleChannelRsp>
{

	public string GetMethod() { return "afterSale.OpenAfterSaleChannel"; }

	public string GetUrl() { return "/afterSale/OpenAfterSaleChannel"; }

	[JsonPropertyName("order_id")]
	[Description("订单ID")]
	[NotNull]
	public long? OrderId { get; set; }
}

[Description("商家打开售后通道")]
public class AfterSaleOpenAfterSaleChannelRsp
{
	[JsonPropertyName("conclusion")]
	[Description("打开售后通道结论")]
	public ConclusionItem Conclusion { get; set; }

	public class ConclusionItem
	{
		[JsonPropertyName("match_conclusion")]
		[Description("匹配到超级售后的类型，1是超售后期售后，2是EP订单超级售后，3是虚拟订单超级售后，4是超售后次数售后")]
		public int MatchConclusion { get; set; }

		[JsonPropertyName("match_message")]
		[Description("匹配结果的解释，成功时为空")]
		public string MatchMessage { get; set; }

		[JsonPropertyName("can_apply_type_list")]
		[Description("当前超级售后可以发起的售后类型，0是退货退款，1是已发货仅退款，2是未发货仅退款，3是换货")]
		public List<long> CanApplyTypeList { get; set; }

		[JsonPropertyName("match_success")]
		[Description("匹配是否成功，当match_conclusion不为0且can_apply_type_list不是空的时候，此值为true")]
		public bool MatchSuccess { get; set; }
	}
}
