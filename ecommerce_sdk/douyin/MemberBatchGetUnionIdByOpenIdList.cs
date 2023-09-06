namespace ecommerce.sdk.douyin;

[Description("会员open_id转union_id；")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","-100001:请求参数非法","isv.business-failed:-100001","检查接口请求参数是否有误")]
[DouyinRetCode(20000,"系统错误","-100002:网络错误","isp.service-error:-100002","请稍后重试")]
[DouyinRetCode(50002,"业务处理失败","628002001:会员店铺不存在","isv.business-failed:628002001","请检查自用型应用的店铺是否开通了会员通功能")]
[DouyinRetCode(50002,"业务处理失败","628145000:网络错误，请稍后再试~","isv.business-failed:628145000","请稍后重试")]
public class MemberBatchGetUnionIdByOpenIdListReq : IDouyinReq<MemberBatchGetUnionIdByOpenIdListRsp>
{

	public string GetMethod() { return "member.batchGetUnionIdByOpenIdList"; }

	public string GetUrl() { return "/member/batchGetUnionIdByOpenIdList"; }

	[JsonPropertyName("app_id")]
	[Description("表明外部平台")]
	[NotNull]
	public long? AppId { get; set; }

	[JsonPropertyName("open_id_list")]
	[Description("会员对外的OpenID列表")]
	[NotNull]
	public List<string> OpenIdList { get; set; }
}

[Description("会员open_id转union_id；")]
public class MemberBatchGetUnionIdByOpenIdListRsp
{
	[JsonPropertyName("union_id_info")]
	[Description("返回传入的OpenID对应的UnionID,map中的key是请求的OpenId，value是OpenId对应的UnionId")]
	public Dictionary<string,string> UnionIdInfo { get; set; }
}
