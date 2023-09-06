namespace ecommerce.sdk.douyin;

[Description("可以前置查询接口，查询地址快递是否可以送达,调用路径：ISV/商家erp—>字节；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","请求物流服务商超时","isp.service-error:4009","可等待一段时间进行重试")]
[DouyinRetCode(50002,"业务处理失败","内部数据格式非法","isv.business-failed:4008","可等待一段时间进行重试")]
[DouyinRetCode(20000,"系统错误","请求物流服务商异常，请重试","isp.service-error:4007","可等待一段时间进行重试")]
[DouyinRetCode(40004,"非法的参数","youzhengguonei 物流服务商不支持该接口","isv.parameter-invalid:4006","以文档上面支持的为准")]
[DouyinRetCode(50002,"业务处理失败","500:发生异常，请咨询对接人","isv.business-failed:500","无")]
[DouyinRetCode(50002,"业务处理失败","10002:服务异常～","isv.business-failed:10002","无")]
[DouyinRetCode(50002,"业务处理失败","3017:筛单异常","isv.business-failed:3017","无")]
[DouyinRetCode(50002,"业务处理失败","1000:request param [receiverAddress.detailAddress] can not be null","isv.business-failed:1000","1000:request param [receiverAddress.detailAddress] can not be null")]
[DouyinRetCode(50002,"业务处理失败","9020501:请求失败，请重试","isv.business-failed:9020501","请重试")]
[DouyinRetCode(50002,"业务处理失败","4001:系统发生数据错误或运行时异常","isv.business-failed:4001","统发生数据错误或运行时异常")]
[DouyinRetCode(50002,"业务处理失败","10001:无效签名","isv.business-failed:10001","无效签名")]
[DouyinRetCode(50002,"业务处理失败","11102:收件地址解析失败","isv.business-failed:11102","请检查收件地址信息")]
[DouyinRetCode(50002,"业务处理失败","11108:{outRangeRsason:该收件地址属于偏远地区暂时无法下单。,isOutRange:true}","isv.business-failed:11108","请调整地址")]
public class LogisticsGetOutRangeReq : IDouyinReq<LogisticsGetOutRangeRsp>
{

	public string GetMethod() { return "logistics.getOutRange"; }

	public string GetUrl() { return "/logistics/getOutRange"; }

	[JsonPropertyName("logistics_code")]
	[Description("快递公司编码")]
	[NotNull]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("sender_address")]
	[Description("发货地址")]
	public SenderAddressItem SenderAddress { get; set; }

	public class SenderAddressItem
	{
		[JsonPropertyName("country_code")]
		[Description("CHN")]
		[NotNull]
		public string CountryCode { get; set; }

		[JsonPropertyName("province_name")]
		[Description("省份名称")]
		[NotNull]
		public string ProvinceName { get; set; }

		[JsonPropertyName("city_name")]
		[Description("城市名称")]
		[NotNull]
		public string CityName { get; set; }

		[JsonPropertyName("district_name")]
		[Description("区名称")]
		[NotNull]
		public string DistrictName { get; set; }

		[JsonPropertyName("street_name")]
		[Description("街道名称")]
		public string StreetName { get; set; }

		[JsonPropertyName("detail_address")]
		[Description("详细地址")]
		[NotNull]
		public string DetailAddress { get; set; }
	}

	[JsonPropertyName("receiver_address")]
	[Description("收件地址")]
	public ReceiverAddressItem ReceiverAddress { get; set; }

	public class ReceiverAddressItem
	{
		[JsonPropertyName("country_code")]
		[Description("CHN")]
		[NotNull]
		public string CountryCode { get; set; }

		[JsonPropertyName("province_name")]
		[Description("省份名称")]
		[NotNull]
		public string ProvinceName { get; set; }

		[JsonPropertyName("city_name")]
		[Description("城市名称")]
		[NotNull]
		public string CityName { get; set; }

		[JsonPropertyName("district_name")]
		[Description("区名称")]
		[NotNull]
		public string DistrictName { get; set; }

		[JsonPropertyName("street_name")]
		[Description("街道名称")]
		public string StreetName { get; set; }

		[JsonPropertyName("detail_address")]
		[Description("详细地址，支持密文")]
		[NotNull]
		public string DetailAddress { get; set; }
	}

	[JsonPropertyName("type")]
	[Description("类型（0-揽派合一；1-揽收区域；2-派送区域） 0：取senderAddress, receiverAddress值 1：取senderAddress值 2：取receiverAddress值")]
	[NotNull]
	public short? Type { get; set; }

	[JsonPropertyName("service_list")]
	[Description("增值服务 目前只支持德邦")]
	public List<ServiceListItem> ServiceList { get; set; }

	public class ServiceListItem
	{
		[JsonPropertyName("service_code")]
		[Description("code")]
		public string ServiceCode { get; set; }

		[JsonPropertyName("service_value")]
		[Description("value")]
		public string ServiceValue { get; set; }
	}

	[JsonPropertyName("product_type")]
	[Description("产品类型 目前只支持德邦")]
	public string ProductType { get; set; }

	[JsonPropertyName("delivery_req")]
	[Description("投递要求 目前只支持德邦")]
	public DeliveryReqItem DeliveryReq { get; set; }

	public class DeliveryReqItem
	{
		[JsonPropertyName("is_center_delivery")]
		[Description("是否接受仅镇中心派送  目前仅支持德邦")]
		public bool? IsCenterDelivery { get; set; }

		[JsonPropertyName("is_pickup_self")]
		[Description("是否接受合伙人自提，目前仅支持德邦")]
		public bool? IsPickupSelf { get; set; }
	}
}

[Description("可以前置查询接口，查询地址快递是否可以送达,调用路径：ISV/商家erp—>字节；")]
public class LogisticsGetOutRangeRsp
{
	[JsonPropertyName("is_out_range")]
	[Description("是否超区响应结果（超区-true；未超区-fasle）")]
	public bool IsOutRange { get; set; }

	[JsonPropertyName("out_range_reason")]
	[Description("超区原因，1、疫情管控 2、洪涝台风等自然灾害 3、特殊会议管控 4、网点经营问题 5、其他原因")]
	public string OutRangeReason { get; set; }
}
