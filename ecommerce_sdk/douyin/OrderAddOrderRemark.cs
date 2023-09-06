namespace ecommerce.sdk.douyin;

[Description("为商家提供订单备注接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","50001:orderId参数不合法，建议根据文档检查传入数据","isv.parameter-invalid:50001","参数错误，检查参数")]
[DouyinRetCode(20000,"系统错误","20001:系统繁忙，请稍后重试","isp.service-error:20001","重试")]
[DouyinRetCode(40004,"非法的参数","50002:参数不合法，建议根据文档检查传入数据","isv.parameter-invalid:50002","参数错误，检查参数")]
[DouyinRetCode(40004,"非法的参数","50051:备注不规范，建议检查备注文案","isv.parameter-invalid:50051","备注不规范，检查参数")]
[DouyinRetCode(40004,"非法的参数","20002:orderId不存在，请检查订单号","isv.parameter-invalid:20002","订单号不存在，检查参数")]
[DouyinRetCode(20000,"系统错误","8888:系统繁忙，请稍后重试","isp.service-error:8888","重试")]
[DouyinRetCode(50002,"业务处理失败","50056:订单备注内容超过规定字数","isv.business-failed:50056","订单备注内容超过规定字数")]
public class OrderAddOrderRemarkReq : IDouyinReq<OrderAddOrderRemarkRsp>
{

	public string GetMethod() { return "order.addOrderRemark"; }

	public string GetUrl() { return "/order/addOrderRemark"; }

	[JsonPropertyName("order_id")]
	[Description("父订单id")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注内容，最大不得超过500个字符")]
	[NotNull]
	public string Remark { get; set; }

	[JsonPropertyName("is_add_star")]
	[Description("是否加旗标，不填则默认为否 true：需要加旗标 false：不加旗标")]
	public string IsAddStar { get; set; }

	[JsonPropertyName("star")]
	[Description("标星等级，范围0～5 0为灰色旗标，5为红色旗标，数字越大颜色越深 0灰 1紫 2青 3绿 4橙 5红")]
	public string Star { get; set; }
}

[Description("为商家提供订单备注接口")]
public class OrderAddOrderRemarkRsp
{
}
