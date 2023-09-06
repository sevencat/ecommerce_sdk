namespace ecommerce.sdk.douyin;

[Description("在订单链路监控场景中，检查用户是否开通，返回用户开通信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","当前用户未开通订单轨迹服务","isv.parameter-invalid:605090004","用户未开通，可调用/trace/addShop接口进行开通")]
[DouyinRetCode(20000,"系统错误","内部服务异常，请稍后重试","isp.service-error:605090001","内部服务异常，请稍后重试")]
public class TraceCheckShopReq : IDouyinReq<TraceCheckShopRsp>
{

	public string GetMethod() { return "trace.checkShop"; }

	public string GetUrl() { return "/trace/checkShop"; }

}

[Description("在订单链路监控场景中，检查用户是否开通，返回用户开通信息")]
public class TraceCheckShopRsp
{
	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	public string ShopName { get; set; }

	[JsonPropertyName("status")]
	[Description("开通状态。正常，授权失效，已关闭，未开启")]
	public string Status { get; set; }

	[JsonPropertyName("create_at")]
	[Description("开通时间；格式：yyyy-MM-dd HH:mm:ss")]
	public string CreateAt { get; set; }

	[JsonPropertyName("update_at")]
	[Description("最近更新时间；格式：yyyy-MM-dd HH:mm:ss")]
	public string UpdateAt { get; set; }
}
