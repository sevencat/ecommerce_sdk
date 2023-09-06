namespace ecommerce.sdk.douyin;

[Description("获取四级地址全量省份信息,物流发货获取省份列表")]
public class AddressGetProvinceReq : IDouyinReq<AddressGetProvinceRsp>
{

	public string GetMethod() { return "address.getProvince"; }

	public string GetUrl() { return "/address/getProvince"; }

}

[Description("获取四级地址全量省份信息,物流发货获取省份列表")]
public class AddressGetProvinceRsp
{
	[JsonPropertyName("data")]
	[Description("data")]
	public List<DataItem> Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("province_id")]
		[Description("省份id")]
		public long ProvinceId { get; set; }

		[JsonPropertyName("province")]
		[Description("省份")]
		public string Province { get; set; }
	}
}
