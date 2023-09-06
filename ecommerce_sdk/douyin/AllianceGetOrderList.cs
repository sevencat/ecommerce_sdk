namespace ecommerce.sdk.douyin;

[Description("查询联盟达人佣金订单明细（order_ids一次最多传入5个订单）")]
public class AllianceGetOrderListReq : IDouyinReq<AllianceGetOrderListRsp>
{

	public string GetMethod() { return "alliance.getOrderList"; }

	public string GetUrl() { return "/alliance/getOrderList"; }

	[JsonPropertyName("order_ids")]
	[Description("订单id列表")]
	[NotNull]
	public List<string> OrderIds { get; set; }
}

[Description("查询联盟达人佣金订单明细（order_ids一次最多传入5个订单）")]
public class AllianceGetOrderListRsp
{
	[JsonPropertyName("code")]
	[Description("返回编码")]
	public string Code { get; set; }

	[JsonPropertyName("code_msg")]
	[Description("返回信息")]
	public string CodeMsg { get; set; }

	[JsonPropertyName("datas")]
	[Description("订单明细数据")]
	public List<DatasItem> Datas { get; set; }

	public class DatasItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单id")]
		public string OrderId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("产品id")]
		public string ProductId { get; set; }

		[JsonPropertyName("author_account")]
		[Description("达人账户")]
		public string AuthorAccount { get; set; }

		[JsonPropertyName("short_id")]
		[Description("达人short_id")]
		public string ShortId { get; set; }

		[JsonPropertyName("total_pay_amount")]
		[Description("用户实付，单位：分")]
		public long TotalPayAmount { get; set; }

		[JsonPropertyName("commission_rate")]
		[Description("达人佣金率，以万为基数，比如3000，就是30%")]
		public long CommissionRate { get; set; }

		[JsonPropertyName("estimated_comission")]
		[Description("预估达人佣金，单位：分；注意：该字段和精选联盟-联盟订单明细模块，预计佣支出（商家预估佣金支出）没有对应关系，一个是达人佣金预估，一个是商家预估佣金支出。")]
		public long EstimatedComission { get; set; }

		[JsonPropertyName("real_comission")]
		[Description("真实达人佣金，单位：分")]
		public long RealComission { get; set; }

		[JsonPropertyName("order_status")]
		[Description("订单状态：支付成功、确认收货、退款、结算")]
		public string OrderStatus { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺id")]
		public string ShopId { get; set; }

		[JsonPropertyName("alliance_biz_type")]
		[Description("业务类型：COMMON普通单、PRE_SELL预售")]
		public string AllianceBizType { get; set; }

		[JsonPropertyName("phase_id")]
		[Description("阶段单号：1定金、2尾款")]
		public long PhaseId { get; set; }
	}
}
