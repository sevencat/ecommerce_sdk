namespace ecommerce.sdk.douyin;

[Description("创建/修改商品专属推广计划,1. 支持使用抖店卖家授权将抖店商品加入精选联盟专属推广计划,2. 支持使用抖店卖家授权针对已加入精选联盟专属推广计划的商品进行佣金修改或删除,3、一个商品只能有一个专属计划")]
public class BuyinExclusivePlanReq : IDouyinReq<BuyinExclusivePlanRsp>
{

	public string GetMethod() { return "buyin.exclusivePlan"; }

	public string GetUrl() { return "/buyin/exclusivePlan"; }

	[JsonPropertyName("is_create")]
	[Description("true:创建 false 修改")]
	[NotNull]
	public bool? IsCreate { get; set; }

	[JsonPropertyName("status")]
	[Description("1 开启专属计划，2 取消专属计划（修改时必填，创建推广时默认开启）")]
	public int? Status { get; set; }

	[JsonPropertyName("products")]
	[Description("总个数不超过20，不可重复；一个商品只能有一个专属计划")]
	public List<ProductsItem> Products { get; set; }

	public class ProductsItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品id")]
		[NotNull]
		public long? ProductId { get; set; }

		[JsonPropertyName("cos_ratio")]
		[Description("佣金比例（创建推广计划时必填）专属计划范围：[0, 50]，每个商品的佣金率在7日内仅可以下调一次 ，最多可下调5%")]
		public long? CosRatio { get; set; }
	}
}

[Description("创建/修改商品专属推广计划,1. 支持使用抖店卖家授权将抖店商品加入精选联盟专属推广计划,2. 支持使用抖店卖家授权针对已加入精选联盟专属推广计划的商品进行佣金修改或删除,3、一个商品只能有一个专属计划")]
public class BuyinExclusivePlanRsp
{
	[JsonPropertyName("result")]
	[Description("创建结果")]
	public List<ResultItem> Result { get; set; }

	public class ResultItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品id")]
		public long ProductId { get; set; }

		[JsonPropertyName("is_success")]
		[Description("操作结果 true成功 false失败")]
		public bool IsSuccess { get; set; }

		[JsonPropertyName("error_code")]
		[Description("具体商品id的错误码 成功为0")]
		public long ErrorCode { get; set; }

		[JsonPropertyName("error_msg")]
		[Description("具体商品id的错误原因 成功为success")]
		public string ErrorMsg { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("操作的商品数量")]
	public long Total { get; set; }
}
