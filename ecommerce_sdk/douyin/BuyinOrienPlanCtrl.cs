namespace ecommerce.sdk.douyin;

[Description("支持商家关闭/删除/恢复 定向计划。,注意：1. 关闭进行中的定向计划 自然日T+1生效（东八区）；2. 删除过期的定向计划实时生效，不能删除正在进行中的定向计划。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效定向计划ID","isv.parameter-invalid:4114","无效定向计划ID")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","该计划禁止删除","isv.business-failed:4126","该计划禁止删除")]
[DouyinRetCode(50002,"业务处理失败","更新定向计划失败","isv.business-failed:4124","更新定向计划失败")]
[DouyinRetCode(50002,"业务处理失败","当天截止的计划不支持关停","isv.business-failed:4123","当天截止的计划不支持关停")]
[DouyinRetCode(50002,"业务处理失败","获取店铺ID失败","isv.business-failed:4096","获取店铺ID失败")]
public class BuyinOrienPlanCtrlReq : IDouyinReq<BuyinOrienPlanCtrlRsp>
{

	public string GetMethod() { return "buyin.orienPlanCtrl"; }

	public string GetUrl() { return "/buyin/orienPlanCtrl"; }

	[JsonPropertyName("orien_plan_id")]
	[Description("定向计划")]
	[NotNull]
	public string OrienPlanId { get; set; }

	[JsonPropertyName("action")]
	[Description("1-关闭，2- 恢复投放，3-删除")]
	[NotNull]
	public int? Action { get; set; }
}

[Description("支持商家关闭/删除/恢复 定向计划。,注意：1. 关闭进行中的定向计划 自然日T+1生效（东八区）；2. 删除过期的定向计划实时生效，不能删除正在进行中的定向计划。")]
public class BuyinOrienPlanCtrlRsp
{
}
