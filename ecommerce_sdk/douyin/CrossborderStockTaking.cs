namespace ecommerce.sdk.douyin;

[Description("服务商向平台回告库存盘点信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","幂等调用异常","isv.parameter-invalid:1007","已操作成功，请忽略")]
[DouyinRetCode(50002,"业务处理失败","1005:接口调用异常，请重试，多次失败请人工反馈","isv.business-failed:1005","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","9001:调用货品中心有误","isv.business-failed:9001","请稍后重试")]
public class CrossborderStockTakingReq : IDouyinReq<CrossborderStockTakingRsp>
{

	public string GetMethod() { return "crossborder.stockTaking"; }

	public string GetUrl() { return "/crossborder/stockTaking"; }

	[JsonPropertyName("vendor")]
	[Description("服务商编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺id")]
	public long? ShopId { get; set; }

	[JsonPropertyName("taking_type")]
	[Description("盘点类型 1:盘盈 2:盘亏")]
	[NotNull]
	public long? TakingType { get; set; }

	[JsonPropertyName("occurrence_time")]
	[Description("盘点完成时间戳 单位：s")]
	[NotNull]
	public long? OccurrenceTime { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("stock_taking_details")]
	[Description("盘点信息")]
	[NotNull]
	public List<StockTakingDetailsItem> StockTakingDetails { get; set; }

	public class StockTakingDetailsItem
	{
		[JsonPropertyName("cargo_code")]
		[Description("货品编码")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("quality_grade")]
		[Description("质量等级 1:良品 2:次品")]
		[NotNull]
		public long? QualityGrade { get; set; }

		[JsonPropertyName("quantity")]
		[Description("数量")]
		[NotNull]
		public int? Quantity { get; set; }

		[JsonPropertyName("reason_code")]
		[Description("盘点原因 1：其他 2：退货盘点")]
		[NotNull]
		public long? ReasonCode { get; set; }

		[JsonPropertyName("reason_msg")]
		[Description("具体原因")]
		public string ReasonMsg { get; set; }

		[JsonPropertyName("extend")]
		[Description("扩展信息")]
		public Dictionary<string,string> Extend { get; set; }

		[JsonPropertyName("duty")]
		[Description("责任方,  1-服务商原因,  2-商家原因,  3-监管原因,  4-服务商原因（无需赔付）")]
		public string Duty { get; set; }

		[JsonPropertyName("remark")]
		[Description("备注")]
		public string Remark { get; set; }

		[JsonPropertyName("evidence")]
		[Description("证明材料")]
		public List<string> Evidence { get; set; }
	}

	[JsonPropertyName("idempotent_no")]
	[Description("幂等号（建议传入，由调用方生成唯一ID，以防接口调用重试场景重复操作库存）")]
	public string IdempotentNo { get; set; }

	[JsonPropertyName("status")]
	[Description("状态 2-待审核 1-已完成 5-已取消")]
	public long? Status { get; set; }

	[JsonPropertyName("inbound_plan_no")]
	[Description("预约到货单号")]
	public string InboundPlanNo { get; set; }

	[JsonPropertyName("adjust_biz_type")]
	[Description("业务场景,101 库存盘点,102 包耗材盘点,103 包耗材出库,104 库存初始化,105 销退入库,106 系统异常")]
	public int? AdjustBizType { get; set; }

	[JsonPropertyName("owner_id")]
	[Description("货主id")]
	public long? OwnerId { get; set; }
}

[Description("服务商向平台回告库存盘点信息")]
public class CrossborderStockTakingRsp
{
	[JsonPropertyName("code")]
	[Description("响应状态码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("响应状态信息")]
	public string Msg { get; set; }
}
