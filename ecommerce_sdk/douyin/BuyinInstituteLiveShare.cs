namespace ecommerce.sdk.douyin;

[Description("抖客获取达人直播间分享物料，包括直播间抖口令、二维码、deeplink和zlink，需要抖客百应授权。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效的doudian_open_id","isv.parameter-invalid:4149","无效的doudian_open_id")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","达人未开播","isv.business-failed:4130","达人未开播")]
[DouyinRetCode(50002,"业务处理失败","达人未开通分销业务","isv.business-failed:4129","达人未开通分销业务")]
[DouyinRetCode(40004,"非法的参数","无效 PID","isv.parameter-invalid:4102","无效 PID")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(50002,"业务处理失败","当前机构或商家尚未开通分销权限","isv.business-failed:4105","参数校验失败")]
[DouyinRetCode(20000,"系统错误","未知错误","isp.service-error:255","未知错误")]
[DouyinRetCode(50002,"业务处理失败","获取用户分销信息失败","isv.business-failed:4128","获取用户分销信息失败")]
[DouyinRetCode(40004,"非法的参数","无效 external_info","isv.parameter-invalid:4101","无效 external_info")]
[DouyinRetCode(50002,"业务处理失败","当前达人未开通分销采买业务权限","isv.business-failed:4112","当前达人未开通分销采买业务权限")]
[DouyinRetCode(50002,"业务处理失败","当前抖客未开通直播间分销业务权限","isv.business-failed:4113","当前抖客未开通直播间分销业务权限")]
[DouyinRetCode(40004,"非法的参数","无效百应ID","isv.parameter-invalid:4098","无效百应ID")]
[DouyinRetCode(50002,"业务处理失败","当前直播间找不到该商品","isv.business-failed:4114","当前直播间找不到该商品")]
[DouyinRetCode(50002,"业务处理失败","无效直播间口令","isv.business-failed:4147","无效直播间口令")]
[DouyinRetCode(50002,"业务处理失败","需【抖客】角色授权后访问","isv.business-failed:8194","需【抖客】角色授权后访问")]
[DouyinRetCode(40004,"非法的参数","回流平台参数非法","isv.parameter-invalid:4122","回流平台参数非法")]
[DouyinRetCode(50002,"业务处理失败","当前抖客未开通直播间分销权限","isv.business-failed:4411","当前抖客未开通直播间分销权限")]
[DouyinRetCode(50002,"业务处理失败","当前抖客尚未开通结算账户","isv.business-failed:4404","当前抖客尚未开通结算账户")]
public class BuyinInstituteLiveShareReq : IDouyinReq<BuyinInstituteLiveShareRsp>
{

	public string GetMethod() { return "buyin.instituteLiveShare"; }

	public string GetUrl() { return "/buyin/instituteLiveShare"; }

	[JsonPropertyName("pid_info")]
	[Description("PID信息")]
	[NotNull]
	public PidInfoItem PidInfo { get; set; }

	public class PidInfoItem
	{
		[JsonPropertyName("pid")]
		[Description("抖客PID")]
		[NotNull]
		public string Pid { get; set; }

		[JsonPropertyName("external_info")]
		[Description("自定义字段，只允许 数字、字母和_，限制长度为40")]
		public string ExternalInfo { get; set; }
	}

	[JsonPropertyName("open_id")]
	[Description("抖店用户open_id【废弃，将下线】")]
	public string OpenId { get; set; }

	[JsonPropertyName("buyin_id")]
	[Description("主播百应ID (buyinId和dy_code最少填一项)")]
	public string BuyinId { get; set; }

	[JsonPropertyName("need_qr_code")]
	[Description("是否需要二维码(获取二维码将增加响应耗时，推荐false)")]
	public bool? NeedQrCode { get; set; }

	[JsonPropertyName("dy_code")]
	[Description("直播间口令或者短链接（优先级 buyin_id > open_id > dy_code）） (buyinId和dy_code最少填一项)")]
	public string DyCode { get; set; }

	[JsonPropertyName("product_id")]
	[Description("直播间绑定的商品id，回流唤起对应商详页")]
	public long? ProductId { get; set; }

	[JsonPropertyName("platform")]
	[Description("回流端标识 0：抖音 1：抖音极速版")]
	public int? Platform { get; set; }

	[JsonPropertyName("need_zlink")]
	[Description("是否需要zlink，默认返回，不需要可填false")]
	public bool? NeedZlink { get; set; }
}

[Description("抖客获取达人直播间分享物料，包括直播间抖口令、二维码、deeplink和zlink，需要抖客百应授权。")]
public class BuyinInstituteLiveShareRsp
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
