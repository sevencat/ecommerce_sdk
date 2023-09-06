namespace ecommerce.sdk.douyin;

[Description("末端操作数据回传")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","rpc调用失败","isv.business-failed:11004","找研发确认")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:11000","修改参数")]
public class LogisticsTerminalRouteDataReq : IDouyinReq<LogisticsTerminalRouteDataRsp>
{

	public string GetMethod() { return "logistics.terminalRouteData"; }

	public string GetUrl() { return "/logistics/terminalRouteData"; }

	[JsonPropertyName("track_operation")]
	[Description("轨迹操作（Arrival - 入站；InStore - 在库；Departure - 出站；DepartureException - 异常出站；SignReject - 拒收）")]
	[NotNull]
	public string TrackOperation { get; set; }

	[JsonPropertyName("sign_by")]
	[Description("签收人（SignedByMyself - 本人签收；SignedByOthers - 他人签收；PostStationSigned - 驿站代签）")]
	public string SignBy { get; set; }

	[JsonPropertyName("post_station_tel")]
	[Description("驿站电话")]
	public string PostStationTel { get; set; }

	[JsonPropertyName("longitude")]
	[Description("经度")]
	public string Longitude { get; set; }

	[JsonPropertyName("latitude")]
	[Description("纬度")]
	public string Latitude { get; set; }

	[JsonPropertyName("standard")]
	[Description("经纬度标准（GaoDe - 高德；BaiDu - 百度；Tencent - 腾讯；Google - 谷歌）")]
	public string Standard { get; set; }

	[JsonPropertyName("pick_up_address")]
	[Description("取件地址")]
	[NotNull]
	public PickUpAddressItem PickUpAddress { get; set; }

	public class PickUpAddressItem
	{
		[JsonPropertyName("country_code")]
		[Description("国家编码")]
		public string CountryCode { get; set; }

		[JsonPropertyName("province_code")]
		[Description("省编码")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("province_name")]
		[Description("省")]
		public string ProvinceName { get; set; }

		[JsonPropertyName("city_code")]
		[Description("市编码")]
		public string CityCode { get; set; }

		[JsonPropertyName("city_name")]
		[Description("市")]
		public string CityName { get; set; }

		[JsonPropertyName("district_code")]
		[Description("区编码")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district_name")]
		[Description("区")]
		public string DistrictName { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编码")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street_name")]
		[Description("街道")]
		public string StreetName { get; set; }

		[JsonPropertyName("detail_address")]
		[Description("详细地址")]
		public string DetailAddress { get; set; }
	}

	[JsonPropertyName("courier_name")]
	[Description("快递员姓名")]
	public string CourierName { get; set; }

	[JsonPropertyName("courier_tel")]
	[Description("快递员电话")]
	public string CourierTel { get; set; }

	[JsonPropertyName("service_type")]
	[Description("服务类型（HomeDelivery - 送货上门；PostStationSelfDelivery - 驿站自提；other - 其他）")]
	[NotNull]
	public string ServiceType { get; set; }

	[JsonPropertyName("waybill_code")]
	[Description("运单号")]
	[NotNull]
	public string WaybillCode { get; set; }

	[JsonPropertyName("express_company")]
	[Description("快递公司（联调时提供枚举）")]
	[NotNull]
	public string ExpressCompany { get; set; }

	[JsonPropertyName("partner_code")]
	[Description("服务商编码")]
	[NotNull]
	public string PartnerCode { get; set; }

	[JsonPropertyName("pick_code")]
	[Description("取件码")]
	public string PickCode { get; set; }

	[JsonPropertyName("pick_site_type")]
	[Description("取件点类型（1 - 驿站；2 - 自提柜）")]
	[NotNull]
	public string PickSiteType { get; set; }

	[JsonPropertyName("pick_site_name")]
	[Description("取件点名称")]
	[NotNull]
	public string PickSiteName { get; set; }

	[JsonPropertyName("pick_site_code")]
	[Description("取件点编码")]
	[NotNull]
	public string PickSiteCode { get; set; }

	[JsonPropertyName("pick_site_phone")]
	[Description("取件点联系方式")]
	[NotNull]
	public string PickSitePhone { get; set; }

	[JsonPropertyName("operation_time")]
	[Description("操作时间")]
	[NotNull]
	public string OperationTime { get; set; }

	[JsonPropertyName("extend")]
	[Description("拓展字段")]
	public Dictionary<string,string> Extend { get; set; }

	[JsonPropertyName("exception_code")]
	[Description("异常编码")]
	public string ExceptionCode { get; set; }

	[JsonPropertyName("exception_description")]
	[Description("异常描述，服务商回传原始异常文案")]
	public string ExceptionDescription { get; set; }
}

[Description("末端操作数据回传")]
public class LogisticsTerminalRouteDataRsp
{
	[JsonPropertyName("result")]
	[Description("是否成功")]
	public bool Result { get; set; }

	[JsonPropertyName("return_code")]
	[Description("响应编码")]
	public string ReturnCode { get; set; }

	[JsonPropertyName("message")]
	[Description("响应描述")]
	public string Message { get; set; }
}
