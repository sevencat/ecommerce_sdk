namespace ecommerce.sdk.douyin;

[Description("支持抖客进行商品转链，写入PID，获取专属商品抖口令、抖音码、deeplink和zlink，需要授权。")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","无效 external_info","isv.parameter-invalid:4101","无效 external_info")]
[DouyinRetCode(50002,"业务处理失败","当前商品暂不支持站外分享","isv.business-failed:4104","当前商品暂不支持站外分享")]
[DouyinRetCode(50002,"业务处理失败","商家已设置该商品仅指定作者可推广，请您更换其他商品","isv.business-failed:1025","商家已设置该商品仅指定作者可推广，请您更换其他商品")]
[DouyinRetCode(50002,"业务处理失败","没有电商橱窗权限","isv.business-failed:4346","没有电商橱窗权限")]
[DouyinRetCode(40004,"非法的参数","无效商品URL","isv.parameter-invalid:4134","无效商品URL")]
[DouyinRetCode(50002,"业务处理失败","当前商品推广未开启，请更换商品推广","isv.business-failed:4354","当前商品推广未开启，请更换商品推广")]
[DouyinRetCode(50002,"业务处理失败","获取用户客户端账户信息失败","isv.business-failed:4126","获取用户客户端账户信息失败")]
[DouyinRetCode(50002,"业务处理失败","商品已下架","isv.business-failed:4133","商品已下架")]
[DouyinRetCode(20000,"系统错误","未知错误","isp.service-error:255","未知错误")]
[DouyinRetCode(20000,"系统错误","获取账户权限失败","isp.service-error:4353","获取账户权限失败")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(50002,"业务处理失败","二级团长活动商品暂不支持分销","isv.business-failed:1102","二级团长活动商品暂不支持分销")]
[DouyinRetCode(50002,"业务处理失败","商品为平台测试商品，暂不支持添加推广","isv.business-failed:4360","商品为平台测试商品，暂不支持添加推广")]
[DouyinRetCode(50002,"业务处理失败","当前达人没有商品分销功能权限","isv.business-failed:4111","当前达人没有商品分销功能权限")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(40004,"非法的参数","商品不存在","isv.parameter-invalid:4349","商品不存在")]
[DouyinRetCode(40004,"非法的参数","无效商品口令","isv.parameter-invalid:4148","无效商品口令")]
[DouyinRetCode(50002,"业务处理失败","该类目商品仅平台指定达人可以绑定，请选择其他商品","isv.business-failed:4613","该类目商品仅平台指定达人可以绑定，请选择其他商品")]
[DouyinRetCode(50002,"业务处理失败","您未开通联盟收款账户，暂不支持推广，请前往移动端商品橱窗-常用服务-升级账户处进行开户设置","isv.business-failed:4601","您未开通联盟收款账户，暂不支持推广，请前往移动端商品橱窗-常用服务-升级账户处进行开户设置")]
[DouyinRetCode(50002,"业务处理失败","推广海淘商品，需要开通海淘收款账户。请前往移动端商品橱窗-常用服务-升级账户处进行开户设置","isv.business-failed:4611","推广海淘商品，需要开通海淘收款账户。请前往移动端商品橱窗-常用服务-升级账户处进行开户设置")]
[DouyinRetCode(50002,"业务处理失败","橱窗仅管理/展示非自卖的带货商品，自卖商品在店铺展示，请到抖店管理。如需个人主页展示店铺，请到PC抖店-店铺-店铺设置-店铺官方账号，选择主推店铺。","isv.business-failed:4617","橱窗仅管理/展示非自卖的带货商品，自卖商品在店铺展示，请到抖店管理。如需个人主页展示店铺，请到PC抖店-店铺-店铺设置-店铺官方账号，选择主推店铺。")]
[DouyinRetCode(50002,"业务处理失败","您推广的商品为海淘商品，当前展示佣金仅为预估参考，最终佣金收入将根据打款时刻汇率折算，请以实际到账为准","isv.business-failed:4607","您推广的商品为海淘商品，当前展示佣金仅为预估参考，最终佣金收入将根据打款时刻汇率折算，请以实际到账为准")]
[DouyinRetCode(50002,"业务处理失败","请通过商品橱窗-常用服务-升级账户开通正式账户后可继续带货","isv.business-failed:-18988","请通过商品橱窗-常用服务-升级账户开通正式账户后可继续带货")]
[DouyinRetCode(50002,"业务处理失败","您已提交过资质认证，收款账户还未开通完成，开通完成后可添加商品，请前往移动端商品橱窗-常用服务-升级账户完成开通","isv.business-failed:4609","您已提交过资质认证，收款账户还未开通完成，开通完成后可添加商品，请前往移动端商品橱窗-常用服务-升级账户完成开通")]
[DouyinRetCode(50002,"业务处理失败","亲爱的用户，因服务器升级，商品展示可能异常，带来不便，敬请见谅。","isv.business-failed:8193","亲爱的用户，因服务器升级，商品展示可能异常，带来不便，敬请见谅。")]
[DouyinRetCode(50002,"业务处理失败","添加当前商品，请在抖音APP开通聚合账户，完成微信提交开户申请。","isv.business-failed:4627","添加当前商品，请在抖音APP开通聚合账户，完成微信提交开户申请")]
[DouyinRetCode(50002,"业务处理失败","添加当前商品，请在抖音APP完成微信提交开户申请。","isv.business-failed:4629","添加当前商品，请在抖音APP完成微信提交开户申请")]
[DouyinRetCode(50002,"业务处理失败","该商品正在参加平台官方补贴，将享有更多曝光机会，但暂不支持挂车；如有疑问请在【超值购】沟通群联系工作人员或咨询达人客服","isv.business-failed:4128","该商品正在参加平台官方补贴，将享有更多曝光机会，但暂不支持挂车；如有疑问请在【超值购】沟通群联系工作人员或咨询达人客服")]
[DouyinRetCode(50002,"业务处理失败","商家已开启「需要佣金发票」，且你目前带货资质为个人资质，需完成以下两步才可推广该商品:1、升级为个体户或企业资质；2、修改发票设置为「支持开具佣金发票」","isv.business-failed:4131","商家已开启「需要佣金发票」，且你目前带货资质为个人资质，需完成以下两步才可推广该商品:1、升级为个体户或企业资质；2、修改发票设置为「支持开具佣金发票」")]
[DouyinRetCode(50002,"业务处理失败","商品属于风险类目，不可转链分享","isv.business-failed:4115","商品属于风险类目，不可转链分享")]
[DouyinRetCode(50002,"业务处理失败","商品没有加入精选联盟","isv.business-failed:4132","商品没有加入精选联盟")]
[DouyinRetCode(50002,"业务处理失败","添加当前商品，请在抖音APP-商品橱窗-账户升级，开通聚合账户。","isv.business-failed:4630","添加当前商品，请在抖音APP-商品橱窗-账户升级，开通聚合账户。")]
[DouyinRetCode(50002,"业务处理失败","添加当前商品，请在抖音APP-商品橱窗-账户升级，开通支付宝账户。","isv.business-failed:4624","添加当前商品，请在抖音APP-商品橱窗-账户升级，开通支付宝账户。")]
[DouyinRetCode(40004,"非法的参数","回流平台参数非法","isv.parameter-invalid:4122","回流平台参数非法")]
[DouyinRetCode(50002,"业务处理失败","商家已设置该商品仅指定作者可推广，请您更换其他商品","isv.business-failed:4618","商家已设置该商品仅指定作者可推广，请您更换其他商品")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：无效 PID","isv.parameter-invalid:4102","参数校验失败：无效 PID")]
[DouyinRetCode(50002,"业务处理失败","商家已设置该商品仅指定作者可推广，请您更换其他商品","isv.business-failed:515","商家已设置该商品仅指定作者可推广，请您更换其他商品")]
[DouyinRetCode(50002,"业务处理失败","商品所属的类目不支持推广，请添加其他类目商品","isv.business-failed:507","商品所属的类目不支持推广，请添加其他类目商品")]
[DouyinRetCode(50002,"业务处理失败","当前抖客尚未开通结算账户","isv.business-failed:4404","当前抖客尚未开通结算账户")]
[DouyinRetCode(50002,"业务处理失败","没有联盟推广","isv.business-failed:4399","没有联盟推广")]
[DouyinRetCode(50002,"业务处理失败","当前抖客未开通商品/活动页分销权限","isv.business-failed:4410","当前抖客未开通商品/活动页分销权限")]
[DouyinRetCode(50002,"业务处理失败","商品非上架状态","isv.business-failed:4400","商品非上架状态")]
[DouyinRetCode(50002,"业务处理失败","需开票商品暂不支持转链","isv.business-failed:4407","需开票商品暂不支持转链")]
[DouyinRetCode(50002,"业务处理失败","团长佣金查询失败，请确认参数后重试","isv.business-failed:4422","团长佣金查询失败，请确认参数后重试")]
public class BuyinKolProductShareReq : IDouyinReq<BuyinKolProductShareRsp>
{

	public string GetMethod() { return "buyin.kolProductShare"; }

	public string GetUrl() { return "/buyin/kolProductShare"; }

	[JsonPropertyName("product_url")]
	[Description("商品URL/口令/短链接")]
	[NotNull]
	public string ProductUrl { get; set; }

	[JsonPropertyName("pid")]
	[Description("抖客PID")]
	[NotNull]
	public string Pid { get; set; }

	[JsonPropertyName("external_info")]
	[Description("自定义字段，只允许 数字、字母和_，限制长度为40")]
	public string ExternalInfo { get; set; }

	[JsonPropertyName("need_qr_code")]
	[Description("是否需要二维码，需要会导致响应耗时增加")]
	public bool? NeedQrCode { get; set; }

	[JsonPropertyName("platform")]
	[Description("回流端标识 0：抖音 1：抖音极速版")]
	public int? Platform { get; set; }

	[JsonPropertyName("use_coupon")]
	[Description("是否返回商品惠后价领券链接(如果商品有优惠则返回，否则不返回)")]
	public bool? UseCoupon { get; set; }

	[JsonPropertyName("need_share_link")]
	[Description("是否返回站外H5链接")]
	public bool? NeedShareLink { get; set; }

	[JsonPropertyName("ins_activity_param")]
	[Description("团长参数")]
	public string InsActivityParam { get; set; }

	[JsonPropertyName("need_zlink")]
	[Description("是否需要zlink，需要会导致响应耗时增加，不填默认返回")]
	public bool? NeedZlink { get; set; }
}

[Description("支持抖客进行商品转链，写入PID，获取专属商品抖口令、抖音码、deeplink和zlink，需要授权。")]
public class BuyinKolProductShareRsp
{
	[JsonPropertyName("data")]
	[Description("返回数据")]
	public DataItem Data { get; set; }

	public class DataItem
	{
		[JsonPropertyName("use_ins_activity")]
		[Description("1:携带，商品链接或口令是否携带了团长参数，最终佣金以订单为准")]
		public string UseInsActivity { get; set; }

		[JsonPropertyName("share_link")]
		[Description("商品站外H5链接")]
		public string ShareLink { get; set; }

		[JsonPropertyName("dy_password")]
		[Description("抖口令")]
		public string DyPassword { get; set; }

		[JsonPropertyName("qr_code")]
		[Description("二维码")]
		public QrCodeItem QrCode { get; set; }

		public class QrCodeItem
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

		[JsonPropertyName("dy_deeplink")]
		[Description("deeplink")]
		public string DyDeeplink { get; set; }

		[JsonPropertyName("dy_zlink")]
		[Description("Zlink，允许外部APP直接唤起抖音直播间，未安装抖音应用用户，唤起抖音下载页，有效期60天")]
		public string DyZlink { get; set; }

		[JsonPropertyName("coupon_link")]
		[Description("优惠价推广链接")]
		public CouponLinkItem CouponLink { get; set; }

		public class CouponLinkItem
		{
			[JsonPropertyName("coupon_status")]
			[Description("是否有优惠价&优惠券 0有优惠券 1没有优惠券")]
			public long CouponStatus { get; set; }

			[JsonPropertyName("qrcode")]
			[Description("二维码")]
			public QrcodeItem Qrcode { get; set; }

			public class QrcodeItem
			{
				[JsonPropertyName("url")]
				[Description("链接")]
				public string Url { get; set; }

				[JsonPropertyName("width")]
				[Description("宽度")]
				public int Width { get; set; }

				[JsonPropertyName("height")]
				[Description("高度")]
				public int Height { get; set; }
			}

			[JsonPropertyName("share_command")]
			[Description("口令")]
			public string ShareCommand { get; set; }

			[JsonPropertyName("deeplink")]
			[Description("deeplink")]
			public string Deeplink { get; set; }

			[JsonPropertyName("share_link")]
			[Description("站外H5领券链接")]
			public string ShareLink { get; set; }
		}
	}
}
