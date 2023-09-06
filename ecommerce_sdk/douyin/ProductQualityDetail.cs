namespace ecommerce.sdk.douyin;

[Description("商品信息质量分查询API,根据商品ID查询商品质量分")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统异常","isp.service-error:2030001","等待后重试")]
[DouyinRetCode(50002,"业务处理失败","处理超时","isv.business-failed:2030002","等待后重试")]
[DouyinRetCode(40002,"缺少必选参数","缺少必要参数","isv.missing-parameter:2030003","补充必要参数")]
[DouyinRetCode(40004,"非法的参数","参数值非法","isv.parameter-invalid:2030004","按要求填写参数值")]
[DouyinRetCode(50002,"业务处理失败","读取商品失败","isv.business-failed:2030013","请稍后重试")]
public class ProductQualityDetailReq : IDouyinReq<ProductQualityDetailRsp>
{

	public string GetMethod() { return "product.qualityDetail"; }

	public string GetUrl() { return "/product/qualityDetail"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }
}

[Description("商品信息质量分查询API,根据商品ID查询商品质量分")]
public class ProductQualityDetailRsp
{
	[JsonPropertyName("field_problem")]
	[Description("可优化问题项")]
	public List<FieldProblemItem> FieldProblem { get; set; }

	public class FieldProblemItem
	{
		[JsonPropertyName("field_key")]
		[Description("字段key，category-类目、props-属性、product_name-标题、pic-主图、desc_pic-详情图片、desc_text-详情文字")]
		public string FieldKey { get; set; }

		[JsonPropertyName("field_name")]
		[Description("字段名")]
		public string FieldName { get; set; }

		[JsonPropertyName("problem_key")]
		[Description("问题编码")]
		public long ProblemKey { get; set; }

		[JsonPropertyName("problem_name")]
		[Description("问题名")]
		public string ProblemName { get; set; }

		[JsonPropertyName("suggestion")]
		[Description("问题建议")]
		public string Suggestion { get; set; }

		[JsonPropertyName("problem_type")]
		[Description("问题类型编码")]
		public long ProblemType { get; set; }
	}

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	public long ProductId { get; set; }

	[JsonPropertyName("product_name")]
	[Description("商品名字")]
	public string ProductName { get; set; }
}
