namespace ecommerce.sdk.douyin;

[Description("获取达人直播间分享物料，包括直播间抖口令、二维码、deeplink和zlink，需要达人百应授权。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效的doudian_open_id","isv.parameter-invalid:4149","无效的doudian_open_id")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","达人未开播","isv.business-failed:4130","达人未开播")]
[DouyinRetCode(50002,"业务处理失败","达人未开通分销业务","isv.business-failed:4129","达人未开通分销业务")]
[DouyinRetCode(50002,"业务处理失败","参数校验失败：无效 PID","isv.business-failed:4102","无效 PID")]
[DouyinRetCode(40004,"非法的参数","回流平台参数非法","isv.parameter-invalid:4122","回流平台参数非法")]
public class BuyinKolLiveShareReq : IDouyinReq<BuyinKolLiveShareRsp>
{

	public string GetMethod() { return "buyin.kolLiveShare"; }

	public string GetUrl() { return "/buyin/kolLiveShare"; }

	[JsonPropertyName("pid_info")]
	[Description("PID信息")]
	[NotNull]
	public PidInfoItem PidInfo { get; set; }

	public class PidInfoItem
	{
		[JsonPropertyName("pid")]
		[Description("达人PID")]
		[NotNull]
		public string Pid { get; set; }

		[JsonPropertyName("external_info")]
		[Description("自定义字段，只允许 数字、字母和_，限制长度为40")]
		public string ExternalInfo { get; set; }
	}

	[JsonPropertyName("need_qr_code")]
	[Description("是否需要二维码(获取二维码将增加响应耗时，推荐false)")]
	public bool? NeedQrCode { get; set; }

	[JsonPropertyName("platform")]
	[Description("回流端标识 0：抖音 1：抖音极速版")]
	public int? Platform { get; set; }

	[JsonPropertyName("need_zlink")]
	[Description("是否需要zlink(默认返回，不需要可以填false)")]
	public bool? NeedZlink { get; set; }
}

[Description("获取达人直播间分享物料，包括直播间抖口令、二维码、deeplink和zlink，需要达人百应授权。")]
public class BuyinKolLiveShareRsp
{
	[JsonPropertyName("data")]
	[Description("结果")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("dy_password")]
		[Description("抖口令")]
		public string DyPassword { get; set; }

		[JsonPropertyName("qr_code")]
		[Description("二维码")]
		public QrCodeItem QrCode { get; set; }

		public class QrCodeItem
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

		[JsonPropertyName("dy_deeplink")]
		[Description("Deeplink，允许外部APP直接唤起抖音直播间")]
		public string DyDeeplink { get; set; }

		[JsonPropertyName("dy_zlink")]
		[Description("Zlink，允许外部APP直接唤起抖音直播间，未安装抖音应用用户，唤起抖音下载页，有效期60天")]
		public string DyZlink { get; set; }
	}
}
