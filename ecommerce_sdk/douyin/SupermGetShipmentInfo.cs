namespace ecommerce.sdk.douyin;

[Description("小时达运力平台运力配送状态查询接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","非法的请求参数","isv.parameter-invalid:40100","请确认请求参数是否正确")]
[DouyinRetCode(50002,"业务处理失败","查询不到对应的物流订单","isv.business-failed:20111","请确认订单状态是否正常")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:20100","请参考错误信息解决")]
[DouyinRetCode(50002,"业务处理失败","物流轨迹展示异常","isv.business-failed:20115","请参考物流轨迹展示异常信息")]
[DouyinRetCode(20001,"内部服务超时","未知服务异常","isp.service-timeout-error:90000","请参考错误信息解决")]
[DouyinRetCode(50002,"业务处理失败","物流履约单当前状态无法取消运力信息","isv.business-failed:50312","请确认运单状态")]
[DouyinRetCode(20000,"系统错误","系统异常：系统异常","isp.service-error:20201","请检查代码逻辑")]
public class SupermGetShipmentInfoReq : IDouyinReq<SupermGetShipmentInfoRsp>
{

	public string GetMethod() { return "superm.getShipmentInfo"; }

	public string GetUrl() { return "/superm/getShipmentInfo"; }

	[JsonPropertyName("shop_order_id")]
	[Description("店铺父订单号")]
	[NotNull]
	public long? ShopOrderId { get; set; }

	[JsonPropertyName("aftersale_id")]
	[Description("上门取运力对应售后单号")]
	public long? AftersaleId { get; set; }

	[JsonPropertyName("shipment_type")]
	[Description("配送类型，1 表示发货单，需要传入店铺订单号 2 表示上门取件，需要传入店铺订单号和售后单编号")]
	[NotNull]
	public int? ShipmentType { get; set; }
}

[Description("小时达运力平台运力配送状态查询接口")]
public class SupermGetShipmentInfoRsp
{
	[JsonPropertyName("shipment_info")]
	[Description("配送状态信息")]
	public ShipmentInfoItem ShipmentInfo { get; set; }

	public class ShipmentInfoItem
	{
		[JsonPropertyName("shop_order_id")]
		[Description("店铺父订单号")]
		public long ShopOrderId { get; set; }

		[JsonPropertyName("aftersale_id")]
		[Description("上门取运力对应售后单号")]
		public long AftersaleId { get; set; }

		[JsonPropertyName("track_no")]
		[Description("骑手配送运单号")]
		public string TrackNo { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("抖店店铺ID")]
		public long ShopId { get; set; }

		[JsonPropertyName("shipment_status")]
		[Description("配送状态：    CALLING   = 1 // 骑手呼叫中     RECEIVED  = 2 //骑手已接单     ARRIVED   = 3 //骑手已到取货点     PICKUPPED = 4 //骑手已取货     DELIVERING= 5 //骑手配送中     REJECTED  = 6 //收货人已拒收     RETURNING = 7 //返回中     RETURNED  = 8 //返回完成     DELIVERED = 9 //订单妥投")]
		public int ShipmentStatus { get; set; }

		[JsonPropertyName("shipment_error")]
		[Description("配送异常：    MERCHANT_DELIVER_SLOW   = 1001  // 商家出货慢,     MERCHANT_DELIVER_ERROR  = 1002  // 商家出错货,     MERCHANT_STOCKOUT       = 1003  // 商家缺货,     GOODS_DAMAGED           = 2001  // 破损,     GOODS_LOST              = 2002  // 丢失,     RIDER_WRONG_GOODS       = 2003  // 骑手取错货,     RIDER_UNDELIVERABLE     = 2004  // 骑手无法送达     WRONG_RECEIPT_CODE      = 3001  // 小票码错误,     MERCHANT_WRONG_ADDRESS  = 3002  // 商家地址错误,     CONSUMER_WRONG_ADDRESS  = 3003  // 消费者地址错误,     WEIGHT_DEVIATION_TOO_LARGE = 3004  //  订单重量偏差过大,     CONSUMER_CALL_NO_ANSWER = 4002  // 消费者电话未接通,     CONSUMER_STAY_OUT       = 4003  // 消费者不在家,     CONSUMER_MODIFY_ADDRESS = 4004  // 消费者线下联系修改地址,     OTHER                   = 5001  // 其他")]
		public int ShipmentError { get; set; }

		[JsonPropertyName("rider_name")]
		[Description("配送骑手名称")]
		public string RiderName { get; set; }

		[JsonPropertyName("rider_phone")]
		[Description("配送骑手联系方式")]
		public string RiderPhone { get; set; }

		[JsonPropertyName("rider_longitude")]
		[Description("配送骑手经度；地图坐标GCJ02")]
		public string RiderLongitude { get; set; }

		[JsonPropertyName("rider_latitude")]
		[Description("配送骑手维度；地图坐标GCJ02")]
		public string RiderLatitude { get; set; }

		[JsonPropertyName("occurred_time")]
		[Description("当前状态的变更时间；时间格式：yyyy-MM-dd HH:mm:ss")]
		public string OccurredTime { get; set; }
	}
}
