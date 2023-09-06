namespace ecommerce.sdk.douyin;

[Description("用于ISV/商家ERP系统 端发起取消已获取的电子面单号；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","轨迹存在","isv.business-failed:10902","无")]
[DouyinRetCode(50002,"业务处理失败","错误：该运单号3180437295999已经有物流信息,不能取消","isv.business-failed:10804","无")]
[DouyinRetCode(50002,"业务处理失败","物流商系统无此运单，无法取消","isv.business-failed:10803","无")]
[DouyinRetCode(50002,"业务处理失败","该运单已取件，不允许取消","isv.business-failed:10802","无")]
[DouyinRetCode(40004,"非法的参数","电子面单号不存在","isv.parameter-invalid:10014","输入正确的运单号")]
[DouyinRetCode(50002,"业务处理失败","取消总数/取号总数超过最大比例","isv.business-failed:10013","无")]
[DouyinRetCode(40004,"非法的参数","该数据不存在，请检查后重试","isv.parameter-invalid:10003","无")]
[DouyinRetCode(50002,"业务处理失败","此订单已收件","isv.business-failed:8060","无")]
[DouyinRetCode(40004,"非法的参数","该物流商暂不支持取消面单号","isv.parameter-invalid:5001","无")]
[DouyinRetCode(50002,"业务处理失败","订单已发货，取消面单号失败","isv.business-failed:4007","无")]
[DouyinRetCode(50002,"业务处理失败","已经取消过了，无需再次取消","isv.business-failed:10901","无")]
[DouyinRetCode(50002,"业务处理失败","该运单已取消成功,请勿重复操作","isv.business-failed:10801","无")]
[DouyinRetCode(40002,"缺少必选参数","物流单号不能为空","isv.missing-parameter:400","输入运单号")]
[DouyinRetCode(20000,"系统错误","系统错误或此状态不允许取消","isp.service-error:10002","无")]
[DouyinRetCode(20000,"系统错误","请求物流服务商超时","isp.service-error:4009","进行重试")]
[DouyinRetCode(50002,"业务处理失败","已消单","isv.business-failed:8037","无")]
[DouyinRetCode(50002,"业务处理失败","10903:单号已回收，不允许变更","isv.business-failed:10903","无")]
[DouyinRetCode(50002,"业务处理失败","20001:重复请求","isv.business-failed:20001","无")]
[DouyinRetCode(20000,"系统错误","4001","isp.service-error:4001","系统内部错误，可以先进行重试处理，如果多次重试失败，开发者交流群进行反馈")]
[DouyinRetCode(20000,"系统错误","11404:系统异常","isp.service-error:11404","系统内部错误，可以先进行重试处理，如果多次重试失败，开发者交流群进行反馈")]
[DouyinRetCode(50002,"业务处理失败","10000:该运单已取件，不允许取消","isv.business-failed:10000","无")]
[DouyinRetCode(20000,"系统错误","4008:内部数据JSON/XML格式非法","isp.service-error:4008","一般都是物流商导致的原因，比如超时或物流商服务返回的有问题")]
[DouyinRetCode(50002,"业务处理失败","8018:未获取到订单信息","isv.business-failed:8018","系统异常，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","1105:已揽收，无法取消","isv.business-failed:1105","无")]
[DouyinRetCode(50002,"业务处理失败","10724:取消失败，如果有疑问请联系京东大件物流","isv.business-failed:10724","如果有疑问请联系京东大件物流")]
[DouyinRetCode(50002,"业务处理失败","20802:该运单已取件，不允许取消","isv.business-failed:20802","无")]
[DouyinRetCode(50002,"业务处理失败","10711:电子面单订购关系不存在","isv.business-failed:10711","请检查订购关系是否正常")]
[DouyinRetCode(50002,"业务处理失败","1102:重复取消","isv.business-failed:1102","无")]
public class LogisticsCancelOrderReq : IDouyinReq<LogisticsCancelOrderRsp>
{

	public string GetMethod() { return "logistics.cancelOrder"; }

	public string GetUrl() { return "/logistics/cancelOrder"; }

	[JsonPropertyName("logistics_code")]
	[Description("物流公司")]
	[NotNull]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("track_no")]
	[Description("运单号")]
	[NotNull]
	public string TrackNo { get; set; }

	[JsonPropertyName("user_id")]
	[Description("实际使用取号服务店铺user_id")]
	public long? UserId { get; set; }
}

[Description("用于ISV/商家ERP系统 端发起取消已获取的电子面单号；")]
public class LogisticsCancelOrderRsp
{
	[JsonPropertyName("cancel_result")]
	[Description("取消状态")]
	public CancelResultItem CancelResult { get; set; }

	public class CancelResultItem
	{
		[JsonPropertyName("success")]
		[Description("true：取消成功 false 取消失败")]
		public bool Success { get; set; }
	}
}
