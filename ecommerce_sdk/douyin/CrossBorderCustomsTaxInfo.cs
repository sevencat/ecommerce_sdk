namespace ecommerce.sdk.douyin;

[Description("服务商向平台回告海关税费信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","1000: 非法的参数","isv.parameter-invalid:1000","检查参数是否正确，若确认参数正确请联系工作人员")]
[DouyinRetCode(50002,"业务处理失败","1005:接口调用异常，请重试，多次失败请人工反馈","isv.business-failed:1005","重试，多次失败联系工作人员")]
public class CrossBorderCustomsTaxInfoReq : IDouyinReq<CrossBorderCustomsTaxInfoRsp>
{

	public string GetMethod() { return "crossBorder.customsTaxInfo"; }

	public string GetUrl() { return "/crossBorder/customsTaxInfo"; }

	[JsonPropertyName("vendor")]
	[Description("字节给供应链服务商定义的编码")]
	[NotNull]
	public string Vendor { get; set; }

	[JsonPropertyName("customs_code")]
	[Description("回执口岸【口岸代码】")]
	[NotNull]
	public string CustomsCode { get; set; }

	[JsonPropertyName("customs_name")]
	[Description("回执口岸【口岸名称】")]
	[NotNull]
	public string CustomsName { get; set; }

	[JsonPropertyName("customs_tax_data")]
	[Description("税费信息")]
	[NotNull]
	public CustomsTaxDataItem CustomsTaxData { get; set; }

	public class CustomsTaxDataItem
	{
		[JsonPropertyName("order_id")]
		[Description("字节电商平台的交易订单号")]
		[NotNull]
		public string OrderId { get; set; }

		[JsonPropertyName("invt_no")]
		[Description("进口清单编号 (宁波 非必传)")]
		public string InvtNo { get; set; }

		[JsonPropertyName("tax_no")]
		[Description("电子税单编号 (宁波 非必传)")]
		public string TaxNo { get; set; }

		[JsonPropertyName("ebc_name")]
		[Description("电商企业名称 (宁波 必传)")]
		public string EbcName { get; set; }

		[JsonPropertyName("return_time")]
		[Description("回执时间 秒时间戳")]
		[NotNull]
		public string ReturnTime { get; set; }

		[JsonPropertyName("customs_tax")]
		[Description("应征关税，例如2.16元传2.16")]
		[NotNull]
		public string CustomsTax { get; set; }

		[JsonPropertyName("value_added_tax")]
		[Description("应征增值税，例如2.16元传2.16")]
		[NotNull]
		public string ValueAddedTax { get; set; }

		[JsonPropertyName("consumption_tax")]
		[Description("应征消费税，例如2.16元传2.16")]
		[NotNull]
		public string ConsumptionTax { get; set; }

		[JsonPropertyName("status")]
		[Description("(宁波 非必传) 海关税单状态  1-已生成，2-已汇总 3-作废")]
		public int? Status { get; set; }

		[JsonPropertyName("tax_detail_list")]
		[Description("商品税费列表")]
		[NotNull]
		public List<TaxDetailListItem> TaxDetailList { get; set; }

		public class TaxDetailListItem
		{
			[JsonPropertyName("gnum")]
			[Description("商品项号")]
			[NotNull]
			public int? Gnum { get; set; }

			[JsonPropertyName("gcode")]
			[Description("海关商品编码 (宁波传HS编码)")]
			[NotNull]
			public string Gcode { get; set; }

			[JsonPropertyName("tax_price")]
			[Description("完税总价格，例如23.74元传23.74")]
			public string TaxPrice { get; set; }

			[JsonPropertyName("customs_tax")]
			[Description("关税，例如2.16元传2.16")]
			[NotNull]
			public string CustomsTax { get; set; }

			[JsonPropertyName("value_added_tax")]
			[Description("增值税，例如2.16元传2.16")]
			[NotNull]
			public string ValueAddedTax { get; set; }

			[JsonPropertyName("consumption_tax")]
			[Description("消费税，例如2.16元传2.16")]
			[NotNull]
			public string ConsumptionTax { get; set; }
		}
	}
}

[Description("服务商向平台回告海关税费信息")]
public class CrossBorderCustomsTaxInfoRsp
{
	[JsonPropertyName("code")]
	[Description("成功就是0")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("响应msg")]
	public string Msg { get; set; }
}
