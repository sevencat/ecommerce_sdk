namespace ecommerce.sdk.douyin;

[Description("编辑小时达活动（目前仅支持修改每人限购）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","操作不合法","isv.parameter-invalid:50100","操作不合法")]
[DouyinRetCode(50002,"业务处理失败","数据访问异常","isv.business-failed:20100","数据访问异常")]
[DouyinRetCode(50002,"业务处理失败","系统异常","isv.business-failed:20201","系统异常")]
[DouyinRetCode(50002,"业务处理失败","活动不存在","isv.business-failed:20121","活动不存在")]
[DouyinRetCode(50002,"业务处理失败","活动校验不通过","isv.business-failed:20122","活动校验不通过")]
[DouyinRetCode(50002,"业务处理失败","活动创建/更新失败","isv.business-failed:20123","活动创建/更新失败")]
[DouyinRetCode(50002,"业务处理失败","商品不存在","isv.business-failed:20124","商品不存在")]
[DouyinRetCode(50002,"业务处理失败","查询店铺信息异常","isv.business-failed:20125","查询店铺信息异常")]
[DouyinRetCode(50002,"业务处理失败","查询门店信息异常","isv.business-failed:20126","查询门店信息异常")]
[DouyinRetCode(50002,"业务处理失败","商品中心/商品服务错误","isv.business-failed:20221","商品中心/商品服务错误")]
[DouyinRetCode(50002,"业务处理失败","商达营销服务错误","isv.business-failed:20222","商达营销服务错误")]
[DouyinRetCode(50002,"业务处理失败","库存中心服务错误","isv.business-failed:20223","库存中心服务错误")]
[DouyinRetCode(50002,"业务处理失败","营销中心服务错误","isv.business-failed:20224","营销中心服务错误")]
[DouyinRetCode(50002,"业务处理失败","商品中心/商品服务错误","isv.business-failed:20225","商品中心/商品服务错误")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40100","参数错误")]
public class SupermPopEditActivityReq : IDouyinReq<SupermPopEditActivityRsp>
{

	public string GetMethod() { return "superm.pop.editActivity"; }

	public string GetUrl() { return "/superm/pop/editActivity"; }

	[JsonPropertyName("sd_activity_id")]
	[Description("商达活动id")]
	[NotNull]
	public string SdActivityId { get; set; }

	[JsonPropertyName("main_skus")]
	[Description("主商品sku信息列表")]
	[NotNull]
	public List<MainSkusItem> MainSkus { get; set; }

	public class MainSkusItem
	{
		[JsonPropertyName("sku_id")]
		[Description("主品skuid")]
		[NotNull]
		public string SkuId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("主品id")]
		[NotNull]
		public string ProductId { get; set; }

		[JsonPropertyName("sub_skus")]
		[Description("子商品sku信息列表")]
		[NotNull]
		public List<SubSkusItem> SubSkus { get; set; }

		public class SubSkusItem
		{
			[JsonPropertyName("sku_id")]
			[Description("子品skuid")]
			[NotNull]
			public string SkuId { get; set; }

			[JsonPropertyName("user_limit")]
			[Description("每人限购")]
			public long? UserLimit { get; set; }

			[JsonPropertyName("product_id")]
			[Description("子品id")]
			[NotNull]
			public string ProductId { get; set; }
		}
	}
}

[Description("编辑小时达活动（目前仅支持修改每人限购）")]
public class SupermPopEditActivityRsp
{
	[JsonPropertyName("sd_activity_id")]
	[Description("商达活动id")]
	public string SdActivityId { get; set; }
}
