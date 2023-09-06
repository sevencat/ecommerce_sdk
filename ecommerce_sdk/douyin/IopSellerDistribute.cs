namespace ecommerce.sdk.douyin;

[Description("商家分配代发订单")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:10000","请检查参数")]
public class IopSellerDistributeReq : IDouyinReq<IopSellerDistributeRsp>
{

	public string GetMethod() { return "iop.sellerDistribute"; }

	public string GetUrl() { return "/iop/sellerDistribute"; }

	[JsonPropertyName("distribute_order_list")]
	[Description("待分配列表，一次批量最多100个")]
	[NotNull]
	public List<DistributeOrderListItem> DistributeOrderList { get; set; }

	public class DistributeOrderListItem
	{
		[JsonPropertyName("supplier_shop_id")]
		[Description("要分配的厂商的店铺ID")]
		[NotNull]
		public long? SupplierShopId { get; set; }

		[JsonPropertyName("distr_order_id")]
		[Description("代打订单号")]
		[NotNull]
		public string DistrOrderId { get; set; }
	}
}

[Description("商家分配代发订单")]
public class IopSellerDistributeRsp
{
	[JsonPropertyName("distribute_order_reuslts")]
	[Description("分配结果明细")]
	public List<DistributeOrderReusltsItem> DistributeOrderReuslts { get; set; }

	public class DistributeOrderReusltsItem
	{
		[JsonPropertyName("supplier_shop_id")]
		[Description("要分配的厂商的店铺ID")]
		public long SupplierShopId { get; set; }

		[JsonPropertyName("distr_order_id")]
		[Description("代打订单")]
		public string DistrOrderId { get; set; }

		[JsonPropertyName("err_no")]
		[Description("返回状态码 0-成功 非0 失败")]
		public int ErrNo { get; set; }

		[JsonPropertyName("message")]
		[Description("返回文案")]
		public string Message { get; set; }
	}
}
