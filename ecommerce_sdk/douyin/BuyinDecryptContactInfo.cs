namespace ecommerce.sdk.douyin;

[Description("接口用于解密团长相关接口返回的联系方式密文")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
public class BuyinDecryptContactInfoReq : IDouyinReq<BuyinDecryptContactInfoRsp>
{

	public string GetMethod() { return "buyin.decryptContactInfo"; }

	public string GetUrl() { return "/buyin/decryptContactInfo"; }

	[JsonPropertyName("text")]
	[Description("联系方式密文")]
	[NotNull]
	public string Text { get; set; }
}

[Description("接口用于解密团长相关接口返回的联系方式密文")]
public class BuyinDecryptContactInfoRsp
{
	[JsonPropertyName("contact_info")]
	[Description("联系方式明文")]
	public string ContactInfo { get; set; }

	[JsonPropertyName("msg")]
	[Description("风控拦截文案，请求被风控拦截时有返回值")]
	public string Msg { get; set; }
}
