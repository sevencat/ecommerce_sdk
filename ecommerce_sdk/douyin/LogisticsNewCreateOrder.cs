namespace ecommerce.sdk.douyin;

[Description("主要用于商家ERP/ISV 向字节电子面单系统获取单号和打印信息。,（重要）若取号后再来取号，需传相同订单号及不同的包裹id再次来取号，否则返回老号,调用路径：ISV/商家—>字节,支持批量取号，一次最多50条。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","共享订单不存在","isv.parameter-invalid:10003","检查参数是否准确")]
[DouyinRetCode(40004,"非法的参数","寄件人姓名不能为空","isv.parameter-invalid:4006","检查参数是否准确")]
[DouyinRetCode(40004,"非法的参数","拼接参数异常","isv.parameter-invalid:1000","检查参数是否准确")]
[DouyinRetCode(50002,"业务处理失败","查询订单信息失败，请重试","isv.business-failed:4007","检查参数是否准确，如果确认无误提工单或者群里反馈")]
[DouyinRetCode(50002,"业务处理失败","订单不是该店铺下的订单","isv.business-failed:15000","切换店铺或更换订单号")]
[DouyinRetCode(50002,"业务处理失败","订单信息不存在","isv.business-failed:15002","确认订单信息是否正确")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:15001","稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统内部错误","isv.business-failed:4029","稍后重试")]
public class LogisticsNewCreateOrderReq : IDouyinReq<LogisticsNewCreateOrderRsp>
{

	public string GetMethod() { return "logistics.newCreateOrder"; }

	public string GetUrl() { return "/logistics/newCreateOrder"; }

	[JsonPropertyName("sender_info")]
	[Description("寄件人信息")]
	[NotNull]
	public SenderInfoItem SenderInfo { get; set; }

	public class SenderInfoItem
	{
		[JsonPropertyName("address")]
		[Description("寄件人地址信息（需要调用/logistics/listShopNetsite查询）")]
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
			[Description("街道名称")]
			public string StreetName { get; set; }

			[JsonPropertyName("detail_address")]
			[Description("剩余详细地址")]
			[NotNull]
			public string DetailAddress { get; set; }
		}

		[JsonPropertyName("contact")]
		[Description("寄件人联系信息")]
		[NotNull]
		public ContactItem Contact { get; set; }

		public class ContactItem
		{
			[JsonPropertyName("name")]
			[Description("寄件人姓名")]
			[NotNull]
			public string Name { get; set; }

			[JsonPropertyName("phone")]
			[Description("寄件人固话（和mobile二选一）")]
			public string Phone { get; set; }

			[JsonPropertyName("mobile")]
			[Description("寄件人移动电话（和phone二选一）")]
			public string Mobile { get; set; }
		}
	}

	[JsonPropertyName("logistics_code")]
	[Description("物流服务商编码")]
	[NotNull]
	public string LogisticsCode { get; set; }

	[JsonPropertyName("order_infos")]
	[Description("详细订单列表")]
	[NotNull]
	public List<OrderInfosItem> OrderInfos { get; set; }

	public class OrderInfosItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单号（合单情况下，isv只需传其中一个订单号，传入的订单号需去掉末尾后缀字母A)；非抖音订单需要传order_channel字段，长度仅支持32个字符，格式：数字、大小写字母及“-”、“/”2种分隔符的组合字符串，例如：Doudian-123456")]
		[NotNull]
		public string OrderId { get; set; }

		[JsonPropertyName("pack_id")]
		[Description("包裹id。拆包（一个订单获取多个独立的运单，非子母件）场景使用，只能传入15位以内的数字、字母和下划线，大小写敏感（即123A,123a为不同包裹id），仅第2个及以后的运单取号时传不同id。")]
		public string PackId { get; set; }

		[JsonPropertyName("service_list")]
		[Description("增值服务列表，更多增值服务参考[抖音电商电子面单对接文档](https://bytedance.feishu.cn/wiki/wikcnNVdm3TlJutNCUlKmiVuwnf)")]
		public List<ServiceListItem> ServiceList { get; set; }

		public class ServiceListItem
		{
			[JsonPropertyName("service_code")]
			[Description("增值服务类型")]
			public string ServiceCode { get; set; }

			[JsonPropertyName("service_value")]
			[Description("增值服务对应的value值，如果增值类型涉及金额会校验，单位：分")]
			public string ServiceValue { get; set; }
		}

		[JsonPropertyName("product_type")]
		[Description("快递产品类型，更多产品类型参考[抖音电商电子面单对接文档](https://bytedance.feishu.cn/wiki/wikcnNVdm3TlJutNCUlKmiVuwnf)")]
		public string ProductType { get; set; }

		[JsonPropertyName("pay_method")]
		[Description("支付方式：1-寄付月结，2-寄付现结）若不传，默认为商家与物流商网点约定的支付方式")]
		public short? PayMethod { get; set; }

		[JsonPropertyName("pay_amount")]
		[Description("运费金额，单位为分")]
		public long? PayAmount { get; set; }

		[JsonPropertyName("pod_model_address")]
		[Description("回单寄回地址")]
		public PodModelAddressItem PodModelAddress { get; set; }

		public class PodModelAddressItem
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
			[Description("街道名称")]
			public string StreetName { get; set; }

			[JsonPropertyName("detail_address")]
			[Description("剩余详细地址")]
			[NotNull]
			public string DetailAddress { get; set; }
		}

		[JsonPropertyName("receiver_info")]
		[Description("收件人信息")]
		[NotNull]
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
				[Description("国家编码（默认中国CHN）")]
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
				[Description("街道名称")]
				public string StreetName { get; set; }

				[JsonPropertyName("detail_address")]
				[Description("剩余详细地址，支持密文")]
				[NotNull]
				public string DetailAddress { get; set; }

				[JsonPropertyName("province_code")]
				[Description("省编码code")]
				public string ProvinceCode { get; set; }

				[JsonPropertyName("city_code")]
				[Description("市编码code")]
				public string CityCode { get; set; }

				[JsonPropertyName("district_code")]
				[Description("区编码code")]
				public string DistrictCode { get; set; }

				[JsonPropertyName("street_code")]
				[Description("街道编码code")]
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
				[NotNull]
				public string Name { get; set; }

				[JsonPropertyName("phone")]
				[Description("收件人固话（和mobile二选一）")]
				public string Phone { get; set; }

				[JsonPropertyName("mobile")]
				[Description("收件人移动电话（和phone二选一），支持密文")]
				public string Mobile { get; set; }
			}
		}

		[JsonPropertyName("items")]
		[Description("商品明细列表")]
		[NotNull]
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
			[Description("单件商品体积（cm3")]
			public int? ItemVolume { get; set; }

			[JsonPropertyName("item_weight")]
			[Description("单件商品重量（g)")]
			public int? ItemWeight { get; set; }

			[JsonPropertyName("item_net_weight")]
			[Description("单件总净重量（g）")]
			public int? ItemNetWeight { get; set; }
		}

		[JsonPropertyName("sender_fetch_time")]
		[Description("要求上门取件时间段")]
		public string SenderFetchTime { get; set; }

		[JsonPropertyName("is_sign_back")]
		[Description("是否返回签回单（签单返还）的运单号，支持以下值：1：要求 0：不要求,")]
		public short? IsSignBack { get; set; }

		[JsonPropertyName("remark")]
		[Description("订单备注")]
		public string Remark { get; set; }

		[JsonPropertyName("extra")]
		[Description("备用扩展字段（非必传字段，如果传值不可为null,按照示例来传。）")]
		public string Extra { get; set; }

		[JsonPropertyName("total_pack_count")]
		[Description("子母件的总包裹数量，仅子母件场景使用，使用时包裹数量必须≥2，不传则默认为普通的一单一包裹运单。")]
		public int? TotalPackCount { get; set; }

		[JsonPropertyName("total_weight")]
		[Description("商品总重量，单位：克（仅支持顺丰物流使用）")]
		public string TotalWeight { get; set; }

		[JsonPropertyName("total_length")]
		[Description("商品总长，单位：cm（仅支持顺丰物流使用）")]
		public string TotalLength { get; set; }

		[JsonPropertyName("total_width")]
		[Description("商品总宽，单位：cm（仅支持顺丰物流使用）")]
		public string TotalWidth { get; set; }

		[JsonPropertyName("total_height")]
		[Description("商品总高，单位：cm（仅支持顺丰物流使用）")]
		public string TotalHeight { get; set; }

		[JsonPropertyName("volume")]
		[Description("商品总体积，单位：cm3（仅支持顺丰物流使用）")]
		public string Volume { get; set; }

		[JsonPropertyName("warehouse")]
		[Description("仓、门店、总对总发货")]
		public WarehouseItem Warehouse { get; set; }

		public class WarehouseItem
		{
			[JsonPropertyName("is_sum_up")]
			[Description("true 总对总门店发货")]
			[NotNull]
			public bool? IsSumUp { get; set; }

			[JsonPropertyName("wh_code")]
			[Description("仓库id编码")]
			public string WhCode { get; set; }

			[JsonPropertyName("wh_order_no")]
			[Description("仓库订单号(丹鸟等仓发链路使用)")]
			public string WhOrderNo { get; set; }

			[JsonPropertyName("delivery_type")]
			[Description("发货方式，2-门店发货 3-仓库发货（不传默认为3）")]
			public string DeliveryType { get; set; }
		}

		[JsonPropertyName("net_info")]
		[Description("总对总信息门店信息")]
		public NetInfoItem NetInfo { get; set; }

		public class NetInfoItem
		{
			[JsonPropertyName("category")]
			[Description("物流服务商类型，直营/加盟")]
			public string Category { get; set; }

			[JsonPropertyName("net_code")]
			[Description("网点编码,当category为加盟类型时，该字段必填；为直营类型时可不传；对总模式该字段均为非必填")]
			public string NetCode { get; set; }

			[JsonPropertyName("monthly_account")]
			[Description("总对总账号 月结账号")]
			public string MonthlyAccount { get; set; }

			[JsonPropertyName("secret_key")]
			[Description("总对总密码")]
			public string SecretKey { get; set; }
		}

		[JsonPropertyName("shipping_code")]
		[Description("物料码")]
		public string ShippingCode { get; set; }

		[JsonPropertyName("special_delivery_type_code")]
		[Description("顺丰极效前置场景（必填）使用  2:极效前置单")]
		public string SpecialDeliveryTypeCode { get; set; }

		[JsonPropertyName("special_delivery_type_value")]
		[Description("顺丰极效前置场景（必填）使用   Y:若不支持则返回普通运单 N:若不支持则返回错误码")]
		public string SpecialDeliveryTypeValue { get; set; }

		[JsonPropertyName("package_weight")]
		[Description("包裹总重量（g）（丹鸟专用，其余物流商取号不要传该字段）")]
		public int? PackageWeight { get; set; }

		[JsonPropertyName("combine_orders")]
		[Description("合单订单号列表")]
		public List<string> CombineOrders { get; set; }
	}

	[JsonPropertyName("user_id")]
	[Description("共享账号场景下需传，代表实际使用取号服务的shop_id（需与order_id匹配）；若无法获取到该shop_id，value传值 -1")]
	public long? UserId { get; set; }

	[JsonPropertyName("delivery_req")]
	[Description("派送要求（目前仅德邦支持）")]
	public DeliveryReqItem DeliveryReq { get; set; }

	public class DeliveryReqItem
	{
		[JsonPropertyName("is_center_delivery")]
		[Description("true")]
		public bool? IsCenterDelivery { get; set; }

		[JsonPropertyName("is_pickup_self")]
		[Description("true")]
		public bool? IsPickupSelf { get; set; }
	}

	[JsonPropertyName("order_channel")]
	[Description("订单渠道来源编码，具体请参考[下单渠道来源编码表](https://bytedance.feishu.cn/sheets/shtcngIVwcJlgXLzWhEtKrmv7Af)，当order_id订单号为非抖音订单时必传")]
	public string OrderChannel { get; set; }
}

