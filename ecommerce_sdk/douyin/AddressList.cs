namespace ecommerce.sdk.douyin;

[Description("分页获取商家地址库列表数据")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","请输入正确的排序方式","isv.parameter-invalid:5001","请输入正确参数")]
public class AddressListReq : IDouyinReq<AddressListRsp>
{

	public string GetMethod() { return "address.list"; }

	public string GetUrl() { return "/address/list"; }

	[JsonPropertyName("shop_id")]
	[Description("【已废弃】店铺id")]
	public long? ShopId { get; set; }

	[JsonPropertyName("page_size")]
	[Description("翻页每页数量，默认10")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("page_no")]
	[Description("翻页页数，从1开始")]
	[NotNull]
	public long? PageNo { get; set; }

	[JsonPropertyName("order_by")]
	[Description("排序方式支持asc/desc")]
	[NotNull]
	public string OrderBy { get; set; }

	[JsonPropertyName("order_field")]
	[Description("排序字段；create_time-创建时间排序，update_time-更新时间排序；")]
	[NotNull]
	public string OrderField { get; set; }

	[JsonPropertyName("store_id")]
	[Description("门店ID，抖超小时达业务使用传入后只获取该门店下地址列表；")]
	public long? StoreId { get; set; }
}

[Description("分页获取商家地址库列表数据")]
public class AddressListRsp
{
	[JsonPropertyName("total")]
	[Description("地址总数")]
	public long Total { get; set; }

	[JsonPropertyName("page_size")]
	[Description("页码")]
	public long PageSize { get; set; }

	[JsonPropertyName("page_no")]
	[Description("每页数量")]
	public long PageNo { get; set; }

	[JsonPropertyName("address_list")]
	[Description("地址列表")]
	public List<AddressListIItem> AddressListI { get; set; }

	public class AddressListIItem
	{
		[JsonPropertyName("address_id")]
		[Description("地址库id")]
		public long AddressId { get; set; }

		[JsonPropertyName("reciever_name")]
		[Description("收/发件人")]
		public string RecieverName { get; set; }

		[JsonPropertyName("is_default")]
		[Description("是否为退货默认")]
		public long IsDefault { get; set; }

		[JsonPropertyName("is_send_default")]
		[Description("是否为发货默认")]
		public long IsSendDefault { get; set; }

		[JsonPropertyName("create_time")]
		[Description("创建时间，时间戳，秒")]
		public string CreateTime { get; set; }

		[JsonPropertyName("update_time")]
		[Description("更新时间，时间戳，秒")]
		public string UpdateTime { get; set; }

		[JsonPropertyName("receiver_provinc")]
		[Description("收件人省份")]
		public string ReceiverProvinc { get; set; }

		[JsonPropertyName("receiver_city")]
		[Description("收件人城市")]
		public string ReceiverCity { get; set; }

		[JsonPropertyName("receiver_district")]
		[Description("收件人地区")]
		public string ReceiverDistrict { get; set; }

		[JsonPropertyName("receiver_detail")]
		[Description("收件人详情地址")]
		public string ReceiverDetail { get; set; }

		[JsonPropertyName("receiver_street")]
		[Description("收件人街道")]
		public string ReceiverStreet { get; set; }

		[JsonPropertyName("remark")]
		[Description("地址备注信息")]
		public string Remark { get; set; }
	}
}
