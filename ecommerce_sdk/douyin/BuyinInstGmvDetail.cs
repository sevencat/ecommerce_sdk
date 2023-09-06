namespace ecommerce.sdk.douyin;

[Description("获取机构某天的选品GMV明细，不包括抖音应用选品GMV数据")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效size","isv.parameter-invalid:1031","无效size")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
public class BuyinInstGmvDetailReq : IDouyinReq<BuyinInstGmvDetailRsp>
{

	public string GetMethod() { return "buyin.instGmvDetail"; }

	public string GetUrl() { return "/buyin/instGmvDetail"; }

	[JsonPropertyName("date")]
	[Description("日期（只支持查询[t-60,t-2]的 GMV）")]
	[NotNull]
	public string Date { get; set; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	public long? ProductId { get; set; }

	[JsonPropertyName("size")]
	[Description("每页数据条数（最大100，不传默认100）")]
	public long? Size { get; set; }

	[JsonPropertyName("page")]
	[Description("页码（不传默认为1）")]
	public long? Page { get; set; }

	[JsonPropertyName("search_type")]
	[Description("查询粒度（1-查询当前应用，2-查询应用所属工具服务商，不包括抖音应用选品GMV数据）")]
	public long? SearchType { get; set; }
}

[Description("获取机构某天的选品GMV明细，不包括抖音应用选品GMV数据")]
public class BuyinInstGmvDetailRsp
{
	[JsonPropertyName("details")]
	[Description("GMV 明细")]
	public List<DetailsItem> Details { get; set; }

	public class DetailsItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("gmv")]
		[Description("GMV（单位：分）")]
		public long Gmv { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("明细总数")]
	public long Total { get; set; }
}
