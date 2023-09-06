namespace ecommerce.sdk.douyin;

[Description("商家获取售后单详细信息。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误，售后单ID错误","isv.parameter-invalid:11000","检查参数后重试")]
[DouyinRetCode(20000,"系统错误","系统内部错误，请重试","isp.service-error:10000","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","返回内容为空，重试后若错误继续存在，请联系平台","isv.business-failed:10002","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","12000:无效的店铺ID，请检查此店铺ID是否正确并重试","isv.business-failed:12000","检查参数后重试")]
[DouyinRetCode(50002,"业务处理失败","12001:映射错误，当前操作不支持，适用于售后状态、类型、金额等校验未通过","isv.business-failed:12001","检查参数后重试")]
public class AfterSaleDetailReq : IDouyinReq<AfterSaleDetailRsp>
{

	public string GetMethod() { return "afterSale.Detail"; }

	public string GetUrl() { return "/afterSale/Detail"; }

	[JsonPropertyName("after_sale_id")]
	[Description("售后单ID")]
	[NotNull]
	public string AfterSaleId { get; set; }

	[JsonPropertyName("need_operation_record")]
	[Description("是否需要协商记录")]
	public bool? NeedOperationRecord { get; set; }
}

[Description("商家获取售后单详细信息。")]
public class AfterSaleDetailRsp
{
	[JsonPropertyName("process_info")]
	[Description("售后单及相关信息")]
	public ProcessInfoItem ProcessInfo { get; set; }

	public class ProcessInfoItem
	{
		[JsonPropertyName("after_sale_info")]
		[Description("售后单信息")]
		public AfterSaleInfoItem AfterSaleInfo { get; set; }

		public class AfterSaleInfoItem
		{
			[JsonPropertyName("after_sale_id")]
			[Description("售后单ID")]
			public long AfterSaleId { get; set; }

			[JsonPropertyName("after_sale_status")]
			[Description("售后状态：6-售后申请；7-售后退货中；8-【补寄,维修返回：售后待商家发货】；11-售后已发货；12-售后成功；13-【换货,补寄,维修返回：售后商家已发货，待用户收货】； 14-【换货,补寄,维修返回：售后用户已收货】 ；27-拒绝售后申请；28-售后失败；29-售后退货拒绝；51-订单取消成功；53-逆向交易已完成；")]
			public long AfterSaleStatus { get; set; }

			[JsonPropertyName("after_sale_status_desc")]
			[Description("售后状态文案")]
			public string AfterSaleStatusDesc { get; set; }

			[JsonPropertyName("refund_type")]
			[Description("退款方式")]
			public long RefundType { get; set; }

			[JsonPropertyName("refund_type_text")]
			[Description("退款方式文案")]
			public string RefundTypeText { get; set; }

			[JsonPropertyName("refund_status")]
			[Description("退款状态;1-待退款;2-退款中;3-退款成功;4退款失败;5追缴成功;")]
			public long RefundStatus { get; set; }

			[JsonPropertyName("refund_total_amount")]
			[Description("售后总金额（含运费）")]
			public long RefundTotalAmount { get; set; }

			[JsonPropertyName("refund_post_amount")]
			[Description("售后运费")]
			public long RefundPostAmount { get; set; }

			[JsonPropertyName("refund_promotion_amount")]
			[Description("退款补贴总金额（此字段只有退款成功后才会记录实际支付补贴回收的金额）")]
			public long RefundPromotionAmount { get; set; }

			[JsonPropertyName("apply_time")]
			[Description("售后单申请时间")]
			public long ApplyTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("售后单更新时间")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("reason")]
			[Description("申请原因")]
			public string Reason { get; set; }

			[JsonPropertyName("reason_code")]
			[Description("原因码；通过【afterSale/rejectReasonCodeList】接口获取")]
			public long ReasonCode { get; set; }

			[JsonPropertyName("after_sale_type")]
			[Description("售后类型： 0-售后退货退款；1-售后仅退款；2-发货前退款；3-换货；4-系统取消；5-用户取消；6-价保；7-补寄；8-维修")]
			public long AfterSaleType { get; set; }

			[JsonPropertyName("after_sale_type_text")]
			[Description("售后单类型文案")]
			public string AfterSaleTypeText { get; set; }

			[JsonPropertyName("reason_remark")]
			[Description("申请描述")]
			public string ReasonRemark { get; set; }

			[JsonPropertyName("evidence")]
			[Description("买家申请退款图片凭证；仅支持图片，最大返回8张图片。")]
			public List<string> Evidence { get; set; }

			[JsonPropertyName("after_sale_apply_count")]
			[Description("用户申请售后件数")]
			public long AfterSaleApplyCount { get; set; }

			[JsonPropertyName("need_return_count")]
			[Description("用户需退回件数, 数值为用户申请售后件数 - 商家未发货件数")]
			public long NeedReturnCount { get; set; }

