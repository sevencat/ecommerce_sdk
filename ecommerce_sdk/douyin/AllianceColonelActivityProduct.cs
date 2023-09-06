namespace ecommerce.sdk.douyin;

[Description("获取专属团长活动商品列表，需团长百应授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","参数校验失败","isv.business-failed:257","参数校验失败")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","无效分页大小","isv.business-failed:4097","每页最多20条数据")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
[DouyinRetCode(50002,"业务处理失败","不允许继续翻页，请使用游标模式加载更多数据","isv.business-failed:8197","请使用游标模式加载更多数据，详情：https://op.jinritemai.com/docs/notice-docs/5/3237")]
public class AllianceColonelActivityProductReq : IDouyinReq<AllianceColonelActivityProductRsp>
{

	public string GetMethod() { return "alliance.colonelActivityProduct"; }

	public string GetUrl() { return "/alliance/colonelActivityProduct"; }

	[JsonPropertyName("activity_id")]
	[Description("活动ID")]
	[NotNull]
	public long? ActivityId { get; set; }

	[JsonPropertyName("search_type")]
	[Description("召回结果排序条件，[推荐按更新时间倒序查]。0：报名时间；1：活动价格排序；2：活动佣金比例排序；4：更新时间排序")]
	public long? SearchType { get; set; }

	[JsonPropertyName("sort_type")]
	[Description("排序顺序。0：升序；1：降序")]
	public long? SortType { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，从1开始。分页模式下生效，超过10000条会被限制，推荐使用游标模式 retrieve_mode=1")]
	public long? Page { get; set; }

	[JsonPropertyName("count")]
	[Description("每页数量（每页最多20）")]
	[NotNull]
	public long? Count { get; set; }

	[JsonPropertyName("cooperation_info")]
	[Description("商家ID or 商家名称 or 一级团长名称 or 一级团长ID")]
	public string CooperationInfo { get; set; }

	[JsonPropertyName("cooperation_type")]
	[Description("合作类型. 0: 不限; 1: 商家; 2: 团长")]
	public int? CooperationType { get; set; }

	[JsonPropertyName("product_info")]
	[Description("商品ID/名称（支持根据商品id或者商品名称搜索，商品ID精准匹配，商品名称模糊匹配）")]
	public string ProductInfo { get; set; }

	[JsonPropertyName("status")]
	[Description("活动商品状态，不传查所有状态。0：待审核；1：推广中；2：申请未通过；3：合作已终止；6：合作已到期")]
	public long? Status { get; set; }

	[JsonPropertyName("retrieve_mode")]
	[Description("获取模式。0: 分页模式（默认），最多返回10000条数据；1: 游标模式（推荐），返回条数无限制")]
	public int? RetrieveMode { get; set; }

	[JsonPropertyName("cursor")]
	[Description("游标。首页不需要传，请求下一页时需传入上一次请求响应的next_cursor值")]
	public string Cursor { get; set; }
}

[Description("获取专属团长活动商品列表，需团长百应授权")]
public class AllianceColonelActivityProductRsp
{
	[JsonPropertyName("data")]
	[Description("活动商品列表")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("exclusion_duration")]
		[Description("团长保护期，单位：月")]
		public int ExclusionDuration { get; set; }

		[JsonPropertyName("can_promote")]
		[Description("能否推广（true:可推广）")]
		public bool CanPromote { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("title")]
		[Description("商品名称")]
		public string Title { get; set; }

		[JsonPropertyName("price")]
		[Description("商品售价（单位为分）")]
		public long Price { get; set; }

		[JsonPropertyName("cos_ratio")]
		[Description("佣金比例（10表示佣金率为10%）")]
		public decimal CosRatio { get; set; }

		[JsonPropertyName("cos_fee")]
		[Description("佣金金额，单位分")]
		public long CosFee { get; set; }

		[JsonPropertyName("first_cid")]
		[Description("商品一级类目")]
		public long FirstCid { get; set; }

		[JsonPropertyName("second_cid")]
		[Description("商品二级类目")]
		public long SecondCid { get; set; }

		[JsonPropertyName("third_cid")]
		[Description("商品三级类目")]
		public long ThirdCid { get; set; }

		[JsonPropertyName("in_stock")]
		[Description("是否有库存")]
		public bool InStock { get; set; }

		[JsonPropertyName("sales")]
		[Description("销量")]
		public long Sales { get; set; }

		[JsonPropertyName("cover")]
		[Description("商品主图")]
		public string Cover { get; set; }

		[JsonPropertyName("detail_url")]
		[Description("商品团长活动链接(推广中的商品会返回，到期后链接不可用)")]
		public string DetailUrl { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺ID")]
		public long ShopId { get; set; }

		[JsonPropertyName("shop_name")]
		[Description("店铺名称")]
		public string ShopName { get; set; }

		[JsonPropertyName("activity_price")]
		[Description("活动售价（单位元，保留两位小数）--废弃")]
		public decimal ActivityPrice { get; set; }

		[JsonPropertyName("activity_cos_ratio")]
		[Description("活动佣金比例(1000 表示佣金比例为10%)")]
		public decimal ActivityCosRatio { get; set; }

		[JsonPropertyName("activity_cos_fee")]
		[Description("活动佣金金额（单位元，保留两位小数）--废弃")]
		public decimal ActivityCosFee { get; set; }

		[JsonPropertyName("status")]
		[Description("商品审核状态。0：待审核；1：推广中；2：申请未通过；3：合作已终止；4:合作前取消；6：合作已到期")]
		public int Status { get; set; }

		[JsonPropertyName("reason")]
		[Description("审核原因")]
		public string Reason { get; set; }

		[JsonPropertyName("shop_contact")]
		[Description("商家联系方式（返回联系电话密文，需通过 https://op.jinritemai.com/docs/api-docs/61/2829 解密）")]
		public string ShopContact { get; set; }

		[JsonPropertyName("activity_start_time")]
		[Description("活动开始时间")]
		public string ActivityStartTime { get; set; }

		[JsonPropertyName("activity_end_time")]
		[Description("活动结束时间")]
		public string ActivityEndTime { get; set; }

		[JsonPropertyName("promotion_start_time")]
		[Description("商品活动推广开始时间")]
		public string PromotionStartTime { get; set; }

		[JsonPropertyName("promotion_end_time")]
		[Description("商品活动推广结束时间（未延期时与活动结束时间相同）")]
		public string PromotionEndTime { get; set; }

		[JsonPropertyName("service_ratio")]
		[Description("招商团长服务费率")]
		public string ServiceRatio { get; set; }

		[JsonPropertyName("apply_id")]
		[Description("审核ID，是专属团长活动商品审核接口必传参数，status=0 时返回")]
		public long ApplyId { get; set; }

		[JsonPropertyName("category_id")]
		[Description("行业类目ID")]
		public long CategoryId { get; set; }

		[JsonPropertyName("category_name")]
		[Description("行业类目名称")]
		public string CategoryName { get; set; }

		[JsonPropertyName("product_stock")]
		[Description("商品库存")]
		public string ProductStock { get; set; }

		[JsonPropertyName("colonel_coupon_info")]
		[Description("团长优惠券信息")]
		public string ColonelCouponInfo { get; set; }

		[JsonPropertyName("is_new_shop")]
		[Description("是否为新手店铺")]
		public bool IsNewShop { get; set; }

		[JsonPropertyName("shop_score")]
		[Description("店铺分")]
		public string ShopScore { get; set; }

		[JsonPropertyName("promotion_stock")]
		[Description("活动库存--废弃")]
		public string PromotionStock { get; set; }

		[JsonPropertyName("gift_info")]
		[Description("赠品信息--废弃")]
		public string GiftInfo { get; set; }

		[JsonPropertyName("promotion_step")]
		[Description("活动实现方式--废弃")]
		public string PromotionStep { get; set; }

		[JsonPropertyName("origin_institution_id")]
		[Description("原始团长 id")]
		public long OriginInstitutionId { get; set; }

		[JsonPropertyName("origin_institution_name")]
		[Description("原始团长名称")]
		public string OriginInstitutionName { get; set; }

		[JsonPropertyName("origin_institution_phone")]
		[Description("原始团长电话")]
		public string OriginInstitutionPhone { get; set; }

		[JsonPropertyName("origin_activity_start_time")]
		[Description("原始团长活动有效期生效开始时间")]
		public string OriginActivityStartTime { get; set; }

		[JsonPropertyName("origin_activity_end_time")]
		[Description("原始团长活动有效期生效结束时间")]
		public string OriginActivityEndTime { get; set; }

		[JsonPropertyName("origin_activity_id")]
		[Description("原始活动id")]
		public long OriginActivityId { get; set; }

		[JsonPropertyName("is_trusteeship_product")]
		[Description("托管商品标识（true:托管商品，该字段仅在团长报团长时生效）")]
		public bool IsTrusteeshipProduct { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public string UpdateTime { get; set; }

		[JsonPropertyName("origin_colonel_buyin_id")]
		[Description("团长百应 id")]
		public long OriginColonelBuyinId { get; set; }

		[JsonPropertyName("months_of_protection")]
		[Description("团长保护期（月数）")]
		public long MonthsOfProtection { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("活动商品条数，游标模式下不返回")]
	public long Total { get; set; }

	[JsonPropertyName("institution_id")]
	[Description("机构id")]
	public long InstitutionId { get; set; }

	[JsonPropertyName("next_cursor")]
	[Description("下一页游标。游标模式下返回，最后一页返回空")]
	public string NextCursor { get; set; }
}
