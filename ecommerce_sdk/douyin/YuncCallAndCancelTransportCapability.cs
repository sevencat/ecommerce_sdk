namespace ecommerce.sdk.douyin;

[Description("同城零售的运力呼叫和运力取消")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20001,"内部服务超时","1103:内部服务超时，请重试","isp.service-timeout-error:1103","请重试！")]
public class YuncCallAndCancelTransportCapabilityReq : IDouyinReq<YuncCallAndCancelTransportCapabilityRsp>
{

	public string GetMethod() { return "yunc.callAndCancelTransportCapability"; }

	public string GetUrl() { return "/yunc/callAndCancelTransportCapability"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID（运力服务商侧的门店ID）")]
	[NotNull]
	public string StoreId { get; set; }

	[JsonPropertyName("platform_order_no")]
	[Description("订单ID（店铺单）抖音电商平台交易父订单号（如果合单，取合单的其一即可）")]
	[NotNull]
	public string PlatformOrderNo { get; set; }

	[JsonPropertyName("order_details")]
	[Description("合单订单需要告知抖音电商交易父子订单号列表")]
	[NotNull]
	public List<OrderDetailsItem> OrderDetails { get; set; }

	public class OrderDetailsItem
	{
		[JsonPropertyName("platform_order_no")]
		[Description("抖音电商平台交易父订单号")]
		[NotNull]
		public string PlatformOrderNo { get; set; }

		[JsonPropertyName("subplatform_order_no")]
		[Description("抖音电商平台交易子订单号")]
		[NotNull]
		public string SubplatformOrderNo { get; set; }
	}

	[JsonPropertyName("out_order_no")]
	[Description("ERP单号")]
	[NotNull]
	public string OutOrderNo { get; set; }

	[JsonPropertyName("sender_info")]
	[Description("发件人信息（条件必填，呼叫运力时必填！）")]
	public SenderInfoItem SenderInfo { get; set; }

	public class SenderInfoItem
	{
		[JsonPropertyName("province_code")]
		[Description("省份编码")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("province")]
		[Description("省份名称（必传）")]
		public string Province { get; set; }

		[JsonPropertyName("city_code")]
		[Description("城市编码")]
		public string CityCode { get; set; }

		[JsonPropertyName("city")]
		[Description("城市名称（必传）")]
		public string City { get; set; }

		[JsonPropertyName("district_code")]
		[Description("地区编码")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district")]
		[Description("地区名称（必传）")]
		public string District { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编码")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street")]
		[Description("街道名称")]
		public string Street { get; set; }

		[JsonPropertyName("detail")]
		[Description("详细地址（必传）")]
		public string Detail { get; set; }

		[JsonPropertyName("name")]
		[Description("姓名")]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("联系方式（mobile/tel_phone 其一必传）")]
		public string Mobile { get; set; }

		[JsonPropertyName("tel_phone")]
		[Description("固定电话（mobile/tel_phone 其一必传）")]
		public string TelPhone { get; set; }

		[JsonPropertyName("oaids")]
		[Description("地址id")]
		public string Oaids { get; set; }
	}

	[JsonPropertyName("receiver_info")]
	[Description("收件人信息（条件必填，呼叫运力时必填！）")]
	public ReceiverInfoItem ReceiverInfo { get; set; }

	public class ReceiverInfoItem
	{
		[JsonPropertyName("province_code")]
		[Description("省份编码")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("province")]
		[Description("省份名称（必传）")]
		public string Province { get; set; }

		[JsonPropertyName("city_code")]
		[Description("城市编码")]
		public string CityCode { get; set; }

		[JsonPropertyName("city")]
		[Description("城市名称（必传）")]
		public string City { get; set; }

		[JsonPropertyName("district_code")]
		[Description("地区编码")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district")]
		[Description("地区名称（必传）")]
		public string District { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编码")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street")]
		[Description("街道名称")]
		public string Street { get; set; }

		[JsonPropertyName("detail")]
		[Description("详细地址（必传）")]
		public string Detail { get; set; }

		[JsonPropertyName("name")]
		[Description("姓名")]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("联系方式（mobile/tel_phone 其一必传）")]
		public string Mobile { get; set; }

		[JsonPropertyName("tel_phone")]
		[Description("固定电话（mobile/tel_phone 其一必传）")]
		public string TelPhone { get; set; }

		[JsonPropertyName("oaids")]
		[Description("地址id")]
		public string Oaids { get; set; }
	}

	[JsonPropertyName("service_provider")]
	[Description("呼单运力服务商品牌（shenzhenshishun=顺丰同城，dajiangwangluo=达达）")]
	[NotNull]
	public string ServiceProvider { get; set; }

	[JsonPropertyName("dispatcher_type")]
	[Description("1 = 呼叫运力，2 = 取消运力")]
	[NotNull]
	public int? DispatcherType { get; set; }
}

[Description("同城零售的运力呼叫和运力取消")]
public class YuncCallAndCancelTransportCapabilityRsp
{
	[JsonPropertyName("data")]
	[Description("返回结果")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("track_no")]
		[Description("骑手配送运单号（上传交易发货使用）")]
		public string TrackNo { get; set; }

		[JsonPropertyName("logistics_track_no")]
		[Description("电子面单号，用作打印面单使用（暂时）")]
		public string LogisticsTrackNo { get; set; }

		[JsonPropertyName("service_provider")]
		[Description("呼单运力服务商品牌,(shenzhenshishun=顺丰同城，dajiangwangluo=达达)")]
		public string ServiceProvider { get; set; }

		[JsonPropertyName("to_aoi_name")]
		[Description("接驳模式下运力服务商返回的接驳商圈，需要打印在面单中")]
		public string ToAoiName { get; set; }
	}
}
