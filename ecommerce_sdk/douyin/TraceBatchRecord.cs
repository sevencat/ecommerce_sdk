namespace ecommerce.sdk.douyin;

[Description("在订单链路监控场景中，批量(最大20条)回传轨迹信息。 信息回传后能自动记录并统计监控状态信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数缺失，OrderId格式不正确","isv.parameter-invalid:605090016","请填写正确的OrderId")]
[DouyinRetCode(40004,"非法的参数","参数缺失，Status格式不正确","isv.parameter-invalid:605090017","请填写正确的Status")]
[DouyinRetCode(40004,"非法的参数","参数错误，RecordTime格式不正确[orderId=%s]","isv.parameter-invalid:605090018","请填写正确的RecordTime")]
[DouyinRetCode(40004,"非法的参数","参数错误，RecordTime不能早于当前时间","isv.parameter-invalid:605090023","请填写正确的RecordTime")]
[DouyinRetCode(20000,"系统错误","内部服务异常，请稍后重试","isp.service-error:605090001","内部服务异常，请稍后重试")]
[DouyinRetCode(40004,"非法的参数","参数错误,订单不存在","isv.parameter-invalid:605090050","请填写正确的OrderId")]
[DouyinRetCode(40004,"非法的参数","当前用户已关闭订单轨迹服务","isv.parameter-invalid:605090005","可调用/trace/addShop接口重新开通")]
[DouyinRetCode(40004,"非法的参数","当前用户授权已过期，轨迹记录服务自动关闭","isv.parameter-invalid:605090006","店铺对App重新授权后自动开启")]
public class TraceBatchRecordReq : IDouyinReq<TraceBatchRecordRsp>
{

	public string GetMethod() { return "trace.batchRecord"; }

	public string GetUrl() { return "/trace/batchRecord"; }

	[JsonPropertyName("trace_list")]
	[Description("轨迹信息列表")]
	[NotNull]
	public List<TraceListItem> TraceList { get; set; }

	public class TraceListItem
	{
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
			[Description("子商品信息")]
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
}

[Description("在订单链路监控场景中，批量(最大20条)回传轨迹信息。 信息回传后能自动记录并统计监控状态信息")]
public class TraceBatchRecordRsp
{
	[JsonPropertyName("error_traces")]
	[Description("有错误的轨迹信息。如无错误，则不返回")]
	public List<ErrorTracesItem> ErrorTraces { get; set; }

	public class ErrorTracesItem
	{
		[JsonPropertyName("order_id")]
		[Description("订单ID")]
		public string OrderId { get; set; }

		[JsonPropertyName("status")]
		[Description("轨迹业务状态")]
		public string Status { get; set; }

		[JsonPropertyName("status_message")]
		[Description("错误信息")]
		public string StatusMessage { get; set; }

		[JsonPropertyName("status_code")]
		[Description("错误码")]
		public int StatusCode { get; set; }
	}
}
