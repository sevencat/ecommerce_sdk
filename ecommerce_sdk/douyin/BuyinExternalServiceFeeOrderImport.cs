namespace ecommerce.sdk.douyin;

[Description("支持MCN机构商达合作订单同步至百应平台")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","无效账号类型","isv.parameter-invalid:4398","无效账号类型")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","外部订单ID错误","isv.parameter-invalid:4497","外部订单ID错误")]
[DouyinRetCode(40004,"非法的参数","订单子状态错误","isv.parameter-invalid:4498","订单子状态错误")]
[DouyinRetCode(40004,"非法的参数","商品数量不能超过30个","isv.parameter-invalid:4499","商品数量不能超过30个")]
[DouyinRetCode(40004,"非法的参数","佣金率需在1-100","isv.parameter-invalid:4500","佣金率需在1-100")]
[DouyinRetCode(40004,"非法的参数","约定直播价格需大于0且max需大于min","isv.parameter-invalid:4501","约定直播价格需大于0且max需大于min")]
[DouyinRetCode(40004,"非法的参数","直播形式错误","isv.parameter-invalid:4502","直播形式错误")]
[DouyinRetCode(40004,"非法的参数","无效单品介绍时长","isv.parameter-invalid:4503","无效单品介绍时长")]
[DouyinRetCode(40004,"非法的参数","开播时间起止日期错误","isv.parameter-invalid:4504","开播时间起止日期错误")]
[DouyinRetCode(40004,"非法的参数","无效发货时间","isv.parameter-invalid:4505","无效发货时间")]
[DouyinRetCode(40004,"非法的参数","低价承诺参数错误","isv.parameter-invalid:4506","低价承诺参数错误")]
[DouyinRetCode(40004,"非法的参数","广告投放参数错误","isv.parameter-invalid:4507","广告投放参数错误")]
[DouyinRetCode(40004,"非法的参数","补充约定文案过长","isv.parameter-invalid:4508","补充约定文案过长")]
[DouyinRetCode(40004,"非法的参数","订单元数据不存在","isv.parameter-invalid:4509","订单元数据不存在")]
[DouyinRetCode(40004,"非法的参数","达人不属于机构","isv.parameter-invalid:4510","达人不属于机构")]
[DouyinRetCode(40004,"非法的参数","预期结算额需大于等于0","isv.parameter-invalid:4511","预期结算额需大于等于0")]
[DouyinRetCode(40004,"非法的参数","库存量需大于等于0","isv.parameter-invalid:4512","库存量需大于等于0")]
[DouyinRetCode(40004,"非法的参数","无效用户","isv.parameter-invalid:4157","无效用户")]
public class BuyinExternalServiceFeeOrderImportReq : IDouyinReq<BuyinExternalServiceFeeOrderImportRsp>
{

	public string GetMethod() { return "buyin.externalServiceFeeOrderImport"; }

	public string GetUrl() { return "/buyin/externalServiceFeeOrderImport"; }

	[JsonPropertyName("external_order_id")]
	[Description("外部订单ID")]
	[NotNull]
	public string ExternalOrderId { get; set; }

	[JsonPropertyName("sub_status")]
	[Description("订单子状态。3001：待开播；3003：待补播；4001：待验收；7006：商家同意取消")]
	[NotNull]
	public long? SubStatus { get; set; }

	[JsonPropertyName("kol_account_id")]
	[Description("达人账号ID")]
	[NotNull]
	public string KolAccountId { get; set; }

	[JsonPropertyName("kol_account_type")]
	[Description("达人账号类型。 0：抖音号; 1: 百应ID")]
	[NotNull]
	public int? KolAccountType { get; set; }

	[JsonPropertyName("products")]
	[Description("合作商品列表，不能超过30个")]
	[NotNull]
	public List<ProductsItem> Products { get; set; }

	public class ProductsItem
	{
		[JsonPropertyName("product_url")]
		[Description("商品链接")]
		[NotNull]
		public string ProductUrl { get; set; }

