namespace ecommerce.sdk.douyin;

[Description("电商云批量上报订单安全事件接口")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数不正确","isv.parameter-invalid:602","请检查入参")]
[DouyinRetCode(20000,"系统错误","100:服务器错误","isp.service-error:100","重试")]
public class SecurityBatchReportOrderSecurityEventReq : IDouyinReq<SecurityBatchReportOrderSecurityEventRsp>
{

	public string GetMethod() { return "security.batchReportOrderSecurityEvent"; }

	public string GetUrl() { return "/security/batchReportOrderSecurityEvent"; }

	[JsonPropertyName("event_type")]
	[Description("订单事件类型 1:订单访问事件, 2:订单流出事件")]
	[NotNull]
	public int? EventType { get; set; }

	[JsonPropertyName("events")]
	[Description("订单事件列表")]
	[NotNull]
	public List<EventsItem> Events { get; set; }

	public class EventsItem
	{
		[JsonPropertyName("event_id")]
		[Description("HTTP 请求头里的 doudian-event-id 对应的值")]
		[NotNull]
		public string EventId { get; set; }

		[JsonPropertyName("account_id")]
		[Description("商户的账户ID，每个ISV下需要保证唯一。独立生成的账户唯一标识")]
		[NotNull]
		public string AccountId { get; set; }

		[JsonPropertyName("account_type")]
		[Description("main_account 服务商账号体系中的主账号、子账号 main_account/sub_account")]
		[NotNull]
		public string AccountType { get; set; }

		[JsonPropertyName("order_related_shop_id")]
		[Description("orderIds 实际归属的店铺id")]
		[NotNull]
		public string OrderRelatedShopId { get; set; }

		[JsonPropertyName("shop_ids")]
		[Description("选填 ，account_id 关联的店铺 ID 列表")]
		public List<string> ShopIds { get; set; }

		[JsonPropertyName("order_ids")]
		[Description("订单 ids, 单次最大数量 50, 超过 50 需分批上传")]
		[NotNull]
		public List<string> OrderIds { get; set; }

		[JsonPropertyName("operation_type")]
		[Description("操作类型.支持操作类型:      1:view_order (查看订单)      2:view_order_list (查看订单列表)      3:download_order (下载订单)      4:download_order_list (下载订单列表)      5:print_order (打印订单)      6:print_order_list (打印订单列表)      7:export_order (导出订单)      8:export_order_list (导出订单列表)      9:delete_order (删除订单)")]
		[NotNull]
		public int? OperationType { get; set; }

		[JsonPropertyName("operate_time")]
		[Description("精确到秒的操作时间戳，格林威治时间，如1522555200")]
		[NotNull]
		public string OperateTime { get; set; }

		[JsonPropertyName("url")]
		[Description("isv请求url")]
		[NotNull]
		public string Url { get; set; }

		[JsonPropertyName("ip")]
		[Description("客户端IP，须为用户操作时真实客户端外网IP 若使用SLB，客户端IP添加在HTTP请求的X-Forwarded-For末尾；若使用CWAF，客户端IP放在 X-Real-Ip 属性")]
		[NotNull]
		public string Ip { get; set; }

		[JsonPropertyName("mac")]
		[Description("登录设备的mac地址")]
		public string Mac { get; set; }

		[JsonPropertyName("identify_info_list")]
		[Description("对外发送的订单信息明细格式 场景:商家来调解密接口，同时解密接口里面包含了敏感信息")]
		[NotNull]
		public List<IdentifyInfoListItem> IdentifyInfoList { get; set; }

		public class IdentifyInfoListItem
		{
			[JsonPropertyName("name")]
			[Description("代表订单某个信息的字段名 (可直接取抖店开放平台返回的订单信息中的字段名)")]
			[NotNull]
			public string Name { get; set; }

			[JsonPropertyName("encrypted")]
			[Description("代表此字段在发送给第三方时是否为加密状态")]
			[NotNull]
			public bool? Encrypted { get; set; }
		}

		[JsonPropertyName("device_type")]
		[Description("iOS / Android / Windows	商户在什么设备上使用 ISV 的软件")]
		public string DeviceType { get; set; }

		[JsonPropertyName("device_id")]
		[Description("设备id，标识唯一设备")]
		public string DeviceId { get; set; }

		[JsonPropertyName("referer")]
		[Description("HTTP 请求头里referer对应的值,参考链接")]
		[NotNull]
		public string Referer { get; set; }

		[JsonPropertyName("user_agent")]
		[Description("HTTP 请求头里的 userAgent对应的值")]
		public string UserAgent { get; set; }

		[JsonPropertyName("purchase_product_info_list")]
		[Description("采购商品信息")]
		public List<PurchaseProductInfoListItem> PurchaseProductInfoList { get; set; }

		public class PurchaseProductInfoListItem
		{
			[JsonPropertyName("purchase_platform_type")]
			[Description("采购平台，枚举值如下：1、拼多多，2、淘宝，3、1688，4、其他，5、淘特，6、天猫，7、京东，8、快手，9、小红书，10、得物，11、苏宁，12、抖音")]
			public int? PurchasePlatformType { get; set; }

			[JsonPropertyName("purchase_product_url")]
			[Description("采购商品链接")]
			public string PurchaseProductUrl { get; set; }

			[JsonPropertyName("external_purchaser_id")]
			[Description("采购人id（外部）")]
			public string ExternalPurchaserId { get; set; }

			[JsonPropertyName("product_name")]
			[Description("本平台订单的商品名称")]
			public string ProductName { get; set; }
		}
	}
}

[Description("电商云批量上报订单安全事件接口")]
public class SecurityBatchReportOrderSecurityEventRsp
{
	[Description("错误信息")]
	public CustomErrorItem CustomError { get; set; }

	public class CustomErrorItem
	{
		[Description("错误码")]
		public long ErrNo { get; set; }

		[Description("错误原因")]
		public string ErrMsg { get; set; }
	}
}
