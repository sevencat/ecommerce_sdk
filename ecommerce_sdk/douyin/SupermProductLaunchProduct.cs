namespace ecommerce.sdk.douyin;

[Description("上架商品")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","2010004:商品已删除，请先将商品恢复，再做修改","isv.business-failed:2010004","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010316:该类目需要支持7天无理由退货","isv.business-failed:2010316","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010063:当前店铺在架商品量已达上限，暂无法创建商品，详细规则可查看商品数限额实施细则","isv.business-failed:2010063","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010044:此类目已调整升级，请重新选择类目进行商品发布","isv.business-failed:2010044","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010101:请上传包装标签图","isv.business-failed:2010101","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010102:系统检测审核不通过，内容未做修改，请修改后提交审核","isv.business-failed:2010102","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010067:更新商品太频繁，操作失败请重试","isv.business-failed:2010067","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010001:系统异常,请重试","isv.business-failed:2010001","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010013:获取店铺类目失败","isv.business-failed:2010013","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010207:查询商家资质失败，请重试","isv.business-failed:2010207","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010202:获取类目配置失败","isv.business-failed:2010202","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010206:查询品牌库失败，请重试","isv.business-failed:2010206","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010348:门店未绑定绑定限售模板","isv.business-failed:2010348","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010203:获取商品信息失败","isv.business-failed:2010203","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010347:门店未绑定运费模板","isv.business-failed:2010347","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010329:当前店铺类型下，不支持在该类目发布此品牌商品。您可查看对应“行业管理规范”的入驻方式。请跳转https://zjsms.com/FFTUJsB/","isv.business-failed:2010329","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010005:商品分类仅支持选择当前店铺开通的一级类目，请核对","isv.business-failed:2010005","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010012:当前商品的部分SKU库存不得低于活动/达人专属价设置的0，可到营销中心修改对应的活动/达人专属价库存，或直接修改当前商品库存数。","isv.business-failed:2010012","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010320:品牌必填，请重新选择品牌","isv.business-failed:2010320","请检查重试")]
[DouyinRetCode(50002,"业务处理失败","2010058:商品不存在或已彻底删除","isv.business-failed:2010058","请检查重试")]
public class SupermProductLaunchProductReq : IDouyinReq<SupermProductLaunchProductRsp>
{

	public string GetMethod() { return "superm.product.launchProduct"; }

	public string GetUrl() { return "/superm/product/launchProduct"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID，支持主品上架，支持子品上架； (主品需要审核通过后上架)")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("outer_product_id")]
	[Description("推荐使用，外部商家编码，支持字符串。")]
	public string OuterProductId { get; set; }

	[JsonPropertyName("store_id")]
	[Description("小时达二期店铺场景才可以传，小时达二期场景可以通过传入主品id+门店id对该门店下的子品进行操作")]
	public long? StoreId { get; set; }
}

[Description("上架商品")]
public class SupermProductLaunchProductRsp
{
}
