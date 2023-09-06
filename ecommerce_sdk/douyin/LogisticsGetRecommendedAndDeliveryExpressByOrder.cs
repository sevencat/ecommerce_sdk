namespace ecommerce.sdk.douyin;

[Description("查询订单维度快递可达及推荐服务")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:4006","根据错误描述检查参数")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:4007","一般重试可解决，若一直报错请联系oncall")]
[DouyinRetCode(20000,"系统错误","查询订单信息失败","isp.service-error:15000","一般重试可解决，若一直报错请联系oncall")]
[DouyinRetCode(50002,"业务处理失败","订单信息不存在","isv.business-failed:15002","检查传入订单号是否是抖店正确订单号")]
[DouyinRetCode(40004,"非法的参数","用户未开通该服务","isv.parameter-invalid:100001","抖店后台-物流服务-开通发货探查服务")]
public class LogisticsGetRecommendedAndDeliveryExpressByOrderReq : IDouyinReq<LogisticsGetRecommendedAndDeliveryExpressByOrderRsp>
{

	public string GetMethod() { return "logistics.getRecommendedAndDeliveryExpressByOrder"; }

	public string GetUrl() { return "/logistics/getRecommendedAndDeliveryExpressByOrder"; }

	[JsonPropertyName("sender_address")]
	[Description("发货地址")]
	[NotNull]
	public SenderAddressItem SenderAddress { get; set; }

	public class SenderAddressItem
	{
		[JsonPropertyName("country_code")]
		[Description("1")]
		public string CountryCode { get; set; }

		[JsonPropertyName("province_code")]
		[Description("1")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("province_name")]
		[Description("省")]
		[NotNull]
		public string ProvinceName { get; set; }

		[JsonPropertyName("city_code")]
		[Description("1")]
		public string CityCode { get; set; }

		[JsonPropertyName("city_name")]
		[Description("市")]
		[NotNull]
		public string CityName { get; set; }

		[JsonPropertyName("district_code")]
		[Description("1")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district_name")]
		[Description("区")]
		[NotNull]
		public string DistrictName { get; set; }

		[JsonPropertyName("street_code")]
		[Description("1")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street_name")]
		[Description("街道")]
		public string StreetName { get; set; }

		[JsonPropertyName("detail_address")]
		[Description("详细地址")]
		[NotNull]
		public string DetailAddress { get; set; }

		[JsonPropertyName("address_id")]
		[Description("1")]
		public long? AddressId { get; set; }

		[JsonPropertyName("zip_code")]
		[Description("1")]
		public string ZipCode { get; set; }
	}

	[JsonPropertyName("order_info_list")]
	[Description("订单信息列表")]
	[NotNull]
	public List<OrderInfoListItem> OrderInfoList { get; set; }

	public class OrderInfoListItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单号")]
		[NotNull]
		public string OrderId { get; set; }

		[JsonPropertyName("product_type")]
		[Description("产品类型，可不传")]
		public string ProductType { get; set; }

		[JsonPropertyName("express_list")]
		[Description("物流商集合，不传默认：yuantong、zhongtong、yunda、shunfeng、jd、jtexpress、shentong")]
		public List<string> ExpressList { get; set; }
	}

	[JsonPropertyName("order_channel")]
	[Description("订单平台来源编码，不传默认抖店")]
	public string OrderChannel { get; set; }
}

[Description("查询订单维度快递可达及推荐服务")]
public class LogisticsGetRecommendedAndDeliveryExpressByOrderRsp
{
	[JsonPropertyName("data")]
	[Description("返回值")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("order_privilege_info_list")]
		[Description("订单权益列表")]
		public List<OrderPrivilegeInfoListItem> OrderPrivilegeInfoList { get; set; }

		public class OrderPrivilegeInfoListItem
		{
			[JsonPropertyName("reason")]
			[Description("订单打标原因")]
			public string Reason { get; set; }

			[JsonPropertyName("label")]
			[Description("订单标签描述")]
			public string Label { get; set; }

			[JsonPropertyName("code")]
			[Description("订单标签code")]
			public string Code { get; set; }
		}

		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("express_info_list")]
		[Description("推荐及可达物流商信息集合")]
		public List<ExpressInfoListItem> ExpressInfoList { get; set; }

		public class ExpressInfoListItem
		{
			[JsonPropertyName("tail_Info")]
			[Description("超长单")]
			public TailInfoItem TailInfo { get; set; }

			public class TailInfoItem
			{
				[JsonPropertyName("level_percent")]
				[Description("超长单占比超过百分之多少商家")]
				public string LevelPercent { get; set; }

				[JsonPropertyName("optimized_percent")]
				[Description("超长单占比优化百分比")]
				public string OptimizedPercent { get; set; }

				[JsonPropertyName("tail_rate")]
				[Description("超长单占比")]
				public string TailRate { get; set; }
			}

			[JsonPropertyName("ccr_Info")]
			[Description("物流负向反馈率（狭义）")]
			public CcrInfoItem CcrInfo { get; set; }

			public class CcrInfoItem
			{
				[JsonPropertyName("level_percent")]
				[Description("物流负向反馈率（狭义）超过百分之多少商家")]
				public string LevelPercent { get; set; }

				[JsonPropertyName("optimized_percent")]
				[Description("物流负向反馈率（狭义）优化百分比")]
				public string OptimizedPercent { get; set; }

				[JsonPropertyName("ccr_rate")]
				[Description("物流负向反馈率（狭义）")]
				public string CcrRate { get; set; }
			}

			[JsonPropertyName("rank_route")]
			[Description("此线路上该物流商排名")]
			public int RankRoute { get; set; }

			[JsonPropertyName("undeliverable_reason")]
			[Description("是否可用（含不可达与线路机构异常）")]
			public string UndeliverableReason { get; set; }

			[JsonPropertyName("express")]
			[Description("物流商编码")]
			public string Express { get; set; }

			[JsonPropertyName("is_deliverable")]
			[Description("是否可达")]
			public bool IsDeliverable { get; set; }

			[JsonPropertyName("is_shop_eBill")]
			[Description("是否订购电子面单")]
			public bool IsShopEBill { get; set; }

			[JsonPropertyName("is_recommended")]
			[Description("是否推荐")]
			public bool IsRecommended { get; set; }

			[JsonPropertyName("collect_sign_info")]
			[Description("时长维度的推荐原因")]
			public CollectSignInfoItem CollectSignInfo { get; set; }

			public class CollectSignInfoItem
			{
				[JsonPropertyName("avg_cost_hours")]
				[Description("揽签时长,单位小时")]
				public string AvgCostHours { get; set; }

				[JsonPropertyName("level_percent")]
				[Description("该线路商超过其他物流公司23.86%")]
				public string LevelPercent { get; set; }

				[JsonPropertyName("optimized_percent")]
				[Description("优化百分比，时长下降6.1%")]
				public string OptimizedPercent { get; set; }
			}
		}
	}
}
