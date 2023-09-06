namespace ecommerce.sdk.douyin;

[Description("快递模式轨迹推送")]
public class LogisticsTrackPushReq : IDouyinReq<LogisticsTrackPushRsp>
{

	public string GetMethod() { return "logistics.trackPush"; }

	public string GetUrl() { return "/logistics/trackPush"; }

	[JsonPropertyName("cur_time")]
	[Description("推送时间")]
	[NotNull]
	public string CurTime { get; set; }

	[JsonPropertyName("company")]
	[Description("快递公司编码")]
	[NotNull]
	public string Company { get; set; }

	[JsonPropertyName("trace_msgs")]
	[Description("消息列表")]
	[NotNull]
	public List<TraceMsgsItem> TraceMsgs { get; set; }

	public class TraceMsgsItem
	{
		[JsonPropertyName("track_no")]
		[Description("运单号")]
		[NotNull]
		public string TrackNo { get; set; }

		[JsonPropertyName("traces")]
		[Description("运单对应的轨迹列表")]
		[NotNull]
		public List<TracesItem> Traces { get; set; }

		public class TracesItem
		{
			[JsonPropertyName("trace_type")]
			[Description("轨迹的一级类型")]
			[NotNull]
			public string TraceType { get; set; }

			[JsonPropertyName("trace_sub_type")]
			[Description("轨迹的二级类型")]
			[NotNull]
			public string TraceSubType { get; set; }

			[JsonPropertyName("op_time")]
			[Description("当前轨迹的操作时间")]
			[NotNull]
			public string OpTime { get; set; }

			[JsonPropertyName("content")]
			[Description("轨迹文案")]
			[NotNull]
			public string Content { get; set; }

			[JsonPropertyName("current_address")]
			[Description("操作网点地址")]
			public CurrentAddressItem CurrentAddress { get; set; }

			public class CurrentAddressItem
			{
				[JsonPropertyName("province")]
				[Description("省份名称")]
				public string Province { get; set; }

				[JsonPropertyName("province_code")]
				[Description("省份编码")]
				public string ProvinceCode { get; set; }

				[JsonPropertyName("city")]
				[Description("城市名称")]
				public string City { get; set; }

				[JsonPropertyName("city_code")]
				[Description("城市编码")]
				public string CityCode { get; set; }

				[JsonPropertyName("town")]
				[Description("区县名称")]
				public string Town { get; set; }

				[JsonPropertyName("town_code")]
				[Description("区县编码")]
				public string TownCode { get; set; }

				[JsonPropertyName("street")]
				[Description("街道名称")]
				public string Street { get; set; }

				[JsonPropertyName("street_code")]
				[Description("街道编码")]
				public string StreetCode { get; set; }

				[JsonPropertyName("detail")]
				[Description("详细地址")]
				public string Detail { get; set; }
			}

			[JsonPropertyName("next_address")]
			[Description("发件轨迹等发往下一网点的地址")]
			public NextAddressItem NextAddress { get; set; }

			public class NextAddressItem
			{
				[JsonPropertyName("province")]
				[Description("省份名称")]
				public string Province { get; set; }

				[JsonPropertyName("province_code")]
				[Description("省份编码")]
				public string ProvinceCode { get; set; }

				[JsonPropertyName("city")]
				[Description("城市名称")]
				public string City { get; set; }

				[JsonPropertyName("city_code")]
				[Description("城市编码")]
				public string CityCode { get; set; }

				[JsonPropertyName("town")]
				[Description("区县名称")]
				public string Town { get; set; }

				[JsonPropertyName("town_code")]
				[Description("区县编码")]
				public string TownCode { get; set; }

				[JsonPropertyName("street")]
				[Description("街道名称")]
				public string Street { get; set; }

				[JsonPropertyName("street_code")]
				[Description("街道编码")]
				public string StreetCode { get; set; }

				[JsonPropertyName("detail")]
				[Description("详细地址")]
				public string Detail { get; set; }
			}

			[JsonPropertyName("reason")]
			[Description("原因")]
			public string Reason { get; set; }

			[JsonPropertyName("city")]
			[Description("网点所在城市")]
			public string City { get; set; }

			[JsonPropertyName("site_name")]
			[Description("网点名称")]
			public string SiteName { get; set; }

