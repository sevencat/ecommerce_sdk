namespace ecommerce.sdk.douyin;

[Description("【会员通商家】批量获取会员信息,注1：用户如果当前不是店铺会员，将无法获取会员信息,注2：[OpenIdList]长度不能大于10,注3：若用户满足接口调用当天店铺/品牌下90天内有支付单条件，则返回明文手机号，否则仅返回加密手机号，不返回明文手机号")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","网络错误，请稍后再试~","isp.service-error:628145000","请稍后重试")]
[DouyinRetCode(40004,"非法的参数","[OpenIdList]长度不能大于10","isv.parameter-invalid:628002001","请检查请求的入参")]
[DouyinRetCode(60000,"触发限流，请稍后重试","请求过于频繁","isp.traffic-limited:628002006","请求过于频繁，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","商家未开通会员体系","isv.business-failed:628005200","请商家联系产运开通会员体系")]
[DouyinRetCode(50002,"业务处理失败","非会员通店铺不支持获取会员信息","isv.business-failed:628145011","请商家联系产运开通会员通")]
[DouyinRetCode(40004,"非法的参数","openId非法","isv.parameter-invalid:628145003","请检查openId是否填写正确或者是否是本店铺用户")]
[DouyinRetCode(50002,"业务处理失败","用户不是当前店铺的会员","isv.business-failed:628145004","引导用户加入成为本店铺的会员")]
[DouyinRetCode(50002,"业务处理失败","会员信息错误","isv.business-failed:628145012","请更新会员数据")]
[DouyinRetCode(50002,"业务处理失败","店铺未绑定会员通应用","isv.business-failed:628145008","请绑定会员通应用")]
public class MemberMGetMemberInfoByOpenIdListReq : IDouyinReq<MemberMGetMemberInfoByOpenIdListRsp>
{

	public string GetMethod() { return "member.mGetMemberInfoByOpenIdList"; }

	public string GetUrl() { return "/member/mGetMemberInfoByOpenIdList"; }

	[JsonPropertyName("app_id")]
	[Description("表明外部平台")]
	[NotNull]
	public long? AppId { get; set; }

	[JsonPropertyName("open_id_list")]
	[Description("会员对外的OpenID列表")]
	[NotNull]
	public List<string> OpenIdList { get; set; }
}

[Description("【会员通商家】批量获取会员信息,注1：用户如果当前不是店铺会员，将无法获取会员信息,注2：[OpenIdList]长度不能大于10,注3：若用户满足接口调用当天店铺/品牌下90天内有支付单条件，则返回明文手机号，否则仅返回加密手机号，不返回明文手机号")]
public class MemberMGetMemberInfoByOpenIdListRsp
{
	[JsonPropertyName("member_infos")]
	[Description("获取到的会员信息列表")]
	public List<MemberInfosItem> MemberInfos { get; set; }

	public class MemberInfosItem
	{
		[JsonPropertyName("success")]
		[Description("true表示对应的openId获取会员数据成功；false表示获取失败")]
		public bool Success { get; set; }

		[JsonPropertyName("open_id")]
		[Description("请求中的一个openId")]
		public string OpenId { get; set; }

		[JsonPropertyName("mobile")]
		[Description("会员明文手机号，需满足90天内有支付单条件")]
		public string Mobile { get; set; }

		[JsonPropertyName("err_code")]
		[Description("success=false时，返回的错误码")]
		public int ErrCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("success=false时，返回的错误描述")]
		public string ErrMsg { get; set; }

		[JsonPropertyName("union_id")]
		[Description("用户升级品牌会员后返回，其他情况下为空")]
		public string UnionId { get; set; }

		[JsonPropertyName("level")]
		[Description("用户当前等级")]
		public long Level { get; set; }

		[JsonPropertyName("point_cent")]
		[Description("用户最新积分，使用分表示法的积分整数值，比如pointCent =100表示1积分，pointCent =-111表示-1.11积分。")]
		public long PointCent { get; set; }

		[JsonPropertyName("mix_mobile")]
		[Description("返回用户加密手机号")]
		public string MixMobile { get; set; }

		[JsonPropertyName("extend")]
		[Description("额外信息，备用")]
		public string Extend { get; set; }
	}
}
