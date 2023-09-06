namespace ecommerce.sdk.douyin;

[Description("1、顺丰极效前置订单放行/回退；,2、顺丰的极效前置类型支持展示在标准区域和自定义区域；①标准区域：235产品类型(右上角)显示:极效前置-预售;或者极效前置“；②自定义区域：商家使用自定义模板编辑器，设置打印项，商家自行设置”前置件“标签打印")]
public class LogisticsDeliveryNoticeReq : IDouyinReq<LogisticsDeliveryNoticeRsp>
{

	public string GetMethod() { return "logistics.deliveryNotice"; }

	public string GetUrl() { return "/logistics/deliveryNotice"; }

	[JsonPropertyName("waybill_no")]
	[Description("运单号")]
	[NotNull]
	public string WaybillNo { get; set; }

	[JsonPropertyName("notice_type")]
	[Description("放行/回退")]
	[NotNull]
	public string NoticeType { get; set; }
}

[Description("1、顺丰极效前置订单放行/回退；,2、顺丰的极效前置类型支持展示在标准区域和自定义区域；①标准区域：235产品类型(右上角)显示:极效前置-预售;或者极效前置“；②自定义区域：商家使用自定义模板编辑器，设置打印项，商家自行设置”前置件“标签打印")]
public class LogisticsDeliveryNoticeRsp
{
	[JsonPropertyName("result")]
	[Description("是否成功")]
	public bool Result { get; set; }
}