[Description("主要用于商家ERP/ISV 向字节电子面单系统获取单号和打印信息。,（重要）若取号后再来取号，需传相同订单号及不同的包裹id再次来取号，否则返回老号,调用路径：ISV/商家—>字节,支持批量取号，一次最多50条。")]
public class LogisticsNewCreateOrderRsp
{
	[JsonPropertyName("ebill_infos")]
	[Description("电子面单信息列表")]
	public List<EbillInfosItem> EbillInfos { get; set; }

	public class EbillInfosItem
	{
		[JsonPropertyName("company")]
		[Description("面单对应的物流商code")]
		public string Company { get; set; }

		[JsonPropertyName("hint_msg")]
		[Description("成功的单子的提示信息")]
		public string HintMsg { get; set; }

		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("pack_id")]
		[Description("包裹id")]
		public string PackId { get; set; }

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
		[Description("额外打印信息（众邮、京东、丰网使用），具体请参考[抖音电商电子面单对接文档](https://op.jinritemai.com/docs/guide-docs/33/338)附录4")]
		public string ExtraResp { get; set; }

		[JsonPropertyName("sub_waybill_codes")]
		[Description("子母件列表英文逗号分隔")]
		public string SubWaybillCodes { get; set; }

		[JsonPropertyName("order_channel")]
		[Description("2；详情请看文档映射表")]
		public string OrderChannel { get; set; }

		[JsonPropertyName("shipping_code")]
		[Description("快递商侧系统生成的寄件码")]
		public string ShippingCode { get; set; }
	}

	[JsonPropertyName("err_infos")]
	[Description("错误信息列表")]
	public List<ErrInfosItem> ErrInfos { get; set; }

	public class ErrInfosItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("pack_id")]
		[Description("包裹id")]
		public string PackId { get; set; }

		[JsonPropertyName("err_code")]
		[Description("错误码")]
		public string ErrCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("错误信息")]
		public string ErrMsg { get; set; }

		[JsonPropertyName("order_channel")]
		[Description("2；详情请看文档映射表")]
		public string OrderChannel { get; set; }
	}
}
