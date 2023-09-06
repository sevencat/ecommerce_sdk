namespace ecommerce.sdk.douyin;

[Description("接口用于一级团长查询自身提报了二级团长的商品及商品审核状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","参数校验失败","isv.business-failed:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
public class BuyinActivityProductListReq : IDouyinReq<BuyinActivityProductListRsp>
{

	public string GetMethod() { return "buyin.activityProductList"; }

	public string GetUrl() { return "/buyin/activityProductList"; }

	[JsonPropertyName("page")]
	[Description("页数，从1开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页条数（最大20）")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("activity_id")]
	[Description("活动ID")]
	[NotNull]
	public long? ActivityId { get; set; }

	[JsonPropertyName("applied_sub_status")]
	[Description("报名商品子状态。0:待审核； 1:合作中； 2:拒绝合作； 4:未合作取消； 5:合作中取消")]
	public int? AppliedSubStatus { get; set; }

	[JsonPropertyName("product_info")]
	[Description("商品信息（支持传商品id或者商品名称，传商品id精确匹配，传商品名称模糊匹配）")]
	public string ProductInfo { get; set; }

	[JsonPropertyName("sort_field")]
	[Description("排序字段。0：默认（同百应）；1：更新时间")]
	public long? SortField { get; set; }

	[JsonPropertyName("sort_direction")]
	[Description("排序方式。1：升序；2：倒序，sort_field为1时有效")]
	public long? SortDirection { get; set; }
}

[Description("接口用于一级团长查询自身提报了二级团长的商品及商品审核状态")]
public class BuyinActivityProductListRsp
{
	[JsonPropertyName("products")]
	[Description("活动商品")]
	public List<ProductsItem> Products { get; set; }

	public class ProductsItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("product_name")]
		[Description("商品名称")]
		public string ProductName { get; set; }

		[JsonPropertyName("product_price")]
		[Description("售价（单位：分）")]
		public decimal ProductPrice { get; set; }

		[JsonPropertyName("product_stock")]
		[Description("库存")]
		public long ProductStock { get; set; }

		[JsonPropertyName("commission_rate")]
		[Description("佣金率（1000表示佣金率10%）")]
		public decimal CommissionRate { get; set; }

		[JsonPropertyName("service_rate")]
		[Description("服务费率（1000表示佣金率10%）")]
		public decimal ServiceRate { get; set; }

		[JsonPropertyName("product_img")]
		[Description("商品主图")]
		public string ProductImg { get; set; }

		[JsonPropertyName("promote_start_time")]
		[Description("商品推广开始时间")]
		public string PromoteStartTime { get; set; }

		[JsonPropertyName("promote_end_time")]
		[Description("商品推广结束时间")]
		public string PromoteEndTime { get; set; }

		[JsonPropertyName("origin_activity_id")]
		[Description("原始活动ID")]
		public long OriginActivityId { get; set; }

		[JsonPropertyName("origin_activity_name")]
		[Description("原始活动名称")]
		public string OriginActivityName { get; set; }

		[JsonPropertyName("is_trusteeship_product")]
		[Description("是否为托管商品")]
		public bool IsTrusteeshipProduct { get; set; }

		[JsonPropertyName("apply_id")]
		[Description("申请唯一标识")]
		public long ApplyId { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public string UpdateTime { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("商品总数")]
	public long Total { get; set; }
}
