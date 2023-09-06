namespace ecommerce.sdk.douyin;

[Description("获取物流运单在字节电商平台的相关信息")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40002,"缺少必选参数","参数错误","isv.missing-parameter:11000","必填项校验失败、参数合法性问题")]
[DouyinRetCode(20000,"系统错误","组件异常","isp.service-error:11404","无")]
[DouyinRetCode(20000,"系统错误","内部服务异常","isp.service-error:11004","无")]
[DouyinRetCode(50002,"业务处理失败","手机号码不存在","isv.business-failed:11009","无")]
[DouyinRetCode(50002,"业务处理失败","未查询到用户信息","isv.business-failed:11016","无")]
[DouyinRetCode(50002,"业务处理失败","获取授权信息异常","isv.business-failed:11017","无")]
public class LogisticsWaybillOrderInfoQueryReq : IDouyinReq<LogisticsWaybillOrderInfoQueryRsp>
{

	public string GetMethod() { return "logistics.waybillOrderInfoQuery"; }

	public string GetUrl() { return "/logistics/waybillOrderInfoQuery"; }

	[JsonPropertyName("waybill_code")]
	[Description("快递运单号")]
	public string WaybillCode { get; set; }

	[JsonPropertyName("express_company")]
	[Description("快递承运公司")]
	public string ExpressCompany { get; set; }
}

[Description("获取物流运单在字节电商平台的相关信息")]
public class LogisticsWaybillOrderInfoQueryRsp
{
	[JsonPropertyName("is_bytedance_waybill")]
	[Description("是否为字节电商平台包裹")]
	public string IsBytedanceWaybill { get; set; }

	[JsonPropertyName("is_bytedance_dec")]
	[Description("是否字节面单")]
	public string IsBytedanceDec { get; set; }

	[JsonPropertyName("sender")]
	[Description("发件人信息")]
	public SenderItem Sender { get; set; }

	public class SenderItem
	{
		[JsonPropertyName("name")]
		[Description("脱敏姓名，保留字段，暂不传")]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("脱敏真实手机号(前三后四位)")]
		public string Mobile { get; set; }

		[JsonPropertyName("is_virtual_no")]
		[Description("是否虚拟号")]
		public string IsVirtualNo { get; set; }

		[JsonPropertyName("virtual_no")]
		[Description("虚拟号")]
		public string VirtualNo { get; set; }

		[JsonPropertyName("virtual_status")]
		[Description("虚拟号状态")]
		public string VirtualStatus { get; set; }

		[JsonPropertyName("auth_flag")]
		[Description("是否授权")]
		public string AuthFlag { get; set; }

		[JsonPropertyName("auth_start_time")]
		[Description("授权开始时间")]
		public string AuthStartTime { get; set; }

		[JsonPropertyName("auth_end_time")]
		[Description("授权结束时间")]
		public string AuthEndTime { get; set; }
	}

	[JsonPropertyName("receiver")]
	[Description("收件人信息")]
	public ReceiverItem Receiver { get; set; }

	public class ReceiverItem
	{
		[JsonPropertyName("name")]
		[Description("脱敏姓名，保留字段，暂不传")]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("脱敏真实手机号(前三后四位)")]
		public string Mobile { get; set; }

		[JsonPropertyName("is_virtual_no")]
		[Description("是否虚拟号")]
		public string IsVirtualNo { get; set; }

		[JsonPropertyName("virtual_no")]
		[Description("虚拟号")]
		public string VirtualNo { get; set; }

		[JsonPropertyName("virtual_status")]
		[Description("虚拟号状态")]
		public string VirtualStatus { get; set; }

		[JsonPropertyName("auth_flag")]
		[Description("是否授权")]
		public string AuthFlag { get; set; }

		[JsonPropertyName("auth_start_time")]
		[Description("授权开始时间")]
		public string AuthStartTime { get; set; }

		[JsonPropertyName("auth_end_time")]
		[Description("授权结束时间")]
		public string AuthEndTime { get; set; }
	}

	[JsonPropertyName("privacy_flag")]
	[Description("是否为隐私面单")]
	public string PrivacyFlag { get; set; }
}
