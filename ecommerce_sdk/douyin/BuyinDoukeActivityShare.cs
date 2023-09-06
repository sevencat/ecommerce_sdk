namespace ecommerce.sdk.douyin;

[Description("活动页转链接口，转链百亿补贴、秒杀活动、自建活动页")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效 PID","isv.parameter-invalid:4102","参数校验失败：无效 PID")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","回流平台参数非法","isv.parameter-invalid:4122","回流平台参数非法")]
[DouyinRetCode(50002,"业务处理失败","需对应角色正确授权后访问","isv.business-failed:8196","需对应角色正确授权后访问")]
[DouyinRetCode(50002,"业务处理失败","不支持的百应账户类型","isv.business-failed:4413","不支持的百应账户类型")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效 external_info","isv.parameter-invalid:4101","参数校验失败：无效 external_info")]
[DouyinRetCode(50002,"业务处理失败","服务打瞌睡了，请稍后再试","isv.business-failed:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","未知错误","isv.business-failed:255","未知错误")]
[DouyinRetCode(50002,"业务处理失败","暂不支持当前活动转链","isv.business-failed:414","暂不支持当前活动转链")]
[DouyinRetCode(50002,"业务处理失败","活动信息不存在","isv.business-failed:4421","活动信息不存在")]
[DouyinRetCode(50002,"业务处理失败","当前抖客未开通商品/活动页分销权限","isv.business-failed:4410","当前抖客未开通商品/活动页分销权限")]
[DouyinRetCode(50002,"业务处理失败","当前活动页转链参数有误","isv.business-failed:4419","当前活动页转链参数有误（比如请输入正确商品id）")]
public class BuyinDoukeActivityShareReq : IDouyinReq<BuyinDoukeActivityShareRsp>
{

	public string GetMethod() { return "buyin.doukeActivityShare"; }

	public string GetUrl() { return "/buyin/doukeActivityShare"; }

	[JsonPropertyName("material_id")]
	[Description("活动页物料ID")]
	[NotNull]
	public long? MaterialId { get; set; }

	[JsonPropertyName("pid")]
	[Description("抖客PID")]
	[NotNull]
	public string Pid { get; set; }

	[JsonPropertyName("need_qr_code")]
	[Description("是否需要二维码（生成二维码会增加接口耗时）")]
	[NotNull]
	public bool? NeedQrCode { get; set; }

	[JsonPropertyName("external_info")]
	[Description("自定义字段，只允许 数字、字母和_，限制长度为40")]
	public string ExternalInfo { get; set; }

	[JsonPropertyName("platform")]
	[Description("回流端标识 0：抖音 1：抖音极速版")]
	public int? Platform { get; set; }

	[JsonPropertyName("extra_params")]
	[Description("活动页转链自定义参数，json格式，键值都是字符串")]
	public string ExtraParams { get; set; }

	[JsonPropertyName("product_id")]
	[Description("活动页面置顶商品ID（仅支持秒杀、超值购、超市频道）")]
	public long? ProductId { get; set; }

	[JsonPropertyName("need_zlink")]
	[Description("是否需要zlink（默认返回，生成zlink会增加接口耗时）")]
	public bool? NeedZlink { get; set; }
}

[Description("活动页转链接口，转链百亿补贴、秒杀活动、自建活动页")]
public class BuyinDoukeActivityShareRsp
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
		[Description("Deeplink，允许外部APP直接唤起抖音")]
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
			[Description("图片宽度")]
			public int Width { get; set; }

			[JsonPropertyName("height")]
			[Description("图片高度")]
			public int Height { get; set; }
		}

		[JsonPropertyName("z_link")]
		[Description("Zlink，允许外部APP直接唤起抖音直播间，未安装抖音应用用户，唤起抖音下载页，有效期60天")]
		public string ZLink { get; set; }
	}
}
