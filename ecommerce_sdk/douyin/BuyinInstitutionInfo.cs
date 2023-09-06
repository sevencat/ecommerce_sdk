namespace ecommerce.sdk.douyin;

[Description("获取机构各角色的信息，如百应ID、角色名称等")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","无效用户","isv.business-failed:4157","无效用户")]
public class BuyinInstitutionInfoReq : IDouyinReq<BuyinInstitutionInfoRsp>
{

	public string GetMethod() { return "buyin.institutionInfo"; }

	public string GetUrl() { return "/buyin/institutionInfo"; }

}

[Description("获取机构各角色的信息，如百应ID、角色名称等")]
public class BuyinInstitutionInfoRsp
{
	[JsonPropertyName("institution_id")]
	[Description("机构ID")]
	public long InstitutionId { get; set; }

	[JsonPropertyName("colonel")]
	[Description("团长信息")]
	public ColonelItem Colonel { get; set; }

	public class ColonelItem
	{
		[JsonPropertyName("buyin_id")]
		[Description("团长百应ID")]
		public long BuyinId { get; set; }

		[JsonPropertyName("name")]
		[Description("团长名称")]
		public string Name { get; set; }
	}

	[JsonPropertyName("mcn")]
	[Description("MCN信息")]
	public McnItem Mcn { get; set; }

	public class McnItem
	{
		[JsonPropertyName("buyin_id")]
		[Description("机构百应ID")]
		public long BuyinId { get; set; }

		[JsonPropertyName("name")]
		[Description("机构名称")]
		public string Name { get; set; }
	}

	[JsonPropertyName("douke")]
	[Description("抖客信息")]
	public DoukeItem Douke { get; set; }

	public class DoukeItem
	{
		[JsonPropertyName("buyin_id")]
		[Description("抖音百应ID")]
		public long BuyinId { get; set; }

		[JsonPropertyName("name")]
		[Description("抖客名称")]
		public string Name { get; set; }
	}
}
