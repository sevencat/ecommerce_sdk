namespace ecommerce.sdk.douyin;

[Description("本接口可以查询商家和物流商的订购关系以及物流单号使用情况")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","4006:店铺ID非法","isv.business-failed:4006","请检查您的店铺id是否正确")]
public class LogisticsListShopNetsiteReq : IDouyinReq<LogisticsListShopNetsiteRsp>
{

	public string GetMethod() { return "logistics.listShopNetsite"; }

	public string GetUrl() { return "/logistics/listShopNetsite"; }

	[JsonPropertyName("logistics_code")]
	[Description("物流服务商编码（想获取全量物流，则传空字符串）")]
	[NotNull]
	public string LogisticsCode { get; set; }
}

[Description("本接口可以查询商家和物流商的订购关系以及物流单号使用情况")]
public class LogisticsListShopNetsiteRsp
{
	[JsonPropertyName("netsites")]
	[Description("商家已开通的网点列表信息")]
	public List<NetsitesItem> Netsites { get; set; }

	public class NetsitesItem
	{
		[JsonPropertyName("netsite_code")]
		[Description("网点Code")]
		public string NetsiteCode { get; set; }

		[JsonPropertyName("netsite_name")]
		[Description("网点名称")]
		public string NetsiteName { get; set; }

		[JsonPropertyName("amount")]
		[Description("电子面单余额数量")]
		public string Amount { get; set; }

		[JsonPropertyName("sender_address")]
		[Description("寄件人地址")]
		public List<SenderAddressItem> SenderAddress { get; set; }

		public class SenderAddressItem
		{
			[JsonPropertyName("province_name")]
			[Description("省名称")]
			public string ProvinceName { get; set; }

			[JsonPropertyName("city_name")]
			[Description("市名称")]
			public string CityName { get; set; }

			[JsonPropertyName("district_name")]
			[Description("区/县名称")]
			public string DistrictName { get; set; }

			[JsonPropertyName("street_name")]
			[Description("街道名称")]
			public string StreetName { get; set; }

			[JsonPropertyName("detail_address")]
			[Description("剩余详细地址")]
			public string DetailAddress { get; set; }
		}

		[JsonPropertyName("allocated_quantity")]
		[Description("已取单号数量，若业务本身无值，则传-1，前端可展示为“-”")]
		public long AllocatedQuantity { get; set; }

		[JsonPropertyName("cancelled_quantity")]
		[Description("已取消单号数量，若业务本身无值，则传-1，前端可展示为“-”")]
		public long CancelledQuantity { get; set; }

		[JsonPropertyName("recycled_quantity")]
		[Description("已回收单号数量，若业务本身无值，则传-1，前端可展示为“-”")]
		public long RecycledQuantity { get; set; }

		[JsonPropertyName("company")]
		[Description("快递公司编码")]
		public string Company { get; set; }

		[JsonPropertyName("company_type")]
		[Description("物流服务商业务类型 1：直营  2：加盟 3：落地配 4：直营带网点")]
		public short CompanyType { get; set; }
	}

	[JsonPropertyName("logistics_code")]
	[Description("快递公司编码")]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("company_type")]
	[Description("物流服务商业务类型 1：直营  2：加盟 3：落地配 4：直营带网点")]
	public short CompanyType { get; set; }
}
