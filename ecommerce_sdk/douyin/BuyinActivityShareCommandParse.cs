namespace ecommerce.sdk.douyin;

[Description("该接口用于分销活动页口令获取活动页信息，可用于解析已经转链过的活动页抖口令，需获取达人授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(20000,"系统错误","调用下游失败","isp.service-error:4189","调用下游失败")]
[DouyinRetCode(40004,"非法的参数","当前达人没有商品分销功能权限","isv.parameter-invalid:4190","当前达人没有商品分销功能权限")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:257","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效活动页口令","isv.parameter-invalid:4188","无效活动页口令")]
[DouyinRetCode(40004,"非法的参数","活动页口令解析失败","isv.parameter-invalid:4191","活动页口令解析失败")]
[DouyinRetCode(40004,"非法的参数","非频道活动口令","isv.parameter-invalid:4192","非频道活动口令")]
public class BuyinActivityShareCommandParseReq : IDouyinReq<BuyinActivityShareCommandParseRsp>
{

	public string GetMethod() { return "buyin.activityShareCommandParse"; }

	public string GetUrl() { return "/buyin/activityShareCommandParse"; }

	[JsonPropertyName("share_command")]
	[Description("活动页分享口令")]
	[NotNull]
	public string ShareCommand { get; set; }
}

[Description("该接口用于分销活动页口令获取活动页信息，可用于解析已经转链过的活动页抖口令，需获取达人授权")]
public class BuyinActivityShareCommandParseRsp
{
	[JsonPropertyName("activity_id")]
	[Description("1:百亿补贴2:秒杀活动3:自建活 动页")]
	public long ActivityId { get; set; }

	[JsonPropertyName("mix_activity_id")]
	[Description("可推广的运营自建活动页活动 id；activity_id为3时，返回该项")]
	public string MixActivityId { get; set; }

	[JsonPropertyName("activity_url")]
	[Description("支持h5和schema两种形式； activity_id为3时，返回该项")]
	public string ActivityUrl { get; set; }
}
