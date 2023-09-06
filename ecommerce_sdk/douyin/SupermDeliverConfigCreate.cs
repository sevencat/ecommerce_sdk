namespace ecommerce.sdk.douyin;

[Description("门店时效管理规则-添加（店铺或门店维度）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40100","参数错误")]
[DouyinRetCode(50002,"业务处理失败","数据转换错误","isv.business-failed:50202","数据转换错误")]
[DouyinRetCode(50002,"业务处理失败","配置已存在","isv.business-failed:20238","配置已存在")]
public class SupermDeliverConfigCreateReq : IDouyinReq<SupermDeliverConfigCreateRsp>
{

	public string GetMethod() { return "superm.deliverConfig.create"; }

	public string GetUrl() { return "/superm/deliverConfig/create"; }

	[JsonPropertyName("shop_deliver_config_list")]
	[Description("配置列表")]
	[NotNull]
	public List<ShopDeliverConfigListItem> ShopDeliverConfigList { get; set; }

	public class ShopDeliverConfigListItem
	{
		[JsonPropertyName("store_id")]
		[Description("门店id")]
		public long? StoreId { get; set; }

		[JsonPropertyName("config_type")]
		[Description("配置维度,1：店铺,2：门店")]
		[NotNull]
		public int? ConfigType { get; set; }

		[JsonPropertyName("deliver_type")]
		[Description("配送类型,1：商家自行配置配送时长,2：系统自动计算配置时长")]
		[NotNull]
		public int? DeliverType { get; set; }

		[JsonPropertyName("normal_time_cost")]
		[Description("三公里内常规时间配送时长（分钟）")]
		[NotNull]
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
		[NotNull]
		public long? OverLimitTimeCost { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public long? UpdateTime { get; set; }

		[JsonPropertyName("config_status")]
		[Description("配置状态,1：启动,2：弃用")]
		[NotNull]
		public int? ConfigStatus { get; set; }
	}
}

[Description("门店时效管理规则-添加（店铺或门店维度）")]
public class SupermDeliverConfigCreateRsp
{
}
