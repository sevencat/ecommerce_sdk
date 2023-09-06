namespace ecommerce.sdk.douyin;

[Description("面单明文信息查询接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","10014:运单号不存在","isv.business-failed:10014","-")]
[DouyinRetCode(50002,"业务处理失败","11704：当前用户单日明文查询量已耗尽，请联系平台运营处理","isv.business-failed:11704","-")]
[DouyinRetCode(50002,"业务处理失败","11703：当日明文查询量已耗尽，请联系平台物流运营护理","isv.business-failed:11703","-")]
[DouyinRetCode(50002,"业务处理失败","4006:waybillCode不能为空","isv.business-failed:4006","请检查waybillCode入参")]
public class LogisticsEbillInfoGetReq : IDouyinReq<LogisticsEbillInfoGetRsp>
{

	public string GetMethod() { return "logistics.ebillInfoGet"; }

	public string GetUrl() { return "/logistics/ebillInfoGet"; }

	[JsonPropertyName("waybill_code")]
	[Description("电子面单号")]
	[NotNull]
	public string WaybillCode { get; set; }

	[JsonPropertyName("company")]
	[Description("物流公司编码")]
	public string Company { get; set; }

	[JsonPropertyName("user_type")]
	[Description("请求用户类型，1-系统；2-业务员（快递员）；3-客服；4-总部业务人员；5-网点业务人员")]
	[NotNull]
	public int? UserType { get; set; }

	[JsonPropertyName("system_source")]
	[Description("系统来源，根据物流公司内部系统的代号传值，比如CRM系统，网点操作系统、小件员APP等，区分系统唯一性")]
	[NotNull]
	public string SystemSource { get; set; }

	[JsonPropertyName("query_reason")]
	[Description("查询原因，根据实际用户查询的情况传值，如派件员联系收件人；处理客诉问题等")]
	[NotNull]
	public string QueryReason { get; set; }

	[JsonPropertyName("ip_address")]
	[Description("IP地址，调用该接口数据的用户的IP地址")]
	public string IpAddress { get; set; }

	[JsonPropertyName("user_id")]
	[Description("若userType≠1时，则必须传入具体用户的系统ID，可以结合systemSource中的系统的用户ID")]
	public string UserId { get; set; }

	[JsonPropertyName("net_code")]
	[Description("查询用户的所属机构编码")]
	public string NetCode { get; set; }

	[JsonPropertyName("net_name")]
	[Description("查询用户的所属机构名称")]
	public string NetName { get; set; }
}

[Description("面单明文信息查询接口")]
public class LogisticsEbillInfoGetRsp
{
	[JsonPropertyName("data")]
	[Description("-")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("order_id")]
		[Description("-")]
		public string OrderId { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("-")]
		public string ShopId { get; set; }

		[JsonPropertyName("waybill_code")]
		[Description("-")]
		public string WaybillCode { get; set; }

		[JsonPropertyName("sender")]
		[Description("-")]
		public SenderItem Sender { get; set; }

		public class SenderItem
		{
			[JsonPropertyName("contact")]
			[Description("-")]
			public ContactItem Contact { get; set; }

			public class ContactItem
			{
				[JsonPropertyName("name")]
				[Description("-")]
				public string Name { get; set; }

				[JsonPropertyName("phone")]
				[Description("-")]
				public string Phone { get; set; }

				[JsonPropertyName("mobile")]
				[Description("-")]
				public string Mobile { get; set; }

				[JsonPropertyName("email")]
				[Description("-")]
				public string Email { get; set; }
			}

			[JsonPropertyName("address")]
			[Description("-")]
			public AddressItem Address { get; set; }

			public class AddressItem
			{
				[JsonPropertyName("country_code")]
				[Description("-")]
				public string CountryCode { get; set; }

				[JsonPropertyName("province_code")]
				[Description("-")]
				public string ProvinceCode { get; set; }

				[JsonPropertyName("province_name")]
				[Description("-")]
				public string ProvinceName { get; set; }

				[JsonPropertyName("city_code")]
				[Description("-")]
				public string CityCode { get; set; }

				[JsonPropertyName("city_name")]
				[Description("-")]
				public string CityName { get; set; }

				[JsonPropertyName("district_code")]
				[Description("-")]
				public string DistrictCode { get; set; }

				[JsonPropertyName("district_name")]
				[Description("-")]
				public string DistrictName { get; set; }

				[JsonPropertyName("street_code")]
				[Description("-")]
				public string StreetCode { get; set; }

				[JsonPropertyName("street_name")]
				[Description("-")]
				public string StreetName { get; set; }

				[JsonPropertyName("detail_address")]
				[Description("-")]
				public string DetailAddress { get; set; }

				[JsonPropertyName("address_id")]
				[Description("-")]
				public long AddressId { get; set; }
			}
		}

		[JsonPropertyName("receiver")]
		[Description("-")]
		public ReceiverItem Receiver { get; set; }

		public class ReceiverItem
		{
			[JsonPropertyName("contact")]
			[Description("-")]
			public ContactItem Contact { get; set; }

