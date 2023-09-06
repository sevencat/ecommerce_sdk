namespace ecommerce.sdk.douyin;

[Description("订单发货后，如需修改商品序列号或补充上传商品序列号，可调用此接口进行修改或上传")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","该订单状态不支持序列号上传","isv.business-failed:60049","停止操作")]
[DouyinRetCode(50002,"业务处理失败","补贴商品发货时需要上传商品序列号","isv.business-failed:60056","输入正确的序列号")]
[DouyinRetCode(20000,"服务不可用","查询订单信息异常","isp.service-error:50024","重试")]
[DouyinRetCode(40002,"缺少必选参数","订单号不能为空","isv.missing-parameter:50049","传入需上传序列号的订单号")]
[DouyinRetCode(40002,"缺少必选参数","序列号不能为空","isv.missing-parameter:60048","传入需上传的序列号")]
[DouyinRetCode(40004,"非法的参数","序列号长度不能超过30位字符","isv.parameter-invalid:60046","输入正确的序列号")]
[DouyinRetCode(20000,"服务不可用","系统异常，请重试","isp.service-error:20003","重试")]
[DouyinRetCode(50002,"业务处理失败","IMEI号仅支持填写15～17位数字","isv.business-failed:60062","输入正确的序列号")]
[DouyinRetCode(50002,"业务处理失败","该订单补贴商品的序列号已经上传，请重新填写","isv.business-failed:60047","重新输入正确的序列号")]
public class OrderAddSerialNumberReq : IDouyinReq<OrderAddSerialNumberRsp>
{

	public string GetMethod() { return "order.addSerialNumber"; }

	public string GetUrl() { return "/order/addSerialNumber"; }

	[JsonPropertyName("order_id")]
	[Description("订单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("serial_number_list")]
	[Description("商品序列号，序列号长度不能超过30位字符，其中手机序列号仅支持填写15～17位数字")]
	[NotNull]
	public List<string> SerialNumberList { get; set; }
}

[Description("订单发货后，如需修改商品序列号或补充上传商品序列号，可调用此接口进行修改或上传")]
public class OrderAddSerialNumberRsp
{
}
