namespace ecommerce.sdk.douyin;

[Description("获取前端明文解密token")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","数据加密失败，请稍后重试","isv.business-failed:300001","请稍后重试")]
public class OrderGetMCTokenReq : IDouyinReq<OrderGetMCTokenRsp>
{

	public string GetMethod() { return "order.getMCToken"; }

	public string GetUrl() { return "/order/getMCToken"; }

}

[Description("获取前端明文解密token")]
public class OrderGetMCTokenRsp
{
	[JsonPropertyName("token")]
	[Description("前端明文解密token")]
	public string Token { get; set; }

	[JsonPropertyName("expire_time")]
	[Description("token过期时间")]
	public long ExpireTime { get; set; }
}
