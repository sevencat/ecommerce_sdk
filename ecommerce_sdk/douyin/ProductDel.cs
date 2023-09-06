namespace ecommerce.sdk.douyin;

[Description("删除商品")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","商品删除失败: 【重复操作】商品操作重复，当前状态：删除","isv.parameter-invalid:7","请重新选择商品")]
[DouyinRetCode(40004,"非法的参数","根据out_product_id找不到商品信息","isv.parameter-invalid:4","请检查参数后重试")]
public class ProductDelReq : IDouyinReq<ProductDelRsp>
{

	public string GetMethod() { return "product.del"; }

	public string GetUrl() { return "/product/del"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	public long? ProductId { get; set; }

	[JsonPropertyName("out_product_id")]
	[Description("外部商品ID")]
	public long? OutProductId { get; set; }

	[JsonPropertyName("delete_forever")]
	[Description("是否彻底删除")]
	public bool? DeleteForever { get; set; }
}

[Description("删除商品")]
public class ProductDelRsp
{
}
