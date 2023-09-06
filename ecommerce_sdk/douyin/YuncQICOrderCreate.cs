namespace ecommerce.sdk.douyin;

[Description("云仓QIC订单创建接口")]
public class YuncQICOrderCreateReq : IDouyinReq<YuncQICOrderCreateRsp>
{

	public string GetMethod() { return "yunc.QICOrderCreate"; }

	public string GetUrl() { return "/yunc/QICOrderCreate"; }

	[JsonPropertyName("order_id")]
	[Description("外部业务单号 仅支持纯数字字符串，长度小于20 必填")]
	public string OrderId { get; set; }

	[JsonPropertyName("BIC_order_detail")]
	[Description("必填")]
	public BICOrderDetailItem BICOrderDetail { get; set; }

	public class BICOrderDetailItem
	{
		[JsonPropertyName("external_shop_id")]
		[Description("外部店铺ID 仅支持纯数字字符串 必填")]
		public string ExternalShopId { get; set; }

		[JsonPropertyName("user_id")]
		[Description("外部店铺ID")]
		public string UserId { get; set; }

		[JsonPropertyName("warehouse_code")]
		[Description("质检仓编码 必填")]
		public string WarehouseCode { get; set; }

		[JsonPropertyName("receiver_info")]
		[Description("收件人信息 必填")]
		public ReceiverInfoItem ReceiverInfo { get; set; }

		public class ReceiverInfoItem
		{
			[JsonPropertyName("name")]
			[Description("姓名 必填")]
			public string Name { get; set; }

			[JsonPropertyName("phone")]
			[Description("固定电话号")]
			public string Phone { get; set; }

			[JsonPropertyName("mobile")]
			[Description("手机号 必填")]
			public string Mobile { get; set; }

			[JsonPropertyName("country_code")]
			[Description("国家编码 必填")]
			public string CountryCode { get; set; }

			[JsonPropertyName("province_code")]
			[Description("省编码")]
			public string ProvinceCode { get; set; }

			[JsonPropertyName("province_name")]
			[Description("省名称 必填")]
			public string ProvinceName { get; set; }

			[JsonPropertyName("city_code")]
			[Description("城市编码")]
			public string CityCode { get; set; }

			[JsonPropertyName("city_name")]
			[Description("城市名称 必填")]
			public string CityName { get; set; }

			[JsonPropertyName("district_code")]
			[Description("区县编码")]
			public string DistrictCode { get; set; }

			[JsonPropertyName("district_name")]
			[Description("区县名称 必填")]
			public string DistrictName { get; set; }

			[JsonPropertyName("street_code")]
			[Description("街道编码")]
			public string StreetCode { get; set; }

			[JsonPropertyName("street_name")]
			[Description("街道名称")]
			public string StreetName { get; set; }

			[JsonPropertyName("detail_address")]
			[Description("详细地址 必填")]
			public string DetailAddress { get; set; }
		}

		[JsonPropertyName("sender_info")]
		[Description("寄件人信息 必填")]
		public SenderInfoItem SenderInfo { get; set; }

		public class SenderInfoItem
		{
			[JsonPropertyName("name")]
			[Description("姓名 必填")]
			public string Name { get; set; }

			[JsonPropertyName("phone")]
			[Description("固定电话号")]
			public string Phone { get; set; }

			[JsonPropertyName("mobile")]
			[Description("手机号 必填")]
			public string Mobile { get; set; }

			[JsonPropertyName("country_code")]
			[Description("国家编码 必填")]
			public string CountryCode { get; set; }

			[JsonPropertyName("province_code")]
			[Description("省编码")]
			public string ProvinceCode { get; set; }

			[JsonPropertyName("province_name")]
			[Description("省名称 必填")]
			public string ProvinceName { get; set; }

			[JsonPropertyName("city_code")]
			[Description("城市编码")]
			public string CityCode { get; set; }

			[JsonPropertyName("city_name")]
			[Description("城市名称 必填")]
			public string CityName { get; set; }

			[JsonPropertyName("district_code")]
			[Description("区县编码")]
			public string DistrictCode { get; set; }

			[JsonPropertyName("district_name")]
			[Description("区县名称 必填")]
			public string DistrictName { get; set; }

			[JsonPropertyName("street_code")]
			[Description("街道编码")]
			public string StreetCode { get; set; }

