namespace ecommerce.sdk.douyin;

[Description("编辑门店")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","8:门店不存在","isv.business-failed:8","请检查门店id")]
[DouyinRetCode(50002,"业务处理失败","9:已有审核中的记录","isv.business-failed:9","请等待当前审核记录审核完成")]
public class ShopEditStoreReq : IDouyinReq<ShopEditStoreRsp>
{

	public string GetMethod() { return "shop.editStore"; }

	public string GetUrl() { return "/shop/editStore"; }

	[JsonPropertyName("store_id")]
	[Description("门店ID")]
	[NotNull]
	public long? StoreId { get; set; }

	[JsonPropertyName("name")]
	[Description("门店名")]
	public string Name { get; set; }

	[JsonPropertyName("store_code")]
	[Description("自用编码")]
	public string StoreCode { get; set; }

	[JsonPropertyName("longitude")]
	[Description("经度")]
	public string Longitude { get; set; }

	[JsonPropertyName("latitude")]
	[Description("纬度")]
	public string Latitude { get; set; }

	[JsonPropertyName("province")]
	[Description("省")]
	public string Province { get; set; }

	[JsonPropertyName("city")]
	[Description("市")]
	public string City { get; set; }

	[JsonPropertyName("district")]
	[Description("区")]
	public string District { get; set; }

	[JsonPropertyName("address")]
	[Description("详细地址")]
	public string Address { get; set; }

	[JsonPropertyName("contact")]
	[Description("电话")]
	public string Contact { get; set; }

	[JsonPropertyName("open_time")]
	[Description("营业时间")]
	public OpenTimeItem OpenTime { get; set; }

	public class OpenTimeItem
	{
		[JsonPropertyName("day_map")]
		[Description("营业时间")]
		[NotNull]
		public Dictionary<long,string> DayMap { get; set; }
	}
}

[Description("编辑门店")]
public class ShopEditStoreRsp
{
}
