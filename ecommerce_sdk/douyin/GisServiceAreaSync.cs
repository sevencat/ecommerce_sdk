namespace ecommerce.sdk.douyin;

[Description("同步服务范围数据")]
public class GisServiceAreaSyncReq : IDouyinReq<GisServiceAreaSyncRsp>
{

	public string GetMethod() { return "gis.serviceArea.sync"; }

	public string GetUrl() { return "/gis/serviceArea/sync"; }

	[JsonPropertyName("express")]
	[Description("物流商编码，接口研发提供")]
	[NotNull]
	public string Express { get; set; }

	[JsonPropertyName("ability_code")]
	[Description("能力表达，接口研发提供")]
	[NotNull]
	public string AbilityCode { get; set; }

	[JsonPropertyName("service_areas")]
	[Description("服务范围结构体")]
	[NotNull]
	public List<ServiceAreasItem> ServiceAreas { get; set; }

	public class ServiceAreasItem
	{
		[JsonPropertyName("country_code")]
		[Description("国家国标码")]
		public string CountryCode { get; set; }

		[JsonPropertyName("province_code")]
		[Description("省国标码")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("city_code")]
		[Description("市国标码")]
		public string CityCode { get; set; }

		[JsonPropertyName("district_code")]
		[Description("区国标码")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道国标码")]
		public string StreetCode { get; set; }

		[JsonPropertyName("fence")]
		[Description("围栏结构体")]
		public FenceItem Fence { get; set; }

		public class FenceItem
		{
			[JsonPropertyName("type")]
			[Description("围栏形状，multipolygon，polygon")]
			[NotNull]
			public string Type { get; set; }

			[JsonPropertyName("standard")]
			[Description("坐标规范")]
			[NotNull]
			public string Standard { get; set; }

			[JsonPropertyName("multipolygon")]
			[Description("多多边形结构体")]
			public List<MultipolygonItem> Multipolygon { get; set; }

			public class MultipolygonItem
			{
				[JsonPropertyName("polygons")]
				[Description("带洞多边形结构体")]
				[NotNull]
				public List<PolygonsItem> Polygons { get; set; }

				public class PolygonsItem
				{
					[JsonPropertyName("polygon")]
					[Description("简单多边形结构体")]
					[NotNull]
					public List<PolygonItem> Polygon { get; set; }

					public class PolygonItem
					{
						[JsonPropertyName("longitude")]
						[Description("经度")]
						[NotNull]
						public decimal? Longitude { get; set; }

						[JsonPropertyName("latitude")]
						[Description("纬度")]
						[NotNull]
						public decimal? Latitude { get; set; }
					}
				}
			}
		}

		[JsonPropertyName("service_area_express")]
		[Description("是否能送货上门 1-能送货上门 2-不能送货上门")]
		[NotNull]
		public int? ServiceAreaExpress { get; set; }

		[JsonPropertyName("service_area_type")]
		[Description("服务范围类型 EFENCE-围栏 REGION-行政区划")]
		[NotNull]
		public string ServiceAreaType { get; set; }

		[JsonPropertyName("country_name")]
		[Description("国家名称")]
		public string CountryName { get; set; }

		[JsonPropertyName("province_name")]
		[Description("省名称")]
		public string ProvinceName { get; set; }

		[JsonPropertyName("city_name")]
		[Description("市名称")]
		public string CityName { get; set; }

		[JsonPropertyName("district_name")]
		[Description("区县名称")]
		public string DistrictName { get; set; }

		[JsonPropertyName("street_name")]
		[Description("街道名称")]
		public string StreetName { get; set; }
	}

	[JsonPropertyName("resource_ability")]
	[Description("资源能力表达")]
	public ResourceAbilityItem ResourceAbility { get; set; }

	public class ResourceAbilityItem
	{
		[JsonPropertyName("resource_code")]
		[Description("资源code")]
		[NotNull]
		public string ResourceCode { get; set; }

		[JsonPropertyName("resource_type")]
		[Description("资源类型")]
		[NotNull]
		public string ResourceType { get; set; }

		[JsonPropertyName("ability_code")]
		[Description("能力code")]
		[NotNull]
		public string AbilityCode { get; set; }

		[JsonPropertyName("ability_type")]
		[Description("能力类型")]
		[NotNull]
		public string AbilityType { get; set; }
	}
}

[Description("同步服务范围数据")]
public class GisServiceAreaSyncRsp
{
}
