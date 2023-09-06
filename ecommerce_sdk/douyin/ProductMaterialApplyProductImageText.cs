namespace ecommerce.sdk.douyin;

[Description("元图文创意发布")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效入参","isv.parameter-invalid:2012004","isv检查入参")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2012001","重试或者联系")]
public class ProductMaterialApplyProductImageTextReq : IDouyinReq<ProductMaterialApplyProductImageTextRsp>
{

	public string GetMethod() { return "product.material.applyProductImageText"; }

	public string GetUrl() { return "/product/material/applyProductImageText"; }

	[JsonPropertyName("material_id")]
	[Description("(作品)素材id")]
	[NotNull]
	public long? MaterialId { get; set; }
}

[Description("元图文创意发布")]
public class ProductMaterialApplyProductImageTextRsp
{
}
