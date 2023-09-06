namespace ecommerce.sdk.douyin;

[Description("商品元图文创意查询")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效入参","isv.parameter-invalid:2012004","isv检查入参")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2012001","重试")]
[DouyinRetCode(50002,"业务处理失败","查询失败","isv.business-failed:2012013","重试或者联系")]
public class ProductMaterialListProductImageTextReq : IDouyinReq<ProductMaterialListProductImageTextRsp>
{

	public string GetMethod() { return "product.material.listProductImageText"; }

	public string GetUrl() { return "/product/material/listProductImageText"; }

	[JsonPropertyName("page")]
	[Description("当前页数，从0开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("一页数量")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("status")]
	[Description("作品(素材)状态")]
	public List<long> Status { get; set; }

	[JsonPropertyName("material_ids")]
	[Description("作品(素材)id")]
	public List<long> MaterialIds { get; set; }

	[JsonPropertyName("process_status")]
	[Description("(作品)素材业务状态")]
	public long? ProcessStatus { get; set; }
}

[Description("商品元图文创意查询")]
public class ProductMaterialListProductImageTextRsp
{
	[JsonPropertyName("total")]
	[Description("查询总数")]
	public long Total { get; set; }

	[JsonPropertyName("data")]
	[Description("数据")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("status")]
		[Description("作品状态")]
		public long Status { get; set; }

		[JsonPropertyName("process_status")]
		[Description("作品发布状态")]
		public long ProcessStatus { get; set; }

		[JsonPropertyName("material_id")]
		[Description("(作品)素材id")]
		public long MaterialId { get; set; }

		[JsonPropertyName("name")]
		[Description("(作品)素材名称")]
		public string Name { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺id")]
		public long ShopId { get; set; }

		[JsonPropertyName("source_id")]
		[Description("来源id")]
		public string SourceId { get; set; }

		[JsonPropertyName("pic_urls")]
		[Description("图片url列表")]
		public List<string> PicUrls { get; set; }

		[JsonPropertyName("subtitle")]
		[Description("图文讲解")]
		public string Subtitle { get; set; }

		[JsonPropertyName("bgm_id")]
		[Description("背景音乐id")]
		public string BgmId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("商品id")]
		public long ProductId { get; set; }
	}
}
