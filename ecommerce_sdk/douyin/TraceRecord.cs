namespace ecommerce.sdk.douyin;

[Description("在订单链路监控场景中，回传轨迹信息。 信息回传后能自动记录并统计监控状态信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误,订单不存在","isv.parameter-invalid:605090050","填写正确的订单ID")]
[DouyinRetCode(40004,"非法的参数","当前用户已关闭订单轨迹服务","isv.parameter-invalid:605090005","可调用/trace/addShop接口重新开通")]
[DouyinRetCode(40004,"非法的参数","当前用户授权已过期，轨迹记录服务自动关闭","isv.parameter-invalid:605090006","店铺对App重新授权后自动开启")]
[DouyinRetCode(40004,"非法的参数","参数错误, 未定义的Status","isv.parameter-invalid:605090013","请填写正确的Status")]
[DouyinRetCode(40004,"非法的参数","参数错误，RecordTime格式不正确","isv.parameter-invalid:605090014","业务时间格式为：2022-11-30 10:52:53")]
[DouyinRetCode(40004,"非法的参数","轨迹信息已回传,请不要重复处理,系统将使用第一次回传记录","isv.parameter-invalid:605090015","无需处理，系统将采用第一次回传记录")]
[DouyinRetCode(40004,"非法的参数","轨迹信息异常, 订单状态回传不正确,下一状态应为**","isv.parameter-invalid:605090021","请填写正确的Status")]
[DouyinRetCode(40004,"非法的参数","轨迹信息异常, 订单缺少前置状态","isv.parameter-invalid:605090020","请填写正确的Status")]
[DouyinRetCode(40004,"非法的参数","轨迹信息异常, 订单当前状态业务时间晚于前置状态","isv.parameter-invalid:605090022","请填写正确的业务时间")]
[DouyinRetCode(20000,"系统错误","内部服务异常，请稍后重试","isp.service-error:605090001","内部服务异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","参数错误，RecordTime不能早于当前时间","isv.parameter-invalid:605090023","请填写正确的业务时间")]
[DouyinRetCode(40004,"非法的参数","当前应用与店铺间授权失效，请检查店铺授权","isv.parameter-invalid:605010102","请引导店铺重新对应用授权")]
public class TraceRecordReq : IDouyinReq<TraceRecordRsp>
{

	public string GetMethod() { return "trace.record"; }

	public string GetUrl() { return "/trace/record"; }

	[JsonPropertyName("order_id")]
	[Description("订单ID")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("status")]
	[Description("轨迹状态。ERP_TRANSFER(ERP完成转单)，ERP_CHECK(ERP完成审单)，CP_NOTIFY(ERP完成通知仓储配货)，ACCEPT(仓库接单完成)，PRINT(仓库完成打印拣货单)，PICK(仓库完成拣货)，CHECK(拣货复核完成)，PACKAGE(仓库完成打包)，CONFIRM(仓库通知ERP出货)")]
	[NotNull]
	public string Status { get; set; }

	[JsonPropertyName("record_time")]
	[Description("业务动作发生时间；格式：yyyy-MM-dd HH:mm:ss")]
	[NotNull]
	public string RecordTime { get; set; }

	[JsonPropertyName("ext_info")]
	[Description("扩展信息")]
	public ExtInfoItem ExtInfo { get; set; }

	public class ExtInfoItem
	{
		[JsonPropertyName("out_operator")]
		[Description("当前操作人")]
		public string OutOperator { get; set; }

		[JsonPropertyName("out_wms_app")]
		[Description("关联wms的app信息")]
		public string OutWmsApp { get; set; }

		[JsonPropertyName("out_customer_id")]
		[Description("货主在wms的身份标识")]
		public string OutCustomerId { get; set; }

		[JsonPropertyName("remark")]
		[Description("备注信息")]
		public string Remark { get; set; }
	}

	[JsonPropertyName("warehouse_code")]
	[Description("仓编码")]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("product_list")]
	[Description("仓商品信息")]
	public List<ProductListItem> ProductList { get; set; }

	public class ProductListItem
	{
		[JsonPropertyName("sku_order_id")]
		[Description("子订单ID")]
		[NotNull]
		public string SkuOrderId { get; set; }

		[JsonPropertyName("count")]
		[Description("商品数量")]
		[NotNull]
		public long? Count { get; set; }

		[JsonPropertyName("sub_product_info_list")]
		[Description("组套商品信息，非组套商品请勿传入")]
		public List<SubProductInfoListItem> SubProductInfoList { get; set; }

		public class SubProductInfoListItem
		{
			[JsonPropertyName("sku_id")]
			[Description("商品SkuId")]
			[NotNull]
			public string SkuId { get; set; }

			[JsonPropertyName("product_id")]
			[Description("商品Id")]
			[NotNull]
			public string ProductId { get; set; }

			[JsonPropertyName("count")]
			[Description("商品数量")]
			[NotNull]
			public long? Count { get; set; }
		}
	}
}

[Description("在订单链路监控场景中，回传轨迹信息。 信息回传后能自动记录并统计监控状态信息")]
public class TraceRecordRsp
{
}
