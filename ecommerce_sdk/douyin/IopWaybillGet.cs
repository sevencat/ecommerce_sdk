namespace ecommerce.sdk.douyin;

[Description("代发订单电子面单取号")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","取号信息一次最多支持10个","isv.parameter-invalid:10000","取号信息一次最多支持10个")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:88888","系统繁忙，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:10005","系统繁忙，请稍后重试")]
public class IopWaybillGetReq : IDouyinReq<IopWaybillGetRsp>
{

	public string GetMethod() { return "iop.waybillGet"; }

	public string GetUrl() { return "/iop/waybillGet"; }

	[JsonPropertyName("sender")]
	[Description("寄件人信息")]
	[NotNull]
	public SenderItem Sender { get; set; }

	public class SenderItem
	{
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

		[JsonPropertyName("address")]
		[Description("寄件人地址信息")]
		[NotNull]
		public AddressItem Address { get; set; }

		public class AddressItem
		{
			[JsonPropertyName("countryCode")]
			[Description("国家编码（默认CHN，目前只有国内业务）")]
			[NotNull]
			public string CountryCode { get; set; }

			[JsonPropertyName("provinceCode")]
			[Description("省编码")]
			public string ProvinceCode { get; set; }

			[JsonPropertyName("provinceName")]
			[Description("省名称")]
			[NotNull]
			public string ProvinceName { get; set; }

			[JsonPropertyName("cityCode")]
			[Description("市编码")]
			public string CityCode { get; set; }

			[JsonPropertyName("cityName")]
			[Description("市名称")]
			[NotNull]
			public string CityName { get; set; }

			[JsonPropertyName("districtCode")]
			[Description("区/县编码")]
			public string DistrictCode { get; set; }

			[JsonPropertyName("districtName")]
			[Description("区/县名称")]
			[NotNull]
			public string DistrictName { get; set; }

			[JsonPropertyName("streetCode")]
			[Description("街道编码")]
			public string StreetCode { get; set; }

			[JsonPropertyName("streetName")]
			[Description("街道名称")]
			public string StreetName { get; set; }

			[JsonPropertyName("detailAddress")]
			[Description("剩余详细地址")]
			[NotNull]
			public string DetailAddress { get; set; }
		}
	}

	[JsonPropertyName("trade_order_list")]
	[Description("取号列表")]
	[NotNull]
	public List<TradeOrderListItem> TradeOrderList { get; set; }

	public class TradeOrderListItem
	{
		[JsonPropertyName("user_id")]
		[Description("代打店铺id")]
		[NotNull]
		public long? UserId { get; set; }

		[JsonPropertyName("order_infos")]
		[Description("代打订单列表")]
		[NotNull]
		public List<OrderInfosItem> OrderInfos { get; set; }

		public class OrderInfosItem
		{
			[JsonPropertyName("service_list")]
			[Description("增值服务列表")]
			public List<ServiceListItem> ServiceList { get; set; }

			public class ServiceListItem
			{
				[JsonPropertyName("service_code")]
				[Description("增值服务类型")]
				[NotNull]
				public string ServiceCode { get; set; }

				[JsonPropertyName("service_value")]
				[Description("增值服务对应的value值，如果增值类型涉及金额会校验，单位：分")]
				[NotNull]
				public string ServiceValue { get; set; }
			}

			[JsonPropertyName("product_type")]
			[Description("快递产品类型")]
			public string ProductType { get; set; }

			[JsonPropertyName("pay_method")]
			[Description("支付方式：1-寄付月结，2-寄付现结）若不传，默认为商家与物流商网点约定的支付方式")]
			public short? PayMethod { get; set; }

			[JsonPropertyName("distr_order_id")]
			[Description("代打订单id")]
			[NotNull]
			public string DistrOrderId { get; set; }

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
				[Description("单件商品体积（cm3)")]
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
			[Description("是否返回签回单（签单返还）的运单号，支持以下值：1：要求 0：不要求")]
			public short? IsSignBack { get; set; }

			[JsonPropertyName("remark")]
			[Description("订单备注")]
			public string Remark { get; set; }

			[JsonPropertyName("extra")]
			[Description("备用扩展字段")]
			public string Extra { get; set; }

