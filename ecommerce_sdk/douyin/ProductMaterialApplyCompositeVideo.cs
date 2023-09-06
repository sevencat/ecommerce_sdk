namespace ecommerce.sdk.douyin;

[Description("元素材视频创意发布")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2012001","重试或者联系")]
[DouyinRetCode(40004,"非法的参数","无效入参","isv.parameter-invalid:2012004","isv检查入参")]
[DouyinRetCode(50002,"业务处理失败","素材图查询异常","isv.business-failed:20121019","重试或者联系")]
[DouyinRetCode(50002,"业务处理失败","应用素材失败","isv.business-failed:20121030","重试或者联系")]
public class ProductMaterialApplyCompositeVideoReq : IDouyinReq<ProductMaterialApplyCompositeVideoRsp>
{

	public string GetMethod() { return "product.material.applyCompositeVideo"; }

	public string GetUrl() { return "/product/material/applyCompositeVideo"; }

	[JsonPropertyName("material_id")]
	[Description("(作品)素材id")]
	[NotNull]
	public long? MaterialId { get; set; }
}

[Description("元素材视频创意发布")]
public class ProductMaterialApplyCompositeVideoRsp
{
}
