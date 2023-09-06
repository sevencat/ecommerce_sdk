namespace ecommerce.sdk.douyin;

[Description("该接口可以根据店铺会员的openId获取品牌维度的用户身份标识unionId。同品牌下跨店铺中存量的抖音会员，可以用这个接口查询unionId，相同的unionId表示是同一个用户。,注1：店铺如果不是品牌店铺，将无法获取unionId,注2：用户如果不是店铺会员，将无法获取unionId,注3：【重要】即使查询返回unionId，不代表用户是品牌会员")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","网络错误，请稍后再试~","isp.service-error:628145000","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","非品牌会员店铺不支持获取UnionId","isv.business-failed:628145001","品牌方到抖店企业版中圈选本店铺为品牌店铺")]
[DouyinRetCode(50002,"业务处理失败","非会员通店铺不支持获取UnionId","isv.business-failed:628145002","请联系平台运营提报并开通会员通体系")]
[DouyinRetCode(40004,"非法的参数","openId非法","isv.parameter-invalid:628145003","请检查openId是否填写正确或者是否是本店铺用户")]
[DouyinRetCode(50002,"业务处理失败","用户不是当前店铺的会员","isv.business-failed:628145004","用户加入成为本店铺的会员")]
[DouyinRetCode(40004,"非法的参数","参数非法","isv.parameter-invalid:628002001","请检查请求的入参")]
[DouyinRetCode(60000,"触发限流，请稍后重试","请求过于频繁","isp.traffic-limited:628002006","请求过于频繁，请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","商家未开通会员体系","isv.business-failed:628005200","请商家联系产运开通会员体系")]
public class MemberBatchGetHistoryMemberUnionIdReq : IDouyinReq<MemberBatchGetHistoryMemberUnionIdRsp>
{

	public string GetMethod() { return "member.batchGetHistoryMemberUnionId"; }

	public string GetUrl() { return "/member/batchGetHistoryMemberUnionId"; }

	[JsonPropertyName("app_id")]
	[Description("表明外部平台")]
	[NotNull]
	public long? AppId { get; set; }

	[JsonPropertyName("open_id_list")]
	[Description("会员对外的OpenID列表，该接口一次最多进行20个Openld的解析")]
	[NotNull]
	public List<string> OpenIdList { get; set; }
}

[Description("该接口可以根据店铺会员的openId获取品牌维度的用户身份标识unionId。同品牌下跨店铺中存量的抖音会员，可以用这个接口查询unionId，相同的unionId表示是同一个用户。,注1：店铺如果不是品牌店铺，将无法获取unionId,注2：用户如果不是店铺会员，将无法获取unionId,注3：【重要】即使查询返回unionId，不代表用户是品牌会员")]
public class MemberBatchGetHistoryMemberUnionIdRsp
{
	[JsonPropertyName("union_id_infos")]
	[Description("获取到的unionId列表")]
	public List<UnionIdInfosItem> UnionIdInfos { get; set; }

	public class UnionIdInfosItem
	{
		[JsonPropertyName("success")]
		[Description("true表示对应的openId获取unionId成功；false表示获取失败")]
		public bool Success { get; set; }

		[JsonPropertyName("open_id")]
		[Description("请求中的一个openId")]
		public string OpenId { get; set; }

		[JsonPropertyName("union_id")]
		[Description("success=true时，返回获取到unionId")]
		public string UnionId { get; set; }

		[JsonPropertyName("err_code")]
		[Description("success=false时，返回的错误码")]
		public int ErrCode { get; set; }

		[JsonPropertyName("err_msg")]
		[Description("success=false时，返回的错误描述")]
		public string ErrMsg { get; set; }
	}
}
