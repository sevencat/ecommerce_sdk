namespace ecommerce.sdk.douyin;

[Description("商家提货出库")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","62302609:下发仓储单据失败","isv.business-failed:62302609","请重试！")]
[DouyinRetCode(50002,"业务处理失败","10001:物流服务未开通","isv.business-failed:10001","物流服务未开通")]
[DouyinRetCode(50002,"业务处理失败","100102:校验可用库存失败","isv.business-failed:100102","请校验库存！")]
[DouyinRetCode(50002,"业务处理失败","100100:查询货品信息失败，请重试","isv.business-failed:100100","请重试！")]
[DouyinRetCode(20001,"内部服务超时","1103:内部服务超时，请重试","isp.service-timeout-error:1103","请重试！")]
[DouyinRetCode(50002,"业务处理失败","9026:校验可用库存失败","isv.business-failed:9026","校验可用库存失败")]
[DouyinRetCode(50002,"业务处理失败","9009:库存中心返回值异常","isv.business-failed:9009","库存中心返回值异常")]
public class YuncCreateOutboundOrderToBReq : IDouyinReq<YuncCreateOutboundOrderToBRsp>
{

	public string GetMethod() { return "yunc.createOutboundOrderToB"; }

	public string GetUrl() { return "/yunc/createOutboundOrderToB"; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("in_warehouse_code")]
	[Description("仓编码")]
	public string InWarehouseCode { get; set; }

	[JsonPropertyName("delivery_mode")]
	[Description("运输方式：物流-1；快递-2；自提-3")]
	[NotNull]
	public int? DeliveryMode { get; set; }

	[JsonPropertyName("erp_order_no")]
	[Description("erp单号")]
	[NotNull]
	public string ErpOrderNo { get; set; }

	[JsonPropertyName("order_type")]
	[Description("调拨出库=2 退供出库=3 生产出库=5 其它出库=6 2B销售出库=7")]
	[NotNull]
	public int? OrderType { get; set; }

	[JsonPropertyName("expected_qty")]
	[Description("提货数量")]
	[NotNull]
	public int? ExpectedQty { get; set; }

	[JsonPropertyName("source_platform_code")]
	[Description("来源平台编码")]
	public string SourcePlatformCode { get; set; }

	[JsonPropertyName("source_platform_name")]
	[Description("来源平台名称")]
	public string SourcePlatformName { get; set; }

	[JsonPropertyName("order_time")]
	[Description("订单时间")]
	[NotNull]
	public long? OrderTime { get; set; }

	[JsonPropertyName("review_time")]
	[Description("审单时间")]
	public long? ReviewTime { get; set; }

	[JsonPropertyName("express_code")]
	[Description("快递公司编码")]
	public string ExpressCode { get; set; }

	[JsonPropertyName("express_name")]
	[Description("快递公司名称")]
	public string ExpressName { get; set; }

	[JsonPropertyName("is_insure")]
	[Description("是否保价1=是0=否")]
	public int? IsInsure { get; set; }

	[JsonPropertyName("insure_amount")]
	[Description("保价金额 单位：分")]
	public int? InsureAmount { get; set; }

	[JsonPropertyName("express_product_id")]
	[Description("快递产品类型")]
	public string ExpressProductId { get; set; }

	[JsonPropertyName("express_product_name")]
	[Description("快递产品名称")]
	public string ExpressProductName { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺id（不强校验，填0即可）")]
	[NotNull]
	public long? ShopId { get; set; }

	[JsonPropertyName("shop_name")]
	[Description("店铺名称（不强校验，填写“店铺”即可）")]
	[NotNull]
	public string ShopName { get; set; }

	[JsonPropertyName("allow_merge")]
	[Description("是否允许合单 1=是 0=否")]
	[NotNull]
	public long? AllowMerge { get; set; }

	[JsonPropertyName("sender_info")]
	[Description("省份编码")]
	public SenderInfoItem SenderInfo { get; set; }

	public class SenderInfoItem
	{
		[JsonPropertyName("province_code")]
		[Description("省份编码")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("province")]
		[Description("省份")]
		[NotNull]
		public string Province { get; set; }

		[JsonPropertyName("city_code")]
		[Description("城市编码")]
		public string CityCode { get; set; }

		[JsonPropertyName("city")]
		[Description("城市")]
		[NotNull]
		public string City { get; set; }

		[JsonPropertyName("district_code")]
		[Description("地区编码")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district")]
		[Description("地区")]
		public string District { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编码")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street")]
		[Description("街道")]
		public string Street { get; set; }

		[JsonPropertyName("name")]
		[Description("姓名")]
		[NotNull]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("手机号")]
		public string Mobile { get; set; }

		[JsonPropertyName("detail")]
		[Description("详细地址")]
		[NotNull]
		public string Detail { get; set; }
	}

	[JsonPropertyName("receiver_info")]
	[Description("省份编码")]
	[NotNull]
	public ReceiverInfoItem ReceiverInfo { get; set; }

	public class ReceiverInfoItem
	{
		[JsonPropertyName("province_code")]
		[Description("省份编码")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("province")]
		[Description("省份")]
		[NotNull]
		public string Province { get; set; }

		[JsonPropertyName("city_code")]
		[Description("城市编码")]
		public string CityCode { get; set; }

		[JsonPropertyName("city")]
		[Description("城市")]
		public string City { get; set; }

		[JsonPropertyName("district_code")]
		[Description("地区编码")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district")]
		[Description("地区")]
		public string District { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编码")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street")]
		[Description("街道")]
		public string Street { get; set; }

		[JsonPropertyName("name")]
		[Description("姓名")]
		[NotNull]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("手机号")]
		public string Mobile { get; set; }

		[JsonPropertyName("detail")]
		[Description("详细地址")]
		[NotNull]
		public string Detail { get; set; }
	}

	[JsonPropertyName("remark")]
	[Description("留言")]
	public string Remark { get; set; }

	[JsonPropertyName("buyer_message")]
	[Description("留言")]
	public string BuyerMessage { get; set; }

	[JsonPropertyName("seller_message")]
	[Description("留言")]
	public string SellerMessage { get; set; }

	[JsonPropertyName("extend")]
	[Description("扩展")]
	public string Extend { get; set; }

	[JsonPropertyName("order_details")]
	[Description("出库单行号")]
	[NotNull]
	public List<OrderDetailsItem> OrderDetails { get; set; }

	public class OrderDetailsItem
	{
		[JsonPropertyName("talent_style_no")]
		[Description("达人款号")]
		public string TalentStyleNo { get; set; }

		[JsonPropertyName("line_no")]
		[Description("出库单行号")]
		[NotNull]
		public string LineNo { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("库存类型")]
		[NotNull]
		public long? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态")]
		[NotNull]
		public long? InventoryStatus { get; set; }

		[JsonPropertyName("barcode")]
		[Description("货品条码（barcode字段要求为4-19位！）")]
		public string Barcode { get; set; }

		[JsonPropertyName("category_name")]
		[Description("类目名称")]
		public string CategoryName { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("平台货品编码")]
		public string CargoCode { get; set; }

		[JsonPropertyName("erp_sku_id")]
		[Description("ERP商品编码")]
		public string ErpSkuId { get; set; }

		[JsonPropertyName("sku_name")]
		[Description("商品名称")]
		[NotNull]
		public string SkuName { get; set; }

		[JsonPropertyName("expected_qty")]
		[Description("订单数量")]
		[NotNull]
		public long? ExpectedQty { get; set; }

		[JsonPropertyName("product_date")]
		[Description("生产日期")]
		public long? ProductDate { get; set; }

		[JsonPropertyName("expire_date")]
		[Description("过期日期")]
		public long? ExpireDate { get; set; }

		[JsonPropertyName("batch_code")]
		[Description("批次号")]
		public string BatchCode { get; set; }
	}

	[JsonPropertyName("owner_code")]
	[Description("货主id")]
	public string OwnerCode { get; set; }
}

[Description("商家提货出库")]
public class YuncCreateOutboundOrderToBRsp
{
}
