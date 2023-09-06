namespace ecommerce.sdk.douyin;

[Description("供货单的供应商发货接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:2000","请参考错误信息，或联系对接人员")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:1000","请稍后再试，或联系对接人员")]
[DouyinRetCode(40004,"非法的参数","非法参数请求","isv.parameter-invalid:1020","请参考错误信息，或联系对接人员")]
public class SupplyChainSupplyConsignReq : IDouyinReq<SupplyChainSupplyConsignRsp>
{

	public string GetMethod() { return "supplyChain.supplyConsign"; }

	public string GetUrl() { return "/supplyChain/supplyConsign"; }

	[JsonPropertyName("order_no")]
	[Description("供货单号")]
	[NotNull]
	public string OrderNo { get; set; }

	[JsonPropertyName("tms_code")]
	[Description("快递商编码，使用package_list进行多包裹发货时，该字段传")]
	[NotNull]
	public string TmsCode { get; set; }

	[JsonPropertyName("tracking_no")]
	[Description("快递单号,使用package_list进行多包裹发货时，该字段传")]
	[NotNull]
	public string TrackingNo { get; set; }

	[JsonPropertyName("sender_addr")]
	[Description("发货人地址结构")]
	public SenderAddrItem SenderAddr { get; set; }

	public class SenderAddrItem
	{
		[JsonPropertyName("province_name")]
		[Description("省名称")]
		[NotNull]
		public string ProvinceName { get; set; }

		[JsonPropertyName("city_name")]
		[Description("市名称")]
		[NotNull]
		public string CityName { get; set; }

		[JsonPropertyName("district_name")]
		[Description("区名称")]
		[NotNull]
		public string DistrictName { get; set; }

		[JsonPropertyName("street_name")]
		[Description("街道名称，没有则填空字符")]
		public string StreetName { get; set; }

		[JsonPropertyName("addr_detail")]
		[Description("剩余详细地址")]
		[NotNull]
		public string AddrDetail { get; set; }
	}

	[JsonPropertyName("sender_name")]
	[Description("发货人姓名")]
	public string SenderName { get; set; }

	[JsonPropertyName("sender_tel")]
	[Description("发货人联系电话")]
	public string SenderTel { get; set; }

	[JsonPropertyName("package_list")]
	[Description("包裹列表，用于拆包发货")]
	public List<PackageListItem> PackageList { get; set; }

	public class PackageListItem
	{
		[JsonPropertyName("tms_code")]
		[Description("快递商编码")]
		[NotNull]
		public string TmsCode { get; set; }

		[JsonPropertyName("ship_cnt")]
		[Description("发货数量")]
		[NotNull]
		public int? ShipCnt { get; set; }

		[JsonPropertyName("track_no")]
		[Description("快递单号")]
		[NotNull]
		public string TrackNo { get; set; }
	}
}

[Description("供货单的供应商发货接口")]
public class SupplyChainSupplyConsignRsp
{
	[JsonPropertyName("success")]
	[Description("true=发货成功")]
	public bool Success { get; set; }
}
