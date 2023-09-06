namespace ecommerce.sdk.douyin;

[Description("支持团长查询托管计划商品及商品审核状态。需要团长授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍候再试","isp.service-error:256","服务打瞌睡了，请稍候再试")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
[DouyinRetCode(40004,"非法的参数","sub_status 参数校验失败（当且仅当status为2时必传，1:申请未通过 2:合作已终止 3:合作已到期）","isv.parameter-invalid:16384","当且仅当status为2时必传，1:申请未通过 2:合作已终止 3:合作已到期")]
[DouyinRetCode(50002,"业务处理失败","参数校验失败","isv.business-failed:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","无效分页大小","isv.business-failed:4097","无效分页大小")]
[DouyinRetCode(40004,"非法的参数","不允许继续翻页，请使用游标模式加载更多数据","isv.parameter-invalid:8197","请使用游标模式加载更多数据，详情：https://op.jinritemai.com/docs/notice-docs/5/3237")]
public class BuyinColonelTrusteeshipListReq : IDouyinReq<BuyinColonelTrusteeshipListRsp>
{

	public string GetMethod() { return "buyin.colonel.trusteeshipList"; }

	public string GetUrl() { return "/buyin/colonel/trusteeshipList"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	public long? ProductId { get; set; }

	[JsonPropertyName("business_id")]
	[Description("商家ID")]
	public long? BusinessId { get; set; }

	[JsonPropertyName("status")]
	[Description("申请状态。0：待审核（默认）；1：生效中；2：已结束")]
	public int? Status { get; set; }

	[JsonPropertyName("sub_status")]
	[Description("子状态（仅当status为已结束时需要传，1:申请未通过; 2:合作已终止; 3:合作已到期）")]
	public int? SubStatus { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，从1开始。分页模式下生效，超过10000条会被限制，推荐使用游标模式 retrieve_mode=1")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页条数（最多20条）")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("retrieve_mode")]
	[Description("获取模式。0: 分页模式（默认），最多返回10000条数据；1: 游标模式（推荐），返回条数无限制")]
	public int? RetrieveMode { get; set; }

	[JsonPropertyName("cursor")]
	[Description("游标。首页不需要传，请求下一页时需传入上一次请求响应的next_cursor值")]
	public string Cursor { get; set; }

	[JsonPropertyName("order_by")]
	[Description("排序（1-按照更新时间倒序）")]
	public long? OrderBy { get; set; }
}

[Description("支持团长查询托管计划商品及商品审核状态。需要团长授权")]
public class BuyinColonelTrusteeshipListRsp
{
	[JsonPropertyName("total")]
	[Description("数据总条数")]
	public long Total { get; set; }

	[JsonPropertyName("records")]
	[Description("托管商品列表")]
	public List<RecordsItem> Records { get; set; }

	public class RecordsItem
	{
		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public string UpdateTime { get; set; }

		[JsonPropertyName("can_promote")]
		[Description("能否推广（true：可推广）")]
		public string CanPromote { get; set; }

		[JsonPropertyName("product_name")]
		[Description("商品名称")]
		public string ProductName { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("product_price")]
		[Description("商品售价(单位：分)")]
		public long ProductPrice { get; set; }

		[JsonPropertyName("product_img")]
		[Description("商品图片")]
		public string ProductImg { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("商家ID")]
		public long ShopId { get; set; }

		[JsonPropertyName("shop_name")]
		[Description("商家名称")]
		public string ShopName { get; set; }

		[JsonPropertyName("shop_phone")]
		[Description("商家联系电话（返回联系电话密文，需通过 https://op.jinritemai.com/docs/api-docs/61/2829 解密）")]
		public string ShopPhone { get; set; }

		[JsonPropertyName("is_new")]
		[Description("是否新手店铺")]
		public bool IsNew { get; set; }

		[JsonPropertyName("shop_score")]
		[Description("店铺体验分")]
		public decimal ShopScore { get; set; }

		[JsonPropertyName("trusteeship_commission_rate")]
		[Description("托管佣金率（10% 返回 1000）")]
		public long TrusteeshipCommissionRate { get; set; }

		[JsonPropertyName("trusteeship_service_rate")]
		[Description("托管服务费率（10% 返回 1000）")]
		public long TrusteeshipServiceRate { get; set; }

		[JsonPropertyName("trusteeship_start_time")]
		[Description("托管开始时间")]
		public string TrusteeshipStartTime { get; set; }

		[JsonPropertyName("trusteeship_end_time")]
		[Description("托管结束时间")]
		public string TrusteeshipEndTime { get; set; }

		[JsonPropertyName("product_stock")]
		[Description("商品库存")]
		public long ProductStock { get; set; }

		[JsonPropertyName("status")]
		[Description("托管状态。0：待审核；1：生效中；2：已结束")]
		public int Status { get; set; }

		[JsonPropertyName("sub_status")]
		[Description("子状态。1:申请未通过； 2:合作已终止； 3:合作已到期")]
		public int SubStatus { get; set; }

		[JsonPropertyName("id")]
		[Description("申请ID")]
		public long Id { get; set; }
	}

	[JsonPropertyName("next_cursor")]
	[Description("下一页游标。游标模式下返回，最后一页返回空")]
	public string NextCursor { get; set; }
}