			public class ContactItem
			{
				[JsonPropertyName("virtualMobile")]
				[Description("虚拟号，手机号脱敏后会返回")]
				public string VirtualMobile { get; set; }

				[JsonPropertyName("mobileId")]
				[Description("每个手机号对应的唯一ID")]
				public string MobileId { get; set; }

				[JsonPropertyName("name")]
				[Description("-")]
				public string Name { get; set; }

				[JsonPropertyName("phone")]
				[Description("-")]
				public string Phone { get; set; }

				[JsonPropertyName("mobile")]
				[Description("-")]
				public string Mobile { get; set; }

				[JsonPropertyName("email")]
				[Description("-")]
				public string Email { get; set; }
			}

			[JsonPropertyName("address")]
			[Description("-")]
			public AddressItem Address { get; set; }

			public class AddressItem
			{
				[JsonPropertyName("country_code")]
				[Description("-")]
				public string CountryCode { get; set; }

				[JsonPropertyName("province_code")]
				[Description("-")]
				public string ProvinceCode { get; set; }

				[JsonPropertyName("province_name")]
				[Description("-")]
				public string ProvinceName { get; set; }

				[JsonPropertyName("city_code")]
				[Description("-")]
				public string CityCode { get; set; }

				[JsonPropertyName("city_name")]
				[Description("-")]
				public string CityName { get; set; }

				[JsonPropertyName("district_code")]
				[Description("-")]
				public string DistrictCode { get; set; }

				[JsonPropertyName("district_name")]
				[Description("-")]
				public string DistrictName { get; set; }

				[JsonPropertyName("street_code")]
				[Description("-")]
				public string StreetCode { get; set; }

				[JsonPropertyName("street_name")]
				[Description("-")]
				public string StreetName { get; set; }

				[JsonPropertyName("detail_address")]
				[Description("-")]
				public string DetailAddress { get; set; }

				[JsonPropertyName("address_id")]
				[Description("-")]
				public long AddressId { get; set; }
			}
		}

		[JsonPropertyName("cargo_list")]
		[Description("-")]
		public List<CargoListItem> CargoList { get; set; }

		public class CargoListItem
		{
			[JsonPropertyName("name")]
			[Description("-")]
			public string Name { get; set; }

			[JsonPropertyName("quantity")]
			[Description("-")]
			public int Quantity { get; set; }

			[JsonPropertyName("volume")]
			[Description("-")]
			public int Volume { get; set; }

			[JsonPropertyName("total_weight")]
			[Description("-")]
			public int TotalWeight { get; set; }

			[JsonPropertyName("total_net_weight")]
			[Description("-")]
			public int TotalNetWeight { get; set; }

			[JsonPropertyName("unit")]
			[Description("-")]
			public string Unit { get; set; }
		}

		[JsonPropertyName("net_info")]
		[Description("-")]
		public NetInfoItem NetInfo { get; set; }

		public class NetInfoItem
		{
			[JsonPropertyName("category")]
			[Description("-")]
			public string Category { get; set; }

			[JsonPropertyName("net_code")]
			[Description("-")]
			public string NetCode { get; set; }

			[JsonPropertyName("monthly_account")]
			[Description("-")]
			public string MonthlyAccount { get; set; }

			[JsonPropertyName("secret_key")]
			[Description("-")]
			public string SecretKey { get; set; }

			[JsonPropertyName("verification_code")]
			[Description("-")]
			public string VerificationCode { get; set; }
		}

		[JsonPropertyName("service_list")]
		[Description("-")]
		public List<ServiceListItem> ServiceList { get; set; }

		public class ServiceListItem
		{
			[JsonPropertyName("service_code")]
			[Description("-")]
			public string ServiceCode { get; set; }

			[JsonPropertyName("service_value")]
			[Description("-")]
			public string ServiceValue { get; set; }
		}

		[JsonPropertyName("product_type")]
		[Description("-")]
		public string ProductType { get; set; }

		[JsonPropertyName("pod_model_address")]
		[Description("-")]
		public PodModelAddressItem PodModelAddress { get; set; }

		public class PodModelAddressItem
		{
			[JsonPropertyName("country_code")]
			[Description("-")]
			public string CountryCode { get; set; }

			[JsonPropertyName("province_code")]
			[Description("-")]
			public string ProvinceCode { get; set; }

			[JsonPropertyName("province_name")]
			[Description("-")]
			public string ProvinceName { get; set; }

			[JsonPropertyName("city_code")]
			[Description("-")]
			public string CityCode { get; set; }

			[JsonPropertyName("city_name")]
			[Description("-")]
			public string CityName { get; set; }

			[JsonPropertyName("district_code")]
			[Description("-")]
			public string DistrictCode { get; set; }

			[JsonPropertyName("district_name")]
			[Description("-")]
			public string DistrictName { get; set; }

			[JsonPropertyName("street_code")]
			[Description("-")]
			public string StreetCode { get; set; }

			[JsonPropertyName("street_name")]
			[Description("-")]
			public string StreetName { get; set; }

