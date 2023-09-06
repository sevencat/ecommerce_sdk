namespace ecommerce.sdk.douyin;

[Description("1. 返回的容量单位都是KB，如果想转成G，请除以 1024*1024；,2. 目前权益类型（equity_type）有：Free-免费容量，B-B类商家独有权益，JBP-JBP类商家独有权益 这三类，后续会慢慢增加。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","店铺ID错误，请输入正确的店铺ID","isv.missing-parameter:20001","补充ShopId")]
[DouyinRetCode(20000,"系统错误","系统异常，请稍后重试","isp.service-error:10004","稍后重试")]
[DouyinRetCode(40004,"非法的参数","素材中心已失效，请联系客服处理","isv.parameter-invalid:30004","联系客服")]
public class MaterialGetCapInfoReq : IDouyinReq<MaterialGetCapInfoRsp>
{

	public string GetMethod() { return "material.get_cap_info"; }

	public string GetUrl() { return "/material/get_cap_info"; }

}

[Description("1. 返回的容量单位都是KB，如果想转成G，请除以 1024*1024；,2. 目前权益类型（equity_type）有：Free-免费容量，B-B类商家独有权益，JBP-JBP类商家独有权益 这三类，后续会慢慢增加。")]
public class MaterialGetCapInfoRsp
{
	[JsonPropertyName("total_capacity")]
	[Description("总容量，单位KB")]
	public long TotalCapacity { get; set; }

	[JsonPropertyName("total_capacity_used")]
	[Description("已使用容量，单位KB")]
	public long TotalCapacityUsed { get; set; }

	[JsonPropertyName("photo_capacity")]
	[Description("图片总容量，单位KB")]
	public long PhotoCapacity { get; set; }

	[JsonPropertyName("photo_capacity_used")]
	[Description("图片已使用容量，单位KB")]
	public long PhotoCapacityUsed { get; set; }

	[JsonPropertyName("video_capacity")]
	[Description("视频总容量，单位KB")]
	public long VideoCapacity { get; set; }

	[JsonPropertyName("video_capacity_used")]
	[Description("视频已使用容量，单位KB")]
	public long VideoCapacityUsed { get; set; }

	[JsonPropertyName("equity_info")]
	[Description("当前生效的权益列表")]
	public List<EquityInfoItem> EquityInfo { get; set; }

	public class EquityInfoItem
	{
		[JsonPropertyName("equity_type")]
		[Description("权益类型")]
		public string EquityType { get; set; }

		[JsonPropertyName("equity_type_desc")]
		[Description("权益描述")]
		public string EquityTypeDesc { get; set; }

		[JsonPropertyName("begin_time")]
		[Description("权益开始时间")]
		public long BeginTime { get; set; }

		[JsonPropertyName("end_time")]
		[Description("权益结束时间")]
		public long EndTime { get; set; }

		[JsonPropertyName("total_capacity")]
		[Description("该权益对应的总容量，单位KB")]
		public long TotalCapacity { get; set; }

		[JsonPropertyName("photo_capacity")]
		[Description("该权益对应的图片总容量，单位KB")]
		public long PhotoCapacity { get; set; }

		[JsonPropertyName("video_capacity")]
		[Description("该权益对应的视频总容量，单位KB")]
		public long VideoCapacity { get; set; }
	}
}
