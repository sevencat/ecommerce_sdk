namespace ecommerce.sdk.douyin;

[Description("小时达创建运费模板")]
public class TradeCreateFreightTemplateReq : IDouyinReq<TradeCreateFreightTemplateRsp>
{

	public string GetMethod() { return "trade.CreateFreightTemplate"; }

	public string GetUrl() { return "/trade/CreateFreightTemplate"; }

	[JsonPropertyName("freight_template_vo")]
	[Description("运费模板模型")]
	[NotNull]
	public FreightTemplateVoItem FreightTemplateVo { get; set; }

	public class FreightTemplateVoItem
	{
		[JsonPropertyName("name")]
		[Description("模板名称")]
		[NotNull]
		public string Name { get; set; }

		[JsonPropertyName("base")]
		[Description("基础运费")]
		[NotNull]
		public List<BaseItem> Base { get; set; }

		public class BaseItem
		{
			[JsonPropertyName("price")]
			[Description("基础运费值")]
			[NotNull]
			public long? Price { get; set; }
		}

		[JsonPropertyName("weight")]
		[Description("重量规则")]
		[NotNull]
		public List<WeightItem> Weight { get; set; }

		public class WeightItem
		{
			[JsonPropertyName("first_weight")]
			[Description("起始重量 单位mg")]
			[NotNull]
			public long? FirstWeight { get; set; }

			[JsonPropertyName("add_weight")]
			[Description("增加重量")]
			[NotNull]
			public long? AddWeight { get; set; }

			[JsonPropertyName("add_price")]
			[Description("加价 单位分")]
			[NotNull]
			public long? AddPrice { get; set; }
		}

		[JsonPropertyName("distance")]
		[Description("距离规则")]
		[NotNull]
		public List<DistanceItem> Distance { get; set; }

		public class DistanceItem
		{
			[JsonPropertyName("first_distance")]
			[Description("起始距离 单位m")]
			[NotNull]
			public long? FirstDistance { get; set; }

			[JsonPropertyName("add_distance")]
			[Description("增加距离")]
			[NotNull]
			public long? AddDistance { get; set; }

			[JsonPropertyName("add_price")]
			[Description("加价")]
			[NotNull]
			public long? AddPrice { get; set; }
		}

		[JsonPropertyName("interval")]
		[Description("时段规则")]
		[NotNull]
		public List<IntervalItem> Interval { get; set; }

		public class IntervalItem
		{
			[JsonPropertyName("time_start")]
			[Description("起始时间 单位秒 比如00:00就是0")]
			[NotNull]
			public long? TimeStart { get; set; }

			[JsonPropertyName("time_end")]
			[Description("结束时间 单位秒 比如10:00 就是36000")]
			[NotNull]
			public long? TimeEnd { get; set; }

			[JsonPropertyName("add_price")]
			[Description("加价")]
			[NotNull]
			public long? AddPrice { get; set; }
		}

		[JsonPropertyName("free")]
		[Description("包邮规则")]
		[NotNull]
		public List<FreeItem> Free { get; set; }

		public class FreeItem
		{
			[JsonPropertyName("amount")]
			[Description("满xx包邮 单位分")]
			[NotNull]
			public long? Amount { get; set; }
		}

		[JsonPropertyName("shipping_address")]
		[Description("发货地址")]
		[NotNull]
		public ShippingAddressItem ShippingAddress { get; set; }

		public class ShippingAddressItem
		{
			[JsonPropertyName("province_id")]
			[Description("省")]
			[NotNull]
			public string ProvinceId { get; set; }

			[JsonPropertyName("city_id")]
			[Description("市")]
			[NotNull]
			public string CityId { get; set; }

			[JsonPropertyName("town_id")]
			[Description("区")]
			public string TownId { get; set; }

			[JsonPropertyName("street_id")]
			[Description("街道")]
			public string StreetId { get; set; }

			[JsonPropertyName("coordinate")]
			[Description("经纬度")]
			public CoordinateItem Coordinate { get; set; }

			public class CoordinateItem
			{
				[JsonPropertyName("latitude")]
				[Description("纬度")]
				[NotNull]
				public string Latitude { get; set; }

				[JsonPropertyName("longitude")]
				[Description("经度")]
				[NotNull]
				public string Longitude { get; set; }

				[JsonPropertyName("geo_hash")]
				[Description("GeoHash")]
				public string GeoHash { get; set; }

				[JsonPropertyName("expire_time")]
				[Description("过期时间")]
				public long? ExpireTime { get; set; }
			}
		}

		[JsonPropertyName("freight_mode")]
		[Description("模板类型 仅4和5")]
		[NotNull]
		public int? FreightMode { get; set; }
	}
}

[Description("小时达创建运费模板")]
public class TradeCreateFreightTemplateRsp
{
	[JsonPropertyName("template_id")]
	[Description("模板ID")]
	public long TemplateId { get; set; }
}
