namespace ecommerce.sdk.douyin;

[Description("查询最新的四级地址用于订单售后处理")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","422:provId invalid","isv.business-failed:422","参数传入有问题，请检查后重试")]
public class AddressGetAreasByProvinceReq : IDouyinReq<AddressGetAreasByProvinceRsp>
{

	public string GetMethod() { return "address.getAreasByProvince"; }

	public string GetUrl() { return "/address/getAreasByProvince"; }

	[JsonPropertyName("province_id")]
	[Description("省ID")]
	[NotNull]
	public long? ProvinceId { get; set; }
}

[Description("查询最新的四级地址用于订单售后处理")]
public class AddressGetAreasByProvinceRsp
{
	[JsonPropertyName("data")]
	[Description("响应结果")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("code")]
		[Description("省ID")]
		public long Code { get; set; }

		[JsonPropertyName("father_code")]
		[Description("父ID")]
		public long FatherCode { get; set; }

		[JsonPropertyName("name")]
		[Description("省名称")]
		public string Name { get; set; }

		[JsonPropertyName("level")]
		[Description("地址等级")]
		public string Level { get; set; }

		[JsonPropertyName("sub_districts")]
		[Description("响应结果")]
		public List<SubDistrictsItem> SubDistricts { get; set; }

		public class SubDistrictsItem
		{
			[JsonPropertyName("code")]
			[Description("市ID")]
			public long Code { get; set; }

			[JsonPropertyName("father_code")]
			[Description("父ID")]
			public long FatherCode { get; set; }

			[JsonPropertyName("name")]
			[Description("市名")]
			public string Name { get; set; }

			[JsonPropertyName("level")]
			[Description("地址等级")]
			public string Level { get; set; }

			[JsonPropertyName("sub_districts")]
			[Description("响应结果")]
			public List<SubDistrictsIItem> SubDistrictsI { get; set; }

			public class SubDistrictsIItem
			{
				[JsonPropertyName("code")]
				[Description("区县ID")]
				public long Code { get; set; }

				[JsonPropertyName("father_code")]
				[Description("父ID")]
				public long FatherCode { get; set; }

				[JsonPropertyName("name")]
				[Description("区县名称")]
				public string Name { get; set; }

				[JsonPropertyName("level")]
				[Description("地址等级")]
				public string Level { get; set; }

				[JsonPropertyName("sub_districts")]
				[Description("响应结果")]
				public List<SubDistrictsItem> SubDistricts { get; set; }

				public class SubDistrictsItem
				{
					[JsonPropertyName("code")]
					[Description("镇或者街道ID")]
					public long Code { get; set; }

					[JsonPropertyName("father_code")]
					[Description("父ID")]
					public long FatherCode { get; set; }

					[JsonPropertyName("level")]
					[Description("地址等级")]
					public string Level { get; set; }

					[JsonPropertyName("name")]
					[Description("镇或者街道名称")]
					public string Name { get; set; }
				}
			}
		}
	}
}
