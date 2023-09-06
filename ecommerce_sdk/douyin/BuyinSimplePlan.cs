namespace ecommerce.sdk.douyin;

[Description("支持商品普通计划的创建和修改，需要商家授权。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","店铺未加入联盟","isv.business-failed:1549","店铺未加入联盟")]
public class BuyinSimplePlanReq : IDouyinReq<BuyinSimplePlanRsp>
{

	public string GetMethod() { return "buyin.simplePlan"; }

	public string GetUrl() { return "/buyin/simplePlan"; }

	[JsonPropertyName("is_create")]
	[Description("是否创建")]
	[NotNull]
	public bool? IsCreate { get; set; }

	[JsonPropertyName("status")]
	[Description("状态，修改时必填，创建推广时默认开启。1：开启普通计划；2：关闭普通计划")]
	public int? Status { get; set; }

	[JsonPropertyName("products")]
	[Description("总个数不超过20，不可重复")]
	public List<ProductsItem> Products { get; set; }

	public class ProductsItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		[NotNull]
		public long? ProductId { get; set; }

		[JsonPropertyName("cos_ratio")]
		[Description("佣金比例（创建推广计划时必填）普通计划范围：[1, 50]。每个商品的佣金率下调次日0点生效，最小下调1%；上调最高到50%，立即生效")]
		public long? CosRatio { get; set; }
	}
}

[Description("支持商品普通计划的创建和修改，需要商家授权。")]
public class BuyinSimplePlanRsp
{
	[JsonPropertyName("result")]
	[Description("创建结果")]
	public List<ResultItem> Result { get; set; }

	public class ResultItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("is_success")]
		[Description("操作结果是否成功，佣金率下调次日生效")]
		public bool IsSuccess { get; set; }

		[JsonPropertyName("error_code")]
		[Description("当前商品操作错误码，成功为0")]
		public long ErrorCode { get; set; }

		[JsonPropertyName("error_msg")]
		[Description("当前商品操作错误原因，成功为success")]
		public string ErrorMsg { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("操作的商品数量")]
	public long Total { get; set; }
}
