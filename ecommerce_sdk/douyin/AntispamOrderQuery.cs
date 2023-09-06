namespace ecommerce.sdk.douyin;

[Description("用户在ISV查看订单、下载订单时, 上报事件到风控系统,用户在ISV查看订单、下载订单时, ISV服务器端需要把查看日志实时发送给风控系统，调用风险控制接口，判断本次查询是否有风险")]
public class AntispamOrderQueryReq : IDouyinReq<AntispamOrderQueryRsp>
{

	public string GetMethod() { return "antispam.orderQuery"; }

	public string GetUrl() { return "/antispam/orderQuery"; }

	[JsonPropertyName("event_time")]
	[Description("事件时间")]
	[NotNull]
	public long? EventTime { get; set; }

	[JsonPropertyName("user")]
	[Description("用户")]
	public UserItem User { get; set; }

	public class UserItem
	{
		[JsonPropertyName("uid_type")]
		[Description("用户类型")]
		public int? UidType { get; set; }

		[JsonPropertyName("user_id")]
		[Description("用户 ID")]
		public long? UserId { get; set; }
	}

	[JsonPropertyName("params")]
	[Description("上报参数")]
	[NotNull]
	public string Params { get; set; }
}

[Description("用户在ISV查看订单、下载订单时, 上报事件到风控系统,用户在ISV查看订单、下载订单时, ISV服务器端需要把查看日志实时发送给风控系统，调用风险控制接口，判断本次查询是否有风险")]
public class AntispamOrderQueryRsp
{
	[JsonPropertyName("decision")]
	[Description("决策")]
	public DecisionItem Decision { get; set; }

	public class DecisionItem
	{
		[JsonPropertyName("decision")]
		[Description("决策")]
		public string DecisionI { get; set; }

		[JsonPropertyName("decision_detail")]
		[Description("决策详情")]
		public string DecisionDetail { get; set; }

		[JsonPropertyName("hit_status")]
		[Description("提示信息")]
		public string HitStatus { get; set; }
	}
}
