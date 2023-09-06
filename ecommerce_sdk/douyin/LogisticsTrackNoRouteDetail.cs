namespace ecommerce.sdk.douyin;

[Description("查询条件：,1、必须是通过抖音电子面单获取的单号并且调用过发货接口回传的运单号才可以查询到物流轨迹；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","订单已取消，不允许变更","isv.parameter-invalid:10901","-")]
[DouyinRetCode(50002,"业务处理失败","非抖音电商电子面单不支持查询轨迹","isv.business-failed:10015","-")]
[DouyinRetCode(50002,"业务处理失败","请求内部服务超时，请重试","isv.business-failed:4007","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","记录不存在","isv.business-failed:-10004","-")]
[DouyinRetCode(50002,"业务处理失败","服务器开了小差，请稍后重试","isv.business-failed:-10006","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","运单号不能为空","isv.business-failed:4006","请检查运单号信息")]
[DouyinRetCode(50002,"业务处理失败","参数错误","isv.business-failed:-10001","请检查请求参数")]
public class LogisticsTrackNoRouteDetailReq : IDouyinReq<LogisticsTrackNoRouteDetailRsp>
{

	public string GetMethod() { return "logistics.trackNoRouteDetail"; }

	public string GetUrl() { return "/logistics/trackNoRouteDetail"; }

	[JsonPropertyName("logistics_code")]
	[Description("物流商编码；需使用【/order/logisticsCompanyList】接口响应参数中的code；")]
	[NotNull]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("track_no")]
	[Description("运单号；可使用电子面单接口获取返回的单号查询【/logistics/newCreateOrder】或商家店铺后台查看")]
	[NotNull]
	public string TrackNo { get; set; }
}

[Description("查询条件：,1、必须是通过抖音电子面单获取的单号并且调用过发货接口回传的运单号才可以查询到物流轨迹；")]
public class LogisticsTrackNoRouteDetailRsp
{
	[JsonPropertyName("route__node_list")]
	[Description("轨迹信息")]
	public List<RouteNodeListItem> RouteNodeList { get; set; }

	public class RouteNodeListItem
	{
		[JsonPropertyName("content")]
		[Description("轨迹内容")]
		public string Content { get; set; }

		[JsonPropertyName("timestamp")]
		[Description("时间戳；单位：秒")]
		public string Timestamp { get; set; }

		[JsonPropertyName("state")]
		[Description("轨迹状态code；枚举值详见：https://op.jinritemai.com/docs/question-docs/94/1642")]
		public string State { get; set; }

		[JsonPropertyName("state_description")]
		[Description("轨迹状态描述")]
		public string StateDescription { get; set; }

		[JsonPropertyName("site_name")]
		[Description("站点名称")]
		public string SiteName { get; set; }
	}

	[JsonPropertyName("track_info")]
	[Description("运单信息")]
	public TrackInfoItem TrackInfo { get; set; }

	public class TrackInfoItem
	{
		[JsonPropertyName("track_no")]
		[Description("运单号")]
		public string TrackNo { get; set; }

		[JsonPropertyName("express")]
		[Description("物流商编码")]
		public string Express { get; set; }
	}
}
