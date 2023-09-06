namespace ecommerce.sdk.douyin;

[Description("智造工场数据开放接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","请求api不存在","isv.business-failed:63000700","开发者确认apiName是否填写正确")]
[DouyinRetCode(50002,"业务处理失败","未知错误，请联系客服","isv.business-failed:-1","未知错误，请联系客服")]
[DouyinRetCode(50002,"业务处理失败","报表中的API未上线，请先上线API","isv.business-failed:63000720","报表中的API未上线，请先上线API")]
[DouyinRetCode(50002,"业务处理失败","volc inner 调用开放接口失败","isv.business-failed:63000704","volc inner 调用开放接口失败")]
public class OpenCloudSmartFactoryInterfaceReq : IDouyinReq<OpenCloudSmartFactoryInterfaceRsp>
{

	public string GetMethod() { return "openCloud.smartFactoryInterface"; }

	public string GetUrl() { return "/openCloud/smartFactoryInterface"; }

	[JsonPropertyName("api_name")]
	[Description("智造工场开放API名称")]
	[NotNull]
	public string ApiName { get; set; }

	[JsonPropertyName("body")]
	[Description("智造工场开放API请求体")]
	[NotNull]
	public string Body { get; set; }
}

[Description("智造工场数据开放接口")]
public class OpenCloudSmartFactoryInterfaceRsp
{
	[JsonPropertyName("result")]
	[Description("智造工场开放API响应结果")]
	public string Result { get; set; }
}
