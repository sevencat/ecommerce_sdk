namespace ecommerce.sdk.douyin;

[Description("1、售后列表接口，可以支持多种筛选规则，详情见请求参数。,2、时间类型参数均为以秒为单位的时间戳，金额均以分为单位。,3、接口中page*size最多不能超过5万条数据。如果超过5万条，请使用时间参数分割数据。,4、默认情况下，只能查到近6个月以内的数据，超过6个月需要指定时间。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:11000","请检查输入参数是否合法")]
[DouyinRetCode(20000,"系统错误","系统超时","isp.service-error:10000","请重试")]
[DouyinRetCode(20000,"系统错误","系统处理失败","isp.service-error:10002","请重试")]
[DouyinRetCode(40004,"非法的参数","数据不存在","isv.parameter-invalid:11003","请检查输入参数是否合法")]
[DouyinRetCode(50002,"业务处理失败","系统处理失败","isv.business-failed:12001","请检查输入参数是否合法")]
[DouyinRetCode(50002,"业务处理失败","未知错误","isv.business-failed:12000","请辛苦联系平台排障")]
public class AfterSaleListReq : IDouyinReq<AfterSaleListRsp>
{

	public string GetMethod() { return "afterSale.List"; }

	public string GetUrl() { return "/afterSale/List"; }

	[JsonPropertyName("order_id")]
	[Description("父订单号")]
	public string OrderId { get; set; }

	[JsonPropertyName("aftersale_type")]
	[Description("售后类型；0-退货退款；1-已发货仅退款；2-未发货仅退款；3-换货；6-价保；7-补寄；8-维修")]
	public long? AftersaleType { get; set; }

	[JsonPropertyName("aftersale_status")]
	[Description("已废弃，推荐使用standard_aftersale_status字段。售后状态，枚举为6(待商家同意),7(待买家退货),8(待商家发货),11(待商家二次同意),12(售后成功),13(换货待买家收货),14(换货成功),27(商家一次拒绝),28(售后失败),29(商家二次拒绝)")]
	public long? AftersaleStatus { get; set; }

	[JsonPropertyName("reason")]
	[Description("售后理由；1-七天无理由退货；2-非七天无理由退货；")]
	public long? Reason { get; set; }

	[JsonPropertyName("logistics_status")]
	[Description("退货物流状态，枚举为1(全部),2(已发货),3(未发货)")]
	public long? LogisticsStatus { get; set; }

	[JsonPropertyName("pay_type")]
	[Description("付款方式，枚举为1(全部), 2(货到付款),3(线上付款)")]
	public long? PayType { get; set; }

	[JsonPropertyName("refund_type")]
	[Description("退款类型，枚举为0(原路退款),1(线下退款),2(备用金),3(保证金),4(无需退款)")]
	public long? RefundType { get; set; }

	[JsonPropertyName("arbitrate_status")]
	[Description("仲裁状态，枚举为0(未介入),1(客服处理中),2(仲裁结束-支持买家),3(仲裁结束-支持卖家),4(待商家举证),5(待与买家协商),6(仲裁结束),255(取消)")]
	public List<long> ArbitrateStatus { get; set; }

	[JsonPropertyName("order_flag")]
	[Description("插旗信息：0：灰 1：紫 2: 青 3：绿 4： 橙 5： 红")]
	public List<long> OrderFlag { get; set; }

