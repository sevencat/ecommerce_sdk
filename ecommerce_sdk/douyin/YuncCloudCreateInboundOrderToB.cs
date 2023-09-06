namespace ecommerce.sdk.douyin;

[Description("创建入库单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20001,"内部服务超时","1103:服务超时，请重试","isp.service-timeout-error:1103","请重试")]
public class YuncCloudCreateInboundOrderToBReq : IDouyinReq<YuncCloudCreateInboundOrderToBRsp>
{

	public string GetMethod() { return "yunc.CloudCreateInboundOrderToB"; }

	public string GetUrl() { return "/yunc/CloudCreateInboundOrderToB"; }

	[JsonPropertyName("action_type")]
	[Description("操作类型")]
	[NotNull]
	public short? ActionType { get; set; }

	[JsonPropertyName("biz_order_no")]
	[Description("入库单号")]
	[NotNull]
	public string BizOrderNo { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺id")]
	[NotNull]
	public int? ShopId { get; set; }

	[JsonPropertyName("order_type")]
	[Description("操作类型")]
	[NotNull]
	public string OrderType { get; set; }

	[JsonPropertyName("related_orders")]
	[Description("关联单据类型")]
	public string RelatedOrders { get; set; }

	[JsonPropertyName("plan_arr_time")]
	[Description("计划到达时间")]
	public string PlanArrTime { get; set; }

	[JsonPropertyName("late_arr_time")]
	[Description("最晚到达时间")]
	public string LateArrTime { get; set; }

	[JsonPropertyName("supplier_code")]
	[Description("供应商编码")]
	public string SupplierCode { get; set; }

	[JsonPropertyName("supplier_name")]
	[Description("供应商名称")]
	public int? SupplierName { get; set; }

	[JsonPropertyName("delivery_mode")]
	[Description("配送模式")]
	[NotNull]
	public int? DeliveryMode { get; set; }

	[JsonPropertyName("delivery_extend")]
	[Description("配送扩展字段")]
	public DeliveryExtendItem DeliveryExtend { get; set; }

	public class DeliveryExtendItem
	{
		[JsonPropertyName("logistics_code")]
		[Description("物流公司编码")]
		public string LogisticsCode { get; set; }

		[JsonPropertyName("logistics_name")]
		[Description("物流公司名称")]
		public string LogisticsName { get; set; }

		[JsonPropertyName("tracking_no")]
		[Description("运单号")]
		public string TrackingNo { get; set; }

		[JsonPropertyName("sender_info")]
		[Description("收件人信息")]
		public SenderInfoItem SenderInfo { get; set; }

		public class SenderInfoItem
		{
			[JsonPropertyName("company")]
			[Description("公司")]
			public string Company { get; set; }

			[JsonPropertyName("name")]
			[Description("姓名")]
			public string Name { get; set; }

			[JsonPropertyName("zip_code")]
			[Description("邮编")]
			public string ZipCode { get; set; }

			[JsonPropertyName("tel")]
			[Description("电话")]
			public string Tel { get; set; }

			[JsonPropertyName("mobile")]
			[Description("手机")]
			public string Mobile { get; set; }

			[JsonPropertyName("email")]
			[Description("邮箱")]
			public string Email { get; set; }

			[JsonPropertyName("country_code")]
			[Description("国家编码")]
			public string CountryCode { get; set; }

			[JsonPropertyName("province_code")]
			[Description("省编码")]
			public string ProvinceCode { get; set; }

			[JsonPropertyName("city_code")]
			[Description("城市编码")]
			public string CityCode { get; set; }

			[JsonPropertyName("area_code")]
			[Description("地区编码")]
			public string AreaCode { get; set; }

			[JsonPropertyName("town_code")]
			[Description("城镇")]
			public string TownCode { get; set; }

			[JsonPropertyName("detail_address")]
			[Description("地址")]
			public string DetailAddress { get; set; }
		}

		[JsonPropertyName("receiver_info")]
		[Description("收件人信息")]
		public ReceiverInfoItem ReceiverInfo { get; set; }

		public class ReceiverInfoItem
		{
			[JsonPropertyName("comapany")]
			[Description("公司")]
			public string Comapany { get; set; }

			[JsonPropertyName("name")]
			[Description("姓名")]
			public string Name { get; set; }

			[JsonPropertyName("zip_code")]
			[Description("邮编")]
			public string ZipCode { get; set; }

			[JsonPropertyName("tel")]
			[Description("手机")]
			public string Tel { get; set; }

			[JsonPropertyName("mobile")]
			[Description("电话")]
			public string Mobile { get; set; }

			[JsonPropertyName("email")]
			[Description("邮编")]
			public string Email { get; set; }

			[JsonPropertyName("country_code")]
			[Description("国家编码")]
			public string CountryCode { get; set; }

			[JsonPropertyName("province_code")]
			[Description("省编码")]
			public string ProvinceCode { get; set; }

			[JsonPropertyName("city_code")]
			[Description("城市编码")]
			public string CityCode { get; set; }

			[JsonPropertyName("area_code")]
			[Description("地区编码")]
			public string AreaCode { get; set; }

			[JsonPropertyName("town_code")]
			[Description("城镇")]
			public string TownCode { get; set; }

			[JsonPropertyName("detail_address")]
			[Description("地址")]
			public string DetailAddress { get; set; }
		}
	}

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("extend")]
	[Description("扩展字段")]
	public string Extend { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("order_details")]
	[Description("明细")]
	public List<OrderDetailsItem> OrderDetails { get; set; }

	public class OrderDetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("行号")]
		[NotNull]
		public int? LineNo { get; set; }

		[JsonPropertyName("biz_order_no")]
		[Description("单号")]
		[NotNull]
		public string BizOrderNo { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("货品code")]
		public string CargoCode { get; set; }

		[JsonPropertyName("erp_sku_id")]
		[Description("erp货品数据")]
		public string ErpSkuId { get; set; }

		[JsonPropertyName("expect_qty")]
		[Description("预计收货数量")]
		[NotNull]
		public int? ExpectQty { get; set; }

		[JsonPropertyName("purchase_price")]
		[Description("采购价格")]
		public int? PurchasePrice { get; set; }

		[JsonPropertyName("currency")]
		[Description("币种")]
		public string Currency { get; set; }

		[JsonPropertyName("sn_list")]
		[Description("唯一码")]
		public string SnList { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("库存类型")]
		[NotNull]
		public int? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态")]
		[NotNull]
		public int? InventoryStatus { get; set; }

		[JsonPropertyName("is_batch_assigned")]
		[Description("是否指定批次")]
		[NotNull]
		public int? IsBatchAssigned { get; set; }

		[JsonPropertyName("batch_info")]
		[Description("批次信息")]
		public BatchInfoItem BatchInfo { get; set; }

		public class BatchInfoItem
		{
			[JsonPropertyName("product_date")]
			[Description("生产日期")]
			public string ProductDate { get; set; }

			[JsonPropertyName("expire_date")]
			[Description("过期日期")]
			public string ExpireDate { get; set; }

			[JsonPropertyName("batch_code")]
			[Description("批次号")]
			public string BatchCode { get; set; }
		}

		[JsonPropertyName("extend")]
		[Description("扩展字段")]
		public string Extend { get; set; }
	}

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }
}

[Description("创建入库单")]
public class YuncCloudCreateInboundOrderToBRsp
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
