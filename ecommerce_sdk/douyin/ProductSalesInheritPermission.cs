namespace ecommerce.sdk.douyin;

[Description("查询店铺是否具有全网销量权限，有返回为true，无返回false；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:500","联系开发者")]
public class ProductSalesInheritPermissionReq : IDouyinReq<ProductSalesInheritPermissionRsp>
{

	public string GetMethod() { return "product.salesInherit.permission"; }

	public string GetUrl() { return "/product/salesInherit/permission"; }

}

[Description("查询店铺是否具有全网销量权限，有返回为true，无返回false；")]
public class ProductSalesInheritPermissionRsp
{
	[JsonPropertyName("success")]
	[Description("true-有权限；false-无权限")]
	public bool Success { get; set; }
}
