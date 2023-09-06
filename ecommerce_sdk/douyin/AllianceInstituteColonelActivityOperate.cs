namespace ecommerce.sdk.douyin;

[Description("专属团长活动删除接口（下线+删除）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","活动不是未上线阶段，不能重复上线","isv.business-failed:500","活动不是未上线阶段，不能重复上线")]
[DouyinRetCode(50002,"业务处理失败","活动不是未上线阶段，不能上线","isv.business-failed:110110","活动不是未上线阶段，不能重复上线")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","当前用户不是创建活动的用户","isv.business-failed:4139","当前用户不是创建活动的用户")]
[DouyinRetCode(50002,"业务处理失败","参数校验失败","isv.business-failed:257","参数校验失败，请检查")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
public class AllianceInstituteColonelActivityOperateReq : IDouyinReq<AllianceInstituteColonelActivityOperateRsp>
{

	public string GetMethod() { return "alliance.instituteColonelActivityOperate"; }

	public string GetUrl() { return "/alliance/instituteColonelActivityOperate"; }

	[JsonPropertyName("activity_id")]
	[Description("团长活动id")]
	[NotNull]
	public long? ActivityId { get; set; }

	[JsonPropertyName("operation")]
	[Description("团长活动状态变更： 1上线，2下线，3删除，4结束报名")]
	public long? Operation { get; set; }
}

[Description("专属团长活动删除接口（下线+删除）")]
public class AllianceInstituteColonelActivityOperateRsp
{
}
