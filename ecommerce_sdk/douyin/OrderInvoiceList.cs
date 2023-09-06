namespace ecommerce.sdk.douyin;

[Description("查看商家开票列表,查看商家开票列表，支持订单号、开票状态、订单状态、开票申请创建开始时间、开票申请创建结束时间筛选")]
public class OrderInvoiceListReq : IDouyinReq<OrderInvoiceListRsp>
{

	public string GetMethod() { return "order.invoiceList"; }

	public string GetUrl() { return "/order/invoiceList"; }

	[JsonPropertyName("order_id")]
	[Description("父订单ID")]
	public string OrderId { get; set; }

	[JsonPropertyName("order_status")]
	[Description("订单状态，逗号分割")]
	public string OrderStatus { get; set; }

	[JsonPropertyName("start_time")]
	[Description("申请创建开始时间，时间戳，秒")]
	public long? StartTime { get; set; }

	[JsonPropertyName("end_time")]
	[Description("申请创建结束时间，时间戳，秒")]
	public long? EndTime { get; set; }

	[JsonPropertyName("status")]
	[Description("开票状态：1待开票、2已开票、3已关闭")]
	public int? Status { get; set; }

	[JsonPropertyName("page_no")]
	[Description("页数（默认为0，第一页从0开始），page_no* page_size不超过1万")]
	public int? PageNo { get; set; }

	[JsonPropertyName("page_size")]
	[Description("请求每页返回的数量，默认20，最多50")]
	public int? PageSize { get; set; }

	[JsonPropertyName("order_by")]
	[Description("默认排序规则为asc； 排序方式支持asc/desc")]
	public string OrderBy { get; set; }

	[JsonPropertyName("order_field")]
	[Description("排序规则： 创建时间排序create_time，不传默认创建时间")]
	public string OrderField { get; set; }
}

[Description("查看商家开票列表,查看商家开票列表，支持订单号、开票状态、订单状态、开票申请创建开始时间、开票申请创建结束时间筛选")]
public class OrderInvoiceListRsp
{
	[JsonPropertyName("invoice_list")]
	[Description("发票信息清单")]
	public List<InvoiceListItem> InvoiceList { get; set; }

	public class InvoiceListItem
	{
		[JsonPropertyName("registation_id")]
		[Description("开票id")]
		public string RegistationId { get; set; }

		[JsonPropertyName("shop_id")]
		[Description("店铺id")]
		public long ShopId { get; set; }

		[JsonPropertyName("shop_order_id")]
		[Description("主订单号")]
		public string ShopOrderId { get; set; }

		[JsonPropertyName("invoice_type")]
		[Description("发票种类 1-增值税普通电子")]
		public int InvoiceType { get; set; }

		[JsonPropertyName("apply_time")]
		[Description("开票申请创建时间")]
		public long ApplyTime { get; set; }

		[JsonPropertyName("invoice_status_type")]
		[Description("发票类型 1-蓝票")]
		public int InvoiceStatusType { get; set; }

		[JsonPropertyName("title_type")]
		[Description("抬头类型 1-个人；2-企业")]
		public int TitleType { get; set; }

		[JsonPropertyName("title")]
		[Description("抬头")]
		public string Title { get; set; }

		[JsonPropertyName("tax_no")]
		[Description("税号")]
		public string TaxNo { get; set; }

		[JsonPropertyName("bank_name")]
		[Description("开户银行")]
		public string BankName { get; set; }

		[JsonPropertyName("bank_no")]
		[Description("银行编号")]
		public string BankNo { get; set; }

		[JsonPropertyName("company_address")]
		[Description("企业地址")]
		public string CompanyAddress { get; set; }

		[JsonPropertyName("company_mobile")]
		[Description("企业电话")]
		public string CompanyMobile { get; set; }

		[JsonPropertyName("invoice_amount")]
		[Description("可开票金额，单位分")]
		public long InvoiceAmount { get; set; }

		[JsonPropertyName("invoice_detail")]
		[Description("开票详情")]
		public string InvoiceDetail { get; set; }

		[JsonPropertyName("invoice_status")]
		[Description("开票状态 1待开票 2开票完成 3已关闭")]
		public int InvoiceStatus { get; set; }

		[JsonPropertyName("order_status")]
		[Description("订单状态")]
		public int OrderStatus { get; set; }

		[JsonPropertyName("end_reason")]
		[Description("关闭原因枚举 1退款完成")]
		public int EndReason { get; set; }

		[JsonPropertyName("tos_url")]
		[Description("发票url，2小时失效")]
		public string TosUrl { get; set; }

		[JsonPropertyName("file_name")]
		[Description("发票文件名称")]
		public string FileName { get; set; }

		[JsonPropertyName("upload_time")]
		[Description("首次发票上传时间")]
		public long UploadTime { get; set; }

		[JsonPropertyName("end_time")]
		[Description("关闭时间")]
		public long EndTime { get; set; }

		[JsonPropertyName("latest_upload_time")]
		[Description("最新发票上传时间")]
		public long LatestUploadTime { get; set; }
	}

	[JsonPropertyName("total")]
	[Description("总数")]
	public long Total { get; set; }
}