			[JsonPropertyName("deduction_amount")]
			[Description("平台需要回收的金额（分）")]
			public long DeductionAmount { get; set; }

			[JsonPropertyName("disable_coupon_id")]
			[Description("作废的券ID")]
			public string DisableCouponId { get; set; }

			[JsonPropertyName("platform_discount_return_amount")]
			[Description("平台优惠退回金额")]
			public long PlatformDiscountReturnAmount { get; set; }

			[JsonPropertyName("platform_discount_return_status")]
			[Description("平台优惠退回状态，枚举：0:待退补贴；1:退补贴成功；2:退补贴失败")]
			public long PlatformDiscountReturnStatus { get; set; }

			[JsonPropertyName("kol_discount_return_amount")]
			[Description("达人优惠退回金额")]
			public long KolDiscountReturnAmount { get; set; }

			[JsonPropertyName("kol_discount_return_status")]
			[Description("达人优惠退回状态，枚举：0:待退补贴；1:退补贴成功；2:退补贴失败")]
			public long KolDiscountReturnStatus { get; set; }

			[JsonPropertyName("post_receiver")]
			[Description("换货、补寄时的收货人名字（只有换货、补寄时，这个字段才会有值），此字段已加密，使用前需要解密")]
			public string PostReceiver { get; set; }

			[JsonPropertyName("post_tel_sec")]
			[Description("换货、补寄时的收货人的联系电话（只有换货、补寄时，这个字段才会有值），此字段已加密，使用前需要解密")]
			public string PostTelSec { get; set; }

			[JsonPropertyName("post_address")]
			[Description("换货、补寄时的收货四级地址（只有换货、补寄时，这个字段才会有值）")]
			public PostAddressItem PostAddress { get; set; }

			public class PostAddressItem
			{
				[JsonPropertyName("province")]
				[Description("省")]
				public ProvinceItem Province { get; set; }

				public class ProvinceItem
				{
					[JsonPropertyName("id")]
					[Description("省ID")]
					public string Id { get; set; }

					[JsonPropertyName("name")]
					[Description("省名字")]
					public string Name { get; set; }
				}

				[JsonPropertyName("city")]
				[Description("市")]
				public CityItem City { get; set; }

				public class CityItem
				{
					[JsonPropertyName("id")]
					[Description("市ID")]
					public string Id { get; set; }

					[JsonPropertyName("name")]
					[Description("市名字")]
					public string Name { get; set; }
				}

				[JsonPropertyName("town")]
				[Description("县")]
				public TownItem Town { get; set; }

				public class TownItem
				{
					[JsonPropertyName("id")]
					[Description("县ID")]
					public string Id { get; set; }

					[JsonPropertyName("name")]
					[Description("县名字")]
					public string Name { get; set; }
				}

				[JsonPropertyName("detail")]
				[Description("地址详情，此字段已加密，使用前需要解密")]
				public string Detail { get; set; }

				[JsonPropertyName("landmark")]
				[Description("收件地址标志物")]
				public string Landmark { get; set; }

				[JsonPropertyName("street")]
				[Description("街道")]
				public StreetItem Street { get; set; }

				public class StreetItem
				{
					[JsonPropertyName("id")]
					[Description("街道ID")]
					public string Id { get; set; }

					[JsonPropertyName("name")]
					[Description("街道名字")]
					public string Name { get; set; }
				}
			}

			[JsonPropertyName("risk_decsison_code")]
			[Description("物流异常风控编码")]
			public long RiskDecsisonCode { get; set; }

			[JsonPropertyName("risk_decsison_reason")]
			[Description("物流异常风控理由")]
			public string RiskDecsisonReason { get; set; }

			[JsonPropertyName("risk_decsison_description")]
			[Description("物流异常风控描述")]
			public string RiskDecsisonDescription { get; set; }

			[JsonPropertyName("return_address")]
			[Description("退货地址")]
			public ReturnAddressItem ReturnAddress { get; set; }

			public class ReturnAddressItem
			{
				[JsonPropertyName("province")]
				[Description("省")]
				public ProvinceItem Province { get; set; }

				public class ProvinceItem
				{
					[JsonPropertyName("id")]
					[Description("省ID")]
					public string Id { get; set; }

					[JsonPropertyName("name")]
					[Description("省名字")]
					public string Name { get; set; }
				}

				[JsonPropertyName("city")]
				[Description("市")]
				public CityItem City { get; set; }

				public class CityItem
				{
					[JsonPropertyName("id")]
					[Description("市ID")]
					public string Id { get; set; }

					[JsonPropertyName("name")]
					[Description("市名称")]
					public string Name { get; set; }
				}

				[JsonPropertyName("town")]
				[Description("县/区")]
				public TownItem Town { get; set; }

