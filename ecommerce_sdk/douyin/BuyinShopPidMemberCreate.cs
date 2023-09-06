namespace ecommerce.sdk.douyin;

[Description("本接口服务于商家会员绑定指定人店一体主账号PID，可以通过接口获取所需的二维码和跳转链接")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","检查参数是否正确")]
[DouyinRetCode(40004,"非法的参数","会员绑定有效期必须大于30天","isv.parameter-invalid:4103","检查参数是否正确")]
[DouyinRetCode(50002,"业务处理失败","当前机构或商家尚未开通分销权限","isv.business-failed:4105","当前机构或商家尚未开通分销权限")]
[DouyinRetCode(50002,"业务处理失败","当前商家暂未开通会员","isv.business-failed:4106","当前商家暂未开通会员")]
[DouyinRetCode(50002,"业务处理失败","未知错误","isv.business-failed:255","未知错误")]
[DouyinRetCode(50002,"业务处理失败","当前商家未绑定人店一体官方账号","isv.business-failed:4107","当前商家未绑定人店一体官方账号")]
[DouyinRetCode(40004,"非法的参数","当前pid非此店铺绑定官方达人所创建","isv.parameter-invalid:4108","当前pid非此店铺绑定官方达人所创建")]
[DouyinRetCode(40004,"非法的参数","无效 PID","isv.parameter-invalid:4102","参数校验失败：无效 PID")]
[DouyinRetCode(40004,"非法的参数","无效 external_info","isv.parameter-invalid:4101","参数校验失败：无效 external_info")]
public class BuyinShopPidMemberCreateReq : IDouyinReq<BuyinShopPidMemberCreateRsp>
{

	public string GetMethod() { return "buyin.shopPidMemberCreate"; }

	public string GetUrl() { return "/buyin/shopPidMemberCreate"; }

	[JsonPropertyName("pid")]
	[Description("人店一体达人PID")]
	[NotNull]
	public string Pid { get; set; }

	[JsonPropertyName("member_available_time")]
	[Description("会员绑定有效天数，至少30天")]
	[NotNull]
	public long? MemberAvailableTime { get; set; }

	[JsonPropertyName("external_info")]
	[Description("自定义字段，只允许 数字、字母和_，限制长度为40")]
	public string ExternalInfo { get; set; }
}

[Description("本接口服务于商家会员绑定指定人店一体主账号PID，可以通过接口获取所需的二维码和跳转链接")]
public class BuyinShopPidMemberCreateRsp
{
	[JsonPropertyName("qrcode")]
	[Description("入会二维码")]
	public string Qrcode { get; set; }

	[JsonPropertyName("member_join_url")]
	[Description("入会跳转URL")]
	public string MemberJoinUrl { get; set; }
}
