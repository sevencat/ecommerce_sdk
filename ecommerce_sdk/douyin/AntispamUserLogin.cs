namespace ecommerce.sdk.douyin;

[Description("商户登陆风险检查")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","-1:cds_key=EGRESS|webarch.shark.antispam:default:lf:|webarch.shark.inner_antispam:default::|CheckSpam|prod| reason=request timeout connect_timeout=10ms request_timeout=44ms real_time=41840us fault_delay=0ms","isv.business-failed:-1","-")]
public class AntispamUserLoginReq : IDouyinReq<AntispamUserLoginRsp>
{

	public string GetMethod() { return "antispam.userLogin"; }

	public string GetUrl() { return "/antispam/userLogin"; }

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

	[JsonPropertyName("event_time")]
	[Description("事件时间")]
	public long? EventTime { get; set; }
}

[Description("商户登陆风险检查")]
public class AntispamUserLoginRsp
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