				public class TownItem
				{
					[JsonPropertyName("id")]
					[Description("县区ID")]
					public string Id { get; set; }

					[JsonPropertyName("name")]
					[Description("县区名字")]
					public string Name { get; set; }
				}

				[JsonPropertyName("street")]
				[Description("街道")]
				public StreetItem Street { get; set; }

				public class StreetItem
				{
					[JsonPropertyName("id")]
					[Description("街道ID")]
					public string Id { get; set; }

					[JsonPropertyName("name")]
					[Description("街道名称")]
					public string Name { get; set; }
				}

				[JsonPropertyName("landmark")]
				[Description("收件地址标志物")]
				public string Landmark { get; set; }

				[JsonPropertyName("detail")]
				[Description("详细地址")]
				public string Detail { get; set; }
			}

			[JsonPropertyName("real_refund_amount")]
			[Description("实际退款金额;单位：分（此字段只有退款成功后才会记录实际减去支付补贴回收的金额）")]
			public long RealRefundAmount { get; set; }

			[JsonPropertyName("got_pkg")]
			[Description("买家是否收到货，0-表示未收到货；1-表示收到货")]
			public long GotPkg { get; set; }

			[JsonPropertyName("status_deadline")]
			[Description("逾期时间")]
			public long StatusDeadline { get; set; }

			[JsonPropertyName("return_address_id")]
			[Description("退货地址ID")]
			public long ReturnAddressId { get; set; }

			[JsonPropertyName("exchange_sku_info")]
			[Description("换货SKU信息")]
			public ExchangeSkuInfoItem ExchangeSkuInfo { get; set; }

			public class ExchangeSkuInfoItem
			{
				[JsonPropertyName("sku_id")]
				[Description("商品skuid")]
				public string SkuId { get; set; }

				[JsonPropertyName("code")]
				[Description("商品编码")]
				public string Code { get; set; }

				[JsonPropertyName("num")]
				[Description("替换数量")]
				public long Num { get; set; }

				[JsonPropertyName("out_sku_id")]
				[Description("商家编号")]
				public string OutSkuId { get; set; }

				[JsonPropertyName("out_warehouse_id")]
				[Description("区域库存仓ID")]
				public string OutWarehouseId { get; set; }

				[JsonPropertyName("supplier_id")]
				[Description("sku外部供应商编码供应商ID")]
				public string SupplierId { get; set; }

				[JsonPropertyName("url")]
				[Description("商品图片url")]
				public string Url { get; set; }

				[JsonPropertyName("name")]
				[Description("商品名称")]
				public string Name { get; set; }

				[JsonPropertyName("price")]
				[Description("换货商品的价格，单位分")]
				public string Price { get; set; }

				[JsonPropertyName("spec_desc")]
				[Description("sku规格信息")]
				public string SpecDesc { get; set; }
			}

			[JsonPropertyName("post_discount_return_amount")]
			[Description("运费优惠退回金额")]
			public long PostDiscountReturnAmount { get; set; }

			[JsonPropertyName("post_discount_return_status")]
			[Description("运费优惠退回状态，枚举：0:待退补贴；1:退补贴成功；2:退补贴失败")]
			public long PostDiscountReturnStatus { get; set; }

			[JsonPropertyName("part_type")]
			[Description("部分退状态，0为全额退款，1为部分退")]
			public long PartType { get; set; }

			[JsonPropertyName("reason_second_labels")]
			[Description("用户申请售后选择的二级原因标签")]
			public List<ReasonSecondLabelsItem> ReasonSecondLabels { get; set; }

			public class ReasonSecondLabelsItem
			{
				[JsonPropertyName("code")]
				[Description("二级原因标签编码")]
				public long Code { get; set; }

				[JsonPropertyName("name")]
				[Description("二级原因标签名称")]
				public string Name { get; set; }
			}

			[JsonPropertyName("refund_voucher_num")]
			[Description("卡券商品申请退款的张数")]
			public long RefundVoucherNum { get; set; }

			[JsonPropertyName("refund_voucher_times")]
			[Description("多次券商品申请退款的次数，对于单次券，此字段值与refund_voucher_num相同")]
			public long RefundVoucherTimes { get; set; }

			[JsonPropertyName("gold_coin_return_amount")]
			[Description("退金币金额")]
			public long GoldCoinReturnAmount { get; set; }

			[JsonPropertyName("refund_fail_reason")]
			[Description("退款失败文案")]
			public string RefundFailReason { get; set; }

			[JsonPropertyName("aftersale_tags")]
			[Description("售后标签")]
			public List<AftersaleTagsItem> AftersaleTags { get; set; }

			public class AftersaleTagsItem
			{
				[JsonPropertyName("tag_detail")]
				[Description("标签名称")]
				public string TagDetail { get; set; }

				[JsonPropertyName("tag_detail_en")]
				[Description("标签关键字")]
				public string TagDetailEn { get; set; }

