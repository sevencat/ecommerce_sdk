namespace ecommerce.sdk.douyin;

[Description("活动页转链接口，转链百亿补贴、秒杀活动、自建活动页")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效 PID","isv.parameter-invalid:4102","参数校验失败：无效 PID")]
[DouyinRetCode(40004,"非法的参数","ActivityId参数非法","isv.parameter-invalid:4154","ActivityId参数非法")]
[DouyinRetCode(50002,"业务处理失败","系统繁忙，此时请开发者稍候再试","isv.business-failed:2100004","系统繁忙，此时请开发者稍候再试")]
[DouyinRetCode(50002,"业务处理失败","活动页转链失败，请确保参数正常","isv.business-failed:1111","活动页转链失败，请确保参数正常")]
[DouyinRetCode(50002,"业务处理失败","MixActivityId参数非法","isv.business-failed:4153","MixActivityId参数非法")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","参数校验失败：无效 external_info","isv.business-failed:4101","参数校验失败：无效 external_info")]
[DouyinRetCode(50002,"业务处理失败","当前达人未开通海淘账户","isv.business-failed:4152","当前达人未开通海淘账户")]
[DouyinRetCode(50002,"业务处理失败","当前达人未开通结算账户","isv.business-failed:4151","当前达人未开通结算账户")]
[DouyinRetCode(50002,"业务处理失败","未知错误","isv.business-failed:255","未知错误")]
[DouyinRetCode(50002,"业务处理失败","当前达人没有商品分销功能权限","isv.business-failed:4111","当前达人没有商品分销功能权限")]
[DouyinRetCode(40004,"非法的参数","回流平台参数非法","isv.parameter-invalid:4122","回流平台参数非法")]
[DouyinRetCode(40004,"非法的参数","需【达人】角色授权后访问","isv.parameter-invalid:8195","需【达人】角色授权后访问")]
[DouyinRetCode(50002,"业务处理失败","暂不支持当前活动转链","isv.business-failed:414","暂不支持当前活动转链")]
[DouyinRetCode(50002,"业务处理失败","不支持的百应账户类型","isv.business-failed:4413","不支持的百应账户类型")]
[DouyinRetCode(50002,"业务处理失败","暂不支持当前活动转链","isv.business-failed:4420","不支持的百应账户类型")]
public class BuyinActivityShareConvertReq : IDouyinReq<BuyinActivityShareConvertRsp>
{

	public string GetMethod() { return "buyin.activityShareConvert"; }

	public string GetUrl() { return "/buyin/activityShareConvert"; }

	[JsonPropertyName("activity_id")]
	[Description("1:百亿补贴 2:秒杀活动 3:自建活动页")]
	[NotNull]
	public long? ActivityId { get; set; }

	[JsonPropertyName("pid")]
	[Description("必须是达人的PID")]
	[NotNull]
	public string Pid { get; set; }

	[JsonPropertyName("need_qr_code")]
	[Description("是否需要二维码（生成二维码会增加接口耗时）")]
	[NotNull]
	public bool? NeedQrCode { get; set; }

	[JsonPropertyName("external_info")]
	[Description("自定义字段，只允许 数字、字母和_，限制长度为40")]
	public string ExternalInfo { get; set; }

	[JsonPropertyName("mix_activity_id")]
	[Description("可推广的运营自建活动页活动id；activity_id为3时，该项必填")]
	public string MixActivityId { get; set; }

	[JsonPropertyName("activity_url")]
	[Description("可推广的运营自建活动页链接，支持 h5 和 schema 两种形式；可不填")]
	public string ActivityUrl { get; set; }

	[JsonPropertyName("platform")]
	[Description("回流端标识 0：抖音 1：抖音极速版")]
	public int? Platform { get; set; }

	[JsonPropertyName("product_id")]
	[Description("超值购&秒杀置顶商品ID")]
	public long? ProductId { get; set; }
}

[Description("活动页转链接口，转链百亿补贴、秒杀活动、自建活动页")]
public class BuyinActivityShareConvertRsp
{
	[JsonPropertyName("data")]
	[Description("转链数据")]
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
			[Description("图片URL")]
			public string Url { get; set; }

			[JsonPropertyName("width")]
			[Description("宽度")]
			public int Width { get; set; }

			[JsonPropertyName("height")]
			[Description("高度")]
			public int Height { get; set; }
		}

		[JsonPropertyName("zlink")]
		[Description("Zlink，允许外部APP直接唤起抖音直播间，未安装抖音应用用户，唤起抖音下载页，有效期60天")]
		public string Zlink { get; set; }
	}
}