		[JsonPropertyName("live_price_min")]
		[Description("约定直播最低价格，单位分")]
		[NotNull]
		public long? LivePriceMin { get; set; }

		[JsonPropertyName("live_price_max")]
		[Description("约定直播最高价格，单位分")]
		[NotNull]
		public long? LivePriceMax { get; set; }

		[JsonPropertyName("min_stock")]
		[Description("库存量")]
		[NotNull]
		public long? MinStock { get; set; }

		[JsonPropertyName("custom_rate")]
		[Description("佣金率，1-100的整数")]
		[NotNull]
		public long? CustomRate { get; set; }
	}

	[JsonPropertyName("order_type")]
	[Description("合作模式。 1：纯佣金；2：等比例；3：一口价")]
	[NotNull]
	public int? OrderType { get; set; }

	[JsonPropertyName("contract")]
	[Description("协议内容")]
	[NotNull]
	public ContractItem Contract { get; set; }

	public class ContractItem
	{
		[JsonPropertyName("live_type")]
		[Description("直播形式。 1：专场； 2：混场")]
		[NotNull]
		public long? LiveType { get; set; }

		[JsonPropertyName("contact_name")]
		[Description("联系人")]
		public string ContactName { get; set; }

		[JsonPropertyName("contact_phone")]
		[Description("联系人手机号")]
		public string ContactPhone { get; set; }

		[JsonPropertyName("min_gmv")]
		[Description("最低销售额(预期结算额)，单位分")]
		[NotNull]
		public long? MinGmv { get; set; }

		[JsonPropertyName("order_fee")]
		[Description("服务费，单位分")]
		public long? OrderFee { get; set; }

		[JsonPropertyName("live_start_time")]
		[Description("直播开始时间，秒级时间戳")]
		[NotNull]
		public long? LiveStartTime { get; set; }

		[JsonPropertyName("live_end_time")]
		[Description("直播结束时间，秒级时间戳")]
		[NotNull]
		public long? LiveEndTime { get; set; }

		[JsonPropertyName("introduce_duration")]
		[Description("单品介绍时长，单位秒")]
		public long? IntroduceDuration { get; set; }

		[JsonPropertyName("max_deliver_time")]
		[Description("最大发货时间，单位秒")]
		public long? MaxDeliverTime { get; set; }

		[JsonPropertyName("assure_price")]
		[Description("是否保价。 0:约定不保价； 1:约定保价")]
		public long? AssurePrice { get; set; }

		[JsonPropertyName("assure_price_channel")]
		[Description("是否接受渠道等价。 1:全渠道最低价，允许与其他渠道等价； 2:全渠道最低价，不可与其他渠道等价")]
		public long? AssurePriceChannel { get; set; }

		[JsonPropertyName("assure_price_pred")]
		[Description("保价时间前X天")]
		public long? AssurePricePred { get; set; }

		[JsonPropertyName("assure_price_postd")]
		[Description("保价时间后X天")]
		public long? AssurePricePostd { get; set; }

		[JsonPropertyName("ad_act")]
		[Description("是否投放广告 0:约定不投放广告； 1:约定投放广告")]
		public long? AdAct { get; set; }

		[JsonPropertyName("ad_act_amount")]
		[Description("广告投放额，单位分")]
		public long? AdActAmount { get; set; }

		[JsonPropertyName("ad_act_role")]
		[Description("广告投放方。1：商家； 2：达人")]
		public long? AdActRole { get; set; }

		[JsonPropertyName("addon")]
		[Description("其它约定(补充说明，1000字以内)")]
		public string Addon { get; set; }
	}
}

[Description("支持MCN机构商达合作订单同步至百应平台")]
public class BuyinExternalServiceFeeOrderImportRsp
{
	[JsonPropertyName("success")]
	[Description("是否成功")]
	public bool Success { get; set; }
}