				[JsonPropertyName("tag_detail_text")]
				[Description("标签悬浮文案的占位符定义")]
				public string TagDetailText { get; set; }

				[JsonPropertyName("tag_link_url")]
				[Description("标签跳转链接")]
				public string TagLinkUrl { get; set; }

				[JsonPropertyName("placeholder")]
				[Description("标签悬浮文案的占位符定义")]
				public Dictionary<string,PlaceholderItem> Placeholder { get; set; }

				public class PlaceholderItem
				{
					[JsonPropertyName("text")]
					[Description("占位符文案")]
					public string Text { get; set; }

					[JsonPropertyName("url")]
					[Description("占位符跳转链接")]
					public string Url { get; set; }
				}
			}

			[JsonPropertyName("store_id")]
			[Description("门店ID")]
			public string StoreId { get; set; }

			[JsonPropertyName("store_name")]
			[Description("门店名称")]
			public string StoreName { get; set; }

			[JsonPropertyName("after_sale_order_type")]
			[Description("售后订单类型，枚举为-1(历史订单),1(商品单),2(店铺单)")]
			public long AfterSaleOrderType { get; set; }

			[JsonPropertyName("refund_packing_charge_amount")]
			[Description("售后打包费退款金额，单位：分，商家退给用户打包费后，该字段则有值；仅小时达店铺使用；")]
			public long RefundPackingChargeAmount { get; set; }

			[JsonPropertyName("shop_discount_return_amount")]
			[Description("商家优惠退回金额（包含供应商优惠退回金额）")]
			public long ShopDiscountReturnAmount { get; set; }

			[JsonPropertyName("after_sale_sub_type")]
			[Description("售后子类型：8001-以换代修")]
			public long AfterSaleSubType { get; set; }

			[JsonPropertyName("agree_refuse_sign")]
			[Description("商家是否同意拒签后退款（0-默认值；1-同意拒签后退款；2-不同意拒签后退款；257-拒签上标；258-拒签下标）")]
			public long AgreeRefuseSign { get; set; }

			[JsonPropertyName("apply_role")]
			[Description("售后申请角色：1-买家；2-商家；3-客服；4-系统")]
			public long ApplyRole { get; set; }

			[JsonPropertyName("refund_time")]
			[Description("退款成功时间，即平台最后原路退回金额到用户账户的成功时间，Unix时间戳：秒")]
			public long RefundTime { get; set; }

			[JsonPropertyName("aftersale_status_to_final_time")]
			[Description("售后完结时间，完结时间是平台根据商品的类型，售后状态等综合判断生成，当售后单有完结时间返回时售后单不可再做做任何操作；未完结售后单的该字段值为0；Unix时间戳：秒")]
			public long AftersaleStatusToFinalTime { get; set; }

			[JsonPropertyName("return_method")]
			[Description("用户申请时的退货方式：0-未选择，1-用户上传物流，2-上门取件，3-到店退货，4-上门取货，5-平台运力，6-线下取货。（具体以实际用户选择为准）")]
			public long ReturnMethod { get; set; }

			[JsonPropertyName("auto_audit_bits")]
			[Description("自动审核方式：1-发货前极速退；2-小助手自动同意退款；3-发货后极速退；4-闪电退货；5-跨境零秒退；6-云仓拦截自动退；7-小助手自动同意退货；8-小助手自动同意拒签后退款；9-商家代客填写卡片发起售后；10-治理未发货自动同意退款；11-治理已发货自动同意退款；12-商家快递拦截成功自动退款；13-质检商品免审核；14-协商方案自动同意退款；15-平台卡券自动同意退款；16-三方卡券自动同意退款；17-治理一审自动同意退货退款")]
			public List<long> AutoAuditBits { get; set; }

			[JsonPropertyName("open_address_id")]
			[Description("标识收件人地址的id，可用于合单")]
			public string OpenAddressId { get; set; }
		}

		[JsonPropertyName("arbitrate_info")]
		[Description("仲裁信息")]
		public ArbitrateInfoItem ArbitrateInfo { get; set; }

		public class ArbitrateInfoItem
		{
			[JsonPropertyName("arbitrate_id")]
			[Description("仲裁单id")]
			public string ArbitrateId { get; set; }

			[JsonPropertyName("arbitrate_status")]
			[Description("仲裁状态")]
			public long ArbitrateStatus { get; set; }

			[JsonPropertyName("is_required_evidence")]
			[Description("是否需要上传凭证")]
			public bool IsRequiredEvidence { get; set; }

			[JsonPropertyName("arbitrate_status_deadline")]
			[Description("仲裁截止时间")]
			public string ArbitrateStatusDeadline { get; set; }

			[JsonPropertyName("arbitrate_opinion")]
			[Description("仲裁原因")]
			public string ArbitrateOpinion { get; set; }

