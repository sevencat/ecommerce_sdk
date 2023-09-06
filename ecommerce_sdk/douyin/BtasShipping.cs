namespace ecommerce.sdk.douyin;

[Description("自发货订单商家发货给买家（仅商家自发货订单可调用），是否自发货在商家送检时接口指定")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","订单中存在商品处于【待发货-顾客申请取消】，不可发货","isv.business-failed:10000","取消顾客取消的商品，或者不发货。")]
[DouyinRetCode(50002,"业务处理失败","订单不存在","isv.business-failed:4000","请检查订单信息")]
[DouyinRetCode(50002,"业务处理失败","获取锁失败","isv.business-failed:1201","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","请录入和原运单号不相同的数据","isv.business-failed:3020","请录入和原运单号不相同的数据")]
public class BtasShippingReq : IDouyinReq<BtasShippingRsp>
{

	public string GetMethod() { return "btas.shipping"; }

	public string GetUrl() { return "/btas/shipping"; }

	[JsonPropertyName("order_id")]
	[Description("父订单ID")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("product_order_id")]
	[Description("首次录入时必输 商品单ID")]
	public string ProductOrderId { get; set; }

	[JsonPropertyName("order_code")]
	[Description("首次录入时必输 一件商品一个订单码，订单码由字节系统生成。 订单码")]
	public string OrderCode { get; set; }

	[JsonPropertyName("service_status")]
	[Description("枚举值： 1: 新增发货 2: 修改发货")]
	[NotNull]
	public int? ServiceStatus { get; set; }

	[JsonPropertyName("base_shipping_logistics_code")]
	[Description("service_status 是2 的时候使用，需要修改的运单号 修改时，基于该店铺单下的运单号进行修改")]
	public string BaseShippingLogisticsCode { get; set; }

	[JsonPropertyName("shipping_logistics_id")]
	[Description("物流公司ID，由接口/order/logisticsCompanyList返回的物流公司列表中对应的ID")]
	[NotNull]
	public string ShippingLogisticsId { get; set; }

	[JsonPropertyName("shipping_logistics_company_code")]
	[Description("预留：物流公司编码")]
	public string ShippingLogisticsCompanyCode { get; set; }

	[JsonPropertyName("shipping_logistics_code")]
	[Description("物流运单号")]
	[NotNull]
	public string ShippingLogisticsCode { get; set; }
}

[Description("自发货订单商家发货给买家（仅商家自发货订单可调用），是否自发货在商家送检时接口指定")]
public class BtasShippingRsp
{
}
