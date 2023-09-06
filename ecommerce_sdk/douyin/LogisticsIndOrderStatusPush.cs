namespace ecommerce.sdk.douyin;

[Description("订单状态回传")]
public class LogisticsIndOrderStatusPushReq : IDouyinReq<LogisticsIndOrderStatusPushRsp>
{

	public string GetMethod() { return "logistics.ind.orderStatusPush"; }

	public string GetUrl() { return "/logistics/ind/orderStatusPush"; }

	[JsonPropertyName("out_order_id")]
	[Description("承运商单据号")]
	[NotNull]
	public string OutOrderId { get; set; }

	[JsonPropertyName("transport_order_id")]
	[Description("抖音单据号")]
	[NotNull]
	public string TransportOrderId { get; set; }

	[JsonPropertyName("order_status")]
	[Description("订单状态(待接单＝1,配送员接单＝2,配送员到店＝3,配送员取货=4,配送员配送中=5,已取消＝6,订单逆向返回中=7, 订单逆向返回完成=8,骑手更换=9,订单妥投=10")]
	[NotNull]
	public int? OrderStatus { get; set; }

	[JsonPropertyName("exception_status")]
	[Description("异常情况")]
	public ExceptionStatusItem ExceptionStatus { get; set; }

	public class ExceptionStatusItem
	{
		[JsonPropertyName("status")]
		[Description("订单拒收=1,配送异常=2")]
		[NotNull]
		public int? Status { get; set; }

		[JsonPropertyName("reason")]
		[Description("配送异常feature：订单拒收=1,配送异常=2 配送异常feature： { 1001,商家出货慢, 1002,商家出错货, 1003,商家缺货, 2001,破损, 2002,丢失, 2003,骑手取错货, 2004,骑手无法送达 3001,小票码错误, 3002,商家地址错误, 3003,消费者地址错误, 3004, 订单重量偏差过大, 4001,消费者拒收, 4002,消费者电话未接通, 4003,消费者不在家, 4004,消费者线下联系修改地址, 5001,其他 }")]
		[NotNull]
		public int? Reason { get; set; }
	}

	[JsonPropertyName("estimate_sign_time")]
	[Description("计划应妥投时间，时间戳")]
	public long? EstimateSignTime { get; set; }

	[JsonPropertyName("estimate_fetch_time")]
	[Description("计划应取件时间")]
	public long? EstimateFetchTime { get; set; }

	[JsonPropertyName("rider")]
	[Description("骑手信息")]
	public RiderItem Rider { get; set; }

	public class RiderItem
	{
		[JsonPropertyName("rider_code")]
		[Description("骑手id")]
		public string RiderCode { get; set; }

		[JsonPropertyName("rider_name")]
		[Description("骑手name")]
		public string RiderName { get; set; }

		[JsonPropertyName("temperature")]
		[Description("骑手温度")]
		public decimal? Temperature { get; set; }

		[JsonPropertyName("vaccine")]
		[Description("骑手疫苗情况  0=未接种,1=一针,2=2针,3=3针")]
		public short? Vaccine { get; set; }

		[JsonPropertyName("covid_report")]
		[Description("骑手健康码情况 0 - 绿码且24h内核酸 1 - 绿码且48h内核酸 2 - 绿码且48h外核酸 3 - 黄码 4 - 红码")]
		public int? CovidReport { get; set; }

		[JsonPropertyName("contact")]
		[Description("骑手联系方式")]
		public ContactItem Contact { get; set; }

		public class ContactItem
		{
			[JsonPropertyName("name")]
			[Description("姓名")]
			public string Name { get; set; }

			[JsonPropertyName("mobile")]
			[Description("电话")]
			public string Mobile { get; set; }

			[JsonPropertyName("tel")]
			[Description("手机号码")]
			public string Tel { get; set; }
		}
	}

	[JsonPropertyName("location")]
	[Description("骑手位置信息")]
	public LocationItem Location { get; set; }

	public class LocationItem
	{
		[JsonPropertyName("longitude")]
		[Description("经度")]
		[NotNull]
		public string Longitude { get; set; }

		[JsonPropertyName("latitude")]
		[Description("维度")]
		[NotNull]
		public string Latitude { get; set; }

		[JsonPropertyName("standard")]
		[Description("使用的地图")]
		[NotNull]
		public string Standard { get; set; }
	}

	[JsonPropertyName("update_time")]
	[Description("本次状态流更新时间")]
	[NotNull]
	public long? UpdateTime { get; set; }

	[JsonPropertyName("logistics_out_order_id")]
	[Description("承运商单据号，电子面单号、用作打印面单使用")]
	public string LogisticsOutOrderId { get; set; }

	[JsonPropertyName("to_aoi_name")]
	[Description("接驳商圈名称，接驳模式下运力服务商返回的接驳商圈，需要在面单打印")]
	public string ToAoiName { get; set; }
}

[Description("订单状态回传")]
public class LogisticsIndOrderStatusPushRsp
{
	[JsonPropertyName("return_code")]
	[Description("错误码，0表示成功")]
	public string ReturnCode { get; set; }

	[JsonPropertyName("message")]
	[Description("错误消息，失败时填写")]
	public string Message { get; set; }
}
