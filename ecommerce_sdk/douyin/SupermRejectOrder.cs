namespace ecommerce.sdk.douyin;

[Description("超市小时达拒单服务")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40100","参数错误")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:20201","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统错误","isv.business-failed:50120","店铺未在灰度中，不存在接单和未接单状态")]
[DouyinRetCode(50002,"业务处理失败","系统错误","isv.business-failed:50121","履约状态不允许变更")]
[DouyinRetCode(50002,"业务处理失败","系统错误","isv.business-failed:50122","拒绝系统拒单的操作")]
[DouyinRetCode(50002,"业务处理失败","系统错误","isv.business-failed:50123","订单已发货，不允许拒单/接单")]
[DouyinRetCode(50002,"业务处理失败","系统错误","isv.business-failed:50124","订单已取消，无需拒单/接单")]
[DouyinRetCode(50002,"业务处理失败","系统错误","isv.business-failed:50125","订单已完结，不允许拒单/接单")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40101","传入履约的参数错误（需商家后台排查）")]
public class SupermRejectOrderReq : IDouyinReq<SupermRejectOrderRsp>
{

	public string GetMethod() { return "superm.rejectOrder"; }

	public string GetUrl() { return "/superm/rejectOrder"; }

	[JsonPropertyName("store_id")]
	[Description("门店id")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("shop_order_id")]
	[Description("店铺单id")]
	[NotNull]
	public string ShopOrderId { get; set; }

	[JsonPropertyName("reason_code")]
	[Description("拒单原因")]
	[NotNull]
	public long? ReasonCode { get; set; }

	[JsonPropertyName("reason_mark")]
	[Description("拒绝备注")]
	public string ReasonMark { get; set; }
}

[Description("超市小时达拒单服务")]
public class SupermRejectOrderRsp
{
}
