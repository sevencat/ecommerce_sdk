namespace ecommerce.sdk.douyin;

[Description("返回某个叶子类目下的可用品牌列表，没有品牌授权限制的类目支持前缀搜索")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数category_id缺失","isv.parameter-invalid:2010004","请检查是否输入了category_id参数")]
[DouyinRetCode(20000,"系统错误","查询数据失败，系统异常","isp.service-error:2010001","请重试")]
[DouyinRetCode(50002,"业务处理失败","2010013:获取账号信息失败","isv.business-failed:2010013","请重试")]
public class BrandListReq : IDouyinReq<BrandListRsp>
{

	public string GetMethod() { return "brand.list"; }

	public string GetUrl() { return "/brand/list"; }

	[JsonPropertyName("categories")]
	[Description("（已停止使用）类目列表")]
	public List<long> Categories { get; set; }

	[JsonPropertyName("offset")]
	[Description("（已停止使用）起始位")]
	public long? Offset { get; set; }

	[JsonPropertyName("size")]
	[Description("（已停止使用）单次最大条数")]
	public long? Size { get; set; }

	[JsonPropertyName("sort")]
	[Description("（已停止使用）排序顺序，默认为倒排 0:降序, 1:升序")]
	public int? Sort { get; set; }

	[JsonPropertyName("status")]
	[Description("（已停止使用）品牌状态 1:审核中, 2:审核通过, 3:审核拒绝")]
	public int? Status { get; set; }

	[JsonPropertyName("full_brand_info")]
	[Description("（已停止使用）是否返回完全的品牌信息")]
	public bool? FullBrandInfo { get; set; }

	[JsonPropertyName("category_id")]
	[Description("（推荐使用，必填）类目id")]
	public long? CategoryId { get; set; }

	[JsonPropertyName("query")]
	[Description("品牌前缀（中文或者英文），适用于不需要品牌资质的场景，根据前缀搜索品牌")]
	public string Query { get; set; }

	[JsonPropertyName("brand_ids")]
	[Description("（选填）品牌ids，传了品牌ids默认直接拿品牌id搜索并返回结果(放在brand_list里)，不会使用其他入参")]
	public List<long> BrandIds { get; set; }
}

[Description("返回某个叶子类目下的可用品牌列表，没有品牌授权限制的类目支持前缀搜索")]
public class BrandListRsp
{
	[JsonPropertyName("brand_ids")]
	[Description("（已停止使用）品牌id列表")]
	public List<long> BrandIds { get; set; }

	[JsonPropertyName("brand_infos")]
	[Description("（已停止使用）品牌信息")]
	public Dictionary<long,BrandInfosItem> BrandInfos { get; set; }

	public class BrandInfosItem
	{
		[JsonPropertyName("brand_id")]
		[Description("品牌id")]
		public long BrandId { get; set; }

		[JsonPropertyName("brand_name_c_n")]
		[Description("品牌中文名")]
		public string BrandNameCN { get; set; }

		[JsonPropertyName("brand_name_e_n")]
		[Description("品牌英文名")]
		public string BrandNameEN { get; set; }

		[JsonPropertyName("level")]
		[Description("品牌评级 0-4")]
		public int Level { get; set; }

		[JsonPropertyName("status")]
		[Description("品牌状态 1:上线, 2:下线")]
		public int Status { get; set; }

		[JsonPropertyName("brand_alias")]
		[Description("品牌别名")]
		public List<string> BrandAlias { get; set; }

		[JsonPropertyName("create_timestamp")]
		[Description("创建时间")]
		public long CreateTimestamp { get; set; }

		[JsonPropertyName("update_timestamp")]
		[Description("更新时间")]
		public long UpdateTimestamp { get; set; }

		[JsonPropertyName("audit_status")]
		[Description("品牌审核状态 1:审核中, 2:审核通过, 3:审核拒绝, 4:送审失败")]
		public int AuditStatus { get; set; }

		[JsonPropertyName("biz_type")]
		[Description("业务类型 0:国内, 1:跨境电商, 2:广告")]
		public int BizType { get; set; }

		[JsonPropertyName("logo")]
		[Description("品牌logo地址")]
		public string Logo { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("（已停止使用）总数")]
	public long Total { get; set; }

	[JsonPropertyName("has_more")]
	[Description("（已停止使用）还有更多")]
	public bool HasMore { get; set; }

	[JsonPropertyName("auth_required")]
	[Description("类目是否要求品牌有授权")]
	public bool AuthRequired { get; set; }

	[JsonPropertyName("auth_brand_list")]
	[Description("授权的品牌列表")]
	public List<AuthBrandListItem> AuthBrandList { get; set; }

	public class AuthBrandListItem
	{
		[JsonPropertyName("brand_id")]
		[Description("品牌id")]
		public long BrandId { get; set; }

		[JsonPropertyName("name_cn")]
		[Description("中文名")]
		public string NameCn { get; set; }

		[JsonPropertyName("name_en")]
		[Description("英文名")]
		public string NameEn { get; set; }
	}

	[JsonPropertyName("brand_list")]
	[Description("未授权的品牌列表")]
	public List<BrandListIItem> BrandListI { get; set; }

	public class BrandListIItem
	{
		[JsonPropertyName("brand_id")]
		[Description("品牌id")]
		public long BrandId { get; set; }

		[JsonPropertyName("name_cn")]
		[Description("中文名")]
		public string NameCn { get; set; }

		[JsonPropertyName("name_en")]
		[Description("英文名")]
		public string NameEn { get; set; }
	}
}
