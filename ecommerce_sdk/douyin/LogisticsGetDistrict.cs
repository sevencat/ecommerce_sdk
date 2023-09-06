namespace ecommerce.sdk.douyin;

[Description("1、根据行政区划code，查询上下级相关区划信息，支持四级地址,2、版本号请传入version=ecom，获取当前最新版本；如需历史版本请联系字节接口人。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","参数错误","isv.business-failed:400","修改参数重新调用")]
public class LogisticsGetDistrictReq : IDouyinReq<LogisticsGetDistrictRsp>
{

	public string GetMethod() { return "logistics.getDistrict"; }

	public string GetUrl() { return "/logistics/getDistrict"; }

	[JsonPropertyName("code")]
	[Description("行政区划code")]
	public string Code { get; set; }

	[JsonPropertyName("subdistrict")]
	[Description("返回下级层级")]
	public int? Subdistrict { get; set; }

	[JsonPropertyName("version")]
	[Description("版本号")]
	public string Version { get; set; }
}

[Description("1、根据行政区划code，查询上下级相关区划信息，支持四级地址,2、版本号请传入version=ecom，获取当前最新版本；如需历史版本请联系字节接口人。")]
public class LogisticsGetDistrictRsp
{
	[JsonPropertyName("district")]
	[Description("区划信息")]
	public DistrictItem District { get; set; }

	public class DistrictItem
	{
		[JsonPropertyName("par_regions")]
		[Description("上级区划")]
		public List<ParRegionsItem> ParRegions { get; set; }

		public class ParRegionsItem
		{
			[JsonPropertyName("code")]
			[Description("编码")]
			public string Code { get; set; }

			[JsonPropertyName("name")]
			[Description("名称")]
			public string Name { get; set; }

			[JsonPropertyName("level")]
			[Description("级别")]
			public int Level { get; set; }

			[JsonPropertyName("description")]
			[Description("描述")]
			public string Description { get; set; }

			[JsonPropertyName("centroid")]
			[Description("中心点信息")]
			public List<decimal> Centroid { get; set; }
		}

		[JsonPropertyName("code")]
		[Description("编码")]
		public string Code { get; set; }

		[JsonPropertyName("name")]
		[Description("名称")]
		public string Name { get; set; }

		[JsonPropertyName("level")]
		[Description("级别")]
		public int Level { get; set; }

		[JsonPropertyName("description")]
		[Description("描述")]
		public string Description { get; set; }

		[JsonPropertyName("sub_region")]
		[Description("下级区划信息")]
		public List<SubRegionItem> SubRegion { get; set; }

		public class SubRegionItem
		{
			[JsonPropertyName("code")]
			[Description("编码")]
			public string Code { get; set; }

			[JsonPropertyName("name")]
			[Description("名称")]
			public string Name { get; set; }

			[JsonPropertyName("level")]
			[Description("级别")]
			public int Level { get; set; }

			[JsonPropertyName("sub_region")]
			[Description("参考上级")]
			public List<SubRegionIItem> SubRegionI { get; set; }

			public class SubRegionIItem
			{
				[JsonPropertyName("code")]
				[Description("#")]
				public string Code { get; set; }

				[JsonPropertyName("name")]
				[Description("#")]
				public string Name { get; set; }

				[JsonPropertyName("level")]
				[Description("#")]
				public int Level { get; set; }

				[JsonPropertyName("description")]
				[Description("#")]
				public string Description { get; set; }

				[JsonPropertyName("sub_region")]
				[Description("参考上级")]
				public List<SubRegionItem> SubRegion { get; set; }

				public class SubRegionItem
				{
					[JsonPropertyName("code")]
					[Description("#")]
					public string Code { get; set; }

					[JsonPropertyName("name")]
					[Description("#")]
					public string Name { get; set; }

					[JsonPropertyName("level")]
					[Description("#")]
					public int Level { get; set; }

					[JsonPropertyName("description")]
					[Description("#")]
					public string Description { get; set; }

					[JsonPropertyName("sub_region")]
					[Description("参考上级")]
					public List<SubRegionIItem> SubRegionI { get; set; }

					public class SubRegionIItem
					{
						[JsonPropertyName("code")]
						[Description("#")]
						public string Code { get; set; }

						[JsonPropertyName("name")]
						[Description("#")]
						public string Name { get; set; }

						[JsonPropertyName("level")]
						[Description("#")]
						public int Level { get; set; }

						[JsonPropertyName("description")]
						[Description("#")]
						public string Description { get; set; }

						[JsonPropertyName("centroid")]
						[Description("#")]
						public List<decimal> Centroid { get; set; }
					}

					[JsonPropertyName("centroid")]
					[Description("中心点")]
					public List<decimal> Centroid { get; set; }
				}

				[JsonPropertyName("centroid")]
				[Description("#")]
				public List<decimal> Centroid { get; set; }
			}

			[JsonPropertyName("description")]
			[Description("#")]
			public string Description { get; set; }

			[JsonPropertyName("centroid")]
			[Description("#")]
			public List<decimal> Centroid { get; set; }
		}

		[JsonPropertyName("pre_region")]
		[Description("上级区划信息，详情参考district其他字段")]
		public PreRegionItem PreRegion { get; set; }

		public class PreRegionItem
		{
			[JsonPropertyName("code")]
			[Description("2")]
			public string Code { get; set; }

			[JsonPropertyName("name")]
			[Description("1")]
			public string Name { get; set; }

			[JsonPropertyName("level")]
			[Description("1")]
			public int Level { get; set; }

			[JsonPropertyName("description")]
			[Description("2")]
			public string Description { get; set; }

			[JsonPropertyName("centroid")]
			[Description("1")]
			public List<decimal> Centroid { get; set; }
		}

		[JsonPropertyName("centroid")]
		[Description("中心点经纬度")]
		public List<decimal> Centroid { get; set; }
	}

	[JsonPropertyName("version")]
	[Description("版本号")]
	public string Version { get; set; }

	[JsonPropertyName("update_time")]
	[Description("更新时间戳")]
	public string UpdateTime { get; set; }
}