			[JsonPropertyName("site_code")]
			[Description("网点编码")]
			public string SiteCode { get; set; }

			[JsonPropertyName("operator_name")]
			[Description("操作员姓名")]
			public string OperatorName { get; set; }

			[JsonPropertyName("operator_phone")]
			[Description("操作员电话")]
			public string OperatorPhone { get; set; }

			[JsonPropertyName("facility_type")]
			[Description("网点类型")]
			public string FacilityType { get; set; }

			[JsonPropertyName("next_site_code")]
			[Description("下一网点编码")]
			public string NextSiteCode { get; set; }

			[JsonPropertyName("exception_code")]
			[Description("异常编码")]
			public string ExceptionCode { get; set; }

			[JsonPropertyName("description")]
			[Description("异常原因描述")]
			public string Description { get; set; }

			[JsonPropertyName("new_track_no")]
			[Description("换单单号")]
			public string NewTrackNo { get; set; }

			[JsonPropertyName("new_company")]
			[Description("换单快递公司编码")]
			public string NewCompany { get; set; }

			[JsonPropertyName("time")]
			[Description("预约时间")]
			public string Time { get; set; }

			[JsonPropertyName("third_sort_code")]
			[Description("三段码")]
			public string ThirdSortCode { get; set; }

			[JsonPropertyName("is_not_learning")]
			[Description("无需学习标记（布尔类型）")]
			public bool? IsNotLearning { get; set; }

			[JsonPropertyName("courier_id")]
			[Description("派件人ID")]
			public string CourierId { get; set; }

			[JsonPropertyName("third_party_company")]
			[Description("代派公司编码")]
			public string ThirdPartyCompany { get; set; }

			[JsonPropertyName("address")]
			[Description("提货地址/驿站地址")]
			public string Address { get; set; }

			[JsonPropertyName("pick_code")]
			[Description("提货码")]
			public string PickCode { get; set; }

			[JsonPropertyName("station_name")]
			[Description("驿站名称")]
			public string StationName { get; set; }

			[JsonPropertyName("station_phone")]
			[Description("驿站电话")]
			public string StationPhone { get; set; }

			[JsonPropertyName("cabinet_name")]
			[Description("自提柜名称")]
			public string CabinetName { get; set; }

			[JsonPropertyName("reason_type")]
			[Description("原因类型编码，不同二级事件下传不同的类型")]
			public string ReasonType { get; set; }

			[JsonPropertyName("new_address")]
			[Description("改地址新地址")]
			public NewAddressItem NewAddress { get; set; }

			public class NewAddressItem
			{
				[JsonPropertyName("province")]
				[Description("省份名称")]
				public string Province { get; set; }

				[JsonPropertyName("province_code")]
				[Description("省份编码")]
				public string ProvinceCode { get; set; }

				[JsonPropertyName("city")]
				[Description("城市名称")]
				public string City { get; set; }

				[JsonPropertyName("city_code")]
				[Description("城市编码")]
				public string CityCode { get; set; }

				[JsonPropertyName("town")]
				[Description("区县名称")]
				public string Town { get; set; }

				[JsonPropertyName("town_code")]
				[Description("区县编码")]
				public string TownCode { get; set; }

				[JsonPropertyName("street")]
				[Description("街道名称")]
				public string Street { get; set; }

				[JsonPropertyName("street_code")]
				[Description("街道编码")]
				public string StreetCode { get; set; }

				[JsonPropertyName("detail")]
				[Description("详细地址")]
				public string Detail { get; set; }
			}

			[JsonPropertyName("new_receiver")]
			[Description("改地址新收件人")]
			public NewReceiverItem NewReceiver { get; set; }

			public class NewReceiverItem
			{
				[JsonPropertyName("name")]
				[Description("改地址新收件人姓名")]
				public string Name { get; set; }

				[JsonPropertyName("mobile")]
				[Description("改地址新收件人电话")]
				public string Mobile { get; set; }
			}

			[JsonPropertyName("signer_name")]
			[Description("签收人")]
			public string SignerName { get; set; }
		}
	}
}

[Description("快递模式轨迹推送")]
public class LogisticsTrackPushRsp
{
}
