namespace ecommerce.sdk.douyin;

[Description("发送消息给服务市场商家，仅支持推送消息给订购履中的商家")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","发送消息失败","isp.service-error:301200","检查消息模板")]
[DouyinRetCode(50002,"业务处理失败","消息重复发送","isv.business-failed:301201","3秒内不要发送重复消息")]
[DouyinRetCode(50002,"业务处理失败","没有模板权限","isv.business-failed:301202","申请模板权限")]
[DouyinRetCode(40004,"非法的参数","消息参数解析失败","isv.parameter-invalid:500002","检查参数")]
[DouyinRetCode(40002,"缺少必选参数","缺少必选参数","isv.missing-parameter:100002","检查参数")]
[DouyinRetCode(40004,"非法的参数","消息内容解析失败","isv.parameter-invalid:301203","检查消息模板参数")]
[DouyinRetCode(50002,"业务处理失败","安全检查错误","isv.business-failed:200000","重试")]
[DouyinRetCode(80000,"风控拦截","安全检查不通过","isv.risk-control-failed:301204","检查消息模板参数")]
public class AppMessageSendReq : IDouyinReq<AppMessageSendRsp>
{

	public string GetMethod() { return "appMessage.send"; }

	public string GetUrl() { return "/appMessage/send"; }

	[JsonPropertyName("template_id")]
	[Description("模板id")]
	[NotNull]
	public long? TemplateId { get; set; }

	[JsonPropertyName("msg_param")]
	[Description("模板参数，jump_url是跳转链接，是必传参数。如果跳转web，需包含http或者https协议头")]
	[NotNull]
	public string MsgParam { get; set; }
}

[Description("发送消息给服务市场商家，仅支持推送消息给订购履中的商家")]
public class AppMessageSendRsp
{
	[JsonPropertyName("rid")]
	[Description("业务key")]
	public string Rid { get; set; }
}
