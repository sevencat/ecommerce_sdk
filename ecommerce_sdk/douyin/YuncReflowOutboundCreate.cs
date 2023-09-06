namespace ecommerce.sdk.douyin;

[Description("创建翻仓出库单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","1001:单据状态应为已创建","isv.business-failed:1001","联系系统负责人处理")]
[DouyinRetCode(50002,"业务处理失败","1000:业务处理失败","isv.business-failed:1000","联系系统负责人处理")]
[DouyinRetCode(50002,"业务处理失败","12000:获取仓库信息失败，请检查编码是否有效","isv.business-failed:12000","检查仓库编码有效性")]
[DouyinRetCode(50002,"业务处理失败","13002:单据正在处理中","isv.business-failed:13002","请稍候重试")]
[DouyinRetCode(50002,"业务处理失败","13006:调用货主服务失败","isv.business-failed:13006","检查货主有效性")]
[DouyinRetCode(50002,"业务处理失败","13001:货主、店铺信息不合法","isv.business-failed:13001","检查货主店铺对应关系")]
public class YuncReflowOutboundCreateReq : IDouyinReq<YuncReflowOutboundCreateRsp>
{

	public string GetMethod() { return "yunc.reflow.outboundCreate"; }

	public string GetUrl() { return "/yunc/reflow/outboundCreate"; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("outbound_order_no")]
	[Description("出库单号")]
	[NotNull]
	public string OutboundOrderNo { get; set; }

	[JsonPropertyName("biz_order_no")]
	[Description("上游业务单号")]
	[NotNull]
	public string BizOrderNo { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }

	[JsonPropertyName("owner_name")]
	[Description("货主名称")]
	public string OwnerName { get; set; }

	[JsonPropertyName("shopid")]
	[Description("店铺ID")]
	public long? Shopid { get; set; }

	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	public string ShopName { get; set; }

	[JsonPropertyName("order_type")]
	[Description("单据类型（XSCK-销售出库，TCCK-退仓出库，DBCK-调拨出库，SCCK-生产出库，QTCK-其他出库）")]
	[NotNull]
	public string OrderType { get; set; }

	[JsonPropertyName("status")]
	[Description("单据状态（1-创单成功）")]
	[NotNull]
	public int? Status { get; set; }

	[JsonPropertyName("express")]
	[Description("快递商编码")]
	public string Express { get; set; }

	[JsonPropertyName("express_name")]
	[Description("快递商名称")]
	public string ExpressName { get; set; }

	[JsonPropertyName("sender_info")]
	[Description("发货人信息")]
	public SenderInfoItem SenderInfo { get; set; }

	public class SenderInfoItem
	{
		[JsonPropertyName("province_code")]
		[Description("省编号")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("province")]
		[Description("省名称")]
		public string Province { get; set; }

		[JsonPropertyName("city_code")]
		[Description("市编号")]
		public string CityCode { get; set; }

		[JsonPropertyName("city")]
		[Description("市名称")]
		public string City { get; set; }

		[JsonPropertyName("district_code")]
		[Description("区编号")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district")]
		[Description("区名称")]
		public string District { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编号")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street")]
		[Description("街道")]
		public string Street { get; set; }

		[JsonPropertyName("name")]
		[Description("姓名")]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("手机")]
		public string Mobile { get; set; }

		[JsonPropertyName("detail")]
		[Description("详细地址")]
		public string Detail { get; set; }

		[JsonPropertyName("telephone")]
		[Description("固定电话")]
		public string Telephone { get; set; }
	}

	[JsonPropertyName("receiver_info")]
	[Description("收货人信息")]
	public ReceiverInfoItem ReceiverInfo { get; set; }

	public class ReceiverInfoItem
	{
		[JsonPropertyName("province_code")]
		[Description("省编号")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("province")]
		[Description("省名称")]
		public string Province { get; set; }

		[JsonPropertyName("city_code")]
		[Description("市编号")]
		public string CityCode { get; set; }

		[JsonPropertyName("city")]
		[Description("市名称")]
		public string City { get; set; }

		[JsonPropertyName("district_code")]
		[Description("区编号")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district")]
		[Description("区名称")]
		public string District { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编号")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street")]
		[Description("街道")]
		public string Street { get; set; }

		[JsonPropertyName("name")]
		[Description("姓名")]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("手机")]
		public string Mobile { get; set; }

		[JsonPropertyName("detail")]
		[Description("详细地址")]
		public string Detail { get; set; }

		[JsonPropertyName("telephone")]
		[Description("固定电话")]
		public string Telephone { get; set; }
	}

	[JsonPropertyName("order_time")]
	[Description("下单时间")]
	public long? OrderTime { get; set; }

	[JsonPropertyName("source_platform_code")]
	[Description("订单来源平台编码")]
	public string SourcePlatformCode { get; set; }

	[JsonPropertyName("source_platform_name")]
	[Description("订单来源平台名称")]
	public string SourcePlatformName { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("order_details")]
	[Description("入库单明细")]
	[NotNull]
	public List<OrderDetailsItem> OrderDetails { get; set; }

	public class OrderDetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("行号（同一出库单下行号唯一，必填）")]
		[NotNull]
		public string LineNo { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("货品编码（必填）")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("cargo_name")]
		[Description("货品名称（必填）")]
		[NotNull]
		public string CargoName { get; set; }

		[JsonPropertyName("barcode")]
		[Description("货品条码")]
		public string Barcode { get; set; }

		[JsonPropertyName("erp_sku_id")]
		[Description("ERP商品ID")]
		public string ErpSkuId { get; set; }

		[JsonPropertyName("expect_qty")]
		[Description("预计出库数量（必填）")]
		[NotNull]
		public long? ExpectQty { get; set; }

		[JsonPropertyName("actual_qty")]
		[Description("实际出库数量")]
		public long? ActualQty { get; set; }
	}

	[JsonPropertyName("order_create_time")]
	[Description("wms系统单据创建时间")]
	public long? OrderCreateTime { get; set; }
}

[Description("创建翻仓出库单")]
public class YuncReflowOutboundCreateRsp
{
	[JsonPropertyName("code")]
	[Description("错误码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("错误信息")]
	public string Msg { get; set; }
}
