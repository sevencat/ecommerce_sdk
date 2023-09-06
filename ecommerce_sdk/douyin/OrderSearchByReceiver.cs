namespace ecommerce.sdk.douyin;

[Description("1. 支持使用收件人姓名、手机号查询订单,2. 只支持使用收件人姓名、手机号精确查询，不支持模糊查询,3. 只支持查询最近90天内创建的订单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","查询收货人类型错误","isv.parameter-invalid:20051","post_type传0或1")]
[DouyinRetCode(40004,"非法的参数","收货人参数不能为空","isv.parameter-invalid:20052","post_receiver不能传空值")]
[DouyinRetCode(40004,"非法的参数","收货人手机号不正确","isv.parameter-invalid:20053","传入正确的手机号")]
[DouyinRetCode(40004,"非法的参数","只支持查询最近90天内的数据","isv.parameter-invalid:20022","需要把下单开始时间设置为最近90天内的时间（如果没有传下单开始时间会默认设置当前时间90天前的时间为下单开始时间）")]
[DouyinRetCode(40004,"非法的参数","订单查询开始时间不能晚于结束时间","isv.parameter-invalid:20048","传入正确的下单开始时间和结束时间")]
[DouyinRetCode(40004,"非法的参数","单次最多支持查询100条","isv.parameter-invalid:20008","单页最大支持100，size设置需要 <= 100")]
[DouyinRetCode(40004,"非法的参数","查询订单列表页数不能小于0","isv.parameter-invalid:10035","查询页数从0开始，需要输入大于等于0的数")]
[DouyinRetCode(40004,"非法的参数","最多支持查询1000条","isv.parameter-invalid:20013","翻页查询最多支持查询到1000，需要缩短查询时间范围，降低查询的订单量")]
[DouyinRetCode(20000,"系统错误","查询异常，请稍后重试","isp.service-error:20002","如遇到该报错，建议再重试3~5次，如还是报错可提交工单咨询")]
[DouyinRetCode(20000,"系统错误","查询异常，请稍后重试","isp.service-error:20054","如遇到该报错，建议再重试3~5次，如还是报错可提交工单咨询")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:20005","如遇到该报错，建议再重试3~5次，如还是报错可提交工单咨询")]
[DouyinRetCode(80000,"风控拦截","风控拦截","isv.risk-control-failed:20047","无")]
public class OrderSearchByReceiverReq : IDouyinReq<OrderSearchByReceiverRsp>
{

	public string GetMethod() { return "order.searchByReceiver"; }

	public string GetUrl() { return "/order/searchByReceiver"; }

	[JsonPropertyName("post_type")]
	[Description("查询类型：0-收货人手机号，1-收货人姓名")]
	[NotNull]
	public long? PostType { get; set; }

	[JsonPropertyName("post_receiver")]
	[Description("收货人手机号或收货人姓名")]
	[NotNull]
	public string PostReceiver { get; set; }

	[JsonPropertyName("create_time_start")]
	[Description("下单时间：开始，秒级时间戳。只允许查最近90天的订单，不传默认按90天前处理")]
	public long? CreateTimeStart { get; set; }

	[JsonPropertyName("create_time_end")]
	[Description("下单时间：截止，秒级时间戳。不传默认按现在处理")]
	public long? CreateTimeEnd { get; set; }

	[JsonPropertyName("size")]
	[Description("单页大小，限制100以内")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，0页开始")]
	[NotNull]
	public long? Page { get; set; }
}

[Description("1. 支持使用收件人姓名、手机号查询订单,2. 只支持使用收件人姓名、手机号精确查询，不支持模糊查询,3. 只支持查询最近90天内创建的订单")]
public class OrderSearchByReceiverRsp
{
	[JsonPropertyName("page")]
	[Description("页数，从0开始")]
	public long Page { get; set; }

	[JsonPropertyName("total")]
	[Description("总订单数")]
	public long Total { get; set; }

	[JsonPropertyName("size")]
	[Description("单页大小")]
	public long Size { get; set; }

	[JsonPropertyName("shop_order_list")]
	[Description("订单信息")]
	public List<ShopOrderListItem> ShopOrderList { get; set; }

	public class ShopOrderListItem
	{
		[JsonPropertyName("create_time")]
		[Description("下单时间，时间戳，秒")]
		public string CreateTime { get; set; }

		[JsonPropertyName("order_status")]
		[Description("订单状态：1-待确认/待支付（订单创建完毕），105-已支付，2 备货中，101-部分发货，3-已发货（全部发货），4-已取消，5-已完成（已收货）")]
		public string OrderStatus { get; set; }

		[JsonPropertyName("order_id")]
		[Description("店铺订单号")]
		public string OrderId { get; set; }
	}
}