			[JsonPropertyName("arbitrate_conclusion")]
			[Description("仲裁结果")]
			public long ArbitrateConclusion { get; set; }

			[JsonPropertyName("arbitrate_create_time")]
			[Description("仲裁单创建时间")]
			public long ArbitrateCreateTime { get; set; }

			[JsonPropertyName("arbitrate_update_time")]
			[Description("仲裁单更新时间")]
			public long ArbitrateUpdateTime { get; set; }

			[JsonPropertyName("arbitrate_evidence_tmpl")]
			[Description("凭证示例")]
			public ArbitrateEvidenceTmplItem ArbitrateEvidenceTmpl { get; set; }

			public class ArbitrateEvidenceTmplItem
			{
				[JsonPropertyName("images")]
				[Description("仲裁图片示例")]
				public List<string> Images { get; set; }

				[JsonPropertyName("describe")]
				[Description("仲裁描述")]
				public string Describe { get; set; }

				[JsonPropertyName("dead_line")]
				[Description("示例截止时间")]
				public long DeadLine { get; set; }
			}

			[JsonPropertyName("arbitrate_evidence")]
			[Description("仲裁证据")]
			public ArbitrateEvidenceItem ArbitrateEvidence { get; set; }

			public class ArbitrateEvidenceItem
			{
				[JsonPropertyName("images")]
				[Description("仲裁图片")]
				public List<string> Images { get; set; }

				[JsonPropertyName("describe")]
				[Description("仲裁图片描述")]
				public string Describe { get; set; }
			}

			[JsonPropertyName("arbitrate_blame")]
			[Description("仲裁责任方")]
			public long ArbitrateBlame { get; set; }
		}

		[JsonPropertyName("after_sale_service_tag")]
		[Description("售后标签")]
		public AfterSaleServiceTagItem AfterSaleServiceTag { get; set; }

		public class AfterSaleServiceTagItem
		{
			[JsonPropertyName("after_sale_service_tag")]
			[Description("售后服务标签")]
			public List<AfterSaleServiceTagIItem> AfterSaleServiceTagI { get; set; }

			public class AfterSaleServiceTagIItem
			{
				[JsonPropertyName("tag_detail")]
				[Description("服务标签名称")]
				public string TagDetail { get; set; }

				[JsonPropertyName("tag_detail_en")]
				[Description("服务标签英文代号")]
				public string TagDetailEn { get; set; }

				[JsonPropertyName("tag_link_url")]
				[Description("服务跳转地址")]
				public string TagLinkUrl { get; set; }
			}
		}

		[JsonPropertyName("logistics_info")]
		[Description("物流信息")]
		public LogisticsInfoItem LogisticsInfo { get; set; }

		public class LogisticsInfoItem
		{
			[JsonPropertyName("return")]
			[Description("买家退货物流信息")]
			public ReturnItem Return { get; set; }

			public class ReturnItem
			{
				[JsonPropertyName("tracking_no")]
				[Description("物流单号")]
				public string TrackingNo { get; set; }

				[JsonPropertyName("company_name")]
				[Description("物流公司名称")]
				public string CompanyName { get; set; }

				[JsonPropertyName("company_code")]
				[Description("物流公司编码")]
				public string CompanyCode { get; set; }

				[JsonPropertyName("logistics_time")]
				[Description("买家填写退货物流时间")]
				public long LogisticsTime { get; set; }
			}

			[JsonPropertyName("exchange")]
			[Description("卖家换货物流信息")]
			public ExchangeItem Exchange { get; set; }

			public class ExchangeItem
			{
				[JsonPropertyName("tracking_no")]
				[Description("物流单号")]
				public string TrackingNo { get; set; }

				[JsonPropertyName("company_name")]
				[Description("物流公司名称")]
				public string CompanyName { get; set; }

				[JsonPropertyName("company_code")]
				[Description("物流公司编码")]
				public string CompanyCode { get; set; }

				[JsonPropertyName("logistics_time")]
				[Description("卖家填写换货物流时间")]
				public long LogisticsTime { get; set; }
			}

			[JsonPropertyName("order")]
			[Description("卖家发货正向物流信息")]
			public List<OrderItem> Order { get; set; }

			public class OrderItem
			{
				[JsonPropertyName("tracking_no")]
				[Description("物流单号")]
				public string TrackingNo { get; set; }

				[JsonPropertyName("company_name")]
				[Description("物流公司名称")]
				public string CompanyName { get; set; }

				[JsonPropertyName("company_code")]
				[Description("物流公司编码")]
				public string CompanyCode { get; set; }

				[JsonPropertyName("logistics_time")]
				[Description("物流状态到达时间")]
				public long LogisticsTime { get; set; }

				[JsonPropertyName("logistics_state")]
				[Description("正向物流状态")]
				public long LogisticsState { get; set; }

