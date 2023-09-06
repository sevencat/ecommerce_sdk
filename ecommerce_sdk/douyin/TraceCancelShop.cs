namespace ecommerce.sdk.douyin;

[Description("在订单链路监控场景中，删除已开通用户。 用户删除后，系统不再记录并统计监控状态信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","当前用户未开通订单轨迹服务","isv.parameter-invalid:605090004","用户未开通，无需调用删除")]
[DouyinRetCode(20000,"系统错误","内部服务异常，请稍后重试","isp.service-error:605090001","内部服务异常，请稍后重试")]
public class TraceCancelShopReq : IDouyinReq<TraceCancelShopRsp>
{

	public string GetMethod() { return "trace.cancelShop"; }

	public string GetUrl() { return "/trace/cancelShop"; }

}

[Description("在订单链路监控场景中，删除已开通用户。 用户删除后，系统不再记录并统计监控状态信息")]
public class TraceCancelShopRsp
{
	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	public string ShopName { get; set; }

	[JsonPropertyName("status")]
	[Description("用户开通状态。已关闭，授权已过期")]
	public string Status { get; set; }

	[JsonPropertyName("create_at")]
	[Description("开通时间；格式：yyyy-MM-dd HH:mm:ss")]
	public string CreateAt { get; set; }

	[JsonPropertyName("update_at")]
	[Description("最后更新时间，此次为关闭时间；格式：yyyy-MM-dd HH:mm:ss")]
	public string UpdateAt { get; set; }
}
