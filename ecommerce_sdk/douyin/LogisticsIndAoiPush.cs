namespace ecommerce.sdk.douyin;

[Description("门店入驻后，自动/手动向承运商同步门店信息")]
public class LogisticsIndAoiPushReq : IDouyinReq<LogisticsIndAoiPushRsp>
{

	public string GetMethod() { return "logistics.ind.aoi.push"; }

	public string GetUrl() { return "/logistics/ind/aoi/push"; }

	[JsonPropertyName("store_code")]
	[Description("门店编码，由字节在门店创建/更新时同步给抖音平台")]
	[NotNull]
	public string StoreCode { get; set; }

	[JsonPropertyName("instant_delivery_code")]
	[Description("外部运力公司业务身份")]
	[NotNull]
	public string InstantDeliveryCode { get; set; }

	[JsonPropertyName("aoi_id")]
	[Description("电子围栏的id,运力公司保障一个电子围栏id唯一性")]
	[NotNull]
	public string AoiId { get; set; }

	[JsonPropertyName("aoi_type")]
	[Description("回传的电子围栏是标准圆形还是多边形")]
	[NotNull]
	public string AoiType { get; set; }

	[JsonPropertyName("aoi_area_circle")]
	[Description("若aoi_type=circle，必填 单位: m 圆心+半径")]
	public List<AoiAreaCircleItem> AoiAreaCircle { get; set; }

	public class AoiAreaCircleItem
	{
		[JsonPropertyName("location")]
		[Description("圆心经纬度")]
		public LocationItem Location { get; set; }

		public class LocationItem
		{
			[JsonPropertyName("longitude")]
			[Description("经度")]
			[NotNull]
			public string Longitude { get; set; }

			[JsonPropertyName("latitude")]
			[Description("维度")]
			[NotNull]
			public string Latitude { get; set; }

			[JsonPropertyName("standard")]
			[Description("地图标准")]
			[NotNull]
			public string Standard { get; set; }
		}

		[JsonPropertyName("circle_radius")]
		[Description("半径")]
		[NotNull]
		public long? CircleRadius { get; set; }
	}

	[JsonPropertyName("aoi_area_polygon_list")]
	[Description("若aoi_category=polygon，则回传经纬度点集合 构成的电子围栏多边形的经纬度坐标(高德体系经纬度) 例如: {   经度A,纬度A;    经度B,纬度B;   经度C,纬度C; }")]
	public string AoiAreaPolygonList { get; set; }

	[JsonPropertyName("aoi_op_type")]
	[Description("变更类型")]
	[NotNull]
	public short? AoiOpType { get; set; }

	[JsonPropertyName("fulfill_service")]
	[Description("门店到此电子围栏的服务")]
	public List<string> FulfillService { get; set; }
}

[Description("门店入驻后，自动/手动向承运商同步门店信息")]
public class LogisticsIndAoiPushRsp
{
	[JsonPropertyName("return_code")]
	[Description("错误码，0 - 成功")]
	public string ReturnCode { get; set; }

	[JsonPropertyName("message")]
	[Description("错误信息，失败时填写")]
	public string Message { get; set; }
}
