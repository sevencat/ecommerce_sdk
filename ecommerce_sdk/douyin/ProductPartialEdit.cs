namespace ecommerce.sdk.douyin;

[Description("对部分字段进行编辑，基于线上数据构建商品信息 。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","非法参数","isv.parameter-invalid:2010004","请检查参数后重试")]
[DouyinRetCode(60000,"触发限流，请稍后重试","更新商品太频繁，操作失败请重试","isp.traffic-limited:2010067","稍后重试")]
[DouyinRetCode(40002,"缺少必选参数","缺少参数","isv.missing-parameter:2010003","重新进入页面进行补充")]
[DouyinRetCode(50002,"业务处理失败","该商品在审核中","isv.business-failed:2010041","不允许编辑")]
[DouyinRetCode(50002,"业务处理失败","该商品已删除","isv.business-failed:2010042","不允许编辑")]
[DouyinRetCode(50002,"业务处理失败","该商品已封禁","isv.business-failed:2010043","不允许编辑")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2010001","稍后重试")]
[DouyinRetCode(20000,"系统错误","请求超时","isp.service-error:2010002","稍后重试")]
[DouyinRetCode(40004,"非法的参数","无访问权限","isv.parameter-invalid:2010005","核对后重试")]
[DouyinRetCode(40004,"非法的参数","编辑商品失败","isv.parameter-invalid:2010011","稍后重试")]
[DouyinRetCode(20000,"系统错误","保存商品失败","isp.service-error:2010012","稍后重试")]
[DouyinRetCode(20000,"系统错误","读取失败","isp.service-error:2010013","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","商品状态错误","isv.business-failed:2010022","检查状态后重试")]
[DouyinRetCode(50002,"业务处理失败","商品正在参加活动","isv.business-failed:2010045","暂不支持修改")]
[DouyinRetCode(20000,"系统错误","获取类目信息失败","isp.service-error:2010201","重试")]
[DouyinRetCode(20000,"系统错误","获取类目配置失败","isp.service-error:2010202","重试")]
[DouyinRetCode(20000,"系统错误","查询品牌库失败","isp.service-error:2010206","重试")]
[DouyinRetCode(20000,"系统错误","查询商家资质失败","isp.service-error:2010207","查询商家资质失败，请重试")]
[DouyinRetCode(50002,"业务处理失败","2010501:商品标题未明确描述商品品名，请重新填写","isv.business-failed:2010501","商品标题未明确描述商品品名，请重新填写")]
[DouyinRetCode(50002,"业务处理失败","2010326:因为店铺受到处罚，限制发品，更多请到商家后台奖惩中心查看","isv.business-failed:2010326","因为店铺受到处罚，限制发品，更多请到商家后台奖惩中心查看")]
[DouyinRetCode(50002,"业务处理失败","2010316:该类目需要支持7天无理由退货","isv.business-failed:2010316","因为店铺受到处罚，限制发品，更多请到商家后台奖惩中心查看")]
[DouyinRetCode(50002,"业务处理失败","2010058:商品不存在","isv.business-failed:2010058","商品不存在")]
[DouyinRetCode(50002,"业务处理失败","2010321:适用场景为必填属性，且可选择的属性值不包括其他/others休闲，请重新进入页面补充","isv.business-failed:2010321","适用场景为必填属性，且可选择的属性值不包括其他/others休闲，请重新进入页面补充")]
[DouyinRetCode(50002,"业务处理失败","2010107:当前价格或商品起购件数不符合平台要求","isv.business-failed:2010107","当前价格或商品起购件数不符合平台要求")]
[DouyinRetCode(50002,"业务处理失败","2147483647:存在审批中素材，请等待审批","isv.business-failed:2147483647","存在审批中素材，请等待审批")]
public class ProductPartialEditReq : IDouyinReq<ProductPartialEditRsp>
{

	public string GetMethod() { return "product.partialEdit"; }

	public string GetUrl() { return "/product/partialEdit"; }

	[JsonPropertyName("product_id")]
	[Description("商品id")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("name")]
	[Description("商品名称")]
	public string Name { get; set; }

	[JsonPropertyName("shop_category")]
	[Description("店铺分类参数")]
	public ShopCategoryItem ShopCategory { get; set; }

	public class ShopCategoryItem
	{
		[JsonPropertyName("leaf_category_ids")]
		[Description("店铺叶子分类id，为[]表示清空商品店铺分类")]
		public List<long> LeafCategoryIds { get; set; }
	}

	[JsonPropertyName("short_product_name")]
	[Description("商品短标题")]
	public string ShortProductName { get; set; }
}

[Description("对部分字段进行编辑，基于线上数据构建商品信息 。")]
public class ProductPartialEditRsp
{
}
