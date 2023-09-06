namespace ecommerce.sdk.douyin;

[Description("末端订单状态推送")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:11000","修改参数")]
[DouyinRetCode(50002,"业务处理失败","bizType非法","isv.business-failed:13001","修改bizType参数")]
[DouyinRetCode(50002,"业务处理失败","订单不存在","isv.business-failed:11005","修改订单号")]
[DouyinRetCode(50002,"业务处理失败","状态机初始化失败","isv.business-failed:12001","联系技术")]
[DouyinRetCode(50002,"业务处理失败","当前状态不允许更新","isv.business-failed:12002","联系技术")]
[DouyinRetCode(50002,"业务处理失败","mq异常","isv.business-failed:11002","重试")]
[DouyinRetCode(50002,"业务处理失败","数据库异常","isv.business-failed:11001","重试")]
[DouyinRetCode(50002,"业务处理失败","数据库并发异常","isv.business-failed:11017","联系技术")]
[DouyinRetCode(50002,"业务处理失败","订单已取消","isv.business-failed:13003","联系技术")]
[DouyinRetCode(50002,"业务处理失败","重量异常","isv.business-failed:11019","二次核重核价")]
public class LogisticsUpdateTerminalOrderReq : IDouyinReq<LogisticsUpdateTerminalOrderRsp>
{

	public string GetMethod() { return "logistics.updateTerminalOrder"; }

	public string GetUrl() { return "/logistics/updateTerminalOrder"; }

	[JsonPropertyName("bizType")]
	[Description("推送状态标识")]
	public string BizType { get; set; }

	[JsonPropertyName("cabinetNum")]
	[Description("快递柜编码")]
	public string CabinetNum { get; set; }

	[JsonPropertyName("cabinetName")]
	[Description("快递柜名称")]
	public string CabinetName { get; set; }

	[JsonPropertyName("cabinetLongitude")]
	[Description("快递柜经度")]
	public string CabinetLongitude { get; set; }

	[JsonPropertyName("cabinetLatitude")]
	[Description("快递柜纬度")]
	public string CabinetLatitude { get; set; }

	[JsonPropertyName("cabinetAddress")]
	[Description("快递柜地址")]
	public CabinetAddressItem CabinetAddress { get; set; }

	public class CabinetAddressItem
	{
		[JsonPropertyName("countryCode")]
		[Description("国家编码")]
		public string CountryCode { get; set; }

		[JsonPropertyName("provinceCode")]
		[Description("省编码")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("provinceName")]
		[Description("省名称")]
		public string ProvinceName { get; set; }

		[JsonPropertyName("cityCode")]
		[Description("市编码")]
		public string CityCode { get; set; }

		[JsonPropertyName("cityName")]
		[Description("市名称")]
		public string CityName { get; set; }

		[JsonPropertyName("districtCode")]
		[Description("区编码")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("districtName")]
		[Description("区名称")]
		public string DistrictName { get; set; }

		[JsonPropertyName("streetCode")]
		[Description("街道编码")]
		public string StreetCode { get; set; }

		[JsonPropertyName("streetName")]
		[Description("街道名称")]
		public string StreetName { get; set; }

		[JsonPropertyName("detailAddress")]
		[Description("详细地址")]
		public string DetailAddress { get; set; }
	}

	[JsonPropertyName("orderId")]
	[Description("订单号")]
	public string OrderId { get; set; }

	[JsonPropertyName("operationTime")]
	[Description("操作时间")]
	public string OperationTime { get; set; }

	[JsonPropertyName("terminalInfo")]
	[Description("订单信息")]
	public TerminalInfoItem TerminalInfo { get; set; }

	public class TerminalInfoItem
	{
		[JsonPropertyName("courierName")]
		[Description("快递员姓名")]
		public string CourierName { get; set; }

		[JsonPropertyName("courierTel")]
		[Description("快递员号码")]
		public string CourierTel { get; set; }

		[JsonPropertyName("waybillCode")]
		[Description("运单号")]
		public string WaybillCode { get; set; }

		[JsonPropertyName("express")]
		[Description("物流商编码")]
		public string Express { get; set; }

		[JsonPropertyName("operatorName")]
		[Description("取件人姓名")]
		public string OperatorName { get; set; }

		[JsonPropertyName("operatorPhone")]
		[Description("取件人号码")]
		public string OperatorPhone { get; set; }

		[JsonPropertyName("weightInfo")]
		[Description("核重核价信息")]
		public WeightInfoItem WeightInfo { get; set; }

		public class WeightInfoItem
		{
			[JsonPropertyName("bulkyWeight")]
			[Description("泡重")]
			public long? BulkyWeight { get; set; }

			[JsonPropertyName("bulkyRatio")]
			[Description("泡重比")]
			public long? BulkyRatio { get; set; }

			[JsonPropertyName("length")]
			[Description("长度 单位cm")]
			public decimal? Length { get; set; }

			[JsonPropertyName("width")]
			[Description("宽度 单位cm")]
			public decimal? Width { get; set; }

			[JsonPropertyName("height")]
			[Description("高度 单位cm")]
			public decimal? Height { get; set; }

			[JsonPropertyName("traceType")]
			[Description("物流节点")]
			public string TraceType { get; set; }

			[JsonPropertyName("site")]
			[Description("站点")]
			public string Site { get; set; }

			[JsonPropertyName("sumFee")]
			[Description("总费用")]
			public long? SumFee { get; set; }

			[JsonPropertyName("insuredFee")]
			[Description("保价费用")]
			public long? InsuredFee { get; set; }

			[JsonPropertyName("packageFee")]
			[Description("包装费用")]
			public long? PackageFee { get; set; }

			[JsonPropertyName("actualWeight")]
			[Description("实际重量")]
			public long? ActualWeight { get; set; }

			[JsonPropertyName("chargedWeight")]
			[Description("计费重量")]
			public long? ChargedWeight { get; set; }

			[JsonPropertyName("chargedType")]
			[Description("计费类型")]
			public long? ChargedType { get; set; }
		}
	}

	[JsonPropertyName("requestId")]
	[Description("请求唯一标识")]
	public string RequestId { get; set; }

	[JsonPropertyName("weightTimes")]
	[Description("核重核价次数")]
	public long? WeightTimes { get; set; }
}

[Description("末端订单状态推送")]
public class LogisticsUpdateTerminalOrderRsp
{
	[JsonPropertyName("isWeightException")]
	[Description("是否重量异常")]
	public bool IsWeightException { get; set; }
}
