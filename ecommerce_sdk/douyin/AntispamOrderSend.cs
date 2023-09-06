namespace ecommerce.sdk.douyin;

[Description("支持使用在ISV系统商户发送（外部系统或模块，如快递平台）场景,用户在ISV通过API等方式推送到第三方服务时")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:-1","系统繁忙，请稍后重试")]
public class AntispamOrderSendReq : IDouyinReq<AntispamOrderSendRsp>
{

	public string GetMethod() { return "antispam.orderSend"; }

	public string GetUrl() { return "/antispam/orderSend"; }

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
	[Description("可变参数")]
	[NotNull]
	public string Params { get; set; }
}

[Description("支持使用在ISV系统商户发送（外部系统或模块，如快递平台）场景,用户在ISV通过API等方式推送到第三方服务时")]
public class AntispamOrderSendRsp
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
