namespace ecommerce.sdk.douyin;

[Description("该接口用于抖客红包转链，需要获取抖客授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","当前抖客未开通直播间分销业务权限","isv.business-failed:4113","当前抖客未开通直播间分销业务权限")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效 PID","isv.parameter-invalid:4102","参数校验失败：无效 PID")]
[DouyinRetCode(40004,"非法的参数","红包不存在","isv.parameter-invalid:4118","红包不存在")]
[DouyinRetCode(40004,"非法的参数","非抖客渠道红包","isv.parameter-invalid:4299","非抖客渠道红包")]
[DouyinRetCode(40004,"非法的参数","红包不是生效状态或已领完","isv.parameter-invalid:4120","红包不是生效状态或已领完")]
[DouyinRetCode(40004,"非法的参数","红包未到或已过领取时间，不可转链","isv.parameter-invalid:4300","红包未到或已过领取时间，不可转链")]
[DouyinRetCode(40004,"非法的参数","红包参数校验失败","isv.parameter-invalid:4298","红包参数校验失败")]
[DouyinRetCode(40004,"非法的参数","无效 external_info","isv.parameter-invalid:4101","参数校验失败：无效 external_info")]
[DouyinRetCode(40004,"非法的参数","抖客红包不支持自营","isv.parameter-invalid:4116","抖客红包不支持自营")]
[DouyinRetCode(50002,"业务处理失败","达人无抖客红包权限","isv.business-failed:4117","达人无抖客红包权限")]
[DouyinRetCode(40004,"非法的参数","红包参数非法","isv.parameter-invalid:4119","红包参数非法")]
public class BuyinShareRedpackReq : IDouyinReq<BuyinShareRedpackRsp>
{

	public string GetMethod() { return "buyin.shareRedpack"; }

	public string GetUrl() { return "/buyin/shareRedpack"; }

	[JsonPropertyName("redpack_id")]
	[Description("红包批次ID")]
	[NotNull]
	public string RedpackId { get; set; }

	[JsonPropertyName("pid")]
	[Description("抖客PID")]
	[NotNull]
	public string Pid { get; set; }

	[JsonPropertyName("external_info")]
	[Description("自定义字段，只允许 数字、字母和_，限制长度为40")]
	public string ExternalInfo { get; set; }

	[JsonPropertyName("need_qr_code")]
	[Description("是否需要二维码(获取二维码将增加响应耗时，推荐false)")]
	public bool? NeedQrCode { get; set; }
}

[Description("该接口用于抖客红包转链，需要获取抖客授权")]
public class BuyinShareRedpackRsp
{
	[JsonPropertyName("data")]
	[Description("结果")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("share_command")]
		[Description("抖口令")]
		public string ShareCommand { get; set; }

		[JsonPropertyName("deep_link")]
		[Description("Deeplink，允许外部APP直接唤起抖音直播间")]
		public string DeepLink { get; set; }

		[JsonPropertyName("qrcode")]
		[Description("二维码")]
		public QrcodeItem Qrcode { get; set; }

		public class QrcodeItem
		{
			[JsonPropertyName("url")]
			[Description("URL")]
			public string Url { get; set; }

			[JsonPropertyName("width")]
			[Description("宽度")]
			public int Width { get; set; }

			[JsonPropertyName("height")]
			[Description("高度")]
			public int Height { get; set; }
		}
	}
}