			[JsonPropertyName("detail_address")]
			[Description("-")]
			public string DetailAddress { get; set; }

			[JsonPropertyName("address_id")]
			[Description("-")]
			public long AddressId { get; set; }
		}

		[JsonPropertyName("sender_fetch_time")]
		[Description("要求上门取件开始时间，YYYY-MM-DD HH24:MM:SS")]
		public string SenderFetchTime { get; set; }

		[JsonPropertyName("has_freight_insurance")]
		[Description("0:没有运费险 1:有运费险 (仅用于逆向场景)")]
		public int HasFreightInsurance { get; set; }

		[JsonPropertyName("logistics_reverse_flag")]
		[Description("0:正向物流场景 1:逆向物流场景")]
		public int LogisticsReverseFlag { get; set; }

		[JsonPropertyName("is_sign_back")]
		[Description("是否返回签回单（签单返还）的运单号，支持以下值：1：要求 0：不要求")]
		public int IsSignBack { get; set; }

		[JsonPropertyName("pay_method")]
		[Description("支付方式（1-寄付月结，2-寄付现结，3-到付）暂时无需传值。若不传，默认取商家与物流商网点约定的结算方式")]
		public int PayMethod { get; set; }

		[JsonPropertyName("remark")]
		[Description("-")]
		public string Remark { get; set; }

		[JsonPropertyName("extra")]
		[Description("-")]
		public string Extra { get; set; }

		[JsonPropertyName("pay_amount")]
		[Description("到付运费金额，单位为分")]
		public long PayAmount { get; set; }

		[JsonPropertyName("biz_info")]
		[Description("业务信息")]
		public BizInfoItem BizInfo { get; set; }

		public class BizInfoItem
		{
			[JsonPropertyName("biz_type")]
			[Description("-")]
			public int BizType { get; set; }

			[JsonPropertyName("biz_name")]
			[Description("-")]
			public string BizName { get; set; }
		}

		[JsonPropertyName("e_bill_id")]
		[Description("订购关系id")]
		public long EBillId { get; set; }

		[JsonPropertyName("warehouse")]
		[Description("仓相关信息")]
		public WarehouseItem Warehouse { get; set; }

		public class WarehouseItem
		{
			[JsonPropertyName("wh_code")]
			[Description("-")]
			public string WhCode { get; set; }

			[JsonPropertyName("is_sumup")]
			[Description("-")]
			public bool IsSumup { get; set; }

			[JsonPropertyName("delivery_type")]
			[Description("-")]
			public string DeliveryType { get; set; }

			[JsonPropertyName("wh_order_no")]
			[Description("-")]
			public string WhOrderNo { get; set; }
		}

		[JsonPropertyName("user_id")]
		[Description("单号使用用户ID")]
		public string UserId { get; set; }

		[JsonPropertyName("delivery_req")]
		[Description("-")]
		public DeliveryReqItem DeliveryReq { get; set; }

		public class DeliveryReqItem
		{
			[JsonPropertyName("is_center_delivery")]
			[Description("-")]
			public bool IsCenterDelivery { get; set; }

			[JsonPropertyName("is_pickup_self")]
			[Description("-")]
			public bool IsPickupSelf { get; set; }
		}

		[JsonPropertyName("total_pack_count")]
		[Description("包裹总数（包括母单和子单），用于子母件场景传入包裹数量，不能传0,传1认为是只有一单非子母单")]
		public int TotalPackCount { get; set; }

		[JsonPropertyName("is_cancelled")]
		[Description("0-有效 1-无效（已取消）")]
		public int IsCancelled { get; set; }

		[JsonPropertyName("segment_code")]
		[Description("面单编码规则（若有多个号段时需传入）")]
		public string SegmentCode { get; set; }

		[JsonPropertyName("version")]
		[Description("面单版本号")]
		public long Version { get; set; }

		[JsonPropertyName("first_sort_code")]
		[Description("一段码")]
		public string FirstSortCode { get; set; }

		[JsonPropertyName("second_sort_code")]
		[Description("二段码")]
		public string SecondSortCode { get; set; }

		[JsonPropertyName("third_sort_code")]
		[Description("三段码")]
		public string ThirdSortCode { get; set; }

		[JsonPropertyName("fourth_sort_code")]
		[Description("四段码")]
		public string FourthSortCode { get; set; }

		[JsonPropertyName("package_code")]
		[Description("集包地编码")]
		public string PackageCode { get; set; }

		[JsonPropertyName("mark_destination_code")]
		[Description("大头笔编码")]
		public string MarkDestinationCode { get; set; }

		[JsonPropertyName("mark_destination_code_name")]
		[Description("大头笔名称")]
		public string MarkDestinationCodeName { get; set; }

		[JsonPropertyName("create_time")]
		[Description("-")]
		public string CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间（包含更新和取消操作的时间）")]
		public string UpdateTime { get; set; }

		[JsonPropertyName("package_name")]
		[Description("集包地名称")]
		public string PackageName { get; set; }
	}
}
