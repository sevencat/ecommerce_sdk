namespace ecommerce.sdk.douyin;

[Description("用于商家向字节系统，获取电子面单打印加密数据；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","参数有误，请检查请求参数","isv.missing-parameter:1001","参数有误，请检查请求参数")]
[DouyinRetCode(20000,"系统错误","查询密钥失败","isp.service-error:100102","请稍后重试")]
[DouyinRetCode(20000,"系统错误","获取订单信息失败","isp.service-error:100101","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","1003:运单号有误，请检查运单号","isv.business-failed:1003","请检查运单号")]
[DouyinRetCode(50002,"业务处理失败","100106:系统错误，请稍后重试","isv.business-failed:100106","请检查运单号")]
public class LogisticsWaybillApplyReq : IDouyinReq<LogisticsWaybillApplyRsp>
{

	public string GetMethod() { return "logistics.waybillApply"; }

	public string GetUrl() { return "/logistics/waybillApply"; }

	[JsonPropertyName("waybill_applies")]
	[Description("请求结构体")]
	[NotNull]
	public List<WaybillAppliesItem> WaybillApplies { get; set; }

	public class WaybillAppliesItem
	{
		[JsonPropertyName("logistics_code")]
		[Description("物流公司编码")]
		[NotNull]
		public string LogisticsCode { get; set; }

		[JsonPropertyName("track_no")]
		[Description("运单号")]
		[NotNull]
		public string TrackNo { get; set; }
	}
}

[Description("用于商家向字节系统，获取电子面单打印加密数据；")]
public class LogisticsWaybillApplyRsp
{
	[JsonPropertyName("waybill_infos")]
	[Description("正常返回结构体")]
	public List<WaybillInfosItem> WaybillInfos { get; set; }

	public class WaybillInfosItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("track_no")]
		[Description("运单号")]
		public string TrackNo { get; set; }

		[JsonPropertyName("print_data")]
		[Description("加密的面单数据")]
		public string PrintData { get; set; }

		[JsonPropertyName("sign")]
		[Description("签名信息")]
		public string Sign { get; set; }
	}

	[JsonPropertyName("err_infos")]
	[Description("错误返回结构体")]
	public List<ErrInfosItem> ErrInfos { get; set; }

	public class ErrInfosItem
	{
		[JsonPropertyName("track_no")]
		[Description("运单号")]
		public string TrackNo { get; set; }

		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("err_code")]
		[Description("错误码")]
		public int ErrCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("错误信息")]
		public string ErrMsg { get; set; }
	}
}
