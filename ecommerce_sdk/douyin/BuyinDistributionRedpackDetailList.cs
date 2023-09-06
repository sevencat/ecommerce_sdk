namespace ecommerce.sdk.douyin;

[Description("该接口用于查询达人抖客红包详情，需要获取抖客授权")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数校验失败","isv.parameter-invalid:4097","参数校验失败")]
[DouyinRetCode(20000,"系统错误","服务打瞌睡了，请稍后再试","isp.service-error:256","服务打瞌睡了，请稍后再试")]
[DouyinRetCode(40004,"非法的参数","当前抖客未开通直播间分销业务权限","isv.parameter-invalid:4113","当前抖客未开通直播间分销业务权限")]
[DouyinRetCode(40004,"非法的参数","参数校验失败: 无效分页大小","isv.parameter-invalid:4127","参数校验失败: 无效分页大小")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：达人百应id无效","isv.parameter-invalid:4296","参数校验失败：达人百应id无效")]
[DouyinRetCode(40004,"非法的参数","参数校验失败：日期无效","isv.parameter-invalid:4297","参数校验失败：日期无效")]
[DouyinRetCode(40004,"非法的参数","红包参数校验失败","isv.parameter-invalid:4298","红包参数校验失败")]
public class BuyinDistributionRedpackDetailListReq : IDouyinReq<BuyinDistributionRedpackDetailListRsp>
{

	public string GetMethod() { return "buyin.distributionRedpackDetailList"; }

	public string GetUrl() { return "/buyin/distributionRedpackDetailList"; }

	[JsonPropertyName("buyin_id")]
	[Description("查询达人的百应ID")]
	[NotNull]
	public string BuyinId { get; set; }

	[JsonPropertyName("page")]
	[Description("起始值为1，不传默认值为1")]
	public long? Page { get; set; }

	[JsonPropertyName("page_size")]
	[Description("最大值20，不传默认值为10")]
	public long? PageSize { get; set; }

	[JsonPropertyName("redpack_name")]
	[Description("红包名称")]
	public string RedpackName { get; set; }

	[JsonPropertyName("start_date")]
	[Description("投放开始日期，格式2006-01-02")]
	public string StartDate { get; set; }

	[JsonPropertyName("end_date")]
	[Description("投放结束日期，格式2006-01-02")]
	public string EndDate { get; set; }
}

[Description("该接口用于查询达人抖客红包详情，需要获取抖客授权")]
public class BuyinDistributionRedpackDetailListRsp
{
	[JsonPropertyName("redpack_list")]
	[Description("红包信息")]
	public List<RedpackListItem> RedpackList { get; set; }

	public class RedpackListItem
	{
		[JsonPropertyName("redpack_id")]
		[Description("123456789")]
		public string RedpackId { get; set; }

		[JsonPropertyName("name")]
		[Description("红包名称")]
		public string Name { get; set; }

		[JsonPropertyName("credit_type")]
		[Description("红包面额类型")]
		public int CreditType { get; set; }

		[JsonPropertyName("left_amount")]
		[Description("剩余金额，单位分")]
		public long LeftAmount { get; set; }

		[JsonPropertyName("left_num")]
		[Description("剩余个数")]
		public long LeftNum { get; set; }

		[JsonPropertyName("start_apply_time")]
		[Description("领取开始有效时间")]
		public string StartApplyTime { get; set; }

		[JsonPropertyName("end_apply_time")]
		[Description("领取结束有效时间")]
		public string EndApplyTime { get; set; }

		[JsonPropertyName("use_start_time")]
		[Description("用户使用开始有效时间")]
		public string UseStartTime { get; set; }

		[JsonPropertyName("use_end_time")]
		[Description("用户使用结束使用有效时间")]
		public string UseEndTime { get; set; }

		[JsonPropertyName("status")]
		[Description("1:未生效，待投放；2:生效中；3:已领完；4:已过期")]
		public int Status { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
