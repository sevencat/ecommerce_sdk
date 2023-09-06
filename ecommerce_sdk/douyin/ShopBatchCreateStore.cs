namespace ecommerce.sdk.douyin;

[Description("批量创建门店")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","16:关联的店铺没有绑定企业","isv.business-failed:16","绑定企业")]
public class ShopBatchCreateStoreReq : IDouyinReq<ShopBatchCreateStoreRsp>
{

	public string GetMethod() { return "shop.batchCreateStore"; }

	public string GetUrl() { return "/shop/batchCreateStore"; }

	[JsonPropertyName("store_list")]
	[Description("与createStore接口入参一致")]
	[NotNull]
	public List<StoreListItem> StoreList { get; set; }

	public class StoreListItem
	{
		[JsonPropertyName("row_id")]
		[Description("标识这行数据")]
		[NotNull]
		public long? RowId { get; set; }

		[JsonPropertyName("name")]
		[Description("门店名称")]
		[NotNull]
		public string Name { get; set; }

		[JsonPropertyName("store_code")]
		[Description("门店编码")]
		[NotNull]
		public string StoreCode { get; set; }

		[JsonPropertyName("longitude")]
		[Description("经度")]
		[NotNull]
		public string Longitude { get; set; }

		[JsonPropertyName("latitude")]
		[Description("纬度")]
		[NotNull]
		public string Latitude { get; set; }

		[JsonPropertyName("province")]
		[Description("省份")]
		[NotNull]
		public string Province { get; set; }

		[JsonPropertyName("city")]
		[Description("市")]
		[NotNull]
		public string City { get; set; }

		[JsonPropertyName("district")]
		[Description("区")]
		[NotNull]
		public string District { get; set; }

		[JsonPropertyName("address")]
		[Description("详细地址")]
		[NotNull]
		public string Address { get; set; }

		[JsonPropertyName("contact")]
		[Description("电话")]
		[NotNull]
		public string Contact { get; set; }

		[JsonPropertyName("open_time")]
		[Description("Key:用数字表示周几，例：1:周一、2:周一、5:周五、6:周六、7:周日。Value: 营业时间，例：“x-x”。x的区间：[00:00, 23:59]（24:00无效）。营业到次日举例：19:00-02:00。完整举例(周3周4不营业)：{1:12:00-16:00,2:12:00-16:00,5:19:00-02:00,6:12:00-16:00,7:12:00-16:00}")]
		[NotNull]
		public OpenTimeItem OpenTime { get; set; }

		public class OpenTimeItem
		{
			[JsonPropertyName("day_map")]
			[Description("Key:用数字表示周几，例：1:周一、2:周一、5:周五、6:周六、7:周日。Value: 营业时间，例：“x-x”。x的区间：[00:00, 23:59]（24:00无效）。营业到次日举例：19:00-02:00。完整举例(周3周4不营业)：{1:12:00-16:00,2:12:00-16:00,5:19:00-02:00,6:12:00-16:00,7:12:00-16:00}")]
			[NotNull]
			public Dictionary<long,string> DayMap { get; set; }
		}
	}
}

[Description("批量创建门店")]
public class ShopBatchCreateStoreRsp
{
	[JsonPropertyName("result_list")]
	[Description("结果")]
	public List<ResultListItem> ResultList { get; set; }

	public class ResultListItem
	{
		[JsonPropertyName("is_success")]
		[Description("是否成功")]
		public bool IsSuccess { get; set; }

		[JsonPropertyName("msg")]
		[Description("错误描述")]
		public string Msg { get; set; }

		[JsonPropertyName("store")]
		[Description("提交过来的信息")]
		public StoreItem Store { get; set; }

		public class StoreItem
		{
			[JsonPropertyName("row_id")]
			[Description("-")]
			public long RowId { get; set; }

			[JsonPropertyName("name")]
			[Description("-")]
			public string Name { get; set; }

			[JsonPropertyName("rel_shop_id")]
			[Description("-")]
			public long RelShopId { get; set; }

			[JsonPropertyName("store_code")]
			[Description("-")]
			public string StoreCode { get; set; }

			[JsonPropertyName("longitude")]
			[Description("-")]
			public string Longitude { get; set; }

			[JsonPropertyName("latitude")]
			[Description("-")]
			public string Latitude { get; set; }

			[JsonPropertyName("province")]
			[Description("-")]
			public string Province { get; set; }

			[JsonPropertyName("city")]
			[Description("-")]
			public string City { get; set; }

			[JsonPropertyName("district")]
			[Description("-")]
			public string District { get; set; }

			[JsonPropertyName("address")]
			[Description("-")]
			public string Address { get; set; }

			[JsonPropertyName("contact")]
			[Description("-")]
			public string Contact { get; set; }

			[JsonPropertyName("open_time")]
			[Description("-")]
			public OpenTimeItem OpenTime { get; set; }

			public class OpenTimeItem
			{
				[JsonPropertyName("day_map")]
				[Description("-")]
				public Dictionary<long,string> DayMap { get; set; }

				[JsonPropertyName("custom")]
				[Description("-")]
				public string Custom { get; set; }
			}

			[JsonPropertyName("store_id")]
			[Description("创建成功的门店ID")]
			public long StoreId { get; set; }
		}
	}
}