	[JsonPropertyName("start_time")]
	[Description("申请时间开始，单位为秒（查询范围包含开始值）")]
	public long? StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("申请时间结束，单位为秒（查询范围不包含结束值）")]
	public long? EndTime { get; set; }

	[JsonPropertyName("amount_start")]
	[Description("金额下限，单位为分（查询范围包含开始值）")]
	public long? AmountStart { get; set; }

	[JsonPropertyName("amount_end")]
	[Description("金额上限，单位为分（查询范围不包含结束值）")]
	public long? AmountEnd { get; set; }

	[JsonPropertyName("risk_flag")]
	[Description("风控标签，枚举为-1(退货正常),1(退货异常)")]
	public long? RiskFlag { get; set; }

	[JsonPropertyName("order_by")]
	[Description("排序方式，优先级按照列表顺序从前往后依次减小，写法为<字段名称> <排序方式>，字段名称目前支持status_deadline（逾期时间）、apply_time（申请时间）和 update_time（更新时间），排序方式目前支持asc（升序）和desc（降序）。按照逾期时间升序排列，会优先返回临近逾期时间的数据。")]
	public List<string> OrderBy { get; set; }

	[JsonPropertyName("page")]
	[Description("页数，从0开始")]
	[NotNull]
	public long? Page { get; set; }

	[JsonPropertyName("size")]
	[Description("每页数量，最多100个")]
	[NotNull]
	public long? Size { get; set; }

	[JsonPropertyName("aftersale_id")]
	[Description("售后单号")]
	public string AftersaleId { get; set; }

	[JsonPropertyName("standard_aftersale_status")]
	[Description("售后状态；6-待商家同意；7-待买家退货；8-待商家发货；11-待商家二次同意；12-售后成功；13-换货,补寄,维修待买家收货；14-换货,补寄,维修成功；27-商家一次拒绝；28-售后失败；29-商家二次拒绝；支持传多种状态，使用英文“,”分隔；注意：如传入非枚举值信息会被系统忽略，如传入都不合法则默认查询所有；")]
	public List<long> StandardAftersaleStatus { get; set; }

	[JsonPropertyName("need_special_type")]
	[Description("是否展示特殊售后")]
	public bool? NeedSpecialType { get; set; }

	[JsonPropertyName("update_start_time")]
	[Description("更新时间开始，单位为秒（查询范围包含开始值）；当使用update_start_time和update_end_time时，请配合传入order_by= update_time否则会导致基于更新时间查询售后列表轮询数据遗漏；")]
	public long? UpdateStartTime { get; set; }

	[JsonPropertyName("update_end_time")]
	[Description("更新时间结束，单位为秒（查询范围包含开始值）；当使用update_start_time和update_end_time时，请配合传入order_by= update_time否则会导致基于更新时间查询售后列表轮询数据遗漏；")]
	public long? UpdateEndTime { get; set; }

	[JsonPropertyName("order_logistics_tracking_no")]
	[Description("正向物流单号")]
	public List<string> OrderLogisticsTrackingNo { get; set; }

	[JsonPropertyName("order_logistics_state")]
	[Description("正向物流状态（仅支持拒签场景下的状态筛选，状态更新有一定时延。1：买家已拒签；2：买家已签收；3：快递退回中，运往商家，包含快递拦截成功；4：商家已签收）")]
	public List<long> OrderLogisticsState { get; set; }

	[JsonPropertyName("agree_refuse_sign")]
	[Description("是否拒签后退款（1：已同意拒签, 2：未同意拒签）")]
	public List<long> AgreeRefuseSign { get; set; }

	[JsonPropertyName("aftersale_sub_type")]
	[Description("售后子类型；8001-以换代修。")]
	public long? AftersaleSubType { get; set; }

	[JsonPropertyName("aftersale_status_to_final_start_time")]
	[Description("售后完结时间开始，单位为秒（查询范围包含开始值），仅支持售后完结时间在近6个月内的售后单，按完结时间筛选；售后完结时间生成规则是平台根据商品的类型，售后状态等综合判断生成，当售后单有完结时间返回时售后单不可再做任何操作；")]
	public long? AftersaleStatusToFinalStartTime { get; set; }

	[JsonPropertyName("aftersale_status_to_final_end_time")]
	[Description("售后完结时间结束，单位为秒（查询范围包含开始值），仅支持售后完结时间在近6个月内的售后单，按完结时间筛选；售后完结时间生成规则是平台根据商品的类型，售后状态等综合判断生成，当售后单有完结时间返回时售后单不可再做任何操作；")]
	public long? AftersaleStatusToFinalEndTime { get; set; }
}

[Description("1、售后列表接口，可以支持多种筛选规则，详情见请求参数。,2、时间类型参数均为以秒为单位的时间戳，金额均以分为单位。,3、接口中page*size最多不能超过5万条数据。如果超过5万条，请使用时间参数分割数据。,4、默认情况下，只能查到近6个月以内的数据，超过6个月需要指定时间。")]
public class AfterSaleListRsp
{
	[JsonPropertyName("items")]
	[Description("售后列表元素")]
	public List<ItemsItem> Items { get; set; }

	public class ItemsItem
	{
		[JsonPropertyName("aftersale_info")]
		[Description("售后信息")]
		public AftersaleInfoItem AftersaleInfo { get; set; }

		public class AftersaleInfoItem
		{
			[JsonPropertyName("aftersale_status_to_final_time")]
			[Description("售后完结时间，完结时间是平台根据商品的类型，售后状态等综合判断生成，当售后单有完结时间返回时售后单不可再做任何操作；未完结售后单的该字段值为0；Unix时间戳：秒")]
			public long AftersaleStatusToFinalTime { get; set; }

			[JsonPropertyName("aftersale_id")]
			[Description("售后单号")]
			public string AftersaleId { get; set; }

