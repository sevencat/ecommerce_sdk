namespace ecommerce.sdk.douyin;

[Description("云仓出库接单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","货品不存在","isv.business-failed:62302630","货品信息校验不通过，按提示修改")]
[DouyinRetCode(50002,"业务处理失败","承运商不存在","isv.business-failed:100100","根据提示修改，请检查快递编码")]
[DouyinRetCode(50002,"业务处理失败","1002:Redis加锁失败","isv.business-failed:1002","并发推送出库单失败，请重试")]
[DouyinRetCode(50002,"业务处理失败","62302604:获取lo失败","isv.business-failed:62302604","请重试")]
[DouyinRetCode(50002,"业务处理失败","62302625:接收订单异常，商家未入驻","isv.business-failed:62302625","商家未入驻云仓，请检查是否开通云仓服务")]
[DouyinRetCode(50002,"业务处理失败","500:500","isv.business-failed:500","请重试")]
[DouyinRetCode(50002,"业务处理失败","1001:并发处理失败","isv.business-failed:1001","并发处理失败，请重试")]
[DouyinRetCode(50002,"业务处理失败","62302628:快递不可达，无推荐快递","isv.business-failed:62302628","快递不可达，请联系买家")]
[DouyinRetCode(50002,"业务处理失败","62302605:构建物流订单失败","isv.business-failed:62302605","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","62301121:重复接单","isv.business-failed:62301121","请检查订单信息")]
[DouyinRetCode(50002,"业务处理失败","62302635:库存不足","isv.business-failed:62302635","请检查库存信息")]
[DouyinRetCode(50002,"业务处理失败","62302633:并发推送erp单据失败，请重新下发","isv.business-failed:62302633","请重新下发！")]
[DouyinRetCode(50002,"业务处理失败","62302601:调用库存中心失败","isv.business-failed:62302601","请重试！")]
[DouyinRetCode(50002,"业务处理失败","1249:该订单已存在，无需重复下发","isv.business-failed:1249","无需重复下发！")]
[DouyinRetCode(50002,"业务处理失败","62302632:该单号已存在，请换一个手工单号重新下发","isv.business-failed:62302632","该单号已存在，请换一个手工单号重新下发")]
[DouyinRetCode(50002,"业务处理失败","999999:下游RPC超时","isv.business-failed:999999","请重试！")]
[DouyinRetCode(20001,"内部服务超时","1103:请求内部服务超时","isp.service-timeout-error:1103","请重试")]
[DouyinRetCode(50002,"业务处理失败","-20001:没有足够的预占产能释放","isv.business-failed:-20001","没有足够的预占产能释放")]
[DouyinRetCode(50002,"业务处理失败","1003:请求内部服务异常,请重试","isv.business-failed:1003","请重试")]
[DouyinRetCode(50002,"业务处理失败","62302606:构建物流履行单失败","isv.business-failed:62302606","构建物流履行单失败")]
[DouyinRetCode(50002,"业务处理失败","1271:手工单号重复，请更换","isv.business-failed:1271","手工单号重复，请更换")]
[DouyinRetCode(50002,"业务处理失败","1200:标准化地址异常","isv.business-failed:1200","标准化地址异常")]
[DouyinRetCode(50002,"业务处理失败","1252:仓快递配置信息不存在","isv.business-failed:1252","仓快递配置信息不存在")]
[DouyinRetCode(50002,"业务处理失败","1401:规则查询缓存失败","isv.business-failed:1401","规则查询缓存失败")]
[DouyinRetCode(50002,"业务处理失败","-1:请求详情列表（index=0）目的地-节点信息-省编码不能为空，请检查！","isv.business-failed:-1","请求详情列表（index=0）目的地-节点信息-省编码不能为空，请检查！")]
[DouyinRetCode(50002,"业务处理失败","1100:查询店铺与货主绑定关系失败，请重试！","isv.business-failed:1100","查询店铺与货主绑定关系失败，请重试！")]
[DouyinRetCode(50002,"业务处理失败","1253:货主和店铺绑定关系不存在，请在scm进行货主和店铺关系绑定后重推数据！","isv.business-failed:1253","货主和店铺绑定关系不存在，请在scm进行货主和店铺关系绑定后重推数据！")]
public class YuncCloudCreateOutboundOrderReq : IDouyinReq<YuncCloudCreateOutboundOrderRsp>
{

	public string GetMethod() { return "yunc.cloudCreateOutboundOrder"; }

	public string GetUrl() { return "/yunc/cloudCreateOutboundOrder"; }

	[JsonPropertyName("delivery_mode")]
	[Description("交货方式")]
	[NotNull]
	public int? DeliveryMode { get; set; }

