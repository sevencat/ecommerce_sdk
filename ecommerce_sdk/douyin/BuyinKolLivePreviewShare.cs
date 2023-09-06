namespace ecommerce.sdk.douyin;

[Description("达人直播预告转链，只能转链达人自己未到开播时间的直播预告")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:4097","参数错误")]
[DouyinRetCode(40004,"非法的参数","直播预约不存在或已删除/预告不属于该达人","isv.parameter-invalid:4123","直播预约不存在或已删除/预告不属于该达人")]
[DouyinRetCode(50002,"业务处理失败","达人已开播","isv.business-failed:4124","达人已开播")]
[DouyinRetCode(20000,"系统错误","直播预告转链异常","isp.service-error:4125","直播预告转链异常")]
[DouyinRetCode(40004,"非法的参数","回流平台参数非法","isv.parameter-invalid:4122","回流平台参数非法")]
public class BuyinKolLivePreviewShareReq : IDouyinReq<BuyinKolLivePreviewShareRsp>
{

	public string GetMethod() { return "buyin.kolLivePreviewShare"; }

	public string GetUrl() { return "/buyin/kolLivePreviewShare"; }

	[JsonPropertyName("live_appointment_id")]
	[Description("直播预告Id")]
	[NotNull]
	public string LiveAppointmentId { get; set; }

	[JsonPropertyName("pid")]
	[Description("pid")]
	[NotNull]
	public string Pid { get; set; }

	[JsonPropertyName("platform")]
	[Description("回流端标识 0：抖音 1：抖音极速版")]
	public int? Platform { get; set; }

	[JsonPropertyName("external_info")]
	[Description("自定义字段，只允许 数字、字母和_，限制长度为40")]
	public string ExternalInfo { get; set; }
}

[Description("达人直播预告转链，只能转链达人自己未到开播时间的直播预告")]
public class BuyinKolLivePreviewShareRsp
{
	[JsonPropertyName("data")]
	[Description("直播预告转链数据")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("share_command")]
		[Description("口令")]
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
			[Description("图片路径")]
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
