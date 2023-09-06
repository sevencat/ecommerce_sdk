namespace ecommerce.sdk.douyin;

[Description("获取外部物流商围栏数据")]
public class GisFenceAreaPushReq : IDouyinReq<GisFenceAreaPushRsp>
{

	public string GetMethod() { return "gis.fenceArea.push"; }

	public string GetUrl() { return "/gis/fenceArea/push"; }

	[JsonPropertyName("express")]
	[Description("物流商code，接口研发提供")]
	[NotNull]
	public string Express { get; set; }

	[JsonPropertyName("express_key")]
	[Description("物流商校验码，接口研发提供")]
	[NotNull]
	public string ExpressKey { get; set; }

	[JsonPropertyName("action")]
	[Description("0-删除 1-创建或更新")]
	[NotNull]
	public int? Action { get; set; }

	[JsonPropertyName("fence_area")]
	[Description("围栏范围结构体")]
	[NotNull]
	public List<FenceAreaItem> FenceArea { get; set; }

	public class FenceAreaItem
	{
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

		[JsonPropertyName("detail_address")]
		[Description("详细地址")]
		public string DetailAddress { get; set; }

		[JsonPropertyName("branch_code")]
		[Description("物流商网点code")]
		[NotNull]
		public string BranchCode { get; set; }

		[JsonPropertyName("branch_name")]
		[Description("物流商网点名称")]
		[NotNull]
		public string BranchName { get; set; }

		[JsonPropertyName("area_type")]
		[Description("围栏类型 0-坐标 1-行政区划")]
		[NotNull]
		public int? AreaType { get; set; }

		[JsonPropertyName("fence")]
		[Description("围栏坐标结构体")]
		[NotNull]
		public FenceItem Fence { get; set; }

		public class FenceItem
		{
			[JsonPropertyName("type")]
			[Description("围栏形状")]
			[NotNull]
			public string Type { get; set; }

			[JsonPropertyName("standard")]
			[Description("围栏坐标规范")]
			[NotNull]
			public string Standard { get; set; }

			[JsonPropertyName("multipolygon")]
			[Description("围栏坐标pg定义")]
			public string Multipolygon { get; set; }
		}

		[JsonPropertyName("data_id")]
		[Description("数据唯一标识")]
		[NotNull]
		public long? DataId { get; set; }

		[JsonPropertyName("entity_type")]
		[Description("实体类型 0-网点 1-小件员")]
		[NotNull]
		public int? EntityType { get; set; }

		[JsonPropertyName("delivery_type")]
		[Description("网点配送方式 0-不区分 1-仅支持配送 2-仅支持自提")]
		public int? DeliveryType { get; set; }

		[JsonPropertyName("three_segment_code")]
		[Description("小件员三段码")]
		public string ThreeSegmentCode { get; set; }

		[JsonPropertyName("biz_type")]
		[Description("小件员业务类型 0-揽件 1-派件")]
		public int? BizType { get; set; }

		[JsonPropertyName("reachable")]
		[Description("是否可达 0-不可达 1-可达")]
		[NotNull]
		public int? Reachable { get; set; }

		[JsonPropertyName("calculate")]
		[Description("是否可用于推算段码 0-不可用于推算段码 1-可用于推算段码")]
		[NotNull]
		public int? Calculate { get; set; }
	}
}

[Description("获取外部物流商围栏数据")]
public class GisFenceAreaPushRsp
{
	[JsonPropertyName("result")]
	[Description("结果")]
	public List<ResultItem> Result { get; set; }

	public class ResultItem
	{
		[JsonPropertyName("data_id")]
		[Description("数据唯一id")]
		public long DataId { get; set; }

		[JsonPropertyName("reason")]
		[Description("错误原因")]
		public string Reason { get; set; }

		[JsonPropertyName("success")]
		[Description("0-失败 1-成功")]
		public bool Success { get; set; }
	}
}
