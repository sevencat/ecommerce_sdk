namespace ecommerce.sdk.douyin;

[Description("支持按抖音小程序open_id查询订单简要信息，仅电商小程序在C端面向用户呈现订单任务类场景使用")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","订单查询只支持查询最近90天内的数据","isv.parameter-invalid:20022","把下单开始时间设置为最近90天内")]
[DouyinRetCode(40004,"非法的参数","订单查询最多支持查询5万","isv.parameter-invalid:20013","缩短查询时间范围")]
[DouyinRetCode(40004,"非法的参数","订单查询状态条件超过限制，只支持1个元素","isv.parameter-invalid:20012","状态查询条件是list，但现在只支持传入一个元素，重新组装参数查询")]
[DouyinRetCode(40004,"非法的参数","单次查询订单数超过限制","isv.parameter-invalid:20008","单页最大支持100，size设置需要 u003c= 100")]
[DouyinRetCode(40004,"非法的参数","系统繁忙，请稍后重试","isv.parameter-invalid:20005","如遇到该报错，建议再30秒内重试3~5次，如还是报错可提交工单咨询")]
[DouyinRetCode(40004,"非法的参数","系统繁忙，请稍后重试","isv.parameter-invalid:20004","如遇到该报错，建议再30秒内重试3~5次，如还是报错可提交工单咨询")]
public class OrderGetUserOrderListReq : IDouyinReq<OrderGetUserOrderListRsp>
{

	public string GetMethod() { return "order.getUserOrderList"; }

	public string GetUrl() { return "/order/getUserOrderList"; }

	[JsonPropertyName("create_time_start")]
	[Description("下单时间：开始，秒级时间戳")]
	public long? CreateTimeStart { get; set; }

	[JsonPropertyName("create_time_end")]
	[Description("下单时间：截止，秒级时间戳")]
	public long? CreateTimeEnd { get; set; }

	[JsonPropertyName("size")]
	[Description("单页大小，限制100以内")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，0页开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("open_id")]
	[Description("用户openId")]
	[NotNull]
	public string OpenId { get; set; }

	[JsonPropertyName("open_id_type")]
	[Description("用户openId类型，固定为 douyin 抖音")]
	[NotNull]
	public string OpenIdType { get; set; }

	[JsonPropertyName("order_status")]
	[Description("订单状态：all-全部，under_sure-待确认，unpaid-待支付，stock_up-待发货，on_delivery-已发货，received-已完成，closed-已关闭，to_groups-待成团")]
	public string OrderStatus { get; set; }
}

[Description("支持按抖音小程序open_id查询订单简要信息，仅电商小程序在C端面向用户呈现订单任务类场景使用")]
public class OrderGetUserOrderListRsp
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
		[JsonPropertyName("order_id")]
		[Description("店铺订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("order_status")]
		[Description("订单状态;1 待确认/待支付-订单创建完毕;105-已支付; 2-备货中； 101-部分发货; 3-已发货（全部发货）;4- 已取消;5 已完成（已收货）;")]
		public long OrderStatus { get; set; }

		[JsonPropertyName("pay_amount")]
		[Description("支付金额（分）")]
		public long PayAmount { get; set; }

		[JsonPropertyName("create_time")]
		[Description("下单时间")]
		public long CreateTime { get; set; }

		[JsonPropertyName("sku_order_list")]
		[Description("商品单信息")]
		public List<SkuOrderListItem> SkuOrderList { get; set; }

		public class SkuOrderListItem
		{
			[JsonPropertyName("sku_info")]
			[Description("商品单信息")]
			public SkuInfoItem SkuInfo { get; set; }

			public class SkuInfoItem
			{
				[JsonPropertyName("product_name")]
				[Description("商品名称")]
				public string ProductName { get; set; }

				[JsonPropertyName("sku_id")]
				[Description("商品skuId")]
				public long SkuId { get; set; }

				[JsonPropertyName("product_id")]
				[Description("商品ID")]
				public long ProductId { get; set; }
			}
		}
	}
}
