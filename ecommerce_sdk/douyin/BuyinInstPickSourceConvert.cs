namespace ecommerce.sdk.douyin;

[Description("商品选品来源转链")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效商品URL","isv.parameter-invalid:1056","无效商品URL")]
[DouyinRetCode(40004,"非法的参数","商品没有加入精选联盟","isv.parameter-invalid:4133","商品没有加入精选联盟")]
[DouyinRetCode(40004,"非法的参数","获取商品信息失败","isv.parameter-invalid:4125","获取商品信息失败")]
public class BuyinInstPickSourceConvertReq : IDouyinReq<BuyinInstPickSourceConvertRsp>
{

	public string GetMethod() { return "buyin.instPickSourceConvert"; }

	public string GetUrl() { return "/buyin/instPickSourceConvert"; }

	[JsonPropertyName("product_url")]
	[Description("商品链接")]
	[NotNull]
	public string ProductUrl { get; set; }

	[JsonPropertyName("pick_extra")]
	[Description("自定义参数（只允许 数字、字母和 _，限制长度为20）")]
	public string PickExtra { get; set; }
}

[Description("商品选品来源转链")]
public class BuyinInstPickSourceConvertRsp
{
	[JsonPropertyName("data")]
	[Description("结果")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("product_url")]
		[Description("转链后的商品链接，链接后pick_source参数有效期为3个月")]
		public string ProductUrl { get; set; }
	}
}
