namespace ecommerce.sdk.douyin;

[Description("机会品提报进度查询,获取平台商机，发布机会商品，指定商品有机会获得平台流量扶持、头部达人带货等多种权益。,,该接口可以获取机会品提报的进度。")]
public class OpptyProductGetApplyProgressReq : IDouyinReq<OpptyProductGetApplyProgressRsp>
{

	public string GetMethod() { return "opptyProduct.getApplyProgress"; }

	public string GetUrl() { return "/opptyProduct/getApplyProgress"; }

	[JsonPropertyName("product_id")]
	[Description("商品ID")]
	[NotNull]
	public long? ProductId { get; set; }

	[JsonPropertyName("origin")]
	[Description("机会品来源。ISV代表服务商")]
	[NotNull]
	public string Origin { get; set; }

	[JsonPropertyName("type")]
	[Description("机会品类型。NEW代表新品")]
	[NotNull]
	public string Type { get; set; }
}

[Description("机会品提报进度查询,获取平台商机，发布机会商品，指定商品有机会获得平台流量扶持、头部达人带货等多种权益。,,该接口可以获取机会品提报的进度。")]
public class OpptyProductGetApplyProgressRsp
{
	[JsonPropertyName("status")]
	[Description("机会品提报状态编码")]
	public string Status { get; set; }

	[JsonPropertyName("status_desc")]
	[Description("机会品提报状态中文描述")]
	public string StatusDesc { get; set; }
}