			[JsonPropertyName("aftersale_order_type")]
			[Description("售后订单类型，枚举为-1(历史订单),1(商品单),2(店铺单)")]
			public long AftersaleOrderType { get; set; }

			[JsonPropertyName("aftersale_type")]
			[Description("售后类型，枚举为0(退货退款),1(已发货仅退款),2(未发货仅退款),3(换货),6(价保),7(补寄)")]
			public long AftersaleType { get; set; }

			[JsonPropertyName("aftersale_status")]
			[Description("售后状态和请求参数standard_aftersale_status字段对应；3-换货待买家收货；6-待商家同意；7-待买家退货；8-待商家发货；11-待商家二次同意；12-售后成功；14-换货成功；27-商家一次拒绝；28-售后失败；29-商家二次拒绝；")]
			public long AftersaleStatus { get; set; }

			[JsonPropertyName("related_id")]
			[Description("关联的订单ID")]
			public string RelatedId { get; set; }

			[JsonPropertyName("apply_time")]
			[Description("申请时间")]
			public long ApplyTime { get; set; }

			[JsonPropertyName("update_time")]
			[Description("最近更新时间")]
			public long UpdateTime { get; set; }

			[JsonPropertyName("status_deadline")]
			[Description("当前节点逾期时间")]
			public long StatusDeadline { get; set; }

			[JsonPropertyName("refund_amount")]
			[Description("售后退款金额，单位为分")]
			public long RefundAmount { get; set; }

			[JsonPropertyName("refund_post_amount")]
			[Description("售后退运费金额，单位为分")]
			public long RefundPostAmount { get; set; }

			[JsonPropertyName("aftersale_num")]
			[Description("售后数量")]
			public long AftersaleNum { get; set; }

			[JsonPropertyName("part_type")]
			[Description("部分退类型")]
			public long PartType { get; set; }

			[JsonPropertyName("aftersale_refund_type")]
			[Description("售后退款类型，枚举为-1(历史数据默认值),0(订单货款/原路退款),1(货到付款线下退款),2(备用金),3(保证金),4(无需退款),5(平台垫付)")]
			public long AftersaleRefundType { get; set; }

			[JsonPropertyName("refund_type")]
			[Description("退款方式，枚举为1(极速退款助手)、2(售后小助手)、3(售后急速退)、4(闪电退货)")]
			public long RefundType { get; set; }

			[JsonPropertyName("arbitrate_status")]
			[Description("仲裁状态，枚举为0(无仲裁记录),1(仲裁中),2(客服同意),3(客服拒绝),4(待商家举证),5(协商期),255(仲裁结束)")]
			public long ArbitrateStatus { get; set; }

			[JsonPropertyName("create_time")]
			[Description("售后单创建时间")]
			public long CreateTime { get; set; }

			[JsonPropertyName("refund_tax_amount")]
			[Description("退税费")]
			public long RefundTaxAmount { get; set; }

			[JsonPropertyName("left_urge_sms_count")]
			[Description("商家剩余发送短信（催用户寄回）次数")]
			public long LeftUrgeSmsCount { get; set; }

			[JsonPropertyName("return_logistics_code")]
			[Description("退货物流单号")]
			public string ReturnLogisticsCode { get; set; }

			[JsonPropertyName("risk_decision_code")]
			[Description("风控码")]
			public long RiskDecisionCode { get; set; }

			[JsonPropertyName("risk_decision_reason")]
			[Description("风控理由")]
			public string RiskDecisionReason { get; set; }

			[JsonPropertyName("risk_decision_description")]
			[Description("风控描述")]
			public string RiskDecisionDescription { get; set; }

			[JsonPropertyName("return_promotion_amount")]
			[Description("退优惠金额")]
			public long ReturnPromotionAmount { get; set; }

			[JsonPropertyName("refund_status")]
			[Description("退款状态；1-待退款;2-退款中;3-退款成功;4-退款失败;5-追缴成功;")]
			public long RefundStatus { get; set; }

			[JsonPropertyName("arbitrate_blame")]
			[Description("仲裁责任方")]
			public long ArbitrateBlame { get; set; }

			[JsonPropertyName("exchange_sku_info")]
			[Description("换货SKU信息")]
			public ExchangeSkuInfoItem ExchangeSkuInfo { get; set; }

			public class ExchangeSkuInfoItem
			{
				[JsonPropertyName("sku_id")]
				[Description("换货SkuID")]
				public string SkuId { get; set; }

				[JsonPropertyName("code")]
				[Description("换货SKU code")]
				public string Code { get; set; }

				[JsonPropertyName("num")]
				[Description("换货数目")]
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

			[JsonPropertyName("return_logistics_company_name")]
			[Description("退货物流公司名称")]
			public string ReturnLogisticsCompanyName { get; set; }

