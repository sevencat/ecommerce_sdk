namespace ecommerce.sdk.douyin;

[Description("通过店铺订单号获取购买用户的隐私小号")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20001,"内部服务超时","1103:请求内部服务超时","isp.service-timeout-error:1103","请重试")]
public class YuncGetVirtualMobileReq : IDouyinReq<YuncGetVirtualMobileRsp>
{

	public string GetMethod() { return "yunc.getVirtualMobile"; }

	public string GetUrl() { return "/yunc/getVirtualMobile"; }

	[JsonPropertyName("platform_order_no")]
	[Description("店铺父订单号，抖店平台生成，平台下唯一")]
	[NotNull]
	public string PlatformOrderNo { get; set; }

	[JsonPropertyName("out_order_no")]
	[Description("ERP单号")]
	[NotNull]
	public string OutOrderNo { get; set; }
}

[Description("通过店铺订单号获取购买用户的隐私小号")]
public class YuncGetVirtualMobileRsp
{
	[JsonPropertyName("is_new_create")]
	[Description("是否新创建")]
	public bool IsNewCreate { get; set; }

	[JsonPropertyName("mobile_virtual")]
	[Description("虚拟号值")]
	public string MobileVirtual { get; set; }

	[JsonPropertyName("expire_time")]
	[Description("虚拟号过期时间，格式为yyyy-MM-dd HH:mm:ss，时区为GMT+8，例如：2016-01-01 12:00:00")]
	public string ExpireTime { get; set; }
}
