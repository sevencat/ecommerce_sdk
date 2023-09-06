namespace ecommerce.sdk.douyin;

[Description("设置sku发货时效,设置sku在某仓的发货时效")]
public class PromiseSetSkuShipTimeReq : IDouyinReq<PromiseSetSkuShipTimeRsp>
{

	public string GetMethod() { return "promise.setSkuShipTime"; }

	public string GetUrl() { return "/promise/setSkuShipTime"; }

	[JsonPropertyName("rules")]
	[Description("sku发货时效规则")]
	[NotNull]
	public List<RulesItem> Rules { get; set; }

	public class RulesItem
	{
		[JsonPropertyName("sku_id")]
		[Description("skuid")]
		[NotNull]
		public string SkuId { get; set; }

		[JsonPropertyName("out_warehouse_id")]
		[Description("外部仓库id")]
		[NotNull]
		public string OutWarehouseId { get; set; }

		[JsonPropertyName("pre_sell_type")]
		[Description("0表示现货模式，1表示全款预售模式")]
		[NotNull]
		public short? PreSellType { get; set; }

		[JsonPropertyName("delay_day")]
		[Description("发货延迟时间：0表示当天发货，1表示24小时发货；当全款预售时，需传入值为(2,15)，即2-15中的任意值")]
		[NotNull]
		public short? DelayDay { get; set; }

		[JsonPropertyName("pre_sell_end_time")]
		[Description("全款预售截止时间，和PreSellType=1时组合使用")]
		[NotNull]
		public long? PreSellEndTime { get; set; }
	}
}

[Description("设置sku发货时效,设置sku在某仓的发货时效")]
public class PromiseSetSkuShipTimeRsp
{
}