			[JsonPropertyName("exchange_logistics_company_name")]
			[Description("换货物流公司名称")]
			public string ExchangeLogisticsCompanyName { get; set; }

			[JsonPropertyName("remark")]
			[Description("售后商家备注")]
			public string Remark { get; set; }

			[JsonPropertyName("got_pkg")]
			[Description("买家是否收到货物，0表示未收到，1表示收到")]
			public long GotPkg { get; set; }

			[JsonPropertyName("order_logistics")]
			[Description("商家首次发货的正向物流信息")]
			public List<OrderLogisticsItem> OrderLogistics { get; set; }

			public class OrderLogisticsItem
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
			}

			[JsonPropertyName("is_agree_refuse_sign")]
			[Description("是否拒签后退款（1：已同意拒签, 2：未同意拒签）")]
			public long IsAgreeRefuseSign { get; set; }

			[JsonPropertyName("reason_second_labels")]
			[Description("用户申请售后时选择的二级原因标签")]
			public List<ReasonSecondLabelsItem> ReasonSecondLabels { get; set; }

			public class ReasonSecondLabelsItem
			{
				[JsonPropertyName("code")]
				[Description("二级原因标签编号")]
				public long Code { get; set; }

				[JsonPropertyName("name")]
				[Description("二级原因标签名称")]
				public string Name { get; set; }
			}

			[JsonPropertyName("aftersale_tags")]
			[Description("售后标签（含时效延长、风险预警、豁免体验分等标签）标签在平台侧会有更新，标签仅做展示使用，请勿作为系统判断依赖。")]
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
				[Description("标签悬浮文案（其中${key}占位符对应placeholder中的key对应内容）")]
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
			public long StoreId { get; set; }

			[JsonPropertyName("store_name")]
			[Description("门店名称")]
			public string StoreName { get; set; }

			[JsonPropertyName("aftersale_sub_type")]
			[Description("售后子类型；8001-以换代修。")]
			public long AftersaleSubType { get; set; }

			[JsonPropertyName("auto_audit_bits")]
			[Description("自动审核方式：1-发货前极速退；2-小助手自动同意退款；3-发货后极速退；4-闪电退货；5-跨境零秒退；6-云仓拦截自动退；7-小助手自动同意退货；8-小助手自动同意拒签后退款；9-商家代客填写卡片发起售后；10-治理未发货自动同意退款；11-治理已发货自动同意退款；12-商家快递拦截成功自动退款；13-质检商品免审核；14-协商方案自动同意退款；15-平台卡券自动同意退款；16-三方卡券自动同意退款；17-治理一审自动同意退货退款")]
			public List<long> AutoAuditBits { get; set; }
		}

		[JsonPropertyName("order_info")]
		[Description("订单信息")]
		public OrderInfoItem OrderInfo { get; set; }

		public class OrderInfoItem
		{
			[JsonPropertyName("shop_order_id")]
			[Description("店铺单订单ID")]
			public string ShopOrderId { get; set; }

			[JsonPropertyName("related_order_info")]
			[Description("售后关联的订单信息")]
			public List<RelatedOrderInfoItem> RelatedOrderInfo { get; set; }

			public class RelatedOrderInfoItem
			{
				[JsonPropertyName("sku_order_id")]
				[Description("商品单信息")]
				public string SkuOrderId { get; set; }

				[JsonPropertyName("order_status")]
				[Description("订单状态，枚举为2(未发货),3(已发货),5(已收货或已完成),255(已完成)")]
				public long OrderStatus { get; set; }

				[JsonPropertyName("pay_amount")]
				[Description("付款金额")]
				public long PayAmount { get; set; }

				[JsonPropertyName("post_amount")]
				[Description("付运费金额")]
				public long PostAmount { get; set; }

				[JsonPropertyName("item_num")]
				[Description("购买数量")]
				public long ItemNum { get; set; }

				[JsonPropertyName("create_time")]
				[Description("下单时间")]
				public long CreateTime { get; set; }

				[JsonPropertyName("tax_amount")]
				[Description("税费")]
				public long TaxAmount { get; set; }

				[JsonPropertyName("is_oversea_order")]
				[Description("是否为海外订单")]
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
				[Description("订单标签；标签在平台侧会有更新，标签仅做展示使用，请勿作为系统判断依赖。")]
				public List<TagsItem> Tags { get; set; }

				public class TagsItem
				{
					[JsonPropertyName("tag_detail")]
					[Description("标签中文名称")]
					public string TagDetail { get; set; }

