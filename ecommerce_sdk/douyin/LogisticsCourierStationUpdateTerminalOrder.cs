namespace ecommerce.sdk.douyin;

[Description("末端服务商回传核重核价信息、运单号、揽收状态")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","-","isp.service-error:10001","修改请求参数")]
[DouyinRetCode(20000,"系统错误","-","isp.service-error:10002","接口重试")]
[DouyinRetCode(20000,"系统错误","-","isp.service-error:10003","联系开发人员")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10101","订单不存在")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10102","订单已取消")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10106","订单当前状态不允许核重核价")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10107","订单当前状态不允许揽收")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10108","不支持重复核重核价")]
[DouyinRetCode(50002,"业务处理失败","-","isv.business-failed:10109","不支持重复揽收")]
public class LogisticsCourierStationUpdateTerminalOrderReq : IDouyinReq<LogisticsCourierStationUpdateTerminalOrderRsp>
{

	public string GetMethod() { return "logistics.courierStation.updateTerminalOrder"; }

	public string GetUrl() { return "/logistics/courierStation/updateTerminalOrder"; }

	[JsonPropertyName("bizType")]
	[Description("业务类型；,支持‘|’分割，批量传入多个类型，枚举：,POST_WEIGHT_INFO--核重核价,POST_WAYBILL_INFO--运单号,POST_COLLECT_STATUS--揽收状态")]
	[NotNull]
	public string BizType { get; set; }

	[JsonPropertyName("orderId")]
	[Description("订单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("operationTime")]
	[Description("操作时间（格式：yyyy-MM-dd HH:mm:ss，24小时制）")]
	[NotNull]
	public string OperationTime { get; set; }

	[JsonPropertyName("postInfo")]
	[Description("推送信息")]
	public PostInfoItem PostInfo { get; set; }

	public class PostInfoItem
	{
		[JsonPropertyName("waybillCode")]
		[Description("运单号")]
		public string WaybillCode { get; set; }

		[JsonPropertyName("express")]
		[Description("物流商编码")]
		public string Express { get; set; }

		[JsonPropertyName("weightInfo")]
		[Description("核重核价信息")]
		public WeightInfoItem WeightInfo { get; set; }

		public class WeightInfoItem
		{
			[JsonPropertyName("sumFee")]
			[Description("总金额（单位：分）")]
			public long? SumFee { get; set; }

			[JsonPropertyName("insuredFee")]
			[Description("保价费（单位：分）")]
			public long? InsuredFee { get; set; }

			[JsonPropertyName("packageFee")]
			[Description("包装费（单位：分）")]
			public long? PackageFee { get; set; }

			[JsonPropertyName("actualWeight")]
			[Description("包裹实际重量（单位：克）")]
			public long? ActualWeight { get; set; }

			[JsonPropertyName("chargedWeight")]
			[Description("包裹计费重量（单位：克）")]
			public long? ChargedWeight { get; set; }

			[JsonPropertyName("chargedType")]
			[Description("计费类型；,枚举：1--重量，2--体积")]
			public long? ChargedType { get; set; }
		}
	}

	[JsonPropertyName("partnerCode")]
	[Description("服务商编码")]
	[NotNull]
	public string PartnerCode { get; set; }

	[JsonPropertyName("postCode")]
	[Description("驿站编码")]
	public string PostCode { get; set; }

	[JsonPropertyName("postName")]
	[Description("驿站名称")]
	public string PostName { get; set; }

	[JsonPropertyName("brandCode")]
	[Description("品牌编码")]
	[NotNull]
	public string BrandCode { get; set; }
}

[Description("末端服务商回传核重核价信息、运单号、揽收状态")]
public class LogisticsCourierStationUpdateTerminalOrderRsp
{
	[JsonPropertyName("errCode")]
	[Description("失败原因编码（处理成功默认回传“0”）")]
	public string ErrCode { get; set; }

	[JsonPropertyName("errReason")]
	[Description("失败原因描述")]
	public string ErrReason { get; set; }
}
