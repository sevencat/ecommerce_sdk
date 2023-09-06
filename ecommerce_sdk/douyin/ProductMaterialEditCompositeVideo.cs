namespace ecommerce.sdk.douyin;

[Description("商品元视频创意编辑")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效入参","isv.parameter-invalid:2012004","isv检查入参")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2012001","重试")]
public class ProductMaterialEditCompositeVideoReq : IDouyinReq<ProductMaterialEditCompositeVideoRsp>
{

	public string GetMethod() { return "product.material.editCompositeVideo"; }

	public string GetUrl() { return "/product/material/editCompositeVideo"; }

	[JsonPropertyName("material_id")]
	[Description("(作品)素材id")]
	[NotNull]
	public long? MaterialId { get; set; }

	[JsonPropertyName("name")]
	[Description("(作品)素材名称")]
	public string Name { get; set; }

	[JsonPropertyName("pass_through_extra")]
	[Description("扩展属性，开发者自定义数据，存放主图视频的编辑信息，平台不做逻辑处理")]
	[NotNull]
	public string PassThroughExtra { get; set; }

	[JsonPropertyName("vid")]
	[Description("资源文件uri")]
	[NotNull]
	public string Vid { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品id")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("is_direct_apply")]
	[Description("创建完是否直接发布应用，true-是，fasle-否，默认fasle；")]
	public bool? IsDirectApply { get; set; }
}

[Description("商品元视频创意编辑")]
public class ProductMaterialEditCompositeVideoRsp
{
	[JsonPropertyName("material_id")]
	[Description("(作品)素材id")]
	public long MaterialId { get; set; }
}