			[JsonPropertyName("pay_amount")]
			[Description("运费金额，单位为分")]
			public long? PayAmount { get; set; }

			[JsonPropertyName("total_pack_count")]
			[Description("大于1，示例3")]
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

			[JsonPropertyName("pack_id")]
			[Description("包裹id（只能传入数字、字母和下划线；大小写敏感，即123A,123a 不可当做相同ID，否则存在一定可能取号失败）一单一包裹是不需要传，有2个以上时，从第二个开始都需要传不同id")]
			public string PackId { get; set; }

			[JsonPropertyName("warehouse")]
			[Description("仓相关信息")]
			public WarehouseItem Warehouse { get; set; }

			public class WarehouseItem
			{
				[JsonPropertyName("wh_code")]
				[Description("仓库编码")]
				public string WhCode { get; set; }

				[JsonPropertyName("delivery_type")]
				[Description("发货方式（用于韵达、京东链路）1或不传-普通发货2-门店发货3-仓库发货")]
				public string DeliveryType { get; set; }

				[JsonPropertyName("wh_order_no")]
				[Description("仓库订单号(丹鸟等仓发链路使用)")]
				public string WhOrderNo { get; set; }
			}
		}

		[JsonPropertyName("delivery_req")]
		[Description("派送要求（目前仅德邦支持）")]
		public DeliveryReqItem DeliveryReq { get; set; }

		public class DeliveryReqItem
		{
			[JsonPropertyName("is_center_delivery")]
			[Description("是否接受仅镇中心派送")]
			public bool? IsCenterDelivery { get; set; }

			[JsonPropertyName("is_pickup_self")]
			[Description("是否合伙人自提")]
			public bool? IsPickupSelf { get; set; }
		}

		[JsonPropertyName("company_code")]
		[Description("物流服务商编码")]
		[NotNull]
		public string CompanyCode { get; set; }
	}
}

[Description("代发订单电子面单取号")]
public class IopWaybillGetRsp
{
	[JsonPropertyName("ebill_infos")]
	[Description("电子面单信息列表")]
	public List<EbillInfosItem> EbillInfos { get; set; }

	public class EbillInfosItem
	{
		[JsonPropertyName("distr_order_id")]
		[Description("代打订单号")]
		public string DistrOrderId { get; set; }

		[JsonPropertyName("pack_id")]
		[Description("包裹id")]
		public string PackId { get; set; }

		[JsonPropertyName("track_no")]
		[Description("运单号")]
		public string TrackNo { get; set; }

		[JsonPropertyName("sort_code")]
		[Description("分拣码（三段码）")]
		public string SortCode { get; set; }

		[JsonPropertyName("package_code")]
		[Description("集包地代码")]
		public string PackageCode { get; set; }

		[JsonPropertyName("package_code_name")]
		[Description("集包名称")]
		public string PackageCodeName { get; set; }

		[JsonPropertyName("mark_destination_code")]
		[Description("大头笔编码")]
		public string MarkDestinationCode { get; set; }

		[JsonPropertyName("mark_destination_code_name")]
		[Description("大头笔名称")]
		public string MarkDestinationCodeName { get; set; }

		[JsonPropertyName("extra")]
		[Description("额外打印")]
		public string Extra { get; set; }

		[JsonPropertyName("extra_resp")]
		[Description("额外打印信息（众邮、京东、丰网使用），具体请参考[抖音电商电子面单对接文档](https://op.jinritemai.com/docs/guide-docs/33/338)附录4")]
		public string ExtraResp { get; set; }

		[JsonPropertyName("sub_waybill_codes")]
		[Description("子母件列表英文逗号分隔")]
		public string SubWaybillCodes { get; set; }
	}

	[JsonPropertyName("err_infos")]
	[Description("错误信息列表")]
	public List<ErrInfosItem> ErrInfos { get; set; }

	public class ErrInfosItem
	{
		[JsonPropertyName("distr_order_id")]
		[Description("代打订单号")]
		public string DistrOrderId { get; set; }

		[JsonPropertyName("pack_id")]
		[Description("包裹id")]
		public string PackId { get; set; }

		[JsonPropertyName("err_code")]
		[Description("错误码")]
		public string ErrCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("错误信息")]
		public string ErrMsg { get; set; }
	}
}
