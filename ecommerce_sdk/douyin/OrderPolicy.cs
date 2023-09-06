namespace ecommerce.sdk.douyin;

[Description("查各种保险的保单详情")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","订单未找到","isv.business-failed:2","请检查订单信息")]
[DouyinRetCode(50002,"业务处理失败","查询保单失败","isv.business-failed:9999","请稍后重试")]
public class OrderPolicyReq : IDouyinReq<OrderPolicyRsp>
{

	public string GetMethod() { return "order.policy"; }

	public string GetUrl() { return "/order/policy"; }

	[JsonPropertyName("order_id")]
	[Description("订单id")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("ins_product_id")]
	[Description("保单类型枚举值：,returnfreight2020v1-运费险；allergyinsurance2021-过敏险；plant7dinsurance2021-绿植养死包赔7天； plant15dinsurance2021-绿植养死包赔15天；insopenbox2022v12b-开箱无忧；foodsafety2022ecom2b,-食安保；")]
	[NotNull]
	public string InsProductId { get; set; }
}

[Description("查各种保险的保单详情")]
public class OrderPolicyRsp
{
	[JsonPropertyName("policy_info")]
	[Description("保单详情列表")]
	public PolicyInfoItem PolicyInfo { get; set; }

	public class PolicyInfoItem
	{
		[JsonPropertyName("ins_policy_no")]
		[Description("保单号")]
		public string InsPolicyNo { get; set; }

		[JsonPropertyName("amount")]
		[Description("预计退保费用，单位分")]
		public long Amount { get; set; }

		[JsonPropertyName("premium")]
		[Description("总保费，单位分")]
		public long Premium { get; set; }

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

		[JsonPropertyName("claim_status")]
		[Description("理赔状态 0: 初始化 1: 理赔中 2: 理赔成功 3: 理赔失败  绿植险该字段没用")]
		public int ClaimStatus { get; set; }

		[JsonPropertyName("appeal_status")]
		[Description("申述状态 0: 初始化 1: 申诉处理中 2: 申诉成功 3: 申诉失败  绿植险该字段没用")]
		public int AppealStatus { get; set; }

		[JsonPropertyName("goods_info_list")]
		[Description("商品列表")]
		public List<GoodsInfoListItem> GoodsInfoList { get; set; }

		public class GoodsInfoListItem
		{
			[JsonPropertyName("name")]
			[Description("商品名称")]
			public string Name { get; set; }

			[JsonPropertyName("product_id")]
			[Description("商品id")]
			public long ProductId { get; set; }

			[JsonPropertyName("category_id")]
			[Description("类目")]
			public string CategoryId { get; set; }

			[JsonPropertyName("show_page_url")]
			[Description("url")]
			public string ShowPageUrl { get; set; }

			[JsonPropertyName("count")]
			[Description("数量")]
			public int Count { get; set; }
		}

		[JsonPropertyName("ins_ensured_time_begin")]
		[Description("出保时间")]
		public string InsEnsuredTimeBegin { get; set; }

		[JsonPropertyName("ins_ensured_time_end")]
		[Description("保险过期时间")]
		public string InsEnsuredTimeEnd { get; set; }

		[JsonPropertyName("is_allow_appeal")]
		[Description("只有在保单状态为赔付失败的时候并允许申诉 true，其他情况 false")]
		public bool IsAllowAppeal { get; set; }

		[JsonPropertyName("refused_msg")]
		[Description("理赔或申述失败原因")]
		public string RefusedMsg { get; set; }

		[JsonPropertyName("ins_hotline")]
		[Description("保险客服电话")]
		public string InsHotline { get; set; }

		[JsonPropertyName("payer_type")]
		[Description("投保人  2:商家  3:平台")]
		public int PayerType { get; set; }
	}

	[JsonPropertyName("claim_info_list")]
	[Description("理赔列表")]
	public List<ClaimInfoListItem> ClaimInfoList { get; set; }

	public class ClaimInfoListItem
	{
		[JsonPropertyName("status")]
		[Description("理赔状态，0：默认值，未发起理赔;1：已发起理赔，理赔审核中;2：理赔通过;3：理赔未通过;仅用于运费险的理赔状态")]
		public int Status { get; set; }

		[JsonPropertyName("amount")]
		[Description("预计理赔金额：分")]
		public long Amount { get; set; }

		[JsonPropertyName("premium")]
		[Description("实际理赔金额")]
		public long Premium { get; set; }

		[JsonPropertyName("claim_time")]
		[Description("理赔时间")]
		public long ClaimTime { get; set; }

		[JsonPropertyName("ins_claim_no")]
		[Description("理赔单号")]
		public string InsClaimNo { get; set; }

		[JsonPropertyName("claim_msg")]
		[Description("申请原因")]
		public string ClaimMsg { get; set; }

		[JsonPropertyName("refused_msg")]
		[Description("拒绝原因")]
		public string RefusedMsg { get; set; }

		[JsonPropertyName("agg_claim_status")]
		[Description("聚合后的理赔状态： 用于非运费险的理赔状态 ；0：默认值，未发起理赔;1：已发起理赔，理赔审核中;2：理赔通过;3：理赔未通过;")]
		public long AggClaimStatus { get; set; }

		[JsonPropertyName("claim_applied_times")]
		[Description("理赔次数")]
		public int ClaimAppliedTimes { get; set; }
	}
}
