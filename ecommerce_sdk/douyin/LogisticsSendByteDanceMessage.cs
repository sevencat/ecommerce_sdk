namespace ecommerce.sdk.douyin;

[Description("短信代发")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:11000","修改参数")]
[DouyinRetCode(50002,"业务处理失败","数据库错误","isv.business-failed:11001","下个字节单")]
[DouyinRetCode(50002,"业务处理失败","不是字节包裹","isv.business-failed:10014","找测试下个字节单")]
[DouyinRetCode(50002,"业务处理失败","关联下游处理失败","isv.business-failed:11004","找研发确认问题")]
[DouyinRetCode(50002,"业务处理失败","不是字节面单","isv.business-failed:10015","找测试下个字节单")]
[DouyinRetCode(50002,"业务处理失败","短信代发失败","isv.business-failed:11010","找研发确认问题")]
[DouyinRetCode(50002,"业务处理失败","内部处理失败","isv.business-failed:11008","找研发确认问题")]
[DouyinRetCode(50002,"业务处理失败","内容检测失败","isv.business-failed:10002","换个合法短信内容")]
public class LogisticsSendByteDanceMessageReq : IDouyinReq<LogisticsSendByteDanceMessageRsp>
{

	public string GetMethod() { return "logistics.sendByteDanceMessage"; }

	public string GetUrl() { return "/logistics/sendByteDanceMessage"; }

	[JsonPropertyName("waybillCode")]
	[Description("运单号")]
	[NotNull]
	public string WaybillCode { get; set; }

	[JsonPropertyName("expressCompany")]
	[Description("快递商编码")]
	[NotNull]
	public string ExpressCompany { get; set; }

	[JsonPropertyName("message")]
	[Description("代码内容")]
	[NotNull]
	public string Message { get; set; }

	[JsonPropertyName("pickMsgCode")]
	[Description("取件消息唯一编码")]
	[NotNull]
	public string PickMsgCode { get; set; }
}

[Description("短信代发")]
public class LogisticsSendByteDanceMessageRsp
{
}
