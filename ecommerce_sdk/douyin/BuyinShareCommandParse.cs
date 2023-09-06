namespace ecommerce.sdk.douyin;

[Description("该接口用于商品口令转商品链接，可用于解析已经转链过的商品抖口令")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:256","参数校验失败")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:255","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","非联盟商品","isv.business-failed:4172","非联盟商品")]
[DouyinRetCode(40004,"非法的参数","无效商品口令","isv.parameter-invalid:4171","无效商品口令")]
[DouyinRetCode(50002,"业务处理失败","亲爱的用户，因服务器升级，商品展示可能异常，带来不便，敬请见谅。","isv.business-failed:8193","亲爱的用户，因服务器升级，商品展示可能异常，带来不便，敬请见谅。")]
public class BuyinShareCommandParseReq : IDouyinReq<BuyinShareCommandParseRsp>
{

	public string GetMethod() { return "buyin.shareCommandParse"; }

	public string GetUrl() { return "/buyin/shareCommandParse"; }

	[JsonPropertyName("command")]
	[Description("抖音口令（仅商品口令）")]
	[NotNull]
	public string Command { get; set; }
}

[Description("该接口用于商品口令转商品链接，可用于解析已经转链过的商品抖口令")]
public class BuyinShareCommandParseRsp
{
	[JsonPropertyName("product_info")]
	[Description("商品信息")]
	public ProductInfoItem ProductInfo { get; set; }

	public class ProductInfoItem
	{
		[JsonPropertyName("product_id")]
		[Description("商品ID")]
		public long ProductId { get; set; }

		[JsonPropertyName("title")]
		[Description("商品名称")]
		public string Title { get; set; }

		[JsonPropertyName("price")]
		[Description("商品售价（单位为分）")]
		public long Price { get; set; }

		[JsonPropertyName("cos_ratio")]
		[Description("普通佣金比例（乘100，例如10%为10）")]
		public decimal CosRatio { get; set; }

		[JsonPropertyName("cos_fee")]
		[Description("普通佣金金额（单位为分）")]
		public long CosFee { get; set; }

		[JsonPropertyName("detail_url")]
		[Description("商品链接")]
		public string DetailUrl { get; set; }

		[JsonPropertyName("promotable")]
		[Description("是否可推广（加入联盟且是可推广状态）")]
		public bool Promotable { get; set; }
	}
}
