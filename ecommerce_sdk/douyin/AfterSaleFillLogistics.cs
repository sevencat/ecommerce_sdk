namespace ecommerce.sdk.douyin;

[Description("适用场景：,send_type=1：用于补寄商家发货,send_type=3：超市预约上门取货；退货退款和换货场景下商家帮买家填写退货物流信息；,send_type=4：维修场景下商家帮买家填写退货物流信息；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","12000:物流信息校验失败","isv.business-failed:12000","填入有效物流信息")]
[DouyinRetCode(50002,"业务处理失败","物流信息校验失败","isv.business-failed:602001","填入有效物流信息")]
[DouyinRetCode(20000,"系统错误","网络异常稍后重试","isp.service-error:10000","重试")]
[DouyinRetCode(20000,"系统错误","网络异常稍后重试","isp.service-error:10002","重试")]
[DouyinRetCode(50002,"业务处理失败","物流信息校验失败","isv.business-failed:50002","填入有效物流信息")]
[DouyinRetCode(50002,"业务处理失败","无效售后单","isv.business-failed:11000","请检查售后单信息")]
[DouyinRetCode(50002,"业务处理失败","12001:物流信息校验失败","isv.business-failed:12001","检查物流信息，物流单号、地址等")]
[DouyinRetCode(50002,"业务处理失败","19009:当前不支持此物流方式","isv.business-failed:19009","请确认售后原因，用户责任场景才能发起到店退货；线下取货目前处于内测阶段，想要试用请联系抖音运营")]
public class AfterSaleFillLogisticsReq : IDouyinReq<AfterSaleFillLogisticsRsp>
{

	public string GetMethod() { return "afterSale.fillLogistics"; }

	public string GetUrl() { return "/afterSale/fillLogistics"; }

	[JsonPropertyName("aftersale_id")]
	[Description("售后单ID")]
	[NotNull]
	public long? AftersaleId { get; set; }

	[JsonPropertyName("send_type")]
	[Description("发货类型；适用场景： send_type=1：用于补寄商家发货 send_type=3：超市预约上门取货；退货退款和换货场景下商家帮买家填写退货物流信息； send_type=4：维修场景下商家帮买家填写退货物流信息；")]
	[NotNull]
	public int? SendType { get; set; }

	[JsonPropertyName("company_code")]
	[Description("物流公司编号,pick_up_type 2:线下取货;3:用户退回，无需物流公司，可传 -")]
	[NotNull]
	public string CompanyCode { get; set; }

	[JsonPropertyName("tracking_no")]
	[Description("物流单号,pick_up_type 2:线下取货;3:用户退回，无需快递单号，可传 -")]
	[NotNull]
	public string TrackingNo { get; set; }

	[JsonPropertyName("book_time_begin")]
	[Description("预约上门取货时间戳，单位：秒（目前抖超小时达店铺使用）")]
	public long? BookTimeBegin { get; set; }

	[JsonPropertyName("book_time_end")]
	[Description("预约上门取货时间戳，单位：秒（目前抖超小时达店铺使用）")]
	public long? BookTimeEnd { get; set; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	public long? StoreId { get; set; }

	[JsonPropertyName("pick_up_type")]
	[Description("1:自行配送;2:线下取货;3:用户退回 ，不传默认自行配送；适用于send_type=3超市预约上门取货场景")]
	public int? PickUpType { get; set; }
}

[Description("适用场景：,send_type=1：用于补寄商家发货,send_type=3：超市预约上门取货；退货退款和换货场景下商家帮买家填写退货物流信息；,send_type=4：维修场景下商家帮买家填写退货物流信息；")]
public class AfterSaleFillLogisticsRsp
{
}
