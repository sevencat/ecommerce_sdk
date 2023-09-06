namespace ecommerce.sdk.douyin;

[Description("服务商向平台回告库存类型变动信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","幂等调用异常","isv.parameter-invalid:1007","请使用唯一幂等键")]
[DouyinRetCode(50002,"业务处理失败","1005:接口调用异常，请重试，多次失败请人工反馈","isv.business-failed:1005","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","9001:调用货品中心有误","isv.business-failed:9001","请稍后重试")]
public class CrossborderStockTransformReq : IDouyinReq<CrossborderStockTransformRsp>
{

	public string GetMethod() { return "crossborder.stockTransform"; }

	public string GetUrl() { return "/crossborder/stockTransform"; }

	[JsonPropertyName("transform_type")]
	[Description("库存变动类型 1：良转次 2：次转良")]
	[NotNull]
	public long? TransformType { get; set; }

	[JsonPropertyName("vendor")]
	[Description("服务商编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("服务商仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("shop_id")]
	[Description("店铺id")]
	public long? ShopId { get; set; }

	[JsonPropertyName("occurrence_time")]
	[Description("库存类型变动时间戳 单位：s")]
	[NotNull]
	public long? OccurrenceTime { get; set; }

	[JsonPropertyName("remark")]
	[Description("备注")]
	public string Remark { get; set; }

	[JsonPropertyName("stock_transform_details")]
	[Description("货品类型变动信息")]
	[NotNull]
	public List<StockTransformDetailsItem> StockTransformDetails { get; set; }

	public class StockTransformDetailsItem
	{
		[JsonPropertyName("cargo_code")]
		[Description("货品编码")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("from_grade")]
		[Description("调整前质量等级 1:良品 2:次品")]
		[NotNull]
		public long? FromGrade { get; set; }

		[JsonPropertyName("to_grade")]
		[Description("调整后质量等级 1:良品 2:次品")]
		[NotNull]
		public long? ToGrade { get; set; }

		[JsonPropertyName("quantity")]
		[Description("调整数量")]
		[NotNull]
		public int? Quantity { get; set; }

		[JsonPropertyName("reason_code")]
		[Description("调整原因编码 1：其他")]
		[NotNull]
		public long? ReasonCode { get; set; }

		[JsonPropertyName("reason_msg")]
		[Description("具体原因信息")]
		public string ReasonMsg { get; set; }

		[JsonPropertyName("extend")]
		[Description("扩展信息")]
		public Dictionary<string,string> Extend { get; set; }

		[JsonPropertyName("duty")]
		[Description("责任方,  1-服务商原因,  2-商家原因")]
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
	[Description("状态,2-待审核 1-已完成 5-已取消")]
	public long? Status { get; set; }

	[JsonPropertyName("inbound_plan_no")]
	[Description("预约到货单号")]
	public string InboundPlanNo { get; set; }

	[JsonPropertyName("adjust_biz_type")]
	[Description("业务场景,,201 库内商品正转残,202 库内商品残转正,203 库存批次属性转移,204 库内商品过期转残")]
	public int? AdjustBizType { get; set; }

	[JsonPropertyName("owner_id")]
	[Description("货主id")]
	public long? OwnerId { get; set; }
}

[Description("服务商向平台回告库存类型变动信息")]
public class CrossborderStockTransformRsp
{
	[JsonPropertyName("code")]
	[Description("响应状态码")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("响应状态信息")]
	public string Msg { get; set; }
}
