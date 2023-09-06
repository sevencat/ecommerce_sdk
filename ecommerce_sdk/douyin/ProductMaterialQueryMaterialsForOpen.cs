namespace ecommerce.sdk.douyin;

[Description("查询作品素材信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","素材查询异常","isv.business-failed:20121019","联系或者重试")]
[DouyinRetCode(40004,"非法的参数","无效入参","isv.parameter-invalid:2012004","请重新校验入参")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2012001","联系或者重试")]
public class ProductMaterialQueryMaterialsForOpenReq : IDouyinReq<ProductMaterialQueryMaterialsForOpenRsp>
{

	public string GetMethod() { return "product.material.QueryMaterialsForOpen"; }

	public string GetUrl() { return "/product/material/QueryMaterialsForOpen"; }

	[JsonPropertyName("product_ids")]
	[Description("商品id列表")]
	public List<long> ProductIds { get; set; }

	[JsonPropertyName("material_types")]
	[Description("素材类型 0-主图视频 1-白底图")]
	public List<long> MaterialTypes { get; set; }

	[JsonPropertyName("material_status")]
	[Description("素材状态 -1:已删除 0:待发布 1:审核中 2:已上线 3:审核未通过")]
	public List<long> MaterialStatus { get; set; }

	[JsonPropertyName("material_ids")]
	[Description("作品素材id列表")]
	public List<long> MaterialIds { get; set; }
}

[Description("查询作品素材信息")]
public class ProductMaterialQueryMaterialsForOpenRsp
{
	[JsonPropertyName("materials")]
	[Description("作品素材列表")]
	public List<MaterialsItem> Materials { get; set; }

	public class MaterialsItem
	{
		[JsonPropertyName("material_id")]
		[Description("作品素材id")]
		public long MaterialId { get; set; }

		[JsonPropertyName("material_type")]
		[Description("作品素材类型，0-主图视频")]
		public long MaterialType { get; set; }

		[JsonPropertyName("material_status")]
		[Description("作品素材状态：-1:已删除 0:待发布 1:审核中 2:已上线 3:审核未通过")]
		public long MaterialStatus { get; set; }

		[JsonPropertyName("reject_reason")]
		[Description("审核拒绝理由")]
		public string RejectReason { get; set; }

		[JsonPropertyName("create_time")]
		[Description("作品素材创建时间(秒)")]
		public long CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("作品素材更新时间(秒)")]
		public long UpdateTime { get; set; }

		[JsonPropertyName("audit_time")]
		[Description("作品素材审核时间(秒)")]
		public long AuditTime { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品id")]
		public long ProductId { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺id")]
		public long ShopId { get; set; }
	}
}
