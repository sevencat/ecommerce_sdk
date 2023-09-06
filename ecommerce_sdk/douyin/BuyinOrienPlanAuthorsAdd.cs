namespace ecommerce.sdk.douyin;

[Description("商家向指定定向计划中添加达人")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效定向计划ID","isv.parameter-invalid:4114","无效定向计划ID")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","定向计划添加达人失败","isv.business-failed:4121","定向计划添加达人失败")]
public class BuyinOrienPlanAuthorsAddReq : IDouyinReq<BuyinOrienPlanAuthorsAddRsp>
{

	public string GetMethod() { return "buyin.orienPlanAuthorsAdd"; }

	public string GetUrl() { return "/buyin/orienPlanAuthorsAdd"; }

	[JsonPropertyName("orien_plan_id")]
	[Description("定向计划ID")]
	[NotNull]
	public string OrienPlanId { get; set; }

	[JsonPropertyName("buyin_ids")]
	[Description("达人百应ID列表，最多20个")]
	[NotNull]
	public List<long> BuyinIds { get; set; }
}

[Description("商家向指定定向计划中添加达人")]
public class BuyinOrienPlanAuthorsAddRsp
{
	[JsonPropertyName("success_ids")]
	[Description("添加成功的作者列表")]
	public List<long> SuccessIds { get; set; }

	[JsonPropertyName("failed_ids")]
	[Description("添加失败的作者列表")]
	public List<FailedIdsItem> FailedIds { get; set; }

	public class FailedIdsItem
	{
		[JsonPropertyName("buyin_id")]
		[Description("失败的作者百应ID")]
		public long BuyinId { get; set; }

		[JsonPropertyName("error_code")]
		[Description("错误码")]
		public long ErrorCode { get; set; }

		[JsonPropertyName("error_msg")]
		[Description("错误原因")]
		public string ErrorMsg { get; set; }
	}
}
