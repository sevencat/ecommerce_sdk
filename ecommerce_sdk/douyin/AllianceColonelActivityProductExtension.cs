namespace ecommerce.sdk.douyin;

[Description("专属团长活动商品延时接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","推广延长时间小于当前时间或小于设置的推广结束时间","isv.business-failed:4137","请检查延长时间")]
[DouyinRetCode(50002,"业务处理失败","需【招商团长】角色授权后访问","isv.business-failed:4197","需【招商团长】角色授权后访问")]
[DouyinRetCode(50002,"业务处理失败","活动不是处在报名中，不能审核","isv.business-failed:4140","活动不是处在报名中，不能审核")]
[DouyinRetCode(50002,"业务处理失败","当前用户不是创建活动的用户","isv.business-failed:4139","当前用户不是创建活动的用户")]
public class AllianceColonelActivityProductExtensionReq : IDouyinReq<AllianceColonelActivityProductExtensionRsp>
{

	public string GetMethod() { return "alliance.colonelActivityProductExtension"; }

	public string GetUrl() { return "/alliance/colonelActivityProductExtension"; }

	[JsonPropertyName("activity_id")]
	[Description("团长活动id")]
	[NotNull]
	public long? ActivityId { get; set; }

	[JsonPropertyName("product_ids")]
	[Description("商品id 用,隔开,少于100个")]
	[NotNull]
	public List<long> ProductIds { get; set; }

	[JsonPropertyName("extend_time")]
	[Description("延长的时长")]
	[NotNull]
	public string ExtendTime { get; set; }
}

[Description("专属团长活动商品延时接口")]
public class AllianceColonelActivityProductExtensionRsp
{
	[JsonPropertyName("data")]
	[Description("延迟失败原因列表")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("msg")]
		[Description("失败原因。包括但不限于：“当前申请正在审核中，审核结束后可操作”，“商品不支持延长推广”，“已经取消合作的推广商品无法再申请延长推广”，“该商品已经托管给其他机构，或者正在等待托管的机构进行审核”， “申请延长的截止时间应该大于原推广截止时间”， “当前商品还未开始推广，不支持申请延长推广”， “当前商品已达到最长推广时间，不支持申请延长推广”")]
		public string Msg { get; set; }
	}
}
