namespace ecommerce.sdk.douyin;

[Description("修改sku编码")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","系统错误:商品已删除，不可更新","isv.parameter-invalid:7","请重新选择商品")]
[DouyinRetCode(40002,"缺少必选参数","缺少sku_id参数","isv.missing-parameter:4","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","找不到对应的sku","isv.business-failed:5","请检查sku信息")]
public class SkuEditCodeReq : IDouyinReq<SkuEditCodeRsp>
{

	public string GetMethod() { return "sku.editCode"; }

	public string GetUrl() { return "/sku/editCode"; }

	[JsonPropertyName("code")]
	[Description("编码")]
	public string Code { get; set; }

	[JsonPropertyName("sku_id")]
	[Description("skuid")]
	public long? SkuId { get; set; }

	[JsonPropertyName("out_sku_id")]
	[Description("外部skuid")]
	public long? OutSkuId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品id")]
	public long? ProductId { get; set; }

	[JsonPropertyName("out_product_id")]
	[Description("外部商品id")]
	public long? OutProductId { get; set; }
}

[Description("修改sku编码")]
public class SkuEditCodeRsp
{
}