				[JsonPropertyName("value_added_services")]
				[Description("增值服务标签")]
				public List<ValueAddedServicesItem> ValueAddedServices { get; set; }

				public class ValueAddedServicesItem
				{
					[JsonPropertyName("code")]
					[Description("标签编码")]
					public string Code { get; set; }

					[JsonPropertyName("name")]
					[Description("标签名称")]
					public string Name { get; set; }
				}
			}

			[JsonPropertyName("resend")]
			[Description("补寄物流")]
			public ResendItem Resend { get; set; }

			public class ResendItem
			{
				[JsonPropertyName("tracking_no")]
				[Description("物流单号")]
				public string TrackingNo { get; set; }

				[JsonPropertyName("company_name")]
				[Description("物流公司名称")]
				public string CompanyName { get; set; }

				[JsonPropertyName("company_code")]
				[Description("物流公司编码")]
				public string CompanyCode { get; set; }

				[JsonPropertyName("logistics_time")]
				[Description("卖家填写补寄物流时间")]
				public long LogisticsTime { get; set; }
			}
		}

		[JsonPropertyName("after_sale_shop_remarks")]
		[Description("售后备注")]
		public List<AfterSaleShopRemarksItem> AfterSaleShopRemarks { get; set; }

		public class AfterSaleShopRemarksItem
		{
			[JsonPropertyName("order_id")]
			[Description("备注关联的订单ID")]
			public long OrderId { get; set; }

			[JsonPropertyName("after_sale_id")]
			[Description("备注关联的售后ID")]
			public long AfterSaleId { get; set; }

			[JsonPropertyName("remark")]
			[Description("备注内容")]
			public string Remark { get; set; }

			[JsonPropertyName("create_time")]
			[Description("创建时间")]
			public long CreateTime { get; set; }

			[JsonPropertyName("operator")]
			[Description("操作人")]
			public string Operator { get; set; }
		}

		[JsonPropertyName("price_protection_detail")]
		[Description("价保详情")]
		public PriceProtectionDetailItem PriceProtectionDetail { get; set; }

		public class PriceProtectionDetailItem
		{
			[JsonPropertyName("title")]
			[Description("价保文案标题")]
			public string Title { get; set; }

			[JsonPropertyName("price_protection_formulas")]
			[Description("价保计算公式")]
			public string PriceProtectionFormulas { get; set; }

			[JsonPropertyName("standard_price")]
			[Description("基准价")]
			public StandardPriceItem StandardPrice { get; set; }

			public class StandardPriceItem
			{
				[JsonPropertyName("actual_amount")]
				[Description("总价")]
				public ActualAmountItem ActualAmount { get; set; }

				public class ActualAmountItem
				{
					[JsonPropertyName("price_text")]
					[Description("金额明细")]
					public string PriceText { get; set; }

					[JsonPropertyName("amount")]
					[Description("金额")]
					public long Amount { get; set; }
				}

				[JsonPropertyName("origin_amount")]
				[Description("原价")]
				public OriginAmountItem OriginAmount { get; set; }

				public class OriginAmountItem
				{
					[JsonPropertyName("price_text")]
					[Description("金额明细")]
					public string PriceText { get; set; }

					[JsonPropertyName("amount")]
					[Description("金额")]
					public long Amount { get; set; }
				}

				[JsonPropertyName("deduction_price_detail")]
				[Description("减数明细")]
				public List<DeductionPriceDetailItem> DeductionPriceDetail { get; set; }

				public class DeductionPriceDetailItem
				{
					[JsonPropertyName("price_text")]
					[Description("金额明细")]
					public string PriceText { get; set; }

					[JsonPropertyName("amount")]
					[Description("金额")]
					public long Amount { get; set; }
				}
			}

			[JsonPropertyName("check_price")]
			[Description("核准价")]
			public CheckPriceItem CheckPrice { get; set; }

			public class CheckPriceItem
			{
				[JsonPropertyName("actual_amount")]
				[Description("总价")]
				public ActualAmountItem ActualAmount { get; set; }

				public class ActualAmountItem
				{
					[JsonPropertyName("price_text")]
					[Description("金额明细")]
					public string PriceText { get; set; }

					[JsonPropertyName("amount")]
					[Description("金额")]
					public long Amount { get; set; }
				}

				[JsonPropertyName("origin_amount")]
				[Description("原价")]
				public OriginAmountItem OriginAmount { get; set; }

				public class OriginAmountItem
				{
					[JsonPropertyName("price_text")]
					[Description("金额明细")]
					public string PriceText { get; set; }

					[JsonPropertyName("amount")]
					[Description("金额")]
					public long Amount { get; set; }
				}

				[JsonPropertyName("deduction_price_detail")]
				[Description("减数明细")]
				public List<DeductionPriceDetailItem> DeductionPriceDetail { get; set; }

