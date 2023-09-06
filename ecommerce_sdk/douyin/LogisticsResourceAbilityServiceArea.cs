namespace ecommerce.sdk.douyin;

[Description("比如服务商送货上门的服务范围")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","传入参数错误","isv.business-failed:-10000","修正参数之后，再次调用接口")]
public class LogisticsResourceAbilityServiceAreaReq : IDouyinReq<LogisticsResourceAbilityServiceAreaRsp>
{

	public string GetMethod() { return "logistics.resourceAbilityServiceArea"; }

	public string GetUrl() { return "/logistics/resourceAbilityServiceArea"; }

	[JsonPropertyName("ability_code")]
	[Description("服务商能力编码，例如送货上门能力的编码，由抖音电商侧提供")]
	[NotNull]
	public string AbilityCode { get; set; }

	[JsonPropertyName("service_areas")]
	[Description("能力服务范围列表")]
	[NotNull]
	public List<ServiceAreasItem> ServiceAreas { get; set; }

	public class ServiceAreasItem
	{
		[JsonPropertyName("country_code")]
		[Description("国家编码，serviceAreaType=REGION时有效，且必填")]
		public string CountryCode { get; set; }

		[JsonPropertyName("country_name")]
		[Description("国家名称，serviceAreaType=REGION时有效，且必填")]
		public string CountryName { get; set; }

		[JsonPropertyName("province_code")]
		[Description("省份编码，serviceAreaType=REGION时有效，且必填")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("province_name")]
		[Description("省份名称，serviceAreaType=REGION时有效，且必填")]
		public string ProvinceName { get; set; }

		[JsonPropertyName("city_code")]
		[Description("城市编码，serviceAreaType=REGION时有效，且必填")]
		public string CityCode { get; set; }

		[JsonPropertyName("city_name")]
		[Description("城市名称，serviceAreaType=REGION时有效，且必填")]
		public string CityName { get; set; }

		[JsonPropertyName("district_code")]
		[Description("区县编码，serviceAreaType=REGION时有效，且必填")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district_name")]
		[Description("区县名称，serviceAreaType=REGION时有效，且必填")]
		public string DistrictName { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编码，serviceAreaType=REGION时有效，且必填")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street_name")]
		[Description("街道名称，serviceAreaType=REGION时有效，且必填")]
		public string StreetName { get; set; }

		[JsonPropertyName("service_fence")]
		[Description("电子围栏serviceAreaType=EFENCE时有效，且必填")]
		public string ServiceFence { get; set; }

		[JsonPropertyName("service_area_express")]
		[Description("能力表达：1-能(送货上门)，2-不能(送货上门)")]
		public long? ServiceAreaExpress { get; set; }

		[JsonPropertyName("service_area_type")]
		[Description("服务范围定义类型： REGION（行政区划4级地址）  EFENCE（电子围栏）——暂不支持 2种之一。")]
		public string ServiceAreaType { get; set; }
	}

	[JsonPropertyName("extend_dimension_code")]
	[Description("针对上门拆旧是【一级-二级-三级回收类目编码】")]
	public string ExtendDimensionCode { get; set; }
}

[Description("比如服务商送货上门的服务范围")]
public class LogisticsResourceAbilityServiceAreaRsp
{
}
