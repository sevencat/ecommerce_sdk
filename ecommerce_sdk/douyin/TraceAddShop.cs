namespace ecommerce.sdk.douyin;

[Description("在订单链路监控场景中，添加用户。 用户添加后能自动记录并统计监控状态信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","当前应用与店铺间授权失效","isv.parameter-invalid:605010102","请检查店铺授权")]
[DouyinRetCode(20000,"系统错误","内部服务异常，请稍后重试","isp.service-error:605090001","内部服务异常，请稍后重试")]
public class TraceAddShopReq : IDouyinReq<TraceAddShopRsp>
{

	public string GetMethod() { return "trace.addShop"; }

	public string GetUrl() { return "/trace/addShop"; }

}

[Description("在订单链路监控场景中，添加用户。 用户添加后能自动记录并统计监控状态信息")]
public class TraceAddShopRsp
{
	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	public string ShopName { get; set; }

	[JsonPropertyName("status")]
	[Description("开通状态。正常，授权失效，已关闭")]
	public string Status { get; set; }

	[JsonPropertyName("create_at")]
	[Description("开通时间；格式：yyyy-MM-dd HH:mm:ss")]
	public string CreateAt { get; set; }

	[JsonPropertyName("update_at")]
	[Description("最近更新时间；格式：yyyy-MM-dd HH:mm:ss")]
	public string UpdateAt { get; set; }
}
