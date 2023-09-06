namespace ecommerce.sdk.douyin;

[Description("此接口已废弃!,此接口已废弃!,此接口已废弃!,tob出库单取消 请调用接口 /yunc/cancelOutboundOrderToB")]
public class YuncCloudCancelOutboundOrderToBReq : IDouyinReq<YuncCloudCancelOutboundOrderToBRsp>
{

	public string GetMethod() { return "yunc.CloudCancelOutboundOrderToB"; }

	public string GetUrl() { return "/yunc/CloudCancelOutboundOrderToB"; }

	[JsonPropertyName("erp_order_no")]
	[Description("ERP出库单号")]
	[NotNull]
	public string ErpOrderNo { get; set; }

	[JsonPropertyName("op_type")]
	[Description("操作类型")]
	[NotNull]
	public int? OpType { get; set; }

	[JsonPropertyName("cancel_tag")]
	[Description("取消标记")]
	[NotNull]
	public int? CancelTag { get; set; }

	[JsonPropertyName("cancel_reason")]
	[Description("取消原因")]
	[NotNull]
	public string CancelReason { get; set; }

	[JsonPropertyName("cancel_details")]
	[Description("取消列表")]
	public List<CancelDetailsItem> CancelDetails { get; set; }

	public class CancelDetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("行号")]
		public string LineNo { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("货品编码")]
		public string CargoCode { get; set; }

		[JsonPropertyName("erp_sku_id")]
		[Description("货品id")]
		public string ErpSkuId { get; set; }

		[JsonPropertyName("cancel_amount")]
		[Description("数量")]
		public int? CancelAmount { get; set; }
	}

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }
}

[Description("此接口已废弃!,此接口已废弃!,此接口已废弃!,tob出库单取消 请调用接口 /yunc/cancelOutboundOrderToB")]
public class YuncCloudCancelOutboundOrderToBRsp
{
	[JsonPropertyName("data")]
	[Description("响应数据")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("logistics_no")]
		[Description("lo编码")]
		public string LogisticsNo { get; set; }
	}
}
