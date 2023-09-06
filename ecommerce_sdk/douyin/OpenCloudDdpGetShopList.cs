namespace ecommerce.sdk.douyin;

[Description("获取当前绑定的店铺推送列表")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(50002,"业务处理失败","811:此App已删除或被禁用","isv.business-failed:811","请联系服务方")]
[DouyinRetCode(50002,"业务处理失败","701:RPCError{PSM:[cmp.ecom.open_captain] Method:[GetAppDetail] ErrType:[RPC_FAILED] OriginalErr:[rpc timeout: timeout=1s, to=cmp.ecom.open_captain, method=GetAppDetail, remote=[fdbd:dc02:22:299::167]:9441] BizStatusCode:[0] BizStatusMessage:[]}","isv.business-failed:701","请检查网络")]
[DouyinRetCode(50002,"业务处理失败","参数非法","isv.business-failed:602","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","函数流程错误","isv.business-failed:812","请联系服务方")]
[DouyinRetCode(50002,"业务处理失败","该用户没有操作权限","isv.business-failed:807","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","该用户没有此应用权限","isv.business-failed:808","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","该用户没有此数据库实例权限","isv.business-failed:809","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","该用户没有此店铺权限","isv.business-failed:810","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","此App已删除或被禁用","isv.business-failed:811","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","该店铺已经添加到其他数据库实例","isv.business-failed:62208201","无")]
[DouyinRetCode(50002,"业务处理失败","该店铺不存在","isv.business-failed:62208202","请检查自身请求")]
[DouyinRetCode(50002,"业务处理失败","该店铺未对此应用授权","isv.business-failed:62208203","请联系服务方")]
[DouyinRetCode(50002,"业务处理失败","无效历史推送天数","isv.business-failed:62208009","请检查自身请求")]
public class OpenCloudDdpGetShopListReq : IDouyinReq<OpenCloudDdpGetShopListRsp>
{

	public string GetMethod() { return "openCloud.ddpGetShopList"; }

	public string GetUrl() { return "/openCloud/ddpGetShopList"; }

	[JsonPropertyName("shop_id")]
	[Description("如果传了shop_id，表示单条查询")]
	public long? ShopId { get; set; }

	[JsonPropertyName("start_modified")]
	[Description("查询最后更改时间在某个时间段内的店铺，秒级时间戳")]
	public long? StartModified { get; set; }

	[JsonPropertyName("end_modified")]
	[Description("查询最后更改时间在某个时间段内的店铺，秒级时间戳")]
	public long? EndModified { get; set; }

	[JsonPropertyName("page_no")]
	[Description("当前页数，从1开始")]
	public long? PageNo { get; set; }

	[JsonPropertyName("page_size")]
	[Description("每页记录数，默认200，最大200")]
	public long? PageSize { get; set; }

	[JsonPropertyName("instance_fuzzy_name")]
	[Description("筛选数据库实例，默认不筛选")]
	public string InstanceFuzzyName { get; set; }

	[JsonPropertyName("filter_rules")]
	[Description("筛选店铺状态，默认不筛选")]
	public List<long> FilterRules { get; set; }
}

[Description("获取当前绑定的店铺推送列表")]
public class OpenCloudDdpGetShopListRsp
{
	[JsonPropertyName("total_results")]
	[Description("总个数")]
	public long TotalResults { get; set; }

	[JsonPropertyName("shops")]
	[Description("绑定推送的店铺列表")]
	public List<ShopsItem> Shops { get; set; }

	public class ShopsItem
	{
		[JsonPropertyName("last_expiration_time")]
		[Description("店铺上次过期时间")]
		public long LastExpirationTime { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺id")]
		public long ShopId { get; set; }

		[JsonPropertyName("rds_instance_id")]
		[Description("数据库实例id")]
		public string RdsInstanceId { get; set; }

		[JsonPropertyName("status")]
		[Description("状态：1-推送中、2-已停止、3-授权无效")]
		public long Status { get; set; }

		[JsonPropertyName("history_days")]
		[Description("推送的历史天数")]
		public long HistoryDays { get; set; }
	}
}
