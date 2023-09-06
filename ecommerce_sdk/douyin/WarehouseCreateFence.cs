namespace ecommerce.sdk.douyin;

[Description("创建电子围栏")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","参数错误","isv.missing-parameter:2","检查参数")]
[DouyinRetCode(50002,"业务处理失败","该电子围栏已经存在","isv.business-failed:1006","使用修改接口")]
[DouyinRetCode(20000,"系统错误","内部错误（如果是 edge xx crosses edge xx，那就是围栏数据不对，边有交叉，不是个合法的多边形，检查数据）","isp.service-error:9999","重试")]
public class WarehouseCreateFenceReq : IDouyinReq<WarehouseCreateFenceRsp>
{

	public string GetMethod() { return "warehouse.createFence"; }

	public string GetUrl() { return "/warehouse/createFence"; }

	[JsonPropertyName("fence_info")]
	[Description("围栏信息")]
	[NotNull]
	public FenceInfoItem FenceInfo { get; set; }

	public class FenceInfoItem
	{
		[JsonPropertyName("out_fence_id")]
		[Description("外部围栏id，必传")]
		[NotNull]
		public string OutFenceId { get; set; }

		[JsonPropertyName("shape")]
		[Description("形状 1. 圆 使用circular 2:多边形，使用polygon  3:带洞多边形（兼容普通多边形），使用polygon_new  4:多个多边形，兼容带洞和不带洞，使用multi_polygons")]
		[NotNull]
		public int? Shape { get; set; }

		[JsonPropertyName("circular")]
		[Description("形状为圆的经纬度信息，对应shape=1")]
		public CircularItem Circular { get; set; }

		public class CircularItem
		{
			[JsonPropertyName("center")]
			[Description("圆的中心经纬度")]
			[NotNull]
			public CenterItem Center { get; set; }

			public class CenterItem
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

			[JsonPropertyName("radius")]
			[Description("半径，单位 米")]
			[NotNull]
			public decimal? Radius { get; set; }
		}

		[JsonPropertyName("polygon")]
		[Description("普通多边形 ，对应shape=2")]
		public PolygonItem Polygon { get; set; }

		public class PolygonItem
		{
			[JsonPropertyName("vertices")]
			[Description("多边形顶点的经纬度：逆时针")]
			[NotNull]
			public List<VerticesItem> Vertices { get; set; }

			public class VerticesItem
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

		[JsonPropertyName("polygon_new")]
		[Description("带洞多边形，可兼容普通多边形 ，对应shape=3")]
		public PolygonNewItem PolygonNew { get; set; }

		public class PolygonNewItem
		{
			[JsonPropertyName("outer")]
			[Description("带洞多边形的外圈数据")]
			[NotNull]
			public OuterItem Outer { get; set; }

			public class OuterItem
			{
				[JsonPropertyName("vertices")]
				[Description("经纬度列表，外圈为逆时针")]
				[NotNull]
				public List<VerticesItem> Vertices { get; set; }

				public class VerticesItem
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

			[JsonPropertyName("inner")]
			[Description("带洞多边形的内圈数据，空表示普通多边形")]
			public List<InnerItem> Inner { get; set; }

			public class InnerItem
			{
				[JsonPropertyName("vertices")]
				[Description("经纬度列表，内圈为顺时针")]
				public List<VerticesItem> Vertices { get; set; }

				public class VerticesItem
				{
					[JsonPropertyName("longitude")]
					[Description("经度")]
					public decimal? Longitude { get; set; }

					[JsonPropertyName("latitude")]
					[Description("纬度")]
					public decimal? Latitude { get; set; }
				}
			}
		}

		[JsonPropertyName("multi_polygons")]
		[Description("多个多边形 ，对应shape=4")]
		public List<MultiPolygonsItem> MultiPolygons { get; set; }

		public class MultiPolygonsItem
		{
			[JsonPropertyName("outer")]
			[Description("带洞多边形的外圈数据")]
			[NotNull]
			public OuterItem Outer { get; set; }

			public class OuterItem
			{
				[JsonPropertyName("vertices")]
				[Description("经纬度列表，外圈为逆时针")]
				[NotNull]
				public List<VerticesItem> Vertices { get; set; }

				public class VerticesItem
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

			[JsonPropertyName("inner")]
			[Description("带洞多边形的内圈数据，空表示普通多边形")]
			public List<InnerItem> Inner { get; set; }

			public class InnerItem
			{
				[JsonPropertyName("vertices")]
				[Description("经纬度列表，内圈为顺时针")]
				public List<VerticesItem> Vertices { get; set; }

				public class VerticesItem
				{
					[JsonPropertyName("longitude")]
					[Description("经度")]
					public decimal? Longitude { get; set; }

					[JsonPropertyName("latitude")]
					[Description("纬度")]
					public decimal? Latitude { get; set; }
				}
			}
		}
	}
}

[Description("创建电子围栏")]
public class WarehouseCreateFenceRsp
{
	[JsonPropertyName("fence_id")]
	[Description("内部围栏id")]
	public string FenceId { get; set; }
}
