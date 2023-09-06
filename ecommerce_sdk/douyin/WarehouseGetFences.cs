namespace ecommerce.sdk.douyin;

[Description("获取电子围栏信息/列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:2","修改后重试")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:9999","重试")]
public class WarehouseGetFencesReq : IDouyinReq<WarehouseGetFencesRsp>
{

	public string GetMethod() { return "warehouse.getFences"; }

	public string GetUrl() { return "/warehouse/getFences"; }

	[JsonPropertyName("out_fence_id_list")]
	[Description("外部围栏id列表，不填则查全部")]
	public List<string> OutFenceIdList { get; set; }
}

[Description("获取电子围栏信息/列表")]
public class WarehouseGetFencesRsp
{
	[JsonPropertyName("fences")]
	[Description("围栏信息列表")]
	public List<FencesItem> Fences { get; set; }

	public class FencesItem
	{
		[JsonPropertyName("out_fence_id")]
		[Description("外部围栏id")]
		public string OutFenceId { get; set; }

		[JsonPropertyName("fence_id")]
		[Description("内部围栏id")]
		public long FenceId { get; set; }

		[JsonPropertyName("shape")]
		[Description("形状 1. 圆  2:多边形  3:带洞多边形（兼容普通多边形")]
		public int Shape { get; set; }

		[JsonPropertyName("circular")]
		[Description("形状为圆的经纬度信息")]
		public CircularItem Circular { get; set; }

		public class CircularItem
		{
			[JsonPropertyName("center")]
			[Description("圆的中心经纬度")]
			public CenterItem Center { get; set; }

			public class CenterItem
			{
				[JsonPropertyName("longitude")]
				[Description("经度")]
				public decimal Longitude { get; set; }

				[JsonPropertyName("latitude")]
				[Description("纬度")]
				public decimal Latitude { get; set; }
			}

			[JsonPropertyName("radius")]
			[Description("半径，单位 米")]
			public decimal Radius { get; set; }
		}

		[JsonPropertyName("polygon")]
		[Description("普通多边形")]
		public PolygonItem Polygon { get; set; }

		public class PolygonItem
		{
			[JsonPropertyName("vertices")]
			[Description("多边形顶点的经纬度：逆时针")]
			public List<VerticesItem> Vertices { get; set; }

			public class VerticesItem
			{
				[JsonPropertyName("longitude")]
				[Description("经度")]
				public decimal Longitude { get; set; }

				[JsonPropertyName("latitude")]
				[Description("纬度")]
				public decimal Latitude { get; set; }
			}
		}

		[JsonPropertyName("polygon_new")]
		[Description("带洞多边形，可兼容普通多边形")]
		public PolygonNewItem PolygonNew { get; set; }

		public class PolygonNewItem
		{
			[JsonPropertyName("outer")]
			[Description("带洞多边形的外圈数据")]
			public OuterItem Outer { get; set; }

			public class OuterItem
			{
				[JsonPropertyName("vertices")]
				[Description("经纬度列表，外圈为逆时针")]
				public List<VerticesItem> Vertices { get; set; }

				public class VerticesItem
				{
					[JsonPropertyName("longitude")]
					[Description("经度")]
					public decimal Longitude { get; set; }

					[JsonPropertyName("latitude")]
					[Description("纬度")]
					public decimal Latitude { get; set; }
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
					public string Longitude { get; set; }

					[JsonPropertyName("latitude")]
					[Description("纬度")]
					public string Latitude { get; set; }
				}
			}
		}

		[JsonPropertyName("multi_polygons")]
		[Description("多个多边形")]
		public List<MultiPolygonsItem> MultiPolygons { get; set; }

		public class MultiPolygonsItem
		{
			[JsonPropertyName("outer")]
			[Description("带洞多边形的外圈数据")]
			public OuterItem Outer { get; set; }

			public class OuterItem
			{
				[JsonPropertyName("vertices")]
				[Description("经纬度列表，外圈为逆时针")]
				public List<VerticesItem> Vertices { get; set; }

				public class VerticesItem
				{
					[JsonPropertyName("longitude")]
					[Description("经度")]
					public decimal Longitude { get; set; }

					[JsonPropertyName("latitude")]
					[Description("纬度")]
					public decimal Latitude { get; set; }
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
					public decimal Longitude { get; set; }

					[JsonPropertyName("latitude")]
					[Description("纬度")]
					public decimal Latitude { get; set; }
				}
			}
		}
	}
}
