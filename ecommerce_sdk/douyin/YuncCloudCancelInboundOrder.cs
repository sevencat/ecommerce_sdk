namespace ecommerce.sdk.douyin;

[Description("销退入库取消")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","62303015:调用仓储失败","isv.business-failed:62303015","调用仓储失败")]
[DouyinRetCode(50002,"业务处理失败","623023011:订单状态不允许取消","isv.business-failed:623023011","订单状态不允许取消")]
[DouyinRetCode(50002,"业务处理失败","内部错误","isv.business-failed:500","内部错误")]
[DouyinRetCode(50002,"业务处理失败","100100:货主和店铺绑定关系不存在，请在scm进行货主和店铺关系绑定后重推数据！","isv.business-failed:100100","货主和店铺绑定关系不存在，请在scm进行货主和店铺关系绑定后重推数据！")]
[DouyinRetCode(50002,"业务处理失败","1001:调用wms取消单据出错","isv.business-failed:1001","取消单据出错")]
[DouyinRetCode(20001,"内部服务超时","超时，请重试","isp.service-timeout-error:1103","请重试")]
public class YuncCloudCancelInboundOrderReq : IDouyinReq<YuncCloudCancelInboundOrderRsp>
{

	public string GetMethod() { return "yunc.cloudCancelInboundOrder"; }

	public string GetUrl() { return "/yunc/cloudCancelInboundOrder"; }

	[JsonPropertyName("biz_order_no")]
	[Description("入库单号")]
	[NotNull]
	public string BizOrderNo { get; set; }

	[JsonPropertyName("action_type")]
	[Description("固定传1:取消")]
	[NotNull]
	public int? ActionType { get; set; }

	[JsonPropertyName("cancel_reason")]
	[Description("取消原因")]
	[NotNull]
	public string CancelReason { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺ID")]
	public long? ShopId { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }
}

[Description("销退入库取消")]
public class YuncCloudCancelInboundOrderRsp
{
	[JsonPropertyName("data")]
	[Description("响应数据")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("logistics_no")]
		[Description("lo编码")]
		public string LogisticsNo { get; set; }
	}
}
