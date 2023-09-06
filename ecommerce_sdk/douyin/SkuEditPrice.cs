namespace ecommerce.sdk.douyin;

[Description("编辑sku价格")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","系统错误:商品已删除，不可更新","isv.parameter-invalid:7","请重新选择商品")]
[DouyinRetCode(40004,"非法的参数","sku_id: 17040531912765881, 找不到对应的sku","isv.parameter-invalid:5","请检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","out_sku_id错误, 无法定位到sku","isv.parameter-invalid:4","请检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","2010401:请求被限流, 请稍后再试","isv.business-failed:2010401","请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","2010013:获取账号信息失败","isv.business-failed:2010013","请稍后再试")]
public class SkuEditPriceReq : IDouyinReq<SkuEditPriceRsp>
{

	public string GetMethod() { return "sku.editPrice"; }

	public string GetUrl() { return "/sku/editPrice"; }

	[JsonPropertyName("price")]
	[Description("售价 (单位 分)")]
	[NotNull]
	public long? Price { get; set; }

	[JsonPropertyName("code")]
	[Description("sku编码")]
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

	[JsonPropertyName("store_id")]
	[Description("小时达店铺场景才可以传，小时达场景可以通过传入主品id+门店id对该门店下的子品进行操作")]
	public long? StoreId { get; set; }
}

[Description("编辑sku价格")]
public class SkuEditPriceRsp
{
}
