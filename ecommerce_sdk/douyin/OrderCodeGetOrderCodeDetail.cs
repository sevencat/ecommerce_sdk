namespace ecommerce.sdk.douyin;

[Description("通过订单码和商家信息查询订单码绑定的订单详情信息(包括材质、镶嵌材质、质量、商品名称等)")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","入参为空","isv.missing-parameter:20001","入参不能为空，填入合法参数")]
[DouyinRetCode(50002,"业务处理失败","订单查询失败","isv.business-failed:20002","不是qic商家")]
[DouyinRetCode(40004,"非法的参数","当前商家不是ERP商家","isv.parameter-invalid:20005","当前商家不是ERP商家")]
[DouyinRetCode(50002,"业务处理失败","订单不存在","isv.business-failed:20004","订单不存在")]
public class OrderCodeGetOrderCodeDetailReq : IDouyinReq<OrderCodeGetOrderCodeDetailRsp>
{

	public string GetMethod() { return "orderCode.getOrderCodeDetail"; }

	public string GetUrl() { return "/orderCode/getOrderCodeDetail"; }

	[JsonPropertyName("orderCodes")]
	[Description("订单码列表，最多支持50个订单码一起查询，超过50个取前50个订单码")]
	[NotNull]
	public List<string> OrderCodes { get; set; }

	[JsonPropertyName("shopId")]
	[Description("店铺ID")]
	[NotNull]
	public long? ShopId { get; set; }
}

[Description("通过订单码和商家信息查询订单码绑定的订单详情信息(包括材质、镶嵌材质、质量、商品名称等)")]
public class OrderCodeGetOrderCodeDetailRsp
{
	[JsonPropertyName("shop_id")]
	[Description("店铺ID")]
	public long ShopId { get; set; }

	[JsonPropertyName("shop_name")]
	[Description("店铺名称")]
	public string ShopName { get; set; }

	[JsonPropertyName("order_detail_list")]
	[Description("订单明细列表")]
	public List<OrderDetailListItem> OrderDetailList { get; set; }

	public class OrderDetailListItem
	{
		[JsonPropertyName("order_code")]
		[Description("订单码")]
		public string OrderCode { get; set; }

		[JsonPropertyName("order_id")]
		[Description("订单号")]
		public string OrderId { get; set; }

		[JsonPropertyName("logistics_name")]
		[Description("物流名称")]
		public string LogisticsName { get; set; }

		[JsonPropertyName("sku_detail_list")]
		[Description("sku明细列表")]
		public List<SkuDetailListItem> SkuDetailList { get; set; }

		public class SkuDetailListItem
		{
			[JsonPropertyName("third_name")]
			[Description("三级类目名称")]
			public string ThirdName { get; set; }

			[JsonPropertyName("third_cid")]
			[Description("三级类目")]
			public string ThirdCid { get; set; }

			[JsonPropertyName("material")]
			[Description("材质")]
			public string Material { get; set; }

			[JsonPropertyName("mosaic_material")]
			[Description("镶嵌材质")]
			public string MosaicMaterial { get; set; }

			[JsonPropertyName("accessory_material")]
			[Description("配件材质")]
			public string AccessoryMaterial { get; set; }

			[JsonPropertyName("product_id")]
			[Description("商品ID")]
			public string ProductId { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("weight")]
			[Description("质量")]
			public string Weight { get; set; }

			[JsonPropertyName("sku_spec_desc")]
			[Description("商品描述")]
			public string SkuSpecDesc { get; set; }

			[JsonPropertyName("sku_id")]
			[Description("skuId")]
			public string SkuId { get; set; }

			[JsonPropertyName("num")]
			[Description("数量（当前sku数量）")]
			public long Num { get; set; }
		}
	}
}
