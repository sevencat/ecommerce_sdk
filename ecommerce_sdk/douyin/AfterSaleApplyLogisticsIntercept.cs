namespace ecommerce.sdk.douyin;

[Description("快递状态处于已揽收未派送之间时，由于各种原因，无需寄送后，进行拦截，将货物原路返还给寄件人")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","信息获取失败，请稍后重试","isv.business-failed:10000","重试")]
public class AfterSaleApplyLogisticsInterceptReq : IDouyinReq<AfterSaleApplyLogisticsInterceptRsp>
{

	public string GetMethod() { return "afterSale.applyLogisticsIntercept"; }

	public string GetUrl() { return "/afterSale/applyLogisticsIntercept"; }

	[JsonPropertyName("after_sale_id")]
	[Description("售后单ID")]
	[NotNull]
	public long? AfterSaleId { get; set; }

	[JsonPropertyName("op_from")]
	[Description("操作来源（1:商家  3:客服）")]
	[NotNull]
	public int? OpFrom { get; set; }

	[JsonPropertyName("intercept_targets")]
	[Description("要拦截的包裹")]
	[NotNull]
	public List<InterceptTargetsItem> InterceptTargets { get; set; }

	public class InterceptTargetsItem
	{
		[JsonPropertyName("company_code")]
		[Description("物流公司编码")]
		[NotNull]
		public string CompanyCode { get; set; }

		[JsonPropertyName("tracking_no")]
		[Description("物流单号")]
		[NotNull]
		public string TrackingNo { get; set; }
	}
}

[Description("快递状态处于已揽收未派送之间时，由于各种原因，无需寄送后，进行拦截，将货物原路返还给寄件人")]
public class AfterSaleApplyLogisticsInterceptRsp
{
	[JsonPropertyName("intercept_results")]
	[Description("物流拦截结果")]
	public List<InterceptResultsItem> InterceptResults { get; set; }

	public class InterceptResultsItem
	{
		[JsonPropertyName("company_code")]
		[Description("物流公司编码")]
		public string CompanyCode { get; set; }

		[JsonPropertyName("company_name")]
		[Description("物流公司名称")]
		public string CompanyName { get; set; }

		[JsonPropertyName("tracking_no")]
		[Description("物流单号")]
		public string TrackingNo { get; set; }

		[JsonPropertyName("value_amount")]
		[Description("包裹价值（分）")]
		public long ValueAmount { get; set; }

		[JsonPropertyName("can_intercept")]
		[Description("是否可拦截（拦截详情时返回）")]
		public bool CanIntercept { get; set; }

		[JsonPropertyName("is_success")]
		[Description("是否拦截成功（发起拦截时返回）")]
		public bool IsSuccess { get; set; }

		[JsonPropertyName("unavailable_reason_code")]
		[Description("不可拦截原因编码")]
		public long UnavailableReasonCode { get; set; }

		[JsonPropertyName("unavailable_reason")]
		[Description("不可拦截原因文案")]
		public string UnavailableReason { get; set; }

		[JsonPropertyName("intercept_cost")]
		[Description("拦截费用（分），（拦截详情时返回，不可拦截时无意义）")]
		public long InterceptCost { get; set; }

		[JsonPropertyName("cur_product")]
		[Description("当前售后商品信息")]
		public CurProductItem CurProduct { get; set; }

		public class CurProductItem
		{
			[JsonPropertyName("order_id")]
			[Description("商品单订单号")]
			public long OrderId { get; set; }

			[JsonPropertyName("product_image")]
			[Description("商品图片")]
			public string ProductImage { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("product_spec")]
			[Description("商品规格")]
			public string ProductSpec { get; set; }

			[JsonPropertyName("tags")]
			[Description("商品标签")]
			public List<string> Tags { get; set; }

			[JsonPropertyName("price")]
			[Description("单价")]
			public long Price { get; set; }

			[JsonPropertyName("amount")]
			[Description("数量")]
			public long Amount { get; set; }
		}

		[JsonPropertyName("other_products")]
		[Description("其它商品列表")]
		public List<OtherProductsItem> OtherProducts { get; set; }

		public class OtherProductsItem
		{
			[JsonPropertyName("order_id")]
			[Description("商品单订单号")]
			public long OrderId { get; set; }

			[JsonPropertyName("product_image")]
			[Description("商品图片")]
			public string ProductImage { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("product_spec")]
			[Description("商品规格")]
			public string ProductSpec { get; set; }

			[JsonPropertyName("tags")]
			[Description("商品标签")]
			public List<string> Tags { get; set; }

			[JsonPropertyName("price")]
			[Description("单价")]
			public long Price { get; set; }

			[JsonPropertyName("amount")]
			[Description("数量")]
			public long Amount { get; set; }
		}

		[JsonPropertyName("other_product_amount")]
		[Description("其他商品件数")]
		public long OtherProductAmount { get; set; }

		[JsonPropertyName("settlement_mode")]
		[Description("结算方式 0是线上结算 1是线下结算")]
		public int SettlementMode { get; set; }
	}

	[JsonPropertyName("success_count")]
	[Description("拦截成功次数")]
	public long SuccessCount { get; set; }

	[JsonPropertyName("failed_count")]
	[Description("拦截失败次数")]
	public long FailedCount { get; set; }

	[JsonPropertyName("unavailable_reason_code")]
	[Description("不可拦截编码(failed_count=1时有意义)")]
	public long UnavailableReasonCode { get; set; }

	[JsonPropertyName("unavailable_reason")]
	[Description("不可拦截原因(failed_count=1时有意义)")]
	public string UnavailableReason { get; set; }

	[JsonPropertyName("refund_amount")]
	[Description("售后单退款总金额")]
	public long RefundAmount { get; set; }
}
