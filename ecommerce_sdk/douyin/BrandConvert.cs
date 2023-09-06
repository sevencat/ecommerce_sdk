namespace ecommerce.sdk.douyin;

[Description("老用户发商品用的是 /shop/brandList 接口获取品牌关系id，新版发布做了调整，需要使用品牌库的品牌id，这个接口可以将品牌关系id转为品牌id")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","品牌授权信息不存在","isv.business-failed:2010004","品牌授权信息不存在，请检查")]
[DouyinRetCode(50002,"业务处理失败","查询品牌授权信息失败","isv.business-failed:2010001","请稍后重试")]
public class BrandConvertReq : IDouyinReq<BrandConvertRsp>
{

	public string GetMethod() { return "brand.convert"; }

	public string GetUrl() { return "/brand/convert"; }

	[JsonPropertyName("related_id")]
	[Description("品牌关系id，即/shop/brandList返回的id")]
	[NotNull]
	public long? RelatedId { get; set; }
}

[Description("老用户发商品用的是 /shop/brandList 接口获取品牌关系id，新版发布做了调整，需要使用品牌库的品牌id，这个接口可以将品牌关系id转为品牌id")]
public class BrandConvertRsp
{
	[JsonPropertyName("brand_id")]
	[Description("品牌id，对应商品发布接口standard_brand_id字段")]
	public long BrandId { get; set; }
}