				public class DeductionPriceDetailItem
				{
					[JsonPropertyName("price_text")]
					[Description("金额明细")]
					public string PriceText { get; set; }

					[JsonPropertyName("amount")]
					[Description("金额")]
					public long Amount { get; set; }
				}
			}

			[JsonPropertyName("refund_detail")]
			[Description("退款明细")]
			public RefundDetailItem RefundDetail { get; set; }

			public class RefundDetailItem
			{
				[JsonPropertyName("actual_amount")]
				[Description("总价")]
				public ActualAmountItem ActualAmount { get; set; }

				public class ActualAmountItem
				{
					[JsonPropertyName("price_text")]
					[Description("金额明细")]
					public string PriceText { get; set; }

					[JsonPropertyName("amount")]
					[Description("金额")]
					public long Amount { get; set; }
				}

				[JsonPropertyName("origin_amount")]
				[Description("原价")]
				public OriginAmountItem OriginAmount { get; set; }

				public class OriginAmountItem
				{
					[JsonPropertyName("price_text")]
					[Description("金额明细")]
					public string PriceText { get; set; }

					[JsonPropertyName("amount")]
					[Description("金额")]
					public long Amount { get; set; }
				}

				[JsonPropertyName("deduction_price_detail")]
				[Description("减数明细")]
				public List<DeductionPriceDetailItem> DeductionPriceDetail { get; set; }

				public class DeductionPriceDetailItem
				{
					[JsonPropertyName("price_text")]
					[Description("金额明细")]
					public string PriceText { get; set; }

					[JsonPropertyName("amount")]
					[Description("金额")]
					public long Amount { get; set; }
				}
			}

			[JsonPropertyName("refund_bearer_list")]
			[Description("钱款承担方")]
			public List<RefundBearerListItem> RefundBearerList { get; set; }

			public class RefundBearerListItem
			{
				[JsonPropertyName("price_text")]
				[Description("文案")]
				public string PriceText { get; set; }

				[JsonPropertyName("amount")]
				[Description("金额")]
				public long Amount { get; set; }
			}

			[JsonPropertyName("platform_to_merchant_refund_status")]
			[Description("平台价保补贴商家金额进度状态，1表示成功")]
			public long PlatformToMerchantRefundStatus { get; set; }

			[JsonPropertyName("platform_recycle_amount")]
			[Description("平台价保回收金额")]
			public long PlatformRecycleAmount { get; set; }
		}

		[JsonPropertyName("record_logs_list")]
		[Description("协商记录")]
		public List<RecordLogsListItem> RecordLogsList { get; set; }

		public class RecordLogsListItem
		{
			[JsonPropertyName("operator")]
			[Description("操作人")]
			public string Operator { get; set; }

			[JsonPropertyName("time")]
			[Description("操作时间")]
			public string Time { get; set; }

			[JsonPropertyName("text")]
			[Description("操作内容")]
			public string Text { get; set; }

			[JsonPropertyName("images")]
			[Description("图片列表")]
			public List<string> Images { get; set; }

			[JsonPropertyName("desc_kvs")]
			[Description("额外信息")]
			public List<DescKvsItem> DescKvs { get; set; }

			public class DescKvsItem
			{
				[JsonPropertyName("key")]
				[Description("行头")]
				public string Key { get; set; }

				[JsonPropertyName("value")]
				[Description("内容")]
				public string Value { get; set; }

				[JsonPropertyName("highlight")]
				[Description("是否高亮展示")]
				public bool Highlight { get; set; }

				[JsonPropertyName("notice")]
				[Description("额外提示")]
				public string Notice { get; set; }
			}

			[JsonPropertyName("action")]
			[Description("动作")]
			public string Action { get; set; }

			[JsonPropertyName("role")]
			[Description("角色；1-买家，2-商家，3-平台客服，4-系统")]
			public long Role { get; set; }

			[JsonPropertyName("all_evidence")]
			[Description("所有类型凭证")]
			public List<AllEvidenceItem> AllEvidence { get; set; }

			public class AllEvidenceItem
			{
				[JsonPropertyName("type")]
				[Description("证据类型  1:图片 2:视频 3:视频 4:文本 5:pdf")]
				public int Type { get; set; }

				[JsonPropertyName("urls")]
				[Description("资源地址")]
				public List<string> Urls { get; set; }

