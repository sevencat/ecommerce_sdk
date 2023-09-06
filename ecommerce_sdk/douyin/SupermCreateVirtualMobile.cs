namespace ecommerce.sdk.douyin;

[Description("通过店铺订单号获取购买用户的隐私小号")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","数据转换错误","isv.business-failed:50202","请通过错误信息排查问题")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:20100","请通过错误信息排查问题")]
[DouyinRetCode(40004,"非法的参数","非法的请求参数","isv.parameter-invalid:40100","请确认请求参数是否正确")]
[DouyinRetCode(40002,"缺少必选参数","缺失必传参数","isv.missing-parameter:40000","请确认缺失的必传参数")]
[DouyinRetCode(50002,"业务处理失败","配置信息错误","isv.business-failed:50203","请排查配置信息错误")]
public class SupermCreateVirtualMobileReq : IDouyinReq<SupermCreateVirtualMobileRsp>
{

	public string GetMethod() { return "superm.createVirtualMobile"; }

	public string GetUrl() { return "/superm/createVirtualMobile"; }

	[JsonPropertyName("shop_order_id")]
	[Description("店铺订单编号")]
	[NotNull]
	public long? ShopOrderId { get; set; }
}

[Description("通过店铺订单号获取购买用户的隐私小号")]
public class SupermCreateVirtualMobileRsp
{
	[JsonPropertyName("mobile_info")]
	[Description("获取虚拟号返回结果信息")]
	public MobileInfoItem MobileInfo { get; set; }

	public class MobileInfoItem
	{
		[JsonPropertyName("is_new_create")]
		[Description("是否是新创建的虚拟号码")]
		public bool IsNewCreate { get; set; }

		[JsonPropertyName("mobile_virtual")]
		[Description("虚拟号码")]
		public string MobileVirtual { get; set; }

		[JsonPropertyName("expire_time")]
		[Description("虚拟号码的过期时间")]
		public string ExpireTime { get; set; }
	}
}
