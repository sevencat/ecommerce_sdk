namespace ecommerce.sdk.douyin;

[Description("通过售后单ID或者渠道交易单ID查询售后明细")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","业务处理失败","isv.business-failed:1000","重试")]
[DouyinRetCode(20000,"系统错误","业务处理失败（可以直接展示给用户）","isp.service-error:1040","根据提示处理")]
[DouyinRetCode(40004,"非法的参数","参数问题","isv.parameter-invalid:1020","修改参数")]
public class SupplyChainQueryReturnOrderByOrderNoReq : IDouyinReq<SupplyChainQueryReturnOrderByOrderNoRsp>
{

	public string GetMethod() { return "supplyChain.queryReturnOrderByOrderNo"; }

	public string GetUrl() { return "/supplyChain/queryReturnOrderByOrderNo"; }

	[JsonPropertyName("after_sale_order_no")]
	[Description("售后单号，一定要注意是售后单号。 与渠道单号不能同时为空")]
	public string AfterSaleOrderNo { get; set; }

	[JsonPropertyName("channel_trade_order_no")]
	[Description("渠道交易单号，与售后单号不能同时为空")]
	public string ChannelTradeOrderNo { get; set; }
}

[Description("通过售后单ID或者渠道交易单ID查询售后明细")]
public class SupplyChainQueryReturnOrderByOrderNoRsp
{
	[JsonPropertyName("code")]
	[Description("是否成功")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("接口是否成功")]
	public string Msg { get; set; }

	[JsonPropertyName("return_order_info_list")]
	[Description("售后单列表")]
	public List<ReturnOrderInfoListItem> ReturnOrderInfoList { get; set; }

	public class ReturnOrderInfoListItem
	{
		[JsonPropertyName("order_dto")]
		[Description("供销售后单信息")]
		public OrderDtoItem OrderDto { get; set; }

		public class OrderDtoItem
		{
			[JsonPropertyName("supply_order_amount")]
			[Description("供货单金额")]
			public long SupplyOrderAmount { get; set; }

			[JsonPropertyName("standard_order_status")]
			[Description("订单标准状态；1-待抖店同意退款，2-待供应商同意退款，3-待买家退货，4-待供应商收货，5-退款中，6-退款成功，7-售后仲裁中，20-售后取消，21-售后关闭，22-售后拒绝")]
			public int StandardOrderStatus { get; set; }

			[JsonPropertyName("return_order_no")]
			[Description("退货单号")]
			public string ReturnOrderNo { get; set; }

			[JsonPropertyName("return_order_type")]
			[Description("订单业务类型（分销场景固定）")]
			public long ReturnOrderType { get; set; }

			[JsonPropertyName("out_order_id")]
			[Description("抖店售后单ID")]
			public string OutOrderId { get; set; }

			[JsonPropertyName("channel_code")]
			[Description("渠道编码,使用方无需理解")]
			public string ChannelCode { get; set; }

			[JsonPropertyName("reverse_type")]
			[Description("售后类型；1-售后退货退款，3-售后退款")]
			public long ReverseType { get; set; }

			[JsonPropertyName("supplier_id")]
			[Description("供应商ID")]
			public long SupplierId { get; set; }

			[JsonPropertyName("supplier_name")]
			[Description("供应商名称")]
			public string SupplierName { get; set; }

			[JsonPropertyName("distributor_id")]
			[Description("分销商ID")]
			public long DistributorId { get; set; }

			[JsonPropertyName("distributor_name")]
			[Description("分销商名称")]
			public string DistributorName { get; set; }

			[JsonPropertyName("trade_order_no")]
			[Description("渠道交易单号，正向单的主单号")]
			public string TradeOrderNo { get; set; }

			[JsonPropertyName("creator")]
			[Description("操作人信息")]
			public CreatorItem Creator { get; set; }

			public class CreatorItem
			{
				[JsonPropertyName("operator_id")]
				[Description("操作人ID")]
				public long OperatorId { get; set; }

				[JsonPropertyName("operator_name")]
				[Description("操作人")]
				public string OperatorName { get; set; }

				[JsonPropertyName("operator_role")]
				[Description("角色")]
				public int OperatorRole { get; set; }

				[JsonPropertyName("operate_time")]
				[Description("时间")]
				public long OperateTime { get; set; }
			}

			[JsonPropertyName("return_sku_cnt")]
			[Description("逆向sku个数")]
			public int ReturnSkuCnt { get; set; }

			[JsonPropertyName("return_total_cnt")]
			[Description("逆向总件数")]
			public int ReturnTotalCnt { get; set; }

			[JsonPropertyName("return_total_amount")]
			[Description("逆向总金额")]
			public long ReturnTotalAmount { get; set; }

			[JsonPropertyName("settlement_method")]
			[Description("结算方式,0-不结算,1-担保交易,2-代销分账")]
			public long SettlementMethod { get; set; }

			[JsonPropertyName("order_status")]
			[Description("单据状态。,CANCEL=-1 已取消,REFUSE=-2   拒绝,DRAFT=0 售后单初始化完成,FAILED=90 售后失败,CREATED=100 售后单创建完成,FULFILLING=101 售后单履约中(待系统确认),,ALLOW_REFUND=145 允许供应商操作,AGREE_REFUND=150 同意退款,WAIT_RETURN=205 待买家退货,(商家同意退货),,RETURNED_WAIT_COLLECT=210 售后退货完成,待商家确认收货,并等待退款,,RETURNED_AND_COLLECTED=220 售后退货完成,商家确认收货,但等待退款,,SUCCESS=310 售后成功,退货退款全部完成")]
			public long OrderStatus { get; set; }

			[JsonPropertyName("view_status")]
			[Description("售后业务视图状态")]
			public long ViewStatus { get; set; }

			[JsonPropertyName("refund_status")]
			[Description("退款状态,1-待退款,2-已退款,3-退款中,4-已退款（扣货款）,5-已退款（扣保证金）")]
			public long RefundStatus { get; set; }

			[JsonPropertyName("extends")]
			[Description("扩展信息")]
			public Dictionary<string,string> Extends { get; set; }

			[JsonPropertyName("refuse_reason")]
			[Description("拒绝原因")]
			public string RefuseReason { get; set; }

			[JsonPropertyName("details")]
			[Description("售后货品明细")]
			public List<DetailsItem> Details { get; set; }

			public class DetailsItem
			{
				[JsonPropertyName("detail_no")]
				[Description("明细ID")]
				public string DetailNo { get; set; }

				[JsonPropertyName("distributor_sku_id")]
				[Description("分销品ID")]
				public long DistributorSkuId { get; set; }

				[JsonPropertyName("distributor_sku_name")]
				[Description("分销品名称")]
				public string DistributorSkuName { get; set; }

				[JsonPropertyName("product_id")]
				[Description("商品ID（不保证数据准确性）")]
				public long ProductId { get; set; }

				[JsonPropertyName("product_name")]
				[Description("商品名称")]
				public string ProductName { get; set; }

				[JsonPropertyName("product_specs")]
				[Description("商品规格")]
				public List<ProductSpecsItem> ProductSpecs { get; set; }

				public class ProductSpecsItem
				{
					[JsonPropertyName("name")]
					[Description("规格名称")]
					public string Name { get; set; }

					[JsonPropertyName("value")]
					[Description("规格值")]
					public string Value { get; set; }
				}

				[JsonPropertyName("supply_price")]
				[Description("供货单价")]
				public long SupplyPrice { get; set; }

				[JsonPropertyName("sale_price")]
				[Description("销售价")]
				public long SalePrice { get; set; }

				[JsonPropertyName("plan_cnt")]
				[Description("计划数量")]
				public int PlanCnt { get; set; }

				[JsonPropertyName("real_cnt")]
				[Description("实际数量")]
				public int RealCnt { get; set; }

				[JsonPropertyName("apply_cnt")]
				[Description("申请售后数量")]
				public int ApplyCnt { get; set; }

				[JsonPropertyName("extends")]
				[Description("扩展信息")]
				public Dictionary<string,string> Extends { get; set; }
			}

			[JsonPropertyName("create_time")]
			[Description("创建时间")]
			public long CreateTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("更新时间")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("exp_return_time")]
			[Description("期望退货时间,超时自动同意退货")]
			public long ExpReturnTime { get; set; }

			[JsonPropertyName("exp_refund_time")]
			[Description("期望退款时间,超时自动同意退款(仅退款)，超时自动确认收货(退货退款)")]
			public long ExpRefundTime { get; set; }

			[JsonPropertyName("refund_remaining_time")]
			[Description("剩余的退款处理时间(期望退款时间 - now)")]
			public long RefundRemainingTime { get; set; }

			[JsonPropertyName("is_finished")]
			[Description("是否完成")]
			public bool IsFinished { get; set; }

			[JsonPropertyName("exp_cancel_time")]
			[Description("期望取消时间")]
			public long ExpCancelTime { get; set; }

			[JsonPropertyName("cancel_remaining_time")]
			[Description("驱动到取消剩余时间")]
			public long CancelRemainingTime { get; set; }

			[JsonPropertyName("allow_re_apply_time")]
			[Description("允许再次申请售后时间")]
			public long AllowReApplyTime { get; set; }

			[JsonPropertyName("allow_re_start_time")]
			[Description("允许再次发起售后时间")]
			public long AllowReStartTime { get; set; }

			[JsonPropertyName("show_add_inventory_tab")]
			[Description("无")]
			public bool ShowAddInventoryTab { get; set; }

			[JsonPropertyName("max_allow_refund_amount")]
			[Description("允许最大退款金额")]
			public long MaxAllowRefundAmount { get; set; }

			[JsonPropertyName("settlement_time")]
			[Description("结算时间")]
			public long SettlementTime { get; set; }

			[JsonPropertyName("settlement_no")]
			[Description("结算单号")]
			public string SettlementNo { get; set; }

			[JsonPropertyName("reverse_logistic_list")]
			[Description("退款物流信息")]
			public List<ReverseLogisticListItem> ReverseLogisticList { get; set; }

			public class ReverseLogisticListItem
			{
				[JsonPropertyName("tracking_no")]
				[Description("物流单号")]
				public string TrackingNo { get; set; }

				[JsonPropertyName("tms_code")]
				[Description("物流服务商编码")]
				public string TmsCode { get; set; }
			}
		}

		[JsonPropertyName("shop_after_sale_order_info")]
		[Description("抖店售后单信息")]
		public ShopAfterSaleOrderInfoItem ShopAfterSaleOrderInfo { get; set; }

		public class ShopAfterSaleOrderInfoItem
		{
			[JsonPropertyName("refund_amount")]
			[Description("售后申请金额（分）")]
			public long RefundAmount { get; set; }

			[JsonPropertyName("real_refund_amount")]
			[Description("售后已退金额（分）")]
			public long RealRefundAmount { get; set; }

			[JsonPropertyName("after_sale_status")]
			[Description("售后状态")]
			public long AfterSaleStatus { get; set; }

			[JsonPropertyName("arbitrate_status")]
			[Description("仲裁结果")]
			public long ArbitrateStatus { get; set; }

			[JsonPropertyName("remit_amount")]
			[Description("小额打款金额")]
			public long RemitAmount { get; set; }

			[JsonPropertyName("after_sale_type")]
			[Description("售后类型")]
			public long AfterSaleType { get; set; }

			[JsonPropertyName("after_sale_item_count")]
			[Description("售后申请数量")]
			public long AfterSaleItemCount { get; set; }

			[JsonPropertyName("after_sale_reason_code")]
			[Description("售后编码")]
			public string AfterSaleReasonCode { get; set; }

			[JsonPropertyName("after_sale_reason")]
			[Description("售后原因")]
			public string AfterSaleReason { get; set; }

			[JsonPropertyName("evidence_pic_list")]
			[Description("上传的凭证")]
			public List<string> EvidencePicList { get; set; }

			[JsonPropertyName("apply_reject_reason")]
			[Description("申请拒绝原因")]
			public string ApplyRejectReason { get; set; }

			[JsonPropertyName("logistics_reject_reason")]
			[Description("物流拒绝原因")]
			public string LogisticsRejectReason { get; set; }

			[JsonPropertyName("reject_evidence")]
			[Description("拒绝凭证")]
			public List<string> RejectEvidence { get; set; }

			[JsonPropertyName("remit_order_info_list")]
			[Description("小额打款信息列表")]
			public List<RemitOrderInfoListItem> RemitOrderInfoList { get; set; }

			public class RemitOrderInfoListItem
			{
				[JsonPropertyName("product_id")]
				[Description("商品ID")]
				public string ProductId { get; set; }

				[JsonPropertyName("product_name")]
				[Description("商品名称")]
				public string ProductName { get; set; }

				[JsonPropertyName("remit_amount")]
				[Description("打款金额")]
				public long RemitAmount { get; set; }

				[JsonPropertyName("create_time")]
				[Description("创建时间")]
				public long CreateTime { get; set; }

				[JsonPropertyName("finish_time")]
				[Description("完成时间")]
				public long FinishTime { get; set; }

				[JsonPropertyName("remit_user_name")]
				[Description("空")]
				public string RemitUserName { get; set; }

				[JsonPropertyName("status")]
				[Description("空")]
				public string Status { get; set; }

				[JsonPropertyName("remit_type")]
				[Description("空")]
				public string RemitType { get; set; }

				[JsonPropertyName("shop_order_no")]
				[Description("空")]
				public string ShopOrderNo { get; set; }
			}
		}
	}
}