					[JsonPropertyName("tag_detail_en")]
					[Description("标签编号")]
					public string TagDetailEn { get; set; }

					[JsonPropertyName("tag_link_url")]
					[Description("标签链接")]
					public string TagLinkUrl { get; set; }
				}

				[JsonPropertyName("sku_spec")]
				[Description("商品规格")]
				public List<SkuSpecItem> SkuSpec { get; set; }

				public class SkuSpecItem
				{
					[JsonPropertyName("name")]
					[Description("规格类型名称")]
					public string Name { get; set; }

					[JsonPropertyName("value")]
					[Description("规格值")]
					public string Value { get; set; }
				}

				[JsonPropertyName("shop_sku_code")]
				[Description("商家SKU编码")]
				public string ShopSkuCode { get; set; }

				[JsonPropertyName("logistics_code")]
				[Description("发货物流编码")]
				public string LogisticsCode { get; set; }

				[JsonPropertyName("aftersale_pay_amount")]
				[Description("售后退款金额")]
				public long AftersalePayAmount { get; set; }

				[JsonPropertyName("aftersale_post_amount")]
				[Description("售后退运费金额")]
				public long AftersalePostAmount { get; set; }

				[JsonPropertyName("aftersale_tax_amount")]
				[Description("售后退税费金额")]
				public long AftersaleTaxAmount { get; set; }

				[JsonPropertyName("aftersale_item_num")]
				[Description("售后商品数量")]
				public long AftersaleItemNum { get; set; }

				[JsonPropertyName("promotion_pay_amount")]
				[Description("优惠券金额")]
				public long PromotionPayAmount { get; set; }

				[JsonPropertyName("price")]
				[Description("价格")]
				public long Price { get; set; }

				[JsonPropertyName("logistics_company_name")]
				[Description("【已废弃】正向物流公司名称,替代字段：aftersale_info.order_logistics.company_name字段")]
				public string LogisticsCompanyName { get; set; }

				[JsonPropertyName("given_sku_order_ids")]
				[Description("赠品订单id")]
				public List<string> GivenSkuOrderIds { get; set; }
			}

			[JsonPropertyName("order_flag")]
			[Description("订单插旗")]
			public long OrderFlag { get; set; }
		}

		[JsonPropertyName("text_part")]
		[Description("文案部分")]
		public TextPartItem TextPart { get; set; }

		public class TextPartItem
		{
			[JsonPropertyName("logistics_text")]
			[Description("正向物流发货状态文案")]
			public string LogisticsText { get; set; }

			[JsonPropertyName("aftersale_status_text")]
			[Description("售后状态文案")]
			public string AftersaleStatusText { get; set; }

			[JsonPropertyName("aftersale_type_text")]
			[Description("售后类型文案")]
			public string AftersaleTypeText { get; set; }

			[JsonPropertyName("return_logistics_text")]
			[Description("退货物流发货状态文案")]
			public string ReturnLogisticsText { get; set; }

			[JsonPropertyName("aftersale_refund_type_text")]
			[Description("售后退款类型文案")]
			public string AftersaleRefundTypeText { get; set; }

			[JsonPropertyName("reason_text")]
			[Description("售后理由文案")]
			public string ReasonText { get; set; }

			[JsonPropertyName("bad_item_text")]
			[Description("坏单比例文案")]
			public string BadItemText { get; set; }

			[JsonPropertyName("arbitrate_status_text")]
			[Description("仲裁状态文案")]
			public string ArbitrateStatusText { get; set; }
		}

		[JsonPropertyName("seller_logs")]
		[Description("卖家插旗日志")]
		public List<SellerLogsItem> SellerLogs { get; set; }

		public class SellerLogsItem
		{
			[JsonPropertyName("content")]
			[Description("插旗日志内容")]
			public string Content { get; set; }

			[JsonPropertyName("op_name")]
			[Description("插旗操作人")]
			public string OpName { get; set; }

			[JsonPropertyName("create_time")]
			[Description("插旗时间（字符串格式）")]
			public string CreateTime { get; set; }

			[JsonPropertyName("star")]
			[Description("插旗信息；0：灰 1：紫 2: 青 3：绿 4： 橙 5： 红")]
			public long Star { get; set; }
		}
	}

	[JsonPropertyName("has_more")]
	[Description("是否还有更多")]
	public bool HasMore { get; set; }

	[JsonPropertyName("total")]
	[Description("当前搜索条件下，匹配到的总数量")]
	public long Total { get; set; }

	[JsonPropertyName("page")]
	[Description("页码，从0开始")]
	public long Page { get; set; }

	[JsonPropertyName("size")]
	[Description("当前返回售后数量")]
	public long Size { get; set; }
}