			[JsonPropertyName("street_name")]
			[Description("街道名称")]
			public string StreetName { get; set; }

			[JsonPropertyName("detail_address")]
			[Description("详细地址 必填")]
			public string DetailAddress { get; set; }
		}

		[JsonPropertyName("buyer_remark")]
		[Description("买家备注")]
		public string BuyerRemark { get; set; }

		[JsonPropertyName("seller_remark")]
		[Description("卖家备注")]
		public string SellerRemark { get; set; }

		[JsonPropertyName("book_time")]
		[Description("下单时间 秒级时间戳")]
		public long? BookTime { get; set; }

		[JsonPropertyName("pay_time")]
		[Description("支付时间 秒级时间戳")]
		public long? PayTime { get; set; }

		[JsonPropertyName("promise_sign_time")]
		[Description("期望收货时间 秒级时间戳")]
		public long? PromiseSignTime { get; set; }

		[JsonPropertyName("order_amount")]
		[Description("订单费用 单位（分）")]
		public long? OrderAmount { get; set; }

		[JsonPropertyName("freight_amount")]
		[Description("运费 单位（分）")]
		public long? FreightAmount { get; set; }

		[JsonPropertyName("pay_amount")]
		[Description("支付费用 单位（分）")]
		public long? PayAmount { get; set; }

		[JsonPropertyName("is_allow_merge")]
		[Description("是否合单 1-合单，2-非合单 默认非合单")]
		public short? IsAllowMerge { get; set; }

		[JsonPropertyName("source_platform_code")]
		[Description("订单来源平台 DY-抖音")]
		public string SourcePlatformCode { get; set; }
	}

	[JsonPropertyName("BIC_product_infos")]
	[Description("商品明细 必填")]
	public List<BICProductInfosItem> BICProductInfos { get; set; }

	public class BICProductInfosItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID 必填")]
		public string ProductId { get; set; }

		[JsonPropertyName("product_name")]
		[Description("商品名称 必填")]
		public string ProductName { get; set; }

		[JsonPropertyName("sku_id")]
		[Description("skuId 必填")]
		public long? SkuId { get; set; }

		[JsonPropertyName("spec_info")]
		[Description("规格信息")]
		public string SpecInfo { get; set; }

		[JsonPropertyName("count")]
		[Description("数量 必填")]
		public int? Count { get; set; }

		[JsonPropertyName("sku_price")]
		[Description("价格 必填")]
		public long? SkuPrice { get; set; }

		[JsonPropertyName("sku_desc")]
		[Description("sku描述")]
		public string SkuDesc { get; set; }

		[JsonPropertyName("pic_url")]
		[Description("商品图片的url 必填")]
		public string PicUrl { get; set; }

		[JsonPropertyName("unit")]
		[Description("单位")]
		public string Unit { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("平台货品id")]
		public string CargoCode { get; set; }

		[JsonPropertyName("bar_code")]
		[Description("条码")]
		public string BarCode { get; set; }

		[JsonPropertyName("first_category_id")]
		[Description("一级类目ID")]
		public string FirstCategoryId { get; set; }

		[JsonPropertyName("second_category_id")]
		[Description("二级类目ID")]
		public string SecondCategoryId { get; set; }

		[JsonPropertyName("third_category_id")]
		[Description("三级类目ID")]
		public string ThirdCategoryId { get; set; }

		[JsonPropertyName("fourth_category_id")]
		[Description("四级类目ID")]
		public string FourthCategoryId { get; set; }

		[JsonPropertyName("first_category_name")]
		[Description("一级类目名称")]
		public string FirstCategoryName { get; set; }

		[JsonPropertyName("second_category_name")]
		[Description("二级类目名称")]
		public string SecondCategoryName { get; set; }

		[JsonPropertyName("third_category_name")]
		[Description("三级类目名称")]
		public string ThirdCategoryName { get; set; }

		[JsonPropertyName("fourth_category_name")]
		[Description("四级类目名称")]
		public string FourthCategoryName { get; set; }
	}

	[JsonPropertyName("extend")]
	[Description("需要在origin_track_nokey中填写原始运单号  必填")]
	public Dictionary<string,string> Extend { get; set; }
}

[Description("云仓QIC订单创建接口")]
public class YuncQICOrderCreateRsp
{
}
