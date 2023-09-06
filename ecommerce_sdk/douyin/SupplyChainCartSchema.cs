namespace ecommerce.sdk.douyin;

[Description("跨境类自营店铺二级承接页跳转购物车schema")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","网络错误，请稍后重试","isv.business-failed:300","网络错误，请稍后重试")]
public class SupplyChainCartSchemaReq : IDouyinReq<SupplyChainCartSchemaRsp>
{

	public string GetMethod() { return "supplyChain.cartSchema"; }

	public string GetUrl() { return "/supplyChain/cartSchema"; }

	[JsonPropertyName("ecom_scene_id")]
	[Description("购物车schema场景化ID")]
	public string EcomSceneId { get; set; }
}

[Description("跨境类自营店铺二级承接页跳转购物车schema")]
public class SupplyChainCartSchemaRsp
{
	[JsonPropertyName("url")]
	[Description("跳转购物车的schema")]
	public string Url { get; set; }
}
