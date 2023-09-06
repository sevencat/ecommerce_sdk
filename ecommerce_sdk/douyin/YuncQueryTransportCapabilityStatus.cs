namespace ecommerce.sdk.douyin;

[Description("通过店铺订单号查询当前运力配送状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20001,"内部服务超时","1103:请求内部服务超时","isp.service-timeout-error:1103","请重试！")]
public class YuncQueryTransportCapabilityStatusReq : IDouyinReq<YuncQueryTransportCapabilityStatusRsp>
{

	public string GetMethod() { return "yunc.queryTransportCapabilityStatus"; }

	public string GetUrl() { return "/yunc/queryTransportCapabilityStatus"; }

	[JsonPropertyName("platform_order_no")]
	[Description("店铺父订单号")]
	[NotNull]
	public string PlatformOrderNo { get; set; }

	[JsonPropertyName("out_order_no")]
	[Description("ERP单号")]
	[NotNull]
	public string OutOrderNo { get; set; }
}

[Description("通过店铺订单号查询当前运力配送状态")]
public class YuncQueryTransportCapabilityStatusRsp
{
	[JsonPropertyName("data")]
	[Description("返回结果")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("platform_order_no")]
		[Description("店铺父订单号")]
		public string PlatformOrderNo { get; set; }

		[JsonPropertyName("out_order_no")]
		[Description("ERP单号")]
		public string OutOrderNo { get; set; }

		[JsonPropertyName("track_no")]
		[Description("骑手配送运单号（上传交易发货使用）")]
		public string TrackNo { get; set; }

		[JsonPropertyName("logistics_track_no")]
		[Description("电子面单号，用作打印面单使用（暂时）")]
		public string LogisticsTrackNo { get; set; }

		[JsonPropertyName("service_provider")]
		[Description("呼单运力服务商品牌（shenzhenshishun=顺丰同城，dajiangwangluo=达达）")]
		public string ServiceProvider { get; set; }

		[JsonPropertyName("to_aoi_name")]
		[Description("接驳模式下运力服务商返回的接驳商圈，需要打印在面单中")]
		public string ToAoiName { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("抖店店铺ID")]
		public string ShopId { get; set; }

		[JsonPropertyName("store_id")]
		[Description("抖店门店id")]
		public string StoreId { get; set; }

		[JsonPropertyName("shipment_status")]
		[Description("1 // 骑手呼叫中,    2 //骑手已接单,    3 //骑手已到取货点,    4 //骑手配送中,    5 //收货人已拒收,    6 //货物逆向退回中,    7 //货物逆向退回完成 ,    8 //订单妥投,    9 //订单取消")]
		public long ShipmentStatus { get; set; }

		[JsonPropertyName("shipment_error")]
		[Description("1001  // 商家出货慢,,1002  // 商家出错货,,1003  // 商家缺货,,2001  // 破损,,2002  // 丢失,,2003  // 骑手取错货,,2004  // 骑手无法送达,3001  // 小票码错误,,3002  // 商家地址错误,,3003  // 消费者地址错误,,3004  //  订单重量偏差过大,,4002  // 消费者电话未接通,,4003  // 消费者不在家,,4004  // 消费者线下联系修改地址,,5001  // 其他")]
		public long ShipmentError { get; set; }

		[JsonPropertyName("rider_name")]
		[Description("配送骑手名称")]
		public string RiderName { get; set; }

		[JsonPropertyName("rider_phone")]
		[Description("配送骑手联系方式")]
		public string RiderPhone { get; set; }

		[JsonPropertyName("rider_longitude")]
		[Description("配送骑手经度")]
		public string RiderLongitude { get; set; }

		[JsonPropertyName("rider_latitude")]
		[Description("配送骑手维度")]
		public string RiderLatitude { get; set; }

		[JsonPropertyName("occurred_time")]
		[Description("当前状态的变更时间")]
		public string OccurredTime { get; set; }
	}
}
