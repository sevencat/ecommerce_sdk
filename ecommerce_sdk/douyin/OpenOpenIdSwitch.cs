namespace ecommerce.sdk.douyin;

[Description("提供抖音和抖店 Openid 转换功能")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","入参不合法","isv.parameter-invalid:100001","请检查入参")]
[DouyinRetCode(50002,"业务处理失败","查询应用和小程序绑定关系失败","isv.business-failed:300010","检查应用和小程序绑定关系")]
[DouyinRetCode(40004,"非法的参数","入参不合法","isv.parameter-invalid:100000","请检查入参")]
public class OpenOpenIdSwitchReq : IDouyinReq<OpenOpenIdSwitchRsp>
{

	public string GetMethod() { return "open.openIdSwitch"; }

	public string GetUrl() { return "/open/openIdSwitch"; }

	[JsonPropertyName("open_id")]
	[Description("传入的openId")]
	[NotNull]
	public string OpenId { get; set; }

	[JsonPropertyName("open_id_type")]
	[Description("openId类型，1-抖音openId 2-抖店openId")]
	public int? OpenIdType { get; set; }
}

[Description("提供抖音和抖店 Openid 转换功能")]
public class OpenOpenIdSwitchRsp
{
	[JsonPropertyName("open_id")]
	[Description("对应的openId")]
	public string OpenId { get; set; }

	[JsonPropertyName("open_id_type")]
	[Description("openId类型，1-抖音openId 2-抖店openId")]
	public int OpenIdType { get; set; }
}
