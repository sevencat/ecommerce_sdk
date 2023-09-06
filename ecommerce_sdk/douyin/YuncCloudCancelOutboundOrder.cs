namespace ecommerce.sdk.douyin;

[Description("云仓出库取消")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","调用仓储失败","isv.business-failed:62302615","重试")]
[DouyinRetCode(50002,"业务处理失败","500","isv.business-failed:500","订单已取消，主键冲突导致，会优化")]
[DouyinRetCode(50002,"业务处理失败","601:601","isv.business-failed:601","参数错误,请检查")]
[DouyinRetCode(50002,"业务处理失败","62302623:订单状态不允许取消","isv.business-failed:62302623","订单状态不允许取消")]
[DouyinRetCode(50002,"业务处理失败","62303013:取消状态跃迁失败","isv.business-failed:62303013","取消状态跃迁失败")]
[DouyinRetCode(50002,"业务处理失败","1001:业务处理失败","isv.business-failed:1001","业务处理失败")]
[DouyinRetCode(50002,"业务处理失败","4004:已经出库，仓库无法取消，若需要取消发货，请发起快递拦截！","isv.business-failed:4004","请发起快递拦截")]
[DouyinRetCode(50002,"业务处理失败","4001:outbound order not found","isv.business-failed:4001","出库单未找到")]
[DouyinRetCode(50002,"业务处理失败","14000:已经出库，仓库无法取消，若需要取消发货，请发起快递拦截！","isv.business-failed:14000","请发起快递拦截")]
[DouyinRetCode(20001,"内部服务超时","1103:调用接口超时，请重试！","isp.service-timeout-error:1103","请重试")]
[DouyinRetCode(50002,"业务处理失败","4005:unsupported outbound operation error","isv.business-failed:4005","不支持的出库操作")]
[DouyinRetCode(50002,"业务处理失败","62302628:取消异常,订单下不存在此erp单号，请确认","isv.business-failed:62302628","确认erp单号")]
[DouyinRetCode(50002,"业务处理失败","100100:货主和店铺绑定关系不存在，请在scm进行货主和店铺关系绑定后重推数据！","isv.business-failed:100100","货主和店铺绑定关系不存在，请在scm进行货主和店铺关系绑定后重推数据！")]
[DouyinRetCode(50002,"业务处理失败","1005:invoke remote failed","isv.business-failed:1005","invoke remote failed")]
public class YuncCloudCancelOutboundOrderReq : IDouyinReq<YuncCloudCancelOutboundOrderRsp>
{

	public string GetMethod() { return "yunc.cloudCancelOutboundOrder"; }

	public string GetUrl() { return "/yunc/cloudCancelOutboundOrder"; }

	[JsonPropertyName("erp_order_no")]
	[Description("ERP出库单号")]
	[NotNull]
	public string ErpOrderNo { get; set; }

	[JsonPropertyName("op_type")]
	[Description("操作类型 0:取消 1：拦截")]
	[NotNull]
	public int? OpType { get; set; }

	[JsonPropertyName("cancel_tag")]
	[Description("操作类型")]
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
		[Description("出库单行号")]
		public string LineNo { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("货品编码")]
		public string CargoCode { get; set; }

		[JsonPropertyName("erp_sku_id")]
		[Description("ERP商品编码")]
		public string ErpSkuId { get; set; }

		[JsonPropertyName("cancel_amount")]
		[Description("取消数量")]
		public int? CancelAmount { get; set; }
	}

	[JsonPropertyName("platform_order_no")]
	[Description("平台交易单号")]
	[NotNull]
	public string PlatformOrderNo { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	public string OwnerCode { get; set; }
}

[Description("云仓出库取消")]
public class YuncCloudCancelOutboundOrderRsp
{
	[JsonPropertyName("data")]
	[Description("响应数据")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("logistics_no")]
		[Description("物流单号")]
		public string LogisticsNo { get; set; }
	}
}
