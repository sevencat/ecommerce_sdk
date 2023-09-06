namespace ecommerce.sdk.douyin;

[Description("该接口用于 解析&转链 抖口令和短链。,1. 可用于解析转链、抖音分享的抖口令和短链，获取口令类型及对应口令信息。,2. 提供对应口令类型的转链能力")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","当前口令无效","isv.parameter-invalid:4446","当前口令无效")]
[DouyinRetCode(40004,"非法的参数","当前口令无效","isv.parameter-invalid:4447","当前口令无效")]
[DouyinRetCode(40004,"非法的参数","无效直播预告口令","isv.parameter-invalid:4448","无效直播预告口令")]
[DouyinRetCode(40004,"非法的参数","无效红包口令","isv.parameter-invalid:4449","无效红包口令")]
[DouyinRetCode(40004,"非法的参数","无效活动口令","isv.parameter-invalid:4450","无效活动口令")]
[DouyinRetCode(40004,"非法的参数","当前口令暂不支持解析","isv.parameter-invalid:4451","当前口令暂不支持解析")]
[DouyinRetCode(40004,"非法的参数","无效直播间口令","isv.parameter-invalid:4147","无效直播间口令")]
[DouyinRetCode(40004,"非法的参数","无效商品口令","isv.parameter-invalid:4148","无效商品口令")]
[DouyinRetCode(20001,"内部服务超时","服务打瞌睡了，请稍后再试","isp.service-timeout-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","需对应角色正确授权后访问","isv.parameter-invalid:8196","需对应角色正确授权后访问")]
public class BuyinDoukeCommandParseAndShareReq : IDouyinReq<BuyinDoukeCommandParseAndShareRsp>
{

	public string GetMethod() { return "buyin.doukeCommandParseAndShare"; }

	public string GetUrl() { return "/buyin/doukeCommandParseAndShare"; }

	[JsonPropertyName("command")]
	[Description("抖口令或短链")]
	[NotNull]
	public string Command { get; set; }

	[JsonPropertyName("share_params")]
	[Description("转链参数，无需转链可不传")]
	public ShareParamsItem ShareParams { get; set; }

	public class ShareParamsItem
	{
		[JsonPropertyName("pid")]
		[Description("抖客PID")]
		public string Pid { get; set; }

		[JsonPropertyName("external_info")]
		[Description("自定义字段，只允许 数字、字母和_，限制长度为40")]
		public string ExternalInfo { get; set; }

		[JsonPropertyName("need_share_info_field")]
		[Description("所需的转链分享物料，默认仅返回deeplink（建议按需获取，获取多种会导致响应耗时增加）")]
		public NeedShareInfoFieldItem NeedShareInfoField { get; set; }

		public class NeedShareInfoFieldItem
		{
			[JsonPropertyName("need_share_command")]
			[Description("是否需要口令")]
			public bool? NeedShareCommand { get; set; }

			[JsonPropertyName("need_qrcode")]
			[Description("是否需要二维码")]
			public bool? NeedQrcode { get; set; }

			[JsonPropertyName("need_zlink")]
			[Description("是否需要zlink")]
			public bool? NeedZlink { get; set; }

			[JsonPropertyName("need_share_link")]
			[Description("是否需要站外H5链接（仅商品生效）")]
			public bool? NeedShareLink { get; set; }
		}

		[JsonPropertyName("platform")]
		[Description("回流端标识 0：抖音 1：抖音极速版")]
		public int? Platform { get; set; }
	}
}

[Description("该接口用于 解析&转链 抖口令和短链。,1. 可用于解析转链、抖音分享的抖口令和短链，获取口令类型及对应口令信息。,2. 提供对应口令类型的转链能力")]
public class BuyinDoukeCommandParseAndShareRsp
{
	[JsonPropertyName("command_info")]
	[Description("口令信息")]
	public CommandInfoItem CommandInfo { get; set; }

	public class CommandInfoItem
	{
		[JsonPropertyName("command_type")]
		[Description("口令类型 1:商品 2:直播间 3:直播预告 4:活动页 5:抖客红包 6:商品优惠")]
		public short CommandType { get; set; }

		[JsonPropertyName("product_info")]
		[Description("商品信息，command_type为1或6返回该项")]
		public ProductInfoItem ProductInfo { get; set; }

		public class ProductInfoItem
		{
			[JsonPropertyName("product_id")]
			[Description("商品ID")]
			public long ProductId { get; set; }

			[JsonPropertyName("ins_activity_param")]
			[Description("团长参数")]
			public string InsActivityParam { get; set; }

			[JsonPropertyName("share_info")]
			[Description("转链分享物料")]
			public ShareInfoItem ShareInfo { get; set; }

			public class ShareInfoItem
			{
				[JsonPropertyName("deeplink")]
				[Description("deeplink")]
				public string Deeplink { get; set; }

				[JsonPropertyName("share_command")]
				[Description("抖口令")]
				public string ShareCommand { get; set; }

				[JsonPropertyName("qrcode")]
				[Description("二维码")]
				public QrcodeItem Qrcode { get; set; }

				public class QrcodeItem
				{
					[JsonPropertyName("url")]
					[Description("图片地址")]
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

				[JsonPropertyName("share_link")]
				[Description("商品站外H5链接")]
				public string ShareLink { get; set; }
			}
		}

		[JsonPropertyName("live_info")]
		[Description("直播间信息，仅command_type为2返回该项")]
		public LiveInfoItem LiveInfo { get; set; }

		public class LiveInfoItem
		{
			[JsonPropertyName("author_buyin_id")]
			[Description("主播百应ID")]
			public string AuthorBuyinId { get; set; }

			[JsonPropertyName("product_id")]
			[Description("直播间绑定的商品ID，product_id专属于该直播间，可能已经失效")]
			public long ProductId { get; set; }

			[JsonPropertyName("share_info")]
			[Description("转链分享物料")]
			public ShareInfoItem ShareInfo { get; set; }

			public class ShareInfoItem
			{
				[JsonPropertyName("deeplink")]
				[Description("deeplink")]
				public string Deeplink { get; set; }

				[JsonPropertyName("share_command")]
				[Description("抖口令")]
				public string ShareCommand { get; set; }

				[JsonPropertyName("qrcode")]
				[Description("二维码")]
				public QrcodeItem Qrcode { get; set; }

				public class QrcodeItem
				{
					[JsonPropertyName("url")]
					[Description("图片地址")]
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

		[JsonPropertyName("live_appoint_info")]
		[Description("直播预告信息，仅command_type为3返回该项")]
		public LiveAppointInfoItem LiveAppointInfo { get; set; }

		public class LiveAppointInfoItem
		{
			[JsonPropertyName("author_buyin_id")]
			[Description("直播预告对应的达人百应ID")]
			public string AuthorBuyinId { get; set; }

			[JsonPropertyName("live_appointment_id")]
			[Description("直播预告对应的达人百应ID")]
			public string LiveAppointmentId { get; set; }

			[JsonPropertyName("share_info")]
			[Description("转链分享物料")]
			public ShareInfoItem ShareInfo { get; set; }

			public class ShareInfoItem
			{
				[JsonPropertyName("deeplink")]
				[Description("deeplink")]
				public string Deeplink { get; set; }

				[JsonPropertyName("share_command")]
				[Description("抖口令")]
				public string ShareCommand { get; set; }

				[JsonPropertyName("qrcode")]
				[Description("二维码")]
				public QrcodeItem Qrcode { get; set; }

				public class QrcodeItem
				{
					[JsonPropertyName("url")]
					[Description("图片地址")]
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

		[JsonPropertyName("activity_info")]
		[Description("活动页信息，仅command_type为4返回该项")]
		public ActivityInfoItem ActivityInfo { get; set; }

		public class ActivityInfoItem
		{
			[JsonPropertyName("material_id")]
			[Description("活动物料ID")]
			public long MaterialId { get; set; }

			[JsonPropertyName("extra_params")]
			[Description("活动页自定义参数，对应活动页转链接口的同名参数")]
			public string ExtraParams { get; set; }

			[JsonPropertyName("share_info")]
			[Description("转链分享物料")]
			public ShareInfoItem ShareInfo { get; set; }

			public class ShareInfoItem
			{
				[JsonPropertyName("deeplink")]
				[Description("deeplink")]
				public string Deeplink { get; set; }

				[JsonPropertyName("share_command")]
				[Description("抖口令")]
				public string ShareCommand { get; set; }

				[JsonPropertyName("qrcode")]
				[Description("二维码")]
				public QrcodeItem Qrcode { get; set; }

				public class QrcodeItem
				{
					[JsonPropertyName("url")]
					[Description("图片地址")]
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

		[JsonPropertyName("redpack_info")]
		[Description("抖客红包信息，仅command_type为5返回该项")]
		public RedpackInfoItem RedpackInfo { get; set; }

		public class RedpackInfoItem
		{
			[JsonPropertyName("redpack_id")]
			[Description("抖客红包ID")]
			public string RedpackId { get; set; }

			[JsonPropertyName("share_info")]
			[Description("转链分享物料")]
			public ShareInfoItem ShareInfo { get; set; }

			public class ShareInfoItem
			{
				[JsonPropertyName("deeplink")]
				[Description("deeplink")]
				public string Deeplink { get; set; }

				[JsonPropertyName("share_command")]
				[Description("抖口令")]
				public string ShareCommand { get; set; }

				[JsonPropertyName("qrcode")]
				[Description("二维码")]
				public QrcodeItem Qrcode { get; set; }

				public class QrcodeItem
				{
					[JsonPropertyName("url")]
					[Description("图片地址")]
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
	}
}
