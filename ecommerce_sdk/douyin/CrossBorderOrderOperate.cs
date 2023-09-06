namespace ecommerce.sdk.douyin;

[Description("服务商回传仓储")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","2018:此订单已开始拦截，请核实订单状态","isv.business-failed:2018","先回传拦截状态")]
[DouyinRetCode(50002,"业务处理失败","2019:此订单处于拦截中，请核实订单状态","isv.business-failed:2019","先回传拦截状态")]
[DouyinRetCode(50002,"业务处理失败","2020:订单已拦截成功，请核实订单状态","isv.business-failed:2020","核实订单状态")]
[DouyinRetCode(50002,"业务处理失败","1004:节点时序状态有误","isv.business-failed:1004","节点时序状态有误，请核实订单状态")]
[DouyinRetCode(50002,"业务处理失败","1005:参数不合法","isv.business-failed:1005","请核实请求参数")]
[DouyinRetCode(40004,"非法的参数","2013:包耗材信息错误","isv.parameter-invalid:2013","核实包耗材信息")]
[DouyinRetCode(40004,"非法的参数","1002:参数不合法","isv.parameter-invalid:1002","请核实请求参数")]
[DouyinRetCode(50002,"业务处理失败","2022:biz error code [2022] message 时间格式错误","isv.business-failed:2022","时间格式错误,请修改时间格式")]
[DouyinRetCode(50002,"业务处理失败","2021:biz error code [2021] message 接单失败异常编码不符合平台规范，请核实后重试","isv.business-failed:2021","接单失败异常编码不符合平台规范，请核实后重试")]
[DouyinRetCode(50002,"业务处理失败","1234:biz error code [1234] message 相同LO已在处理中","isv.business-failed:1234","重试")]
[DouyinRetCode(50002,"业务处理失败","1204:系统内部错误","isv.business-failed:1204","系统内部错误")]
[DouyinRetCode(50002,"业务处理失败","1003:当前订单为自研单据，不允许回传【订单开始拣货】","isv.business-failed:1003","自研单据不允许回传")]
[DouyinRetCode(50002,"业务处理失败","1001:服务商鉴权失败","isv.business-failed:1001","服务商鉴权失败")]
public class CrossBorderOrderOperateReq : IDouyinReq<CrossBorderOrderOperateRsp>
{

	public string GetMethod() { return "crossBorder.orderOperate"; }

	public string GetUrl() { return "/crossBorder/orderOperate"; }

	[JsonPropertyName("order_id")]
	[Description("字节电商平台的交易订单号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("vendor")]
	[Description("字节给供应链服务商定义的编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("status")]
	[Description("仓储作业状态：1入库 2打包 3 发货成功 4出库失败 6订单开始拣货 7订单拣货完成 9接单成功 10接单失败")]
	[NotNull]
	public long? Status { get; set; }

	[JsonPropertyName("occurrence_time")]
	[Description("物流状态的真实发生时间，时间戳，单位秒")]
	[NotNull]
	public string OccurrenceTime { get; set; }

	[JsonPropertyName("transportation")]
	[Description("国内物流信息(注意：如果提供了这块信息，domestic_carrier/domestic_trans_no/domestic_ship_address是必传的；对于接单成功事件，集货场景下必传，备货场景下可不传；对于出库完成事件，快递公司编码domestic_carrier和运单号domestic_trans_no必填且必须匹配，4PL=T时快递公司编码必须与下发时一致或者在兜底公司列表，4PL=T&仓配分拆=T时快递公司编码和运单号必须与下发时一致)")]
	public TransportationItem Transportation { get; set; }

	public class TransportationItem
	{
		[JsonPropertyName("domestic_carrier")]
		[Description("国内快递公司编码 按字节定义的编码推送")]
		public string DomesticCarrier { get; set; }

		[JsonPropertyName("domestic_trans_no")]
		[Description("国内运单号（BBC/BC/CC/UPU）")]
		public string DomesticTransNo { get; set; }

		[JsonPropertyName("domestic_ship_address")]
		[Description("国内发货地址（国内快递揽收地址）")]
		public string DomesticShipAddress { get; set; }

		[JsonPropertyName("product_num")]
		[Description("商品件数")]
		public long? ProductNum { get; set; }

		[JsonPropertyName("mark")]
		[Description("快递公司大头笔，便于快速识别地址")]
		public string Mark { get; set; }

		[JsonPropertyName("waybill")]
		[Description("PDF格式的电子面单URL")]
		public string Waybill { get; set; }

		[JsonPropertyName("delivery_name")]
		[Description("发货人name")]
		public string DeliveryName { get; set; }

		[JsonPropertyName("delivery_tel")]
		[Description("发货人电话")]
		public string DeliveryTel { get; set; }
	}

	[JsonPropertyName("package")]
	[Description("包裹信息")]
	public PackageItem Package { get; set; }

	public class PackageItem
	{
		[JsonPropertyName("packing_materials")]
		[Description("包材信息，原则上只需回传1个")]
		[NotNull]
		public List<PackingMaterialsItem> PackingMaterials { get; set; }

		public class PackingMaterialsItem
		{
			[JsonPropertyName("packing_material_code")]
			[Description("包材编码")]
			[NotNull]
			public string PackingMaterialCode { get; set; }

			[JsonPropertyName("packing_material_name")]
			[Description("包材名称")]
			[NotNull]
			public string PackingMaterialName { get; set; }

			[JsonPropertyName("packing_material_num")]
			[Description("包材数量")]
			[NotNull]
			public long? PackingMaterialNum { get; set; }
		}

		[JsonPropertyName("consumables_materials")]
		[Description("耗材信息")]
		public List<ConsumablesMaterialsItem> ConsumablesMaterials { get; set; }

		public class ConsumablesMaterialsItem
		{
			[JsonPropertyName("consumables_code")]
			[Description("耗材编码")]
			public string ConsumablesCode { get; set; }

			[JsonPropertyName("consumables_name")]
			[Description("耗材名称")]
			public string ConsumablesName { get; set; }

			[JsonPropertyName("consumables_num")]
			[Description("耗材数量")]
			public long? ConsumablesNum { get; set; }
		}

		[JsonPropertyName("package_weight")]
		[Description("包裹重量,单位g")]
		[NotNull]
		public long? PackageWeight { get; set; }

		[JsonPropertyName("package_items")]
		[Description("包裹明细信息")]
		public List<PackageItemsItem> PackageItems { get; set; }

		public class PackageItemsItem
		{
			[JsonPropertyName("item_id")]
			[Description("货品编码")]
			public string ItemId { get; set; }

			[JsonPropertyName("sku_id")]
			[Description("平台sku编号")]
			public long? SkuId { get; set; }

			[JsonPropertyName("item_no")]
			[Description("外部服务商货品编码")]
			public string ItemNo { get; set; }

			[JsonPropertyName("inventory_type")]
			[Description("库存类型,正品-1，残次-2")]
			public long? InventoryType { get; set; }

			[JsonPropertyName("quantity")]
			[Description("数量")]
			public long? Quantity { get; set; }

			[JsonPropertyName("batch_info")]
			[Description("批属性")]
			public BatchInfoItem BatchInfo { get; set; }

			public class BatchInfoItem
			{
				[JsonPropertyName("batch_number")]
				[Description("批次号")]
				public string BatchNumber { get; set; }

				[JsonPropertyName("product_date")]
				[Description("生产日期 秒级时间戳")]
				public long? ProductDate { get; set; }

				[JsonPropertyName("expire_date")]
				[Description("失效日期 秒级时间戳")]
				public long? ExpireDate { get; set; }

				[JsonPropertyName("receipt_date")]
				[Description("入库日期 秒级时间戳")]
				public long? ReceiptDate { get; set; }

				[JsonPropertyName("supplier_id")]
				[Description("供应商")]
				public string SupplierId { get; set; }

				[JsonPropertyName("scm_inbound_order")]
				[Description("SCM入库单号")]
				public string ScmInboundOrder { get; set; }

				[JsonPropertyName("lot_id")]
				[Description("批次id")]
				public string LotId { get; set; }

				[JsonPropertyName("batch_extend")]
				[Description("批次扩展字段，json格式")]
				public string BatchExtend { get; set; }
			}

			[JsonPropertyName("line_no")]
			[Description("行号")]
			public string LineNo { get; set; }
		}
	}

	[JsonPropertyName("error_info")]
	[Description("异常信息（【发货失败】状态时，必须提供）")]
	public ErrorInfoItem ErrorInfo { get; set; }

	public class ErrorInfoItem
	{
		[JsonPropertyName("error_code")]
		[Description("发货失败或者接单失败异常码")]
		public string ErrorCode { get; set; }

		[JsonPropertyName("error_msg")]
		[Description("详细失败原因")]
		public string ErrorMsg { get; set; }
	}

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	public string WarehouseCode { get; set; }
}

[Description("服务商回传仓储")]
public class CrossBorderOrderOperateRsp
{
}
