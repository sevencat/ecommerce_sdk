namespace ecommerce.sdk.douyin;

[Description("面单信息更新接口，更新收件人信息 以及发件人名字联系方式信息，支持顺丰速递更新面单信息（支持顺丰速递更新重量体积）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","ERROR:该订单对应的运单号3180425096642已经有物流信息,不能进行修改","isv.parameter-invalid:10912","有轨迹无法更新")]
[DouyinRetCode(40004,"非法的参数","运单号不存在","isv.parameter-invalid:10911","参数错误")]
[DouyinRetCode(40004,"非法的参数","订单已取件，不允许变更","isv.parameter-invalid:10902","无法更新")]
[DouyinRetCode(40004,"非法的参数","订单已取消，不允许变更","isv.parameter-invalid:10901","无法更新")]
[DouyinRetCode(40004,"非法的参数","运单号不存在","isv.parameter-invalid:10724","输入正确的运单号")]
[DouyinRetCode(40004,"非法的参数","物流服务不支持派送","isv.parameter-invalid:10704","无")]
[DouyinRetCode(40004,"非法的参数","电子面单号不存在","isv.parameter-invalid:10014","无")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:10000","无")]
[DouyinRetCode(40004,"非法的参数","订单已确认","isv.parameter-invalid:8252","无")]
[DouyinRetCode(40004,"非法的参数","fengwang物流服务商不支持该接口","isv.parameter-invalid:5001","无")]
[DouyinRetCode(40004,"非法的参数","该物流商不允许更新 Weight、Volume 字段","isv.parameter-invalid:4023","无")]
[DouyinRetCode(40004,"非法的参数","邮政和ems接口暂时不支持除了Weight、Volume之外的字段","isv.parameter-invalid:4006","无")]
[DouyinRetCode(40004,"非法的参数","使用该产品需签订指定专属协议","isv.parameter-invalid:4001","无")]
[DouyinRetCode(50002,"业务处理失败","未获取到网点数据","isv.business-failed:20045","无")]
[DouyinRetCode(50002,"业务处理失败","筛单不可到:其它原因","isv.business-failed:20019","无")]
[DouyinRetCode(50002,"业务处理失败","账户余额不足","isv.business-failed:10701","无")]
[DouyinRetCode(50002,"业务处理失败","请求物流服务商超时","isv.business-failed:4009","无")]
[DouyinRetCode(50002,"业务处理失败","请求内部服务超时，请重试","isv.business-failed:4007","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","11204:调用路由信息查询接口异常","isv.business-failed:11204","无")]
[DouyinRetCode(50002,"业务处理失败","4010:数据库查询失败","isv.business-failed:4010","无")]
[DouyinRetCode(50002,"业务处理失败","20043:网点获取超时,请稍后重试","isv.business-failed:20043","无")]
[DouyinRetCode(50002,"业务处理失败","14081:服务不可达","isv.business-failed:14081","无")]
[DouyinRetCode(50002,"业务处理失败","8177:1:尊敬的客户您好！受目的地疫情影响，暂时无法提供收派服务，带来不便请您理解。(BPS：0125000)","isv.business-failed:8177","无")]
[DouyinRetCode(50002,"业务处理失败","8092:到方电话或手机不合法","isv.business-failed:8092","无")]
[DouyinRetCode(50002,"业务处理失败","10913:末端服务不可达","isv.business-failed:10913","无")]
[DouyinRetCode(50002,"业务处理失败","10802:外部订单号:141209-279021|279021_1|43|54订单已经揽收或上传无法修改","isv.business-failed:10802","无")]
[DouyinRetCode(50002,"业务处理失败","10907:60：订单状态不在可允许修改配置项内","isv.business-failed:10907","无")]
[DouyinRetCode(50002,"业务处理失败","817703:1:尊敬的客户，您好！因当前流向件量激增，为更好地保障您的寄件体验，暂不提供此产品寄递服务，您可选择其他产品寄递，带来不便请您理解。","isv.business-failed:817703","请选择其他产品寄递")]
[DouyinRetCode(50002,"业务处理失败","4008:内部数据JSON/XML格式非法   !","isv.business-failed:4008","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","817702:1:尊敬的客户，您好！受目的地疫情影响，暂不提供寄递服务，带来不便请您理解。(BPS:125000)","isv.business-failed:817702","受目的地疫情影响，暂不提供寄递服务")]
[DouyinRetCode(50002,"业务处理失败","15000:系统繁忙，请稍后重试","isv.business-failed:15000","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","10719:内部处理超时，请重试","isv.business-failed:10719","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","817701:1:尊敬的客户，您好！受寄件地疫情影响，暂时无法提供此产品寄递服务，带来不便请您理解。(BPS3562)","isv.business-failed:817701","无")]
[DouyinRetCode(50002,"业务处理失败","200101:订单已揽收或已完成，不支持修改订单","isv.business-failed:200101","无")]
[DouyinRetCode(50002,"业务处理失败","10903:订单号不存在","isv.business-failed:10903","提工单")]
public class LogisticsUpdateOrderReq : IDouyinReq<LogisticsUpdateOrderRsp>
{

	public string GetMethod() { return "logistics.updateOrder"; }

	public string GetUrl() { return "/logistics/updateOrder"; }

	[JsonPropertyName("sender_info")]
	[Description("寄件人信息")]
	public SenderInfoItem SenderInfo { get; set; }

	public class SenderInfoItem
	{
		[JsonPropertyName("contact")]
		[Description("寄件人联系信息")]
		public ContactItem Contact { get; set; }

		public class ContactItem
		{
			[JsonPropertyName("name")]
			[Description("寄件人姓名")]
			public string Name { get; set; }

			[JsonPropertyName("phone")]
			[Description("寄件人固话（和mobile二选一）")]
			public string Phone { get; set; }

			[JsonPropertyName("mobile")]
			[Description("寄件人移动电话（和phone二选一）")]
			public string Mobile { get; set; }
		}
	}

	[JsonPropertyName("receiver_info")]
	[Description("收件人信息")]
	public ReceiverInfoItem ReceiverInfo { get; set; }

	public class ReceiverInfoItem
	{
		[JsonPropertyName("address")]
		[Description("收件人地址信息")]
		[NotNull]
		public AddressItem Address { get; set; }

		public class AddressItem
		{
			[JsonPropertyName("country_code")]
			[Description("国家编码（默认CHN，目前只有国内业务）")]
			[NotNull]
			public string CountryCode { get; set; }

			[JsonPropertyName("province_name")]
			[Description("省名称")]
			[NotNull]
			public string ProvinceName { get; set; }

			[JsonPropertyName("city_name")]
			[Description("市名称")]
			[NotNull]
			public string CityName { get; set; }

			[JsonPropertyName("district_name")]
			[Description("区/县名称")]
			[NotNull]
			public string DistrictName { get; set; }

			[JsonPropertyName("street_name")]
			[Description("街道名称。街道名称（street_name）和街道code（street_code），若传入时，需要一起传入。")]
			public string StreetName { get; set; }

			[JsonPropertyName("detail_address")]
			[Description("剩余详细地址，支持密文")]
			public string DetailAddress { get; set; }

			[JsonPropertyName("province_code")]
			[Description("省code编码")]
			public string ProvinceCode { get; set; }

			[JsonPropertyName("city_code")]
			[Description("市code编码")]
			public string CityCode { get; set; }

			[JsonPropertyName("district_code")]
			[Description("区code编码")]
			public string DistrictCode { get; set; }

			[JsonPropertyName("street_code")]
			[Description("街道code编码")]
			public string StreetCode { get; set; }
		}

		[JsonPropertyName("contact")]
		[Description("收件人联系信息")]
		[NotNull]
		public ContactItem Contact { get; set; }

		public class ContactItem
		{
			[JsonPropertyName("name")]
			[Description("收件人姓名，支持密文")]
			public string Name { get; set; }

			[JsonPropertyName("phone")]
			[Description("收件人固话（和mobile二选一）")]
			public string Phone { get; set; }

			[JsonPropertyName("mobile")]
			[Description("收件人移动电话（和phone二选一），支持密文")]
			public string Mobile { get; set; }
		}
	}

	[JsonPropertyName("logistics_code")]
	[Description("物流服务商编码")]
	[NotNull]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("track_no")]
	[Description("运单号")]
	[NotNull]
	public string TrackNo { get; set; }

	[JsonPropertyName("items")]
	[Description("商品明细列表")]
	public List<ItemsItem> Items { get; set; }

	public class ItemsItem
	{
		[JsonPropertyName("item_name")]
		[Description("商品名称")]
		[NotNull]
		public string ItemName { get; set; }

		[JsonPropertyName("item_specs")]
		[Description("商品规格")]
		public string ItemSpecs { get; set; }

		[JsonPropertyName("item_count")]
		[Description("商品数量")]
		[NotNull]
		public int? ItemCount { get; set; }

		[JsonPropertyName("item_volume")]
		[Description("单件商品体积（cm3）")]
		public int? ItemVolume { get; set; }

		[JsonPropertyName("item_weight")]
		[Description("单件商品重量（g)")]
		public int? ItemWeight { get; set; }

		[JsonPropertyName("item_net_weight")]
		[Description("单件总净重量（g）")]
		public int? ItemNetWeight { get; set; }
	}

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("extra")]
	[Description("备用扩展字段")]
	public string Extra { get; set; }

	[JsonPropertyName("user_id")]
	[Description("实际使用取号服务店铺user_id")]
	public long? UserId { get; set; }

	[JsonPropertyName("volume")]
	[Description("总体积 货物的总体积或长，宽，高 ；整数 单位cm")]
	public string Volume { get; set; }

	[JsonPropertyName("weight")]
	[Description("/总重量 ；整数 用于与快递商有计抛信任协议的商家）单位克")]
	public long? Weight { get; set; }

	[JsonPropertyName("warehouse")]
	[Description("仓、门店、总对总发货")]
	public WarehouseItem Warehouse { get; set; }

	public class WarehouseItem
	{
		[JsonPropertyName("is_sum_up")]
		[Description("目前该字段无效，统一传false")]
		[NotNull]
		public bool? IsSumUp { get; set; }

		[JsonPropertyName("wh_order_no")]
		[Description("仓库订单号(丹鸟等仓发链路使用)")]
		public string WhOrderNo { get; set; }
	}
}

[Description("面单信息更新接口，更新收件人信息 以及发件人名字联系方式信息，支持顺丰速递更新面单信息（支持顺丰速递更新重量体积）")]
public class LogisticsUpdateOrderRsp
{
	[JsonPropertyName("track_no")]
	[Description("运单号")]
	public string TrackNo { get; set; }

	[JsonPropertyName("sort_code")]
	[Description("分拣码（三段码）")]
	public string SortCode { get; set; }

	[JsonPropertyName("package_center_code")]
	[Description("集包地代码")]
	public string PackageCenterCode { get; set; }

	[JsonPropertyName("package_center_name")]
	[Description("集包名称")]
	public string PackageCenterName { get; set; }

	[JsonPropertyName("short_address_code")]
	[Description("大头笔编码")]
	public string ShortAddressCode { get; set; }

	[JsonPropertyName("short_address_name")]
	[Description("大头笔名称")]
	public string ShortAddressName { get; set; }

	[JsonPropertyName("extra_resp")]
	[Description("扩展字段")]
	public string ExtraResp { get; set; }
}
