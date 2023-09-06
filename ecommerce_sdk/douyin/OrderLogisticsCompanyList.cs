namespace ecommerce.sdk.douyin;

[Description("获取快递公司列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","未知错误，请重试","isp.service-error:60019","请重试请求")]
[DouyinRetCode(50002,"业务处理失败","错误信息不固定，根据下游返回的信息提示做处理","isv.business-failed:60124","根据下游返回的错误信息做处理")]
public class OrderLogisticsCompanyListReq : IDouyinReq<OrderLogisticsCompanyListRsp>
{

	public string GetMethod() { return "order.logisticsCompanyList"; }

	public string GetUrl() { return "/order/logisticsCompanyList"; }

}

[Description("获取快递公司列表")]
public class OrderLogisticsCompanyListRsp
{
	[JsonPropertyName("data")]
	[Description("物流公司信息")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("id")]
		[Description("物流公司id")]
		public long Id { get; set; }

		[JsonPropertyName("name")]
		[Description("物流公司名字")]
		public string Name { get; set; }

		[JsonPropertyName("code")]
		[Description("物流公司code")]
		public string Code { get; set; }
	}
}
