namespace ecommerce.sdk.douyin;

[Description("该接口用于分销直播间口令获取直播间信息，可用于解析已经转链过的直播间抖口令，需获取抖客授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","无效直播间口令","isv.parameter-invalid:4186","无效直播间口令")]
[DouyinRetCode(40004,"非法的参数","商品信息解析失败","isv.parameter-invalid:4187","商品信息解析失败")]
[DouyinRetCode(20000,"系统错误","调用下游失败","isp.service-error:4189","调用下游失败")]
[DouyinRetCode(40004,"非法的参数","当前抖客未开通直播间分销业务权限","isv.parameter-invalid:4193","当前抖客未开通直播间分销业务权限")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","需【抖客】角色授权后访问","isv.business-failed:4198","需【抖客】角色授权后访问")]
public class BuyinLiveShareCommandParseReq : IDouyinReq<BuyinLiveShareCommandParseRsp>
{

	public string GetMethod() { return "buyin.liveShareCommandParse"; }

	public string GetUrl() { return "/buyin/liveShareCommandParse"; }

	[JsonPropertyName("command")]
	[Description("分销直播间口令")]
	[NotNull]
	public string Command { get; set; }
}

[Description("该接口用于分销直播间口令获取直播间信息，可用于解析已经转链过的直播间抖口令，需获取抖客授权")]
public class BuyinLiveShareCommandParseRsp
{
	[JsonPropertyName("author_buyin_id")]
	[Description("主播百应id")]
	public string AuthorBuyinId { get; set; }

	[JsonPropertyName("product_id")]
	[Description("直播间绑定的商品id，解析出来的product_id专属于该直播间，可能已经失效")]
	public long ProductId { get; set; }
}
