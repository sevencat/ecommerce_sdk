namespace ecommerce.sdk.douyin;

[Description("查询机构某天的选品GMV，不包括抖音应用选品GMV数据")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
public class BuyinInstGmvReq : IDouyinReq<BuyinInstGmvRsp>
{

	public string GetMethod() { return "buyin.instGmv"; }

	public string GetUrl() { return "/buyin/instGmv"; }

	[JsonPropertyName("date")]
	[Description("日期（只支持查询[t-60,t-2]的GMV）")]
	[NotNull]
	public string Date { get; set; }

	[JsonPropertyName("search_type")]
	[Description("查询粒度（1-查询当前应用，2-查询应用所属工具服务商，不包括抖音应用选品GMV数据）")]
	public long? SearchType { get; set; }
}

[Description("查询机构某天的选品GMV，不包括抖音应用选品GMV数据")]
public class BuyinInstGmvRsp
{
	[JsonPropertyName("data")]
	[Description("数据")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("gmv")]
		[Description("GMV（单位：分）")]
		public long Gmv { get; set; }
	}
}
