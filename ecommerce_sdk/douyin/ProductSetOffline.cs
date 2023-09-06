namespace ecommerce.sdk.douyin;

[Description("1、支持所有类型商品下架,2、接口调用成功，商品会放到仓库中。,3、商品上架请使用【product/editV2】商品更新接口，请求参数传值commit=true即表示提交上架。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","【状态非法】商品状态错误, 当前状态: 删除","isv.parameter-invalid:2010022","请重新选择商品")]
[DouyinRetCode(40004,"非法的参数","【重复操作】商品操作重复，当前状态：下架","isv.parameter-invalid:2010021","请重新选择商品")]
[DouyinRetCode(40004,"非法的参数","下架失败，该商品正在参加平台秒杀-抖in好物池（自播专入），暂不支持下架","isv.parameter-invalid:2010005","请重新选择商品")]
[DouyinRetCode(40004,"非法的参数","奖品商品不支持下架","isv.parameter-invalid:2010004","请重新选择商品")]
[DouyinRetCode(40004,"非法的参数","缺少必要参数","isv.parameter-invalid:20024","请检查参数后重试")]
[DouyinRetCode(40004,"非法的参数","商户状态不合法","isv.parameter-invalid:10008","请检查店铺状态")]
[DouyinRetCode(50002,"业务处理失败","请求超时","isv.business-failed:2010002","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","更新商品失败","isv.business-failed:2010001","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","商品正在参加平台活动，无法下架商品","isv.business-failed:2010045","商品正在参加平台活动，无法下架商品")]
[DouyinRetCode(50002,"业务处理失败","商品不存在","isv.business-failed:2010064","请检查product_id信息")]
[DouyinRetCode(50002,"业务处理失败","2010058:商品不存在","isv.business-failed:2010058","请检查product_id信息")]
[DouyinRetCode(50002,"业务处理失败","2010401:请求被限流, 请稍后再试","isv.business-failed:2010401","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","2010013:获取账号信息失败","isv.business-failed:2010013","请稍后重试")]
public class ProductSetOfflineReq : IDouyinReq<ProductSetOfflineRsp>
{

	public string GetMethod() { return "product.setOffline"; }

	public string GetUrl() { return "/product/setOffline"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("outer_product_id")]
	[Description("推荐使用，外部商家编码，支持字符串。")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("store_id")]
	[Description("小时达二期店铺场景才可以传，小时达二期场景可以通过传入主品id+门店id对该门店下的子品进行操作")]
	public long? StoreId { get; set; }
}

[Description("1、支持所有类型商品下架,2、接口调用成功，商品会放到仓库中。,3、商品上架请使用【product/editV2】商品更新接口，请求参数传值commit=true即表示提交上架。")]
public class ProductSetOfflineRsp
{
}
