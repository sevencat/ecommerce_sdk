namespace ecommerce.sdk.douyin;

[Description("回传物流单号，实现代发订单的发货功能（注：回传成功后，原始订单也会同步更新成已发货状态）")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:10000","请检查参数")]
[DouyinRetCode(50002,"业务处理失败","代打订单状态不允许发货","isv.business-failed:41001","请检查代发单状态")]
[DouyinRetCode(50002,"业务处理失败","代打订单状态不允许发货","isv.business-failed:41000","请检查代发单状态")]
[DouyinRetCode(50002,"业务处理失败","代打订单状态不允许发货","isv.business-failed:41004","请检查代发单状态")]
[DouyinRetCode(50002,"业务处理失败","代发单不存在","isv.business-failed:41002","请检查代发单是否存在")]
[DouyinRetCode(50002,"业务处理失败","没有找到默认的发货地址","isv.business-failed:41003","没有找到默认的发货地址，请到抖店后台配置")]
[DouyinRetCode(20000,"系统错误","系统繁忙，请稍后重试","isp.service-error:88888","发货失败，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:10005","发货失败，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:10006","发货失败，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，请稍后重试","isv.business-failed:1000","发货失败，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","发货失败，请重新检查当前请求发货的全部件数，等于代发单的剩余待发货件数","isv.business-failed:41007","发货失败，请重新检查当前请求发货的全部件数，等于代发单的剩余待发货件数")]
public class IopWaybillReturnReq : IDouyinReq<IopWaybillReturnRsp>
{

	public string GetMethod() { return "iop.waybillReturn"; }

	public string GetUrl() { return "/iop/waybillReturn"; }

	[JsonPropertyName("user_id")]
	[Description("代打店铺id")]
	[NotNull]
	public long? UserId { get; set; }

	[JsonPropertyName("distr_order_id")]
	[Description("代打订单号")]
	[NotNull]
	public string DistrOrderId { get; set; }

	[JsonPropertyName("company_code")]
	[Description("物流公司，当包裹list为空或不合规时，该字段必填；后续即将废弃，建议传入pack_list；")]
	public string CompanyCode { get; set; }

	[JsonPropertyName("track_no")]
	[Description("面单号，当包裹list为空或不合规时，该字段必填；后续即将废弃，建议传入pack_list；")]
	public string TrackNo { get; set; }

	[JsonPropertyName("is_refund_reject")]
	[Description("是否拒绝退款申请（默认不传即为false，则发货失败；true即拒绝退款，发货成功")]
	public bool? IsRefundReject { get; set; }

	[JsonPropertyName("address_id")]
	[Description("1商家后台-地址库管理里获取。如果send_addr不为空，则以send_addr的为准")]
	public long? AddressId { get; set; }

	[JsonPropertyName("send_addr")]
	[Description("发货地址")]
	public SendAddrItem SendAddr { get; set; }

	public class SendAddrItem
	{
		[JsonPropertyName("province")]
		[Description("省")]
		[NotNull]
		public ProvinceItem Province { get; set; }

		public class ProvinceItem
		{
			[JsonPropertyName("id")]
			[Description("省编码")]
			[NotNull]
			public string Id { get; set; }

			[JsonPropertyName("name")]
			[Description("省名称")]
			[NotNull]
			public string Name { get; set; }
		}

		[JsonPropertyName("city")]
		[Description("市")]
		[NotNull]
		public CityItem City { get; set; }

		public class CityItem
		{
			[JsonPropertyName("id")]
			[Description("市编码")]
			[NotNull]
			public string Id { get; set; }

			[JsonPropertyName("name")]
			[Description("市名称")]
			[NotNull]
			public string Name { get; set; }
		}

		[JsonPropertyName("town")]
		[Description("区")]
		[NotNull]
		public TownItem Town { get; set; }

		public class TownItem
		{
			[JsonPropertyName("id")]
			[Description("区编码")]
			[NotNull]
			public string Id { get; set; }

			[JsonPropertyName("name")]
			[Description("区名称")]
			[NotNull]
			public string Name { get; set; }
		}

		[JsonPropertyName("detail")]
		[Description("详情")]
		[NotNull]
		public string Detail { get; set; }

		[JsonPropertyName("landmark")]
		[Description("直接传空字符串")]
		[NotNull]
		public string Landmark { get; set; }

		[JsonPropertyName("street")]
		[Description("街道")]
		[NotNull]
		public StreetItem Street { get; set; }

		public class StreetItem
		{
			[JsonPropertyName("id")]
			[Description("街道编码")]
			[NotNull]
			public string Id { get; set; }

			[JsonPropertyName("name")]
			[Description("街道名称")]
			[NotNull]
			public string Name { get; set; }
		}
	}

	[JsonPropertyName("pack_list")]
	[Description("当物流公司和面单号均为空时，该字段为必填；当该字段不为空时，以该字段信息为准。")]
	public List<PackListItem> PackList { get; set; }

	public class PackListItem
	{
		[JsonPropertyName("track_no")]
		[Description("运单号")]
		[NotNull]
		public string TrackNo { get; set; }

		[JsonPropertyName("ship_num")]
		[Description("代发单的待发货件数")]
		[NotNull]
		public long? ShipNum { get; set; }

		[JsonPropertyName("company_code")]
		[Description("物流公司")]
		[NotNull]
		public string CompanyCode { get; set; }
	}

	[JsonPropertyName("serial_number_list")]
	[Description("序列号")]
	public List<string> SerialNumberList { get; set; }
}

[Description("回传物流单号，实现代发订单的发货功能（注：回传成功后，原始订单也会同步更新成已发货状态）")]
public class IopWaybillReturnRsp
{
	[JsonPropertyName("return_result")]
	[Description("结果")]
	public bool ReturnResult { get; set; }

	[JsonPropertyName("delivery_id")]
	[Description("运单id")]
	public string DeliveryId { get; set; }

	[JsonPropertyName("pack_list")]
	[Description("包裹信息")]
	public List<PackListItem> PackList { get; set; }

	public class PackListItem
	{
		[JsonPropertyName("deliver_id")]
		[Description("运单id")]
		public string DeliverId { get; set; }

		[JsonPropertyName("track_no")]
		[Description("运单号")]
		public string TrackNo { get; set; }

		[JsonPropertyName("ship_num")]
		[Description("本次发货的商品件数")]
		public long ShipNum { get; set; }

		[JsonPropertyName("company_code")]
		[Description("物流公司")]
		public string CompanyCode { get; set; }
	}
}
