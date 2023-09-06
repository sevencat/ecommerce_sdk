namespace ecommerce.sdk.douyin;

[Description("入库回告")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","13003:更新库存失败","isv.business-failed:13003","请重试")]
[DouyinRetCode(40002,"缺少必选参数","outBizCode is required","isv.missing-parameter:13000","部分收货（分批次回传）的场景，OutBizCode需必传，请填充该字段后重试")]
[DouyinRetCode(50002,"业务处理失败","order not found","isv.business-failed:13001","请检查入库单号后重试")]
[DouyinRetCode(50002,"业务处理失败","仓库编码鉴权失败，操作仓和鉴权仓不一致","isv.business-failed:1003","检查操作仓Code")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:1004","检查报错")]
[DouyinRetCode(40002,"缺少必选参数","参数错误","isv.missing-parameter:1001","检查参数重新回传")]
public class YuncWmsInboundCallbackReq : IDouyinReq<YuncWmsInboundCallbackRsp>
{

	public string GetMethod() { return "yunc.wmsInboundCallback"; }

	public string GetUrl() { return "/yunc/wmsInboundCallback"; }

	[JsonPropertyName("inbound_order_no")]
	[Description("字段长度(64)：入库单号")]
	[NotNull]
	public string InboundOrderNo { get; set; }

	[JsonPropertyName("order_type")]
	[Description("字段长度(8)：单据类型，CGSH：常规售货，CGRK：采购入库，DBRK：调拨入库，XTRK：销退入库")]
	[NotNull]
	public string OrderType { get; set; }

	[JsonPropertyName("status")]
	[Description("状态，0：预创建，1：已创建，2：作业中，3：已完成，4：已取消，5：上架完成")]
	[NotNull]
	public short? Status { get; set; }

	[JsonPropertyName("operate_time")]
	[Description("作业时间")]
	[NotNull]
	public long? OperateTime { get; set; }

	[JsonPropertyName("operator")]
	[Description("字段长度(32)：操作人")]
	[NotNull]
	public string Operator { get; set; }

	[JsonPropertyName("reamrk")]
	[Description("字段长度(200)：备注")]
	public string Reamrk { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("字段长度(16)：仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("details")]
	[Description("明细")]
	[NotNull]
	public List<DetailsItem> Details { get; set; }

	public class DetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("字段长度(32)：行号")]
		[NotNull]
		public string LineNo { get; set; }

		[JsonPropertyName("inbound_order_no")]
		[Description("字段长度(64)：单号")]
		[NotNull]
		public string InboundOrderNo { get; set; }

		[JsonPropertyName("sn_list")]
		[Description("字段长度(1024)：唯一码")]
		public string SnList { get; set; }

		[JsonPropertyName("total_qty")]
		[Description("累计实收")]
		[NotNull]
		public int? TotalQty { get; set; }

		[JsonPropertyName("received_qty")]
		[Description("本次实收")]
		[NotNull]
		public int? ReceivedQty { get; set; }

		[JsonPropertyName("batch_code")]
		[Description("字段长度(64)：批次编码")]
		public string BatchCode { get; set; }

		[JsonPropertyName("product_date")]
		[Description("生产时间")]
		public long? ProductDate { get; set; }

		[JsonPropertyName("expire_date")]
		[Description("过期时间")]
		public long? ExpireDate { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("库存类型")]
		[NotNull]
		public short? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态，1 正常 2 质检 3 冻结")]
		[NotNull]
		public short? InventoryStatus { get; set; }

		[JsonPropertyName("remark")]
		[Description("字段长度(1024)：备注")]
		public string Remark { get; set; }

		[JsonPropertyName("extend")]
		[Description("字段长度(2048)：扩展字段")]
		public string Extend { get; set; }

		[JsonPropertyName("owner_code")]
		[Description("字段长度(32)：货主编码")]
		[NotNull]
		public string OwnerCode { get; set; }

		[JsonPropertyName("batch_info")]
		[Description("批属性(20220715增加)")]
		public BatchInfoItem BatchInfo { get; set; }

		public class BatchInfoItem
		{
			[JsonPropertyName("batch_number")]
			[Description("字段长度(64)：批次号")]
			public string BatchNumber { get; set; }

			[JsonPropertyName("product_date")]
			[Description("生产日期")]
			public long? ProductDate { get; set; }

			[JsonPropertyName("expire_date")]
			[Description("失效日期")]
			public long? ExpireDate { get; set; }

			[JsonPropertyName("receipt_date")]
			[Description("入库日期")]
			public long? ReceiptDate { get; set; }

			[JsonPropertyName("supplier_id")]
			[Description("字段长度(64)：供应商ID")]
			public string SupplierId { get; set; }

			[JsonPropertyName("scm_inbound_order")]
			[Description("字段长度(64)：SCM入库单号")]
			public string ScmInboundOrder { get; set; }

			[JsonPropertyName("lot_id")]
			[Description("字段长度(64): 批次id")]
			public string LotId { get; set; }

			[JsonPropertyName("batch_extend")]
			[Description("字段长度(2048): 批次扩展字段，json结构")]
			public string BatchExtend { get; set; }
		}

		[JsonPropertyName("defect_reason")]
		[Description("残次品原因")]
		public DefectReasonItem DefectReason { get; set; }

		public class DefectReasonItem
		{
			[JsonPropertyName("code")]
			[Description("原因编码")]
			[NotNull]
			public string Code { get; set; }

			[JsonPropertyName("desc_msg")]
			[Description("描述信息")]
			[NotNull]
			public string DescMsg { get; set; }
		}
	}

	[JsonPropertyName("out_biz_code")]
	[Description("字段长度(64)：外部业务唯一键")]
	public string OutBizCode { get; set; }

	[JsonPropertyName("rejection_details")]
	[Description("拒收明细(20220715增加)")]
	public List<RejectionDetailsItem> RejectionDetails { get; set; }

	public class RejectionDetailsItem
	{
		[JsonPropertyName("line_no")]
		[Description("字段长度(32)：行号")]
		[NotNull]
		public string LineNo { get; set; }

		[JsonPropertyName("rejection_qty")]
		[Description("拒收数量")]
		[NotNull]
		public int? RejectionQty { get; set; }

		[JsonPropertyName("rejection_reason")]
		[Description("字段长度(200)：拒收原因")]
		public string RejectionReason { get; set; }

		[JsonPropertyName("rejection_remark")]
		[Description("字段长度(200)：拒收说明")]
		public string RejectionRemark { get; set; }
	}

	[JsonPropertyName("sign_detail")]
	[Description("到货登记信息")]
	public SignDetailItem SignDetail { get; set; }

	public class SignDetailItem
	{
		[JsonPropertyName("express")]
		[Description("快递公司")]
		[NotNull]
		public string Express { get; set; }

		[JsonPropertyName("way_bill_no")]
		[Description("快递单号")]
		[NotNull]
		public string WayBillNo { get; set; }

		[JsonPropertyName("driver")]
		[Description("送货人")]
		[NotNull]
		public string Driver { get; set; }

		[JsonPropertyName("plate_number")]
		[Description("车牌号")]
		[NotNull]
		public string PlateNumber { get; set; }

		[JsonPropertyName("contact_way")]
		[Description("联系方式")]
		[NotNull]
		public string ContactWay { get; set; }
	}

	[JsonPropertyName("event_type_remark")]
	[Description("字段长度(200)：作业节点说明")]
	public string EventTypeRemark { get; set; }

	[JsonPropertyName("picture_list")]
	[Description("销退入库时回传图片列表")]
	public List<string> PictureList { get; set; }

	[JsonPropertyName("abnormal_info_list")]
	[Description("异常信息列表")]
	public List<AbnormalInfoListItem> AbnormalInfoList { get; set; }

	public class AbnormalInfoListItem
	{
		[JsonPropertyName("abnormal_source")]
		[Description("字段长度(64)：来源，WMS，QMS")]
		[NotNull]
		public string AbnormalSource { get; set; }

		[JsonPropertyName("cargo_code")]
		[Description("字段长度(64)：货品编码")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("qty")]
		[Description("数量")]
		[NotNull]
		public long? Qty { get; set; }

		[JsonPropertyName("abnormal_info_type")]
		[Description("字段长度(64)：异常原因分类")]
		[NotNull]
		public string AbnormalInfoType { get; set; }

		[JsonPropertyName("abnormal_info_remark")]
		[Description("字段长度(200)：异常原因说明")]
		[NotNull]
		public string AbnormalInfoRemark { get; set; }

		[JsonPropertyName("abnormal_picture_list")]
		[Description("图片列表")]
		[NotNull]
		public List<string> AbnormalPictureList { get; set; }
	}
}

[Description("入库回告")]
public class YuncWmsInboundCallbackRsp
{
	[JsonPropertyName("code")]
	[Description("错误码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("异常信息")]
	public string Msg { get; set; }

	[JsonPropertyName("data")]
	[Description("data")]
	public string Data { get; set; }
}
