namespace ecommerce.sdk.douyin;

[Description("查询商家待处理/已处理的延长推广列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","257:参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(20000,"系统错误","256:服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
public class BuyinActivityProductExtendListReq : IDouyinReq<BuyinActivityProductExtendListRsp>
{

	public string GetMethod() { return "buyin.activityProductExtendList"; }

	public string GetUrl() { return "/buyin/activityProductExtendList"; }

	[JsonPropertyName("page")]
	[Description("当前页")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页条数（最大20）")]
	public long? PageSize { get; set; }

	[JsonPropertyName("search_type")]
	[Description("查询类型（0:查询待处理申请，1:查询已处理申请）")]
	public int? SearchType { get; set; }

	[JsonPropertyName("activity_id")]
	[Description("活动 id")]
	public long? ActivityId { get; set; }
}

[Description("查询商家待处理/已处理的延长推广列表")]
public class BuyinActivityProductExtendListRsp
{
	[JsonPropertyName("item_list")]
	[Description("item 列表")]
	public List<ItemListItem> ItemList { get; set; }

	public class ItemListItem
	{
		[JsonPropertyName("product_name")]
		[Description("商品名称")]
		public string ProductName { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品 id")]
		public long ProductId { get; set; }

		[JsonPropertyName("product_img")]
		[Description("商品图片")]
		public string ProductImg { get; set; }

		[JsonPropertyName("product_price")]
		[Description("商品售价")]
		public decimal ProductPrice { get; set; }

		[JsonPropertyName("product_stock")]
		[Description("商品库存")]
		public long ProductStock { get; set; }

		[JsonPropertyName("commission_rate")]
		[Description("佣金率")]
		public decimal CommissionRate { get; set; }

		[JsonPropertyName("service_rate")]
		[Description("服务费率")]
		public decimal ServiceRate { get; set; }

		[JsonPropertyName("promote_start_time")]
		[Description("推广开始时间")]
		public string PromoteStartTime { get; set; }

		[JsonPropertyName("promote_end_time")]
		[Description("推广结束时间")]
		public string PromoteEndTime { get; set; }

		[JsonPropertyName("extend_time")]
		[Description("延长到的时间点（yyyy-MM-dd）")]
		public string ExtendTime { get; set; }

		[JsonPropertyName("extend_apply_time")]
		[Description("延长申请时间")]
		public string ExtendApplyTime { get; set; }

		[JsonPropertyName("extend_deal_time")]
		[Description("延长申请审核时间")]
		public string ExtendDealTime { get; set; }

		[JsonPropertyName("extend_deal_result")]
		[Description("延长申请审核结果 1:机构发起延长申请  2:商家同意延长申请  3:商家拒绝延长申请  4:3天未审核到期自动拒绝")]
		public long ExtendDealResult { get; set; }

		[JsonPropertyName("extend_deal_note")]
		[Description("延长申请审核备注")]
		public string ExtendDealNote { get; set; }

		[JsonPropertyName("extend_apply_id")]
		[Description("延长推广的申请id")]
		public long ExtendApplyId { get; set; }

		[JsonPropertyName("institution_id")]
		[Description("团长id")]
		public long InstitutionId { get; set; }

		[JsonPropertyName("institution_name")]
		[Description("团长名称")]
		public string InstitutionName { get; set; }

		[JsonPropertyName("institution_phone")]
		[Description("团长电话（返回联系电话密文，需通过 https://op.jinritemai.com/docs/api-docs/61/2829 解密）")]
		public string InstitutionPhone { get; set; }

		[JsonPropertyName("activity_id")]
		[Description("团长活动id")]
		public long ActivityId { get; set; }

		[JsonPropertyName("activity_name")]
		[Description("团长活动名称")]
		public string ActivityName { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("条目总数")]
	public long Total { get; set; }
}
