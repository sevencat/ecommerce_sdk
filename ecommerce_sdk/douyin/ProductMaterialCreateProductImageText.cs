namespace ecommerce.sdk.douyin;

[Description("商品元图文创意创建")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效入参","isv.parameter-invalid:2012004","isv检查入参")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2012001","重试")]
public class ProductMaterialCreateProductImageTextReq : IDouyinReq<ProductMaterialCreateProductImageTextRsp>
{

	public string GetMethod() { return "product.material.createProductImageText"; }

	public string GetUrl() { return "/product/material/createProductImageText"; }

	[JsonPropertyName("name")]
	[Description("素材名称")]
	public string Name { get; set; }

	[JsonPropertyName("pic_urls")]
	[Description("元数据图片列表")]
	[NotNull]
	public List<string> PicUrls { get; set; }

	[JsonPropertyName("subtitle")]
	[Description("图文讲解")]
	[NotNull]
	public string Subtitle { get; set; }

	[JsonPropertyName("bgm_id")]
	[Description("背景音乐id")]
	[NotNull]
	public string BgmId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("绑定商品id")]
	public long? ProductId { get; set; }

	[JsonPropertyName("is_direct_apply")]
	[Description("创建完是否直接发布应用，true-是，fasle-否，默认fasle；")]
	public bool? IsDirectApply { get; set; }
}

[Description("商品元图文创意创建")]
public class ProductMaterialCreateProductImageTextRsp
{
	[JsonPropertyName("material_id")]
	[Description("(作品)素材id")]
	public long MaterialId { get; set; }
}
