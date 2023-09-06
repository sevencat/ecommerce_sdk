namespace ecommerce.sdk.douyin;

[Description("实时库存同步接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(20000,"系统错误","系统错误","isp.service-error:1000","请重试")]
[DouyinRetCode(40004,"非法的参数","实时库存回传请求参数校验失败","isv.parameter-invalid:14000","请检查回传的参数")]
[DouyinRetCode(40004,"非法的参数","仓库信息不存在","isv.parameter-invalid:14001","请检查回传的仓编码")]
[DouyinRetCode(40004,"非法的参数","货主信息不存在","isv.parameter-invalid:14002","请检查回传的货主编码")]
[DouyinRetCode(40004,"非法的参数","货品信息不存在","isv.parameter-invalid:14003","剔除掉不存在的货品信息")]
[DouyinRetCode(20001,"内部服务超时","同步库存失败","isp.service-timeout-error:14004","请重试")]
public class YuncRealTimeInventoryCallbackReq : IDouyinReq<YuncRealTimeInventoryCallbackRsp>
{

	public string GetMethod() { return "yunc.realTimeInventoryCallback"; }

	public string GetUrl() { return "/yunc/realTimeInventoryCallback"; }

	[JsonPropertyName("idempotent_no")]
	[Description("(字段长度: 50)幂等键本次请求的唯一键 最大50个字符")]
	[NotNull]
	public string IdempotentNo { get; set; }

	[JsonPropertyName("total_lines")]
	[Description("总行数")]
	[NotNull]
	public long? TotalLines { get; set; }

	[JsonPropertyName("current_page")]
	[Description("当前页数")]
	[NotNull]
	public long? CurrentPage { get; set; }

	[JsonPropertyName("page_size")]
	[Description("本页回传的实际总行数。 不超过100， 否则分多次回传")]
	[NotNull]
	public long? PageSize { get; set; }

	[JsonPropertyName("occur_time")]
	[Description("当前回传时间，秒级时间戳")]
	[NotNull]
	public long? OccurTime { get; set; }

	[JsonPropertyName("warehouse_code")]
	[Description("仓库编码")]
	[NotNull]
	public string WarehouseCode { get; set; }

	[JsonPropertyName("owner_code")]
	[Description("货主编码")]
	[NotNull]
	public string OwnerCode { get; set; }

	[JsonPropertyName("details")]
	[Description("货品明细")]
	[NotNull]
	public List<DetailsItem> Details { get; set; }

	public class DetailsItem
	{
		[JsonPropertyName("cargo_code")]
		[Description("货品编码")]
		[NotNull]
		public string CargoCode { get; set; }

		[JsonPropertyName("inventory_type")]
		[Description("库存类型 1-正品 2-残品")]
		[NotNull]
		public int? InventoryType { get; set; }

		[JsonPropertyName("inventory_status")]
		[Description("库存状态 1-正常")]
		[NotNull]
		public int? InventoryStatus { get; set; }

		[JsonPropertyName("total_num")]
		[Description("库存总数量 （大于等于0）")]
		[NotNull]
		public int? TotalNum { get; set; }

		[JsonPropertyName("can_use_num")]
		[Description("库存可用数量 （大于等于0）")]
		[NotNull]
		public int? CanUseNum { get; set; }
	}
}

[Description("实时库存同步接口")]
public class YuncRealTimeInventoryCallbackRsp
{
	[JsonPropertyName("code")]
	[Description("系统调用code")]
	public long Code { get; set; }

	[JsonPropertyName("msg")]
	[Description("调用接口返回的信息")]
	public string Msg { get; set; }
}
