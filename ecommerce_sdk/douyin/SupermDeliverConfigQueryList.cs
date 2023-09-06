namespace ecommerce.sdk.douyin;

[Description("时效管理查询（店铺或门店维度）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:40100","参数错误")]
[DouyinRetCode(50002,"业务处理失败","时效配置查询失败","isv.business-failed:202326","时效配置查询失败")]
[DouyinRetCode(50002,"业务处理失败","当前店铺下未查询到该配置","isv.business-failed:202327","当前店铺下未查询到该配置")]
[DouyinRetCode(50002,"业务处理失败","数据转换错误","isv.business-failed:50202","数据转换错误")]
[DouyinRetCode(50002,"业务处理失败","门店查询服务失败","isv.business-failed:20233","门店查询服务失败")]
public class SupermDeliverConfigQueryListReq : IDouyinReq<SupermDeliverConfigQueryListRsp>
{

	public string GetMethod() { return "superm.deliverConfig.queryList"; }

	public string GetUrl() { return "/superm/deliverConfig/queryList"; }

	[JsonPropertyName("store_ids")]
	[Description("店铺id列表，不传则查门店下的配置")]
	public List<long> StoreIds { get; set; }
}

[Description("时效管理查询（店铺或门店维度）")]
public class SupermDeliverConfigQueryListRsp
{
	[JsonPropertyName("shop_deliver_config_list")]
	[Description("配置列表")]
	public List<ShopDeliverConfigListItem> ShopDeliverConfigList { get; set; }

	public class ShopDeliverConfigListItem
	{
		[JsonPropertyName("config_id")]
		[Description("配置ID")]
		public long ConfigId { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺Id")]
		public long ShopId { get; set; }

		[JsonPropertyName("store_id")]
		[Description("门店id")]
		public long StoreId { get; set; }

		[JsonPropertyName("config_type")]
		[Description("配置维度,1：店铺,2：门店")]
		public int ConfigType { get; set; }

		[JsonPropertyName("deliver_type")]
		[Description("配送类型,1：商家自行配置配送时长,2：系统自动计算配置时长")]
		public int DeliverType { get; set; }

		[JsonPropertyName("normal_time_cost")]
		[Description("三公里内常规时间配送时长（分钟）")]
		public long NormalTimeCost { get; set; }

		[JsonPropertyName("special_time_list")]
		[Description("三公里内特殊时段列表")]
		public List<SpecialTimeListItem> SpecialTimeList { get; set; }

		public class SpecialTimeListItem
		{
			[JsonPropertyName("start_time")]
			[Description("时间片（单位秒，表示第几秒，如36000表示10:00）")]
			public long StartTime { get; set; }

			[JsonPropertyName("end_time")]
			[Description("时间片（单位秒，表示第几秒，如39600表示11:00）")]
			public long EndTime { get; set; }

			[JsonPropertyName("time_cost")]
			[Description("时间片内对应的配送时长（分钟）")]
			public long TimeCost { get; set; }
		}

		[JsonPropertyName("over_limit_time_cost")]
		[Description("三公里外每公里增加的配送时长（分钟）")]
		public long OverLimitTimeCost { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间")]
		public long UpdateTime { get; set; }

		[JsonPropertyName("config_status")]
		[Description("配置状态")]
		public int ConfigStatus { get; set; }
	}
}
