namespace ecommerce.sdk.douyin;

[Description("时效管理更新")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40100","参数错误")]
[DouyinRetCode(50002,"业务处理失败","时效配置查询失败","isv.business-failed:202326","时效配置查询失败")]
[DouyinRetCode(50002,"业务处理失败","当前店铺下未查询到该配置","isv.business-failed:202327","当前店铺下未查询到该配置")]
public class SupermDeliverConfigUpdateReq : IDouyinReq<SupermDeliverConfigUpdateRsp>
{

	public string GetMethod() { return "superm.deliverConfig.update"; }

	public string GetUrl() { return "/superm/deliverConfig/update"; }

	[JsonPropertyName("config_ids")]
	[Description("配置ID列表")]
	[NotNull]
	public List<long> ConfigIds { get; set; }

	[JsonPropertyName("shop_deliver_config")]
	[Description("配置信息")]
	[NotNull]
	public ShopDeliverConfigItem ShopDeliverConfig { get; set; }

	public class ShopDeliverConfigItem
	{
		[JsonPropertyName("deliver_type")]
		[Description("配送类型,1：商家自行配置配送时长,2：系统自动计算配置时长")]
		public int? DeliverType { get; set; }

		[JsonPropertyName("normal_time_cost")]
		[Description("三公里内常规时间配送时长（分钟）")]
		public long? NormalTimeCost { get; set; }

		[JsonPropertyName("special_time_list")]
		[Description("三公里内特殊时段列表")]
		public List<SpecialTimeListItem> SpecialTimeList { get; set; }

		public class SpecialTimeListItem
		{
			[JsonPropertyName("start_time")]
			[Description("时间片（单位秒，表示第几秒，如36000表示10:00）")]
			[NotNull]
			public long? StartTime { get; set; }

			[JsonPropertyName("end_time")]
			[Description("时间片（单位秒，表示第几秒，如39600表示11:00）")]
			[NotNull]
			public long? EndTime { get; set; }

			[JsonPropertyName("time_cost")]
			[Description("时间片内对应的配送时长（分钟）")]
			[NotNull]
			public long? TimeCost { get; set; }
		}

		[JsonPropertyName("over_limit_time_cost")]
		[Description("三公里外每公里增加的配送时长（分钟）")]
		public long? OverLimitTimeCost { get; set; }
	}
}

[Description("时效管理更新")]
public class SupermDeliverConfigUpdateRsp
{
}
