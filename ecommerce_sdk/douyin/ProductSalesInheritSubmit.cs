namespace ecommerce.sdk.douyin;

[Description("1、提报全网销量（批量），一次最多提报20条，提交成功仅表示提交成功，不表示审核通过;  2、submit_sales_num最小销量上传销量不能低于100个，注意submit_sales_num为商家提交销量，实际展示销量以【/product/salesInherit/submitList】查询接口返回的实际销量展示为准。  3、提交成功后会有审核，工作日审核周期1~3个工作日，节假日顺延；请做好销量查询接口【/product/salesInherit/submitList】的定时查询逻辑，建议天维度查询审核状态即可；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数异常","isv.parameter-invalid:500","请检查参数")]
[DouyinRetCode(50002,"业务处理失败","权限异常","isv.business-failed:401","请检查店铺权限开通情况")]
public class ProductSalesInheritSubmitReq : IDouyinReq<ProductSalesInheritSubmitRsp>
{

	public string GetMethod() { return "product.salesInherit.submit"; }

	public string GetUrl() { return "/product/salesInherit/submit"; }

	[JsonPropertyName("submit_records")]
	[Description("提报记录列表（不超过20条）")]
	[NotNull]
	public List<SubmitRecordsItem> SubmitRecords { get; set; }

	public class SubmitRecordsItem
	{
		[JsonPropertyName("platform_id")]
		[Description("站外平台类型；1-淘宝；当前仅支持1，后续有支持站外多平台规划，请开发者做好预留。")]
		[NotNull]
		public long? PlatformId { get; set; }

		[JsonPropertyName("product_id")]
		[Description("抖店店铺商品id")]
		[NotNull]
		public long? ProductId { get; set; }

		[JsonPropertyName("outside_product_id")]
		[Description("同主体站外店铺商品id，")]
		[NotNull]
		public long? OutsideProductId { get; set; }

		[JsonPropertyName("submit_sales_num")]
		[Description("站外商品30天内销量；最小销量上传销量不能低于100个")]
		[NotNull]
		public long? SubmitSalesNum { get; set; }
	}
}

[Description("1、提报全网销量（批量），一次最多提报20条，提交成功仅表示提交成功，不表示审核通过;  2、submit_sales_num最小销量上传销量不能低于100个，注意submit_sales_num为商家提交销量，实际展示销量以【/product/salesInherit/submitList】查询接口返回的实际销量展示为准。  3、提交成功后会有审核，工作日审核周期1~3个工作日，节假日顺延；请做好销量查询接口【/product/salesInherit/submitList】的定时查询逻辑，建议天维度查询审核状态即可；")]
public class ProductSalesInheritSubmitRsp
{
	[JsonPropertyName("success_product_ids")]
	[Description("提报成功站内商品id列表")]
	public List<long> SuccessProductIds { get; set; }

	[JsonPropertyName("failed_product_list")]
	[Description("提报失败商品列表")]
	public List<FailedProductListItem> FailedProductList { get; set; }

	public class FailedProductListItem
	{
		[JsonPropertyName("product_id")]
		[Description("提报失败站内商品id")]
		public long ProductId { get; set; }

		[JsonPropertyName("failed_msg")]
		[Description("失败原因描述")]
		public string FailedMsg { get; set; }
	}
}
