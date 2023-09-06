namespace ecommerce.sdk.douyin;

[Description("回复服务请求,回复客服向店铺发起的服务请求")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务申请已经回复，无需重复回复","isp.service-error:10009","-")]
[DouyinRetCode(20000,"系统错误","参数错误","isp.service-error:10002","-")]
[DouyinRetCode(50002,"业务处理失败","图片链接有误","isv.business-failed:10017","-")]
public class OrderReplyServiceReq : IDouyinReq<OrderReplyServiceRsp>
{

	public string GetMethod() { return "order.replyService"; }

	public string GetUrl() { return "/order/replyService"; }

	[JsonPropertyName("id")]
	[Description("服务请求列表中获取的id")]
	[NotNull]
	public long? Id { get; set; }

	[JsonPropertyName("reply")]
	[Description("回复内容")]
	[NotNull]
	public string Reply { get; set; }

	[JsonPropertyName("evidence")]
	[Description("回复凭证，通过/order/serviceDetail获取是否当前服务单</br>是否必须上传凭证。多张图片用竖线分开。不超过4张")]
	public string Evidence { get; set; }
}

[Description("回复服务请求,回复客服向店铺发起的服务请求")]
public class OrderReplyServiceRsp
{
}
