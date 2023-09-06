namespace ecommerce.sdk.douyin;

[Description("商家送检图片质检（线上质检）订单。 订单是图片质检还是实物质检在获取订单质检信息接口有返回")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","2038:鉴定扣已使用","isv.business-failed:2038","更换")]
[DouyinRetCode(50002,"业务处理失败","2027:线下质检订单请通过管理系统进行操作","isv.business-failed:2027","-")]
[DouyinRetCode(50002,"业务处理失败","10000:订单目前不满足送检条件，请检查取消状态或所绑定质检机构","isv.business-failed:10000","-")]
[DouyinRetCode(50002,"业务处理失败","2036:拦截发货时候请先处理退款请求","isv.business-failed:2036","-")]
public class BtasSaveInspectionOnlineReq : IDouyinReq<BtasSaveInspectionOnlineRsp>
{

	public string GetMethod() { return "btas.saveInspectionOnline"; }

	public string GetUrl() { return "/btas/saveInspectionOnline"; }

	[JsonPropertyName("order_id")]
	[Description("父订单（店铺单）编号")]
	[NotNull]
	public string OrderId { get; set; }

	[JsonPropertyName("product_order_id")]
	[Description("商品单ID")]
	[NotNull]
	public string ProductOrderId { get; set; }

	[JsonPropertyName("order_code")]
	[Description("一件商品一个订单码，订单码由字节系统生成。 订单码")]
	[NotNull]
	public string OrderCode { get; set; }

	[JsonPropertyName("service_status")]
	[Description("枚举值 1: 新增   2: 修改")]
	[NotNull]
	public int? ServiceStatus { get; set; }

	[JsonPropertyName("certification_code")]
	[Description("质检扣")]
	[NotNull]
	public string CertificationCode { get; set; }

	[JsonPropertyName("is_original_info")]
	[Description("原盒包装 枚举值 1: 是  2: 否")]
	[NotNull]
	public int? IsOriginalInfo { get; set; }

	[JsonPropertyName("brand_id")]
	[Description("鉴定品牌，列表参数见接口 btas/listBrand")]
	[NotNull]
	public long? BrandId { get; set; }

	[JsonPropertyName("return_intercept_type")]
	[Description("0：发货优先，送检前存在退款申请可通过送检自动拒绝   1：售后优先：送检前存在退款申请则不可送检")]
	[NotNull]
	public int? ReturnInterceptType { get; set; }

	[JsonPropertyName("images")]
	[Description("送检图片")]
	[NotNull]
	public List<ImagesItem> Images { get; set; }

	public class ImagesItem
	{
		[JsonPropertyName("image_id")]
		[Description("图片ID 要求大于0")]
		[NotNull]
		public long? ImageId { get; set; }

		[JsonPropertyName("image_url")]
		[Description("图片链接")]
		[NotNull]
		public string ImageUrl { get; set; }

		[JsonPropertyName("image_comment")]
		[Description("图片备注")]
		public string ImageComment { get; set; }
	}
}

[Description("商家送检图片质检（线上质检）订单。 订单是图片质检还是实物质检在获取订单质检信息接口有返回")]
public class BtasSaveInspectionOnlineRsp
{
}
