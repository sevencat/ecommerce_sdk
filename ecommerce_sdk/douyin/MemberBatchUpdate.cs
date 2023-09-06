namespace ecommerce.sdk.douyin;

[Description("抖店会员通服务提供了独立的会员数据更新接口，商家可调用此接口来更新抖店侧会员用户的数据")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","网络错误，请稍后再试~","isp.service-error:628145000","请稍后再试")]
[DouyinRetCode(40004,"非法的参数","参数非法","isv.parameter-invalid:628002001","请查看操作接口返回的详细错误描述，针对性的调整错误参数")]
[DouyinRetCode(50002,"业务处理失败","请求过于频繁，请稍后重试","isv.business-failed:628145015","请检查短时间内是否并发操作同账号？请检查是否和平台SPI请求并发？")]
[DouyinRetCode(40004,"非法的参数","openId非法","isv.parameter-invalid:628145003","请检查传入的open_id和token店铺ID是否有关联？确认openId是否合法？")]
[DouyinRetCode(50002,"业务处理失败","【抖店会员体系升级会员通体系】会员数据传输中，请勿更新会员数据。","isv.business-failed:628145010","等待升级完成。如有疑问，请联系商家IT或者服务商技术同学咨询")]
[DouyinRetCode(50002,"业务处理失败","抖店会员商家不允许更新用户信息","isv.business-failed:628145006","联系行业运营完成抖店会员数据升级到会员通体系")]
[DouyinRetCode(50002,"业务处理失败","用户是品牌会员，必须使用品牌唯一身份的UnionId来更新","isv.business-failed:628145036","当前是批量接口，针对品牌会员的那一行更新请传入unionId")]
[DouyinRetCode(50002,"业务处理失败","请求超时，请稍后重试","isv.business-failed:628004002","请求超时，请稍后重试")]
public class MemberBatchUpdateReq : IDouyinReq<MemberBatchUpdateRsp>
{

	public string GetMethod() { return "member.batchUpdate"; }

	public string GetUrl() { return "/member/batchUpdate"; }

	[JsonPropertyName("app_id")]
	[Description("表明外部平台")]
	[NotNull]
	public long? AppId { get; set; }

	[JsonPropertyName("member_info_list")]
	[Description("新的用户数据，数组中一次最多可更新5个用户的信息")]
	[NotNull]
	public List<MemberInfoListItem> MemberInfoList { get; set; }

	public class MemberInfoListItem
	{
		[JsonPropertyName("open_id")]
		[Description("会员对外的身份ID")]
		[NotNull]
		public string OpenId { get; set; }

		[JsonPropertyName("mobile")]
		[Description("新的手机号")]
		public string Mobile { get; set; }

		[JsonPropertyName("level")]
		[Description("新的等级")]
		public long? Level { get; set; }

		[JsonPropertyName("unbind")]
		[Description("是否解绑")]
		public bool? Unbind { get; set; }

		[JsonPropertyName("integral")]
		[Description("已废弃，仅支持存量历史商家】用户最新积分，正数表示法。如果有小数或者负数诉求的必须对接PointCent字段。新商家考虑扩展性，都建议对接PointCent。PointCent设置值时，优先级比Integral高")]
		public long? Integral { get; set; }

		[JsonPropertyName("pointCent")]
		[Description("【推荐】用户最新积分，分表示法，会乘以100放大，目前最多支持两位小数，同时也支持负数，PointCent=100表示1积分，PointCent=-111表示-1.11积分")]
		public long? PointCent { get; set; }

		[JsonPropertyName("union_id")]
		[Description("【仅品牌会员通商家设置】品牌会员的union_id，可此以此来标识某一个用户。（商家在抖店企业版配置同品牌跨店互通配置）")]
		public string UnionId { get; set; }
	}
}

[Description("抖店会员通服务提供了独立的会员数据更新接口，商家可调用此接口来更新抖店侧会员用户的数据")]
public class MemberBatchUpdateRsp
{
}
