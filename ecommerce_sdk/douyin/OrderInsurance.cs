namespace ecommerce.sdk.douyin;

[Description("根据订单ID，获取该订单对应的运费险保单的详细信息；,1、status<=1&status=5的情况下ins_ensured_time_begin、ins_ensured_time_end没有意义（返回的是默认时间1754-08-31 06:49:25）忽略即可，status其他情况下都会返回正确的时间。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","查询保单信息失败","isv.business-failed:9999","业务处理失败，尝试重试")]
[DouyinRetCode(50002,"业务处理失败","参数错误,订单不存在","isv.business-failed:2","请检查order_id字段")]
public class OrderInsuranceReq : IDouyinReq<OrderInsuranceRsp>
{

	public string GetMethod() { return "order.insurance"; }

	public string GetUrl() { return "/order/insurance"; }

	[JsonPropertyName("order_id")]
	[Description("订单id(可以加A也可以不加）")]
	[NotNull]
	public string OrderId { get; set; }
}

[Description("根据订单ID，获取该订单对应的运费险保单的详细信息；,1、status<=1&status=5的情况下ins_ensured_time_begin、ins_ensured_time_end没有意义（返回的是默认时间1754-08-31 06:49:25）忽略即可，status其他情况下都会返回正确的时间。")]
public class OrderInsuranceRsp
{
	[JsonPropertyName("policy_info_list")]
	[Description("保单详情列表")]
	public List<PolicyInfoListItem> PolicyInfoList { get; set; }

	public class PolicyInfoListItem
	{
		[JsonPropertyName("ins_policy_no")]
		[Description("保单号")]
		public string InsPolicyNo { get; set; }

		[JsonPropertyName("approximate_return_fee")]
		[Description("预计退保费用，单位分")]
		public long ApproximateReturnFee { get; set; }

		[JsonPropertyName("total_premium")]
		[Description("总保费，单位分")]
		public long TotalPremium { get; set; }

		[JsonPropertyName("user_premium")]
		[Description("用户支付的保费，单位分")]
		public long UserPremium { get; set; }

		[JsonPropertyName("merchant_premium")]
		[Description("商家支付的保费，单位分")]
		public long MerchantPremium { get; set; }

		[JsonPropertyName("platform_premium")]
		[Description("平台承担的保费，单位分")]
		public long PlatformPremium { get; set; }

		[JsonPropertyName("status")]
		[Description("保单状态 0: 初始化 1: 待生效 2: 保障中 3: 赔付完成 4: 保单失效 5: 已经取消")]
		public int Status { get; set; }

		[JsonPropertyName("appeal_status")]
		[Description("申述状态 0: 初始化 1: 申诉处理中 2: 申诉成功 3: 申诉失败")]
		public int AppealStatus { get; set; }

		[JsonPropertyName("claim_status")]
		[Description("理赔状态 0: 初始化 1: 理赔中 2: 理赔成功 3: 理赔失败")]
		public int ClaimStatus { get; set; }

		[JsonPropertyName("company_name")]
		[Description("保险公司名称")]
		public string CompanyName { get; set; }

		[JsonPropertyName("is_allow_appeal")]
		[Description("只有在保单状态为赔付失败的时候并允许申诉 true，其他情况 false")]
		public bool IsAllowAppeal { get; set; }

		[JsonPropertyName("goods_info_list")]
		[Description("商品列表")]
		public List<GoodsInfoListItem> GoodsInfoList { get; set; }

		public class GoodsInfoListItem
		{
			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("product_id")]
			[Description("商品id")]
			public long ProductId { get; set; }

			[JsonPropertyName("category_id")]
			[Description("类目")]
			public string CategoryId { get; set; }

			[JsonPropertyName("show_page_url")]
			[Description("url")]
			public string ShowPageUrl { get; set; }

			[JsonPropertyName("amount")]
			[Description("数量")]
			public int Amount { get; set; }
		}

		[JsonPropertyName("fail_reason")]
		[Description("理赔或申述失败原因")]
		public string FailReason { get; set; }

		[JsonPropertyName("insurance_hotline")]
		[Description("保险客服电话")]
		public string InsuranceHotline { get; set; }

		[JsonPropertyName("premium_status")]
		[Description("保费状态 1：待扣减 2：已扣减 3：已退还 4：已垫付 5：已关闭")]
		public int PremiumStatus { get; set; }

		[JsonPropertyName("ins_ensured_time_begin")]
		[Description("出保时间，status<=1&status=5的情况下ins_ensured_time_begin、ins_ensured_time_end没有意义（返回的是默认时间1754-08-31 06:49:25）忽略即可，status其他情况下都会返回正确的时间。")]
		public string InsEnsuredTimeBegin { get; set; }

		[JsonPropertyName("ins_ensured_time_end")]
		[Description("保险过期时间，status<=1&status=5的情况下ins_ensured_time_begin、ins_ensured_time_end没有意义（返回的是默认时间1754-08-31 06:49:25）忽略即可，status其他情况下都会返回正确的时间。")]
		public string InsEnsuredTimeEnd { get; set; }
	}
}
