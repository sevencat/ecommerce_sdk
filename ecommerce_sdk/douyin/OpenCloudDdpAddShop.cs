namespace ecommerce.sdk.douyin;

[Description("数据推送，添加数据推送店铺")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","701:RPCError{PSM:[cmp.ecom.open_captain] Method:[GetAppDetail] ErrType:[RPC_FAILED] OriginalErr:[rpc timeout: timeout=1s, to=cmp.ecom.open_captain, method=GetAppDetail, remote=[fdbd:dc02:108:339::132]:9244] BizStatusCode:[0] BizStatusMessage:[]}","isv.business-failed:701","请检查网络")]
[DouyinRetCode(50002,"业务处理失败","62207001:GetAppDetailFromAppId failed","isv.business-failed:62207001","请联系服务方")]
[DouyinRetCode(50002,"业务处理失败","62208201:该店铺已经添加到其他数据库实例","isv.business-failed:62208201","无")]
[DouyinRetCode(50002,"业务处理失败","810:该用户没有此店铺权限","isv.business-failed:810","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","811:此App已删除或被禁用","isv.business-failed:811","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","参数非法","isv.business-failed:602","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","函数流程错误","isv.business-failed:812","请联系服务方")]
[DouyinRetCode(50002,"业务处理失败","该用户没有操作权限","isv.business-failed:807","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","该用户没有此应用权限","isv.business-failed:808","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","该用户没有此数据库实例权限","isv.business-failed:809","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","该用户没有此店铺权限","isv.business-failed:810","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","该店铺已经添加到其他数据库实例","isv.business-failed:62208201","无")]
[DouyinRetCode(50002,"业务处理失败","该店铺不存在","isv.business-failed:62208202","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","该店铺未对此应用授权","isv.business-failed:62208203","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","无效历史推送天数","isv.business-failed:62208009","请检查自身请求")]
public class OpenCloudDdpAddShopReq : IDouyinReq<OpenCloudDdpAddShopRsp>
{

	public string GetMethod() { return "openCloud.ddpAddShop"; }

	public string GetUrl() { return "/openCloud/ddpAddShop"; }

	[JsonPropertyName("shop_id")]
	[Description("需要添加推送的店铺ID")]
	[NotNull]
	public long? ShopId { get; set; }

	[JsonPropertyName("rds_instance_id")]
	[Description("绑定推送到的数据库InstanceID")]
	[NotNull]
	public string RdsInstanceId { get; set; }

	[JsonPropertyName("history_days")]
	[Description("历史推送天数。(0表示不推送历史数据，空表示跟随应用)")]
	public long? HistoryDays { get; set; }
}

[Description("数据推送，添加数据推送店铺")]
public class OpenCloudDdpAddShopRsp
{
}