	[JsonPropertyName("platform_order_no")]
	[Description("平台交易单号")]
	[NotNull]
	public string PlatformOrderNo { get; set; }

	[JsonPropertyName("erp_order_no")]
	[Description("ERP出库单号")]
	[NotNull]
	public string ErpOrderNo { get; set; }

	[JsonPropertyName("order_type")]
	[Description("订单类型 1:销售出库")]
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
	[Description("DY传shopid，非DY传erp的店铺编码")]
	[NotNull]
	public long? ShopId { get; set; }

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
		[Description("省份名称（必传）")]
		[NotNull]
		public string Province { get; set; }

		[JsonPropertyName("city_code")]
		[Description("城市编码")]
		public string CityCode { get; set; }

		[JsonPropertyName("city")]
		[Description("城市名称（必传）")]
		[NotNull]
		public string City { get; set; }

		[JsonPropertyName("district_code")]
		[Description("地区编码")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district")]
		[Description("地区名称（必传）")]
		[NotNull]
		public string District { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编码")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street")]
		[Description("街道名称")]
		public string Street { get; set; }

		[JsonPropertyName("detail")]
		[Description("详细地址（必传）")]
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

		[JsonPropertyName("oaids")]
		[Description("地址id")]
		public string Oaids { get; set; }
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
		[Description("省份名称（必传）")]
		[NotNull]
		public string Province { get; set; }

		[JsonPropertyName("city_code")]
		[Description("城市编码")]
		public string CityCode { get; set; }

		[JsonPropertyName("city")]
		[Description("城市名称（必传）")]
		[NotNull]
		public string City { get; set; }

		[JsonPropertyName("district_code")]
		[Description("地区编码")]
		public string DistrictCode { get; set; }

		[JsonPropertyName("district")]
		[Description("地区名称（必传）")]
		[NotNull]
		public string District { get; set; }

		[JsonPropertyName("street_code")]
		[Description("街道编码")]
		public string StreetCode { get; set; }

		[JsonPropertyName("street")]
		[Description("街道名称")]
		public string Street { get; set; }

		[JsonPropertyName("detail")]
		[Description("详细地址（必传）")]
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

		[JsonPropertyName("oaids")]
		[Description("地址id")]
		public string Oaids { get; set; }
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

		[JsonPropertyName("inventory_type")]
		[Description("库存类型 1正品 2次品")]
		[NotNull]
		public int? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态 1正常 2质检 3冻结")]
		[NotNull]
		public int? InventoryStatus { get; set; }

		[JsonPropertyName("barcode")]
		[Description("货品条码（barcode字段要求为4-19位）")]
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
		public int? ExpectedQty { get; set; }

		[JsonPropertyName("product_date")]
		[Description("生产日期")]
		public long? ProductDate { get; set; }

		[JsonPropertyName("expire_date")]
		[Description("过期日期")]
		public long? ExpireDate { get; set; }

		[JsonPropertyName("batch_code")]
		[Description("批次号")]
		public string BatchCode { get; set; }

		[JsonPropertyName("platform_sku_id")]
		[Description("平台商品编码")]
		public string PlatformSkuId { get; set; }

		[JsonPropertyName("platform_order_no")]
		[Description("平台订单号")]
		public string PlatformOrderNo { get; set; }

		[JsonPropertyName("merge_shop_id")]
		[Description("店铺ID")]
		public long? MergeShopId { get; set; }

		[JsonPropertyName("order_time")]
		[Description("下单时间")]
		public long? OrderTime { get; set; }

		[JsonPropertyName("pay_time")]
		[Description("支付时间")]
		public long? PayTime { get; set; }

		[JsonPropertyName("subplatform_order_no")]
		[Description("平台交易子订单号")]
		public string SubplatformOrderNo { get; set; }
	}

	[JsonPropertyName("warehouse_code")]
	[Description("仓编码")]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("货主编码(必填！！)")]
	public string OwnerCode { get; set; }

	[JsonPropertyName("add_biz_type")]
	[Description("附加业务类型 A100:代发")]
	public string AddBizType { get; set; }

	[JsonPropertyName("out_batch_num")]
	[Description("合单数量")]
	public int? OutBatchNum { get; set; }

	[JsonPropertyName("package_type")]
	[Description("订单类型（一单一包:1 拆单:2 合单:3）")]
	public short? PackageType { get; set; }

	[JsonPropertyName("pay_time")]
	[Description("支付时间")]
	public long? PayTime { get; set; }

	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	public string ShopName { get; set; }

	[JsonPropertyName("extend")]
	[Description("扩展字段")]
	public string Extend { get; set; }
}

[Description("云仓出库接单")]
public class YuncCloudCreateOutboundOrderRsp
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
