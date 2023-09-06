namespace ecommerce.sdk.douyin;

[Description("云仓出库接单toB")]
public class YuncCloudCreateOutboundOrderToBReq : IDouyinReq<YuncCloudCreateOutboundOrderToBRsp>
{

	public string GetMethod() { return "yunc.CloudCreateOutboundOrderToB"; }

	public string GetUrl() { return "/yunc/CloudCreateOutboundOrderToB"; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓编码")]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("in_warehouse_code")]
	[Description("入库仓库")]
	[NotNull]
	public string InWarehouseCode { get; set; }

	[JsonPropertyName("delivery_mode")]
	[Description("交货方式")]
	[NotNull]
	public int? DeliveryMode { get; set; }

	[JsonPropertyName("erp_order_no")]
	[Description("ERP出库单号")]
	[NotNull]
	public string ErpOrderNo { get; set; }

	[JsonPropertyName("order_type")]
	[Description("订单类型")]
	[NotNull]
	public int? OrderType { get; set; }

	[JsonPropertyName("expected_qty")]
	[Description("应发数量")]
	[NotNull]
	public int? ExpectedQty { get; set; }

	[JsonPropertyName("source_platform_code")]
	[Description("订单来源平台编码")]
	[NotNull]
	public string SourcePlatformCode { get; set; }

	[JsonPropertyName("source_platform_name")]
	[Description("订单来源平台名称")]
	[NotNull]
	public string SourcePlatformName { get; set; }

	[JsonPropertyName("order_time")]
	[Description("前台订单下单时间")]
	[NotNull]
	public long? OrderTime { get; set; }

	[JsonPropertyName("review_time")]
	[Description("审单时间")]
	[NotNull]
	public long? ReviewTime { get; set; }

	[JsonPropertyName("express_code")]
	[Description("快递公司编码")]
	[NotNull]
	public string ExpressCode { get; set; }

	[JsonPropertyName("express_name")]
	[Description("快递公司名称")]
	public string ExpressName { get; set; }

	[JsonPropertyName("is_insure")]
	[Description("是否保价")]
	[NotNull]
	public int? IsInsure { get; set; }

	[JsonPropertyName("insure_amount")]
	[Description("保价金额")]
	public int? InsureAmount { get; set; }

	[JsonPropertyName("express_product_id")]
	[Description("快递产品类型")]
	public string ExpressProductId { get; set; }

	[JsonPropertyName("express_product_name")]
	[Description("快递产品名称")]
	public string ExpressProductName { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺id")]
	[NotNull]
	public long? ShopId { get; set; }

	[JsonPropertyName("shop_name")]
	[Description("店铺名")]
	[NotNull]
	public string ShopName { get; set; }

	[JsonPropertyName("allow_merge")]
	[Description("是否允许合单")]
	[NotNull]
	public int? AllowMerge { get; set; }

	[JsonPropertyName("sender_info")]
	[Description("发件人信息")]
	[NotNull]
	public SenderInfoItem SenderInfo { get; set; }

	public class SenderInfoItem
	{
		[JsonPropertyName("province_code")]
		[Description("省份编码")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("province")]
		[Description("省份名称")]
		[NotNull]
		public string Province { get; set; }

		[JsonPropertyName("city_code")]
		[Description("城市编码")]
		public string CityCode { get; set; }

		[JsonPropertyName("city")]
		[Description("城市名称")]
		[NotNull]
		public string City { get; set; }

		[JsonPropertyName("district_code")]
		[Description("地区编码")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district")]
		[Description("地区名称")]
		[NotNull]
		public string District { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编码")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street")]
		[Description("街道名称")]
		public string Street { get; set; }

		[JsonPropertyName("detail")]
		[Description("详细地址")]
		[NotNull]
		public string Detail { get; set; }

		[JsonPropertyName("name")]
		[Description("姓名")]
		[NotNull]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("联系方式")]
		public string Mobile { get; set; }

		[JsonPropertyName("tel_phone")]
		[Description("固定电话")]
		public string TelPhone { get; set; }
	}

	[JsonPropertyName("receiver_info")]
	[Description("收件人信息")]
	[NotNull]
	public ReceiverInfoItem ReceiverInfo { get; set; }

	public class ReceiverInfoItem
	{
		[JsonPropertyName("province_code")]
		[Description("省份编码")]
		public string ProvinceCode { get; set; }

		[JsonPropertyName("province")]
		[Description("省份名称")]
		public string Province { get; set; }

		[JsonPropertyName("city_code")]
		[Description("城市编码")]
		public string CityCode { get; set; }

		[JsonPropertyName("city")]
		[Description("城市名称")]
		public string City { get; set; }

		[JsonPropertyName("district_code")]
		[Description("地区编码")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district")]
		[Description("地区名称")]
		public string District { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编码")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street")]
		[Description("街道名称")]
		public string Street { get; set; }

		[JsonPropertyName("detail")]
		[Description("地址")]
		public string Detail { get; set; }

		[JsonPropertyName("name")]
		[Description("姓名")]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("手机")]
		public string Mobile { get; set; }

		[JsonPropertyName("tel_phone")]
		[Description("电话")]
		public string TelPhone { get; set; }
	}

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("buyer_message")]
	[Description("买家备注")]
	public string BuyerMessage { get; set; }

	[JsonPropertyName("seller_message")]
	[Description("卖家备注")]
	public string SellerMessage { get; set; }

	[JsonPropertyName("order_details")]
	[Description("订单详情")]
	[NotNull]
	public List<OrderDetailsItem> OrderDetails { get; set; }

	public class OrderDetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("出库单行号")]
		[NotNull]
		public string LineNo { get; set; }

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
		public int? ExpectedQty { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("库存类型")]
		[NotNull]
		public int? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态")]
		[NotNull]
		public int? InventoryStatus { get; set; }

		[JsonPropertyName("barcode")]
		[Description("货品条码")]
		public string Barcode { get; set; }

		[JsonPropertyName("category_name")]
		[Description("类目名称")]
		public string CategoryName { get; set; }

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
	[Description("货主编码")]
	public string OwnerCode { get; set; }

	[JsonPropertyName("extend")]
	[Description("扩展字段")]
	public string Extend { get; set; }
}

[Description("云仓出库接单toB")]
public class YuncCloudCreateOutboundOrderToBRsp
{
	[JsonPropertyName("data")]
	[Description("响应数据")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("logistics_no")]
		[Description("lo单号")]
		public string LogisticsNo { get; set; }
	}
}
