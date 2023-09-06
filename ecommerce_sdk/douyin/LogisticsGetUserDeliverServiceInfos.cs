namespace ecommerce.sdk.douyin;

[Description("查询商家开通的发货服务信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:4006","检查入参重试")]
[DouyinRetCode(20000,"系统错误","系统异常请重试","isp.service-error:4007","系统异常请重试")]
public class LogisticsGetUserDeliverServiceInfosReq : IDouyinReq<LogisticsGetUserDeliverServiceInfosRsp>
{

	public string GetMethod() { return "logistics.getUserDeliverServiceInfos"; }

	public string GetUrl() { return "/logistics/getUserDeliverServiceInfos"; }

	[JsonPropertyName("biz_info")]
	[Description("商家信息")]
	[NotNull]
	public BizInfoItem BizInfo { get; set; }

	public class BizInfoItem
	{
		[JsonPropertyName("biz_type")]
		[Description("1：抖店")]
		[NotNull]
		public int? BizType { get; set; }
	}

	[JsonPropertyName("service_codes")]
	[Description("GetRecommendedAndDeliveryExpressByOrder：By单快递推荐服务")]
	public List<string> ServiceCodes { get; set; }
}

[Description("查询商家开通的发货服务信息")]
public class LogisticsGetUserDeliverServiceInfosRsp
{
	[JsonPropertyName("user_service_infos")]
	[Description("用户发货服务信息")]
	public List<UserServiceInfosItem> UserServiceInfos { get; set; }

	public class UserServiceInfosItem
	{
		[JsonPropertyName("service_info")]
		[Description("发货服务信息")]
		public ServiceInfoItem ServiceInfo { get; set; }

		public class ServiceInfoItem
		{
			[JsonPropertyName("service_code")]
			[Description("GetRecommendedAndDeliveryExpressByOrder")]
			public string ServiceCode { get; set; }

			[JsonPropertyName("service_name")]
			[Description("GetRecommendedAndDeliveryExpressByOrder")]
			public string ServiceName { get; set; }
		}

		[JsonPropertyName("effect_status")]
		[Description("0：未生效 1：已生效 2：已失效")]
		public int EffectStatus { get; set; }
	}
}
