namespace ecommerce.sdk.douyin;

[Description("接口用于查询团长活动特殊申请，需要机构百应授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","参数校验失败","isv.business-failed:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
public class BuyinColonelSpecialApplyListReq : IDouyinReq<BuyinColonelSpecialApplyListRsp>
{

	public string GetMethod() { return "buyin.colonel.specialApplyList"; }

	public string GetUrl() { return "/buyin/colonel/specialApplyList"; }

	[JsonPropertyName("activity_id")]
	[Description("活动 id(不传表示查机构下所有活动)")]
	public long? ActivityId { get; set; }

	[JsonPropertyName("search_type")]
	[Description("查询类型（0：待处理，1：历史记录，不传默认是待处理）")]
	public int? SearchType { get; set; }

	[JsonPropertyName("page")]
	[Description("页数（从 1 开始，不传默认为 1）")]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页条数（不传默认为 10，最大为200）")]
	public long? Size { get; set; }
}

[Description("接口用于查询团长活动特殊申请，需要机构百应授权")]
public class BuyinColonelSpecialApplyListRsp
{
	[JsonPropertyName("special_apply_list")]
	[Description("特殊申请列表")]
	public List<SpecialApplyListItem> SpecialApplyList { get; set; }

	public class SpecialApplyListItem
	{
		[JsonPropertyName("activity_id")]
		[Description("活动 id")]
		public long ActivityId { get; set; }

		[JsonPropertyName("special_apply_id")]
		[Description("特殊申请 id")]
		public long SpecialApplyId { get; set; }

		[JsonPropertyName("product_name")]
		[Description("商品名称")]
		public string ProductName { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品 id")]
		public long ProductId { get; set; }

		[JsonPropertyName("product_img")]
		[Description("商品主图")]
		public string ProductImg { get; set; }

		[JsonPropertyName("product_price")]
		[Description("商品售价（单位：分）")]
		public string ProductPrice { get; set; }

		[JsonPropertyName("shop_name")]
		[Description("商家名称")]
		public string ShopName { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("商家id")]
		public long ShopId { get; set; }

		[JsonPropertyName("shop_phone")]
		[Description("商家联系方式（返回联系电话密文，需通过 https://op.jinritemai.com/docs/api-docs/61/2829 解密）")]
		public string ShopPhone { get; set; }

		[JsonPropertyName("op_type")]
		[Description("申请类型（1:取消合作，2:修改费率，3：作废优惠券）")]
		public int OpType { get; set; }

		[JsonPropertyName("cur_commission_rate")]
		[Description("原佣金率（10.11%返回1011）")]
		public string CurCommissionRate { get; set; }

		[JsonPropertyName("cur_service_rate")]
		[Description("原服务费率（10.11%返回1011）")]
		public string CurServiceRate { get; set; }

		[JsonPropertyName("apply_commission_rate")]
		[Description("申请佣金率（10.11%返回1011）")]
		public string ApplyCommissionRate { get; set; }

		[JsonPropertyName("apply_service_rate")]
		[Description("申请服务费率（10.11%返回1011）")]
		public string ApplyServiceRate { get; set; }

		[JsonPropertyName("apply_time")]
		[Description("申请时间")]
		public string ApplyTime { get; set; }

		[JsonPropertyName("approve_time")]
		[Description("审批时间")]
		public string ApproveTime { get; set; }

		[JsonPropertyName("status")]
		[Description("状态(0:待审核 1:机构同意 2:拒绝 3:7天未审核自动同意 4:30日无出单自动同意)")]
		public int Status { get; set; }

		[JsonPropertyName("reason")]
		[Description("处理理由")]
		public string Reason { get; set; }

		[JsonPropertyName("origin_institution_id")]
		[Description("原始团长id")]
		public long OriginInstitutionId { get; set; }

		[JsonPropertyName("origin_institution_name")]
		[Description("原始团长名称")]
		public string OriginInstitutionName { get; set; }

		[JsonPropertyName("origin_institution_phone")]
		[Description("原始团长联系电话（返回联系电话密文，需通过 https://op.jinritemai.com/docs/api-docs/61/2829 解密）")]
		public string OriginInstitutionPhone { get; set; }

		[JsonPropertyName("origin_activity_start_time")]
		[Description("原始团长活动/托管有效期生效开始时间")]
		public string OriginActivityStartTime { get; set; }

		[JsonPropertyName("origin_activity_end_time")]
		[Description("原始团长活动/托管有效期生效结束时间")]
		public string OriginActivityEndTime { get; set; }

		[JsonPropertyName("activity_name")]
		[Description("活动名称")]
		public string ActivityName { get; set; }

		[JsonPropertyName("shop_level_is_new")]
		[Description("新手店铺标识")]
		public bool ShopLevelIsNew { get; set; }

		[JsonPropertyName("shop_score")]
		[Description("商家体验分")]
		public decimal ShopScore { get; set; }

		[JsonPropertyName("product_stock")]
		[Description("商品库存")]
		public long ProductStock { get; set; }

		[JsonPropertyName("origin_colonel_buyin_id")]
		[Description("原始团长百应 id")]
		public long OriginColonelBuyinId { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总申请数")]
	public long Total { get; set; }
}
