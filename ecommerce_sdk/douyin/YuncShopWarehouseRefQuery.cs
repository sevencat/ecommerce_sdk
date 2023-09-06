namespace ecommerce.sdk.douyin;

[Description("云仓项目, erp获取商家入驻仓关系")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","3000:参数错误","isv.business-failed:3000","校验参数准确性")]
public class YuncShopWarehouseRefQueryReq : IDouyinReq<YuncShopWarehouseRefQueryRsp>
{

	public string GetMethod() { return "yunc.shopWarehouseRefQuery"; }

	public string GetUrl() { return "/yunc/shopWarehouseRefQuery"; }

	[JsonPropertyName("shop_id")]
	[Description("店铺id")]
	[NotNull]
	public long? ShopId { get; set; }
}

[Description("云仓项目, erp获取商家入驻仓关系")]
public class YuncShopWarehouseRefQueryRsp
{
	[JsonPropertyName("warehouse_list")]
	[Description("仓信息")]
	public List<WarehouseListItem> WarehouseList { get; set; }

	public class WarehouseListItem
	{
		[JsonPropertyName("warehouse_code")]
		[Description("仓编码")]
		public string WarehouseCode { get; set; }

		[JsonPropertyName("warehouse_name")]
		[Description("仓名称")]
		public string WarehouseName { get; set; }
	}

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }

	[JsonPropertyName("owner_name")]
	[Description("货主名称")]
	public string OwnerName { get; set; }
}
