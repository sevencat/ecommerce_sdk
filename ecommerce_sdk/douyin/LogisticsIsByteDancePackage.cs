namespace ecommerce.sdk.douyin;

[Description("判断运单是否为字节面单、抖音电商包裹")]
[DouyinRetCode(10000,"success","","","")]
[DouyinRetCode(40004,"非法的参数","参数错误","isv.parameter-invalid:11000","修改参数")]
[DouyinRetCode(50002,"业务处理失败","下游接口处理失败","isv.business-failed:11004","找研发确认")]
[DouyinRetCode(50002,"业务处理失败","手机号不存在","isv.business-failed:11009","找测试下个单")]
[DouyinRetCode(50002,"业务处理失败","系统异常","isv.business-failed:11003","无")]
[DouyinRetCode(50002,"业务处理失败","未查询到用户信息","isv.business-failed:11016","无")]
public class LogisticsIsByteDancePackageReq : IDouyinReq<LogisticsIsByteDancePackageRsp>
{

	public string GetMethod() { return "logistics.isByteDancePackage"; }

	public string GetUrl() { return "/logistics/isByteDancePackage"; }

	[JsonPropertyName("waybillCode")]
	[Description("运单号")]
	[NotNull]
	public string WaybillCode { get; set; }

	[JsonPropertyName("expressCompany")]
	[Description("快递服务商编码（联调时提供枚举）")]
	[NotNull]
	public string ExpressCompany { get; set; }

	[JsonPropertyName("bizType")]
	[Description("业务场景（联调时提供枚举）")]
	public string BizType { get; set; }
}

[Description("判断运单是否为字节面单、抖音电商包裹")]
public class LogisticsIsByteDancePackageRsp
{
	[JsonPropertyName("isBytedanceWaybill")]
	[Description("是否是字节包裹（1 - 是；2 - 否）")]
	public string IsBytedanceWaybill { get; set; }

	[JsonPropertyName("isBytedanceDec")]
	[Description("是否是字节面单（1 - 是；2 - 否）")]
	public string IsBytedanceDec { get; set; }

	[JsonPropertyName("sender")]
	[Description("寄件人信息")]
	public SenderItem Sender { get; set; }

	public class SenderItem
	{
		[JsonPropertyName("name")]
		[Description("姓名")]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("手机号")]
		public string Mobile { get; set; }

		[JsonPropertyName("isVirtualNo")]
		[Description("是否为虚拟号（1 - 是；2 - 否）")]
		public string IsVirtualNo { get; set; }

		[JsonPropertyName("virtualNo")]
		[Description("虚拟号")]
		public string VirtualNo { get; set; }

		[JsonPropertyName("virtualStatus")]
		[Description("虚拟号状态（1 - 有效；2 - 失效）")]
		public string VirtualStatus { get; set; }

		[JsonPropertyName("authFlag")]
		[Description("是否授权（1 - 是；2 - 否）")]
		public string AuthFlag { get; set; }

		[JsonPropertyName("authStartTime")]
		[Description("授权开始时间")]
		public string AuthStartTime { get; set; }

		[JsonPropertyName("authEndTime")]
		[Description("授权结束时间")]
		public string AuthEndTime { get; set; }
	}

	[JsonPropertyName("receiver")]
	[Description("收件人信息")]
	public ReceiverItem Receiver { get; set; }

	public class ReceiverItem
	{
		[JsonPropertyName("name")]
		[Description("姓名")]
		public string Name { get; set; }

		[JsonPropertyName("mobile")]
		[Description("手机号")]
		public string Mobile { get; set; }

		[JsonPropertyName("isVirtualNo")]
		[Description("是否为虚拟号（1 - 是；2 - 否）")]
		public string IsVirtualNo { get; set; }

		[JsonPropertyName("virtualNo")]
		[Description("虚拟号")]
		public string VirtualNo { get; set; }

		[JsonPropertyName("virtualStatus")]
		[Description("虚拟号状态（1 - 有效；2 - 失效）")]
		public string VirtualStatus { get; set; }

		[JsonPropertyName("authFlag")]
		[Description("是否授权（1 - 是；2 - 否）")]
		public string AuthFlag { get; set; }

		[JsonPropertyName("authStartTime")]
		[Description("授权开始时间")]
		public string AuthStartTime { get; set; }

		[JsonPropertyName("authEndTime")]
		[Description("授权结束时间")]
		public string AuthEndTime { get; set; }
	}

	[JsonPropertyName("privacyFlag")]
	[Description("是否为隐私面单（1 - 是；2 - 否）")]
	public string PrivacyFlag { get; set; }
}
