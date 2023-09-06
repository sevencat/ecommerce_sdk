namespace ecommerce.sdk.douyin;

[Description("编辑尺码模板")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统处理异常","isp.service-error:2010001","系统处理异常，咨询研发人员")]
[DouyinRetCode(40002,"缺少必选参数","参数缺失","isv.missing-parameter:2010003","根据返回信息提示检查参数")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:2010004","根据返回信息提示检查参数")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2010011","系统处理异常，咨询研发人员")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:2010012","系统处理异常，咨询研发人员")]
public class ProductEditComponentTemplateReq : IDouyinReq<ProductEditComponentTemplateRsp>
{

	public string GetMethod() { return "product.editComponentTemplate"; }

	public string GetUrl() { return "/product/editComponentTemplate"; }

	[JsonPropertyName("template_id")]
	[Description("模板ID")]
	[NotNull]
	public long? TemplateId { get; set; }

	[JsonPropertyName("template_name")]
	[Description("模板名称")]
	public string TemplateName { get; set; }

	[JsonPropertyName("component_data")]
	[Description("模板数据json")]
	public string ComponentData { get; set; }

	[JsonPropertyName("shareable")]
	[Description("是否为公有模板(多个商品可共用)")]
	public bool? Shareable { get; set; }
}

[Description("编辑尺码模板")]
public class ProductEditComponentTemplateRsp
{
}
