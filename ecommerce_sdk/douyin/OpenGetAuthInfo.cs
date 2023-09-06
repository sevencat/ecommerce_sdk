namespace ecommerce.sdk.douyin;

[Description("查询当前App下商家授权信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:100001","系统异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","auth_subject_type值非法","isv.parameter-invalid:100003","请填写正确的auth_subject_type")]
public class OpenGetAuthInfoReq : IDouyinReq<OpenGetAuthInfoRsp>
{

	public string GetMethod() { return "open.getAuthInfo"; }

	public string GetUrl() { return "/open/getAuthInfo"; }

	[JsonPropertyName("auth_id")]
	[Description("授权主体ID，这里为店铺ID")]
	[NotNull]
	public string AuthId { get; set; }

	[JsonPropertyName("auth_subject_type")]
	[Description("授权主体类型，默认为店铺授权，不需要填写。,其他类型枚举值如下：YunCang -云仓；WuLiuShang -物流商；WLGongYingShang -物流供应商；MiniApp -小程序 MCN-联盟MCN机构 DouKe-联盟抖客 Colonel-联盟团长")]
	public string AuthSubjectType { get; set; }
}

[Description("查询当前App下商家授权信息")]
public class OpenGetAuthInfoRsp
{
	[JsonPropertyName("status")]
	[Description("授权状态，1为正常。枚举为,0:待商家确认，1:正常，2:取消，3:过期。,授权状态为正常时，需额外判断auth_end_time")]
	public int Status { get; set; }

	[JsonPropertyName("auth_success_time")]
	[Description("授权生效时间")]
	public long AuthSuccessTime { get; set; }

	[JsonPropertyName("auth_end_time")]
	[Description("授权截止时间")]
	public long AuthEndTime { get; set; }

	[JsonPropertyName("auth_id")]
	[Description("授权主体ID")]
	public string AuthId { get; set; }

	[JsonPropertyName("auth_update_time")]
	[Description("授权最近一次更新时间")]
	public long AuthUpdateTime { get; set; }
}
