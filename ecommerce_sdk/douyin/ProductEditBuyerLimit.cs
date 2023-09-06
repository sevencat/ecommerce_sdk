namespace ecommerce.sdk.douyin;

[Description("编辑商品限购信息。编辑提交后默认自动提交审核，审核通过后，更新线上数据。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","该商品在审核中，不允许编辑","isp.service-error:2010004","-")]
[DouyinRetCode(20000,"系统错误","类目属性填写不完整，请重新进入页面进行补充","isp.service-error:2010003","-")]
public class ProductEditBuyerLimitReq : IDouyinReq<ProductEditBuyerLimitRsp>
{

	public string GetMethod() { return "product.editBuyerLimit"; }

	public string GetUrl() { return "/product/editBuyerLimit"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("maximum_per_order")]
	[Description("每个用户每次下单限购件数")]
	public long? MaximumPerOrder { get; set; }

	[JsonPropertyName("limit_per_buyer")]
	[Description("每个用户累计限购件数")]
	public long? LimitPerBuyer { get; set; }

	[JsonPropertyName("minimum_per_order")]
	[Description("每个用户每次下单至少购买的件数 ")]
	public long? MinimumPerOrder { get; set; }
}

[Description("编辑商品限购信息。编辑提交后默认自动提交审核，审核通过后，更新线上数据。")]
public class ProductEditBuyerLimitRsp
{
}