				[JsonPropertyName("desc")]
				[Description("证据描述")]
				public string Desc { get; set; }
			}
		}
	}

	[JsonPropertyName("order_info")]
	[Description("售后单关联订单信息")]
	public OrderInfoItem OrderInfo { get; set; }

	public class OrderInfoItem
	{
		[JsonPropertyName("shop_order_id")]
		[Description("店铺单ID")]
		public long ShopOrderId { get; set; }

		[JsonPropertyName("sku_order_infos")]
		[Description("sku单信息")]
		public List<SkuOrderInfosItem> SkuOrderInfos { get; set; }

		public class SkuOrderInfosItem
		{
			[JsonPropertyName("sku_order_id")]
			[Description("sku单ID")]
			public long SkuOrderId { get; set; }

			[JsonPropertyName("order_status")]
			[Description("订单状态")]
			public long OrderStatus { get; set; }

			[JsonPropertyName("pay_amount")]
			[Description("买家实付金额（分）")]
			public long PayAmount { get; set; }

			[JsonPropertyName("post_amount")]
			[Description("买家购买运费（分）")]
			public long PostAmount { get; set; }

			[JsonPropertyName("item_quantity")]
			[Description("订单件数")]
			public long ItemQuantity { get; set; }

			[JsonPropertyName("create_time")]
			[Description("订单创建时间")]
			public long CreateTime { get; set; }

			[JsonPropertyName("tax_amount")]
			[Description("购买税费（分）")]
			public long TaxAmount { get; set; }

			[JsonPropertyName("is_oversea_order")]
			[Description("是否为跨境业务")]
			public long IsOverseaOrder { get; set; }

			[JsonPropertyName("product_name")]
			[Description("商品名称")]
			public string ProductName { get; set; }

			[JsonPropertyName("product_id")]
			[Description("商品ID")]
			public long ProductId { get; set; }

			[JsonPropertyName("product_image")]
			[Description("商品图片")]
			public string ProductImage { get; set; }

			[JsonPropertyName("tags")]
			[Description("商品标签")]
			public List<TagsItem> Tags { get; set; }

			public class TagsItem
			{
				[JsonPropertyName("tag_detail")]
				[Description("服务标签名称")]
				public string TagDetail { get; set; }

				[JsonPropertyName("tag_detail_en")]
				[Description("服务标签英文代号")]
				public string TagDetailEn { get; set; }

				[JsonPropertyName("tag_link_url")]
				[Description("服务跳转地址")]
				public string TagLinkUrl { get; set; }
			}

			[JsonPropertyName("sku_spec")]
			[Description("商品规格信息")]
			public List<SkuSpecItem> SkuSpec { get; set; }

			public class SkuSpecItem
			{
				[JsonPropertyName("name")]
				[Description("规格名称")]
				public string Name { get; set; }

				[JsonPropertyName("value")]
				[Description("规格值")]
				public string Value { get; set; }
			}

			[JsonPropertyName("shop_sku_code")]
			[Description("商家sku自定义编码")]
			public string ShopSkuCode { get; set; }

			[JsonPropertyName("sku_id")]
			[Description("skuID")]
			public long SkuId { get; set; }

			[JsonPropertyName("item_sum_amount")]
			[Description("sku商品总原价（不含优惠）")]
			public long ItemSumAmount { get; set; }

			[JsonPropertyName("sku_pay_amount")]
			[Description("商品实际支付金额")]
			public long SkuPayAmount { get; set; }

			[JsonPropertyName("promotion_amount")]
			[Description("优惠总金额")]
			public long PromotionAmount { get; set; }

			[JsonPropertyName("pay_type")]
			[Description("支付方式")]
			public long PayType { get; set; }

			[JsonPropertyName("insurance_tags")]
			[Description("保险及其状态")]
			public List<InsuranceTagsItem> InsuranceTags { get; set; }

			public class InsuranceTagsItem
			{
				[JsonPropertyName("tag_detail")]
				[Description("服务标签名称")]
				public string TagDetail { get; set; }

				[JsonPropertyName("tag_detail_en")]
				[Description("服务标签英文代号")]
				public string TagDetailEn { get; set; }

				[JsonPropertyName("tag_link_url")]
				[Description("服务跳转地址")]
				public string TagLinkUrl { get; set; }
			}

			[JsonPropertyName("after_sale_item_count")]
			[Description("商品单对应的售后数量")]
			public long AfterSaleItemCount { get; set; }

			[JsonPropertyName("given_sku_details")]
			[Description("赠品信息")]
			public List<GivenSkuDetailsItem> GivenSkuDetails { get; set; }

			public class GivenSkuDetailsItem
			{
				[JsonPropertyName("item_order_num")]
				[Description("赠品个数")]
				public long ItemOrderNum { get; set; }

				[JsonPropertyName("shop_sku_code")]
				[Description("赠品商家编码")]
				public string ShopSkuCode { get; set; }

				[JsonPropertyName("product_id")]
				[Description("赠品商品ID")]
				public string ProductId { get; set; }

				[JsonPropertyName("sku_order_id")]
				[Description("赠品商品订单ID")]
				public string SkuOrderId { get; set; }

				[JsonPropertyName("product_name")]
				[Description("赠品名称")]
				public string ProductName { get; set; }
			}
		}
	}
}
